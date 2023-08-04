Option Explicit On

Imports DevExpress.XtraEditors

Public Class frmAgency
    Inherits iEditForm
    Private Const mFormName As String = "frmAgency"
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
                    UcFileAttach1.ClearControl()
                    UcAddress1.ClearControl()
                    UcNote1.ClearControl()
                    UcHistory1.ClearControl()
                Case DataMode.ModeEdit
                    'AccountCode.Properties.ReadOnly = True
                    btnGenID.Enabled = False
            End Select

            XtraTabControl1.SelectedTabPage = GeneralTabPage
            AccountCode.Select()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".ClearAllForm : " & e.Message)
        End Try

    End Sub

    Protected Overrides Function Save(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        XtraTabControl1.SelectedTabPage = GeneralTabPage
        Try
            mcls.TableID = MasterType.Agency
            mcls.IsQuick = "No"
            mcls.ID = pID
            mcls.ModeData = pMode
            mcls.Code = AccountCode.Text.Trim
            mcls.CompanyName = txtCompanyName.Text.Trim
            mcls.Rating = cboRating.EditValue
            mcls.BarCode = ConvertNullToString(BarCode.Text)
            mcls.NoOfEmployee = ConvertNullToZero(txtNoOfEmployee.EditValue)
            mcls.VatTypeID = ConvertNullToZero(VatTypeID.GetColumnValue("ID"))
            mcls.BillDay = ConvertNullToZero(BillDay.EditValue)
            mcls.ChqDay = ConvertNullToZero(ChqDay.EditValue)
            mcls.BillDayTo = ConvertNullToZero(BillDayTo.EditValue)
            mcls.ChqDayTo = ConvertNullToZero(ChqDayTo.EditValue)
            mcls.SendBy = SendBy.Text.Trim
            mcls.Remark = txtRemark.Text.Trim
            mcls.IndustryTypeID = ConvertNullToZero(cboIndustryType.GetColumnValue("ID"))
            mcls.BusinessTypeID = ConvertNullToZero(cboBusinessType.GetColumnValue("ID"))
            mcls.CreditRuleID = ConvertNullToZero(cboCreditRule.GetColumnValue("ID"))
            mcls.CurrencyID = ConvertNullToZero(cboCurrency.GetColumnValue("ID"))
            mcls.TerritoryID = ConvertNullToZero(cboTerritory.GetColumnValue("ID"))
            mcls.CriterionPriceID = ConvertNullToZero(CriterionPriceID.GetColumnValue("ID"))
            mcls.CompanyTypeID = ConvertNullToZero(CompanyType.GetColumnValue("ID"))
            mcls.CompanyRelateID = ConvertNullToZero(CustomerID.EditValue)
            mcls.IsMainCompany = IIf(IsMainCompanyYes.Checked, 1, 0)
            mcls.Branch = ConvertNullToZero(Branch.EditValue)
            mcls.IsInActive = UcAdmin1.CheckInAcive.Checked
            mcls.NoteDAOs = UcNote1.GetNoteDAOs
            mcls.FileAttachs = UcFileAttach1.GetFileAttachs
            mcls.AddressS = UcAddress1.GetAddressDAO
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

#Region "Private"

    Private Sub InitialCombo()
        Try
            SetComboCreditRole()
            SetComboCurrency()
            SetComboIndustryType()
            SetComboBusinessType()
            SetComboTerritory()
            SetComboCriterionPrice()
            SetComboCustomer()
            SetComboCompanyType()
            SetVatType()

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".InitialCombo : " & e.Message)
        End Try
    End Sub

    Private Function LoadData(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        Dim lclsProvince As New ProvinceDAO
        Try
            If pMode = DataMode.ModeNew Then
                AccountCode.EditValue = AutoGenCode(MasterType.Agency)
                UcAddress1.InitailData(Nothing, lclsProvince.GetDataTable())
            ElseIf pMode = DataMode.ModeEdit Or pMode = DataMode.ModeCopy Then

                mcls.TableID = MasterType.Agency
                If mcls.InitailData(pID) Then
                    If pMode = DataMode.ModeEdit Then
                        AccountCode.Text = mcls.Code
                        If Not mcls.EmployeeDAO Is Nothing Then
                            txtEmp.Text = mcls.EmployeeDAO.Title & " " & mcls.EmployeeDAO.FirstName & " " & mcls.EmployeeDAO.LastName
                        End If
                        UcAdmin1.CheckInAcive.Checked = mcls.IsInActive
                        UcAdmin1.txtCreateBy.Text = mcls.CreateBy.Trim
                        UcAdmin1.txtCreateTime.Text = mcls.CreateTime
                        UcAdmin1.txtModifiBy.Text = mcls.ModifiedBy.Trim
                        UcAdmin1.txtModifiTime.Text = mcls.ModifiedTime

                        UcFileAttach1.ShowControl(mcls.FileAttachs)

                    ElseIf pMode = DataMode.ModeCopy Then
                        MyBase.SetMode = DataMode.ModeNew
                        AccountCode.EditValue = AutoGenCode(MasterType.Agency)
                    End If
                    txtCompanyName.Text = mcls.CompanyName
                    cboRating.Text = mcls.Rating
                    BarCode.Text = mcls.BarCode
                    txtNoOfEmployee.EditValue = mcls.NoOfEmployee
                    VatTypeID.EditValue = mcls.VatTypeID
                    txtRemark.Text = mcls.Remark
                    CriterionPriceID.EditValue = mcls.CriterionPriceID
                    cboIndustryType.EditValue = mcls.IndustryTypeID
                    cboBusinessType.EditValue = mcls.BusinessTypeID
                    cboCreditRule.EditValue = mcls.CreditRuleID
                    cboCurrency.EditValue = mcls.CurrencyID
                    cboTerritory.EditValue = mcls.TerritoryID
                    BillDay.EditValue = mcls.BillDay
                    ChqDay.EditValue = mcls.ChqDay
                    BillDayTo.EditValue = mcls.BillDayTo
                    ChqDayTo.EditValue = mcls.ChqDayTo
                    SendBy.Text = mcls.SendBy
                    Branch.EditValue = ConvertNullToZero(mcls.Branch)
                    If mcls.IsMainCompany = 1 Then
                        IsMainCompanyYes.Checked = True
                    Else
                        IsMainCompanyNo.Checked = True
                    End If
                    CompanyType.EditValue = mcls.CompanyTypeID
                    CustomerID.EditValue = mcls.CompanyRelateID
                    UcAddress1.InitailData(mcls.AddressS, lclsProvince.GetDataTable())
                    UcHistory1.InitailData(mcls.HistoryDAO)
                End If
            End If

            UcNote1.ShowControl(mcls.TableName, pID)
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
            If Trim(AccountCode.Text) = "" Then
                SetErrorProvider(DxErrorProvider1, AccountCode, "กรุณาระบุรหัสเจ้าหนี้")
            ElseIf mcls.CheckExist() Then
                SetErrorProvider(DxErrorProvider1, AccountCode, "รหัสเจ้าหนี้ซ้ำ")
            End If
            lstrErr = lstrErr & DxErrorProvider1.GetError(AccountCode) & vbNewLine

            If Trim(txtCompanyName.Text) = "" Then
                SetErrorProvider(DxErrorProvider1, txtCompanyName, "กรุณาระบุชื่อบริษัท")
                lstrErr = lstrErr & DxErrorProvider1.GetError(txtCompanyName) & vbNewLine
            End If

            If ConvertNullToZero(cboCreditRule.EditValue) = 0 Then
                SetErrorProvider(DxErrorProvider1, cboCreditRule, "กรุณาระบุเงื่อนไขการชำระเงิน")
                lstrErr = lstrErr & DxErrorProvider1.GetError(cboCreditRule) & vbNewLine

            End If

            If ConvertNullToZero(VatTypeID.EditValue) = 0 Then
                SetErrorProvider(DxErrorProvider1, VatTypeID, "กรุณาระบุรูปแบบภาษี")
                lstrErr = lstrErr & DxErrorProvider1.GetError(VatTypeID) & vbNewLine

            End If
            If ConvertNullToZero(cboCurrency.EditValue) = 0 Then
                SetErrorProvider(DxErrorProvider1, cboCurrency, "กรุณาระบุสกุลเงิน")
                lstrErr = lstrErr & DxErrorProvider1.GetError(cboCurrency) & vbNewLine

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
    Private Sub SetVatType()
        Try
            SetLookUpVatType(VatTypeID)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetVatType : " & e.Message)
        End Try
    End Sub


    Private Sub SetComboIndustryType()
        Try
            SetComboMasterLook(cboIndustryType, MasterType.IndustryType)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboIndustryType : " & e.Message)
        End Try

    End Sub

    Private Sub SetComboCriterionPrice()
        Try
            SetComboMasterLook(CriterionPriceID, MasterType.CriterionPrice)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboCriterionPrice : " & e.Message)
        End Try

    End Sub

    Private Sub SetComboCustomer()
        Try
            SetSearchLookCustomer(CustomerID, False, True)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboCustomer : " & e.Message)
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

    Private Sub SetComboTerritory()
        Try
            SetLookUpTerritory(cboTerritory)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboTerritory : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboCreditRole()
        Try
            SetLookUpCreditRole(cboCreditRule)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboCreditRole : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboCurrency()
        Try
            SetLookUpCurrency(cboCurrency)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboCurrency : " & e.Message)
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

    Private Sub btnRefreshTerritory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshTerritory.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboTerritory()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub btnRefreshCreditRule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshCreditRule.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboCreditRole()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub btnRefreshCurrency_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshCurrency.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboCurrency()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub btnGenID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenID.Click
        Try
            ShowProgress(True, "Loading...")
            AccountCode.EditValue = AutoGenCode(MasterType.Agency)
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try

    End Sub

    Private Sub btnVatTypeID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVatTypeID.Click
        Try
            ShowProgress(True, "Loading...")
            SetVatType()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try

    End Sub


    Private Sub FormChangedComponent1_FormControlChanged1(ByVal sender As Object, ByVal e As FormChangedEventArgs) Handles FormChangedComponent1.FormControlChanged
        MyBase.CheckFormChanged()
    End Sub


    Private Function Highlighter1() As Object
        Throw New NotImplementedException
    End Function

    Private Sub btnCriterionPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCriterionPrice.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboCriterionPrice()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

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

    Private Sub btnCustomerID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomerID.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboCustomer()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub IsMainCompanyYes_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles IsMainCompanyYes.CheckedChanged
        Branch.Enabled = IsMainCompanyYes.Checked = False
        Branch.TabStop = IsMainCompanyYes.Checked = False
    End Sub
End Class