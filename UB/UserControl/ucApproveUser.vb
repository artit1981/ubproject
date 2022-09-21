Option Explicit On

Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraGrid.Views.Grid

Public Enum AppColumn
    Amount = 1
End Enum

Public Class ucApproveUser
    Private mIsError As Boolean
    Private mDataDAOs As List(Of ApproveUserDTLDAO)
    Private mIsReaOnly As Boolean
    Private mNotVerifyEditor As Boolean
    Private mMode As DataMode
    Private bindingSource1 As New BindingSource
    Private DxErrorProvider1 As New DXErrorProvider
    Private mApproveType As Integer
    Shared mColData As AppColumn

    Public ReadOnly Property IsError() As Boolean
        Get
            Return mIsError
        End Get
    End Property

    Public Function ShowControl(ByVal pMode As Long, ByVal pApproveType As Integer, ByVal pColumnData As AppColumn, ByVal pIsReaOnly As Boolean) As Boolean
        Try
            mColData = pColumnData
            mIsReaOnly = pIsReaOnly
            mMode = pMode
            mApproveType = pApproveType
            Call LoadData(pApproveType)

            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucApproveUser.ShowControl : " & e.Message)
            Return False
        End Try
    End Function

    Public Function ShowControlByDataSource(ByVal pMode As Long, ByVal pSource As BindingSource, ByVal pColumnData As ProColumn, ByVal pIsReaOnly As Boolean) As Boolean
        Try
            Try
                mMode = pMode
                mColData = pColumnData
                mIsReaOnly = pIsReaOnly
                bindingSource1.DataSource = GetType(ApproveUserDTLDAOSub)
                bindingSource1 = pSource
                DxErrorProvider1.DataSource = bindingSource1
                DxErrorProvider1.ContainerControl = Me
                gridControl.DataSource = bindingSource1
                GridStyle()

            Catch e As Exception
                Err.Raise(Err.Number, e.Source, "ucApproveUser.LoadData : " & e.Message)
            Finally

            End Try

            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucApproveUser.ShowControl : " & e.Message)
            Return False
        End Try
    End Function


    Public Function GetDAOs() As List(Of ApproveUserDTLDAO)
        Dim lRow As Long
        Dim lDataDAO As ApproveUserDTLDAO
        Dim info As New ErrorInfo()

        Try
            mDataDAOs = New List(Of ApproveUserDTLDAO)
            mIsError = False
            mNotVerifyEditor = True


            If gridView.RowCount > 0 Then
                For lRow = 0 To gridView.RowCount
                    If ConvertNullToZero(gridView.GetRowCellValue(lRow, "EmpID")) <> 0 Then
                        lDataDAO = New ApproveUserDTLDAO
                        lDataDAO.SEQ = lRow + 1
                        lDataDAO.ApproveUserDtlID = ConvertNullToZero(gridView.GetRowCellDisplayText(lRow, "ApproveUserDtlID"))
                        lDataDAO.EmpID = ConvertNullToZero(gridView.GetRowCellValue(lRow, "EmpID"))
                        lDataDAO.ApproveType = ConvertNullToZero(gridView.GetRowCellDisplayText(lRow, "ApproveType"))
                        lDataDAO.EmpName = ConvertNullToString(gridView.GetRowCellDisplayText(lRow, "EmpName"))
                        lDataDAO.PositionName = ConvertNullToString(gridView.GetRowCellDisplayText(lRow, "PositionName"))
                        lDataDAO.Email1 = ConvertNullToString(gridView.GetRowCellDisplayText(lRow, "Email1"))
                        lDataDAO.Phone1 = ConvertNullToString(gridView.GetRowCellDisplayText(lRow, "Phone1"))
                        lDataDAO.ApproveAmount = ConvertNullToZero(gridView.GetRowCellValue(lRow, "ApproveAmount"))
                        lDataDAO.Remark = gridView.GetRowCellDisplayText(lRow, "Remark")
                        lDataDAO.IsCancel = gridView.GetRowCellValue(lRow, "IsCancel")
                        mDataDAOs.Add(lDataDAO)

                        TryCast(gridView.GetRow(lRow), ApproveUserDTLDAOSub).GetError(info)
                        If info.ErrorText <> "" Then
                            gridView.RefreshData()
                            mIsError = True
                        Else

                        End If
                    End If
                Next
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucApproveUser.GetDAOs : " & e.Message)
        Finally
            lDataDAO = Nothing
        End Try
        Return mDataDAOs
    End Function

    Public Sub ClearControl()
        Try
            bindingSource1.Clear()
            bindingSource1.DataSource = GetType(ApproveUserDTLDAOSub)
            gridControl.DataSource = bindingSource1
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucApproveUser.ClearAll : " & e.Message)
        End Try
    End Sub

    Private Sub LoadData(ByVal ppApproveType As Long)
        Dim lcls As New ApproveUserDTLDAO
        Dim dataTable As New DataTable()

        Try
            bindingSource1.DataSource = GetType(ApproveUserDTLDAOSub)
            dataTable = lcls.GetDataTable(ppApproveType, 0, False)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    Dim rec As New ApproveUserDTLDAOSub()

                    rec.ApproveUserDtlID = dr("ApproveUserDtlID")
                    rec.SEQ = ConvertNullToZero(dr("SEQ"))
                    rec.ApproveType = ConvertNullToZero(dr("ApproveType"))
                    rec.EmpID = ConvertNullToZero(dr("EmpID"))
                    rec.EmpName = ConvertNullToString(dr("EmpName"))
                    rec.PositionName = ConvertNullToString(dr("PositionName"))
                    rec.Email1 = ConvertNullToString(dr("Email1"))
                    rec.Phone1 = ConvertNullToString(dr("Phone1"))
                    rec.ApproveAmount = ConvertNullToZero(dr("ApproveAmount"))
                    rec.IsCancel = dr("IsCancel")
                    rec.Remark = ConvertNullToString(dr("Remark"))
                    rec.ModeData = DataMode.ModeEdit
                    bindingSource1.Add(rec)
                Next
            End If
            DxErrorProvider1.DataSource = bindingSource1
            DxErrorProvider1.ContainerControl = Me
            gridControl.DataSource = bindingSource1
            GridStyle()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucApproveUser.LoadData : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub


    Private Sub GridStyle()
        With gridView

            .Columns("ApproveUserDtlID").Visible = False
            .Columns("SEQ").Visible = False
            .Columns("EmpID").Visible = False
            If mApproveType = 1 Then
                .Columns("ApproveAmount").Visible = False
            Else
                .Columns("ApproveAmount").Visible = True
            End If
            .Columns("ApproveAmount").Visible = (mColData And AppColumn.Amount) = AppColumn.Amount
            If mIsReaOnly = True Then
                gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False
                gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False
                'If .Columns("Discount").Visible Then .Columns("Discount").OptionsColumn.ReadOnly = True
                .Columns("EmpName").OptionsColumn.ReadOnly = True
            End If
        End With
    End Sub

    Private Function LoadDataEmp(ByVal pEmpName As String, ByVal pAutoAdd As Boolean) As String

        'Dim lEmpID As Long
        Dim lstrEmpName As String
        LoadDataEmp = ""

        Dim lstrProductCode As String
        LoadDataEmp = ""
        Try
            If pEmpName = "" Then
                lstrProductCode = ""
            Else
                lstrProductCode = LoadDataTableEmp(0, pEmpName, pAutoAdd)
            End If

            If lstrProductCode <> "" Then
                Return lstrProductCode
            Else
                Dim lfrmFind As New frmFindData
                lfrmFind.LookFor = pEmpName
                lfrmFind.Execute(MasterType.Employee, 0, 0)

                If ConvertNullToZero(lfrmFind.LookFor) = 0 Then
                    Return ""
                Else
                    lstrEmpName = LoadDataTableEmp(lfrmFind.LookFor, "", pAutoAdd)
                    If lstrEmpName <> "" Then
                        Return lstrEmpName
                    End If
                End If
                lfrmFind = Nothing
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucApproveUser.LoadDataEmp : " & e.Message)
        Finally

        End Try
    End Function


    Private Function LoadDataTableEmp(ByVal pllngID As Long, ByVal pEmpName As String, ByVal pAutoAdd As Boolean) As String
        Dim lcls As New EmployeeDAO
        Dim dataTable As New DataTable()
        LoadDataTableEmp = ""
        Try
            If pllngID <= 0 And pEmpName <> "" Then
                dataTable = lcls.GetDataTableForCombo2(0, True, pEmpName)
            Else
                dataTable = lcls.GetDataTableForCombo2(pllngID, True, "")
            End If

            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    If pAutoAdd Then
                        If Not gridView.GetFocusedRow Is Nothing Then
                            gridView.SetFocusedRowCellValue("EmpID", ConvertNullToZero(dr("ID")))
                            gridView.SetFocusedRowCellValue("EmpName", ConvertNullToString(dr("EmpName")))
                            gridView.SetFocusedRowCellValue("PositionName", ConvertNullToString(dr("PositionName")))
                            gridView.SetFocusedRowCellValue("Phone1", ConvertNullToString(dr("Phone1")))
                            gridView.SetFocusedRowCellValue("Email1", ConvertNullToString(dr("Email1")))
                        Else
                            Dim rec = New ApproveUserDTLDAOSub
                            rec.EmpID = ConvertNullToZero(dr("ID"))
                            rec.EmpName = ConvertNullToString(dr("EmpName"))
                            rec.PositionName = ConvertNullToString(dr("PositionName"))
                            rec.Phone1 = ConvertNullToString(dr("Phone1"))
                            rec.Email1 = ConvertNullToString(dr("Email1"))
                            rec.ModeData = DataMode.ModeNew
                            rec.IsCancel = 0
                            rec.ApproveType = mApproveType
                            bindingSource1.Add(rec)
                        End If
                    Else
                        gridView.SetFocusedRowCellValue("EmpID", ConvertNullToZero(dr("ID")))
                        gridView.SetFocusedRowCellValue("EmpName", ConvertNullToString(dr("EmpName")))
                        gridView.SetFocusedRowCellValue("PositionName", ConvertNullToString(dr("PositionName")))
                        gridView.SetFocusedRowCellValue("Phone1", ConvertNullToString(dr("Phone1")))
                        gridView.SetFocusedRowCellValue("Email1", ConvertNullToString(dr("Email1")))
                    End If

                    Return ConvertNullToString(dr("EmpName"))
                    Exit For
                Next
            Else
                Return ""
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucApproveUser.LoadDataTableEmp : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Function


    Private Sub gridView_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gridView.ValidateRow
        Dim info As New ErrorInfo()
        TryCast(e.Row, ApproveUserDTLDAOSub).GetError(info)
        e.Valid = info.ErrorText = ""
    End Sub

    Private Sub gridView_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gridView.InvalidRowException
        e.ExceptionMode = ExceptionMode.NoAction
    End Sub

    Private Sub gridView_ShowingEditor(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles gridView.ShowingEditor
        If sender.FocusedColumn.FieldName = "EmpName" Then
            If sender.GetRowCellValue(sender.FocusedRowHandle, "ModeData") = DataMode.ModeEdit Then
                e.Cancel = True
            End If
        End If

    End Sub

    Private Sub gridView_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles gridView.ValidatingEditor

        If gridView.FocusedColumn.FieldName = "EmpName" Then
            If e.Value = "" Then
            Else
                Dim lValue As String = LoadDataEmp(e.Value, False)
                If lValue = "" Then
                    e.Valid = False
                    e.ErrorText = "ไม่พบข้อมูล"
                Else
                    e.Value = lValue
                End If
            End If
        End If

    End Sub

    Private Sub NameBtn_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles NameBtn.ButtonClick
        If mIsReaOnly = True Then
        Else
            LoadDataEmp("", True)
        End If
    End Sub


    Public Class ApproveUserDTLDAOSub
        Inherits ApproveUserDTLDAO
        Implements IDXDataErrorInfo


#Region "IDXDataErrorInfo Members"
        Public Sub GetPropertyError(ByVal propertyName As String, ByVal info As ErrorInfo) Implements IDXDataErrorInfo.GetPropertyError
            'If propertyName = "ProductCode" AndAlso String.IsNullOrEmpty(ProductCode) Then
            '    info.ErrorText = String.Format("กรุณาระบุข้อมูล", propertyName)
            '    info.ErrorType = ErrorType.Critical
            'End If
            'If propertyName = "UnitName" AndAlso String.IsNullOrEmpty(UnitName) Then
            '    info.ErrorText = String.Format("กรุณาระบุข้อมูล", propertyName)
            '    info.ErrorType = ErrorType.Critical
            'End If
            'If propertyName = "Units" AndAlso ConvertNullToZero(Units) <= 0 Then
            '    info.ErrorText = String.Format("กรุณาระบุจำนวน", propertyName)
            '    info.ErrorType = ErrorType.Critical
            'End If
            'If (mColData And ProColumn.LocationDTLID) = ProColumn.LocationDTLID Then
            '    If propertyName = "LocationDTLID" AndAlso ConvertNullToZero(LocationDTLID) <= 0 Then
            '        info.ErrorText = String.Format("กรุณาระบุข้อมูล", propertyName)
            '        info.ErrorType = ErrorType.Critical
            '    End If
            'End If
        End Sub


        Public Sub GetError(ByVal info As ErrorInfo) Implements IDXDataErrorInfo.GetError
            'Dim propertyInfo As New ErrorInfo()

            'GetPropertyError("ProductCode", propertyInfo)

            'If propertyInfo.ErrorText = "" Then
            '    If (mColData And ProColumn.UnitName) = ProColumn.UnitName Then
            '        GetPropertyError("UnitName", propertyInfo)
            '    End If
            'End If

            'If propertyInfo.ErrorText = "" Then
            '    If (mColData And ProColumn.LocationDTLID) = ProColumn.LocationDTLID Then
            '        GetPropertyError("LocationDTLID", propertyInfo)
            '    End If
            'End If
            'If propertyInfo.ErrorText = "" Then
            '    If (mColData And ProColumn.Units) = ProColumn.Units Then
            '        GetPropertyError("Units", propertyInfo)
            '    End If
            '    'If mIsCheckStock = True And propertyInfo.ErrorText <> "" Then
            '    '    info.ErrorText = CheckStock(ProductID, UnitID, LocationDTLID, Units)
            '    '    info.ErrorType = ErrorType.Critical
            '    '    propertyInfo.ErrorText = info.ErrorText
            '    '    propertyInfo.ErrorType = ErrorType.Critical
            '    'End If

            'End If

            'If propertyInfo.ErrorText <> "" Then
            '    info.ErrorText = "พบข้อผิดพลาด"
            'Else

            'End If
            'Total = (Units * Price) - Discount
            'If mIsCheckStock = True And IsSelect = True Then
            '    info.ErrorText = CheckStock(ProductID, UnitID, LocationDTLID, Units)
            '    If info.ErrorText <> "" Then info.ErrorType = ErrorType.Warning
            'End If

        End Sub
#End Region
    End Class

End Class
