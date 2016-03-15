Option Explicit On

Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns

Public Class frmSN

    Dim mProductName As String
    Dim mProductCode As String
    Dim mUnit As Long
    Dim mSnList As List(Of SnDAO)
    Dim mIsReadOnly As Boolean
    Private mIsFromLoad As Boolean
    Dim mOrderType As String
    Dim mProductIDs As Long
    Dim mIsModePrint As Boolean = False
    Dim mStockType As String = ""
    Dim mUnitMain As Long
    Dim mUnitName As String
    Dim mUnitMainName As String
    Dim mIsModeDelete As Boolean = False

    Public Property SnList() As List(Of SnDAO)
        Get
            Return mSnList
        End Get
        Set(ByVal value As List(Of SnDAO))
            mSnList = value
        End Set
    End Property

    Public WriteOnly Property ProductCodes() As String
        Set(ByVal value As String)
            mProductCode = value
        End Set
    End Property

    Public WriteOnly Property ProductNames() As String
        Set(ByVal value As String)
            mProductName = value
        End Set
    End Property

    Public WriteOnly Property Unit() As Long
        Set(ByVal value As Long)
            mUnit = value
        End Set
    End Property

    Public WriteOnly Property UnitMain() As Long
        Set(ByVal value As Long)
            mUnitMain = value
        End Set
    End Property

    Public WriteOnly Property UnitNames() As String
        Set(ByVal value As String)
            mUnitName = value
        End Set
    End Property
    Public WriteOnly Property UnitMainNames() As String
        Set(ByVal value As String)
            mUnitMainName = value
        End Set
    End Property

    Public WriteOnly Property IsReadOnly() As Boolean
        Set(ByVal value As Boolean)
            mIsReadOnly = value
        End Set
    End Property

    Public WriteOnly Property IsModeDelete() As Boolean
        Set(ByVal value As Boolean)
            mIsModeDelete = value
        End Set
    End Property

    Public WriteOnly Property IsModePrint() As Boolean
        Set(ByVal value As Boolean)
            mIsModePrint = value
        End Set
    End Property

    Public WriteOnly Property OrderType() As String
        Set(ByVal value As String)
            mOrderType = value
        End Set
    End Property

    Public WriteOnly Property StockType() As String
        Set(ByVal value As String)
            mStockType = value
        End Set
    End Property
    Public WriteOnly Property ProductIDs() As Long
        Set(ByVal value As Long)
            mProductIDs = value
        End Set
    End Property

    Private Sub frmSN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mIsFromLoad = True
        btnPrint.Visible = False
        lblProcode.Visible = False
        btnFind.Enabled = False

        If mIsModePrint = True Then
            btnOK.Visible = False
            btnFind.Enabled = True
            btnPrint.Visible = True
            btnLoadSN.Visible = False
            btnSelectSN.Visible = False
            lblProcode.Visible = True
            ProductCode.Properties.Appearance.BackColor = Color.White
            ProductCode.Properties.ReadOnly = False
            UnitsMain.Properties.Appearance.BackColor = Color.White
            UnitsMain.Properties.ReadOnly = False
            UnitsMain.EditValue = "10"
            mUnitMain = 10
        ElseIf mIsReadOnly = True Then
            btnOK.Visible = True
            btnOK.Enabled = False
            btnLoadSN.Enabled = False
            btnGenID.Enabled = False
            SNType.Enabled = False
            SNNo.Enabled = False
            GridView1.OptionsBehavior.ReadOnly = True
        Else
            Select Case mOrderType
                Case MasterType.StockIn.ToString
                    btnLoadSN.Visible = False
                    btnGenID.Enabled = True
                    SNType.Enabled = True
                    btnSelectSN.Visible = False
                Case MasterType.SellOrders.ToString
                    btnLoadSN.Visible = True
                    SNType.Enabled = False
                    btnGenID.Enabled = False
                    btnSelectSN.Visible = True
                    'LoadSN()
                Case MasterType.UpdateStock.ToString
                    btnLoadSN.Visible = False
                    btnGenID.Enabled = False
                    SNType.Enabled = False
                    btnSelectSN.Visible = False
                Case MasterType.ReduceCredit.ToString, MasterType.ReduceCreditBuy.ToString, MasterType.AddCreditBuy.ToString, MasterType.AddCredit.ToString
                    If mStockType = "O" Then 'ตัด
                        btnLoadSN.Visible = False
                        btnGenID.Enabled = False
                        SNType.Enabled = False
                        btnSelectSN.Visible = False
                    ElseIf mStockType = "I" Then 'เพิ่ม
                        btnLoadSN.Visible = False
                        btnGenID.Enabled = False
                        SNType.Enabled = False
                        btnSelectSN.Visible = False
                    Else
                        mStockType = ""
                    End If
            End Select
        End If

        If IsNothing(mSnList) Then
            mSnList = New List(Of SnDAO)
        End If


        GridControl1.DataSource = mSnList
        If mIsModeDelete = False Then
            GridView1.Columns("IsDelete").FilterInfo = New ColumnFilterInfo("[IsDelete]=0")
        End If

        Init()
        InitialCombo()
        ProductCode.EditValue = mProductCode
        ProductName.EditValue = mProductName
        Units.EditValue = mUnit
        UnitsMain.EditValue = mUnitMain
        UnitName.EditValue = mUnitName
        UnitMainName.EditValue = mUnitMainName

        Call LoadData()
        Call LoadLastSN()
        If mIsModePrint = True Then
            ProductCode.Focus()
        End If
        mIsFromLoad = False
    End Sub

    Private Sub Init()
        Try
            If mIsFromLoad = False Then
                If SNType.EditValue = "M" Then
                    If IsNothing(mSnList) Then
                        mSnList = New List(Of SnDAO)
                    End If
                    SNNo.Focus()
                Else
                    FormatFront.Focus()
                    SNNo.EditValue = ""
                End If
            End If

            FormatFront.Enabled = (SNType.EditValue = "A")
            FormatMidle.Enabled = (SNType.EditValue = "A")
            RunningCount.Enabled = (SNType.EditValue = "A")
            btnGenID.Enabled = (SNType.EditValue = "A")
            StartNo.Enabled = (SNType.EditValue = "A")
            SNNo.Enabled = (SNType.EditValue = "M")


        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "frmSN.Init : " & e.Message)
        Finally

        End Try
    End Sub

    Private Sub InitialCombo()
        Try
            FormatMidle.Properties.Items.Add("None")
            FormatMidle.Properties.Items.Add("-")
            FormatMidle.Properties.Items.Add("/")
            FormatMidle.Properties.Items.Add("\")
            FormatMidle.EditValue = "None"
            FormatFront.EditValue = ""
            RunningCount.EditValue = "10"
            StartNo.EditValue = "1"
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "frmSN.InitialCombo : " & e.Message)
        End Try
    End Sub

    Private Sub SNType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SNType.SelectedIndexChanged
        Init()
    End Sub

    Private Sub LoadData()
        Try
            GridControl1.DataSource = mSnList
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try
    End Sub



    Private Sub LoadLastSN()
        Dim lclsSN As New SnDAO
        Dim dataSN As New DataTable()
        Try
            If mProductIDs > 0 Then

                dataSN = lclsSN.GetDataTable(Nothing, 0, mProductIDs, "'New','Close'", Nothing, False, "")

                For Each dr2 As DataRow In dataSN.Rows
                    SnLast.EditValue = ConvertNullToString(dr2("SerialNumberNo"))
                Next

            End If

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "frmSN.LoadLastSN : " & ex.Message)
        Finally

        End Try
    End Sub


    Private Sub btnGenID_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGenID.Click
        Dim lstrExam As String = "", lRunCount As String = "", i As Integer, lLastCount As Long
        Dim lCode As String = "", lSNAdd As Long = 0
        Dim lclsSN As SnDAO

        Try
            Cursor = Cursors.WaitCursor
            If IsNothing(mSnList) Then
                mSnList = New List(Of SnDAO)
            Else
                If mIsModePrint Then
                    mSnList.Clear()
                End If

            End If

            'Dim lUnit = mUnit
            lLastCount = StartNo.EditValue
            If FormatFront.EditValue <> "None" Then
                lstrExam = FormatFront.EditValue.ToString.ToUpper
            End If

            If FormatMidle.EditValue <> "None" Then
                lstrExam = lstrExam & FormatMidle.EditValue
            End If

            For i = 1 To RunningCount.EditValue
                lRunCount = lRunCount & "0"
            Next
            lSNAdd = mSnList.Count
            Do Until lSNAdd = UnitsMain.EditValue
                lCode = lstrExam & lLastCount.ToString(lRunCount)
                If mOrderType = MasterType.StockIn.ToString Then
                    lclsSN = New SnDAO
                    If lclsSN.CheckSNIsExist(mProductIDs, lCode, "'New','Close'", Nothing) = True Then
                        MessageBox.Show("Serial Number ซ้ำ :" & lCode, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Do
                    End If
                End If
                lclsSN = New SnDAO
                lclsSN.SerialNumberID = 0
                lclsSN.SerialNumberNo = lCode
                lclsSN.Status = "New"
                lclsSN.IsDelete = 0
                lSNAdd = lSNAdd + 1
                lLastCount = lLastCount + 1
                mSnList.Add(lclsSN)
            Loop

            GridControl1.RefreshDataSource()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            Cursor = Cursors.Default
        End Try

    End Sub


    Private Sub btnLoadSN_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLoadSN.Click
        Dim lclsSN As New SnDAO
        Dim dataSN As New DataTable()
        Try
            Cursor = Cursors.WaitCursor
            LoadSN()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub


    Private Sub LoadSN()
        Dim lclsSN As New SnDAO
        Dim dataSN As New DataTable()
        Try
            If IsNothing(mSnList) Then
                mSnList = New List(Of SnDAO)
            End If
            dataSN = lclsSN.GetDataTable(Nothing, 0, mProductIDs, "'New'", Nothing, False, "")
            For Each dr2 As DataRow In dataSN.Rows
                If mSnList.Count < UnitsMain.EditValue Then
                    lclsSN = New SnDAO
                    lclsSN.SerialNumberID = 0
                    lclsSN.SerialNumberNo = ConvertNullToString(dr2("SerialNumberNo"))
                    lclsSN.IsDelete = ConvertNullToZero(dr2("IsDelete"))
                    lclsSN.Status = "None"
                    mSnList.Add(lclsSN)
                End If
            Next
            GridControl1.RefreshDataSource()
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "frmSN.LoadSN : " & ex.Message)
        Finally
        End Try
    End Sub

    Private Sub SNNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SNNo.KeyPress
        Dim lclsSN As SnDAO, lIndex As Long, lIsError As String = ""
        If e.KeyChar = ChrW(Keys.Enter) And ConvertNullToString(SNNo.EditValue) <> "" Then
            If mSnList.Count > Math.Abs(UnitsMain.EditValue) Then
                MessageBox.Show("รายการครบจำนวน", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                SNNo.SelectAll()
            Else
                lIndex = mSnList.FindIndex(Function(m As SnDAO) m.SerialNumberNo = ConvertNullToString(SNNo.EditValue))
                If lIndex >= 0 Then
                    lIsError = True
                End If

                lclsSN = New SnDAO

                Dim lIsCheckCreditType As Boolean = False
                Select Case mOrderType
                    Case MasterType.ReduceCredit.ToString, MasterType.ReduceCreditBuy.ToString, MasterType.AddCreditBuy.ToString, MasterType.AddCredit.ToString
                        lIsCheckCreditType = True
                End Select

                If mOrderType = MasterType.StockIn.ToString Then
                    If lclsSN.CheckSNIsExist(mProductIDs, ConvertNullToString(SNNo.EditValue), "'New','Close'", Nothing) = True Then
                        lIsError = "Serial Number ซ้ำ"
                    End If
                ElseIf mOrderType = MasterType.UpdateStock.ToString And UnitsMain.EditValue > 0 Then
                    If lclsSN.CheckSNIsExist(mProductIDs, ConvertNullToString(SNNo.EditValue), "'New','Close'", Nothing) = True Then
                        lIsError = "Serial Number ซ้ำ"
                    End If
                ElseIf mOrderType = MasterType.UpdateStock.ToString And UnitsMain.EditValue < 0 Then  '' คืนสต๊อก
                    If lclsSN.CheckSNIsExist(mProductIDs, ConvertNullToString(SNNo.EditValue), "'New'", Nothing) = False Then
                        lIsError = "ไม่พบ Serial Number: " & ConvertNullToString(SNNo.EditValue)
                    End If
                ElseIf mOrderType = MasterType.SellOrders.ToString Then
                    If lclsSN.CheckSNIsExist(mProductIDs, ConvertNullToString(SNNo.EditValue), "'New'", Nothing) = False Then
                        lIsError = "ไม่พบ Serial Number: " & ConvertNullToString(SNNo.EditValue)
                    End If
                ElseIf lIsCheckCreditType = True And mStockType = "I" Then
                    If lclsSN.CheckSNIsExist(mProductIDs, ConvertNullToString(SNNo.EditValue), "'New','Close'", Nothing) = True Then
                        lIsError = "Serial Number ซ้ำ"
                    End If
                ElseIf lIsCheckCreditType = True And mStockType = "O" Then
                    If lclsSN.CheckSNIsExist(mProductIDs, ConvertNullToString(SNNo.EditValue), "'New'", Nothing) = False Then
                        lIsError = "ไม่พบ Serial Number: " & ConvertNullToString(SNNo.EditValue)
                    End If
                End If

                If lIsError = "" Then
                    lclsSN.SerialNumberID = 0
                    lclsSN.SerialNumberNo = ConvertNullToString(SNNo.EditValue)
                    lclsSN.Status = "New"
                    lclsSN.IsDelete = 0
                    mSnList.Add(lclsSN)
                    GridControl1.RefreshDataSource()
                    SNNo.EditValue = ""
                Else
                    MessageBox.Show(lIsError, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    SNNo.SelectAll()
                End If
            End If


        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim lSnData As SnDAO, lSNCount As Long = 0

        'If mSnList.Count <> Math.Abs(UnitsMain.EditValue) Then
        '    MessageBox.Show("รายการ S/N ไม่เท่ากับจำนวนสินค้า", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    SNNo.Focus()
        'Else
        'If GridView1.RowCount > 0 Then
        '    mSnList = Nothing
        '    mSnList = New List(Of SnDAO)
        '    For lRow = 0 To GridView1.RowCount
        '        If ConvertNullToString(GridView1.GetRowCellValue(lRow, "SerialNumberNo")) <> "" Then
        '            lSnData = New SnDAO
        '            lSnData.SerialNumberID = ConvertNullToZero(GridView1.GetRowCellValue(lRow, "SerialNumberID"))
        '            lSnData.SerialNumberNo = ConvertNullToString(GridView1.GetRowCellValue(lRow, "SerialNumberNo"))
        '            lSnData.IsDelete = ConvertNullToZero(GridView1.GetRowCellValue(lRow, "IsDelete"))
        '            lSnData.Status = ConvertNullToString(GridView1.GetRowCellValue(lRow, "Status"))
        '            mSnList.Add(lSnData)
        '            If lSnData.IsDelete = 0 Then
        '                lSNCount = lSNCount + 1
        '            End If
        '        End If

        '    Next
        'End If
        GridView1.ClearColumnsFilter()
        If GridView1.RowCount > 0 Then
            mSnList = Nothing
            mSnList = New List(Of SnDAO)
            For lRow = 0 To GridView1.RowCount
                If ConvertNullToString(GridView1.GetRowCellValue(lRow, "SerialNumberNo")) <> "" Then
                    lSnData = New SnDAO
                    lSnData.SerialNumberID = ConvertNullToZero(GridView1.GetRowCellValue(lRow, "SerialNumberID"))
                    lSnData.SerialNumberNo = ConvertNullToString(GridView1.GetRowCellValue(lRow, "SerialNumberNo"))
                    lSnData.IsDelete = ConvertNullToZero(GridView1.GetRowCellValue(lRow, "IsDelete"))
                    lSnData.Status = ConvertNullToString(GridView1.GetRowCellValue(lRow, "Status"))
                    mSnList.Add(lSnData)
                    If lSnData.IsDelete = 0 Then
                        lSNCount = lSNCount + 1
                    End If
                End If

            Next
        End If


        If lSNCount <> Math.Abs(UnitsMain.EditValue) Then
            MessageBox.Show("รายการ S/N ไม่เท่ากับจำนวนสินค้า", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            SNNo.Focus()
            Exit Sub
        End If

        If mIsReadOnly = False And mOrderType = MasterType.StockIn.ToString Then
            If XtraMessageBox.Show(Me, "ต้องการพิมพ์บาร์โค้ดหรือไม่", "พิมพ์บาร์โค้ด", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                modReport.PrintBarCode(ProductName.EditValue, mSnList)
            End If
        End If

        Me.Close()
        'End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            Cursor = Cursors.WaitCursor
            If mSnList.Count = 0 Then
                MessageBox.Show("กรุณาระบุรายการ S/N", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                SNNo.Focus()
            Else
                modReport.PrintBarCode(ProductName.EditValue, mSnList)
            End If
        Catch ex As Exception
            Cursor = Cursors.Default
            ShowErrorMsg(False, ex.Message)
        Finally
            Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub ProductCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ProductCode.KeyPress
        Dim lProCode As String = ConvertNullToString(ProductCode.EditValue)
        If e.KeyChar = ChrW(Keys.Enter) And mIsModePrint = True And lProCode <> "" Then
            InitialProduct(0, lProCode)
        End If

    End Sub

    Private Sub InitialProduct(ByVal pProID As Long, ByVal pProCode As String)
        Dim lcls As New ProductDAO
        If lcls.InitailData(pProID, 0, pProCode, "", Nothing) Then
            ProductName.EditValue = lcls.NameThai
            ProductCode.EditValue = lcls.Code
            mProductIDs = lcls.ID
            Call LoadLastSN()
        Else
            MessageBox.Show("ไม่พบสินค้ารหัส : " & pProCode, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ProductCode.Focus()
            ProductCode.SelectAll()
        End If
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Try
            Dim lfrmFind As New frmFindProduct
            Dim i As Long
            lfrmFind.LookFor = ConvertNullToString(ProductCode.EditValue)
            lfrmFind.Execute(MasterType.Product, gCustomerID)
            If lfrmFind.IsAccept Then
                If lfrmFind.GetDataKey.Count > 0 Then
                    For i = 1 To lfrmFind.GetDataKey.Count
                        If ConvertNullToZero(lfrmFind.GetDataKey(i)) > 0 Then
                            InitialProduct(ConvertNullToZero(lfrmFind.GetDataKey(i)), "")

                        End If
                    Next
                    lfrmFind = Nothing
                End If
            End If
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally

        End Try
    End Sub

    Private Sub btnSelectSN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectSN.Click
        Dim lSnList As New List(Of SnDAO)
        Dim lfrmSN As New frmSNSelect
        Try

            lfrmSN.ProductCodes = mProductCode
            lfrmSN.ProductNames = mProductName
            lfrmSN.Unit = UnitsMain.EditValue - GridView1.RowCount
            lfrmSN.ProductIDs = mProductIDs
            lfrmSN.ShowDialog()
            lSnList = lfrmSN.SnList
            For Each pSN As SnDAO In lSnList
                mSnList.Add(pSN)
            Next
            GridControl1.DataSource = mSnList
            GridControl1.RefreshDataSource()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Dim lStatus As String = ""
        Dim View As GridView = sender
        If View.RowCount = 0 Then Exit Sub
        Dim rowHandle As Long = (TryCast(GridControl1.MainView, ColumnView)).FocusedRowHandle

        If rowHandle < 0 Then Exit Sub
        lStatus = ConvertNullToString(GridView1.GetRowCellValue(rowHandle, "Status"))
        ControlNavigator1.Buttons.CustomButtons(0).Enabled = Not (lStatus = EnumStatus.Close.ToString)
    End Sub

    Private Sub ControlNavigator1_ButtonClick(sender As Object, e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles ControlNavigator1.ButtonClick
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = GridView1
        view.GridControl.Focus()
        Dim index As Integer = view.FocusedRowHandle
        Select Case e.Button.Tag
            Case "Remove"
                If ConvertNullToString(GridView1.GetRowCellValue(index, "Status")) = "Close" Then
                    XtraMessageBox.Show("Serial Number Close แล้ว ไม่สามารถทำรายการได้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If XtraMessageBox.Show(Me, "ยืนยันการลบรายการสินค้า ใช่หรือไม่", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                        If ConvertNullToZero(GridView1.GetRowCellValue(index, "SerialNumberID")) = 0 Then
                            GridView1.DeleteSelectedRows()
                            GridView1.RefreshData()
                            GridControl1.RefreshDataSource()
                        Else
                            GridView1.SetRowCellValue(index, "IsDelete", 1)
                            GridView1.RefreshData()
                            GridControl1.RefreshDataSource()
                        End If
                    End If
                End If
               
        End Select
    End Sub
End Class