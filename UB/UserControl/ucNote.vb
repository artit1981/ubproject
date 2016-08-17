Option Explicit On

Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns

Public Class ucNote
    Private mNoteDAOs As List(Of NoteDAO)
    Private bindingSource1 As BindingSource

    Public Function GetNoteDAOs() As List(Of NoteDAO)
        Dim lNoteDAO As NoteDAO
        Try
            mNoteDAOs = New List(Of NoteDAO)

            If gridView.RowCount > 0 Then
                For lRow = 0 To gridView.RowCount
                    If gridView.GetRowCellDisplayText(lRow, "Description").Trim <> "" Then
                        lNoteDAO = New NoteDAO
                        lNoteDAO.ID = ConvertNullToZero(gridView.GetRowCellDisplayText(lRow, "ID"))
                        lNoteDAO.Description = gridView.GetRowCellDisplayText(lRow, "Description")
                        lNoteDAO.SEQ = gridView.GetRowCellDisplayText(lRow, "SEQ")
                        mNoteDAOs.Add(lNoteDAO)
                    End If
                Next
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucNote.GetNoteDAOs : " & e.Message)
        Finally
            lNoteDAO = Nothing
        End Try

        Return mNoteDAOs
    End Function

    Public Function ShowControl(ByVal pRefTable As String, ByVal pRefID As Long, Optional ByVal pIsAppend As Boolean = False) As Boolean
        Try
            Call LoadData(pRefTable, pRefID, pIsAppend)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucNote.ShowControl : " & e.Message)
            Return False
        End Try
    End Function

    Public Sub ClearControl()
        Try
            Call LoadData("", 0, False)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucNote.ClearAll : " & e.Message)
        End Try
    End Sub


    Private Sub LoadData(ByVal pRefTable As String, ByVal pRefID As Long, ByVal pIsAppend As Boolean)
        Dim lcls As New NoteDAO
        Dim dataTable As New DataTable()

        Try
            If pIsAppend = False Or bindingSource1 Is Nothing Then
                bindingSource1 = New BindingSource
                bindingSource1.DataSource = GetType(NoteDAO)
            End If

            dataTable = lcls.GetDataTable(pRefTable, pRefID)
            lcls = Nothing
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    lcls = New NoteDAO
                    lcls.ID = ConvertNullToZero(dr("ID"))
                    lcls.SEQ = ConvertNullToZero(dr("SEQ"))
                    lcls.Description = ConvertNullToString(dr("Description"))
                    lcls.CreateBy = ConvertNullToString(dr("CreateBy"))
                    lcls.CreateTime = dr("CreateTime")
                    lcls.RefID = ConvertNullToZero(dr("RefID"))
                    lcls.RefTable = ConvertNullToString(dr("RefTable"))
                    lcls.ModeData = ConvertNullToZero(dr("ModeData"))
                    bindingSource1.Add(lcls)
                Next
            End If

            gridControl.DataSource = bindingSource1
            Call GridStyle()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucNote.LoadData : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Private Sub GridStyle()
        With gridView
            .Columns("Description").Caption = "ข้อความ"
            .Columns("Description").Width = 400

            .Columns("CreateBy").Caption = "บันทึกล่าสุดโดย"
            .Columns("CreateBy").Width = 100

            .Columns("CreateTime").Caption = "บันทึกล่าสุดเมื่อ"
            .Columns("CreateTime").Width = 150
            .Columns("CreateTime").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom


            .Columns("ID").Visible = False
            .Columns("RefID").Visible = False
            .Columns("RefTable").Visible = False
            '.Columns("SEQ").Visible = False
            .Columns("ModeData").Visible = False

            .Columns("ModeData").FilterInfo = New ColumnFilterInfo("[ModeData]<>3")
        End With

    End Sub

    Private Sub gridView_FocusedColumnChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles gridView.FocusedColumnChanged
       ReGenSEQ
    End Sub

    Private Sub gridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gridView.CellValueChanged
        If e.Column.FieldName <> "SEQ" Then
           ReGenSEQ
        End If
    End Sub

  

    'Private Sub gridView_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
    '    If e.FocusedRowHandle >= 0 Then
    '        gridView.SetFocusedRowCellValue("SEQ", e.FocusedRowHandle + 1)
    '    Else
    '        gridView.SetFocusedRowCellValue("SEQ", 1)
    '    End If

    'End Sub

    'Private Sub gridView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gridView.InitNewRow
    '    If e.RowHandle >= 0 Then
    '        gridView.SetRowCellValue(e.RowHandle, "SEQ", e.RowHandle + 1)
    '    Else
    '        gridView.SetRowCellValue(e.RowHandle, "SEQ", 1)
    '    End If

    'End Sub

    Private Sub ReGenSEQ()
        Try
            If gridView.RowCount > 0 Then
                For lRow = 0 To gridView.RowCount
                    gridView.SetRowCellValue(lRow, "SEQ", lRow + 1)
                Next
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucNote.ReGenSEQ : " & e.Message)
        Finally
        End Try

    End Sub

    Private Sub gridView_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
        ReGenSEQ()
    End Sub
 
 

    Private Sub gridView_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles gridView.ValidatingEditor
        Dim reply As Object() = Nothing
        If gridView.FocusedColumn.FieldName = "Description" Then
            reply = IsTrueCondition(GridConditionType.NotEmpty, e.Value)
        End If

        If Not reply Is Nothing AndAlso (Not CBool(reply(0))) Then
            e.ErrorText = reply(1).ToString()
            e.Valid = False
        End If
    End Sub


    Private Sub ControlNavigator1_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles ControlNavigator1.ButtonClick
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gridView
        view.GridControl.Focus()
        Dim index As Integer = view.FocusedRowHandle
        Dim rec As New NoteDAO, rec2 As New NoteDAO
        Select Case e.Button.Tag
            Case "Insert"
                bindingSource1.Insert(index, rec)
                gridControl.DataSource = bindingSource1
                gridView.RefreshData()
                gridControl.RefreshDataSource()
            Case "Remove"
                If XtraMessageBox.Show(Me, "ยืนยันการลบข้อความ ใช่หรือไม่", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    If ConvertNullToZero(gridView.GetRowCellValue(index, "ID")) = 0 Then
                        gridView.DeleteSelectedRows()
                        gridView.RefreshData()
                        gridControl.RefreshDataSource()
                    Else
                        gridView.SetRowCellValue(index, "ModeData", 3) 'Mode delete
                        gridView.RefreshData()
                        gridControl.RefreshDataSource()
                    End If
                End If
            Case "MoveUp"
                If index > 0 Then
                    rec = bindingSource1.Item(index)
                    rec2 = bindingSource1.Item(index - 1)

                    bindingSource1.Item(index) = rec2
                    bindingSource1.Item(index - 1) = rec
                    gridView.RefreshData()
                    gridControl.RefreshDataSource()
                End If
            Case "MoveDown"
                If index < (bindingSource1.Count - 1) Then
                    rec = bindingSource1.Item(index)
                    rec2 = bindingSource1.Item(index + 1)

                    bindingSource1.Item(index) = rec2
                    bindingSource1.Item(index + 1) = rec
                    gridView.RefreshData()
                    gridControl.RefreshDataSource()
                End If

        End Select
    End Sub

    Private Sub gridView_LostFocus(sender As Object, e As System.EventArgs) Handles gridView.LostFocus
        ReGenSEQ()
    End Sub
End Class
