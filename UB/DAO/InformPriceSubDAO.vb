Public Class InformPriceSubDAO
    Private mIsSelect As Boolean
    Private mProductID As Long
    Private mProductCode As String
    Private mProductName As String
    Private mProductRemark As String
    Private mPriceStandard As Decimal
    Private mPrice1 As Decimal
    Private mPrice2 As Decimal
    Private mPrice3 As Decimal
    Private mPriceInform As Decimal
    Private mUnit As Long
    Dim mCost As Decimal
    Dim mPrice4 As Decimal
    Dim mPrice5 As Decimal
    Dim mPrice6 As Decimal
    Dim mInformPriceID As Long
    Dim mDiscount As Decimal
    Dim mCostAdjust As Decimal

    Public Property IsSelect() As Boolean
        Get
            Return mIsSelect
        End Get
        Set(ByVal Value As Boolean)
            mIsSelect = Value
        End Set
    End Property
    Public Property ProductID() As Long
        Get
            Return mProductID
        End Get
        Set(ByVal Value As Long)
            mProductID = Value
        End Set
    End Property
    Public Property ProductCode() As String
        Get
            Return mProductCode
        End Get
        Set(ByVal value As String)
            mProductCode = value
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
    Public Property ProductRemark() As String
        Get
            Return mProductRemark
        End Get
        Set(ByVal value As String)
            mProductRemark = value
        End Set
    End Property
    Public Property PriceStandard() As Decimal
        Get
            Return mPriceStandard
        End Get
        Set(ByVal value As Decimal)
            mPriceStandard = value
        End Set
    End Property
    Public Property Price1() As Decimal
        Get
            Return mPrice1
        End Get
        Set(ByVal value As Decimal)
            mPrice1 = value
        End Set
    End Property
    Public Property Price2() As Decimal
        Get
            Return mPrice2
        End Get
        Set(ByVal value As Decimal)
            mPrice2 = value
        End Set
    End Property
    Public Property Price3() As Decimal
        Get
            Return mPrice3
        End Get
        Set(ByVal value As Decimal)
            mPrice3 = value
        End Set
    End Property
    Public Property Price4() As Decimal
        Get
            Return mPrice4
        End Get
        Set(ByVal value As Decimal)
            mPrice4 = value
        End Set
    End Property
    Public Property Price5() As Decimal
        Get
            Return mPrice5
        End Get
        Set(ByVal value As Decimal)
            mPrice5 = value
        End Set
    End Property
    Public Property Price6() As Decimal
        Get
            Return mPrice6
        End Get
        Set(ByVal value As Decimal)
            mPrice6 = value
        End Set
    End Property
    Public Property Cost() As Decimal
        Get
            Return mCost
        End Get
        Set(ByVal value As Decimal)
            mCost = value
        End Set
    End Property
    Public Property PriceInform() As Decimal
        Get
            Return mPriceInform
        End Get
        Set(ByVal value As Decimal)
            mPriceInform = value
        End Set
    End Property
    Public Property CostAdjust() As Decimal
        Get
            Return mCostAdjust
        End Get
        Set(ByVal value As Decimal)
            mCostAdjust = value
        End Set
    End Property
    Public Property Discount() As Decimal
        Get
            Return mDiscount
        End Get
        Set(ByVal value As Decimal)
            mDiscount = value
        End Set
    End Property
    Public Property Unit() As Long
        Get
            Return mUnit
        End Get
        Set(ByVal value As Long)
            mUnit = value
        End Set
    End Property

    Public Property InformPriceID() As Long
        Get
            Return mInformPriceID
        End Get
        Set(ByVal value As Long)
            mInformPriceID = value
        End Set
    End Property

    Public Sub New()
        mIsSelect = False
        PriceInform = 0
        mInformPriceID = 0
        mProductRemark = ""
        mDiscount = 0
        mCostAdjust = 0
    End Sub
End Class

