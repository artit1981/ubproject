Option Explicit On
Imports System.Data.SqlClient

Public Class iOrder

#Region "Property"
    Private mMode As DataMode
    Private mIDs As Long = 0
    Private mTableID As MasterType
    Private mCode As String
    Private mOrderDate As Date
    Private mShipingDate As Date
    Private mSourceID As Long = 0
    Private mRemark As String
    Private mPO As String
    Private mShipingByID As Long = 0
    Private mShipingMethodID As Long = 0

    Private mCreateBy As String
    Private mModifiedBy As String
    Private mCreateTime As String
    Private mModifiedTime As String
    Private mIsInActive As Boolean
    Private mIsCancel As Boolean
    Private mCancelRemark As String
    Private mTotal As Double
    Private mDiscountPercen As Double
    Private mDiscountAmount As Double
    Private mVatPercen As Double
    Private mVatAmount As Double
    Private mGrandTotal As Double
     
    Private mFileAttachs As List(Of FileAttachDAO)       ' a container for the Files collection
    Private mNoteDAOs As List(Of NoteDAO)

    Private mSendBy As String
    Private mOrderStatus As String
    Private mCreditRuleID As Long
    Private mVatTypeID As Long

    Private mEmpID As Long
    Private mclsEmployee As EmployeeDAO
    Private mCustomerID As Long
    Private mclsCustomer As iPerson
    Private mProductDAOs As List(Of ProductListDAO)
    Private mPledgeDAOs As List(Of PledgeDAO)
    Private mExpireDate As Date
    Private mQuotationDays As Long
    Private mIsHold As Boolean
    Private mRefToOrderID As List(Of Long)
    Private mRefBillID As Long
    Private mPayType As String
    Private mOrderDAOs As List(Of SubOrder)
    Private mBillMedthodID As Long
    Private mPayTotal As Double
    Private mPledgeTotal As Double
    Private mRefReceiptID As Long
    Private mCurrencyID As Long
    Private mExchangeRate As Long
    Private mTaxCanYes As String
    Private mTaxCondition As String
    Private mTaxMonthYear As Date
    Private mTaxNumber As String
    Private mTaxRemark As String
    Private mTaxTaxSection As String
    Private mTaxType As String
    Private mChequeDAOs As List(Of ChequeDAO)
    Private mShipingRuleID As Long
    Private mTaxOrderDAOs As List(Of TaxOrderDAO)
    Private mTaxTotal As Double
    Private mImportTXID As Long
    Private mCustomerID_Old As Long
    Private mLocationDTLID As Long
    Private mClsClone As OrderSDAO
    Private mInvoiceSuplierID As String
    Private mInstitute As String
    Private mIsDelete As Boolean
    Private mRefOrderIDs As Long
    Private mStockType As String
    Private mIsSumStock As Boolean
    Private mIsMakePO As Boolean = False
    Private mRefToReserveID As List(Of Long)
    Private mMakePOStatus As String = ""
    Private mIsEditVat As Boolean = False
    Private mQuotationRemarkID As Long = 0
    Private mIsNotPass As Boolean = False
    Private mCampaignID As Long = 0
    Private mOrderStatus2 As String = ""
    Private mIsChangeCancel As Boolean = False
    Private mNoteProductDAOs As List(Of NoteDAO)
    Private mClaimRemark As String = ""
    Private mClaimResult As String = ""

    Public Overridable ReadOnly Property TableName() As String
        Get
            Return ""
        End Get
    End Property

    Public Property ModeData() As Integer
        Get
            Return mMode
        End Get
        Set(ByVal Value As Integer)
            mMode = Value
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
    Public Property TableID() As Long
        Get
            Return mTableID
        End Get
        Set(ByVal value As Long)
            mTableID = value
        End Set
    End Property
    Public Property Code() As String
        Get
            Return mCode
        End Get
        Set(ByVal value As String)
            mCode = value
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


    Public Property ShipingDate() As Date
        Get
            Return mShipingDate
        End Get
        Set(ByVal value As Date)
            mShipingDate = value
        End Set
    End Property

    Public Property SourceID() As Long
        Get
            Return mSourceID
        End Get
        Set(ByVal value As Long)
            mSourceID = value
        End Set
    End Property

    Public Property PO() As String
        Get
            Return mPO
        End Get
        Set(ByVal value As String)
            mPO = value
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

    Public Property IsCancel() As Boolean
        Get
            Return mIsCancel
        End Get
        Set(ByVal value As Boolean)
            mIsCancel = value
        End Set
    End Property

    Public Property CancelRemark() As String
        Get
            Return mCancelRemark
        End Get
        Set(ByVal value As String)
            mCancelRemark = value
        End Set
    End Property
    Public Property CreateBy() As String
        Get
            Return mCreateBy
        End Get
        Set(ByVal value As String)
            mCreateBy = value
        End Set
    End Property

    Public Property ModifiedBy() As String
        Get
            Return mModifiedBy
        End Get
        Set(ByVal value As String)
            mModifiedBy = value
        End Set
    End Property

    Public Property CreateTime() As String
        Get
            Return mCreateTime
        End Get
        Set(ByVal value As String)
            mCreateTime = value
        End Set

    End Property

    Public Property ModifiedTime() As String
        Get
            Return mModifiedTime
        End Get
        Set(ByVal value As String)
            mModifiedTime = value
        End Set
    End Property

    Public Property IsInActive() As Boolean
        Get
            Return mIsInActive
        End Get
        Set(ByVal value As Boolean)
            mIsInActive = value
        End Set
    End Property
    Public Property IsSumStock() As Boolean
        Get
            Return mIsSumStock
        End Get
        Set(ByVal value As Boolean)
            mIsSumStock = value
        End Set
    End Property

    Public Property IsDelete() As Boolean
        Get
            Return mIsDelete
        End Get
        Set(ByVal value As Boolean)
            mIsDelete = value
        End Set
    End Property

    Public Property Total() As Double
        Get
            Return mTotal
        End Get
        Set(ByVal value As Double)
            mTotal = value
        End Set
    End Property

    Public Property DiscountPercen() As Double
        Get
            Return mDiscountPercen
        End Get
        Set(ByVal value As Double)
            mDiscountPercen = value
        End Set
    End Property

    Public Property DiscountAmount() As Double
        Get
            Return mDiscountAmount
        End Get
        Set(ByVal value As Double)
            mDiscountAmount = value
        End Set
    End Property

    Public Property VatPercen() As Double
        Get
            Return mVatPercen
        End Get
        Set(ByVal value As Double)
            mVatPercen = value
        End Set
    End Property

    Public Property VatAmount() As Double
        Get
            Return mVatAmount
        End Get
        Set(ByVal value As Double)
            mVatAmount = value
        End Set
    End Property

    Public Property GrandTotal() As Double
        Get
            Return mGrandTotal
        End Get
        Set(ByVal value As Double)
            mGrandTotal = value
        End Set
    End Property

    Public Property PledgeTotal() As Double
        Get
            Return mPledgeTotal
        End Get
        Set(ByVal value As Double)
            mPledgeTotal = value
        End Set
    End Property

    Public Property PayTotal() As Double
        Get
            Return mPayTotal
        End Get
        Set(ByVal value As Double)
            mPayTotal = value
        End Set
    End Property

    Public Property OrderStatus() As String
        Get
            Return mOrderStatus
        End Get
        Set(ByVal value As String)
            mOrderStatus = value
        End Set
    End Property
    Public Property OrderStatus2() As String
        Get
            Return mOrderStatus2
        End Get
        Set(ByVal value As String)
            mOrderStatus2 = value
        End Set
    End Property
    Public Property IsChangeCancel() As Boolean
        Get
            Return mIsChangeCancel
        End Get
        Set(ByVal value As Boolean)
            mIsChangeCancel = value
        End Set
    End Property
    Public Property MakePOStatus() As String
        Get
            Return mMakePOStatus
        End Get
        Set(ByVal value As String)
            mMakePOStatus = value
        End Set
    End Property

    Public Property CreditRuleID() As Long
        Get
            Return mCreditRuleID
        End Get
        Set(ByVal value As Long)
            mCreditRuleID = value
        End Set
    End Property
    Public Property VatTypeID() As Long
        Get
            Return mVatTypeID
        End Get
        Set(ByVal value As Long)
            mVatTypeID = value
        End Set
    End Property
    Public Property QuotationRemarkID() As Long
        Get
            Return mQuotationRemarkID
        End Get
        Set(ByVal value As Long)
            mQuotationRemarkID = value
        End Set
    End Property
    Public Property CurrencyID() As Long
        Get
            Return mCurrencyID
        End Get
        Set(ByVal value As Long)
            mCurrencyID = value
        End Set
    End Property
    Public Property ExchangeRate() As Long
        Get
            Return mExchangeRate
        End Get
        Set(ByVal value As Long)
            mExchangeRate = value
        End Set
    End Property
    Public Property TaxCanYes() As String
        Get
            Return mTaxCanYes
        End Get
        Set(ByVal value As String)
            mTaxCanYes = value
        End Set
    End Property
    Public Property TaxCondition() As String
        Get
            Return mTaxCondition
        End Get
        Set(ByVal value As String)
            mTaxCondition = value
        End Set
    End Property

    Public Property TaxMonthYear() As Date
        Get
            Return mTaxMonthYear
        End Get
        Set(ByVal value As Date)
            mTaxMonthYear = value
        End Set
    End Property
    Public Property TaxNumber() As String
        Get
            Return mTaxNumber
        End Get
        Set(ByVal value As String)
            mTaxNumber = value
        End Set
    End Property
    Public Property TaxRemark() As String
        Get
            Return mTaxRemark
        End Get
        Set(ByVal value As String)
            mTaxRemark = value
        End Set
    End Property
    Public Property TaxTotal() As Double
        Get
            Return mTaxTotal
        End Get
        Set(ByVal value As Double)
            mTaxTotal = value
        End Set
    End Property
    Public Property SendBy() As String
        Get
            Return mSendBy
        End Get
        Set(ByVal value As String)
            mSendBy = value
        End Set
    End Property
    Public Property TaxSection() As String
        Get
            Return mTaxTaxSection
        End Get
        Set(ByVal value As String)
            mTaxTaxSection = value
        End Set
    End Property
 
    Public Property TaxType() As String
        Get
            Return mTaxType
        End Get
        Set(ByVal value As String)
            mTaxType = value
        End Set
    End Property


    Public Property NoteDAOs() As List(Of NoteDAO)
        Get
            Return mNoteDAOs
        End Get
        Set(ByVal Value As List(Of NoteDAO))
            mNoteDAOs = Value
        End Set
    End Property


    Public Property NoteProductDAOs() As List(Of NoteDAO)
        Get
            Return mNoteProductDAOs
        End Get
        Set(ByVal Value As List(Of NoteDAO))
            mNoteProductDAOs = Value
        End Set
    End Property

    Public Property FileAttachs() As List(Of FileAttachDAO)
        Get
            Return mFileAttachs
        End Get
        Set(ByVal Value As List(Of FileAttachDAO))
            mFileAttachs = Value
        End Set
    End Property
 
    Public Property EmpID() As Long
        Get
            Return mEmpID
        End Get
        Set(ByVal value As Long)
            mEmpID = value
        End Set
    End Property

    Public ReadOnly Property EmployeeDAO() As EmployeeDAO
        Get
            If mclsEmployee Is Nothing Then
                mclsEmployee = New EmployeeDAO
                mclsEmployee.InitailData(EmpID)
            End If
            Return mclsEmployee
        End Get
    End Property

    Public Property CustomerID() As Long
        Get
            Return mCustomerID
        End Get
        Set(ByVal value As Long)
            mCustomerID = value
        End Set
    End Property

    Public ReadOnly Property CustomerDAO() As CustomerDAO
        Get
            If mclsCustomer Is Nothing Then
                mclsCustomer = New CustomerDAO
                mclsCustomer.InitailData(CustomerID)
            End If
            Return mclsCustomer
        End Get
    End Property

    Public Property ProductDAOs() As List(Of ProductListDAO)
        Get
            Return mProductDAOs
        End Get
        Set(ByVal Value As List(Of ProductListDAO))
            mProductDAOs = Value
        End Set
    End Property

    Public Property PledgeDAOs() As List(Of PledgeDAO)
        Get
            Return mPledgeDAOs
        End Get
        Set(ByVal Value As List(Of PledgeDAO))
            mPledgeDAOs = Value
        End Set
    End Property
    Public Property ExpireDate() As Date
        Get
            Return mExpireDate
        End Get
        Set(ByVal value As Date)
            mExpireDate = value
        End Set
    End Property

    Public Property RefToOrderID() As List(Of Long)
        Get
            Return mRefToOrderID
        End Get
        Set(ByVal value As List(Of Long))
            mRefToOrderID = value
        End Set
    End Property
    Public Property RefToReserveID() As List(Of Long)
        Get
            Return mRefToReserveID
        End Get
        Set(ByVal value As List(Of Long))
            mRefToReserveID = value
        End Set
    End Property
    Public Property QuotationDays() As Long
        Get
            Return mQuotationDays
        End Get
        Set(ByVal value As Long)
            mQuotationDays = value
        End Set
    End Property

    Public Property PayType() As String
        Get
            Return mPayType
        End Get
        Set(ByVal value As String)
            mPayType = value
        End Set
    End Property


    Public Property IsHold() As Boolean
        Get
            Return mIsHold
        End Get
        Set(ByVal value As Boolean)
            mIsHold = value
        End Set
    End Property

    Public Property ShipingRuleID() As Long
        Get
            Return mShipingRuleID
        End Get
        Set(ByVal value As Long)
            mShipingRuleID = value
        End Set
    End Property
    Public Property ShipingByID() As Long
        Get
            Return mShipingByID
        End Get
        Set(ByVal value As Long)
            mShipingByID = value
        End Set
    End Property
    Public Property ShipingMethodID() As Long
        Get
            Return mShipingMethodID
        End Get
        Set(ByVal value As Long)
            mShipingMethodID = value
        End Set
    End Property


    Public Property IsMakePO() As Boolean
        Get
            Return mIsMakePO
        End Get
        Set(ByVal value As Boolean)
            mIsMakePO = value
        End Set
    End Property

    Public Property IsEditVat() As Boolean
        Get
            Return mIsEditVat
        End Get
        Set(ByVal value As Boolean)
            mIsEditVat = value
        End Set
    End Property


    Public Property IsNotPass() As Boolean
        Get
            Return mIsNotPass
        End Get
        Set(ByVal value As Boolean)
            mIsNotPass = value
        End Set
    End Property

    Public Property RefOrderIDs() As Long
        Get
            Return mRefOrderIDs
        End Get
        Set(ByVal value As Long)
            mRefOrderIDs = value
        End Set
    End Property


    Public Property RefBillID() As Long
        Get
            Return mRefBillID
        End Get
        Set(ByVal value As Long)
            mRefBillID = value
        End Set
    End Property

    Public Property RefReceiptID() As Long
        Get
            Return mRefReceiptID
        End Get
        Set(ByVal value As Long)
            mRefReceiptID = value
        End Set
    End Property

    Public Property BillMedthodID() As Long
        Get
            Return mBillMedthodID
        End Get
        Set(ByVal value As Long)
            mBillMedthodID = value
        End Set
    End Property

    Public Property OrderDAOs() As List(Of SubOrder)
        Get
            Return mOrderDAOs
        End Get
        Set(ByVal Value As List(Of SubOrder))
            mOrderDAOs = Value
        End Set
    End Property

    Public Property ChequeDAOs() As List(Of ChequeDAO)
        Get
            Return mChequeDAOs
        End Get
        Set(ByVal Value As List(Of ChequeDAO))
            mChequeDAOs = Value
        End Set
    End Property

    Public Property TaxOrderDAOs() As List(Of TaxOrderDAO)
        Get
            Return mTaxOrderDAOs
        End Get
        Set(ByVal Value As List(Of TaxOrderDAO))
            mTaxOrderDAOs = Value
        End Set
    End Property

    Public Property ImportTXID() As Long
        Get
            Return mImportTXID
        End Get
        Set(ByVal value As Long)
            mImportTXID = value
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

    'Public ReadOnly Property Order_Old(ByVal ptr As SqlTransaction) As OrderSDAO
    '    Get
    '        If mclsOrder_Old Is Nothing Then
    '            mclsOrder_Old = New OrderSDAO
    '            mclsOrder_Old.InitailData(ID, , ptr)
    '        End If
    '        Return mclsOrder_Old
    '    End Get
    'End Property
    Public Property ClsClone() As OrderSDAO
        Get
            Return mClsClone

        End Get
        Set(value As OrderSDAO)
            mClsClone = value
        End Set
    End Property

    Public Property InvoiceSuplierID() As String
        Get
            Return mInvoiceSuplierID
        End Get
        Set(ByVal value As String)
            mInvoiceSuplierID = value
        End Set
    End Property

    Public Property Institute() As String
        Get
            Return mInstitute
        End Get
        Set(ByVal value As String)
            mInstitute = value
        End Set
    End Property
    Public Property StockType() As String
        Get
            Return mStockType
        End Get
        Set(ByVal value As String)
            mStockType = value
        End Set
    End Property

    Public Property CampaignID() As Long
        Get
            Return mCampaignID
        End Get
        Set(ByVal value As Long)
            mCampaignID = value
        End Set
    End Property

    Public Property ClaimRemark() As String
        Get
            Return mClaimRemark
        End Get
        Set(ByVal value As String)
            mClaimRemark = value
        End Set
    End Property

    Public Property ClaimResult() As String
        Get
            Return mClaimResult
        End Get
        Set(ByVal value As String)
            mClaimResult = value
        End Set
    End Property

    Public Sub New()
        mIDs = 0
        mCode = ""
        mOrderDate = Now
        mShipingDate = mOrderDate
        mSourceID = 0
        mSendBy = ""
        mRemark = ""
        mIsCancel = 0
        mCreateBy = ""
        mModifiedBy = ""
        mCreateTime = ""
        mModifiedTime = ""
        mIsInActive = 0
        mTotal = 0
        mDiscountPercen = 0
        mDiscountAmount = 0
        mVatPercen = 0
        mVatAmount = 0
        mGrandTotal = 0
        mIsDelete = 0

        mPO = ""
        mOrderStatus = ""
        mCreditRuleID = 0
        mVatTypeID = 0
        mFileAttachs = Nothing
        mNoteDAOs = Nothing
        mEmpID = 0
        mclsEmployee = Nothing

        mCustomerID = 0
        mclsCustomer = Nothing
        mProductDAOs = Nothing

        mIsHold = False
        mExpireDate = mOrderDate
        mQuotationDays = 0
        mRefToOrderID = New List(Of Long)
        mRefToReserveID = New List(Of Long)
        mShipingByID = 0
        mShipingMethodID = 0
        mRefBillID = 0
        mOrderDAOs = Nothing
        mPledgeDAOs = Nothing
        mBillMedthodID = 0
        mPayTotal = 0
        mPledgeTotal = 0
        mRefReceiptID = 0
        mCurrencyID = 0
        mExchangeRate = 1
        mTaxCanYes = ""
        mTaxCondition = ""
        mTaxMonthYear = Now
        mTaxNumber = ""
        mTaxRemark = ""
        mChequeDAOs = Nothing
        mTaxOrderDAOs = Nothing
        mShipingRuleID = 0
        mTaxTotal = 0
        mImportTXID = 0
        mCustomerID_Old = 0
        mLocationDTLID = 0
        mClsClone = Nothing
        mInvoiceSuplierID = ""
        mInstitute = ""
        mRefOrderIDs = 0
        mStockType = ""
        mIsEditVat = False
        mCampaignID = 0
    End Sub

#End Region

    Public Overridable Function InitailData(ByVal pID As Long, Optional ByVal pName As String = "", Optional ByVal tr As SqlTransaction = Nothing) As Boolean

    End Function

    Public Overridable Function SaveData(Optional ByRef ptr As SqlTransaction = Nothing) As Boolean
    
    End Function

    Public Overridable Function CheckExist() As Boolean

    End Function

    Public Overridable Function GetToRefOrderCode(ByVal pParentOrderID As Long, ByRef tr As SqlTransaction) As String

    End Function


    Public Overridable Function GetToRefReserveCode(ByVal pParentOrderID As Long, ByRef tr As SqlTransaction) As String

    End Function
End Class
