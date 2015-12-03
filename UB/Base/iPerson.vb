Option Explicit On

Imports System.Data.SqlClient

Public Class iPerson

    Private mCode As String
    Private mTitle As String
    Private mFirstName As String
    Private mLastName As String
    Private mTitleEng As String
    Private mFirstNameEng As String
    Private mLastNameEng As String
    Private mNickName As String
    Private mCriterionPriceID As Long
    Private mCompanyName As String
    Private mSourceID As Long
    Private mTerritoryID As Long
    Private mTerritoryDAOs As TerritoryDAO
    Private mRemark As String
    Private mCreateBy As String
    Private mModifiedBy As String
    Private mCreateTime As String
    Private mModifiedTime As String
    Private mIsInActive As Boolean

    Private mAddressDAO As AddressDAO
    Private mAddressShipDAO As AddressDAO
    Private mMode As DataMode
    Private mFileAttachs As List(Of FileAttachDAO)       ' a container for the Files collection
    Private mNoteDAOs As List(Of NoteDAO)
    Private mIDs As Long
    Private mPosition As String
    Private mVatTypeID As Long
    Private mCreditRuleID As Long
    'Private mCreditRoleDAOs As CreditRoleDAO
    Private mBillDay As Long
    Private mChqDay As Long
    Private mCustomerZoneID As Long
    Private mSendBy As String
    Private mHistoryDAO As HistoryDAO
    'Dim mOrderStatus As String
    Dim mCreditGroupID As Long
    Dim mCreditAmount As Decimal
    Dim mCustomerGroupID As Long
    Dim mIsCorporation As Integer
    Dim mImportTXID As Long
    Dim mIsMainCompany As Integer
    Dim mBillDayTo As Long
    Dim mChqDayTo As Long
    
 

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

    Public Property Code() As String
        Get
            Return mCode
        End Get
        Set(ByVal value As String)
            mCode = value
        End Set
    End Property

    Public ReadOnly Property CustomerName() As String
        Get
            If CompanyName <> "" Then
                Return CompanyName
            Else
                Return Title & FirstName & " " & LastName
            End If
        End Get
    End Property

    Public Property Title() As String
        Get
            Return mTitle
        End Get
        Set(ByVal value As String)
            mTitle = value
        End Set
    End Property

    Public Property FirstName() As String
        Get
            Return mFirstName
        End Get
        Set(ByVal value As String)
            mFirstName = value
        End Set
    End Property


    Public Property LastName() As String
        Get
            Return mLastName
        End Get
        Set(ByVal value As String)
            mLastName = value
        End Set
    End Property

    Public Property TitleEng() As String
        Get
            Return mTitleEng
        End Get
        Set(ByVal value As String)
            mTitleEng = value
        End Set
    End Property

    Public Property FirstNameEng() As String
        Get
            Return mFirstNameEng
        End Get
        Set(ByVal value As String)
            mFirstNameEng = value
        End Set
    End Property


    Public Property LastNameEng() As String
        Get
            Return mLastNameEng
        End Get
        Set(ByVal value As String)
            mLastNameEng = value
        End Set
    End Property

    Public Property NickName() As String
        Get
            Return mNickName
        End Get
        Set(ByVal value As String)
            mNickName = value
        End Set
    End Property

    Public Property Position() As String
        Get
            Return mPosition
        End Get
        Set(ByVal value As String)
            mPosition = value
        End Set
    End Property


    Public Property CompanyName() As String
        Get
            Return mCompanyName
        End Get
        Set(ByVal value As String)
            mCompanyName = value
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

    Public Property TerritoryID() As Long
        Get
            Return mTerritoryID
        End Get
        Set(ByVal value As Long)
            mTerritoryID = value
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

    Public Property CreditRuleID() As Long
        Get
            Return mCreditRuleID
        End Get
        Set(ByVal value As Long)
            mCreditRuleID = value
        End Set
    End Property

    Public Property CreditGroupID() As Long
        Get
            Return mCreditGroupID
        End Get
        Set(ByVal value As Long)
            mCreditGroupID = value
        End Set
    End Property

  

    'Public ReadOnly Property CreditRuleDAOs() As CreditRoleDAO
    '    Get
    '        If mCreditRoleDAOs Is Nothing Then
    '            mCreditRoleDAOs = New CreditRoleDAO
    '            If mCreditRuleID > 0 Then
    '                mCreditRoleDAOs.InitailData(mCreditRuleID)
    '            End If

    '        End If
    '        Return mCreditRoleDAOs
    '    End Get
    'End Property


    Public Property BillDayTo() As Long
        Get
            Return mBillDayTo
        End Get
        Set(ByVal value As Long)
            mBillDayTo = value
        End Set
    End Property
    Public Property BillDay() As Long
        Get
            Return mBillDay
        End Get
        Set(ByVal value As Long)
            mBillDay = value
        End Set
    End Property
    Public Property ChqDayTo() As Long
        Get
            Return mChqDayTo
        End Get
        Set(ByVal value As Long)
            mChqDayTo = value
        End Set
    End Property
    Public Property ChqDay() As Long
        Get
            Return mChqDay
        End Get
        Set(ByVal value As Long)
            mChqDay = value
        End Set
    End Property
    Public Property CustomerZoneID() As Long
        Get
            Return mCustomerZoneID
        End Get
        Set(ByVal value As Long)
            mCustomerZoneID = value
        End Set
    End Property
    Public Property CustomerGroupID() As Long
        Get
            Return mCustomerGroupID
        End Get
        Set(ByVal value As Long)
            mCustomerGroupID = value
        End Set
    End Property
    Public Property IsCorporation() As Integer
        Get
            Return mIsCorporation
        End Get
        Set(ByVal value As Integer)
            mIsCorporation = value
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
    Public Property CriterionPriceID() As Long
        Get
            Return mCriterionPriceID
        End Get
        Set(ByVal value As Long)
            mCriterionPriceID = value
        End Set
    End Property

    Public ReadOnly Property TerritoryDAOs() As TerritoryDAO
        Get
            If mTerritoryDAOs Is Nothing Then
                mTerritoryDAOs = New TerritoryDAO
                If mTerritoryID > 0 Then
                    mTerritoryDAOs.InitailData(mTerritoryID)
                End If

            End If
            Return mTerritoryDAOs
        End Get
    End Property

    Public Property Remark() As String
        Get
            Return mRemark
        End Get
        Set(ByVal value As String)
            mRemark = value
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



    Public Property NoteDAOs() As List(Of NoteDAO)
        Get
            Return mNoteDAOs
        End Get
        Set(ByVal Value As List(Of NoteDAO))
            mNoteDAOs = Value
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

    Public Property AddressS() As AddressDAO
        Get
            Return mAddressDAO
        End Get
        Set(ByVal Value As AddressDAO)
            mAddressDAO = Value
        End Set
    End Property

    Public Property HistoryDAO() As HistoryDAO
        Get
            Return mHistoryDAO
        End Get
        Set(ByVal value As HistoryDAO)
            mHistoryDAO = value
        End Set
    End Property

    Public Property AddressShip() As AddressDAO
        Get
            Return mAddressShipDAO
        End Get
        Set(ByVal Value As AddressDAO)
            mAddressShipDAO = Value
        End Set

    End Property

    Public Property CreditAmount() As Decimal
        Get
            Return mCreditAmount
        End Get
        Set(ByVal value As Decimal)
            mCreditAmount = value
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
    Public Property IsMainCompany() As Integer
        Get
            Return mIsMainCompany
        End Get
        Set(ByVal value As Integer)
            mIsMainCompany = value
        End Set
    End Property
    Public Overridable Function InitailData(ByVal pID As Long, Optional ByVal pName As String = "", Optional ByVal tr As SqlTransaction = Nothing) As Boolean

    End Function

    Public Overridable Function SaveData(Optional ByRef ptr As SqlTransaction = Nothing) As Boolean

    End Function

    Public Sub New()
        mCode = ""
        mTitle = ""
        mFirstName = ""
        mLastName = ""
        mTitleEng = ""
        mFirstNameEng = ""
        mLastNameEng = ""
        mNickName = ""
        mCompanyName = ""
        mSourceID = 0
        mRemark = ""
        mCreateBy = ""
        mModifiedBy = ""
        mCreateTime = ""
        mModifiedTime = ""
        mIsInActive = False
        mAddressDAO = Nothing
        mFileAttachs = Nothing
        mNoteDAOs = Nothing
        mHistoryDAO = Nothing
        mIDs = 0
        mPosition = ""
        mCustomerZoneID = 0
        mTerritoryDAOs = Nothing
        mAddressShipDAO = Nothing
        'mCreditRoleDAOs = Nothing
        mVatTypeID = 0
        mCreditRuleID = 0
        mBillDay = 0
        mChqDay = 0
        mBillDayTo = 0
        mChqDayTo = 0
        mCriterionPriceID = 0
        mSendBy = ""
        'mOrderStatus = ""
        mCreditAmount = 0
        mCreditGroupID = 0
        mCustomerZoneID = 0
        mCustomerGroupID = 0
        mIsCorporation = 1
        mImportTXID = 0
        mIsMainCompany = 1
    End Sub
End Class
