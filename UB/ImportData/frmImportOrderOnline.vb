Option Explicit On
Imports System.Data.OleDb
Imports System.IO
Imports System.Linq
Imports DevExpress.XtraEditors
Imports ExcelDataReader


Public Class frmImportOrderOnline
    Public Event AddNew()
    'Private mMasterType As MasterType
    Private mclsShopee As ShopeeImport
    Private mclsLazada As LazadaImport
    'Private mclsCustomer As CustomerImport
    'Private mclsStock As StockImport
    Private MyWorkSheets As List(Of String)



    Private Sub btnBrows_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrows.Click
        Dim sFileNamePath As String = ""
        Try
            Using OpenFileDialog As OpenFileDialog = Me.GetOpenFileDialog()
                If (OpenFileDialog.ShowDialog(Me) = DialogResult.OK) Then
                    sFileNamePath = OpenFileDialog.FileName
                    Call AddFile(sFileNamePath)
                Else 'Cancel                
                    Exit Sub
                End If
            End Using
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

#Region "FileDialog"
    Private Function GetOpenFileDialog() As OpenFileDialog
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.CheckPathExists = True
        openFileDialog.CheckFileExists = True
        If RadioCompany.EditValue = "Shopee" Then
            openFileDialog.Filter = "Import Files (*.csv)|*.csv"
        Else
            openFileDialog.Filter = "Import Files (*.xls;*.xlsx)|*.xls;*.xlsx"
        End If

        openFileDialog.Multiselect = False
        openFileDialog.AddExtension = True
        openFileDialog.ValidateNames = True
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer)
        Return openFileDialog
    End Function

    Private Sub AddFile(ByVal pFileNamePath As String)
        Try
            txtFileName.Text = pFileNamePath
            If InStr(pFileNamePath.ToUpper, "Shopee".ToUpper) > 0 Then
                RadioCompany.EditValue = "Shopee"
            Else
                RadioCompany.EditValue = "Lazada"
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "frmImport.AddFile : " & ex.Message)
        End Try
    End Sub


    Private Function OpenFile(ByVal fileName As String) As Object
        Dim fullFileName = fileName
        Dim data As New DataTable
        'Dim dt As New DataTable
        Try
            If (Not File.Exists(fullFileName)) Then
                System.Windows.Forms.MessageBox.Show("File not found")
                Return Nothing
            End If

            If RadioCompany.EditValue = "Shopee" Then
                Dim lines = File.ReadAllLines(fullFileName)

                data.Columns.Add("OrderDate", GetType(Date))
                data.Columns.Add("PayBy", GetType(String))
                data.Columns.Add("OrderAmount", GetType(Decimal))
                data.Columns.Add("OrderDesc", GetType(String))
                data.Columns.Add("OrderStatus", GetType(String))
                data.Columns.Add("OrderUnit", GetType(Decimal))

                For Each line In lines.Skip(7)
                    Dim parts = line.Split(",")
                    'Dim ltmp = parts
                    data.Rows.Add(parts)
                Next
            Else
                Using stream As FileStream = File.Open(fullFileName, FileMode.Open, FileAccess.Read)
                    Dim excelReader As IExcelDataReader = ExcelReaderFactory.CreateReader(stream)
                    Dim lds As DataSet = excelReader.AsDataSet
                    data = lds.Tables(0)
                    'Remove header
                    data.Rows.RemoveAt(0)
                End Using
            End If

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
        Return data



    End Function

#End Region

    Private Sub frmImport_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub frmImport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblError.Text = ""
        Me.Text = "Import Online Sales"
    End Sub

    Private Sub WizardControl1_CancelClick(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles WizardControl1.CancelClick
        If XtraMessageBox.Show(Me, "ยืนยันการปิดหน้าจอ", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub WizardControl1_FinishClick(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles WizardControl1.FinishClick
        Me.Close()
    End Sub

    Private Sub WizardControl1_NextClick(ByVal sender As Object, ByVal e As DevExpress.XtraWizard.WizardCommandButtonClickEventArgs) Handles WizardControl1.NextClick
        Try
            GridPage.DescriptionText = ""
            lblError.Text = ""
            ShowProgress(True, "Loading...")
            If e.Page Is BrowsPage Then
                If txtFileName.Text.Trim = "" Then
                    lblError.Text = "กรุณาระบุไฟล์"
                    e.Handled = True
                Else
                    txtError.EditValue = ""
                    ShowProgress(True, "Loading...")
                    If LoadFileToGrid() = False Then
                        'e.Handled = True
                        GridPage.DescriptionText = "พบข้อผิดพลาด กรุณาตรวจสอบข้อมูล"
                        e.Handled = True
                    Else
                        e.Handled = False
                    End If


                End If
            ElseIf e.Page Is GridPage Then
                If LoadFileToGridOnImport() Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If

            End If
        Catch ex As Exception
            e.Handled = True
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub WizardControl1_SelectedPageChanging(ByVal sender As Object, ByVal e As DevExpress.XtraWizard.WizardPageChangingEventArgs) Handles WizardControl1.SelectedPageChanging
        Try
            If e.Direction = DevExpress.XtraWizard.Direction.Forward Then

            ElseIf e.Direction = DevExpress.XtraWizard.Direction.Backward Then
                If e.Page Is BrowsPage Then
                    GridPage.DescriptionText = ""
                    lblError.Text = ""
                End If
            End If
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub



    Private Function LoadFileToGrid() As Boolean
        Dim dataTable As New DataTable()
        Dim lError As String = ""
        LoadFileToGrid = False


        Try

            dataTable = OpenFile(txtFileName.Text)

            If RadioCompany.EditValue = "Shopee" Then
                If dataTable.Columns.Count = 6 Then
                    mclsShopee = New ShopeeImport
                    lError = mclsShopee.LoadFileToGrid(dataTable)
                    Dim lShopeePropertyS = mclsShopee.DataDAOs
                    GridControl.DataSource = lShopeePropertyS
                Else
                    lError = "จำนวนแถวของข้อมูลไม่ถูกต้อง (6 แถว)"
                End If

            Else
                If dataTable.Columns.Count = 22 Then
                    mclsLazada = New LazadaImport
                    lError = mclsLazada.LoadFileToGrid(dataTable)
                    Dim lLazadaPropertyS = mclsLazada.DataDAOs
                    GridControl.DataSource = lLazadaPropertyS
                Else
                    lError = "จำนวนแถวของข้อมูลไม่ถูกต้อง (22 แถว)"
                End If

            End If




            If lError = "" Then
                GridStyle(GridView)
            Else
                lblError.Text = lError
                txtError.EditValue = lError
            End If
            Return lError = ""
            gIsCheckError = False
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "frmImport.LoadFileToGrid : " & e.Message)
        Finally

            dataTable = Nothing
        End Try
    End Function

    Private Function LoadFileToGridOnImport() As Boolean

        Dim bindingSource1 As New BindingSource
        LoadFileToGridOnImport = False
        Try

            If RadioCompany.EditValue = "Shopee" Then
                bindingSource1 = mclsShopee.ImportData()
            Else
                bindingSource1 = mclsLazada.ImportData()
            End If

            If bindingSource1.Count > 0 Then
                ShowProgress(False, "")
                If XtraMessageBox.Show(Me, "ยืนยันการสร้างรายการตัดรับชำระ", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    Dim lFormEdit As New frmBill
                    With lFormEdit
                        .OrderType = MasterType.ReceiptCut
                        .Caption = "ตัดรับชำระ"
                        .MdiParent = frmMain
                        .ModeData = DataMode.ModeNew
                        .IDs = 0
                        .SubOrderList = bindingSource1
                        .Show()

                        Me.Close()
                    End With
                End If
            Else
                txtError.EditValue = "กรุณาเลือกรายการ หรือตรวจสอบข้อผิดพลาด"
            End If

            Return False


        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "frmImport.LoadFileToGridOnImport : " & e.Message)
        Finally

        End Try
    End Function


    Private Sub GridStyle(ByVal pGrid As DevExpress.XtraGrid.Views.Grid.GridView)
        With pGrid

            .Columns("ExternalCode").Visible = False
            .Columns("OrderID").Visible = False

            '.Columns("IsSelect").MaxWidth = "70"
            '.Columns("IsSelect").Caption = "เลือก"

            .Columns("InternalCode").OptionsColumn.ReadOnly = True
            .Columns("InternalCode").Caption = "เลขที่เอกสาร"
            .Columns("InternalCode").MaxWidth = "200"

            .Columns("OrderStatus").OptionsColumn.ReadOnly = True
            .Columns("OrderStatus").Caption = "สถานะเอกสาร"
            .Columns("OrderStatus").MaxWidth = "150"

            .Columns("GrandTotal").OptionsColumn.ReadOnly = True
            .Columns("GrandTotal").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            .Columns("GrandTotal").DisplayFormat.FormatString = "n2"
            .Columns("GrandTotal").Caption = "ยอดรวมรายการ"
            .Columns("GrandTotal").MaxWidth = "200"

            .Columns("DiffAmount").OptionsColumn.ReadOnly = True
            .Columns("DiffAmount").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            .Columns("DiffAmount").DisplayFormat.FormatString = "n2"
            .Columns("DiffAmount").Caption = "ยอดแตกต่าง"
            .Columns("DiffAmount").MaxWidth = "200"

            .Columns("DiffPercen").OptionsColumn.ReadOnly = True
            .Columns("DiffPercen").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            .Columns("DiffPercen").DisplayFormat.FormatString = "n2"
            .Columns("DiffPercen").Caption = "% ยอดต่าง"
            .Columns("DiffPercen").MaxWidth = "150"

            .Columns("TXDate").OptionsColumn.ReadOnly = True
            .Columns("TXDate").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            .Columns("TXDate").DisplayFormat.FormatString = "dd/MM/yyyy"
            .Columns("TXDate").MaxWidth = "150"

            .Columns("TxNo").OptionsColumn.ReadOnly = True
            .Columns("TxNo").MaxWidth = "200"

            .Columns("TxDesc").OptionsColumn.ReadOnly = True
            .Columns("TxDesc").Caption = "รายละเอียด"
            .Columns("TxDesc").MaxWidth = "0"

            .Columns("TxAmount").OptionsColumn.ReadOnly = True
            .Columns("TxAmount").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            .Columns("TxAmount").DisplayFormat.FormatString = "n2"
            .Columns("TxAmount").MaxWidth = "150"

            If RadioCompany.EditValue = "Shopee" Then
                .Columns("TXDate").Caption = "วันที่ Shopee"
                .Columns("TxNo").Caption = "ผู้นำจ่าย"
                .Columns("TxAmount").Caption = "จำนวนเงิน Shopee"
            Else
                .Columns("TXDate").Caption = "วันที่ Lazada"
                .Columns("TxNo").Caption = "Tx. No"
                .Columns("TxAmount").Caption = "จำนวนเงิน Lazada"
            End If

        End With
    End Sub

    Private Sub GridView_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridView.ValidateRow
        'Dim info As New ErrorInfo()
        'If mMasterType = MasterType.Product Then
        '    TryCast(e.Row, ProductProperty).GetError(info)
        'End If

        'e.Valid = info.ErrorText = ""

    End Sub

End Class