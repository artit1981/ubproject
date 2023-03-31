Option Explicit On
Imports System.Data.SqlClient

Public Class ShopeeImport
    'Implements iImport
    Private mClassName As String = "ShopeeImport"
    Private mPropertyS As List(Of ShopeeProperty)

    Public Property DataDAOs() As List(Of ShopeeProperty)
        Get
            Return mPropertyS
        End Get
        Set(ByVal Value As List(Of ShopeeProperty))
            mPropertyS = Value
        End Set
    End Property

    'Public Sub LoadFileToGrid(ByVal pDataTable As DataTable, ByRef pBindingSource As BindingSource)
    Public Function LoadFileToGrid(ByVal pDataTable As DataTable) As String
        Try
            Dim rec As ShopeeProperty
            Dim lError As String = "", lErrorList As String = "", lSEQ As Long = 1
            mPropertyS = New List(Of ShopeeProperty)

            If pDataTable.Rows.Count > 0 Then
                For Each dr As DataRow In pDataTable.Rows
                    If ConvertNullToString(dr(3)) <> "" Then '*** OrderDesc
                        rec = New ShopeeProperty
                        rec.IsSelect = True  '' 0
                        rec.OrderDate = dr(0)
                        rec.PayBy = ConvertNullToString(dr(1))
                        rec.OrderAmount = ConvertNullToZero(dr(2))
                        rec.OrderDesc = ConvertNullToString(dr(3)).Trim
                        'rec.OrderStatus = ConvertNullToString(dr(4))
                        rec.OrderUnit = ConvertNullToZero(dr(5))

                        Dim lPoCode = rec.OrderDesc.Substring(rec.OrderDesc.IndexOf("#"c) + 1)
                        rec.ExternalCode = lPoCode.Trim
                        If rec.ExternalCode.Trim <> "" Then
                            Dim lOrders = GetOrderFromPO(rec.ExternalCode)
                            rec.OrderID = lOrders(0)
                            rec.InternalCode = lOrders(1)
                            rec.GrandTotal = lOrders(2)
                            rec.OrderStatus = lOrders(3)
                        End If
                        rec.IsSelect = rec.OrderID > 0
                        rec.DiffAmount = rec.OrderAmount - rec.GrandTotal
                        lError = GetPropertyError(rec)
                        If lError <> "" Then
                            If lErrorList = "" Then
                                lErrorList = "******** Import Error *********"
                                lErrorList = lErrorList & vbNewLine & " Row : " & lSEQ & lError
                            Else
                                lErrorList = lErrorList & vbNewLine & " Row : " & lSEQ & lError
                            End If
                            rec.IsSelect = False
                        End If

                        mPropertyS.Add(rec)
                        lSEQ = lSEQ + 1
                    End If
                Next
            End If
            Return lErrorList
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mClassName & ".LoadFileToGrid : " & e.Message)
        End Try
    End Function

    'Public Function CheckIsError(ByVal pGrid As DevExpress.XtraGrid.Views.Grid.GridView) As Boolean
    '    Dim info As New ErrorInfo()
    '    Dim lIsError = False
    '    Try
    '        If pGrid.RowCount > 0 Then
    '            For lRow = 0 To pGrid.RowCount - 1
    '                TryCast(pGrid.GetRow(lRow), ProductProperty).GetError(info)
    '                If info.ErrorText <> "" Then
    '                    lIsError = True
    '                End If
    '            Next
    '        End If
    '        Return lIsError
    '    Catch e As Exception
    '        Err.Raise(Err.Number, e.Source, mClassName & ".CheckIsError : " & e.Message)
    '    Finally
    '    End Try
    'End Function

    'Public Function GetDAOFromGrid(ByVal pGrid As DevExpress.XtraGrid.Views.Grid.GridView)
    '    Dim lRow As Long
    '    Dim rec As ProductProperty

    '    GetDAOFromGrid = False
    '    Try
    '        mProductPropertyS = Nothing
    '        mProductPropertyS = New List(Of ProductProperty)
    '        pProgressBar.Position = 0
    '        If pGrid.RowCount > 0 Then
    '            pProgressBar.Properties.Maximum = pGrid.RowCount
    '            For lRow = 0 To pGrid.RowCount
    '                rec = Nothing
    '                rec = TryCast(pGrid.GetRow(lRow), ProductProperty)
    '                If Not rec Is Nothing AndAlso rec.IsSelect = True Then
    '                    mProductPropertyS.Add(rec)
    '                End If
    '                pProgressBar.Position = lRow
    '                'End If
    '            Next
    '        End If
    '    Catch e As Exception
    '        Err.Raise(Err.Number, e.Source, "frmImport.GetDAOFromGrid : " & e.Message)
    '    Finally
    '        rec = Nothing
    '    End Try
    'End Function

    Public Function ImportData() As Long()
        'Dim lList As New List(Of SubOrder)
        Dim bindingSource1 = New BindingSource
        bindingSource1.DataSource = GetType(SubOrder)
        Try
            If mPropertyS.Count > 0 Then
                For Each pRow In mPropertyS
                    If pRow.IsSelect = True Then


                        Dim lcls As New OrderSDAO

                        If lcls.InitailData(pRow.OrderID, "", Nothing) Then
                            If lcls.ID > 0 Then
                                Dim rec As New SubOrder
                                rec.IsSelect = True
                                rec.ID = 0
                                rec.BillID = 0
                                rec.BillType = ""
                                rec.OrderID = lcls.ID
                                rec.OrderCode = lcls.Code
                                rec.OrderDate = lcls.OrderDate
                                rec.CusName = lcls.CustomerDAO.FirstName
                                rec.EmpName = lcls.EmployeeDAO(Nothing).Title & lcls.EmployeeDAO(Nothing).FirstName & " " & lcls.EmployeeDAO(Nothing).LastName
                                rec.Remark = ""
                                rec.TableID = lcls.TableID
                                Select Case lcls.TableID
                                    Case MasterType.ReduceCredit, MasterType.ReduceCreditBuy
                                        rec.GrandTotal = lcls.GrandTotal * -1
                                        rec.BillTotal = lcls.GrandTotal * -1
                                    Case Else
                                        rec.BillTotal = lcls.GrandTotal
                                        rec.GrandTotal = lcls.GrandTotal
                                End Select
                                bindingSource1.Add(rec)
                            End If
                        End If
                    End If



                Next

                If bindingSource1.Count > 0 Then
                    Dim lFormEdit As New frmBill
                    With lFormEdit
                        .OrderType = MasterType.ReceiptCut
                        .Caption = "ตัดรับชำระ"
                        .MdiParent = frmMain
                        .ModeData = DataMode.ModeNew
                        .IDs = 0
                        .SubOrderList = bindingSource1
                        .Show()
                    End With
                End If
            End If

        Catch e As Exception

            Err.Raise(Err.Number, e.Source, mClassName & ".ImportData : " & e.Message)
        Finally

        End Try
    End Function




    Public Function GetPropertyError(ByVal pData As ShopeeProperty) As String
        Dim lError As String = ""
        'If String.IsNullOrEmpty(pData.IsNew) Then
        '    pData.IsNew = "Y" 'Default Y
        'ElseIf pData.IsNew.ToString.Trim <> "Y" And pData.IsNew.ToString.Trim <> "N" Then
        '    lError = lError & vbNewLine & "ข้อมูล IsNew ไม่ถูกต้อง[Y,N]"
        'End If



        Return lError
    End Function

    Public Sub New()
        'mRunningFormatDAO = New RunningFormatDAO
        'mRunningFormatDAO.InitailData(MasterType.Product, Nothing)
    End Sub
End Class



Public Class ShopeeProperty
    'Implements IDXDataErrorInfo
    Private mClassName As String = "ShopeeProperty"

#Region "Property"
    Private mOrderDate As Date
    Private mPayBy As String
    Private mOrderAmount As Decimal
    Private mOrderDesc As String
    Private mOrderUnit As Decimal
    Private mExternalCode As String
    Private mInternalCode As String

    Dim mIsSelect As Boolean


    Public Property IsSelect() As Boolean
        Get
            Return mIsSelect
        End Get
        Set(ByVal value As Boolean)
            mIsSelect = value
        End Set
    End Property

    Public Property OrderDate() As Date
        Get
            Return mOrderDate
        End Get
        Set(ByVal value As Date)
            mOrderDate = value
        End Set
    End Property

    Public Property PayBy() As String
        Get
            Return mPayBy
        End Get
        Set(ByVal value As String)
            mPayBy = value
        End Set
    End Property

    Public Property OrderAmount() As Decimal
        Get
            Return mOrderAmount
        End Get
        Set(ByVal value As Decimal)
            mOrderAmount = value
        End Set
    End Property

    Public Property OrderDesc() As String
        Get
            Return mOrderDesc
        End Get
        Set(ByVal value As String)
            mOrderDesc = value
        End Set
    End Property


    Public Property OrderUnit() As Decimal
        Get
            Return mOrderUnit
        End Get
        Set(ByVal value As Decimal)
            mOrderUnit = value
        End Set

    End Property

    Public Property ExternalCode() As String
        Get
            Return mExternalCode
        End Get
        Set(ByVal value As String)
            mExternalCode = value
        End Set
    End Property

    Public Property InternalCode() As String
        Get
            Return mInternalCode
        End Get
        Set(ByVal value As String)
            mInternalCode = value
        End Set
    End Property

    Dim mOrderStatus As String = ""
    Public Property OrderStatus() As String
        Get
            Return mOrderStatus
        End Get
        Set(ByVal value As String)
            mOrderStatus = value
        End Set
    End Property
    ''Hide
    Dim mOrderID As Long = 0
    Public Property OrderID() As Long
        Get
            Return mOrderID
        End Get
        Set(ByVal value As Long)
            mOrderID = value
        End Set
    End Property
    Dim mGrandTotal As Decimal = 0
    Public Property GrandTotal() As Long
        Get
            Return mGrandTotal
        End Get
        Set(ByVal value As Long)
            mGrandTotal = value
        End Set
    End Property

    Dim mDiffAmount As Decimal = 0
    Public Property DiffAmount() As Decimal
        Get
            Return mDiffAmount
        End Get
        Set(ByVal value As Decimal)
            mDiffAmount = value
        End Set
    End Property



#End Region




    Public Sub New()

    End Sub
End Class

