Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Module modFunction

    Public Enum GridConditionType
        NotEmpty = 1
    End Enum


    Public Enum FilterBy
        Subject = 1
        Name = 2
        Company = 4
        EmpName = 8
        Code = 16
        Rate = 32
        Customer = 64
        OppName = 128
        Agency = 256
        CustomerCode = 512
    End Enum



    Private mFindAll(1) As String
    Private mFindSubject(1) As String
    Private mFindName(1) As String
    Private mFindCompany(1) As String
    Private mFindOwner(1) As String
    Private mFindRate(1) As String
    Private mFindCode(1) As String
    Private mFindCustomerCode(1) As String
    Private mFindCustomer(1) As String
    Private mFindOppName(1) As String
    Private mFindAgency(1) As String

    Public Sub InitialFilterCon(ByVal pCombo As DevExpress.XtraEditors.ComboBoxEdit, ByVal pFilterBy As FilterBy)
        mFindAll(0) = "ทั้งหมด"
        mFindAll(1) = "*"
        mFindSubject(0) = "หัวเรื่อง"
        mFindSubject(1) = "Subject"
        mFindName(0) = "ชื่อ นามสกุล"
        mFindName(1) = "NAME"
        mFindCompany(0) = "ชื่อบริษัท"
        mFindCompany(1) = "CompanyName"
        mFindOwner(0) = "ผู้รับผิดชอบ"
        mFindOwner(1) = "EMPNAME"
        mFindCode(0) = "รหัส/เลขที่"
        mFindCode(1) = "Code"
        mFindRate(0) = "ระดับความสนใจ"
        mFindRate(1) = "Rating"
        mFindCustomer(0) = "ลูกค้า"
        mFindCustomer(1) = "Customer"
        mFindCustomerCode(0) = "รหัสลูกค้า"
        mFindCustomerCode(1) = "CustomerCode"
        mFindOppName(0) = "ชื่อโอกาสทางการขาย"
        mFindOppName(1) = "OppName"
        mFindAgency(0) = "เจ้าหนี้"
        mFindAgency(1) = "Agency"
        Try
            pCombo.Properties.Items.Add(mFindAll(0))
            If (pFilterBy And FilterBy.Subject) = FilterBy.Subject Then pCombo.Properties.Items.Add(mFindSubject(0))
            If (pFilterBy And FilterBy.Name) = FilterBy.Name Then pCombo.Properties.Items.Add(mFindName(0))
            If (pFilterBy And FilterBy.Company) = FilterBy.Company Then pCombo.Properties.Items.Add(mFindCompany(0))
            If (pFilterBy And FilterBy.EmpName) = FilterBy.EmpName Then pCombo.Properties.Items.Add(mFindOwner(0))
            If (pFilterBy And FilterBy.Code) = FilterBy.Code Then pCombo.Properties.Items.Add(mFindCode(0))
            If (pFilterBy And FilterBy.Rate) = FilterBy.Rate Then pCombo.Properties.Items.Add(mFindRate(0))
            If (pFilterBy And FilterBy.Customer) = FilterBy.Customer Then pCombo.Properties.Items.Add(mFindCustomer(0))
            If (pFilterBy And FilterBy.CustomerCode) = FilterBy.CustomerCode Then pCombo.Properties.Items.Add(mFindCustomerCode(0))
            If (pFilterBy And FilterBy.OppName) = FilterBy.OppName Then pCombo.Properties.Items.Add(mFindOppName(0))
            If (pFilterBy And FilterBy.Agency) = FilterBy.Agency Then pCombo.Properties.Items.Add(mFindAgency(0))
            pCombo.SelectedIndex = 0


        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modFunction.InitialFilterCon : " & e.Message)
        Finally
        End Try
    End Sub

    Public Function InitialFilterMapping(ByRef pSelectBy As String) As String
        Try
            Select Case pSelectBy.Trim
                Case mFindAll(0)
                    Return mFindAll(1)
                Case mFindSubject(0)
                    Return mFindSubject(1)
                Case mFindName(0)
                    Return mFindName(1)
                Case mFindCompany(0)
                    Return mFindCompany(1)
                Case mFindRate(0)
                    Return mFindRate(1)
                Case mFindOwner(0)
                    Return mFindOwner(1)
                Case mFindCode(0)
                    Return mFindCode(1)
                Case mFindRate(0)
                    Return mFindRate(1)
                Case mFindCustomer(0)
                    Return mFindCustomer(1)
                Case mFindCustomerCode(0)
                    Return mFindCustomerCode(1)
                Case mFindOppName(0)
                    Return mFindOppName(1)
                Case mFindAgency(0)
                    Return mFindAgency(1)
                Case Else
                    Return "*"   'Default ALL
            End Select
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "modFunction.InitialFilterMapping : " & ex.Message)
            Return "*"
        End Try
    End Function

    Public Sub ChangeLanguage()
        System.Threading.Thread.CurrentThread.CurrentCulture = New Globalization.CultureInfo("th-TH")
        System.Threading.Thread.CurrentThread.CurrentUICulture = New Globalization.CultureInfo("th-TH")
    End Sub

    Public Sub SetControlMenuPrivilege(ByVal pfrmControl As frmControls, ByVal pMenuId As Long)
        Dim lcls As New MenuADO
        Dim lclsPrivilege As New PrivilegeDAO
        Try


            If lcls.InitailData(pMenuId) Then
                pfrmControl.ImportBar.Visibility = IIf((lcls.ShowMode And Privilege.Import) = Privilege.Import, DevExpress.XtraBars.BarItemVisibility.Always, DevExpress.XtraBars.BarItemVisibility.Never)
                pfrmControl.QuickBar.Visibility = IIf((lcls.ShowMode And Privilege.Quick) = Privilege.Quick, DevExpress.XtraBars.BarItemVisibility.Always, DevExpress.XtraBars.BarItemVisibility.Never)
                pfrmControl.CopyBar.Visibility = IIf((lcls.ShowMode And Privilege.Copy) = Privilege.Copy, DevExpress.XtraBars.BarItemVisibility.Always, DevExpress.XtraBars.BarItemVisibility.Never)
                pfrmControl.AssignBar.Visibility = IIf((lcls.ShowMode And Privilege.Assign) = Privilege.Assign, DevExpress.XtraBars.BarItemVisibility.Always, DevExpress.XtraBars.BarItemVisibility.Never)
                pfrmControl.ConvertBar.Visibility = IIf((lcls.ShowMode And Privilege.Convert) = Privilege.Convert, DevExpress.XtraBars.BarItemVisibility.Always, DevExpress.XtraBars.BarItemVisibility.Never)
            End If


            If lclsPrivilege.InitailData(gPrivilegeID, pMenuId) Then
                pfrmControl.AddBar.Enabled = (lclsPrivilege.PrivilegeData And Privilege.Add) = Privilege.Add
                pfrmControl.EditBar.Enabled = (lclsPrivilege.PrivilegeData And Privilege.Edit) = Privilege.Edit
                pfrmControl.DeleteBar.Enabled = (lclsPrivilege.PrivilegeData And Privilege.Delete) = Privilege.Delete
                pfrmControl.PrintBar.Enabled = (lclsPrivilege.PrivilegeData And Privilege.Print) = Privilege.Print
                pfrmControl.ImportBar.Enabled = (lclsPrivilege.PrivilegeData And Privilege.Import) = Privilege.Import
                pfrmControl.QuickBar.Enabled = (lclsPrivilege.PrivilegeData And Privilege.Quick) = Privilege.Quick
                pfrmControl.CopyBar.Enabled = (lclsPrivilege.PrivilegeData And Privilege.Copy) = Privilege.Copy
                pfrmControl.AssignBar.Enabled = (lclsPrivilege.PrivilegeData And Privilege.Assign) = Privilege.Assign
                pfrmControl.ConvertBar.Enabled = (lclsPrivilege.PrivilegeData And Privilege.Convert) = Privilege.Convert

            End If

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "modFunction.SetControlMenuPrivilege : " & ex.Message)
        Finally
            lcls = Nothing
            lclsPrivilege = Nothing
        End Try
    End Sub


    Public Function IsTrueCondition(ByRef pConditionType As GridConditionType, ByVal val As Object) As Object()
        Dim reply As String = ""
        IsTrueCondition = Nothing
        Select Case pConditionType
            Case GridConditionType.NotEmpty
                Dim lData As String = ConvertNullToString(val)
                If lData = "" Then
                    reply = "กรุณาระบุข้อมูล"
                    Return New Object() {False, reply}
                End If
        End Select


        '    'Dim greater As Boolean = False
        '    'Dim reply As String = ""
        '    'If condition1 = 2 Then
        '    '    reply = "The value must be less than " + value1.ToString()
        '    '    Return New Object() {(dValue < value1), reply}
        '    'End If
        '    'If condition1 = 3 Then
        '    '    reply = "The value must be less than or equal to " + value1.ToString()
        '    '    Return New Object() {(dValue <= value1), reply}
        '    'End If
        '    'If condition1 = 4 Then
        '    '    reply = "The value must not equal " + value1.ToString()
        '    '    Return New Object() {(dValue <> value1), reply}
        '    'End If
        '    'If condition1 = 0 Then
        '    '    reply = "The value must be greater than " + value1.ToString()
        '    '    greater = dValue > value1
        '    'End If
        '    'If condition1 = 1 Then
        '    '    reply = "The value must be greater than or equal to " + value1.ToString()
        '    '    greater = dValue >= value1
        '    'End If
        '    'If condition2 = 0 Then

        '    '    Return New Object() {greater, reply}
        '    'End If
        '    'If greater Then
        '    '    If condition2 = 1 Then
        '    '        reply = "The value must be less than " + value2.ToString()
        '    '        Return New Object() {(greater AndAlso dValue < value2), reply}
        '    '    End If
        '    '    If condition2 = 2 Then
        '    '        reply = "The value must be less than or equal to " + value2.ToString()
        '    '        Return New Object() {(greater AndAlso dValue <= value2), reply}
        '    '    End If
        '    'End If

    End Function

    Public Function AutoGenCode(ByVal MenuID As MasterType, Optional ByRef ptr As SqlTransaction = Nothing) As String
        Dim lcls As New RunningFormatDAO
        AutoGenCode = ""
        Try
            Dim lGenCode As String = ""
            lcls.InitailData(MenuID, ptr)
            Return lcls.GenerateCode(ptr)

        Catch e As Exception

            Err.Raise(Err.Number, e.Source, "modFunction.AutoGenCode : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Function


    Public Function CheckStock(ByVal pProID As Long, ByVal pUnitID As Long, ByVal pLocationDtlID As Long, ByVal pUnits As Long, ByVal lIsStockSum As Boolean, ByRef pDiffUnit As Long) As String
        CheckStock = ""
        Try
            Dim lcls As New ProductStockDAO
            Dim lclsProduct As New ProductDAO
            Dim lclsLocat As New LocationDTLDAO
            Dim lclsUnit As New UnitDAO
            pDiffUnit = 0

            lclsProduct.InitailData(pProID, 0, "", "", Nothing)
            lclsLocat.InitailData(pLocationDtlID)
            lclsUnit.InitailData(pUnitID, "")

            lcls.ProductID = pProID
            lcls.LocationDTLID = pLocationDtlID
            lcls.UnitID = pUnitID

            If lcls.IsExist_Initial(Nothing, lIsStockSum) Then
                pDiffUnit = pUnits - lcls.UnitsStock
                If pUnits > lcls.UnitsStock Then

                    Return "จำนวนสินค้าในสต๊อกมีไม่เพียงพอ : " & lclsProduct.Code & "[คลัง :" & lclsLocat.IDCode & " หน่วย :" & lclsUnit.Code & " ]"
                End If
            Else
                pDiffUnit = pUnits
                Return "ไม่พบสินค้าในสต๊อก" & lclsProduct.Code & " [คลัง :" & lclsLocat.IDCode & " หน่วย :" & lclsUnit.Code & " ]"
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modFunction.CheckStock : " & e.Message)
        End Try
    End Function

    Public Sub SetErrorProvider(ByRef DxError As DXErrorProvider.DXErrorProvider, ByRef control As System.Windows.Forms.Control, ByVal MSG As String)
        Try
            DxError.SetError(control, MSG)
            DxError.SetIconAlignment(control, ErrorIconAlignment.BottomRight)
            DxError.SetErrorType(control, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning)

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modFunction.SetErrorProvider : " & e.Message)
        End Try

    End Sub

    Public Function Show(ByVal text As String, _
                       Optional ByVal caption As String = "", _
                       Optional ByVal buttons As MessageBoxButtons = MessageBoxButtons.OK, _
                       Optional ByVal icon As MessageBoxIcon = MessageBoxIcon.Information, _
                       Optional ByVal defaultButton As MessageBoxDefaultButton = MessageBoxDefaultButton.Button1) _
                           As DialogResult

        If caption.Trim.Length = 0 Then
            caption = Application.ProductName
        End If

        Return DevExpress.XtraEditors.XtraMessageBox.Show(text, caption, buttons, icon, defaultButton)
    End Function

    Private Function NumberToText(ByVal pAmount As Double) As String
        ' ตัวอักษร
        Dim _numberText() As String = {"", "หนึ่ง", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า", "สิบ"}

        ' หลัก หน่วย สิบ ร้อย พัน ...
        Dim _digit() As String = {"", "สิบ", "ร้อย", "พัน", "หมื่น", "แสน", "ล้าน"}
        Dim _value As String, _aWord As String, _text As String
        Dim _numberTranslatedText As String = ""
        Dim _length, _digitPosition As Integer

        _value = pAmount.ToString
        _length = Len(_value) ' ขนาดของ ข้อมูลที่ต้องการแปลง เช่น 122200 มีขนาด เท่ากับ 6

        For i As Integer = 0 To _length - 1 ' วนลูป เริ่มจาก 0 จนถึง (ขนาด - 1)
            ' ตำแหน่งของ หลัก (digit) ของตัวเลข
            ' เช่น
            ' ตำแหน่งหลักที่0 (หลักหน่วย)
            ' ตำแหน่งหลักที่1 (หลักสิบ)
            ' ตำแหน่งหลักที่2 (หลักร้อย)
            ' ถ้าเป็นข้อมูล i = 7 ตำแหน่งหลักจะเท่ากับ 1 (หลักสิบ)
            ' ถ้าเป็นข้อมูล i = 9 ตำแหน่งหลักจะเท่ากับ 3 (หลักพัน)
            ' ถ้าเป็นข้อมูล i = 13 ตำแหน่งหลักจะเท่ากับ 1 (หลักสิบ)
            _digitPosition = i - (6 * ((i - 1) \ 6))
            _aWord = Mid(_value, Len(_value) - i, 1)
            _text = ""
            Select Case _digitPosition
                Case 0 ' หลักหน่วย
                    If _aWord = "1" And _length > 1 Then
                        ' ถ้าเป็นเลข 1 และมีขนาดมากกว่า 1 ให้มีค่าเท่ากับ "เอ็ด"
                        _text = "เอ็ด"
                    ElseIf _aWord <> "0" Then
                        ' ถ้าไม่ใช่เลข 0 ให้หา ตัวอักษร ใน _numberText()
                        _text = _numberText(CInt(_aWord))
                    End If
                Case 1 ' หลักสิบ
                    If _aWord = "1" Then
                        ' ถ้าเป็นเลข 1 ไม่ต้องมี ตัวอักษร อื่นอีก นอกจากคำว่า "สิบ"
                        '_numberTranslatedText = "สิบ" & _numberTranslatedText
                        _text = _digit(_digitPosition)
                    ElseIf _aWord = "2" Then
                        ' ถ้าเป็นเลข 2 ให้ตัวอักษรคือ "ยี่สิบ"
                        _text = "ยี่" & _digit(_digitPosition)
                    ElseIf _aWord <> "0" Then
                        ' ถ้าไม่ใช่เลข 0 ให้หา ตัวอักษร ใน _numberText() และหาหลัก(digit) ใน _digit()
                        _text = _numberText(CInt(_aWord)) & _digit(_digitPosition)
                    End If
                Case 2, 3, 4, 5 ' หลักร้อย ถึง แสน
                    If _aWord <> "0" Then
                        _text = _numberText(CInt(_aWord)) & _digit(_digitPosition)
                    End If
                Case 6 ' หลักล้าน
                    If _aWord = "0" Then
                        _text = "ล้าน"
                    ElseIf _aWord = "1" And _length - 1 > i Then
                        _text = "เอ็ดล้าน"
                    Else
                        _text = _numberText(CInt(_aWord)) & _digit(_digitPosition)
                    End If
            End Select
            _numberTranslatedText = _text & _numberTranslatedText
        Next

        Return _numberTranslatedText
    End Function

    Public Function ChangeToThaibathWord(ByVal pAmount As Double) As String
        If pAmount = 0 Then
            Return "ศูนย์บาทถ้วน"
        End If

        Dim _integerValue As String ' จำนวนเต็ม
        Dim _decimalValue As String ' ทศนิยม
        Dim _integerTranslatedText As String ' จำนวนเต็ม ภาษาไทย
        Dim _decimalTranslatedText As String ' ทศนิยมภาษาไทย

        _integerValue = Format(pAmount, "####.00") ' จัด Format ค่าเงินเป็นตัวเลข 2 หลัก
        _decimalValue = Mid(_integerValue, Len(_integerValue) - 1, 2) ' ทศนิยม
        _integerValue = Mid(_integerValue, 1, Len(_integerValue) - 3) ' จำนวนเต็ม

        ' แปลง จำนวนเต็ม เป็น ภาษาไทย
        _integerTranslatedText = NumberToText(CDbl(_integerValue))

        ' แปลง ทศนิยม เป็น ภาษาไทย
        If CDbl(_decimalValue) <> 0 Then
            _decimalTranslatedText = NumberToText(CDbl(_decimalValue))
        Else
            _decimalTranslatedText = ""
        End If

        ' ถ้าไม่มีทศนิม
        If _decimalTranslatedText.Trim = "" Then
            _integerTranslatedText += "บาทถ้วน"
        Else
            _integerTranslatedText += "บาท" & _decimalTranslatedText & "สตางค์"
        End If

        Return _integerTranslatedText

        'Dim digit() As String = {"เอ็ด", "สิบ", "ร้อย", "พัน", "หมื่น", "แสน", "ล้าน", "สิบล้าน", "ร้อยล้าน", "พันล้าน"}
        'Dim tmp() As String = mondyValue.Split(".".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
        'Dim intNumber = tmp(0).Replace(",", "")
        'Dim decNumber As String
        'If (tmp.Length > 1) Then
        '    decNumber = tmp(1)
        'Else
        '    decNumber = ""
        'End If

        'Dim result As String = ""
        'Dim testChar As String = ""
        'Dim splitChar As String = ""

        'Dim wordLength As Integer = intNumber.Length - 1
        'For intPosition As Integer = 0 To wordLength
        '    splitChar = intNumber.Substring(intPosition, 1)
        '    Select Case splitChar
        '        Case "0" : testChar = ""
        '        Case "1" : testChar = "หนึ่ง"
        '        Case "2" : testChar = "สอง"
        '        Case "3" : testChar = "สาม"
        '        Case "4" : testChar = "สี่"
        '        Case "5" : testChar = "ห้า"
        '        Case "6" : testChar = "หก"
        '        Case "7" : testChar = "เจ็ด"
        '        Case "8" : testChar = "แปด"
        '        Case "9" : testChar = "เก้า"
        '    End Select

        '    Select Case (wordLength - intPosition)
        '        Case 0
        '            If (splitChar = "1") Then
        '                If (wordLength = 0) Then
        '                    result = result & testChar
        '                Else
        '                    result = result & digit(wordLength - intPosition)
        '                End If
        '            Else
        '                result = result & testChar
        '            End If
        '        Case 1
        '            Select Case splitChar
        '                Case "0"
        '                Case "1"
        '                    result = result & digit(wordLength - intPosition)
        '                Case "2"
        '                    testChar = "ยี่"
        '                    result = result & testChar & digit(wordLength - intPosition)
        '                Case Else
        '                    result = result & testChar & digit(wordLength - intPosition)
        '            End Select
        '        Case Else
        '            Select Case splitChar
        '                Case "0"
        '                Case Else
        '                    result = result & testChar & digit(wordLength - intPosition)
        '            End Select
        '    End Select

        'Next
        'result = result & "บาท"

        'Dim stang As String = ""
        'If (decNumber.Length > 0) Then
        '    wordLength = decNumber.Length - 1
        '    For intPosition As Integer = 0 To wordLength
        '        splitChar = decNumber.Substring(intPosition, 1)
        '        Select Case splitChar
        '            Case "0" : testChar = ""
        '            Case "1" : testChar = "หนึ่ง"
        '            Case "2" : testChar = "สอง"
        '            Case "3" : testChar = "สาม"
        '            Case "4" : testChar = "สี่"
        '            Case "5" : testChar = "ห้า"
        '            Case "6" : testChar = "หก"
        '            Case "7" : testChar = "เจ็ด"
        '            Case "8" : testChar = "แปด"
        '            Case "9" : testChar = "เก้า"
        '        End Select

        '        Select Case (wordLength - intPosition)
        '            Case 0
        '                If (splitChar = "1") Then
        '                    If (wordLength = 0) Then
        '                        stang = stang & testChar
        '                    Else
        '                        stang = stang & digit(wordLength - intPosition)
        '                    End If
        '                Else
        '                    stang = stang & testChar
        '                End If
        '            Case 1
        '                Select Case splitChar
        '                    Case "0"
        '                    Case "1"
        '                        stang = stang & digit(wordLength - intPosition)
        '                    Case "2"
        '                        testChar = "ยี่"
        '                        stang = stang & testChar & digit(wordLength - intPosition)
        '                    Case Else
        '                        stang = stang & testChar & digit(wordLength - intPosition)
        '                End Select
        '            Case Else
        '                Select Case splitChar
        '                    Case "0"
        '                    Case Else
        '                        stang = stang & testChar & digit(wordLength - intPosition)
        '                End Select
        '        End Select

        '    Next
        'End If

        'If (stang.Trim().Length > 0) Then
        '    stang = stang & "สตางค์"
        'Else
        '    stang = "ถ้วน"
        'End If

        'result = result & stang

        'Return result
    End Function

    Public Function CheckIsSell(ByVal pOrderType As Long) As Boolean
        Try
            Select Case pOrderType
                Case MasterType.PurchaseOrder, MasterType.AddCreditBuy, MasterType.InformPriceBuy, MasterType.StockIn, MasterType.ShipingBuy, MasterType.InvoiceBuy, MasterType.MakePO
                    Return False
                Case Else
                    Return True
            End Select
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "modFunction.CheckIsSell : " & ex.Message)
            Return True
        End Try
    End Function

    Public Function ConvertListToString(ByVal pList As List(Of Long)) As String
        'Dim builder As StringBuilder = New StringBuilder()
        Try
            If IsNothing(pList) Then
                Return ""
            ElseIf pList.Count = 0 Then
                Return ""
            Else
                Return String.Join(",", pList)
                'For Each pID In pList
                '    If pID > 0 Then
                '        builder.Append(pID).Append(",")
                '    End If
                'Next
                'Return builder.ToString
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "modFunction.ConvertListToString : " & ex.Message)
            Return ""
        End Try
    End Function

    Public Function InitialProductForAdd(ByVal pProID As Long, ByVal pCusID As Long, ByVal pOrderType As MasterType) As ProductListDAO
        Dim lcls As New ProductDAO
        Dim lclsProSub As New ProductListDAO
        Try
            If lcls.InitailData(pProID, pCusID, "", "") Then
                lclsProSub = New ProductListDAO
                lclsProSub.IsSelect = True
                lclsProSub.ProductID = lcls.ID
                lclsProSub.ProductCode = lcls.Code
                lclsProSub.ProductName = lcls.NameThai
                lclsProSub.Price = lcls.PriceSale
                lclsProSub.PriceMain = lcls.PriceSale
                lclsProSub.Cost = lcls.Cost
                lclsProSub.Remark = ""
                lclsProSub.Units = 1

                'Set Location
                Dim lclsProLocat As New ProductLocationSDAO
                Dim lDataTable As New DataTable
                lDataTable = lclsProLocat.GetDataTableDTL(lclsProSub.ProductID, pOrderType.ToString)
                For Each lRow As DataRow In lDataTable.Rows
                    lclsProSub.LocationDTLID = lRow.Item("LocationDTLID")
                    Exit For
                Next

                'Set unitid
                Dim lclsUnit As New ProductUnitDAO
                lDataTable = New DataTable
                lDataTable = lclsUnit.GetDataTable(lclsProSub.ProductID, 2, 0, "")
                For Each lRow As DataRow In lDataTable.Rows
                    lclsProSub.UnitID = ConvertNullToZero(lRow("UnitID"))
                    lclsProSub.UnitName = ConvertNullToString(lRow("UnitName"))
                    Exit For
                Next

            End If
            Return lclsProSub
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "modFunction.InitialProductForAdd : " & ex.Message)
            Return Nothing
        End Try
    End Function

    Public Sub SetComboProductGroup(ByVal pProGroupIDList As String, ByRef pProduct As DevExpress.XtraEditors.CheckedListBoxControl)
        Dim SQL As String
        Dim dataTable As New DataTable()
        Dim pTable As String = ""

        pTable = GetMasterTableName(MasterType.ProductGroup)
        Try
            If pProGroupIDList = "" Then
                SQL = "SELECT MasterID AS ID,CodeThai, 0 as Flag"
            Else
                SQL = "SELECT MasterID AS ID,CodeThai,case when  MasterID in (" & pProGroupIDList & ") Then 1 else 0 end Flag"
            End If
            SQL &=  " FROM " & pTable
            SQL &=  " WHERE IsDelete= 0   "
            SQL &=  " AND IsInActive = 0"
            SQL &=  " ORDER BY CodeThai"

            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            pProduct.DataSource = dataTable
            pProduct.DisplayMember = "CodeThai"
            pProduct.ValueMember = "ID"

            For i As Integer = 0 To dataTable.DefaultView.Count - 1
                Dim row As DataRowView = dataTable.DefaultView(i)
                If row("Flag") = 1 Then
                    pProduct.SetItemChecked(i, True)
                Else
                    pProduct.SetItemChecked(i, False)
                End If
            Next i

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modFunction.SetComboProductGroup : " & e.Message)
        Finally
            dataTable = Nothing
        End Try

    End Sub

    Public Sub SetComboProductType(ByVal pProTypeIDList As String, ByRef pProductTypeID As DevExpress.XtraEditors.CheckedListBoxControl)
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            If pProTypeIDList = "" Then
                SQL = "SELECT ProductTypeID AS ID,NameThai, 0 as Flag"
            Else
                SQL = "SELECT ProductTypeID AS ID,NameThai,case when  ProductTypeID in (" & pProTypeIDList & ") Then 1 else 0 end Flag"
            End If
            SQL &=  " FROM ProductType"
            SQL &=  " WHERE IsDelete= 0   "
            SQL &=  " AND IsInActive = 0"
            SQL &=  " ORDER BY NameThai"

            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            pProductTypeID.DataSource = dataTable
            pProductTypeID.DisplayMember = "NameThai"
            pProductTypeID.ValueMember = "ID"

            For i As Integer = 0 To dataTable.DefaultView.Count - 1
                Dim row As DataRowView = dataTable.DefaultView(i)
                If row("Flag") = 1 Then
                    pProductTypeID.SetItemChecked(i, True)
                Else
                    pProductTypeID.SetItemChecked(i, False)
                End If
            Next i

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modFunction.SetComboProductType : " & e.Message)
        Finally
            dataTable = Nothing
        End Try

    End Sub

    Public Sub SetComboProductBrand(ByVal pProBrandIDList As String, ByRef pProductBrandID As DevExpress.XtraEditors.CheckedListBoxControl)
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            If pProBrandIDList = "" Then
                SQL = "SELECT ProductBrandID AS ID,NameThai, 0 as Flag"
            Else
                SQL = "SELECT ProductBrandID AS ID,NameThai,case when  ProductBrandID in (" & pProBrandIDList & ") Then 1 else 0 end Flag"
            End If
            SQL &=  " FROM ProductBrand"
            SQL &=  " WHERE IsDelete= 0   "
            SQL &=  " AND IsInActive = 0"
            SQL &=  " ORDER BY NameThai"

            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            pProductBrandID.DataSource = dataTable
            pProductBrandID.DisplayMember = "NameThai"
            pProductBrandID.ValueMember = "ID"

            For i As Integer = 0 To dataTable.DefaultView.Count - 1
                Dim row As DataRowView = dataTable.DefaultView(i)
                If row("Flag") = 1 Then
                    pProductBrandID.SetItemChecked(i, True)
                Else
                    pProductBrandID.SetItemChecked(i, False)
                End If
            Next i

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modFunction.SetComboProductBrand : " & e.Message)
        Finally
            dataTable = Nothing
        End Try

    End Sub


    Public Sub SetComboProductLocation(ByRef pProductLocation As DevExpress.XtraEditors.CheckedListBoxControl)
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try

            SQL = "SELECT b.LocationDTLID AS ID,b.NameThai, 0 as Flag"

            SQL &=  " FROM Product_LocationDTL b"
            SQL &=  " Inner join Product_Location a on a.LocationID=b.RefID"
            SQL &=  " WHERE a.IsDelete= 0   "
            SQL &=  " AND a.IsInActive = 0"
            SQL &=  " ORDER BY NameThai"

            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            pProductLocation.DataSource = dataTable
            pProductLocation.DisplayMember = "NameThai"
            pProductLocation.ValueMember = "ID"

            For i As Integer = 0 To dataTable.DefaultView.Count - 1
                Dim row As DataRowView = dataTable.DefaultView(i)
                If row("Flag") = 1 Then
                    pProductLocation.SetItemChecked(i, True)
                Else
                    pProductLocation.SetItemChecked(i, False)
                End If
            Next i

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modFunction.SetComboProductLocation : " & e.Message)
        Finally
            dataTable = Nothing
        End Try


    End Sub
    Public Function CheckIsUseStock(ByVal TableID As MasterType, ByVal RefToOrderID As List(Of Long) _
                                        , ByVal StockType As String, ByRef tr As SqlTransaction) As Integer
        Dim lclsOrder As OrderSDAO = Nothing
        CheckIsUseStock = 0
        Try
            'Condition for Up Stock
            If TableID = MasterType.SellOrders Then
                Return 1
            ElseIf (TableID = MasterType.Invoice) Or (TableID = MasterType.Shiping) Or (TableID = MasterType.Borrow) Or (TableID = MasterType.InvoiceOnline) Then
                Return 2
                If IsNothing(RefToOrderID) = False Then
                    If RefToOrderID.Count > 0 And (TableID = MasterType.Invoice Or TableID = MasterType.InvoiceOnline) Then
                        For Each pOrderID As Long In RefToOrderID
                            lclsOrder = New OrderSDAO
                            If lclsOrder.InitailData(pOrderID, , tr) Then
                                If lclsOrder.TableID = MasterType.Borrow Then
                                    Return 0
                                End If
                            End If
                        Next
                    End If
                End If
            ElseIf (TableID = MasterType.ReduceCredit) Or (TableID = MasterType.AddCredit) _
                    Or (TableID = MasterType.ReduceCreditBuy) Or (TableID = MasterType.AddCreditBuy) Or (TableID = MasterType.ClaimReturn) Then
                If StockType = "N" Or StockType = "" Then
                    Return 0
                Else
                    Return 3
                End If
            ElseIf (TableID = MasterType.StockIn) Then
                Return 4
            ElseIf (TableID = MasterType.UpdateStock) Then
                Return 5
            End If
            'Condition for Up Stock


        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modFunction.CheckIsUseStock" & e.Message)
        End Try

    End Function


    Public Function CheckIsWaitApproveStock() As Boolean
        Dim dataTable As New DataTable()
        Dim SQL As String = ""
        Try

            SQL = " select ProcessID,ProcessDate from  Product_Stock_Process"
            SQL &= "  where IsComfirm=0 "
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            Return dataTable.Rows.Count > 0

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modFunction.CheckIsWaitApproveStock" & e.Message)
        End Try

    End Function

#Region "Orders"

    Public Function GetOrderTypeFromID(ByVal pOrderID As Long, ByRef tr As SqlTransaction) As Long
        Dim SQL As String = "", lstrCode As String = ""
        Dim dataTable As New DataTable()
        Try
            GetOrderTypeFromID = 0
            SQL = "SELECT TableID  "
            SQL &=  " FROM  Orders  "
            SQL &=  " WHERE Orders.OrderID=" & pOrderID
            dataTable = gConnection.executeSelectQuery(SQL, tr)

            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    Return ConvertNullToZero(dr("TableID"))
                Next
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modFunction.GetOrderTypeFromID : " & e.Message)
        End Try

    End Function
#End Region

End Module
