Option Explicit On

Public Class ucCheque

    Private mIsToApprove As Boolean
    Private mChequeList As List(Of ChequeDAO)
    'Private bindingSource1 As BindingSource

    Public Function ShowControl(ByVal pIsToApprove As Boolean, ByVal pRefOrderID As Long, Optional ByVal pBankID As Long = 0 _
                                , Optional ByVal pDateFrom As Date = Nothing, Optional ByVal pDateTo As Date = Nothing, Optional ByVal pIsNewOnly As Boolean = False) As Boolean
        Try
            mIsToApprove = pIsToApprove

            Call LoadData(pRefOrderID, pBankID, pDateFrom, pDateTo, pIsNewOnly)

            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucCheque.ShowControl : " & e.Message)
            Return False
        End Try
    End Function

    Public Sub ClearControl()
        Try
            'If Not bindingSource1 Is Nothing Then
            '    bindingSource1.Clear()
            '    bindingSource1.DataSource = GetType(ChequeDAO)
            '    gridControl.DataSource = bindingSource1
            'End If
            If Not mChequeList Is Nothing Then
                mChequeList.Clear()
                gridControl.DataSource = mChequeList
            End If
          
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucPledge.ClearAll : " & e.Message)
        End Try
    End Sub

    Public Function GetDAOs() As List(Of ChequeDAO)

        'Dim lRow As Long
        Try
            Return mChequeList
            'mChequeList = New List(Of ChequeDAO)

            'If Not bindingSource1 Is Nothing > 0 Then
            '    lRow = 0
            '    For Each pProSub As ChequeDAO In bindingSource1
            '        If pProSub.ChequeNo.Trim <> "" Then
            '            mChequeList.Add(pProSub)
            '        End If
            '    Next
            'End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucCheque.GetDAOs : " & e.Message)
        Finally

        End Try
        Return mChequeList
    End Function

    Private Sub LoadData(ByVal pRefOrderID As Long, Optional ByVal pBankID As Long = 0 _
                                , Optional ByVal pDateFrom As Date = Nothing, Optional ByVal pDateTo As Date = Nothing, Optional ByVal pIsNewOnly As Boolean = False)
        Dim lcls As New ChequeDAO
        Dim dataTable As New DataTable()
        Try
            'bindingSource1 = New BindingSource
            'bindingSource1.DataSource = GetType(ChequeDAO)
            mChequeList = New List(Of ChequeDAO)

            dataTable = lcls.GetDataTable(pRefOrderID, pBankID, pDateFrom, pDateTo, pIsNewOnly)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    Dim rec As New ChequeDAO
                    rec.ID = dr("ID")
                    rec.BankAccountID = dr("BankAccountID")
                    rec.BankBranch = dr("BankBranch").ToString.Trim
                    rec.BankDocType = dr("BankDocType").ToString.Trim
                    rec.BankID = dr("BankID")
                    rec.CashType = dr("CashType").ToString.Trim
                    rec.ChequeBalance = dr("ChequeBalance")
                    rec.ChequeDate = dr("ChequeDate")
                    rec.ChequeDateDue = dr("ChequeDateDue")
                    rec.ChequeDatePass = dr("ChequeDatePass")
                    rec.ChequeDateReceive = dr("ChequeDateReceive")
                    rec.ChequeDateStop = dr("ChequeDateStop")
                    rec.ChequeNo = dr("ChequeNo").ToString.Trim
                    rec.ChequeOwnerEN = dr("ChequeOwnerEN").ToString.Trim
                    rec.ChequeOwnerTH = dr("ChequeOwnerTH").ToString.Trim
                    rec.ChequePay = dr("ChequePay")
                    rec.ChequeStatus = dr("ChequeStatus").ToString.Trim
                    rec.ChequeStep = dr("ChequeStep").ToString.Trim
                    rec.ChequeType = dr("ChequeType")
                    rec.Remark = dr("Remark").ToString.Trim
                    'bindingSource1.Add(rec)
                    mChequeList.Add(rec)
                Next
            End If
            'gridControl.DataSource = bindingSource1
            gridControl.DataSource = mChequeList
            SetLookUpChequeStatus()
            GridStyle()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucCheque.LoadData : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub


    Private Sub GridStyle()
        With gridView
            .Columns("ChequeStatus").Visible = mIsToApprove
        End With
    End Sub

    Private Sub SetLookUpChequeStatus()
        Dim lcls As ChequeStatus
        Dim lList As New List(Of ChequeStatus)
        Try
            lcls = New ChequeStatus
            lcls.ChequeStatusCode = "N"
            lcls.ChequeStatusName = "เพิ่งได้รับ"
            lList.Add(lcls)

            lcls = New ChequeStatus
            lcls.ChequeStatusCode = "P"
            lcls.ChequeStatusName = "ผ่านแล้ว"
            lList.Add(lcls)

            lcls = New ChequeStatus
            lcls.ChequeStatusCode = "R"
            lcls.ChequeStatusName = "เช็คคืน"
            lList.Add(lcls)

            ChequeStatusCombo.DataSource = lList

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucCheque.SetLookUpChequeStatus : " & e.Message)
        Finally
            lcls = Nothing
        End Try

    End Sub

    Private Sub gridView_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles gridView.KeyPress
        'Dim rec As ChequeDAO
        'Dim lfrm As New frmCheque
        'If e.KeyChar = ChrW(Keys.Enter) Then
        '    rec = TryCast(gridView.GetFocusedRow, ChequeDAO)
        '    lfrm.clsChequeDAO = rec
        '    lfrm.ShowDialog()
        'End If

    End Sub

    Private Sub gridView_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles gridView.ValidatingEditor
        If gridView.FocusedColumn.FieldName = "BankDocType" Then
            If e.Value <> "" Then
                ShowFromCheque(e.Value)
            End If
        End If
    End Sub

    Private Sub ShowFromCheque(ByVal pBankDocType As String)
        Dim lclsChequeDAO As New ChequeDAO
        Dim lTotal As Decimal = 0
        Dim lclsCus As CustomerDAO
        Dim lIsEditRow As Boolean = False

        If mIsToApprove = False Then
            Dim rec1 As ChequeDAO
            Dim lfrm As New frmCheque
            rec1 = TryCast(gridView.GetFocusedRow, ChequeDAO)
            If IsNothing(rec1) Then
                rec1 = New ChequeDAO
                lclsCus = New CustomerDAO
                lclsCus.InitailData(gCustomerID)

                If lclsCus.FirstName <> "" Then
                    rec1.ChequeOwnerTH = lclsCus.Title & lclsCus.FirstName & "  " & lclsCus.LastName
                Else
                    rec1.ChequeOwnerTH = lclsCus.CompanyName
                End If

                If lclsCus.FirstNameEng <> "" Then
                    rec1.ChequeOwnerEN = lclsCus.TitleEng & lclsCus.FirstNameEng & "  " & lclsCus.LastNameEng
                Else
                    rec1.ChequeOwnerTH = lclsCus.CompanyName
                End If

                lfrm.clsChequeDAO = rec1
                lfrm.IDs = 0
                lfrm.ModeData = DataMode.ModeNew
                lIsEditRow = False

            Else
                lIsEditRow = True
                lfrm.clsChequeDAO = rec1
                lfrm.IDs = rec1.ID
            End If

            If pBankDocType <> "" Then lfrm.clsChequeDAO.BankDocType = pBankDocType

            For Each pclsCheque In mChequeList
                lTotal = lTotal + pclsCheque.ChequePay
            Next

            'Cal each amount
            lfrm.ChequeTotal = gGrandAmount - lTotal

            lfrm.ShowDialog()
            lclsChequeDAO = lfrm.clsChequeDAO
            If lclsChequeDAO.BankDocType <> "" Then 'And lclsChequeDAO.ChequeNo <> "" Then
                If lIsEditRow = False Then
                    'bindingSource1.Add(rec)
                    mChequeList.Add(lclsChequeDAO)
                End If
                gridControl.DataSource = mChequeList

                gridControl.RefreshDataSource()

                'gridView.FocusedColumn = gridView.Columns("ChequeNo")
            End If
        End If

    End Sub

    Private Sub btnBankDocType_ButtonPressed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnBankDocType.ButtonPressed
        ShowFromCheque("")
    End Sub
End Class
