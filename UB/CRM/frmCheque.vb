Option Explicit On
Imports DevExpress.XtraEditors
Public Class frmCheque
    Inherits iEditForm
    Private Const mFormName As String = "frmCheque"
    Private mcls As ChequeDAO
    Private mIDs As Long
    Private mIsFromLoad As Boolean
    Dim mChequeTotal As Decimal
    Dim mChequeOwnerTH As String
    Dim mChequeOwnerEN As String

    Public Property clsChequeDAO() As ChequeDAO
        Get
            Return mcls
        End Get
        Set(ByVal value As ChequeDAO)
            mcls = value
        End Set
    End Property

    Public WriteOnly Property ChequeTotal() As Decimal
        Set(ByVal value As Decimal)
            mChequeTotal = value
        End Set
    End Property



#Region "Overrides"
    Protected Overrides Sub OnLoadForm(ByVal pMode As Integer, ByVal pID As Long, ByVal pOrderType As Long, ByVal pclsConvert As iOrder, ByVal pCusID As Long)
        Try
            mIsFromLoad = True
            InitialCombo()
            Call LoadData(pMode, pID)
            PrintBar2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            PrintChequeBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            If mIDs > 0 Then

            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".OnLoadForm : " & e.Message)
        Finally
            mIsFromLoad = False
        End Try
    End Sub

    Protected Overrides Sub ClearAllForm(ByVal pMode As Integer)
        Try
            MyBase.ClearAllForm(pMode)
            Select Case pMode
                Case DataMode.ModeNew
                    'ClearForm(GroupControl1)

            End Select

            'txtCode.Select()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".ClearAllForm : " & e.Message)
        End Try
    End Sub

    Protected Overrides Function Save(ByVal pMode As Integer, ByVal pID As Long) As Boolean

        Try
            If Verify() = True Then
                mcls.BankAccountID = BankAccountID.EditValue
                mcls.BankBranch = BankBranch.EditValue
                mcls.BankDocType = BankDocTypeID.Text
                mcls.BankID = BankID.EditValue
                mcls.CashType = CashType.EditValue
                mcls.ChequeBalance = ChequeBalance.EditValue
                mcls.ChequeDate = ChequeDate.EditValue
                mcls.ChequeDateDue = ChequeDateDue.EditValue
                mcls.ChequeDatePass = ChequeDatePass.EditValue
                mcls.ChequeDateReceive = ChequeDateReceive.EditValue
                mcls.ChequeDateStop = ChequeDateStop.EditValue
                mcls.ChequeNo = ChequeNo.EditValue
                mcls.ChequeOwnerEN = ChequeOwnerEN.EditValue
                mcls.ChequeOwnerTH = ChequeOwnerTH.EditValue
                mcls.ChequePay = ChequePay.EditValue
                mcls.ChequeStatus = ChequeStatus.EditValue
                mcls.ChequeStep = ChequeStep.EditValue
                If ChequeType1.Checked = True Then
                    mcls.ChequeType = 1
                Else
                    mcls.ChequeType = 2
                End If
                mcls.ID = mIDs
                mcls.Remark = Remark.EditValue
                mcls.ModeData = pMode

                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".Save : " & ex.Message)
            Return False
        End Try
    End Function

    Protected Overrides Sub PrintOrder(ByVal pID As Long, ByVal pPrintType As Long) '1=Order, 2=Payment, 3=Cheque)
        If pPrintType = 3 Then
            If mIDs > 0 Then
                modReport.PrintCheque(mIDs, Nothing)
            Else
                Save(0, 0)
                modReport.PrintCheque(mIDs, mcls)
            End If

        End If

    End Sub

    Private Function Verify() As Boolean
        Dim lTotal As Decimal = 0
        Dim lstrErr As String = ""
        Try
            DxErrorProvider1.ClearErrors()
            If Trim(BankDocTypeID.Text) = "" Then
                SetErrorProvider(DxErrorProvider1, BankDocTypeID, "กรุณาระบุประเภทเอกสาร")
                lstrErr = lstrErr & DxErrorProvider1.GetError(BankDocTypeID) & vbNewLine
            End If
            If Trim(CashType.Text) = "" Then
                SetErrorProvider(DxErrorProvider1, CashType, "กรุณาระบุประเภทรายการ")
                lstrErr = lstrErr & DxErrorProvider1.GetError(CashType) & vbNewLine
            End If
            'If Trim(ChequeNo.Text) = "" Then
            '    SetErrorProvider(DxErrorProvider1, ChequeNo, "กรุณาระบุเลขที่เช็ค/เอกสาร/บัตร")
            '    lstrErr = lstrErr & DxErrorProvider1.GetError(ChequeNo) & vbNewLine
            'End If

            'If ConvertNullToZero(ChequePay.EditValue) > ConvertNullToZero(ChequeBalance.EditValue) Then
            '    SetErrorProvider(DxErrorProvider1, ChequePay, "ยอดชำระเกินมูลค่า")
            '    lstrErr = lstrErr & DxErrorProvider1.GetError(ChequePay) & vbNewLine
            'End If


            If lstrErr.Trim <> "" Then
                ShowProgress(False, "")
                lstrErr = "พบข้อผิดพลาดกรุณาตรวจสอบ : " & vbNewLine & lstrErr
                XtraMessageBox.Show(Me, lstrErr, "ตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Else
                Return True
            End If

            'If DxErrorProvider1.HasErrors = False Then
            '    If UcOrderList1.IsError = True Then
            '        Return False
            '    End If
            'End If
            Return DxErrorProvider1.HasErrors = False
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".Verify : " & e.Message)
        End Try
    End Function

    Protected Overrides Sub OnClosedForm()
        'mcls = Nothing

    End Sub
#End Region

#Region "Private"
    Private Function LoadData(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        Try
            mIDs = mcls.ID
            BankDocTypeID.Text = mcls.BankDocType
            CashType.EditValue = mcls.CashType
            ChequeNo.EditValue = mcls.ChequeNo
            ChequeDate.EditValue = mcls.ChequeDate
            ChequeDateReceive.EditValue = mcls.ChequeDateReceive
            ChequeDateDue.EditValue = mcls.ChequeDateDue
            ChequeOwnerTH.EditValue = mcls.ChequeOwnerTH
            ChequeOwnerEN.EditValue = mcls.ChequeOwnerEN
            BankID.EditValue = mcls.BankID
            BankBranch.EditValue = mcls.BankBranch
            If pMode = DataMode.ModeNew Then
                ChequeBalance.EditValue = mChequeTotal
            Else
                ChequeBalance.EditValue = mcls.ChequeBalance
            End If

            If mcls.ChequeType = 1 Then
                ChequeType1.Checked = True
                ChequeType2.Checked = False
            Else
                ChequeType1.Checked = False
                ChequeType2.Checked = True
            End If
            ChequePay.EditValue = mcls.ChequePay
            ChequeStep.EditValue = mcls.ChequeStep
            ChequeStatus.EditValue = mcls.ChequeStatus
            ChequeDatePass.EditValue = mcls.ChequeDatePass
            ChequeDateStop.EditValue = mcls.ChequeDateStop
            BankAccountID.EditValue = mcls.BankAccountID
            Remark.EditValue = mcls.Remark
            If mIDs = 0 Then
                ChequeStatus.EditValue = "N"
                ChequeStep.EditValue = "W"
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".LoadData : " & ex.Message)
            Return False
        End Try
    End Function

    Private Sub InitialCombo()
        Try
            SetComboBank()
            SetComboBankAccount()
            SetComboBankDocType()
            SetComboChequeStatus()
            SetComboChequeStep()
            SetComboCashType()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".InitialCombo : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboBank()
        Try
            SetSearchLookBank(BankID)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboBank : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboBankAccount()
        Try
            SetSearchLookBankAccount(BankAccountID, 0, ConvertNullToZero(BankID.EditValue))
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboBankAccount : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboBankDocType()
        Try
            SetLookUpBankDocType(BankDocTypeID)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboBankDocType : " & e.Message)
        End Try
    End Sub
    Private Sub SetComboCashType()
        Try
            SetLookUpCashType(CashType)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboCashType : " & e.Message)
        End Try
    End Sub
    Private Sub SetComboChequeStatus()
        Try
            SetLookUpChequeStatus(ChequeStatus)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboChequeStatus : " & e.Message)
        End Try
    End Sub
    Private Sub SetComboChequeStep()
        Try
            SetLookUpChequeStep(ChequeStep)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboChequeStep : " & e.Message)
        End Try
    End Sub
#End Region




    Private Sub BankDocTypeID_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BankDocTypeID.EditValueChanged
        If mIsFromLoad = False Then
            CashType.EditValue = BankDocTypeID.GetColumnValue("CashTypeCode")
        End If
    End Sub


End Class