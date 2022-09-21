Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraGrid.Views.Grid
Public Class ucOrderList
    Private bindingSource1 As BindingSource
    Private mDataDAOs As List(Of SubOrder)
    Private mEffectDate As Date
    Private mIsReadOnly As Boolean
    Private mCanFind As Boolean
    Private mIsError As Boolean
    Private mTotal As Double
    Private mFormOrder As frmBill
    Private mOrderType As MasterType
    Shared mColData As OrdColumn

    Public ReadOnly Property IsError() As Boolean
        Get
            Return mIsError
        End Get
    End Property

    Public Enum OrdColumn
        BillTotal = 1
        Remark = 2
        BillType = 4
        IsSelect = 8
    End Enum
    Public ReadOnly Property Totals() As Double
        Get
            Return mTotal
        End Get
    End Property
#Region "Public"
    Public Function ShowControl(ByVal pSource As BindingSource, ByVal pBillID As Long, ByVal pEffectDate As Date, ByVal pIsReadOnly As Boolean _
                                , ByVal pColumnData As OrdColumn, ByVal pShowFooter As Boolean, ByVal pFormOrder As frmBill, ByVal pOrderType As Long, ByVal pCanFind As Boolean) As Boolean
        Try
            If pSource Is Nothing Then
                bindingSource1 = New BindingSource
                bindingSource1.DataSource = GetType(SubOrder)
                If pBillID > 0 Then
                    LoadData(pBillID)
                End If
            Else
                bindingSource1 = pSource
            End If
            mEffectDate = pEffectDate
            mIsReadOnly = pIsReadOnly
            mColData = pColumnData
            mFormOrder = pFormOrder
            mOrderType = pOrderType
            mCanFind = pCanFind
            GridView.OptionsView.ShowFooter = pShowFooter

            DxErrorProvider1.DataSource = bindingSource1
            DxErrorProvider1.ContainerControl = Me
            GridControl.DataSource = bindingSource1
            GridStyle()
            'LoadComboOrder()
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucOrderList.ShowControl : " & e.Message)
            Return False
        End Try
    End Function



    Public Function GetDAOs() As List(Of SubOrder)
        Dim lRow As Long
        Dim lDataDAO As SubOrder
        Dim info As New ErrorInfo()

        Try
            mTotal = 0
            mDataDAOs = New List(Of SubOrder)
            If GridView.RowCount > 0 Then
                For lRow = 0 To GridView.RowCount
                    If ConvertNullToZero(GridView.GetRowCellValue(lRow, "OrderID")) <> 0 And GridView.GetRowCellValue(lRow, "IsSelect") = True Then
                        lDataDAO = New SubOrder
                        lDataDAO.IsSelect = True
                        lDataDAO.ID = ConvertNullToZero(GridView.GetRowCellDisplayText(lRow, "ID"))
                        lDataDAO.OrderID = ConvertNullToZero(GridView.GetRowCellDisplayText(lRow, "OrderID"))
                        lDataDAO.OrderCode = ConvertNullToString(GridView.GetRowCellDisplayText(lRow, "OrderCode"))
                        lDataDAO.CusName = ConvertNullToString(GridView.GetRowCellDisplayText(lRow, "CusName"))
                        lDataDAO.EmpName = ConvertNullToString(GridView.GetRowCellDisplayText(lRow, "EmpName"))
                        lDataDAO.BillTotal = ConvertNullToZero(GridView.GetRowCellValue(lRow, "BillTotal"))
                        lDataDAO.GrandTotal = ConvertNullToZero(GridView.GetRowCellValue(lRow, "GrandTotal"))
                        lDataDAO.OrderDate = GridView.GetRowCellValue(lRow, "OrderDate")
                        lDataDAO.Remark = ConvertNullToString(GridView.GetRowCellDisplayText(lRow, "Remark"))
                        lDataDAO.BillType = ConvertNullToString(GridView.GetRowCellDisplayText(lRow, "BillType"))
                        lDataDAO.TableID = ConvertNullToString(GridView.GetRowCellDisplayText(lRow, "TableID"))
                        mTotal = mTotal + ConvertNullToZero(GridView.GetRowCellValue(lRow, "BillTotal"))
                        mDataDAOs.Add(lDataDAO)
                        TryCast(GridView.GetRow(lRow), SubOrder).GetError(info)
                        If info.ErrorText <> "" Then
                            mIsError = True
                        End If
                    End If
                Next
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucOrderList.GetDAOs : " & e.Message)
        Finally
            lDataDAO = Nothing
        End Try
        Return mDataDAOs
    End Function

    Public Sub ClearControl()
        Try
            If Not bindingSource1 Is Nothing Then
                bindingSource1.Clear()
                bindingSource1.DataSource = GetType(SubOrder)
                GridControl.DataSource = bindingSource1
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucOrderList.ClearAll : " & e.Message)
        End Try
    End Sub
#End Region

#Region "Private"
    Private Sub GridStyle()
        With GridView
            GridView.OptionsBehavior.ReadOnly = mIsReadOnly
            .Columns("ID").Visible = False
            .Columns("CusName").Visible = False
            .Columns("IsSelect").Visible = (mColData And OrdColumn.IsSelect) = OrdColumn.IsSelect
            .Columns("GrandTotal").Visible = True
            .Columns("OrderCode").Visible = True
            .Columns("BillTotal").Visible = (mColData And OrdColumn.BillTotal) = OrdColumn.BillTotal
            .Columns("BillType").Visible = (mColData And OrdColumn.BillType) = OrdColumn.BillType
            .Columns("Remark").Visible = (mColData And OrdColumn.Remark) = OrdColumn.Remark
            .Columns("OrderCode").OptionsColumn.ReadOnly = (mCanFind = False)
        End With
    End Sub

    Private Sub LoadData(ByVal pBillID As Long)
        Dim lcls As New OrderSDetailDAO
        Dim dataTable As New DataTable()

        Try
            dataTable = lcls.GetDataTable(pBillID, Nothing)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    Dim rec As New SubOrder()
                    rec.IsSelect = True
                    rec.ID = dr("ID")
                    rec.BillID = ConvertNullToZero(dr("BillID"))
                    rec.BillType = ConvertNullToString(dr("BillType"))
                    rec.OrderID = ConvertNullToZero(dr("OrderID"))
                    rec.OrderCode = ConvertNullToString(dr("OrderCode"))
                    rec.OrderDate = dr("OrderDate")
                    rec.CusName = ConvertNullToString(dr("CusName"))
                    rec.EmpName = ConvertNullToString(dr("EmpName"))
                    rec.BillTotal = ConvertNullToZero(dr("BillTotal"))
                    rec.GrandTotal = ConvertNullToZero(dr("GrandTotal"))
                    rec.Remark = ConvertNullToString(dr("Remark"))
                    rec.TableID = ConvertNullToString(dr("TableID"))
                    bindingSource1.Add(rec)
                Next
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucOrderList.LoadData : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Private Sub CalcToForm()
        If Not mFormOrder Is Nothing And mCanFind = True Then
            Call mFormOrder.Calculation()
        End If

    End Sub


    Private Function LoadDataProduct(ByVal pProductCode As String, ByVal pAutoAdd As Boolean) As String
        Dim lfrm As New frmFindOrder
        Dim lSubOrderList As New List(Of SubOrder)
        Dim bindingSource1 As New BindingSource
        Dim i As Long = 1
        Dim lstrProductCode As String = ""

        LoadDataProduct = ""
        Try
            If pProductCode = "" Then
                lstrProductCode = ""
            Else
                lstrProductCode = LoadDataTableOrder(0, pProductCode, pAutoAdd)

            End If

            If lstrProductCode <> "" Then
                CalcToForm()
                Return lstrProductCode
            Else
                If gCustomerID = 0 Then
                    XtraMessageBox.Show(Me, "กรุณาระบุลูกค้า", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return ""
                Else
                    lfrm.CustomerID_ = gCustomerID
                    lfrm.OrderDate = mEffectDate
                    lfrm.Text = "ค้นหารายการ "
                    lfrm.OrderType = mOrderType
                    lfrm.ShowDialog()
                    If lfrm.IsAccept Then
                        lSubOrderList = lfrm.GetSubOrderList
                        If Not lSubOrderList Is Nothing Then
                            If lSubOrderList.Count > 0 Then
                                For Each rec As SubOrder In lSubOrderList
                                    If ConvertNullToZero(rec.OrderID) = 0 Then
                                        Return ""
                                    Else
                                        If i > 1 Then pAutoAdd = True
                                        lstrProductCode = LoadDataTableOrder(rec.OrderID, "", pAutoAdd)

                                    End If
                                    i = i + 1
                                Next
                                CalcToForm()
                                Return lstrProductCode
                            Else
                                Return ""
                            End If
                        Else
                            Return ""
                        End If
                    End If
                End If
                lfrm = Nothing
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucProductLists.LoadDataProduct : " & e.Message)
        Finally

        End Try
    End Function



    Private Function LoadDataTableOrder(ByVal pllngID As Long, ByVal pOrderCode As String, ByVal pAutoAdd As Boolean) As String
        Dim lcls As New OrderSDAO
        Dim llIndex As Long
        LoadDataTableOrder = ""
        Try
            If pOrderCode <> "" Then
                lcls.InitailData(0, pOrderCode, Nothing)
            Else
                lcls.InitailData(pllngID, "", Nothing)
            End If

            If lcls.ID > 0 Then
                Dim rec As SubOrder
                rec = TryCast(GridView.GetFocusedRow, SubOrder)
                If rec Is Nothing Or pAutoAdd = True Then
                    rec = New SubOrder
                    llIndex = 0
                Else
                    llIndex = 1
                End If
                rec.IsSelect = True
                rec.ID = 0
                rec.BillID = 0
                rec.BillType = ""
                rec.OrderID = lcls.ID
                rec.OrderCode = lcls.Code
                rec.OrderDate = lcls.OrderDate
                rec.CusName = lcls.CustomerDAO.FirstName
                rec.EmpName = lcls.EmployeeDAO(Nothing).Title & lcls.EmployeeDAO(Nothing).FirstName & " " & lcls.EmployeeDAO(Nothing).LastName

                rec.Remark = ""
                rec.TableID = lcls.TableID
                Select Case lcls.TableID
                    Case MasterType.ReduceCredit, MasterType.ReduceCreditBuy
                        rec.GrandTotal = lcls.GrandTotal * -1
                        rec.BillTotal = lcls.GrandTotal * -1
                    Case Else
                        rec.BillTotal = lcls.GrandTotal
                        rec.GrandTotal = lcls.GrandTotal
                End Select
                If llIndex = 0 Then
                    bindingSource1.Add(rec)
                End If
                GridControl.DataSource = bindingSource1

                GridControl.RefreshDataSource()

                Return lcls.Code
            Else
                Return ""
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucProductLists.LoadDataTableProduct : " & e.Message)
        Finally
            lcls = Nothing
        End Try

    End Function

#End Region

    Private Sub GridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView.CellValueChanged
        CalcToForm()
    End Sub

    'Private Sub GridView_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles GridView.KeyPress

    '    If e.KeyChar = ChrW(Keys.Enter) And GridView.FocusedColumn.FieldName = "OrderCode" Then
    '        LoadDataProduct("", False)

    '    End If
    'End Sub


    Private Sub GridView_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView.RowUpdated
        CalcToForm()
    End Sub

    Private Sub GridView_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GridView.ValidatingEditor
        If GridView.FocusedColumn.FieldName = "OrderCode" And mCanFind = True And mIsReadOnly = False Then
            If e.Value = "" Then
                'e.Valid = False
                'e.ErrorText = "กรุณาระบุข้อมูล"
            Else
                Dim lValue As String = LoadDataProduct(e.Value, False)
                If lValue = "" Then
                    e.Value = ""
                    'e.Valid = False
                    'e.ErrorText = "ไม่พบข้อมูล"
                Else
                    'e.Valid = True
                    e.Value = lValue
                    GridView.FocusedColumn = BillTotal
                    'End If
                End If
            End If
        End If
    End Sub

    Private Sub btnOrderCode_ButtonPressed(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnOrderCode.ButtonPressed
        If mCanFind = True And mIsReadOnly = False Then
            LoadDataProduct("", False)
        End If

    End Sub

End Class


Public Class SubOrder
    Inherits OrderSDetailDAO
    Implements IDXDataErrorInfo


#Region "IDXDataErrorInfo Members"
    Public Sub GetPropertyError(ByVal propertyName As String, ByVal info As ErrorInfo) Implements IDXDataErrorInfo.GetPropertyError
        If propertyName = "OrderCode" AndAlso String.IsNullOrEmpty(OrderCode) Then
            info.ErrorText = String.Format("กรุณาระบุข้อมูล", propertyName)
            info.ErrorType = ErrorType.Critical
        End If
        'If propertyName = "UnitName" AndAlso String.IsNullOrEmpty(UnitName) Then
        '    info.ErrorText = String.Format("กรุณาระบุข้อมูล", propertyName)
        '    info.ErrorType = ErrorType.Critical
        'End If
        'If propertyName = "Units" AndAlso ConvertNullToZero(Units) <= 0 Then
        '    info.ErrorText = String.Format("กรุณาระบุจำนวน", propertyName)
        '    info.ErrorType = ErrorType.Critical
        'End If
    End Sub


    Public Sub GetError(ByVal info As ErrorInfo) Implements IDXDataErrorInfo.GetError
        Dim propertyInfo As New ErrorInfo()

        GetPropertyError("OrderCode", propertyInfo)

        'If propertyInfo.ErrorText = "" Then
        '    If (mColData And ProColumn.UnitName) = ProColumn.UnitName Then
        '        GetPropertyError("UnitName", propertyInfo)
        '    End If
        'End If

        'If propertyInfo.ErrorText = "" Then
        '    If (mColData And ProColumn.Units) = ProColumn.Units Then
        '        GetPropertyError("Units", propertyInfo)
        '    End If
        'End If

        'If propertyInfo.ErrorText <> "" Then
        '    info.ErrorText = "พบข้อผิดพลาด"
        'Else

        'End If
        'Total = (Units * Price) - Discount
    End Sub
#End Region

End Class