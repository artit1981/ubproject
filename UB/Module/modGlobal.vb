Option Explicit On

Imports DevExpress.XtraEditors
Imports DevExpress.XtraSplashScreen
Imports System.Data.SqlClient

Module modGlobal

    Public Enum MasterType 'Menu id
        Prefix = 1
        LeadType = 2
        Source = 3
        Department = 4
        Position = 5
        Territory = 6
        IndustryType = 7
        BusinessType = 8
        Employee = 9
        Lead = 10
        User = 11
        Privilege = 12
        ActivityBar = 13
        UnitBar = 14
        ProductGroup = 15
        ProductDimension = 16
        ProductCategory = 17
        ProductBrand = 18
        ProductType = 19
        EmpGroup = 20
        Location = 21
        Product = 22
        ContactRole = 23
        CreditRule = 24
        Currency = 25
        Contacts = 26
        Accounts = 27
        RunningFormat = 28
        VerifyCustomer = 29
        OpportunityType = 30
        OpportunityStage = 31
        Opportunity = 32
        VatType = 33
        SellOrders = 34
        Quotation = 35
        CriterionPrice = 36
        InformPrice = 37
        CompanyType = 38
        Invoice = 39
        StockIn = 40
        Shiping = 41
        ShipingMethod = 42
        ShipingBy = 43
        Bill = 44
        BillMedthod = 45
        CheckStock = 46
        Agency = 47
        PurchaseOrder = 48
        Company = 49
        ApproveUser = 50
        ApproveTX = 51
        CreditGroup = 52
        Reserve = 53
        AddCredit = 54
        ReduceCredit = 55
        Receipt = 56
        InformPriceBuy = 57
        InvoiceBuy = 58
        Asset = 59
        ReportTaxSell = 60
        AddCreditBuy = 61
        ReduceCreditBuy = 62
        ShipingRule = 63
        TaxType = 64
        CustomerZone = 65
        CustomerGroup = 66
        Claim = 67
        ClaimOut = 68
        UpdateStock = 69
        ReceiptBuy = 70
        BankAccount = 71
        OrderHis = 72
        Borrow = 73
        ShipingBuy = 74
        RecordCheque = 75
        QuotationRemark = 76
        ReceiptCut = 77
        ReportSellAnalyze = 78
        TaxNumber = 79
        UpdateSN = 80
        ReportTaxAtSell = 81
        ReportSN = 82
        Expose = 83
        OrderSNHis = 84
        MakePO = 85
        OrderHisExport = 86
        CancelPO = 87
        ManageTeam = 88
        InformPricePro = 89
        InformPriceProExport = 90
        Campaign = 91
        ReportDeal = 92
        UpdateSNStatus = 93
        Bank = 94
        OrderSellHis = 95
        OrderSellHisExp = 96
        ApproveStock = 97
        Province = 98
    End Enum

    Public Enum DataMode
        ModeNone = 0
        ModeNew = 1
        ModeEdit = 2
        ModeDelete = 3
        ModePreView = 4
        ModeOpen = 5
        ModeLogIn = 6
        ModeLogOut = 7
        ModeCopy = 8
        ModeConvert = 9
        ModeImport = 10
        ModeNotApprove = 11
    End Enum

    Public Enum EnumStatus
        Open = 1
        Close = 2
        WaitApprove = 3
        Approve = 4
        NotApprove = 5
        Ordering = 6
        Ordered = 7
        Receive = 8
        Billed = 9
        Waiting = 10
        Cancel = 11
    End Enum

    Public Enum Privilege
        Visible = 1
        Enable = 2
        Add = 4
        Edit = 8
        Delete = 16
        Print = 32
        Import = 64
        Quick = 128
        Copy = 256
        Assign = 512
        Convert = 1024
    End Enum



    Public cEN As New System.Globalization.CultureInfo("en-US")
    Public cTH As New System.Globalization.CultureInfo("th-TH")

    Public gUserID As Long
    Public gEmpID As Long
    Public gPrivilegeID As Long
    Public gCompanyName As String
    Public gUserName As String
    Public gEmpName As String
    Public gTerritoryID As Long
    Public gConnection As DBConnection

    'App setup
    Public gConString As String
    Public gLastLogin As String
    Public gDBServerName As String
    Public gDatabaseName As String
    Public gSkinName As String
    Public gDBUser As String
    Public gDBPass As String
    Public gOpenTab As String


    'Approve setup
    Public gIsApproveLimitUser As Boolean
    Public gIsApproveOrderUser As Boolean

    Public gCustomerID As Long '' For Refresh uc...

    Public gIsCheckError As Boolean = False
    Public gConnectionError As Boolean = False
    Public gShowDateReport As Boolean = True

    'Calc
    Public gGrandAmount As Decimal = 0

    Public Sub InsertActivity(ByVal Action As DataMode, ByVal MenuID As MasterType, ByVal Remark As String, ByRef ptr As SqlTransaction)
        Dim lcls As New ActivityDAO
        Try
            Dim lAction As String = "", lMenu As String = ""

            Select Case Action
                Case DataMode.ModeOpen : lAction = "เปิดหน้าจอ"
                Case DataMode.ModeDelete : lAction = "ลบข้อมูล"
                Case DataMode.ModeEdit : lAction = "แก้ไขข้อมูล"
                Case DataMode.ModeNew : lAction = "เพิ่มข้อมูล"
                Case DataMode.ModeLogIn : lAction = "เข้าใช้งานระบบ"
                Case DataMode.ModeLogOut : lAction = "ออกจากระบบ"
                Case DataMode.ModeImport : lAction = "นำเข้าข้อมูล"
            End Select

            lcls.SaveData(lAction, MenuID, Remark, ptr)
        Catch e As Exception

            Err.Raise(Err.Number, e.Source, "modGlobal.InsertActivity : " & e.Message)
        Finally
            lcls = Nothing
        End Try

    End Sub


    Public Sub ShowProgress(ByVal IsShow As Boolean, ByVal Title As String)

        Try
            If IsShow Then
                'frmMain.ProgressStatus.Caption = Title
                frmMain.Cursor = Cursors.AppStarting
                SplashScreenManager.ShowForm(frmMain, GetType(frmLoading), True, True, False)
                'frmMain.ProgressStatus.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                'Application.DoEvents()
                'If frmMain.backgroundWorker1.IsBusy <> True Then
                '    ' Start the asynchronous operation.
                '    frmMain.backgroundWorker1.RunWorkerAsync()
                'End If
            Else
                'frmMain.ProgressStatus.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                frmMain.Cursor = Cursors.Default
                SplashScreenManager.CloseForm(False)
                'If frmMain.backgroundWorker1.WorkerSupportsCancellation = True Then
                '    ' Cancel the asynchronous operation.
                '    frmMain.backgroundWorker1.CancelAsync()
                'End If
                'frmLoading.Close()
            End If

        Catch e As Exception
            frmMain.Cursor = Cursors.Default
            Err.Raise(Err.Number, e.Source, "modGlobal.ShowProgress : " & e.Message)
        Finally

        End Try

    End Sub


    Public Sub ShowErrorMsg(ByVal IsStop As Boolean, ByVal Title As String)
        'frmMain.Cursor = Cursors.Default
        ShowProgress(False, "")
        Err.Clear()
        If IsStop Then
            XtraMessageBox.Show(Title, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Application.Exit()
        Else
            'XtraMessageBox.AllowCustomLookAndFeel = True
            XtraMessageBox.Show(Title, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
    End Sub


    Public Function ConvertNullToZero(ByVal pField As Object) As Decimal

        Try
            'ConvertNullToZero = Convert.ToDecimal(pField)
            If IsDBNull(pField) Then
                ConvertNullToZero = 0
            ElseIf Not IsNumeric(pField) Then
                ConvertNullToZero = 0
            ElseIf VarType(pField) = vbBoolean Then
                If pField = True Then
                    ConvertNullToZero = 1
                Else
                    ConvertNullToZero = 0
                End If

            Else
                ConvertNullToZero = pField
            End If
        Catch e As Exception
            ConvertNullToZero = 0
            Err.Raise(Err.Number, e.Source, "modGlobal.ConvertNullToZero : " & e.Message)
        End Try

    End Function

    Public Function ConvertNullToBoolean(ByVal pField As Object) As Boolean

        Try
            If IsDBNull(pField) Then
                ConvertNullToBoolean = False
            Else
                ConvertNullToBoolean = pField
            End If
        Catch e As Exception
            ConvertNullToBoolean = False
            Err.Raise(Err.Number, e.Source, "modGlobal.ConvertNullToBoolean : " & e.Message)
        End Try

    End Function

    'Public Function ConvertZeroToNull(ByVal pField As Long) As Object
    '    If pField = 0 Then
    '        Return DBNull.Value
    '    Else
    '        Return pField
    '    End If
    'End Function

    Public Function ConvertNullToString(ByVal pField As Object, Optional ByVal pLimit As Boolean = False, Optional ByVal pLength As Long = 0) As String
        ConvertNullToString = ""
        Try
            'ConvertNullToString = Convert.ToString(pField)
            If pField Is Nothing Then
                ConvertNullToString = ""
            ElseIf IsDBNull(pField) Then
                ConvertNullToString = ""
            ElseIf pField.ToString = "" Then
                ConvertNullToString = ""
            Else
                If pLimit = True Then
                    ConvertNullToString = Microsoft.VisualBasic.Strings.Left(pField, pLength).Trim
                Else
                    ConvertNullToString = pField.ToString.Trim
                End If

            End If
        Catch e As Exception
            ConvertNullToString = ""
            Err.Raise(Err.Number, e.Source, "modGlobal.ConvertNullToString : " & e.Message)
        End Try
    End Function

    Public Function ConvertNullToDate(ByVal pField As Object) As String

        Try
            If IsDBNull(pField) Then
                ConvertNullToDate = ""
            ElseIf IsDate(pField) Then
                ConvertNullToDate = Format(pField, "dd MMMM yyyy")
            Else
                ConvertNullToDate = ""
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modGlobal.ConvertNullToDate : " & e.Message)
            ConvertNullToDate = ""
        End Try
    End Function

    Public Function ConvertNullToDateTime(ByVal pField As Object) As String

        Try
            If IsDBNull(pField) Then
                ConvertNullToDateTime = ""
            ElseIf IsDate(pField) Then
                ConvertNullToDateTime = Format(pField, "dd MMMM yyyy HH:mm:ss")
            Else
                ConvertNullToDateTime = ""
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modGlobal.ConvertNullToDateTime : " & e.Message)
            ConvertNullToDateTime = ""
        End Try
    End Function

    Public Function formatSQLDate(ByVal pDate As Date) As String

        Try
            formatSQLDate = pDate.ToString("yyyy-MM-dd", cEN)
            'If CDec(Format(Now, "yyyy")) > 2500 Then
            '    formatSQLDate = Year(pDate) & Format(pDate, "-MM-dd")
            'Else
            '    formatSQLDate = Format(pDate, "yyyy-MM-dd")
            'End If
        Catch e As Exception

            Err.Raise(Err.Number, e.Source, "modGlobal.formatSQLDate : " & e.Message)
            formatSQLDate = ""
        End Try
    End Function

    Public Function formatSQLDateTime(ByVal pDate As Date) As String
        Try
            formatSQLDateTime = pDate.ToString("yyyy-MM-dd HH:mm:ss", cEN)
            'If CDec(Format(Now, "yyyy")) > 2500 Then
            '    formatSQLDateTime = CDec(Format(Now, "yyyy")) - 543 & Format(pDate, "-MM-dd HH:mm:ss")
            'Else
            '    formatSQLDateTime = Format(pDate, "yyyy-MM-dd HH:mm:ss")
            'End If

        Catch e As Exception

            Err.Raise(Err.Number, e.Source, "modGlobal.formatSQLDateTime : " & e.Message)
            formatSQLDateTime = ""
        End Try
    End Function

    Public Sub ClearForm(ByVal parent As System.Windows.Forms.Control)
        Dim i As Long = 1
        Try
            For Each ctrControl As System.Windows.Forms.Control In parent.Controls
                'Loop through all controls 
                If Object.ReferenceEquals(ctrControl.[GetType](), GetType(System.Windows.Forms.TextBox)) Then
                    DirectCast(ctrControl, System.Windows.Forms.TextBox).Text = String.Empty
                ElseIf Object.ReferenceEquals(ctrControl.[GetType](), GetType(System.Windows.Forms.RichTextBox)) Then
                    DirectCast(ctrControl, System.Windows.Forms.RichTextBox).Text = String.Empty
                ElseIf Object.ReferenceEquals(ctrControl.[GetType](), GetType(System.Windows.Forms.ComboBox)) Then
                    DirectCast(ctrControl, System.Windows.Forms.ComboBox).SelectedIndex = -1
                ElseIf Object.ReferenceEquals(ctrControl.[GetType](), GetType(System.Windows.Forms.CheckBox)) Then
                    DirectCast(ctrControl, System.Windows.Forms.CheckBox).Checked = False
                ElseIf Object.ReferenceEquals(ctrControl.[GetType](), GetType(System.Windows.Forms.RadioButton)) Then
                    DirectCast(ctrControl, System.Windows.Forms.RadioButton).Checked = False
                ElseIf Object.ReferenceEquals(ctrControl.[GetType](), GetType(DevExpress.XtraEditors.TextEdit)) Then
                    DirectCast(ctrControl, DevExpress.XtraEditors.TextEdit).Text = String.Empty
                ElseIf Object.ReferenceEquals(ctrControl.[GetType](), GetType(DevExpress.XtraEditors.MemoEdit)) Then
                    DirectCast(ctrControl, DevExpress.XtraEditors.MemoEdit).Text = String.Empty
                ElseIf Object.ReferenceEquals(ctrControl.[GetType](), GetType(DevExpress.XtraEditors.CheckEdit)) Then
                    DirectCast(ctrControl, DevExpress.XtraEditors.CheckEdit).Checked = False
                ElseIf Object.ReferenceEquals(ctrControl.[GetType](), GetType(DevExpress.XtraEditors.ComboBoxEdit)) Then
                    DirectCast(ctrControl, DevExpress.XtraEditors.ComboBoxEdit).SelectedIndex = -1
                ElseIf Object.ReferenceEquals(ctrControl.[GetType](), GetType(DevExpress.XtraEditors.SearchLookUpEdit)) Then
                    DirectCast(ctrControl, DevExpress.XtraEditors.SearchLookUpEdit).Text = ""
                ElseIf Object.ReferenceEquals(ctrControl.[GetType](), GetType(DevExpress.XtraEditors.LookUpEdit)) Then
                    ''DirectCast(ctrControl, DevExpress.XtraEditors.LookUpEdit).EditValue = DBNull.Value
                    DirectCast(ctrControl, DevExpress.XtraEditors.LookUpEdit).Text = ""
                ElseIf Object.ReferenceEquals(ctrControl.[GetType](), GetType(DevExpress.XtraEditors.DateEdit)) Then
                    DirectCast(ctrControl, DevExpress.XtraEditors.DateEdit).DateTime = GetCurrentDate(Nothing)
                ElseIf Object.ReferenceEquals(ctrControl.[GetType](), GetType(DevExpress.XtraEditors.CalcEdit)) Then
                    DirectCast(ctrControl, DevExpress.XtraEditors.CalcEdit).Value = 0
                ElseIf Object.ReferenceEquals(ctrControl.[GetType](), GetType(DevExpress.XtraEditors.CheckEdit)) Then
                    DirectCast(ctrControl, DevExpress.XtraEditors.CheckEdit).Checked = False
                End If
                'If ctrControl.Controls.Count > 0 Then
                '    ClearForm(ctrControl)
                'End If
                i = i + 1
            Next
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modGlobal.ClearForm : " & e.Message)
        End Try

    End Sub


    Public Sub LockControl(ByVal C As Object)
        Try
            Select Case TypeName(C)
                Case "TextBoxX", "ComboTree", "IntegerInput", "IntegerInput", "DoubleInput", "DateTimeInput", "CheckEdit"
                    C.ReadOnly = True
                    C.backcolor = Color.LightYellow
                Case "ComboBoxEx", "ComboBoxEx"
                    C.Enabled = False
                    C.DisabledBackColor = Color.LightYellow
                Case "CheckBoxX"
                    C.Enabled = False
                    C.backcolor = Color.LightYellow
                Case "TextEdit", "MemoEdit", "ComboBoxEdit", "SearchLookUpEdit", "DateEdit", "DateEdit", "CalcEdit"
                    C.Properties.ReadOnly = True
                    C.backcolor = Color.LightYellow
                Case "SimpleButton"
                    C.Enabled = True

                Case Else
            End Select
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modGlobal.LockControl :" & e.Message)
        Finally
        End Try
    End Sub

    Public Sub UnLockControl(ByVal C As Object)
        Try

            Select Case TypeName(C)
                Case "TextBoxX", "ComboTree", "IntegerInput", "IntegerInput", "DoubleInput", "DateTimeInput", "CheckEdit"
                    C.ReadOnly = False
                    C.backcolor = Color.White
                Case "ComboBoxEx"
                    C.Enabled = True
                    C.DisabledBackColor = Color.White
                Case "CheckBoxX"
                    C.Enabled = True
                    C.backcolor = Color.White
                Case "TextEdit", "MemoEdit", "ComboBoxEdit", "SearchLookUpEdit", "DateEdit", "DateEdit", "CalcEdit"
                    C.Properties.ReadOnly = False
                    C.backcolor = Color.White
                Case "SimpleButton"
                    C.Enabled = True
                Case Else

            End Select


        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modGlobal.UnLockControl : " & e.Message)
        Finally
        End Try

    End Sub



End Module
