Option Explicit On

Imports DevExpress.XtraEditors

Public Class frmLocation
    Inherits iEditForm
    Private Const mFormName As String = "frmLocation"
    Dim mcls As New LocatonDAO

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
                    ClearForm(UcAdmin1)
                    UcFileAttach1.ClearControl()
                    UcAddress1.ClearControl()
                    UcNote1.ClearControl()
                    UcLocationDTL1.ClearControl()
            End Select

            XtraTabControl1.SelectedTabPage = GeneralTabPage
            IDCode.Select()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".ClearAllForm : " & e.Message)
        End Try
    End Sub

    Protected Overrides Function Save(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        XtraTabControl1.SelectedTabPage = GeneralTabPage
        Try
            mcls.ID = pID
            mcls.ModeData = pMode
            mcls.Code = IDCode.Text.Trim
            mcls.NameThai = txtNameThai.Text.Trim
            mcls.NameEng = txtNameEng.Text.Trim
            mcls.Remark = Remark.Text.Trim
            mcls.IsInActive = UcAdmin1.CheckInAcive.Checked
            mcls.EmpID = ConvertNullToZero(EmpID.EditValue)
            mcls.EmpGroupID = ConvertNullToZero(EmpGroupID.GetColumnValue("ID"))
            mcls.PrivilegeBy = ConvertNullToString(PrivilegeBy.EditValue)
            mcls.NoteDAOs = UcNote1.GetNoteDAOs
            mcls.FileAttachs = UcFileAttach1.GetFileAttachs
            mcls.AddressS = UcAddress1.GetAddressDAO
            mcls.LocationDtlDAOs = UcLocationDTL1.GetNoteDAOs
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
    Private Sub FormChangedComponent1_FormControlChanged1(ByVal sender As Object, ByVal e As FormChangedEventArgs) Handles FormChangedComponent1.FormControlChanged
        MyBase.CheckFormChanged()
    End Sub

    Private Sub btnRefreshEmpID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshEmpID.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboEmp()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub


    Private Sub btnRefreshEmpGroupID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshEmpGroupID.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboEmpGroup()
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
            SetComboEmp()
            SetComboEmpGroup()
            SetComboPrivilegeBy()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".InitialCombo : " & e.Message)
        End Try
    End Sub

    Private Function LoadData(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        Dim lclsProvince As New ProvinceDAO
        Try
            If pMode = DataMode.ModeNew Then
                UcAddress1.InitailData(Nothing, lclsProvince.GetDataTable())
            ElseIf pMode = DataMode.ModeEdit Then
                If mcls.InitailData(pID, Nothing) Then
                    IDCode.Text = mcls.Code
                    txtNameThai.Text = mcls.NameThai
                    txtNameEng.Text = mcls.NameEng
                    Remark.Text = mcls.Remark
                    EmpID.EditValue = mcls.EmpID
                    EmpGroupID.EditValue = mcls.EmpGroupID
                    PrivilegeBy.EditValue = mcls.PrivilegeBy

                    UcAdmin1.CheckInAcive.Checked = mcls.IsInActive
                    UcAdmin1.txtCreateBy.Text = mcls.CreateBy.Trim
                    UcAdmin1.txtCreateTime.Text = mcls.CreateTime
                    UcAdmin1.txtModifiBy.Text = mcls.ModifiedBy.Trim
                    UcAdmin1.txtModifiTime.Text = mcls.ModifiedTime

                    ''FileAttachs
                    UcFileAttach1.ShowControl(mcls.FileAttachs)

                    ''Address
                    UcAddress1.InitailData(mcls.AddressS, lclsProvince.GetDataTable())
                End If
            End If

            UcNote1.ShowControl(mcls.TableName, pID)
            UcLocationDTL1.ShowControl(pID)

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
            lblKeepError.Visible = False

            If Trim(IDCode.Text) = "" Then
                SetErrorProvider(DxErrorProvider1, IDCode, "กรุณาระบุข้อมูล")
            ElseIf mcls.CheckExist() Then
                SetErrorProvider(DxErrorProvider1, IDCode, "ข้อมูลซ้ำ")
            End If

            If Trim(txtNameThai.Text) = "" Then
                SetErrorProvider(DxErrorProvider1, txtNameThai, "กรุณาระบุข้อมูล")
            End If

            If DxErrorProvider1.HasErrors = False Then
                If mcls.LocationDtlDAOs.Count <= 0 Then
                    SetErrorProvider(DxErrorProvider1, IDCode, "กรุณาระบุตำแหน่งเก็บ")
                    lblKeepError.Text = "กรุณาระบุตำแหน่งเก็บ"
                    XtraTabControl1.SelectedTabPage = KeepTabPage
                    lblKeepError.Visible = True
                End If
            End If

            Return DxErrorProvider1.HasErrors = False
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".Verify : " & e.Message)
        End Try
    End Function


#End Region

#Region "Set combo"
    Private Sub SetComboEmp()
        Try
            Call SetComboEmployee(EmpID)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboEmp : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboEmpGroup()
        Try
            SetComboMasterLook(EmpGroupID, MasterType.EmpGroup)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboEmpGroup : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboPrivilegeBy()
        Try

            PrivilegeBy.Properties.Items.Add("ใช้ได้ทุกกลุ่มพนักงาน")
            PrivilegeBy.Properties.Items.Add("ใช้ได้เฉพาะกลุ่มที่กำหนด")
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboPrivilegeBy : " & e.Message)
        End Try
    End Sub

#End Region

End Class