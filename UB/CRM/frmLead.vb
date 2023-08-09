Option Explicit On

Imports DevExpress.XtraEditors


Public Class frmLead
    Inherits iEditForm
    Private Const mFormName As String = "frmLead"
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
                Case DataMode.ModeNew
                    ClearForm(GeneralTabPage)
                    ClearForm(UcSWOT1)
                    ClearForm(UcAdmin1)
                    UcFileAttach1.ClearControl()
                    UcAddress1.ClearControl()
                    UcNote1.ClearControl()
                    UcProductLists1.ClearControl()
            End Select

            XtraTabControl1.SelectedTabPage = GeneralTabPage
            txtSUBJECT.Select()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".ClearAllForm : " & e.Message)
        End Try
    End Sub

    Protected Overrides Function Save(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        XtraTabControl1.SelectedTabPage = GeneralTabPage
        Try
            mcls.TableID = MasterType.Lead
            mcls.IsQuick = "No"
            mcls.IsConvert = "No"
            mcls.ID = pID
            mcls.ModeData = pMode
            mcls.Subject = txtSUBJECT.Text.Trim
            mcls.Title = cboTITLE.Text.Trim
            mcls.LeadType = cboLeadType.Text.Trim
            mcls.SourceID = ConvertNullToZero(cboSource.GetColumnValue("ID"))
            mcls.FirstName = txtFIRSTNAME.Text.Trim
            mcls.LastName = txtLASTNAME.Text.Trim
            mcls.CompanyName = txtCOMPANYNAME.Text.Trim
            mcls.Remark = txtRemark.Text.Trim
            mcls.IsInActive = UcAdmin1.CheckInAcive.Checked

            mcls.LeadStatus = txtLeadStatus.Text
            mcls.Rating = cboRating.Text
            mcls.DisqualifyStatus = txtDisqualifyStatus.Text
            mcls.Position = txtPosition.Text
            mcls.IndustryTypeID = ConvertNullToZero(cboIndustryType.GetColumnValue("ID"))
            mcls.BusinessTypeID = ConvertNullToZero(cboBusinessType.GetColumnValue("ID"))
            mcls.TerritoryID = ConvertNullToZero(cboTerritory.GetColumnValue("ID"))
            mcls.NoOfEmployee = ConvertNullToZero(txtNoOfEmployee.Text)
            mcls.AnnualRevenue = ConvertNullToZero(txtAnnualRevenue.Text)
            mcls.EsttablishedDate = dtpEsttablishedDate.EditValue
            mcls.BuyingTimeFrame = ConvertNullToZero(txtBuyingTimeFrame.Text)
            mcls.EstimatedBudjet = ConvertNullToZero(txtEstimatedBudjet.Text)
            mcls.Capital = ConvertNullToZero(txtCapital.Text)
            mcls.CompanyRelateID = ConvertNullToZero(CustomerID.EditValue)
            mcls.NoteDAOs = UcNote1.GetNoteDAOs
            mcls.FileAttachs = UcFileAttach1.GetFileAttachs
            mcls.AddressS = UcAddress1.GetAddressDAO
            mcls.ProductDAOs = UcProductLists1.GetDAOs(False, True, False, Nothing, False, 0, False, "", pMode, "")
            If Verify() = True Then
                Return mcls.SaveData(Nothing)
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

    Private Sub FormChangedComponent1_FormControlChanged1(ByVal sender As Object, ByVal e As FormChangedEventArgs) Handles FormChangedComponent1.FormControlChanged
        MyBase.CheckFormChanged()
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

    Private Sub btnRefreshLeadType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshLeadType.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboLeadType()
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
            SetComboCustomer()
            SetComboPrefix()
            SetComboLeadType()
            SetComboSource()
            SetComboIndustryType()
            SetComboBusinessType()
            SetComboTerritory()
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
                mcls.TableID = MasterType.Lead
                If mcls.InitailData(pID) Then
                    If pMode = DataMode.ModeEdit Then
                        UcAdmin1.CheckInAcive.Checked = mcls.IsInActive
                        UcAdmin1.txtCreateBy.Text = mcls.CreateBy.Trim
                        UcAdmin1.txtCreateTime.Text = mcls.CreateTime
                        UcAdmin1.txtModifiBy.Text = mcls.ModifiedBy.Trim
                        UcAdmin1.txtModifiTime.Text = mcls.ModifiedTime

                        ''FileAttachs
                        UcFileAttach1.ShowControl(mcls.FileAttachs)
                    ElseIf pMode = DataMode.ModeCopy Then
                        MyBase.SetMode = DataMode.ModeNew
                    End If
                    txtSUBJECT.Text = mcls.Subject
                    cboTITLE.Text = mcls.Title
                    txtFIRSTNAME.Text = mcls.FirstName
                    txtLASTNAME.Text = mcls.LastName
                    txtCOMPANYNAME.Text = mcls.CompanyName
                    cboLeadType.Text = mcls.LeadType
                    cboSource.EditValue = mcls.SourceID
                    txtLeadStatus.Text = mcls.LeadStatus
                    cboRating.Text = mcls.Rating
                    txtDisqualifyStatus.Text = mcls.DisqualifyStatus
                    txtPosition.Text = mcls.Position
                    cboIndustryType.EditValue = mcls.IndustryTypeID
                    cboBusinessType.EditValue = mcls.BusinessTypeID
                    cboTerritory.EditValue = mcls.TerritoryID
                    txtNoOfEmployee.Text = mcls.NoOfEmployee
                    txtAnnualRevenue.Text = mcls.AnnualRevenue
                    dtpEsttablishedDate.EditValue = mcls.EsttablishedDate
                    txtBuyingTimeFrame.Text = mcls.BuyingTimeFrame
                    txtEstimatedBudjet.Text = mcls.EstimatedBudjet
                    txtCapital.Text = mcls.Capital
                    CustomerID.EditValue = mcls.CompanyRelateID
                    txtEmp.Text = mcls.EmployeeDAO.Title & " " & mcls.EmployeeDAO.FirstName & " " & mcls.EmployeeDAO.LastName
                    txtRemark.Text = mcls.Remark
                    ''Address
                    UcAddress1.InitailData(mcls.AddressS, lclsProvince.GetDataTable())

                End If
            End If

            'Note
            UcNote1.ShowControl(mcls.TableName, pID)
            'gCustomerID = mcls.ID
            Dim lOrderList As New List(Of Long)
            lOrderList.Add(mcls.ID)
            UcProductLists1.CustomerID = mcls.ID
            UcProductLists1.ShowControl(pMode, lOrderList, mcls.TableName, ProColumn.Units + ProColumn.Price + ProColumn.UnitName + ProColumn.Total _
                                        , False, True, Nothing, True, mcls.TableName, False, False, "")

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
            If Trim(txtSUBJECT.Text) = "" Then
                SetErrorProvider(DxErrorProvider1, txtSUBJECT, "กรุณาระบุข้อมูล")
            ElseIf mcls.CheckExist() Then
                SetErrorProvider(DxErrorProvider1, txtSUBJECT, "ข้อมูลซ้ำ")
            End If

            If DxErrorProvider1.HasErrors = False Then
                If UcProductLists1.IsError <> "" Then
                    XtraTabControl1.SelectedTabPage = ProductTabPage
                    Return False
                End If
            End If

            Return DxErrorProvider1.HasErrors = False
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".Verify : " & e.Message)
        End Try
    End Function



#End Region

#Region "Set combo"
    Private Sub SetComboCustomer()
        Try
            SetSearchLookCustomer(CustomerID, False, False)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboCustomer : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboPrefix()
        Try
            SetComboMaster(cboTITLE, MasterType.Prefix, True)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboPrefix : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboLeadType()
        Try
            SetComboMaster(cboLeadType, MasterType.LeadType, True)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboLeadType : " & e.Message)
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

#End Region



End Class