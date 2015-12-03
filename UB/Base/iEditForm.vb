Option Explicit On

Imports DevExpress.XtraEditors

Partial Public Class iEditForm
    Private mIsChange As Boolean = False
    Shared mIsFromLoad As Boolean = True
    Private mCaption As String
    Private mMode As DataMode
    Private mIDs As Long
    Private mclsConvert As iOrder
    Private mOrderType As MasterType
    Private mProductList As List(Of ProductSubDAO)
    Private mRefOrderIDList As List(Of Long) = Nothing

#Region "Property"
    Dim mCustomerID As Long
    Dim mRefReserveIDList As List(Of Long)


    Public Property ModeData() As Integer
        Set(ByVal Value As Integer)
            mMode = Value
        End Set
        Get
            Return mMode
        End Get
    End Property

    Public WriteOnly Property IDs() As Long
        Set(ByVal Value As Long)
            mIDs = Value
        End Set
    End Property

    Public WriteOnly Property Caption() As String
        Set(ByVal Value As String)
            mCaption = Value
        End Set
    End Property

    Public WriteOnly Property SetMode() As Integer
        Set(ByVal value As Integer)
            mMode = value
        End Set
    End Property

    Public WriteOnly Property clsConvert() As iOrder
        Set(ByVal Value As iOrder)
            mclsConvert = Value
        End Set
    End Property

    Public WriteOnly Property OrderType() As Integer
        Set(ByVal Value As Integer)
            mOrderType = Value
        End Set
    End Property

    Public WriteOnly Property CusID() As Long
        Set(ByVal Value As Long)
            mCustomerID = Value
        End Set
    End Property

    Public Property ProductList() As List(Of ProductSubDAO)
        Get
            Return mProductList
        End Get
        Set(ByVal value As List(Of ProductSubDAO))
            mProductList = value
        End Set
    End Property
    Public Property RefOrderIDList() As List(Of Long)
        Get
            Return mRefOrderIDList
        End Get
        Set(ByVal value As List(Of Long))
            mRefOrderIDList = value
        End Set
    End Property
    Public Property RefReserveIDList() As List(Of Long)
        Get
            Return mRefReserveIDList
        End Get
        Set(ByVal value As List(Of Long))
            mRefReserveIDList = value
        End Set
    End Property

#End Region

#Region "call child"
    Protected Overridable Sub ClearAllForm(ByVal pMode As Integer)
        Try
            Select Case pMode
                Case DataMode.ModeNew, DataMode.ModeCopy, DataMode.ModeConvert
                    Me.Text = mCaption & " (เพิ่ม)"
                Case DataMode.ModeEdit
                    Me.Text = mCaption & " (แก้ไข)"
            End Select
            mIsChange = False
            DxErrorProvider1.ClearErrors()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "iEditForm.ClearAllForm : " & e.Message)
        End Try
    End Sub


    Protected Overridable Sub CheckFormChanged()
        If mIsFromLoad = False Then
            If mIsChange = False Then
                Me.Text = Me.Text & " *"
            End If
            mIsChange = True
        End If
    End Sub

    Protected Overridable Sub OnLoadForm(ByVal pMode As Integer, ByVal pID As Long, ByVal pOrderType As Long, ByVal pclsConvert As iOrder _
                                         , ByVal pCusID As Long)
    End Sub

    Protected Overridable Function Save(ByVal pMode As Integer, ByVal pID As Long) As Boolean
    End Function

    Protected Overridable Sub OnClosedForm()
    End Sub

     
    Protected Overridable Sub PrintOrder(ByVal pID As Long, ByVal pPrintType As Long) '1=Order, 2=Payment, 3=Cheque
    End Sub

    Protected Overridable Sub MakeOrder(ByVal pID As Long)
    End Sub

#End Region


    'Private Sub FormChangedComponent1_FormControlChanged(ByVal sender As Object, ByVal e As FormChangedEventArgs)
    '    CheckFormChanged()
    'End Sub

    Private Sub iEditForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        OnClosedForm()
    End Sub

    Private Sub iEditForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If mIsChange = True And SaveBar.Enabled = True Then
            If XtraMessageBox.Show(Me, "ต้องการยกเลิกข้อมูลใช่หรือไม่", "คำเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub iEditForm_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub iEditForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        mIsFromLoad = True
        Try
            ClearAllForm(mMode)
            OnLoadForm(mMode, mIDs, mOrderType, mclsConvert, mCustomerID)
        Catch ex As Exception

            ShowErrorMsg(False, ex.Message)
        Finally
            'ShowProgress(False, "")
        End Try
        mIsFromLoad = False
    End Sub

    Private Sub Addbar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles Addbar.ItemClick
        Try
            If XtraMessageBox.Show(Me, "ต้องการเคลียร์ข้อมูลทั้งหมดใช่หรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                ShowProgress(True, "Loading...")
                mIsFromLoad = True
                ModeData = DataMode.ModeNew
                ClearAllForm(mMode)
            End If
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            mIsFromLoad = False
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub SaveBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles SaveBar.ItemClick
        Try
            ShowProgress(True, "Saving...")
            'Me.Focus()
            If Save(mMode, mIDs) Then
                mIsFromLoad = True  'Not check change again
                mIsChange = False
                'If mOrderType <> MasterType.Receipt Then
                Me.Close()
                'End If

            End If
        Catch ex As Exception
            ShowProgress(False, "")
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub ExitBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ExitBar.ItemClick
        Me.Close()
    End Sub

    Private Sub MakeOrderBar_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles MakeOrderBar.ItemClick
        Me.MakeOrder(mIDs)
    End Sub

    
    Private Sub PrintBar2_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PrintBar2.ItemClick
        Try
            'ShowProgress(True, "Printing...")
            Me.PrintOrder(mIDs, 1)
        Catch ex As Exception
            'ShowProgress(False, "")
            ShowErrorMsg(False, ex.Message)
        Finally
            'ShowProgress(False, "")
        End Try

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        mProductList = Nothing
        mCustomerID = 0
    End Sub

    Private Sub PrintPaymantBar_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles PrintPaymantBar.ItemClick
        Try
            'ShowProgress(True, "Printing...")
            Me.PrintOrder(mIDs, 2)
        Catch ex As Exception
            'ShowProgress(False, "")
            ShowErrorMsg(False, ex.Message)
        Finally
            'ShowProgress(False, "")
        End Try

    End Sub

    Private Sub PrintChequeBar_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles PrintChequeBar.ItemClick
        Try
            'ShowProgress(True, "Printing...")
            Me.PrintOrder(mIDs, 3)
        Catch ex As Exception
            'ShowProgress(False, "")
            ShowErrorMsg(False, ex.Message)
        Finally
            'ShowProgress(False, "")
        End Try
    End Sub

   
End Class