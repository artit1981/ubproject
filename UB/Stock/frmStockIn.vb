Option Explicit On

Imports DevExpress.XtraEditors

Public Class frmStockIn
    Inherits iEditForm
    Private Const mFormName As String = "frmStockIn"
    Private mcls As New OrderSDAO
    Private mIsFromLoad As Boolean
    Private mMode As DataMode
    Private mRefOrderID As List(Of Long)
    Private mOrderType As MasterType
    Private mProductList As List(Of ProductListDAO)
    Private mIsGroupDupProduct As Integer = 0 '0 none ,1=yes,2=no
#Region "Overrides"
    Protected Overrides Sub OnLoadForm(ByVal pMode As Integer, ByVal pID As Long, ByVal pOrderType As Long, ByVal pclsConvert As iOrder, ByVal pCusID As Long)
        Try
            mMode = pMode
            mOrderType = pOrderType
            mIsFromLoad = True
            InitialCombo()
            mcls = New OrderSDAO
            mcls.TableID = mOrderType
            If mOrderType = MasterType.StockIn Then
                txtRefOrder.Enabled = True
                btnRefOrder.Enabled = True
                lblUpdateStr.Visible = False
                IsSumStock.Visible = False
            Else
                IsSumStock.Visible = True
                txtRefOrder.Enabled = False
                btnRefOrder.Enabled = False
                lblUpdateStr.Visible = True
            End If
            Call LoadData(pMode, pID)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".OnLoadForm : " & e.Message)
        Finally
            mIsFromLoad = False
        End Try
    End Sub

    Protected Overrides Sub ClearAllForm(ByVal pMode As Integer)
        Try
            mIsFromLoad = True
            MyBase.ClearAllForm(pMode)
            Select Case pMode
                Case DataMode.ModeNew
                    ClearForm(GeneralTabPage)
                    ClearForm(UcAdmin1)
                    UcFileAttach1.ClearControl()
                    UcNote1.ClearControl()
                    UcProductLists1.ClearControl()

                    'Un Lockcontrol
                    OrderCode.Properties.ReadOnly = False
                    OrderDate.Properties.ReadOnly = False
            End Select

            XtraTabControl1.SelectedTabPage = GeneralTabPage
            OrderCode.Select()
            EmpID.EditValue = gEmpID
            UcAdmin1.CheckInAcive.Enabled = False
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".ClearAllForm : " & e.Message)
        Finally
            mIsFromLoad = False
        End Try
    End Sub

    Protected Overrides Function Save(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        XtraTabControl1.SelectedTabPage = GeneralTabPage
        OrderCode.Focus()
        Try
            mcls.ID = pID
            mcls.ModeData = pMode
            mcls.Code = OrderCode.Text.Trim
            mcls.OrderDate = OrderDate.EditValue
            mcls.EmpID = ConvertNullToZero(EmpID.EditValue)
            mcls.Remark = Remark.Text.Trim
            mcls.IsInActive = UcAdmin1.CheckInAcive.Checked
            mcls.NoteDAOs = UcNote1.GetNoteDAOs
            mcls.FileAttachs = UcFileAttach1.GetFileAttachs
            mcls.ProductDAOs = UcProductLists1.GetDAOs(False, True, False, Nothing, False, 0, False, mOrderType.ToString, mMode, "")
            mcls.RefToOrderID = mRefOrderID
            mcls.TableID = mOrderType
            mcls.IsSumStock = IsSumStock.Checked
            If CheckIsWaitApproveStock() Then
                ShowProgress(False, "")
                XtraMessageBox.Show(Me, "ไม่สามารถทำรายการได้ เนื่องจากระบบมีการคำนวนสต๊อกใหม่ กรุณาทำการอนุมัติสต๊อก ", "Approve", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
                Return False
            End If
            If Verify() = True Then
                Call mcls.SaveData()
                ShowProgress(False, "")
                'XtraMessageBox.Show(Me, "บันทึกรายการสำเร็จ", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                If XtraMessageBox.Show(Me, "บันทึกรายการสำเร็จ ต้องการพิมพ์บาร์โค้ดหรือไม่", "บันทึก", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    Dim lSNList As New List(Of SnDAO)
                    Dim lSN As New SnDAO

                    For Each pPro In mcls.ProductDAOs
                        For Each pSN In pPro.SNList
                            lSN = New SnDAO
                            lSN.ProductName = pPro.ProductName
                            lSN.SerialNumberNo = pSN.SerialNumberNo
                            lSNList.Add(lSN)
                        Next
                    Next
                    If lSNList.Count > 0 Then
                        modReport.PrintBarCode("", lSNList)
                    End If

                End If
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            If Err.Number = -1 Then
                XtraMessageBox.Show("Serial Number บางรายการถุก Close แล้ว ไม่สามารถทำรายการได้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Err.Raise(Err.Number, ex.Source, mFormName & ".Save : " & ex.Message)
            End If
            Return False
        End Try
    End Function

    Protected Overrides Sub OnClosedForm()
        mcls = Nothing
    End Sub
#End Region

#Region "Event"
    Private Sub FormChangedComponent1_FormControlChanged1(ByVal sender As Object, ByVal e As FormChangedEventArgs) Handles FormChangedComponent1.FormControlChanged
        MyBase.CheckFormChanged()
    End Sub

    Private Sub btnEmpID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpID.Click
        Try
            ShowProgress(True, "Loading...")
            SetEmployees()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub btnGenID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenID.Click
        Try
            ShowProgress(True, "Loading...")
            OrderCode.EditValue = AutoGenCode(MasterType.StockIn)
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub btnRefOrder_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRefOrder.Click
        Try
            ShowFindOrder()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally

        End Try
    End Sub

    Private Sub txtRefOrder_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRefOrder.KeyPress
        Try
            If e.KeyChar = ChrW(Keys.Enter) Then
                If txtRefOrder.Text.Trim <> "" Then
                    ShowProgress(True, "Loading...")
                    If InitialOrder(0, txtRefOrder.Text.Trim, True) = False Then
                        ShowFindOrder()
                    End If
                End If
            End If
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try

    End Sub

#End Region

#Region "Private"

    Private Sub InitialCombo()
        Try
            SetEmployees()
            SetSearchLookAgency(CustomerID)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".InitialCombo : " & e.Message)
        End Try
    End Sub

    Private Function LoadData(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        Dim lCusID As Long = 0
        Try
            If pMode = DataMode.ModeNew Then
                OrderCode.EditValue = AutoGenCode(mOrderType)
                EmpID.EditValue = gEmpID
                IsSumStock.Checked = True
            ElseIf pMode = DataMode.ModeEdit Then

                If mOrderType = MasterType.UpdateStock Then
                    SaveBar.Enabled = False
                End If

                If mcls.InitailData(pID) Then
                    IsSumStock.Enabled = False
                    OrderCode.EditValue = mcls.Code
                    OrderDate.EditValue = mcls.OrderDate
                    IsSumStock.Checked = mcls.IsSumStock
                    UcAdmin1.CheckInAcive.Checked = mcls.IsInActive
                    UcAdmin1.txtCreateBy.Text = mcls.CreateBy.Trim
                    UcAdmin1.txtCreateTime.Text = mcls.CreateTime
                    UcAdmin1.txtModifiBy.Text = mcls.ModifiedBy.Trim
                    UcAdmin1.txtModifiTime.Text = mcls.ModifiedTime
                    'LocationDTLID.EditValue = mcls.LocationDTLID
                    'Location.EditValue = 1
                    ''FileAttachs
                    UcFileAttach1.ShowControl(mcls.FileAttachs)
                    EmpID.EditValue = mcls.EmpID
                    Remark.EditValue = mcls.Remark

                    'Lockcontrol
                    OrderCode.Properties.ReadOnly = True
                    OrderDate.Properties.ReadOnly = True
                    txtRefOrder.Properties.ReadOnly = True
                    btnRefOrder.Enabled = False
                    'LocationDTLID.Enabled = False

                    If mcls.EmpID = gEmpID Then
                        EmpID.Properties.ReadOnly = False
                    Else
                        EmpID.Properties.ReadOnly = True
                    End If

                    'Ref order
                    'Dim lToRefOrder As List(Of Long)
                    txtRefOrder.Text = mcls.GetToRefOrderCode(pID, Nothing)
                    mRefOrderID = mcls.RefToOrderID
                    If txtRefOrder.Text <> "" Then
                        Dim lclsRefOrder As New OrderSDAO
                        If lclsRefOrder.InitailData(mRefOrderID.Item(0)) Then
                            CustomerID.EditValue = lclsRefOrder.CustomerID
                            lCusID = lclsRefOrder.CustomerID
                        End If
                    End If

                    SaveBar.Enabled = (mcls.OrderStatus = EnumStatus.Open.ToString Or mcls.OrderStatus = EnumStatus.Approve.ToString Or mcls.OrderStatus = EnumStatus.Cancel.ToString Or mcls.OrderStatus = EnumStatus.Waiting.ToString Or mcls.OrderStatus = EnumStatus.Receive.ToString) And mcls.IsDelete = False

                End If
            End If

            'Note
            UcNote1.ShowControl(mcls.TableName, pID)
            'gCustomerID = 0
            Dim lOrderList As New List(Of Long)
            lOrderList.Add(mcls.ID)
            UcProductLists1.CustomerID = lCusID
            UcProductLists1.ShowControl(pMode, lOrderList, mcls.TableName, ProColumn.Units + ProColumn.UnitName + ProColumn.LocationDTLID _
                                        , False, True, Nothing, False, mcls.TableName, False, mcls.IsDelete, "")
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".LoadData : " & ex.Message)
            Return False
        Finally

        End Try
    End Function


    Private Function Verify() As Boolean
        Dim lstrErr As String = ""
        Try
            DxErrorProvider1.ClearErrors()
            If Trim(OrderCode.Text) = "" Then
                SetErrorProvider(DxErrorProvider1, OrderCode, "กรุณาระบุเลขที่เอกสาร")
            ElseIf mcls.CheckExist() Then
                SetErrorProvider(DxErrorProvider1, OrderCode, "เลขที่เอกสารซ้ำ")
            End If
            lstrErr = lstrErr & DxErrorProvider1.GetError(OrderCode) & vbNewLine

            If ConvertNullToZero(EmpID.EditValue) = 0 Then
                SetErrorProvider(DxErrorProvider1, EmpID, "กรุณาระบุพนักงาน")
                lstrErr = lstrErr & DxErrorProvider1.GetError(EmpID) & vbNewLine
            End If



            lstrErr = lstrErr & UcProductLists1.IsError


            If lstrErr.Trim = "PRODUCTCHANGE" Then
                ShowProgress(False, "")
                Dim lfrm As New frmOrderDTL
                lfrm.ProList = mcls.ProductDAOs
                lfrm.ShowDialog()
                If lfrm.IsSave = True Then
                    Return True
                Else
                    Return False
                End If
            ElseIf lstrErr.Trim <> "" Then
                ShowProgress(False, "")
                lstrErr = "พบข้อผิดพลาดกรุณาตรวจสอบ : " & vbNewLine & lstrErr
                XtraMessageBox.Show(Me, lstrErr, "ตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Else
                Return True
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".Verify : " & e.Message)
        End Try
    End Function



    Private Function VerifyStockLocation() As Boolean
        Dim lstrErr As String = ""
        Try
            For Each pclsPro In mcls.ProductDAOs

            Next

            If lstrErr.Trim <> "" Then
                ShowProgress(False, "")
                lstrErr = "พบข้อผิดพลาดกรุณาตรวจสอบ : " & vbNewLine & lstrErr
                XtraMessageBox.Show(Me, lstrErr, "ตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Else
                Return True
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".Verify : " & e.Message)
        End Try
    End Function

    Private Sub ShowFindOrder()
        Dim lfrm As New frmFindOrder
        Dim lSubOrderList As New List(Of SubOrder)
        Dim bindingSource1 As New BindingSource, lIsInitProduct As Boolean
        Try
            lfrm.CustomerID_ = 0
            lfrm.OrderDate = OrderDate.EditValue
            lfrm.Text = "ค้นหารายการ  "
            lfrm.OrderType = MasterType.StockIn
            lfrm.ShowDialog()
            If lfrm.IsAccept Then
                If lfrm.IsGetByProduct = True Then
                    lIsInitProduct = False
                    mProductList = lfrm.GetProductSubList
                Else
                    lIsInitProduct = True
                    mProductList = New List(Of ProductListDAO)
                End If


                lSubOrderList = lfrm.GetSubOrderList
                If Not lSubOrderList Is Nothing Then
                    If lSubOrderList.Count > 0 Then
                        mIsGroupDupProduct = 0
                        txtRefOrder.Text = ""
                        mRefOrderID = New List(Of Long)

                        For Each rec As SubOrder In lSubOrderList
                            mRefOrderID.Add(rec.OrderID)
                            InitialRefOrder(rec.OrderID, lIsInitProduct)
                        Next
                        ShowProductListBySource(mMode, mProductList)
                    End If
                End If
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".ShowFindOrder : " & ex.Message)
        Finally
        End Try
    End Sub

    Private Function ShowProductListBySource(ByVal pMode As Integer, ByVal pSource As List(Of ProductListDAO)) As Boolean
        Try
            'gCustomerID = 0
            Dim lOrderList As New List(Of Long)
            lOrderList.Add(mcls.ID)
            UcProductLists1.CustomerID = CustomerID.EditValue
            UcProductLists1.ShowControlByDataSource(pMode, pSource, ProColumn.Units + ProColumn.UnitName + ProColumn.LocationDTLID _
                                                    , pMode = DataMode.ModeEdit, Nothing, mOrderType.ToString, False, lOrderList, True, False, "")
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".ShowProductListBySource : " & ex.Message)
            Return False
        Finally
        End Try
    End Function


    Private Function InitialRefOrder(ByVal pRefOrderID As Long, ByVal pInitProduct As Boolean) As Boolean
        Try
            If pRefOrderID > 0 And mIsFromLoad = False Then
                If pInitProduct Then
                    UcProductLists1.ClearControl()
                End If
                InitialOrder(pRefOrderID, "", pInitProduct)
            ElseIf pRefOrderID = 0 And mIsFromLoad = False Then
                txtRefOrder.Text = ""
                If pInitProduct Then
                    UcProductLists1.ClearControl()
                End If
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".InitialRefOrder : " & ex.Message)
        Finally
        End Try
    End Function

    Private Function InitialOrder(ByVal plngOrderID As Long, ByVal pstrOrderCode As String, ByVal pInitProduct As Boolean) As Boolean
        Dim lcls As OrderSDAO
        Try
            If (plngOrderID > 0 Or pstrOrderCode.Trim <> "") And mIsFromLoad = False Then
                lcls = New OrderSDAO
                lcls.TableID = MasterType.PurchaseOrder
                If lcls.InitailData(plngOrderID, pstrOrderCode.Trim) = True Then
                    If txtRefOrder.Text = "" Then
                        txtRefOrder.Text = lcls.Code
                    Else
                        txtRefOrder.Text = txtRefOrder.Text & ", " & lcls.Code
                    End If
                    'gCustomerID = lcls.CustomerID
                    'gSupplierID = lcls.CustomerID
                    UcProductLists1.CustomerID = lcls.CustomerID
                    CustomerID.EditValue = lcls.CustomerID
                    If pInitProduct Then
                        LoadProList(plngOrderID, MasterType.PurchaseOrder)
                    End If

                    Return True
                Else
                    Return False
                End If
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".InitialReserve : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Function


    Private Function LoadProList(ByVal pOrderID As Long, ByVal pTableID As MasterType) As Boolean
        Dim lcls As New ProductListDAO
        Dim rec As New ProductListDAO, lIndex As Long
        Dim dataTable As New DataTable()
        Dim llngProID As Long, llngUnitID As Long
        Dim lOrderList As New List(Of Long)
        Dim lNotRefUnits As Long = 0
        Dim lCalcUnit As Long, lCalcAdjustUnit As Long, lCalcTotal As Long, lCanNotMerge As Boolean = False

        'lIsSell = CheckIsSell(mOrderType)
        lOrderList.Add(pOrderID)
        Try
            Dim lIsConfirm As Boolean = False
            'If pTableID = MasterType.ReduceCredit Or pTableID = MasterType.AddCredit Then
            '    lIsConfirm = False
            'End If

            dataTable = lcls.GetDataTable(lOrderList, pTableID.ToString, Nothing, lIsConfirm, "", False, mOrderType, True)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    llngProID = ConvertNullToZero(dr("ProductID"))
                    llngUnitID = ConvertNullToZero(dr("UnitID"))

                    Call GetRefOrderStatus(pOrderID, mOrderType, mcls.ID, dr("ID"), llngProID, Nothing, mMode, lNotRefUnits, ConvertNullToZero(dr("Units")))

                    If lNotRefUnits > 0 Then
                        If lNotRefUnits < ConvertNullToZero(dr("Units")) Then
                            lCalcUnit = lNotRefUnits
                            lCalcAdjustUnit = lNotRefUnits / ConvertNullToZero(dr("RateUnit"))
                            lCalcTotal = (lNotRefUnits * ConvertNullToZero(dr("PriceMain"))) - (lCalcAdjustUnit * ConvertNullToZero(dr("Discount")))
                        Else
                            lCalcUnit = ConvertNullToZero(dr("Units"))
                            lCalcAdjustUnit = ConvertNullToZero(dr("AdjustUnit"))
                            lCalcTotal = ConvertNullToZero(dr("Total"))
                        End If

                        lIndex = mProductList.FindIndex(Function(m As ProductListDAO) m.ProductID = llngProID And m.IsShow = 1 And m.UnitID = llngUnitID)

                        If lIndex < 0 Or mIsGroupDupProduct = 1 Or ConvertNullToZero(dr("IsShow")) = 0 Or lCanNotMerge = True Then
                            rec = New ProductListDAO
                            rec.IsSelect = True
                            rec.ID = ConvertNullToZero(dr("ID"))
                            rec.SEQ = 0
                            rec.IsSN = ConvertNullToZero(dr("IsSN"))
                            rec.RefID = ConvertNullToZero(dr("RefID"))
                            rec.ProductID = ConvertNullToZero(dr("ProductID"))
                            rec.ProductCode = ConvertNullToString(dr("ProductCode"))
                            rec.ProductName = ConvertNullToString(dr("ProductName"))
                            rec.ProductNameExt = ConvertNullToString(dr("ProductNameExt"))
                            rec.LocationDTLID = ConvertNullToZero(dr("LocationDTLID"))
                            rec.UnitID = ConvertNullToZero(dr("UnitID"))
                            rec.UnitMainID = ConvertNullToZero(dr("UnitMainIDBuy"))
                            rec.UnitName = ConvertNullToString(dr("UnitName"))
                            rec.Remark = ConvertNullToString(dr("Remark"))
                            rec.KeepMin = ConvertNullToZero(dr("KeepMin"))
                            rec.RateUnit = ConvertNullToZero(dr("RateUnit"))
                            rec.Price = ConvertNullToZero(dr("Price"))
                            rec.PriceMain = ConvertNullToZero(dr("PriceMain"))
                            rec.Cost = ConvertNullToZero(dr("Cost"))
                            rec.Discount = ConvertNullToZero(dr("Discount"))
                            rec.IsShow = ConvertNullToZero(dr("IsShow"))

                            'Recalc
                            rec.Units = lCalcUnit
                            rec.AdjustUnit = lCalcAdjustUnit
                            rec.Total = lCalcTotal
                            rec.ProductListRefID = ConvertNullToZero(dr("ID"))
                            rec.ProductListRefID2 = 0
                            rec.ProductListRefID3 = 0
                            rec.ProductListRefID4 = 0
                            rec.ProductListRefID5 = 0
                            rec.ProductListUnitRef1 = lCalcUnit
                            rec.ProductListUnitRef2 = 0
                            rec.ProductListUnitRef3 = 0
                            rec.ProductListUnitRef4 = 0
                            rec.ProductListUnitRef5 = 0

                            rec.IsMerge = 0
                            rec.ModePro = DataMode.ModeNew
                            mProductList.Add(rec)
                        Else
                            If mIsGroupDupProduct = 0 Then
                                If XtraMessageBox.Show(Me, "มีข้อมูลสินค้าซ้ำต้องการรวมรายการหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                                    mIsGroupDupProduct = 2
                                Else
                                    mIsGroupDupProduct = 1
                                    rec = New ProductListDAO
                                    rec.IsSelect = True
                                    rec.IsSN = ConvertNullToZero(dr("IsSN"))
                                    rec.SEQ = 0
                                    rec.ID = ConvertNullToZero(dr("ID"))
                                    rec.RefID = ConvertNullToZero(dr("RefID"))
                                    rec.ProductID = ConvertNullToZero(dr("ProductID"))
                                    rec.ProductCode = ConvertNullToString(dr("ProductCode"))
                                    rec.ProductName = ConvertNullToString(dr("ProductName"))
                                    rec.ProductNameExt = ConvertNullToString(dr("ProductNameExt"))
                                    rec.LocationDTLID = ConvertNullToZero(dr("LocationDTLID"))
                                    rec.UnitID = ConvertNullToZero(dr("UnitID"))
                                    rec.UnitMainID = ConvertNullToZero(dr("UnitMainIDBuy"))
                                    rec.UnitName = ConvertNullToString(dr("UnitName"))
                                    rec.Remark = ConvertNullToString(dr("Remark"))
                                    rec.KeepMin = ConvertNullToZero(dr("KeepMin"))
                                    rec.RateUnit = ConvertNullToZero(dr("RateUnit"))
                                    rec.Price = ConvertNullToZero(dr("Price"))
                                    rec.PriceMain = ConvertNullToZero(dr("PriceMain"))
                                    rec.Cost = ConvertNullToZero(dr("Cost"))
                                    rec.Discount = ConvertNullToZero(dr("Discount"))
                                    'Recalc
                                    rec.Units = lCalcUnit
                                    rec.AdjustUnit = lCalcAdjustUnit
                                    rec.Total = lCalcTotal

                                    rec.ModePro = DataMode.ModeNew
                                    rec.IsShow = 1
                                    rec.IsMerge = 0
                                    rec.ProductListRefID = ConvertNullToZero(dr("ID"))
                                    rec.ProductListRefID2 = 0
                                    rec.ProductListRefID3 = 0
                                    rec.ProductListRefID4 = 0
                                    rec.ProductListRefID5 = 0
                                    rec.ProductListUnitRef1 = lCalcUnit
                                    rec.ProductListUnitRef2 = 0
                                    rec.ProductListUnitRef3 = 0
                                    rec.ProductListUnitRef4 = 0
                                    rec.ProductListUnitRef5 = 0

                                    mProductList.Add(rec)
                                End If
                            End If
                            If mIsGroupDupProduct = 2 Then
                                mProductList.Item(lIndex).Units = mProductList.Item(lIndex).Units + lCalcUnit
                                mProductList.Item(lIndex).AdjustUnit = mProductList.Item(lIndex).AdjustUnit + lCalcAdjustUnit
                                mProductList.Item(lIndex).Total = mProductList.Item(lIndex).Total + lCalcTotal

                                If mProductList.Item(lIndex).ProductListRefID2 = 0 Then
                                    mProductList.Item(lIndex).ProductListRefID2 = ConvertNullToZero(dr("ID"))
                                    mProductList.Item(lIndex).ProductListUnitRef2 = ConvertNullToZero(dr("Units"))
                                ElseIf mProductList.Item(lIndex).ProductListRefID3 = 0 Then
                                    mProductList.Item(lIndex).ProductListRefID3 = ConvertNullToZero(dr("ID"))
                                    mProductList.Item(lIndex).ProductListUnitRef3 = ConvertNullToZero(dr("Units"))
                                ElseIf mProductList.Item(lIndex).ProductListRefID4 = 0 Then
                                    mProductList.Item(lIndex).ProductListRefID4 = ConvertNullToZero(dr("ID"))
                                    mProductList.Item(lIndex).ProductListUnitRef4 = ConvertNullToZero(dr("Units"))
                                Else
                                    mProductList.Item(lIndex).ProductListRefID5 = ConvertNullToZero(dr("ID"))
                                    mProductList.Item(lIndex).ProductListUnitRef5 = ConvertNullToZero(dr("Units"))
                                    lCanNotMerge = True   'Ref slot full
                                End If
                                mProductList.Item(lIndex).IsMerge = 1
                            End If
                        End If
                    End If 'If lNotRefUnits > 0 Then
                Next
            End If 'If dataTable.Rows.Count > 0 Then

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".LoadProList : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Function

#End Region

#Region "Set combo"
    Private Sub SetEmployees()
        Try
            SetComboEmployee(EmpID)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetEmployees : " & e.Message)
        End Try
    End Sub

    'Private Sub SetComboLocation()
    '    Try
    '        SetLookUpLocationDTL(LocationDTLID)
    '    Catch e As Exception
    '        Err.Raise(Err.Number, e.Source, mFormName & ".SetComboLocation : " & e.Message)
    '    End Try
    'End Sub
#End Region


End Class