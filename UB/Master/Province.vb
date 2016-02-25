Option Explicit On

Imports DevExpress.XtraEditors

Public Class frmProvince
    Inherits iEditForm
    Private Const mFormName As String = "frmProvince"
    Dim mcls As New ProvinceDAO



#Region "Overrides"
    Protected Overrides Sub OnLoadForm(ByVal pMode As Integer, ByVal pID As Long, ByVal pOrderType As Long, ByVal pclsConvert As iOrder, ByVal pCusID As Long)
        Try
            Call SetComboGeo()
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
            End Select

            XtraTabControl1.SelectedTabPage = GeneralTabPage
            txtCode.Select()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".ClearAllForm : " & e.Message)
        End Try
    End Sub

    Protected Overrides Function Save(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        XtraTabControl1.SelectedTabPage = GeneralTabPage
        Try

            mcls.ID = pID
            mcls.ModeData = pMode
            mcls.Code = txtCode.Text.Trim
            mcls.NameThai = txtNameThai.Text.Trim
            mcls.NameEng = txtNameEng.Text.Trim
            mcls.Remark = txtRemark.Text.Trim
            mcls.GeoID = ConvertNullToZero(cboGeo.EditValue)
            mcls.IsInActive = UcAdmin1.CheckInAcive.Checked
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
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Try
            ShowProgress(True, "Loading...")
            Call SetComboGeo()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub FormChangedComponent1_FormControlChanged1(ByVal sender As Object, ByVal e As FormChangedEventArgs) Handles FormChangedComponent1.FormControlChanged
        MyBase.CheckFormChanged()
    End Sub

#End Region

#Region "Private"
    Private Sub SetComboGeo()
        Dim dataTable As New DataTable()
        Try
            ' Create four typed columns in the DataTable.
            dataTable.Columns.Add("ID", GetType(Long))
            dataTable.Columns.Add("Name", GetType(String))

            ' Add five rows with those columns filled in the DataTable.
            dataTable.Rows.Add(1, "ภาคเหนือ")
            dataTable.Rows.Add(2, "ภาคกลาง")
            dataTable.Rows.Add(3, "ภาคตะวันออกเฉียงเหนือ")
            dataTable.Rows.Add(4, "ภาคตะวันตก")
            dataTable.Rows.Add(5, "ภาคตะวันออก")
            dataTable.Rows.Add(6, "ภาคใต้")

            cboGeo.Properties.DataSource = dataTable
            cboGeo.Properties.DisplayMember = "NAME"
            cboGeo.Properties.ValueMember = "ID"
            cboGeo.EditValue = DBNull.Value
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SetComboGeo : " & e.Message)
        Finally
            dataTable = Nothing
        End Try
     
    End Sub

    Private Function LoadData(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        Try
            If pMode = DataMode.ModeNew Then
            ElseIf pMode = DataMode.ModeEdit Then
                If mcls.InitailData(pID) Then
                    txtCode.Text = mcls.Code
                    txtNameThai.Text = mcls.NameThai
                    txtNameEng.Text = mcls.NameEng
                    txtRemark.Text = mcls.Remark
                    cboGeo.EditValue = mcls.GeoID
                    UcAdmin1.CheckInAcive.Checked = mcls.IsInActive
                    UcAdmin1.txtCreateBy.Text = mcls.CreateBy.Trim
                    UcAdmin1.txtCreateTime.Text = mcls.CreateTime
                    UcAdmin1.txtModifiBy.Text = mcls.ModifiedBy.Trim
                    UcAdmin1.txtModifiTime.Text = mcls.ModifiedTime


                End If
            End If

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".LoadData : " & ex.Message)
            Return False
        End Try
    End Function

    Private Function Verify() As Boolean
        DxErrorProvider1.ClearErrors()
        Try
            If Trim(txtCode.Text) = "" Then
                SetErrorProvider(DxErrorProvider1, txtCode, "กรุณาระบุข้อมูล")
            ElseIf mcls.CheckExist() Then
                SetErrorProvider(DxErrorProvider1, txtCode, "ข้อมูลซ้ำ")
            End If

            If Trim(txtNameThai.Text) = "" Then
                SetErrorProvider(DxErrorProvider1, txtNameThai, "กรุณาระบุข้อมูล")
            End If

            If ConvertNullToZero(cboGeo.EditValue) = 0 Then
                SetErrorProvider(DxErrorProvider1, cboGeo, "กรุณาระบุข้อมูล")
            End If
            Return DxErrorProvider1.HasErrors = False
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".Verify : " & e.Message)
        End Try

    End Function


#End Region





End Class