Option Explicit On
Public Class ucNote
    Private mNoteDAOs As List(Of NoteDAO)
 
    Public Function GetNoteDAOs() As List(Of NoteDAO)
        Dim lRow As Long
        Dim lNoteDAO As NoteDAO
        Try
            mNoteDAOs = New List(Of NoteDAO)

            If gridView.RowCount > 0 Then
                For lRow = 0 To gridView.RowCount
                    If gridView.GetRowCellDisplayText(lRow, "Description").Trim <> "" Then
                        lNoteDAO = New NoteDAO
                        lNoteDAO.ID = ConvertNullToZero(gridView.GetRowCellDisplayText(lRow, "ID"))
                        lNoteDAO.Description = gridView.GetRowCellDisplayText(lRow, "Description")
                        lNoteDAO.DescriptionORG = gridView.GetRowCellDisplayText(lRow, "DescriptionORG")
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

    Public Function ShowControl(ByVal pRefTable As String, ByVal pRefID As Long) As Boolean
        Try
            Call LoadData(pRefTable, pRefID)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucNote.ShowControl : " & e.Message)
            Return False
        End Try
    End Function

    Public Sub ClearControl()
        Try
            Call LoadData("", 0)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucNote.ClearAll : " & e.Message)
        End Try
    End Sub


    Private Sub LoadData(ByVal pRefTable As String, ByVal pRefID As Long)
        Dim lcls As New NoteDAO
        Dim dataTable As New DataTable()

        Try
            dataTable = lcls.GetDataTable(pRefTable, pRefID)
            gridControl.DataSource = dataTable
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
            .Columns("DescriptionORG").Visible = False
        End With

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
End Class
