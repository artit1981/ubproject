Public Class frmActivityLog

    Private Sub frmActivityLog_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.Text = "การใช้งานระบบ"
            'ShowProgress(True, "Loading...")
            StartDate.EditValue = DateAdd(DateInterval.Month, -1, GetCurrentDate(Nothing))
            EndDate.EditValue = GetCurrentDate(Nothing)

            SetComboUser()
            SetComboMenu()

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub SetComboUser()
        Dim lcls As New UserDAO
        Dim dataTable As New DataTable()
        Try
            dataTable = lcls.GetDataTableForCombo(0, True)
            cboUser.Properties.DataSource = dataTable
            cboUser.Properties.DisplayMember = "UserName"
            cboUser.Properties.ValueMember = "ID"
            cboUser.EditValue = DBNull.Value

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "frmActivityLog.SetComboPosition : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub

    Private Sub SetComboMenu()
        Dim lcls As New MenuADO
        Dim dataTable As New DataTable()
        Try
            dataTable = lcls.GetDataTableForCombo
            cboMenu.Properties.DataSource = dataTable
            cboMenu.Properties.DisplayMember = "MenuDisplay"
            cboMenu.Properties.ValueMember = "MenuID"
            cboMenu.EditValue = DBNull.Value

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "frmActivityLog.SetComboPosition : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub

    Private Sub btnRefreshUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshUser.Click
        Try
            ShowProgress(True, "Loading...")
            Call SetComboUser()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim lcls As New ActivityDAO
        Dim dataTable As New DataTable()
        Try
            ShowProgress(True, "Loading...")

            dataTable = lcls.GetDataTable(StartDate.EditValue, EndDate.EditValue, ConvertNullToZero(cboUser.GetColumnValue("ID")), ConvertNullToZero(cboMenu.GetColumnValue("MenuID")))

            If dataTable.Rows.Count > 0 Then
                GridControl.DataSource = dataTable
                GridView.ViewCaption = "การใช้งานระบบ"
                Call GridStyle()
            Else
                GridControl.DataSource = Nothing
            End If

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try

    End Sub

    Private Sub GridStyle()
        With GridView

            .Columns("Date").Caption = "วัน"
            .Columns("Date").Width = 100
            .Columns("Date").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            .Columns("Date").DisplayFormat.FormatString = "d"

            .Columns("Time").Caption = "เวลา"
            .Columns("Time").Width = 100
            .Columns("Time").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            .Columns("Time").DisplayFormat.FormatString = "T"

            .Columns("Action").Caption = "การใช้งาน"
            .Columns("Action").Width = 120

            .Columns("MenuDisplay").Caption = "หน้าจอ"
            .Columns("MenuDisplay").Width = 150

            .Columns("UserName").Caption = "ผู้ใช้งาน"
            .Columns("UserName").Width = 100

            .Columns("ComputerName").Caption = "ชื่อเครื่องคอมพิวเตอร์"
            .Columns("ComputerName").Width = 120

            .Columns("Remark").Caption = "รายละเอียด"
            .Columns("Remark").Width = 250

        End With
    End Sub


    Private Sub btnRefreshMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshMenu.Click
        Try
            ShowProgress(True, "Loading...")
            Call SetComboMenu()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub frmActivityLog_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class