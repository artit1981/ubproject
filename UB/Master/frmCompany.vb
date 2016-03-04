Imports DevExpress.XtraEditors

Public Class frmCompany
    Inherits iEditForm
    Dim mcls As New CompanyDAO
    Private Const mFormName As String = "frmCompany"


#Region "Overrides"
    Protected Overrides Sub OnLoadForm(ByVal pMode As Integer, ByVal pID As Long, ByVal pOrderType As Long, ByVal pclsConvert As iOrder, ByVal pCusID As Long)
        Try
            InitialCombo()
            Call LoadData(pMode, pID)
            UcHistory1.GroupData.Visible = False
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".OnLoadForm : " & e.Message)
        End Try
    End Sub

    Protected Overrides Sub ClearAllForm(ByVal pMode As Integer)
        Try
            MyBase.ClearAllForm(pMode)
            Select Case pMode
                Case DataMode.ModeNew, DataMode.ModeCopy, DataMode.ModeConvert
                    ClearForm(GeneralTabPage)
                    ClearForm(UcAdmin1)
                    UcFileAttach1.ClearControl()
                    UcAddress1.ClearControl()
                    ClearForm(RegisterTabPage)
                    UcHistory1.ClearControl()
                    XtraTabControl1.SelectedTabPage = GeneralTabPage
                    CompanyNames.Select()
                Case DataMode.ModeEdit
            End Select

            XtraTabControl1.SelectedTabPage = GeneralTabPage
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".ClearAllForm : " & e.Message)
        End Try
    End Sub

    Protected Overrides Function Save(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        XtraTabControl1.SelectedTabPage = GeneralTabPage
        Try
            mcls.ID = pID
            mcls.ModeData = pMode
            mcls.FirstNameEng = CompanyNameEng.Text.Trim
            mcls.FirstName = CompanyNames.Text.Trim
            mcls.Owner = Owners.Text.Trim
            mcls.TaxID = TaxID.Text.Trim
            mcls.TaxType = TaxType.EditValue
            mcls.TaxRate = TaxRate.EditValue
            mcls.RegisterDate = RegisterDate.EditValue
            mcls.Remark = Remark.Text.Trim
            mcls.RegisterNo = RegisterNo.Text.Trim
            mcls.RegisterAsset = ConvertNullToZero(RegisterAsset.EditValue)
            mcls.RegisterNum = ConvertNullToZero(RegisterNum.EditValue)
            mcls.RegisterCost = ConvertNullToZero(RegisterCost.EditValue)
            mcls.CommitteeNum = ConvertNullToZero(CommitteeNum.EditValue)
            mcls.CommitteeName = ConvertNullToString(CommitteeName.EditValue)
            mcls.CheckLimitReserve = ConvertNullToZero(CheckLimitReserve.Checked)
            mcls.CheckLimitSellOrder = ConvertNullToZero(CheckLimitSellOrder.Checked)
            mcls.CheckLimitInvoice = ConvertNullToZero(CheckLimitInvoice.Checked)
            mcls.CheckLimitShiping = ConvertNullToZero(CheckLimitShiping.Checked)
            mcls.IsApproveQua = ConvertNullToZero(IsApproveQua.Checked)
            mcls.IsApproveReserve = ConvertNullToZero(IsApproveReserve.Checked)
            mcls.IsApproveSellOrder = ConvertNullToZero(IsApproveSellOrder.Checked)
            mcls.IsApproveOffer = ConvertNullToZero(IsApproveOffer.Checked)
            mcls.IsApproveBuyOrder = ConvertNullToZero(IsApproveBuyOrder.Checked)
            mcls.IsApproveInvoice = ConvertNullToZero(IsApproveInvoice.Checked)
            mcls.IsApproveShiping = ConvertNullToZero(IsApproveShiping.Checked)
            mcls.IsApproveBorrow = ConvertNullToZero(IsApproveBorrow.Checked)
            mcls.IsInActive = UcAdmin1.CheckInAcive.Checked
            mcls.IsMainCompany = IIf(IsMainCompanyYes.Checked, 1, 0)
            mcls.Branch = ConvertNullToZero(Branch.EditValue)
            mcls.NoteDAOs = UcNote1.GetNoteDAOs
            mcls.FileAttachs = UcFileAttach1.GetFileAttachs
            mcls.AddressS = UcAddress1.GetAddressDAO
            mcls.HistoryDAO = UcHistory1.GetDAO
            mcls.BankAccount = ConvertNullToString(BankAccount.EditValue)
            mcls.BankAccount2 = ConvertNullToString(BankAccount2.EditValue)
            If Verify() = True Then
                Return mcls.SaveData()
            Else
                ShowProgress(False, "")
                XtraMessageBox.Show(Me, "พบข้อผิดพลาดกรุณาตรวจสอบ", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    

#End Region

#Region "Private"

    Private Sub InitialCombo()
        Try
            SetComboTaxType()

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".InitialCombo : " & e.Message)
        End Try
    End Sub

    Private Function LoadData(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        Dim lclsProvince As New ProvinceDAO
        Try
            If pMode = DataMode.ModeNew Then
                UcAddress1.InitailData(Nothing, lclsProvince.GetDataTable())
            ElseIf pMode = DataMode.ModeEdit Or pMode = DataMode.ModeCopy Then
                If mcls.InitailData(pID) Then
                    If pMode = DataMode.ModeEdit Then
                        UcAdmin1.CheckInAcive.Checked = mcls.IsInActive
                        UcAdmin1.txtCreateBy.Text = mcls.CreateBy.Trim
                        UcAdmin1.txtCreateTime.Text = mcls.CreateTime
                        UcAdmin1.txtModifiBy.Text = mcls.ModifiedBy.Trim
                        UcAdmin1.txtModifiTime.Text = mcls.ModifiedTime
                        UcFileAttach1.ShowControl(mcls.FileAttachs)
                    ElseIf pMode = DataMode.ModeCopy Then
                        MyBase.SetMode = DataMode.ModeNew


                    End If
                     
                    CompanyNames.Text = mcls.FirstName
                    CompanyNameEng.Text = mcls.FirstNameEng
                    Owners.Text = mcls.Owner
                    TaxID.Text = mcls.TaxID
                    TaxType.EditValue = mcls.TaxType
                    TaxRate.EditValue = mcls.TaxRate
                    RegisterDate.EditValue = mcls.RegisterDate
                    Remark.Text = mcls.Remark
                    RegisterNo.Text = mcls.RegisterNo
                    RegisterAsset.EditValue = mcls.RegisterAsset
                    RegisterNum.EditValue = mcls.RegisterNum
                    RegisterCost.EditValue = mcls.RegisterCost
                    CommitteeNum.EditValue = mcls.CommitteeNum
                    CommitteeName.Text = mcls.CommitteeName
                    BankAccount.EditValue = mcls.BankAccount
                    BankAccount2.EditValue = mcls.BankAccount2
                    CheckLimitReserve.Checked = mcls.CheckLimitReserve
                    CheckLimitSellOrder.Checked = mcls.CheckLimitSellOrder
                    IsApproveQua.Checked = mcls.IsApproveQua
                    IsApproveReserve.Checked = mcls.IsApproveReserve
                    IsApproveSellOrder.Checked = mcls.IsApproveSellOrder
                    IsApproveOffer.Checked = mcls.IsApproveOffer
                    IsApproveBuyOrder.Checked = mcls.IsApproveBuyOrder
                    UcAddress1.InitailData(mcls.AddressS, lclsProvince.GetDataTable())
                    If mcls.IsMainCompany = 1 Then
                        IsMainCompanyYes.Checked = True
                    Else
                        IsMainCompanyNo.Checked = True
                    End If
                    Branch.EditValue = ConvertNullToZero(mcls.Branch)
                    UcHistory1.InitailData(mcls.HistoryDAO)
                End If
            End If

            'Note
            UcNote1.ShowControl(mcls.TableName, pID)


        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".LoadData : " & ex.Message)
            Return False
        Finally
            lclsProvince = Nothing
        End Try
    End Function

   

    Private Function Verify() As Boolean
        Try
            DxErrorProvider1.ClearErrors()
            If Trim(CompanyNames.Text) = "" Then
                SetErrorProvider(DxErrorProvider1, CompanyNames, "กรุณาระบุข้อมูล")
            ElseIf mcls.CheckExist() Then
                SetErrorProvider(DxErrorProvider1, CompanyNames, "ข้อมูลซ้ำ")
            End If
            Return DxErrorProvider1.HasErrors = False
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".Verify : " & e.Message)
        End Try
    End Function
#End Region

#Region "Set combo"
   Private Sub SetComboTaxType()
        Try
            TaxType.Properties.Items.Add("แยกนอก")
            TaxType.Properties.Items.Add("รวมใน")
            TaxType.Properties.Items.Add("ยกเว้น")
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "frmLead.SetComboPrefix : " & e.Message)
        End Try
    End Sub
#End Region


    Private Function Highlighter1() As Object
        Throw New NotImplementedException
    End Function

   Private Sub IsMainCompanyYes_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles IsMainCompanyYes.CheckedChanged
        Branch.Enabled = IsMainCompanyYes.Checked = False
        Branch.TabStop = IsMainCompanyYes.Checked = False
    End Sub

  
End Class