

Public Class frmPreExport
    Private mReportCode As String
    Private mGridControl As DevExpress.XtraGrid.GridControl

    Public Function InitialForm(ByVal pFileName As String, ByVal pGridControl As DevExpress.XtraGrid.GridControl) As Boolean
        Try
            mReportCode = pFileName
            mGridControl = pGridControl
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "frmPreExport   .InitialForm : " & e.Message)
            Return False
        End Try
    End Function


    Private Sub InitialCondition()
        mReportCode = Replace(mReportCode, "\", "-")
        mReportCode = Replace(mReportCode, "/", "-")

        Select Case rdoCondition.EditValue
            Case 1
                txtBrows.Enabled = True
                txtBrows.Text = "C:\" & mReportCode & ".xlsx"
            Case 2
                txtBrows.Enabled = True
                txtBrows.Text = "C:\" & mReportCode & ".pdf"
            Case 3
                txtBrows.Enabled = True
                txtBrows.Text = "C:\" & mReportCode & ".rtf"
        End Select
    End Sub


    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Try
            ShowProgress(True, "Exporting...")

            Select Case rdoCondition.EditValue
                Case 1 : mGridControl.ExportToXlsx(txtBrows.Text)
                Case 2 : mGridControl.ExportToPdf(txtBrows.Text)
                Case 3 : mGridControl.ExportToRtf(txtBrows.Text)
            End Select
            Process.Start(txtBrows.Text)
        Catch ex As Exception
            ShowProgress(False, "")
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try


    End Sub


    Private Sub frmPreExport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ShowProgress(False, "Loading...")
            InitialCondition()
        Catch ex As Exception
            ShowProgress(False, "")
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub


    Private Sub txtBrows_ButtonPressed(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtBrows.ButtonPressed
        'Select Case rdoCondition.EditValue
        '    Case 1
        '        SaveFileDialog1.FileName = mReportCode & ".xlsx"
        '    Case 2
        '        SaveFileDialog1.FileName = mReportCode & ".pdf"
        '    Case 3
        '        SaveFileDialog1.FileName = mReportCode & ".rtf"
        'End Select
        SaveFileDialog1.FileName = txtBrows.Text
        SaveFileDialog1.ShowDialog()
        txtBrows.Text = SaveFileDialog1.FileName
    End Sub

    Private Sub rdoCondition_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdoCondition.SelectedIndexChanged
        InitialCondition()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


End Class