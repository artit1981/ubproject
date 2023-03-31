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
        openFileDialog.Filter = "Image Files (*.xls;*.xlsx;*.txt;*.csv)|*.xls;*.xlsx;*.txt;*.csv"
        openFileDialog.Multiselect = False
        openFileDialog.AddExtension = True
        openFileDialog.ValidateNames = True
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer)
        Return openFileDialog
    End Function

    Private Sub AddFile(ByVal pFileNamePath As String)
        Try
            txtFileName.Text = pFileNamePath
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
            ShowProgress(True, "Loading...")
            If e.Page Is BrowsPage Then
                If txtFileName.Text.Trim = "" Then
                    MessageBox.Show("กรุณาระบุไฟล์")
                    e.Handled = True
                Else
                    ShowProgress(True, "Loading...")
                    If LoadFileToGrid() = False Then
                        'e.Handled = True
                        GridPage.DescriptionText = "พบข้อผิดพลาด กรุณาตรวจสอบข้อมูล หรือดำเนินการต่อโดยไม่สนใจข้อมูลที่ผิดพลาด"
                    Else
                        e.Handled = False
                    End If


                End If
            ElseIf e.Page Is GridPage Then
                LoadFileToGridOnImport()
                e.Handled = False
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
                'If e.Page Is WelcomeWizardPage1 Then
                '    GridPage.DescriptionText = ""
                'End If
            End If
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    'Private Function CheckIsError() As Boolean
    '    Dim info As New ErrorInfo()
    '    Try
    '        If mMasterType = MasterType.Product Then
    '            Return mclsProduct.CheckIsError(GridView)
    '        ElseIf mMasterType = MasterType.StockIn Then
    '            Return mclsStock.CheckIsError(GridView)
    '        Else
    '            Return mclsCustomer.CheckIsError(GridView)
    '        End If
    '    Catch e As Exception
    '        Err.Raise(Err.Number, e.Source, "frmImport.CheckIsError : " & e.Message)
    '    Finally
    '    End Try
    'End Function


    Private Function LoadFileToGrid() As Boolean
        Dim dataTable As New DataTable()
        Dim lError As String = ""
        LoadFileToGrid = False


        Try

            dataTable = OpenFile(txtFileName.Text)

            If RadioCompany.EditValue = "Shopee" Then
                mclsShopee = New ShopeeImport
                lError = mclsShopee.LoadFileToGrid(dataTable)
                Dim lShopeePropertyS = mclsShopee.DataDAOs
                GridControl.DataSource = lShopeePropertyS
            Else
                mclsLazada = New LazadaImport
                lError = mclsLazada.LoadFileToGrid(dataTable)
                Dim lLazadaPropertyS = mclsLazada.DataDAOs
                GridControl.DataSource = lLazadaPropertyS
            End If


            GridStyle(GridView)

            If lError <> "" Then
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
        Dim lstrFinish As String = ""
        Dim llngRow(1) As Long
        LoadFileToGridOnImport = False
        Try
            'gIsCheckError = False
            If RadioCompany.EditValue = "Shopee" Then
                llngRow = mclsShopee.ImportData()
                'ElseIf mMasterType = MasterType.StockIn Then
                '    llngRow = mclsStock.ImportData()
                'Else
                '    llngRow = mclsCustomer.ImportData()
            End If

            'lstrFinish = Me.Text & " Success." & vbNewLine
            'lstrFinish &= "Import Total : " & llngRow(0) & " row" & vbNewLine
            'lstrFinish &= "Import Success : " & llngRow(1) & " row" & vbNewLine
            'lstrFinish &= "Import Fail : " & llngRow(0) - llngRow(1) & " row"
            'CompletionWizardPage1.FinishText = lstrFinish

            Me.Close()
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "frmImport.LoadFileToGridOnImport : " & e.Message)
        Finally

        End Try
    End Function


    Private Sub GridStyle(ByVal pGrid As DevExpress.XtraGrid.Views.Grid.GridView)
        With pGrid
            'pGrid.OptionsBehavior.ReadOnly = True

            If RadioCompany.EditValue = "Shopee" Then
                .Columns("ExternalCode").Visible = False
                .Columns("OrderID").Visible = False
                .Columns("OrderUnit").Visible = False
                '.Columns("OrderStatus").Visible = False

                .Columns("IsSelect").MaxWidth = "70"
                .Columns("IsSelect").Caption = "เลือก"

                .Columns("OrderDate").OptionsColumn.ReadOnly = True
                .Columns("OrderDate").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                .Columns("OrderDate").DisplayFormat.FormatString = "dd/MM/yyyy"
                .Columns("OrderDate").Caption = "วันที่ Shopee"
                .Columns("OrderDate").MaxWidth = "150"

                .Columns("PayBy").OptionsColumn.ReadOnly = True
                .Columns("PayBy").Caption = "ผู้นำจ่าย"
                .Columns("PayBy").MaxWidth = "200"


                .Columns("OrderAmount").OptionsColumn.ReadOnly = True
                .Columns("OrderAmount").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                .Columns("OrderAmount").DisplayFormat.FormatString = "n2"
                .Columns("OrderAmount").Caption = "จำนวนเงิน Shopee"
                .Columns("OrderAmount").MaxWidth = "150"

                .Columns("OrderDesc").OptionsColumn.ReadOnly = True
                .Columns("OrderDesc").Caption = "รายการ"
                .Columns("OrderDesc").MaxWidth = "0"

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
            Else
                .Columns("ExternalCode").Visible = False
                .Columns("OrderID").Visible = False

                '.Columns("OrderStatus").Visible = False

                .Columns("IsSelect").MaxWidth = "70"
                .Columns("IsSelect").Caption = "เลือก"

                .Columns("TXDate").OptionsColumn.ReadOnly = True
                .Columns("TXDate").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                .Columns("TXDate").DisplayFormat.FormatString = "dd/MM/yyyy"
                .Columns("TXDate").Caption = "วันที่ Lazada"
                .Columns("TXDate").MaxWidth = "150"

                .Columns("TxNo").OptionsColumn.ReadOnly = True
                .Columns("TxNo").Caption = "Tx. No"
                .Columns("TxNo").MaxWidth = "200"

                .Columns("TxDesc").OptionsColumn.ReadOnly = True
                .Columns("TxDesc").Caption = "รายละเอียด"
                .Columns("TxDesc").MaxWidth = "0"

                .Columns("TxAmount").OptionsColumn.ReadOnly = True
                .Columns("TxAmount").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                .Columns("TxAmount").DisplayFormat.FormatString = "n2"
                .Columns("TxAmount").Caption = "จำนวนเงิน Lazada"
                .Columns("TxAmount").MaxWidth = "150"


                .Columns("ExternalCode").OptionsColumn.ReadOnly = True
                .Columns("ExternalCode").Caption = "Order No."
                .Columns("ExternalCode").MaxWidth = "200"

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