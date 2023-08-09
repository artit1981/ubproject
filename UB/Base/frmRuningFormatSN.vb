Option Explicit On

Imports DevExpress.XtraEditors

Public Class frmRuningFormatSN
    Inherits iEditForm
    Dim mcls As New RunningFormatSNDAO
    Private Const mFormName As String = "frmRuningFormatSN"

#Region "Event"
    Private Sub FormChangedComponent1_FormControlChanged1(ByVal sender As Object, ByVal e As FormChangedEventArgs) Handles FormChangedComponent1.FormControlChanged
        MyBase.CheckFormChanged()
    End Sub
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        DisplayExams()
    End Sub

#End Region

#Region "Private"
    Private Sub InitialCombo()
        Try
            FormatDate.Properties.Items.Add("None")
            FormatDate.Properties.Items.Add("dd")
            FormatDate.Properties.Items.Add("mm")
            FormatDate.Properties.Items.Add("yy")
            FormatDate.Properties.Items.Add("yyyy")
            FormatDate.Properties.Items.Add("ddmm")
            FormatDate.Properties.Items.Add("ddmmyy")
            FormatDate.Properties.Items.Add("ddmmyyyy")
            FormatDate.Properties.Items.Add("mmdd")
            FormatDate.Properties.Items.Add("mmddyy")
            FormatDate.Properties.Items.Add("mmddyyyy")
            FormatDate.Properties.Items.Add("mmyy")
            FormatDate.Properties.Items.Add("mmyyyy")
            FormatDate.Properties.Items.Add("yymm")
            FormatDate.Properties.Items.Add("yymmdd")
            FormatDate.Properties.Items.Add("yyyymm")
            FormatDate.Properties.Items.Add("yyyymmdd")
            FormatDate.Properties.Items.Add("dd-mm")
            FormatDate.Properties.Items.Add("dd-mm-yy")
            FormatDate.Properties.Items.Add("dd-mm-yyyy")
            FormatDate.Properties.Items.Add("mm-dd")
            FormatDate.Properties.Items.Add("mm-dd-yy")
            FormatDate.Properties.Items.Add("mm-dd-yyyy")
            FormatDate.Properties.Items.Add("mm-yy")
            FormatDate.Properties.Items.Add("mm-yyyy")
            FormatDate.Properties.Items.Add("yy-mm")
            FormatDate.Properties.Items.Add("yy-mm-dd")
            FormatDate.Properties.Items.Add("yyyy-mm")
            FormatDate.Properties.Items.Add("yyyy-mm-dd")
            FormatDate.Properties.Items.Add("dd/mm")
            FormatDate.Properties.Items.Add("dd/mm/yy")
            FormatDate.Properties.Items.Add("dd/mm/yyyy")
            FormatDate.Properties.Items.Add("mm/dd")
            FormatDate.Properties.Items.Add("mm/dd/yy")
            FormatDate.Properties.Items.Add("mm/dd/yyyy")
            FormatDate.Properties.Items.Add("mm/yy")
            FormatDate.Properties.Items.Add("mm/yyyy")
            FormatDate.Properties.Items.Add("yy/mm")
            FormatDate.Properties.Items.Add("yy/mm/dd")
            FormatDate.Properties.Items.Add("yyyy/mm")
            FormatDate.Properties.Items.Add("yyyy/mm/dd")
            FormatDate.Properties.Items.Add("dd:mm")
            FormatDate.Properties.Items.Add("dd:mm:yy")
            FormatDate.Properties.Items.Add("dd:mm:yyyy")
            FormatDate.Properties.Items.Add("mm:dd")
            FormatDate.Properties.Items.Add("mm:dd:yy")
            FormatDate.Properties.Items.Add("mm:dd:yyyy")
            FormatDate.Properties.Items.Add("mm:yy")
            FormatDate.Properties.Items.Add("mm:yyyy")
            FormatDate.Properties.Items.Add("yy:mm")
            FormatDate.Properties.Items.Add("yy:mm:dd")
            FormatDate.Properties.Items.Add("yyyy:mm")
            FormatDate.Properties.Items.Add("yyyy:mm:dd")


            FormatMidle.Properties.Items.Add("None")
            FormatMidle.Properties.Items.Add("-")
            FormatMidle.Properties.Items.Add("/")
            FormatMidle.Properties.Items.Add("\")

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "frmProduct.InitialCombo : " & e.Message)
        End Try
    End Sub


    Private Function DisplayExams() As Boolean
        Dim lstrExam As String, lRunCount As String = "", lLastCount As Long, i As Integer
        Try

            mcls.FormatDate = FormatDate.EditValue
            mcls.FormatYear = FormatYear.EditValue
            mcls.FormatMidle = FormatMidle.EditValue
            mcls.RunningCount = RunningCount.EditValue

            lstrExam = "รหัสสินค้า" &  mcls.FormatMidle
            lstrExam &= "รหัสซัพพลายเออร์" & mcls.FormatMidle

            If mcls.FormatDate <> "None" Then
                mcls.FormatDate = Replace(mcls.FormatDate, "mm", "MM")
                If mcls.FormatYear = "TH" Then
                    lstrExam &= Now.ToString(mcls.FormatDate, cTH)
                Else
                    lstrExam &= Now.ToString(mcls.FormatDate, cEN)
                End If
                lstrExam &= mcls.FormatMidle
            End If


            For i = 1 To mcls.RunningCount
                lRunCount = lRunCount & "0"
            Next

            'Get Last no
            lLastCount = 0

            lLastCount += 1
            lstrExam &= lLastCount.ToString(lRunCount)

            lblExam.Text = lstrExam

            Return True
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, ".DisplayExam : " & ex.Message)
            Return False
        Finally
        End Try
    End Function

    Private Function LoadData(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        Try

            If mcls.InitailData(Nothing) Then
                'FormatFront.EditValue = mcls.FormatFront
                FormatDate.EditValue = mcls.FormatDate
                If ConvertNullToString(mcls.FormatYear) = "" Then
                    FormatYear.EditValue = "EN"
                Else
                    FormatYear.EditValue = mcls.FormatYear
                End If
                FormatMidle.EditValue = mcls.FormatMidle
                RunningCount.EditValue = mcls.RunningCount

                chkIsReset.Checked = False
                UcAdmin1.txtCreateBy.Text = mcls.CreateBy.Trim
                UcAdmin1.txtCreateTime.Text = mcls.CreateTime
                UcAdmin1.txtModifiBy.Text = mcls.ModifiedBy.Trim
                UcAdmin1.txtModifiTime.Text = mcls.ModifiedTime
                DisplayExams()
            End If


        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".LoadData : " & ex.Message)
            Return False
        End Try
    End Function

    Private Function Verify() As Boolean
        DxErrorProvider1.ClearErrors()
        Try
            If Trim(RunningCount.Text) = "" Then
                SetErrorProvider(DxErrorProvider1, RunningCount, "กรุณาระบุข้อมูล")
            ElseIf ConvertNullToZero(RunningCount.EditValue) > 10 Then
                SetErrorProvider(DxErrorProvider1, RunningCount, "จำนวนหลักไม่ควรมากกว่า 10")
            End If


            Return DxErrorProvider1.HasErrors = False
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".Verify : " & e.Message)
        End Try

    End Function


#End Region
#Region "Overrides"
    Protected Overrides Sub OnLoadForm(ByVal pMode As Integer, ByVal pID As Long, ByVal pOrderType As Long, ByVal pclsConvert As iOrder, ByVal pCusID As Long)
        Try
            Addbar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            PrintBar2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

            FormatYear.EditValue = "TH"
            Call InitialCombo()
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
            UcAdmin1.CheckInAcive.Enabled = False
            XtraTabControl1.SelectedTabPage = GeneralTabPage
            FormatFront.Select()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".ClearAllForm : " & e.Message)
        End Try

    End Sub

    Protected Overrides Function Save(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        XtraTabControl1.SelectedTabPage = GeneralTabPage
        Try
            'mcls.ID = pID
            mcls.ModeData = DataMode.ModeEdit
            mcls.FormatDate = FormatDate.EditValue
            mcls.FormatYear = FormatYear.EditValue
            mcls.FormatMidle = FormatMidle.EditValue
            mcls.RunningCount = RunningCount.EditValue
            'mcls.LastNo = LastNo.EditValue

            mcls.IsReset = chkIsReset.Checked
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


End Class