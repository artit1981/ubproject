Imports DevExpress.XtraEditors

Public Class frmCommissionReport
    Private Const mFormName As String = "frmCommissionReport"
    Private mIsFromLoad As Boolean = False

    Private Sub frmCommissionReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            mIsFromLoad = True
            'ShowProgress(True, "Loading...")

            dtpDateTo.EditValue = DateAdd(DateInterval.Day, 7, GetCurrentDate(Nothing))
            dtpDateFrom.EditValue = DateAdd(DateInterval.Month, -3, GetCurrentDate(Nothing))

            InitialCombo()

            cboCheckedCommission.CheckAll()
            cboCheckedTerritory.CheckAll()
            cboCheckedEmployee.CheckAll()

            cboCheckedTerritory.Enabled = False
            'LoadData()
            mIsFromLoad = False
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try

    End Sub



#Region "Private"
    Private Sub InitialCombo()
        Try
            SetComboEmployee()
            SetComboTerritory()
            SetComboCommission()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".InitialCombo : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboEmployee()
        Try '  
            If gPrivilegeID > 1 Then 'Not admin
                SetComboCheckEmployee(cboCheckedEmployee, " and [CommissionID]>0 and EmpID=" & gEmpID)
            Else
                SetComboCheckEmployee(cboCheckedEmployee, " and [CommissionID]>0 ")
            End If


        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboEmployee : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboTerritory()
        Try '  
            SetComboCheckTerritory(cboCheckedTerritory, " and [CommissionID]>0 ")
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboTerritory : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboCommission()
        Try '  
            SetComboCheckCommission(cboCheckedCommission)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboCommission : " & e.Message)
        End Try
    End Sub

    Private Function LoadData() As Boolean
        Try

            Dim lCommID As String = ""
            For Each pVaue In cboCheckedCommission.Properties.Items.GetCheckedValues()
                lCommID &= "," & pVaue
            Next
            If lCommID <> "" Then
                lCommID = lCommID.Substring(1)
            End If

            Dim lEmpID As String = ""
            Dim lStoredName As String = ""
            If rdoCondition.EditValue = 1 Then
                lStoredName = "[dbo].[spCommission]"
                For Each pVaue In cboCheckedEmployee.Properties.Items.GetCheckedValues()
                    lEmpID &= "," & pVaue
                Next
                If lEmpID <> "" Then
                    lEmpID = lEmpID.Substring(1)
                End If
            Else
                lStoredName = "[dbo].[spCommissionGroup]"
                For Each pVaue In cboCheckedTerritory.Properties.Items.GetCheckedValues()
                    lEmpID &= "," & pVaue
                Next
                If lEmpID <> "" Then
                    lEmpID = lEmpID.Substring(1)
                End If
            End If



            Dim SQL = " EXEC " & lStoredName
            SQL &= " @FromDate = '" & formatSQLDate(dtpDateFrom.EditValue) & "'"
            SQL &= " ,@ToDate = '" & formatSQLDate(dtpDateTo.EditValue) & "';"
            Dim dataTable = gConnection.executeSelectQuery(SQL, Nothing, 180)

            If dataTable.Rows.Count > 0 Then
                Dim FilterTable As New DataTable
                If rdoCondition.EditValue = 1 Then
                    If dataTable.Select("Commisstion>0 and EmpID in(" & lEmpID & ") and CommissionID in(" & lCommID & ")").Length > 0 Then
                        FilterTable = dataTable.Select("Commisstion>0 and EmpID in(" & lEmpID & ") and CommissionID in(" & lCommID & ")").CopyToDataTable
                    End If

                Else
                    If dataTable.Select("Commisstion>0 and TerritoryID in(" & lEmpID & ") and CommissionID in(" & lCommID & ")").Length > 0 Then
                        FilterTable = dataTable.Select("Commisstion>0 and TerritoryID in(" & lEmpID & ") and CommissionID in(" & lCommID & ")").CopyToDataTable
                    End If

                End If

                If gPrivilegeID > 1 Then 'Not admin
                    dataTable = FilterTable
                    If dataTable.Select("EmpID in(" & gEmpID & ") ").Length > 0 Then
                        FilterTable = dataTable.Select("EmpID in(" & gEmpID & ")").CopyToDataTable
                    Else
                        FilterTable = Nothing
                    End If

                End If

                gridView.Columns.Clear()
                If FilterTable IsNot Nothing Then
                    If FilterTable.Rows.Count > 0 Then
                        gridControl.DataSource = FilterTable
                        gridView.ViewCaption = "Commission"
                        Call GridStyle()
                    Else
                        gridControl.DataSource = Nothing
                    End If

                End If
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".LoadData : " & e.Message)
        Finally
        End Try
    End Function


    Private Sub GridStyle()
        With gridView

            .Columns("CommissionID").Visible = False
            .Columns("EmpID").Visible = False
            .Columns("EmpCode").Visible = False

            If rdoCondition.EditValue = 1 Then
                .Columns("EmpTotal").Caption = "ยอดขายรวม"
                .Columns("Commisstion").Caption = "ยอดคอมมิชชัน"
            Else
                .Columns("EmpTotal").Caption = "ยอดขายบุคคล"
                .Columns("Commisstion").Caption = "คอมมิชชันทีม"

                .Columns("TerritoryID").Visible = False
                .Columns("TotalRatio").Visible = False

                .Columns("TerritoryName").Caption = "ชื่อทีมงาน"
                .Columns("TerritoryName").Width = 200
                .Columns("TerritoryName").MaxWidth = 0

                .Columns("GroupTotal").Caption = "ยอดขายทีม"
                .Columns("GroupTotal").Width = 200
                .Columns("GroupTotal").MaxWidth = 250
                .Columns("GroupTotal").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                .Columns("GroupTotal").DisplayFormat.FormatString = "n2"

                .Columns("EmpComm").Caption = "คอมมิชชันบุคคล"
                .Columns("EmpComm").Width = 200
                .Columns("EmpComm").MaxWidth = 250
                .Columns("EmpComm").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                .Columns("EmpComm").DisplayFormat.FormatString = "n2"

            End If

            .Columns("Subject").Caption = "ชื่อคอมมิชชัน"
            .Columns("Subject").Width = 200
            .Columns("Subject").MaxWidth = 0

            .Columns("EmpName").Caption = "พนักงาน"
            .Columns("EmpName").Width = 200
            .Columns("EmpName").MaxWidth = 0


            .Columns("EmpTotal").Width = 200
            .Columns("EmpTotal").MaxWidth = 250
            .Columns("EmpTotal").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            .Columns("EmpTotal").DisplayFormat.FormatString = "n2"


            .Columns("Commisstion").Width = 200
            .Columns("Commisstion").MaxWidth = 250
            .Columns("Commisstion").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            .Columns("Commisstion").DisplayFormat.FormatString = "n2"



        End With
    End Sub

    Private Function Verify() As Boolean
        Try
            DxErrorProvider1.ClearErrors()

            If cboCheckedCommission.Properties.Items.GetCheckedValues.Count = 0 Then
                SetErrorProvider(DxErrorProvider1, cboCheckedCommission, "กรุณาระบุข้อมูล")
            End If

            If rdoCondition.EditValue = 1 Then
                If cboCheckedEmployee.Properties.Items.GetCheckedValues.Count = 0 Then
                    SetErrorProvider(DxErrorProvider1, cboCheckedEmployee, "กรุณาระบุข้อมูล")
                End If
            Else

                    If cboCheckedTerritory.Properties.Items.GetCheckedValues.Count = 0 Then
                        SetErrorProvider(DxErrorProvider1, cboCheckedTerritory, "กรุณาระบุข้อมูล")
                    End If
                End If

            Return DxErrorProvider1.HasErrors = False
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".Verify : " & e.Message)
        End Try
    End Function

#End Region


#Region "Event"



#End Region


    Private Sub btnExportExcel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExportExcel.Click
        Try
            Dim lfrm As New frmPreExport
            lfrm.InitialForm("Stock", gridControl)
            lfrm.ShowDialog()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try
    End Sub
    Private Sub frmCommissionReport_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Try
            ShowProgress(True, "Loading...")
            If Verify() Then
                LoadData()
            End If

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub rdoCondition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rdoCondition.SelectedIndexChanged
        cboCheckedEmployee.Enabled = rdoCondition.EditValue = 1
        cboCheckedTerritory.Enabled = rdoCondition.EditValue = 2
    End Sub
End Class
