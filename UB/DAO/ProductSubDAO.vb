Public Class ProductSubDAO
    Private mIsSelect As Boolean
    Private mIDs As Long
    Private mSEQ As Long
    Private mUnitID As Long
    Private mRemark As String
    Private mUnitName As String
    Private mProductID As Long
    Private mProductCode As String
    Private mProductName As String
    Private mUnits As Long
    Private mCost As Decimal
    Private mPrice As Decimal
    Private mTotal As Decimal
    Private mLocationDTLID As Long
    Private mDiscount As Decimal
    Private mMode As Integer
    Private mKeepMin As Long
    Private mProductNameExt As String
    Private mUnits_Old As Long
    Private mLocationDTLID_Old As Long
    Private mProductListRefID As Long = 0
    Private mSNList As List(Of SnDAO)
    Private mSN As String
    Private mIsSN As Integer
    Private mIsShow As Integer = 1
    Private mIsMerge As Integer = 0
    Private mUnitMainID As Long = 0
    Private mAdjustUnit As Long = 0
    Private mRateUnit As Decimal = 1
    Private mIsDelete As Integer = 0
    Private mAdjustUnit_Old As Long = 0
    Private mPriceMain As Decimal = 0
    Private mRefOrderID As Long = 0

    Public Property RefOrderID() As Long
        Get
            Return mRefOrderID
        End Get
        Set(ByVal Value As Long)
            mRefOrderID = Value
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

    Public Property ProductNames() As String
        Get
            Return mProductName
        End Get
        Set(ByVal value As String)
            mProductName = value
        End Set
    End Property

    Public Property LocationDTLID() As Long
        Get
            Return mLocationDTLID
        End Get
        Set(ByVal value As Long)
            mLocationDTLID = value
        End Set
    End Property

    Public Property UnitName() As String
        Get
            Return mUnitName
        End Get
        Set(ByVal value As String)
            mUnitName = value
        End Set
    End Property



    '-----------------
    Public Property IsSelect() As Boolean
        Get
            Return mIsSelect
        End Get
        Set(ByVal Value As Boolean)
            mIsSelect = Value
        End Set

    End Property

    Public Property Discount() As Decimal
        Get
            Return mDiscount
        End Get
        Set(ByVal Value As Decimal)
            mDiscount = Value
        End Set

    End Property

   

    Public Property ProductNameExt() As String
        Get
            Return mProductNameExt
        End Get
        Set(ByVal value As String)
            mProductNameExt = value
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

    Public Property Remark() As String
        Get
            Return mRemark
        End Get
        Set(ByVal value As String)
            mRemark = value
        End Set
    End Property


    Public Property UnitID() As Long
        Get
            Return mUnitID
        End Get
        Set(ByVal Value As Long)
            mUnitID = Value
        End Set
    End Property

    Public Property SEQ() As Long
        Get
            Return mSEQ
        End Get
        Set(ByVal value As Long)
            mSEQ = value
        End Set
    End Property
 
    Public Property ID() As Long
        Get
            Return mIDs
        End Get
        Set(ByVal value As Long)
            mIDs = value
        End Set
    End Property

    Public Property KeepMin() As Long
        Get
            Return mKeepMin
        End Get
        Set(ByVal value As Long)
            mKeepMin = value
        End Set
    End Property

    Public Property Units() As Long
        Get
            Return mUnits
        End Get
        Set(ByVal value As Long)
            mUnits = value
        End Set
    End Property
    Public Property Units_Old() As Long
        Get
            Return mUnits_Old
        End Get
        Set(ByVal value As Long)
            mUnits_Old = value
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
    Public Property Price() As Decimal
        Get
            Return mPrice
        End Get
        Set(ByVal value As Decimal)
            mPrice = value
        End Set
    End Property
    Public Property PriceMain() As Decimal
        Get
            Return mPriceMain
        End Get
        Set(ByVal value As Decimal)
            mPriceMain = value
        End Set
    End Property
    Public Property Total() As Decimal
        Get
            Return mTotal
        End Get
        Set(ByVal value As Decimal)
            mTotal = value
        End Set
    End Property



    Public Property LocationDTLID_Old() As Long
        Get
            Return mLocationDTLID_Old
        End Get
        Set(ByVal value As Long)
            mLocationDTLID_Old = value
        End Set
    End Property

    Public Property ProductListRefID() As Long
        Get
            Return mProductListRefID
        End Get
        Set(ByVal Value As Long)
            mProductListRefID = Value
        End Set
    End Property
    
    Public Property ModePro() As Integer
        Get
            Return mMode
        End Get
        Set(ByVal value As Integer)
            mMode = value
        End Set
    End Property


    Public Property SNList() As List(Of SnDAO)
        Get
            Return mSNList
        End Get
        Set(ByVal Value As List(Of SnDAO))
            mSNList = Value
        End Set
    End Property

    Public Property SN() As String
        Get
            Return mSN
        End Get
        Set(ByVal value As String)
            mSN = value
        End Set
    End Property

    Public Property IsSN() As Integer
        Get
            Return mIsSN
        End Get
        Set(ByVal value As Integer)
            mIsSN = value
        End Set
    End Property

    Public Property IsShow() As Integer
        Get
            Return mIsShow
        End Get
        Set(ByVal value As Integer)
            mIsShow = value
        End Set
    End Property

    Public Property IsMerge() As Integer
        Get
            Return mIsMerge
        End Get
        Set(ByVal value As Integer)
            mIsMerge = value
        End Set
    End Property

    Public Property UnitMainID() As Long
        Get
            Return mUnitMainID
        End Get
        Set(ByVal value As Long)
            mUnitMainID = value
        End Set
    End Property
    Public Property AdjustUnit() As Long
        Get
            Return mAdjustUnit
        End Get
        Set(ByVal value As Long)
            mAdjustUnit = value
        End Set
    End Property
    Public Property AdjustUnit_Old() As Long
        Get
            Return mAdjustUnit_Old
        End Get
        Set(ByVal value As Long)
            mAdjustUnit_Old = value
        End Set
    End Property
    Public Property RateUnit() As Decimal
        Get
            Return mRateUnit
        End Get
        Set(ByVal value As Decimal)
            mRateUnit = value
        End Set
    End Property

    Public Property IsDelete() As Integer
        Get
            Return mIsDelete
        End Get
        Set(ByVal value As Integer)
            mIsDelete = value
        End Set
    End Property
End Class
