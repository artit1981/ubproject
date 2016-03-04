Option Explicit On
Public Class CampaignSub

    Dim mCampaignID As Long
    Dim mSubject As String = ""
    Dim mBudget As Decimal = 0
    Dim mStartDate As Date
    Dim mExpireDate As Date
    Dim mEvaluateTarget As Decimal
    Dim mEvaluateBy As String = ""
    Dim mCampaignStatus As String = ""
    Dim mCampaignDTL As List(Of CampaignDetail)
    Dim mActivity As Decimal = 0
    Dim mIsDelete As Integer = 0

    Public Property CampaignID() As Long
        Get
            Return mCampaignID
        End Get
        Set(ByVal value As Long)
            mCampaignID = value
        End Set
    End Property


    Public Property Subject() As String
        Get
            Return mSubject
        End Get
        Set(ByVal value As String)
            mSubject = value
        End Set
    End Property

    Public Property StartDate() As Date
        Get
            Return mStartDate
        End Get
        Set(ByVal value As Date)
            mStartDate = value
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
    Public Property Budget() As Decimal
        Get
            Return mBudget
        End Get
        Set(ByVal value As Decimal)
            mBudget = value
        End Set
    End Property
    Public Property EvaluateTarget() As Decimal
        Get
            Return mEvaluateTarget
        End Get
        Set(ByVal value As Decimal)
            mEvaluateTarget = value
        End Set
    End Property
    Public Property EvaluateBy() As String
        Get
            Return mEvaluateBy
        End Get
        Set(ByVal value As String)
            mEvaluateBy = value
        End Set
    End Property
    Public Property Activity() As Decimal
        Get
            Return mActivity
        End Get
        Set(ByVal value As Decimal)
            mActivity = value
        End Set
    End Property
    Public Property CampaignStatus() As String
        Get
            Return mCampaignStatus
        End Get
        Set(ByVal value As String)
            mCampaignStatus = value
        End Set
    End Property

    Public Property CampaignDTL() As List(Of CampaignDetail)
        Get
            Return mCampaignDTL
        End Get
        Set(ByVal value As List(Of CampaignDetail))
            mCampaignDTL = value
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
