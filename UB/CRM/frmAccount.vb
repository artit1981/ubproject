Option Explicit On

Imports DevExpress.XtraEditors

Public Class frmAccount
    Inherits iEditForm
    Private Const mFormName As String = "frmAccount"
    Dim mcls As New CustomerDAO


#Region "Overrides"
    Protected Overrides Sub OnLoadForm(ByVal pMode As Integer, ByVal pID As Long, ByVal pOrderType As Long, ByVal pclsConvert As iOrder, ByVal pCusID As Long)
        Try
            InitialCombo()
            Call LoadData(pMode, pID)

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".OnLoadForm : " & e.Message)
        End Try
    End Sub

    Protected Overrides Sub ClearAllForm(ByVal pMode As Integer)
        Try
            MyBase.ClearAllForm(pMode)
            Select Case pMode
                Case DataMode.ModeNew, DataMode.ModeCopy, DataMode.ModeConvert
                    AccountCode.Properties.ReadOnly = False
                    btnGenID.Enabled = True

                    ClearForm(GeneralTabPage)
                    ClearForm(UcSWOT1)
                    ClearForm(UcAdmin1)
                    ClearForm(UcCreditInfo1)
                    UcFileAttach1.ClearControl()
                    UcAddress1.ClearControl()
                    UcAddress2.ClearControl()
                    UcNote1.ClearControl()
                    UcHistory1.ClearControl()

                Case DataMode.ModeEdit
                    'AccountCode.Properties.ReadOnly = True
                    btnGenID.Enabled = False
            End Select

            XtraTabControl1.SelectedTabPage = GeneralTabPage
            UcCreditInfo1.IsHoldButgetYes.Checked = False
            AccountCode.Select()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".ClearAllForm : " & e.Message)
        End Try

    End Sub

    Protected Overrides Function Save(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        XtraTabControl1.SelectedTabPage = GeneralTabPage
        Try
            mcls.TableID = MasterType.Accounts
            mcls.IsQuick = "No"

            mcls.ID = pID
            mcls.ModeData = pMode
            mcls.Code = AccountCode.Text.Trim
            mcls.CompanyName = txtCompanyName.Text.Trim
            mcls.Rating = cboRating.EditValue
            mcls.ContactPersonID = ConvertNullToZero(ContactPersonID.EditValue)
            mcls.DecisionMakerID = ConvertNullToZero(DecisionMakerID.EditValue)
            mcls.NoOfEmployee = ConvertNullToZero(txtNoOfEmployee.EditValue)
            mcls.AnnualRevenue = ConvertNullToZero(txtAnnualRevenue.EditValue)
            mcls.EstimatedBudjet = ConvertNullToZero(txtEstimatedBudjet.EditValue)
            mcls.VatTypeID = ConvertNullToZero(UcCreditInfo1.VatTypeID.GetColumnValue("ID"))
            mcls.BillDay = ConvertNullToZero(UcCreditInfo1.BillDay.EditValue)
            mcls.ChqDay = ConvertNullToZero(UcCreditInfo1.ChqDay.EditValue)
            mcls.BillDayTo = ConvertNullToZero(UcCreditInfo1.BillDayTo.EditValue)
            mcls.ChqDayTo = ConvertNullToZero(UcCreditInfo1.ChqDayTo.EditValue)
            mcls.Branch = ConvertNullToZero(UcCreditInfo1.Branch.EditValue)
            mcls.SendBy = UcCreditInfo1.SendBy.Text.Trim
            mcls.Remark = txtRemark.Text.Trim
            mcls.ContactRole = ContactRule.EditValue
            mcls.SourceID = ConvertNullToZero(cboSource.GetColumnValue("ID"))
            mcls.IndustryTypeID = ConvertNullToZero(cboIndustryType.GetColumnValue("ID"))
            mcls.BusinessTypeID = ConvertNullToZero(cboBusinessType.GetColumnValue("ID"))
            mcls.EstimatedBudjet = ConvertNullToZero(txtEstimatedBudjet.EditValue)

            mcls.BuyingTimeFrame = ConvertNullToZero(UcCreditInfo1.txtBuyingTimeFrame.EditValue)
            mcls.CreditAmount = ConvertNullToZero(UcCreditInfo1.CreditAmount.EditValue)
            mcls.CreditRuleID = ConvertNullToZero(UcCreditInfo1.cboCreditRule.GetColumnValue("ID"))
            mcls.CurrencyID = ConvertNullToZero(UcCreditInfo1.cboCurrency.GetColumnValue("ID"))
            mcls.TerritoryID = ConvertNullToZero(UcCreditInfo1.cboTerritory.GetColumnValue("ID"))
            mcls.CriterionPriceID = ConvertNullToZero(UcCreditInfo1.CriterionPriceID.GetColumnValue("ID"))
            mcls.CompanyTypeID = ConvertNullToZero(CompanyType.GetColumnValue("ID"))
            mcls.CompanyRelateID = ConvertNullToZero(CompanyRelateID.EditValue)
            mcls.CreditGroupID = ConvertNullToZero(UcCreditInfo1.CreditGroupID.GetColumnValue("ID"))
            mcls.EmpID = ConvertNullToZero(UcCreditInfo1.cboEmp.EditValue)
            mcls.CustomerZoneID = ConvertNullToZero(UcCreditInfo1.CustomerZoneID.EditValue)
            mcls.CustomerGroupID = ConvertNullToZero(UcCreditInfo1.CustomerGroupID.EditValue)
            mcls.IsCorporation = IIf(UcCreditInfo1.IsCorporationYes.Checked, 1, 0)
            mcls.IsMainCompany = IIf(UcCreditInfo1.IsMainCompanyYes.Checked, 1, 0)
            mcls.IsHoldButget = IIf(UcCreditInfo1.IsHoldButgetYes.Checked, 1, 0)
            mcls.BankAccountID1 = ConvertNullToZero(UcCreditInfo1.BankAccountID1.EditValue)
            mcls.BankAccountID2 = ConvertNullToZero(UcCreditInfo1.BankAccountID2.EditValue)
            mcls.BankAccountID3 = ConvertNullToZero(UcCreditInfo1.BankAccountID3.EditValue)

            mcls.IsInActive = UcAdmin1.CheckInAcive.Checked

            mcls.NoteDAOs = UcNote1.GetNoteDAOs
            mcls.FileAttachs = UcFileAttach1.GetFileAttachs
            mcls.AddressS = UcAddress1.GetAddressDAO
            mcls.AddressShip = UcAddress2.GetAddressDAO
            mcls.HistoryDAO = UcHistory1.GetDAO
            If Verify() = True Then
                Return mcls.SaveData()

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

    Private Sub btnRefreshLeadType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshLeadType.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboContactRole()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub btnRefreshSource_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshSource.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboSource()
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

            SetComboDecisionMakerID()
            SetComboContactRole()
            SetComboSource()
            SetComboIndustryType()
            SetComboBusinessType()
            SetComboCustomer()
            SetComboContacts()
            SetComboCompanyType()

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".InitialCombo : " & e.Message)
        End Try
    End Sub

    Private Function LoadData(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        Dim lclsProvince As New ProvinceDAO
        Try
            UcCreditInfo1.ShowControl(pID, pMode)
            If pMode = DataMode.ModeNew Then
                AccountCode.EditValue = AutoGenCode(MasterType.Accounts)
                UcAddress1.InitailData(Nothing, lclsProvince.GetDataTable())
                UcAddress2.InitailData(Nothing, lclsProvince.GetDataTable())
                UcCreditInfo1.cboEmp.EditValue = gEmpID
            ElseIf pMode = DataMode.ModeConvert Then
                Call LoadConvert(pID)
                MyBase.SetMode = DataMode.ModeNew
            ElseIf pMode = DataMode.ModeEdit Or pMode = DataMode.ModeCopy Then

                mcls.TableID = MasterType.Accounts
                If mcls.InitailData(pID) Then
                    If pMode = DataMode.ModeEdit Then
                        AccountCode.Text = mcls.Code
                        If Not mcls.Lead Is Nothing Then
                            LeadID.Text = mcls.Lead.Subject
                        End If

                        UcAdmin1.CheckInAcive.Checked = mcls.IsInActive
                        UcAdmin1.txtCreateBy.Text = mcls.CreateBy.Trim
                        UcAdmin1.txtCreateTime.Text = mcls.CreateTime
                        UcAdmin1.txtModifiBy.Text = mcls.ModifiedBy.Trim
                        UcAdmin1.txtModifiTime.Text = mcls.ModifiedTime

                        UcFileAttach1.ShowControl(mcls.FileAttachs)

                    ElseIf pMode = DataMode.ModeCopy Then
                        MyBase.SetMode = DataMode.ModeNew

                        AccountCode.EditValue = AutoGenCode(MasterType.Accounts)
                        LeadID.Text = ""
                    End If


                    txtCompanyName.Text = mcls.CompanyName
                    cboRating.Text = mcls.Rating
                    ContactPersonID.EditValue = mcls.ContactPersonID
                    DecisionMakerID.EditValue = mcls.DecisionMakerID
                    txtNoOfEmployee.EditValue = mcls.NoOfEmployee
                    txtAnnualRevenue.EditValue = mcls.AnnualRevenue
                    txtEstimatedBudjet.EditValue = mcls.EstimatedBudjet
                    UcCreditInfo1.VatTypeID.EditValue = mcls.VatTypeID
                    txtRemark.Text = mcls.Remark
                    ContactRule.Text = mcls.ContactRole
                    cboSource.EditValue = mcls.SourceID
                    UcCreditInfo1.CriterionPriceID.EditValue = mcls.CriterionPriceID
                    cboIndustryType.EditValue = mcls.IndustryTypeID
                    cboBusinessType.EditValue = mcls.BusinessTypeID
                    UcCreditInfo1.Branch.EditValue = ConvertNullToZero(mcls.Branch)
                    UcCreditInfo1.CreditAmount.EditValue = mcls.CreditAmount
                    txtEstimatedBudjet.EditValue = mcls.EstimatedBudjet


                    UcCreditInfo1.txtBuyingTimeFrame.EditValue = mcls.BuyingTimeFrame
                    UcCreditInfo1.cboCreditRule.EditValue = mcls.CreditRuleID
                    UcCreditInfo1.cboCurrency.EditValue = mcls.CurrencyID
                    UcCreditInfo1.cboTerritory.EditValue = mcls.TerritoryID
                    UcCreditInfo1.CreditGroupID.EditValue = mcls.CreditGroupID
                    UcCreditInfo1.BillDay.EditValue = mcls.BillDay
                    UcCreditInfo1.ChqDay.EditValue = mcls.ChqDay
                    UcCreditInfo1.BillDayTo.EditValue = mcls.BillDayTo
                    UcCreditInfo1.ChqDayTo.EditValue = mcls.ChqDayTo
                    UcCreditInfo1.cboEmp.EditValue = mcls.EmpID
                    UcCreditInfo1.SendBy.Text = mcls.SendBy
                    UcCreditInfo1.CustomerZoneID.EditValue = mcls.CustomerZoneID
                    UcCreditInfo1.CustomerGroupID.EditValue = mcls.CustomerGroupID
                    UcCreditInfo1.BankAccountID1.EditValue = mcls.BankAccountID1
                    UcCreditInfo1.BankAccountID2.EditValue = mcls.BankAccountID2
                    UcCreditInfo1.BankAccountID3.EditValue = mcls.BankAccountID3

                    If mcls.IsMainCompany = 1 Then
                        UcCreditInfo1.IsMainCompanyYes.Checked = True
                    Else
                        UcCreditInfo1.IsMainCompanyNo.Checked = True
                    End If
                    If mcls.IsHoldButget = 1 Then
                        UcCreditInfo1.IsHoldButgetYes.Checked = True
                    Else
                        UcCreditInfo1.IsHoldButgetNo.Checked = True
                    End If
                    If mcls.IsCorporation = 1 Then
                        UcCreditInfo1.IsCorporationYes.Checked = True
                    Else
                        UcCreditInfo1.IsCorporationNo.Checked = True
                    End If
                    CompanyType.EditValue = mcls.CompanyTypeID
                    CompanyRelateID.EditValue = mcls.CompanyRelateID


                    UcAddress1.InitailData(mcls.AddressS, lclsProvince.GetDataTable())
                    UcAddress2.InitailData(mcls.AddressShip, lclsProvince.GetDataTable())
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



    Private Function LoadConvert(ByVal pID As Long) As Boolean
        Dim lclsProvince As New ProvinceDAO
        Try

            AccountCode.EditValue = AutoGenCode(MasterType.Accounts)

            mcls = Nothing
            mcls = New CustomerDAO
            mcls.TableID = MasterType.Accounts
            mcls.LeadID = pID

            If Not mcls.Lead Is Nothing Then

                LeadID.Text = mcls.Lead.Subject
                txtCompanyName.Text = mcls.Lead.Title & mcls.Lead.FirstName & " " & mcls.Lead.LastName
                cboRating.Text = mcls.Lead.Rating
                txtNoOfEmployee.EditValue = mcls.Lead.NoOfEmployee
                txtAnnualRevenue.EditValue = mcls.Lead.AnnualRevenue
                txtEstimatedBudjet.EditValue = mcls.Lead.EstimatedBudjet
                txtRemark.Text = mcls.Lead.Remark
                cboSource.EditValue = mcls.Lead.SourceID
                cboIndustryType.EditValue = mcls.Lead.IndustryTypeID
                cboBusinessType.EditValue = mcls.Lead.BusinessTypeID
                txtEstimatedBudjet.EditValue = mcls.Lead.EstimatedBudjet
                UcCreditInfo1.txtBuyingTimeFrame.EditValue = mcls.Lead.BuyingTimeFrame
                UcCreditInfo1.cboTerritory.EditValue = mcls.Lead.TerritoryID
                UcCreditInfo1.CreditGroupID.EditValue = mcls.Lead.CreditGroupID
                UcCreditInfo1.cboEmp.EditValue = mcls.Lead.EmpID
                UcCreditInfo1.Branch.EditValue = mcls.Branch
                UcAddress1.InitailData(mcls.Lead.AddressS, lclsProvince.GetDataTable())
                UcAddress2.InitailData(mcls.Lead.AddressS, lclsProvince.GetDataTable())
            End If



        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".LoadConvert : " & ex.Message)
            Return False
        Finally
            lclsProvince = Nothing
        End Try
    End Function


    Private Function Verify() As Boolean
        Dim lstrErr As String = ""
        Try
            DxErrorProvider1.ClearErrors()
            If Trim(AccountCode.Text) = "" Then
                SetErrorProvider(DxErrorProvider1, AccountCode, "กรุณาระบุรหัสลูกค้า")
            ElseIf mcls.CheckExist() Then
                SetErrorProvider(DxErrorProvider1, AccountCode, "รหัสลูกค้าซ้ำ")
            End If
            lstrErr = lstrErr & DxErrorProvider1.GetError(AccountCode) & vbNewLine

            If Trim(txtCompanyName.Text) = "" Then
                SetErrorProvider(DxErrorProvider1, txtCompanyName, "กรุณาระบุชื่อบริษัท")
                lstrErr = lstrErr & DxErrorProvider1.GetError(txtCompanyName) & vbNewLine
            End If

            If ConvertNullToZero(UcCreditInfo1.cboCreditRule.EditValue) = 0 Then
                SetErrorProvider(DxErrorProvider1, UcCreditInfo1.cboCreditRule, "กรุณาระบุเงื่อนไขการชำระเงิน")
                lstrErr = lstrErr & DxErrorProvider1.GetError(UcCreditInfo1.cboCreditRule) & vbNewLine

            End If

            If ConvertNullToZero(UcCreditInfo1.VatTypeID.EditValue) = 0 Then
                SetErrorProvider(DxErrorProvider1, UcCreditInfo1.VatTypeID, "กรุณาระบุรูปแบบภาษี")
                lstrErr = lstrErr & DxErrorProvider1.GetError(UcCreditInfo1.VatTypeID) & vbNewLine

            End If
            If ConvertNullToZero(UcCreditInfo1.cboCurrency.EditValue) = 0 Then
                SetErrorProvider(DxErrorProvider1, UcCreditInfo1.cboCurrency, "กรุณาระบุสกุลเงิน")
                lstrErr = lstrErr & DxErrorProvider1.GetError(UcCreditInfo1.cboCurrency) & vbNewLine

            End If
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




#End Region

#Region "Set combo"

    'Private Sub SetComboOwner()
    '    Try
    '        Call SetComboContact(OwnerID)
    '    Catch e As Exception
    '        Err.Raise(Err.Number, e.Source, mFormName & ".SetComboOwner : " & e.Message)
    '    End Try
    'End Sub


    Private Sub SetComboDecisionMakerID()
        Try
            Call SetComboContact(DecisionMakerID)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboDecisionMakerID : " & e.Message)
        End Try
    End Sub


    Private Sub SetComboContactRole()
        Try
            SetComboMaster(ContactRule, MasterType.ContactRole, True)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboContactRole : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboSource()
        Try
            SetComboMasterLook(cboSource, MasterType.Source)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboSource : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboIndustryType()
        Try
            SetComboMasterLook(cboIndustryType, MasterType.IndustryType)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboIndustryType : " & e.Message)
        End Try

    End Sub


    Private Sub SetComboCustomer()
        Try
            SetSearchLookCustomer(CompanyRelateID, False, False)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboCustomer : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboContacts()
        Try
            SetComboContact(ContactPersonID)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboContact : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboCompanyType()
        Try
            SetComboMasterLook(CompanyType, MasterType.CompanyType)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboCompanyType : " & e.Message)
        End Try
    End Sub

  
    Private Sub SetComboBusinessType()
        Try
            SetComboMasterLook(cboBusinessType, MasterType.BusinessType)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".BusinessType : " & e.Message)
        End Try
    End Sub

#End Region

    Private Sub btnRefreshIndustryType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshIndustryType.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboIndustryType()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub btnRefreshBusinessType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshBusinessType.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboBusinessType()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub


    'Private Sub btnOwner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        ShowProgress(True, "Loading...")
    '        SetComboOwner()
    '    Catch ex As Exception
    '        ShowErrorMsg(False, ex.Message)
    '    Finally
    '        ShowProgress(False, "")
    '    End Try
    'End Sub

    Private Sub btnDecision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecision.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboDecisionMakerID()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub btnGenID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenID.Click
        Try
            ShowProgress(True, "Loading...")
            AccountCode.EditValue = AutoGenCode(MasterType.Accounts)
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try

    End Sub

    Private Sub FormChangedComponent1_FormControlChanged1(ByVal sender As Object, ByVal e As FormChangedEventArgs) Handles FormChangedComponent1.FormControlChanged
        MyBase.CheckFormChanged()
    End Sub

    Private Sub GeneralTabPage_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles GeneralTabPage.Paint

    End Sub

    Private Function Highlighter1() As Object
        Throw New NotImplementedException
    End Function



    Private Sub btnCompanyType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompanyType.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboCompanyType()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub btnCompanyRelateID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompanyRelateID.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboCustomer()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub
       
    Private Sub btnContactPersonID_Click(sender As System.Object, e As System.EventArgs) Handles btnContactPersonID.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboContacts()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub
 
End Class