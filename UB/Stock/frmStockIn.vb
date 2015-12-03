Option Explicit On

Imports DevExpress.XtraEditors

Public Class frmStockIn
    Inherits iEditForm
    Private Const mFormName As String = "frmStockIn"
    Private mcls As New OrderSDAO
    Private mIsFromLoad As Boolean
    Private mMode As DataMode
    'Private mRefOrderID As Long
    Private mRefOrderID As List(Of Long)
    Private mOrderType As MasterType
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
            mcls.ProductDAOs = UcProductLists1.GetDAOs(False, True, False, Nothing, False, 0, False, mOrderType.ToString, 0, "")
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
                XtraMessageBox.Show(Me, "บันทึกรายการสำเร็จ", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".Save : " & ex.Message)
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
                    If InitialOrder(0, txtRefOrder.Text.Trim) = False Then
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
            'SetComboLocation()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".InitialCombo : " & e.Message)
        End Try
    End Sub

    Private Function LoadData(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        Dim lclsProvince As New ProvinceDAO
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
                            Customer.EditValue = lclsRefOrder.CustomerDAO.CustomerName
                        End If
                    End If


                End If
            End If

            'Note
            UcNote1.ShowControl(mcls.TableName, pID)
            gCustomerID = 0
            Dim lOrderList As New List(Of Long)
            lOrderList.Add(mcls.ID)
            UcProductLists1.ShowControl(pMode, lOrderList, mcls.TableName, ProColumn.Units + ProColumn.UnitName + ProColumn.LocationDTLID _
                                        , False, True, Nothing, False, mcls.TableName, False, mcls.IsDelete, 0, "")
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".LoadData : " & ex.Message)
            Return False
        Finally
            lclsProvince = Nothing
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
 
            'If ConvertNullToZero(LocationDTLID.EditValue) = 0 Then
            '    SetErrorProvider(DxErrorProvider1, LocationDTLID, "กรุณาระบุคลัง")
            '    lstrErr = lstrErr & "กรุณาระบุคลัง" & vbNewLine
            'End If

            ''Sum Stock
            'Dim lclsStock As New ProductStockDAO
            'If lclsStock.CheckSumStock(Nothing) = False Then
            '    lstrErr = lstrErr & "กรุณาระบุคลังรวม (หน้า running format)" & vbNewLine
            'End If

            lstrErr = lstrErr & UcProductLists1.IsError

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
        Dim bindingSource1 As New BindingSource
        Try
            'mRefOrderID = New List(Of Long)
            'mRefOrderID.Clear()
            lfrm.CustomerID_ = 0
            lfrm.OrderDate = OrderDate.EditValue
            lfrm.Text = "ค้นหารายการ  "
            lfrm.OrderType = MasterType.StockIn
            lfrm.ShowDialog()
            If lfrm.IsAccept Then
                If lfrm.IsGetByProduct = True Then
                    ShowProductListBySource(mMode, lfrm.GetProductSubList)
                Else
                    lSubOrderList = lfrm.GetSubOrderList
                    If Not lSubOrderList Is Nothing Then
                        If lSubOrderList.Count > 0 Then
                            mRefOrderID = New List(Of Long)
                            For Each rec As SubOrder In lSubOrderList
                                mRefOrderID.Add(rec.OrderID)
                                InitialRefOrder(rec.OrderID)
                            Next
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".ShowFindOrder : " & ex.Message)
        Finally
        End Try
    End Sub

    Private Function ShowProductListBySource(ByVal pMode As Integer, ByVal pSource As List(Of ProductSubDAO)) As Boolean
        Try
            gCustomerID = 0
            Dim lOrderList As New List(Of Long)
            lOrderList.Add(mcls.ID)
            UcProductLists1.ShowControlByDataSource(pMode, pSource, ProColumn.Units + ProColumn.UnitName + ProColumn.LocationDTLID _
                                                    , pMode = DataMode.ModeEdit, Nothing, mOrderType.ToString, False, lOrderList, True, False, "")
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".ShowProductListBySource : " & ex.Message)
            Return False
        Finally
        End Try
    End Function


    Private Function InitialRefOrder(ByVal pRefOrderID As Long) As Boolean
        Try
            If pRefOrderID > 0 And mIsFromLoad = False Then
                InitialOrder(pRefOrderID, "")
            ElseIf pRefOrderID = 0 And mIsFromLoad = False Then
                txtRefOrder.Text = ""
                UcProductLists1.ClearControl()
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".InitialRefOrder : " & ex.Message)
        Finally
        End Try
    End Function

    Private Function InitialOrder(ByVal plngOrderID As Long, ByVal pstrOrderCode As String) As Boolean
        Dim lcls As OrderSDAO
        Try
            If (plngOrderID > 0 Or pstrOrderCode.Trim <> "") And mIsFromLoad = False Then
                lcls = New OrderSDAO
                lcls.TableID = MasterType.PurchaseOrder
                If lcls.InitailData(plngOrderID, pstrOrderCode.Trim) = True Then
                    mRefOrderID.Clear()
                    mRefOrderID.Add(plngOrderID)
                    txtRefOrder.Text = lcls.Code
                    gCustomerID = lcls.CustomerID
                    Customer.EditValue = lcls.CustomerDAO.CustomerName
                    Dim lOrderList As New List(Of Long)
                    lOrderList.Add(lcls.ID)
                    UcProductLists1.ShowControl(mMode, lOrderList, lcls.TableName, ProColumn.Units + ProColumn.UnitName + ProColumn.LocationDTLID _
                                                , False, True, Nothing, False, mcls.TableName, True, False, MasterType.StockIn, "")
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