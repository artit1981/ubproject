Option Explicit On

Imports DevExpress.XtraEditors

Public Class frmLeadQ
    Private Const mFormName As String = "frmLeadQ"
    Dim mcls As New CustomerDAO

    Private Sub frmLeadQ_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            SetComboPrefix()
            SetComboLeadType()
            txtSUBJECT.Select()

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ''ShowProgress(False, "")
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
            SetComboLeadType()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Try
            ShowProgress(True, "Saving...")
            If Save() Then
                Me.Close()
            End If
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Protected Function Save() As Boolean
        Try
            mcls.TableID = MasterType.Lead
            mcls.IsQuick = "Yes"
            mcls.ID = 0
            mcls.ModeData = DataMode.ModeNew
            mcls.Subject = txtSUBJECT.Text.Trim
            mcls.Title = cboTITLE.Text.Trim
            mcls.LeadType = cboLeadType.Text.Trim
            mcls.FirstName = txtFIRSTNAME.Text.Trim
            mcls.LastName = txtLASTNAME.Text.Trim
            mcls.CompanyName = txtCOMPANYNAME.Text.Trim
            mcls.IsInActive = False
            mcls.Rating = cboRating.Text

            mcls.AddressS = New AddressDAO
            mcls.AddressS.Email1 = Email1.EditValue
            mcls.AddressS.Phone1 = Phone1.EditValue
            If Verify() = True Then
                Return mcls.SaveData(Nothing)
            Else
                XtraMessageBox.Show(Me, "พบข้อผิดพลาดกรุณาตรวจสอบ", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".Save : " & ex.Message)
            Return False
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
            Return DxErrorProvider1.HasErrors = False
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".Verify : " & e.Message)
        End Try
    End Function


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class