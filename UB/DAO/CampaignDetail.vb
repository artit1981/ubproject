Public Class CampaignDetail

    Dim mOrderID As Long = 0
    Dim mOrderCode As String = ""
    Dim mProductName As String = ""
    Dim mCustomerName As String = ""
    Dim mTotalAmount As Decimal = 0
    Dim mTotalGain As Decimal = 0

    Public Property OrderID() As Long
        Get
            Return mOrderID
        End Get
        Set(ByVal value As Long)
            mOrderID = value
        End Set
    End Property

    Public Property OrderCode() As String
        Get
            Return mOrderCode
        End Get
        Set(ByVal value As String)
            mOrderCode = value
        End Set
    End Property

    Public Property CustomerName() As String
        Get
            Return mCustomerName
        End Get
        Set(ByVal value As String)
            mCustomerName = value
        End Set
    End Property

    Public Property ProductName() As String
        Get
            Return mProductName
        End Get
        Set(ByVal value As String)
            mProductName = value
        End Set
    End Property

    Public Property TotalAmount() As Decimal
        Get
            Return mTotalAmount
        End Get
        Set(ByVal value As Decimal)
            mTotalAmount = value
        End Set
    End Property


    Public Property TotalGain() As Decimal
        Get
            Return mTotalGain
        End Get
        Set(ByVal value As Decimal)
            mTotalGain = value
        End Set
    End Property

End Class
