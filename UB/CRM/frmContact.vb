Option Explicit On

Imports DevExpress.XtraEditors

Public Class frmContact
    Inherits iEditForm
    Private Const mFormName As String = "frmContact"
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
                    ClearForm(GeneralTabPage)
                    ClearForm(UcSWOT1)
                    ClearForm(UcAdmin1)
                    UcFileAttach1.ClearControl()
                    UcAddress1.ClearControl()
                    UcAddress2.ClearControl()
                    UcNote1.ClearControl()
                    UcHistory1.ClearControl()
                Case DataMode.ModeEdit
                    'ContactCode.Properties.ReadOnly = True
                    btnGenID.Enabled = False
            End Select

            XtraTabControl1.SelectedTabPage = GeneralTabPage
            UcCreditInfo1.IsHoldButgetNo.Checked = True
            ContactCode.Select()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".ClearAllForm : " & e.Message)
        End Try

    End Sub

    Protected Overrides Function Save(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        XtraTabControl1.SelectedTabPage = GeneralTabPage
        Try
            mcls.TableID = MasterType.Contacts
            mcls.IsQuick = "No"

            mcls.ID = pID
            mcls.ModeData = pMode
            mcls.Code = ContactCode.Text.Trim
            mcls.Title = cboTITLE.Text.Trim
            mcls.FirstName = txtFIRSTNAME.Text.Trim
            mcls.LastName = txtLASTNAME.Text.Trim
            mcls.CompanyName = txtCompanyName.Text.Trim
            mcls.Position = txtPosition.Text
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
            mcls.VatTypeID = ConvertNullToZero(UcCreditInfo1.VatTypeID.GetColumnValue("ID"))
            mcls.BillDay = ConvertNullToZero(UcCreditInfo1.BillDay.EditValue)
            mcls.ChqDay = ConvertNullToZero(UcCreditInfo1.ChqDay.EditValue)
            mcls.BillDayTo = ConvertNullToZero(UcCreditInfo1.BillDayTo.EditValue)
            mcls.ChqDayTo = ConvertNullToZero(UcCreditInfo1.ChqDayTo.EditValue)
            mcls.EmpID = ConvertNullToZero(UcCreditInfo1.cboEmp.EditValue)
            mcls.Branch = ConvertNullToZero(UcCreditInfo1.Branch.EditValue)
            mcls.ContactPersonID = ConvertNullToZero(ContactPersonID.EditValue)
            mcls.CustomerZoneID = ConvertNullToZero(UcCreditInfo1.CustomerZoneID.EditValue)
            mcls.CustomerGroupID = ConvertNullToZero(UcCreditInfo1.CustomerGroupID.EditValue)
            mcls.IsCorporation = IIf(UcCreditInfo1.IsCorporationYes.Checked, 1, 0)
            mcls.IsMainCompany = IIf(UcCreditInfo1.IsMainCompanyYes.Checked, 1, 0)
            mcls.IsHoldButget = IIf(UcCreditInfo1.IsHoldButgetYes.Checked, 1, 0)
            mcls.SendBy = UcCreditInfo1.SendBy.Text.Trim
            mcls.CriterionPriceID = ConvertNullToZero(UcCreditInfo1.CriterionPriceID.GetColumnValue("ID"))
            mcls.CreditGroupID = ConvertNullToZero(UcCreditInfo1.CreditGroupID.GetColumnValue("ID"))
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

    Private Sub btnRefreshTitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshTitle.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboPrefix()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub


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



    Private Sub btnGenID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenID.Click
        Try
            ShowProgress(True, "Loading...")
            ContactCode.EditValue = AutoGenCode(MasterType.Contacts)
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
            SetComboPrefix()
            SetComboContactRole()
            SetComboSource()
            SetComboIndustryType()
            SetComboBusinessType()
            SetComboContacts()

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".InitialCombo : " & e.Message)
        End Try
    End Sub

    Private Function LoadData(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        Dim lclsProvince As New ProvinceDAO
        Try

            UcCreditInfo1.ShowControl(pID, pMode)
            If pMode = DataMode.ModeNew Then
                ContactCode.EditValue = AutoGenCode(MasterType.Contacts)
                UcAddress1.InitailData(Nothing, lclsProvince.GetDataTable())
                UcAddress2.InitailData(Nothing, lclsProvince.GetDataTable())
                UcCreditInfo1.cboEmp.EditValue = gEmpID
            ElseIf pMode = DataMode.ModeConvert Then
                Call LoadConvert(pID)
                MyBase.SetMode = DataMode.ModeNew
            ElseIf pMode = DataMode.ModeEdit Or pMode = DataMode.ModeCopy Then

                mcls.TableID = MasterType.Contacts
                If mcls.InitailData(pID, "") Then
                    If pMode = DataMode.ModeEdit Then
                        If Not mcls.Lead Is Nothing Then
                            LeadID.Text = mcls.Lead.Subject
                        End If

                        ContactCode.Text = mcls.Code
                        UcFileAttach1.ShowControl(mcls.FileAttachs)

                        UcAdmin1.CheckInAcive.Checked = mcls.IsInActive
                        UcAdmin1.txtCreateBy.Text = mcls.CreateBy.Trim
                        UcAdmin1.txtCreateTime.Text = mcls.CreateTime
                        UcAdmin1.txtModifiBy.Text = mcls.ModifiedBy.Trim
                        UcAdmin1.txtModifiTime.Text = mcls.ModifiedTime

                    ElseIf pMode = DataMode.ModeCopy Then
                        MyBase.SetMode = DataMode.ModeNew
                        LeadID.Text = ""
                        ContactCode.EditValue = AutoGenCode(MasterType.Contacts)
                    End If


                    cboTITLE.Text = mcls.Title
                    txtFIRSTNAME.Text = mcls.FirstName
                    txtLASTNAME.Text = mcls.LastName
                    txtCompanyName.Text = mcls.CompanyName
                    txtPosition.Text = mcls.Position
                    txtRemark.Text = mcls.Remark
                    ContactRule.Text = mcls.ContactRole
                    ContactPersonID.EditValue = mcls.ContactPersonID
                    cboSource.EditValue = mcls.SourceID
                    UcCreditInfo1.VatTypeID.EditValue = mcls.VatTypeID
                    cboIndustryType.EditValue = mcls.IndustryTypeID
                    cboBusinessType.EditValue = mcls.BusinessTypeID
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
                    UcCreditInfo1.CustomerZoneID.EditValue = mcls.CustomerZoneID
                    UcCreditInfo1.CustomerGroupID.EditValue = mcls.CustomerGroupID

                    UcCreditInfo1.SendBy.Text = mcls.SendBy
                    UcCreditInfo1.Branch.EditValue = ConvertNullToZero(mcls.Branch)
                    UcCreditInfo1.CriterionPriceID.EditValue = mcls.CriterionPriceID
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

            ContactCode.EditValue = AutoGenCode(MasterType.Contacts)

            mcls = Nothing
            mcls = New CustomerDAO
            mcls.TableID = MasterType.Contacts
            mcls.LeadID = pID

            If Not mcls.Lead Is Nothing Then

                LeadID.Text = mcls.Lead.Subject
                cboTITLE.Text = mcls.Lead.Title
                txtFIRSTNAME.Text = mcls.Lead.FirstName
                txtLASTNAME.Text = mcls.Lead.LastName
                txtCompanyName.Text = mcls.Lead.CompanyName
                txtPosition.Text = mcls.Lead.Position
                txtRemark.Text = mcls.Lead.Remark
                cboSource.EditValue = mcls.Lead.SourceID

                cboIndustryType.EditValue = mcls.Lead.IndustryTypeID
                cboBusinessType.EditValue = mcls.Lead.BusinessTypeID
                txtEstimatedBudjet.EditValue = mcls.Lead.EstimatedBudjet
                UcCreditInfo1.txtBuyingTimeFrame.EditValue = mcls.Lead.BuyingTimeFrame
                UcCreditInfo1.cboTerritory.EditValue = mcls.Lead.TerritoryID
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
            If Trim(ContactCode.Text) = "" Then
                SetErrorProvider(DxErrorProvider1, ContactCode, "กรุณาระบุรหัสลูกค้า")
            ElseIf mcls.CheckExist() Then
                SetErrorProvider(DxErrorProvider1, ContactCode, "รหัสลูกค้าซ้ำ")
            End If

            lstrErr = lstrErr & DxErrorProvider1.GetError(ContactCode) & vbNewLine

            If Trim(txtFIRSTNAME.Text) = "" Then
                SetErrorProvider(DxErrorProvider1, txtFIRSTNAME, "กรุณาระบุชื่อลูกค้า")
                lstrErr = lstrErr & DxErrorProvider1.GetError(txtFIRSTNAME) & vbNewLine
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
    Private Sub SetComboPrefix()
        Try
            SetComboMaster(cboTITLE, MasterType.Prefix, True)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboPrefix : " & e.Message)
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

    Private Sub SetComboBusinessType()
        Try
            SetComboMasterLook(cboBusinessType, MasterType.BusinessType)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboBusinessType : " & e.Message)
        End Try
    End Sub
 
    Private Sub SetComboContacts()
        Try
            SetComboContact(ContactPersonID)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboContact : " & e.Message)
        End Try
    End Sub


#End Region


    Private Sub FormChangedComponent1_FormControlChanged1(ByVal sender As Object, ByVal e As FormChangedEventArgs) Handles FormChangedComponent1.FormControlChanged
        MyBase.CheckFormChanged()
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