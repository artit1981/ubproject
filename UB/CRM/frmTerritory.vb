﻿Option Explicit On

Imports DevExpress.XtraEditors

Public Class frmTerritory
    Inherits iEditForm
    Private Const mFormName As String = "frmTerritory"
    Dim mcls As New TerritoryDAO


#Region "Overrides"
    Protected Overrides Sub OnLoadForm(ByVal pMode As Integer, ByVal pID As Long, ByVal pOrderType As Long, ByVal pclsConvert As iOrder, ByVal pCusID As Long)
        Try
            Call SetComboManager()
            SetComboCommission()
            Call LoadData(pMode, pID)
            CommissionID.Enabled = False
            btnRefreshCommissionID.Enabled = False
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
                    UcNote1.ClearControl()
                    UcFileAttach1.ClearControl()
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
            mcls.IsInActive = UcAdmin1.CheckInAcive.Checked
            mcls.ManagerID = ConvertNullToZero(cboManager.EditValue)
            mcls.CommissionID = ConvertNullToZero(CommissionID.EditValue)
            mcls.NoteDAOs = UcNote1.GetNoteDAOs
            mcls.FileAttachs = UcFileAttach1.GetFileAttachs
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
    Private Sub btnRefreshIndustryType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshIndustryType.Click
        Try
            ShowProgress(True, "Loading...")
            Call SetComboManager()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try

    End Sub
    Private Sub btnRefreshCommissionID_Click(sender As Object, e As EventArgs) Handles btnRefreshCommissionID.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboCommission()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub
#End Region

#Region "Private"
    Private Sub SetComboManager()
        Try
            Call SetComboEmployee(cboManager)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboManager : " & e.Message)
        End Try
    End Sub
    Private Sub SetComboCommission()
        Try
            SetLookUpCommission(CommissionID)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboCommission : " & e.Message)
        Finally
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
                    cboManager.EditValue = mcls.ManagerID
                    CommissionID.EditValue = mcls.CommissionID
                    UcAdmin1.CheckInAcive.Checked = mcls.IsInActive
                    UcAdmin1.txtCreateBy.Text = mcls.CreateBy.Trim
                    UcAdmin1.txtCreateTime.Text = mcls.CreateTime
                    UcAdmin1.txtModifiBy.Text = mcls.ModifiedBy.Trim
                    UcAdmin1.txtModifiTime.Text = mcls.ModifiedTime

                    ''FileAttachs
                    UcFileAttach1.ShowControl(mcls.FileAttachs)

                End If
            End If

            'Note
            UcNote1.ShowControl(mcls.TableName, pID)


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

            If ConvertNullToZero(cboManager.EditValue) <= 0 Then
                SetErrorProvider(DxErrorProvider1, cboManager, "กรุณาระบุข้อมูล")
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".Verify : " & e.Message)
        End Try
        Return DxErrorProvider1.HasErrors = False

    End Function

#End Region

End Class