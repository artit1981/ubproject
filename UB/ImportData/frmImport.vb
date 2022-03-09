Option Explicit On
Imports System.IO
Imports System.Data.OleDb
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider
Imports ExcelDataReader


Public Class frmImport
    Public Event AddNew()
    Private mMasterType As MasterType
    Private mclsProduct As ProductImport
    Private mclsCustomer As CustomerImport
    Private mclsStock As StockImport
    Private MyWorkSheets As List(Of String)

    Public Property MasterTypes() As Long

        Set(ByVal value As Long)
            mMasterType = value
        End Set
        Get
            Return mMasterType
        End Get
    End Property

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
        openFileDialog.Filter = "Image Files (*.xls;*.xlsx)|*.xls;*.xlsx"
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

    Private Function GetWorksheets(ByVal Connection As OleDbConnection) As IEnumerable
        Try
            Dim schema As DataTable = Connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Nothing, "Table"})
            MyWorkSheets = New List(Of String)
            For Each row As DataRow In schema.Rows
                MyWorkSheets.Add(row("TABLE_NAME").ToString)
            Next
            Return MyWorkSheets
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            Throw
        End Try
    End Function

    Private Function OpenFile(ByVal fileName As String) As Object
        Dim fullFileName = fileName
        Dim data As DataTable = Nothing
        Dim dt As New DataTable
        Try
            If (Not File.Exists(fullFileName)) Then
                System.Windows.Forms.MessageBox.Show("File not found")
                Return Nothing
            End If
            Using stream As FileStream = File.Open(fileName, FileMode.Open, FileAccess.Read)
                Dim excelReader As IExcelDataReader = ExcelReaderFactory.CreateReader(stream)
                Dim lds As DataSet = excelReader.AsDataSet
                data = lds.Tables(0)
                'Remove header
                data.Rows.RemoveAt(0)

            End Using
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
        Return data


        'Dim fullFileName = fileName
        'Dim data As DataTable = Nothing
        'Dim dt As New DataTable
        'Try
        '    If (Not File.Exists(fullFileName)) Then
        '        System.Windows.Forms.MessageBox.Show("File not found")
        '        Return Nothing
        '    End If
        '    Dim connectionString As String = String.Format("Provider=Microsoft.ACE.Oledb.12.0; data source={0}; Extended Properties=Excel 12.0;", fullFileName)
        '    Dim con As OleDbConnection = New OleDbConnection(connectionString)
        '    con.Open()
        '    dt = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
        '    Dim adapter = New OleDbDataAdapter("select * from [" & dt.Rows(0).Item(2) & "]", connectionString)
        '    Dim ds = New DataSet()
        '    Dim tableName As String = "excelData"
        '    adapter.Fill(ds, tableName)
        '    data = ds.Tables(tableName)

        'Catch ex As Exception
        '    ShowErrorMsg(False, ex.Message)
        'End Try




    End Function

#End Region

    Private Sub frmImport_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        mclsProduct = Nothing
        mclsCustomer = Nothing
        mclsStock = Nothing
    End Sub

    Private Sub frmImport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '*** 
        If mMasterType = MasterType.Product Then
            mclsProduct = New ProductImport
            WelcomeWizardPage1.Text = "Import Products"
            Me.Text = "Import Products"
        ElseIf mMasterType = MasterType.StockIn Then
            mclsStock = New StockImport
            WelcomeWizardPage1.Text = "Import Stock"
            Me.Text = "Import Stock"
        Else
            mclsCustomer = New CustomerImport
            mclsCustomer.MasterTypes = mMasterType
            If mMasterType = MasterType.Accounts Then
                WelcomeWizardPage1.Text = "Import Accounts"
                Me.Text = "Import Accounts"
            ElseIf mMasterType = MasterType.Contacts Then
                WelcomeWizardPage1.Text = "Import Contacts"
                Me.Text = "Import Contacts"
            ElseIf mMasterType = MasterType.Agency Then
                WelcomeWizardPage1.Text = "Import Supplier"
                Me.Text = "Import Supplier"
            End If
        End If

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
                If e.Page Is WelcomeWizardPage1 Then
                    GridPage.DescriptionText = ""
                End If
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
        Dim lProductPropertyS As List(Of ProductProperty)
        'Dim lStockPropertyS As List(Of StockProperty)
        'Dim lCustomerPropertyS As List(Of CustomerProperty)
        Try
            'gIsCheckError = True

            'bindingSource1 = Nothing
            'bindingSource1 = New BindingSource

            dataTable = OpenFile(txtFileName.Text)
            'bindingSource1.DataSource = GetType(Object)
            'If mMasterType = MasterType.Product Then
            '    mclsProduct.LoadFileToGrid(dataTable, bindingSource1)
            'ElseIf mMasterType = MasterType.StockIn Then
            '    mclsStock.LoadFileToGrid(dataTable, bindingSource1)
            'Else
            '    mclsCustomer.LoadFileToGrid(dataTable, bindingSource1)
            'End If
            If mMasterType = MasterType.Product Then
                lError = mclsProduct.LoadFileToGrid(dataTable)
                lProductPropertyS = mclsProduct.DataDAOs
                GridControl.DataSource = lProductPropertyS
                'ElseIf mMasterType = MasterType.StockIn Then
                '    lStockPropertyS = mclsStock.LoadFileToGrid(dataTable)
                '    GridControl.DataSource = lStockPropertyS
                'Else
                '    lCustomerPropertyS = mclsCustomer.LoadFileToGrid(dataTable)
                '    GridControl.DataSource = lCustomerPropertyS
            End If

            'DxErrorProvider1.DataSource = bindingSource1
            'DxErrorProvider1.ContainerControl = Me
            'GridControl.DataSource = bindingSource1
            'DxErrorProvider1.DataSource = bindingSource1
            'DxErrorProvider1.ContainerControl = Me
            'GridControl.DataSource = lListData
            GridStyle(GridView)
            'gIsCheckError = True
            'Return CheckIsError() = False
            'GridView.RefreshData()
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
            If mMasterType = MasterType.Product Then
                llngRow = mclsProduct.ImportData()
            ElseIf mMasterType = MasterType.StockIn Then
                llngRow = mclsStock.ImportData()
            Else
                llngRow = mclsCustomer.ImportData()
            End If

            lstrFinish = Me.Text & " Success." & vbNewLine
            lstrFinish &= "Import Total : " & llngRow(0) & " row" & vbNewLine
            lstrFinish &= "Import Success : " & llngRow(1) & " row" & vbNewLine
            lstrFinish &= "Import Fail : " & llngRow(0) - llngRow(1) & " row"
            CompletionWizardPage1.FinishText = lstrFinish
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "frmImport.LoadFileToGridOnImport : " & e.Message)
        Finally

        End Try
    End Function


    Private Sub GridStyle(ByVal pGrid As DevExpress.XtraGrid.Views.Grid.GridView)
        With pGrid
            pGrid.OptionsBehavior.ReadOnly = True
            If mMasterType = MasterType.Product Then
                If Not IsNothing(.Columns("UnitMainID")) Then
                    .Columns("UnitMainID").Visible = False
                    .Columns("ProductCategoryID").Visible = False
                    .Columns("ProductBrandID").Visible = False
                    .Columns("ProductTypeID").Visible = False
                    .Columns("ProductGroup1ID").Visible = False
                    .Columns("ProductDimension1ID").Visible = False
                    .Columns("LocationMainID").Visible = False
                    .Columns("LocationSubID").Visible = False
                    '.Columns("LocationSub").Visible = False
                    .Columns("ProductID").Visible = False
                End If
            ElseIf mMasterType = MasterType.StockIn Then
                If Not IsNothing(.Columns("ProductID")) Then
                    .Columns("ProductID").Visible = False
                    .Columns("UnitMainID").Visible = False
                    .Columns("LocationDTLID").Visible = False
                    '.Columns("VerifyStep1").Width = 0
                End If
            Else
                If Not IsNothing(.Columns("CustomerGroupID")) Then
                    .Columns("CustomerGroupID").Visible = False
                    .Columns("CustomerZoneID").Visible = False
                    .Columns("EmpID").Visible = False
                    .Columns("CriterionPriceID").Visible = False
                    .Columns("ContactPersonID").Visible = False
                    .Columns("CreditRuleID").Visible = False
                    .Columns("VatTypeID").Visible = False
                    '.Columns("VerifyStep1").Width = 0
                    .Columns("MasterTypes").Visible = False
                End If
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