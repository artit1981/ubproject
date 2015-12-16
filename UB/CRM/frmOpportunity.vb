
Option Explicit On

Imports DevExpress.XtraEditors

Public Class frmOpportunity
    Inherits iEditForm
    Private Const mFormName As String = "frmOpportunity"
    Dim mcls As New OpportunityDAO


#Region "Overrides"
    Protected Overrides Sub OnLoadForm(ByVal pMode As Integer, ByVal pID As Long, ByVal pOrderType As Long, ByVal pclsConvert As iOrder, ByVal pCusID As Long)
        Try
            InitialCombo()
            Call LoadData(pMode, pID)
            'OptionSubItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            'MakeOrderBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
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
                    ClearForm(UcContactRole1)
                    ClearForm(UcAdmin1)
                    UcFileAttach1.ClearControl()

                    UcNote1.ClearControl()
                    UcProductLists1.ClearControl()
            End Select

            XtraTabControl1.SelectedTabPage = GeneralTabPage
            OppExpireDate.EditValue = DateAdd(DateInterval.Month, 1, GetCurrentDate(Nothing))
            OppName.Select()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".ClearAllForm : " & e.Message)
        End Try
    End Sub

    Protected Overrides Function Save(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        XtraTabControl1.SelectedTabPage = GeneralTabPage
        Try
            CalcPercen()
            mcls.ID = pID
            mcls.ModeData = pMode
            mcls.Subject = OppName.Text.Trim
            mcls.CustomerID = ConvertNullToZero(CustomerID.EditValue)
            mcls.OpportunityTypeID = ConvertNullToZero(OpportunityTypeID.GetColumnValue("ID"))
            mcls.OpportunityStageID = ConvertNullToZero(OpportunityStageID.GetColumnValue("ID"))
            mcls.OppStartDate = OppStartDate.EditValue
            mcls.OppExpireDate = OppExpireDate.EditValue
            mcls.SourceID = ConvertNullToZero(SourceID.GetColumnValue("ID"))
            mcls.IsSysRevenue = IsSysRevenue.EditValue
            mcls.EstimateRevenue = ConvertNullToZero(EstimateRevenue.EditValue)
            mcls.ExpectRevenue = ConvertNullToZero(ExpectRevenue.EditValue)
            mcls.Remark = Remark.Text.Trim

            mcls.IsInActive = UcAdmin1.CheckInAcive.Checked
            mcls.NoteDAOs = UcNote1.GetNoteDAOs
            mcls.FileAttachs = UcFileAttach1.GetFileAttachs
            mcls.OppContactRoleDAOs = UcContactRole1.GetDAOs
            mcls.ProductDAOs = UcProductLists1.GetDAOs(False, True, False, Nothing, False, 0, False, "", pMode, "")

            If Status.EditValue = EnumStatus.Close.ToString Then
                mcls.IsClose = True
                mcls.CloseDate = CloseDate.EditValue
                mcls.RealRevenue = RealRevenue.EditValue
                mcls.CloseResult = CloseResult.EditValue
                mcls.CloseRemark = CloseRemark.EditValue
            ElseIf Status.EditValue = "Reopen" Then
                mcls.IsClose = False
                mcls.CloseDate = Nothing
                mcls.RealRevenue = RealRevenue.EditValue
                mcls.CloseResult = False
                mcls.CloseRemark = ""
            End If

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

    Protected Overrides Sub MakeOrder(ByVal pID As Long)
        Try
            Dim lFormEdit As New frmOrderS
            lFormEdit.clsConvert = New OpportunityDAO
            lFormEdit.Caption = "ใบสั่งขาย"
            lFormEdit.MdiParent = frmMain
            lFormEdit.ModeData = DataMode.ModeConvert
            lFormEdit.OrderType = MasterType.SellOrders
            lFormEdit.IDs = pID
            lFormEdit.Show()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".MakeOrder : " & e.Message)
        End Try
    End Sub

    Protected Overrides Sub OnClosedForm()
        mcls = Nothing
    End Sub
#End Region

#Region "Event"

    Private Sub FormChangedComponent1_FormControlChanged1(ByVal sender As Object, ByVal e As FormChangedEventArgs) Handles FormChangedComponent1.FormControlChanged
        MyBase.CheckFormChanged()
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

    Private Sub btnOpportunityTypeID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpportunityTypeID.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboOpportunityType()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub btnOpportunityStageID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpportunityStageID.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboOpportunityStage()
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
            SetComboOpportunityStage()
            SetComboOpportunityType()
            SetComboSource()
            SetComboCustomer()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".InitialCombo : " & e.Message)
        End Try
    End Sub

    Private Function LoadData(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        Dim lclsProvince As New ProvinceDAO
        Try
            If pMode = DataMode.ModeNew Then
                IsSysRevenue.EditValue = True
                EstimateRevenue.Enabled = False

                'Status
                Status.Properties.Items.Clear()
                Status.Properties.Items.Add(EnumStatus.Open.ToString)
                Status.SelectedIndex = 0 'Open
                Status.Enabled = False
                CloseDate.EditValue = Nothing
                CloseDate.Enabled = False
                CloseResult.Enabled = False
                RealRevenue.Enabled = False
                CloseRemark.Enabled = False

            ElseIf pMode = DataMode.ModeEdit Then
                If mcls.InitailData(pID) Then
                    OppName.Text = mcls.Subject
                    CustomerID.EditValue = mcls.CustomerID
                    OpportunityTypeID.EditValue = mcls.OpportunityTypeID
                    OpportunityStageID.EditValue = mcls.OpportunityStageID
                    OppStartDate.EditValue = mcls.OppStartDate
                    OppExpireDate.EditValue = mcls.OppExpireDate
                    IsSysRevenue.EditValue = mcls.IsSysRevenue
                    EstimateRevenue.EditValue = mcls.EstimateRevenue
                    ExpectRevenue.EditValue = FormatNumber(mcls.ExpectRevenue, 2)
                    SourceID.EditValue = mcls.SourceID
                    Remark.EditValue = mcls.Remark
                    txtEmp.Text = mcls.EmployeeDAO.Title & " " & mcls.EmployeeDAO.FirstName & " " & mcls.EmployeeDAO.LastName
                    UcAdmin1.CheckInAcive.Checked = mcls.IsInActive
                    UcAdmin1.txtCreateBy.Text = mcls.CreateBy.Trim
                    UcAdmin1.txtCreateTime.Text = mcls.CreateTime
                    UcAdmin1.txtModifiBy.Text = mcls.ModifiedBy.Trim
                    UcAdmin1.txtModifiTime.Text = mcls.ModifiedTime

                    ''FileAttachs
                    UcFileAttach1.ShowControl(mcls.FileAttachs)

                    'Status
                    Status.Properties.Items.Clear()
                    If mcls.IsClose = True Then
                        Status.Properties.Items.Add(EnumStatus.Close.ToString)
                        Status.Properties.Items.Add("Reopen")
                        Status.SelectedIndex = 0 'Close
                        CloseDate.EditValue = mcls.CloseDate
                        CloseResult.EditValue = mcls.CloseDate
                        RealRevenue.EditValue = mcls.RealRevenue
                        CloseRemark.EditValue = mcls.CloseRemark
                    Else 'New
                        Status.Properties.Items.Add(EnumStatus.Open.ToString)
                        Status.Properties.Items.Add(EnumStatus.Close.ToString)
                        Status.SelectedIndex = 0 'Close
                        CloseDate.EditValue = Nothing
                    End If

                    Status.Enabled = True
                    CloseDate.Enabled = False
                    CloseResult.Enabled = False
                    RealRevenue.Enabled = False
                    CloseRemark.Enabled = False

                    LoadHistory(pID)
                End If
            End If

            'Note
            UcNote1.ShowControl(mcls.TableName, pID)
            gCustomerID = ConvertNullToZero(CustomerID.EditValue)
            Dim lOrderList As New List(Of Long)
            lOrderList.Add(mcls.ID)
            UcProductLists1.ShowControl(pMode, lOrderList, mcls.TableName, ProColumn.Units + ProColumn.Price + ProColumn.UnitName + ProColumn.Total + ProColumn.Discount _
                                        , False, True, Nothing, True, mcls.TableName, False, mcls.IsDelete, 0, "")
            UcContactRole1.ShowControl(pID)

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".LoadData : " & ex.Message)
            Return False
        Finally
            lclsProvince = Nothing
        End Try
    End Function



    Private Sub LoadHistory(ByVal pID As Long)
        Dim lcls As New OpportunityDAO
        Dim dataTable As New DataTable()

        Try
            dataTable = lcls.GetHistoryTable(pID)

            If dataTable.Rows.Count > 0 Then
                GridControl.DataSource = dataTable
                GridView.ViewCaption = "ประวัติการแก้ไข"
                Call GridStyle()
            Else
                GridControl.DataSource = Nothing
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".LoadHistory : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub


    Private Sub GridStyle()
        With GridView
            .Columns("Customer").Caption = "ลูกค้า"
            .Columns("Customer").Width = 250
            .Columns("EstimateRevenue").Caption = "ประมาณการรายได้"
            .Columns("EstimateRevenue").Width = 100
            .Columns("ExpectRevenue").Caption = "รายได้คาดหวัง"
            .Columns("ExpectRevenue").Width = 100
            .Columns("NameThai").Caption = "ช่วงโอกาส"
            .Columns("NameThai").Width = 150
            .Columns("IsClose").Caption = "Is Close"
            .Columns("IsClose").Width = 80
            .Columns("CloseDate").Caption = "Close Date"
            .Columns("CloseDate").Width = 100
            .Columns("UserName").Caption = "ผู้แก้ไขล่าสุด"
            .Columns("UserName").Width = 250
            .Columns("ModifiedTime").Caption = "วันแก้ไขล่าสุด"
            .Columns("ModifiedTime").Width = 200
            '.Columns("ModifiedTime").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        End With
    End Sub


    Private Function Verify() As Boolean
        Try
            DxErrorProvider1.ClearErrors()
            If Trim(OppName.Text) = "" Then
                SetErrorProvider(DxErrorProvider1, OppName, "กรุณาระบุข้อมูล")
            ElseIf mcls.CheckExist() Then
                SetErrorProvider(DxErrorProvider1, OppName, "ข้อมูลซ้ำ")
            End If

            If Trim(CustomerID.Text) = "" Then
                SetErrorProvider(DxErrorProvider1, CustomerID, "กรุณาระบุลูกค้า")
            End If

            If DxErrorProvider1.HasErrors = False Then
                If UcProductLists1.IsError <> "" Then
                    XtraTabControl1.SelectedTabPage = ProductTabPage
                    Return False
                End If
            End If

            If DxErrorProvider1.HasErrors = False Then
                If UcContactRole1.IsError = True Then
                    XtraTabControl1.SelectedTabPage = OppContactRoleTabPage
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


    Private Sub SetComboOpportunityType()
        Try
            SetComboMasterLook(OpportunityTypeID, MasterType.OpportunityType)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboOpportunityType : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboSource()
        Try
            SetComboMasterLook(SourceID, MasterType.Source)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboSource : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboOpportunityStage()
        Try
            SetLookUpOppStage(OpportunityStageID)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboOpportunityStage : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboCustomer()
        Try
            SetSearchLookCustomer(CustomerID, True, False)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboCustomer : " & e.Message)
        End Try

    End Sub
#End Region

    Private Sub IsSysRevenue_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles IsSysRevenue.EditValueChanged
        If IsSysRevenue.EditValue = True Then
            EstimateRevenue.Enabled = False
            UcProductLists1.GetDAOs(False, False, False, Nothing, True, 0, False, "", 0, "")
            EstimateRevenue.EditValue = UcProductLists1.Totals
        Else

            EstimateRevenue.EditValue = 0
            EstimateRevenue.Enabled = True
        End If
        EstimateRevenue.Enabled = (IsSysRevenue.EditValue = False)
    End Sub

    Private Sub GeneralTabPage_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GeneralTabPage.GotFocus
        If IsSysRevenue.EditValue = True Then
            UcProductLists1.GetDAOs(False, False, False, Nothing, True, 0, False, "", 0, "")
            EstimateRevenue.EditValue = UcProductLists1.Totals
        End If
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If IsSysRevenue.EditValue = True And XtraTabControl1.SelectedTabPage Is GeneralTabPage Then
            UcProductLists1.GetDAOs(False, False, False, Nothing, True, 0, False, "", 0, "")
            EstimateRevenue.EditValue = UcProductLists1.Totals
        End If
    End Sub


    Private Sub OpportunityStageID_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles OpportunityStageID.EditValueChanged
        CalcPercen()
    End Sub

    Private Sub CalcPercen()
        Dim lOppStageID As Long
        Dim lcls As New OpportunityStageDAO
        Try
            lOppStageID = ConvertNullToZero(OpportunityStageID.EditValue)
            If lOppStageID > 0 Then
                If lcls.InitailData(lOppStageID) Then
                    Percen.EditValue = Format(lcls.Percents, "#,##0.00")
                    ExpectRevenue.EditValue = Format((lcls.Percents / 100) * EstimateRevenue.EditValue, "#,##0.00")
                End If

            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".CalcPercen : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Private Sub EstimateRevenue_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles EstimateRevenue.EditValueChanged
        CalcPercen()
    End Sub

    Private Sub Status_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Status.SelectedIndexChanged
        'Status        
        If Status.EditValue = EnumStatus.Close.ToString Then
            CloseDate.EditValue = GetCurrentDate(Nothing)
            CloseDate.Enabled = True
            CloseResult.Enabled = True
            CloseResult.EditValue = True
            RealRevenue.Enabled = True
            RealRevenue.EditValue = 0
            CloseRemark.Enabled = True
        ElseIf Status.EditValue = "Reopen" Or Status.EditValue = EnumStatus.Open.ToString Then
            CloseDate.EditValue = Nothing
            CloseDate.Enabled = False
            CloseResult.Enabled = False
            CloseResult.EditValue = Nothing
            RealRevenue.Enabled = False
            RealRevenue.EditValue = Nothing
            CloseRemark.Enabled = False
        End If

    End Sub

    Private Sub CustomerID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerID.EditValueChanged
        Dim lCusID As Long
        lCusID = ConvertNullToZero(CustomerID.EditValue)
        If lCusID > 0 Then
            gCustomerID = lCusID
        End If
    End Sub
End Class