Option Explicit On
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.DXErrorProvider

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
                        rec.TXDate = dr(0)
                        rec.TxNo = ConvertNullToString(dr(1))
                        rec.TxAmount = ConvertNullToZero(dr(2))
                        rec.TxDesc = ConvertNullToString(dr(3)).Trim
                        'rec.OrderStatus = ConvertNullToString(dr(4))
                        'rec.OrderUnit = ConvertNullToZero(dr(5))

                        Dim lPoCode = rec.TxDesc.Substring(rec.TxDesc.IndexOf("#"c) + 1)
                        rec.ExternalCode = lPoCode.Trim
                        If rec.ExternalCode.Trim <> "" Then
                            Dim lOrders = GetOrderFromPO(rec.ExternalCode)
                            rec.OrderID = lOrders(0)
                            rec.InternalCode = lOrders(1)
                            rec.GrandTotal = lOrders(2)
                            rec.OrderStatus = lOrders(3)
                        End If
                        rec.IsSelect = rec.OrderID > 0
                        rec.DiffAmount = rec.TxAmount - rec.GrandTotal

                        If rec.DiffAmount <> 0 And rec.GrandTotal > 0 Then
                            rec.DiffPercen = (rec.DiffAmount / rec.GrandTotal) * 100
                        Else
                            rec.DiffPercen = 0
                        End If
                        'lError = GetPropertyError(rec)
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


    Public Function ImportData() As BindingSource

        Dim bindingSource1 = New BindingSource
        bindingSource1.DataSource = GetType(SubOrder)

        Try
            If mPropertyS.Count > 0 Then
                Dim query = mPropertyS.FindAll(Function(p) p.IsSelect = True)

                For Each pRow In query
                    If pRow.IsSelect = True And pRow.OrderID > 0 Then
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
                    Else
                        pRow.IsSelect = False
                    End If

                Next

            End If
            Return bindingSource1
        Catch e As Exception

            Err.Raise(Err.Number, e.Source, mClassName & ".ImportData : " & e.Message)
        Finally

        End Try
    End Function




    'Public Function GetPropertyError(ByVal pData As ShopeeProperty) As String
    '    Dim lError As String = ""
    '    If pData.InternalCode.ToString.Trim = "" Then
    '        lError = lError & vbNewLine & "ไม่พบข้อมูลอ้างอิงจากคำสั่งซื้อ " & pData.ExternalCode
    '    End If



    '    Return lError
    'End Function

    Public Sub New()
        'mRunningFormatDAO = New RunningFormatDAO
        'mRunningFormatDAO.InitailData(MasterType.Product, Nothing)
    End Sub
End Class



Public Class ShopeeProperty
    Implements IDXDataErrorInfo
    Private mClassName As String = "ShopeeProperty"

#Region "Property"


    Private mInternalCode As String

    Dim mIsSelect As Boolean

    Public Sub GetPropertyError(ByVal propertyName As String, ByVal info As ErrorInfo) Implements IDXDataErrorInfo.GetPropertyError
        If propertyName = "InternalCode" AndAlso String.IsNullOrEmpty(InternalCode) Then
            info.ErrorText = String.Format("ไม่พบข้อมูลอ้างอิงจากคำสั่งซื้อ " & ExternalCode, propertyName)
            info.ErrorType = ErrorType.Critical
        End If

    End Sub

    Public Sub GetError(ByVal info As ErrorInfo) Implements IDXDataErrorInfo.GetError
        Dim propertyInfo As New ErrorInfo()

        GetPropertyError("InternalCode", propertyInfo)


    End Sub

    Public Property IsSelect() As Boolean
        Get
            Return mIsSelect
        End Get
        Set(ByVal value As Boolean)
            mIsSelect = value
        End Set
    End Property

    Private mTXDate As Date
    Public Property TXDate() As Date
        Get
            Return mTXDate
        End Get
        Set(ByVal value As Date)
            mTXDate = value
        End Set
    End Property

    Private mTxNo As String
    Public Property TxNo() As String
        Get
            Return mTxNo
        End Get
        Set(ByVal value As String)
            mTxNo = value
        End Set
    End Property

    Private mExternalCode As String
    Public Property ExternalCode() As String
        Get
            Return mExternalCode
        End Get
        Set(ByVal value As String)
            mExternalCode = value
        End Set
    End Property
    Private mTxDesc As String
    Public Property TxDesc() As String
        Get
            Return mTxDesc
        End Get
        Set(ByVal value As String)
            mTxDesc = value
        End Set
    End Property

    Private mTxAmount As Decimal
    Public Property TxAmount() As Decimal
        Get
            Return mTxAmount
        End Get
        Set(ByVal value As Decimal)
            mTxAmount = value
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

    Dim mDiffPercen As Decimal = 0
    Public Property DiffPercen() As Decimal
        Get
            Return mDiffPercen
        End Get
        Set(ByVal value As Decimal)
            mDiffPercen = value
        End Set
    End Property


#End Region




    Public Sub New()

    End Sub
End Class

