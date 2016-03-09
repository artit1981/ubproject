Option Explicit On

Imports DevExpress.XtraEditors

Public Class frmApproveUser
    Inherits iEditForm
    Private Const mFormName As String = "frmApproveUser"
    Dim mcls As New ApproveUserDAO

#Region "Overrides"

    Protected Overrides Sub OnLoadForm(ByVal pMode As Integer, ByVal pID As Long, ByVal pOrderType As Long, ByVal pclsConvert As iOrder, ByVal pCusID As Long)
        Try
            InitialCombo()
            Call LoadData(pMode, pID)
            Addbar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
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
                    UcApproveUser1.ClearControl()
                    UcApproveUser2.ClearControl()
                    UcNote1.ClearControl()

                Case DataMode.ModeEdit
                    'AccountCode.Properties.ReadOnly = True
                    'btnGenID.Enabled = False
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
            mcls.IsInActive = UcAdmin1.CheckInAcive.Checked
            mcls.NoteDAOs = UcNote1.GetNoteDAOs
            mcls.FileAttachs = UcFileAttach1.GetFileAttachs
            mcls.ApproveUsersDAOs1 = UcApproveUser1.GetDAOs
            mcls.ApproveUsersDAOs2 = UcApproveUser2.GetDAOs
            If Verify() = True Then
                mcls.SaveData()
                VerifyApproveUser()
                Return True
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

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".InitialCombo : " & e.Message)
        End Try
    End Sub

    Private Function LoadData(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        Dim lclsProvince As New ProvinceDAO
        Try
            If pMode = DataMode.ModeNew Then

            ElseIf pMode = DataMode.ModeConvert Then

                MyBase.SetMode = DataMode.ModeNew
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
                End If
            End If

            UcNote1.ShowControl(mcls.TableName, pID)
            UcApproveUser1.ShowControl(pMode, 1, 0, False)
            UcApproveUser2.ShowControl(pMode, 2, AppColumn.Amount, False)
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
            'If Trim(AccountCode.Text) = "" Then
            '    SetErrorProvider(DxErrorProvider1, AccountCode, "กรุณาระบุข้อมูล")
            'ElseIf mcls.CheckExist() Then
            '    SetErrorProvider(DxErrorProvider1, AccountCode, "ข้อมูลซ้ำ")
            'End If

            'If Trim(txtCompanyName.Text) = "" Then
            '    SetErrorProvider(DxErrorProvider1, txtCompanyName, "กรุณาระบุข้อมูล")
            'End If

            'Return DxErrorProvider1.HasErrors = False
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".Verify : " & e.Message)
        End Try
    End Function




#End Region

End Class