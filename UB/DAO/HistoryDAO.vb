Option Explicit On
Imports System.Data.SqlClient

Public Class HistoryDAO
    Dim mMode As DataMode
    Dim mIDs As Long
    Dim mImageID As Long

    Dim mIdentityCard As String
    Dim mIdentityCardIssueAt As String
    Dim mIdentityCardDate As Date
    Dim mIdentityCardExpire As Date
    Dim mBirthDate As Date
    Dim mGender As String
    Dim mHeight As Decimal
    Dim mWeight As Decimal
    Dim mBloodGroups As String
    Dim mRace As String
    Dim mNationality As String
    Dim mReligion As String
    Dim mTaxID As String
    Dim mMaritalStatus As String
    Dim mMaritalName As String
    Dim mMilitaryStatus As String

#Region "Property"


    Public Property MilitaryStatus() As String
        Get
            Return mMilitaryStatus
        End Get
        Set(ByVal Value As String)
            mMilitaryStatus = Value
        End Set
    End Property

    Public Property MaritalName() As String
        Get
            Return mMaritalName
        End Get
        Set(ByVal Value As String)
            mMaritalName = Value
        End Set
    End Property

    Public Property MaritalStatus() As String
        Get
            Return mMaritalStatus
        End Get
        Set(ByVal Value As String)
            mMaritalStatus = Value
        End Set
    End Property

    Public Property TaxID() As String
        Get
            Return mTaxID
        End Get
        Set(ByVal Value As String)
            mTaxID = Value
        End Set
    End Property

    Public Property Religion() As String
        Get
            Return mReligion
        End Get
        Set(ByVal Value As String)
            mReligion = Value
        End Set
    End Property

    Public Property Nationality() As String
        Get
            Return mNationality
        End Get
        Set(ByVal Value As String)
            mNationality = Value
        End Set
    End Property

    Public Property Race() As String
        Get
            Return mRace
        End Get
        Set(ByVal Value As String)
            mRace = Value
        End Set
    End Property

    Public Property BloodGroups() As String
        Get
            Return mBloodGroups
        End Get
        Set(ByVal Value As String)
            mBloodGroups = Value
        End Set
    End Property

    Public Property Weight() As Decimal
        Get
            Return mWeight
        End Get
        Set(ByVal Value As Decimal)
            mWeight = Value
        End Set
    End Property

    Public Property Height() As Decimal
        Get
            Return mHeight
        End Get
        Set(ByVal Value As Decimal)
            mHeight = Value
        End Set
    End Property

    Public Property Gender() As String
        Get
            Return mGender
        End Get
        Set(ByVal Value As String)
            mGender = Value
        End Set
    End Property

    Public Property BirthDate() As Date
        Get
            Return mBirthDate
        End Get
        Set(ByVal Value As Date)
            mBirthDate = Value
        End Set
    End Property

    Public Property IdentityCardExpire() As Date
        Get
            Return mIdentityCardExpire
        End Get
        Set(ByVal Value As Date)
            mIdentityCardExpire = Value
        End Set
    End Property

    Public Property IdentityCardDate() As Date
        Get
            Return mIdentityCardDate
        End Get
        Set(ByVal Value As Date)
            mIdentityCardDate = Value
        End Set
    End Property

    Public Property IdentityCardIssueAt() As String
        Get
            Return mIdentityCardIssueAt
        End Get
        Set(ByVal Value As String)
            mIdentityCardIssueAt = Value
        End Set
    End Property

    Public Property IdentityCard() As String
        Get
            Return mIdentityCard
        End Get
        Set(ByVal Value As String)
            mIdentityCard = Value
        End Set
    End Property


    'Map (Image)
    Private mImageS As FileAttachDAO
    Public Property ImageS() As FileAttachDAO
        Get
            Return mImageS
        End Get
        Set(ByVal Value As FileAttachDAO)
            mImageS = Value
        End Set
    End Property

    'Local Property
    Public Property ID() As Long
        Get
            Return mIDs
        End Get
        Set(ByVal value As Long)
            mIDs = value
        End Set
    End Property

    Public Property ModeData() As Integer
        Get
            Return mMode
        End Get
        Set(ByVal Value As Integer)
            mMode = Value
        End Set
    End Property

    Public Property ImageID() As Long
        Get
            Return mImageID
        End Get
        Set(ByVal value As Long)
            mImageID = value
        End Set
    End Property
#End Region

    Public Function InitailData(ByVal pHistoryID As Long, ByRef tr As SqlTransaction) As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT * "
            SQL &=  " FROM History  "
            SQL &=  " WHERE HistoryID =" & pHistoryID

            dataTable = gConnection.executeSelectQuery(SQL, tr)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    ID = Int32.Parse(dr("HistoryID"))
                    ImageID = ConvertNullToZero(dr("ImageID"))
                    IdentityCard = dr("IdentityCard").ToString
                    IdentityCardIssueAt = dr("IdentityCardIssueAt").ToString
                    IdentityCardDate = dr("IdentityCardDate")
                    IdentityCardExpire = dr("IdentityCardExpire")
                    Gender = dr("Gender").ToString
                    BirthDate = dr("BirthDate")
                    Height = dr("Height")
                    Weight = dr("Weight")
                    BloodGroups = dr("BloodGroups").ToString
                    Race = dr("Race").ToString
                    Nationality = dr("Nationality").ToString
                    Religion = dr("Religion").ToString
                    TaxID = dr("TaxID").ToString
                    MaritalStatus = dr("MaritalStatus").ToString
                    MaritalName = dr("MaritalName").ToString
                    MilitaryStatus = dr("MilitaryStatus").ToString

                    If mImageID > 0 Then
                        mImageS = New FileAttachDAO
                        mImageS.InitailData(mImageID, tr)
                    End If
                    Exit For
                Next
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "History.InitailData : " & e.Message)
            Return False
        End Try
    End Function

    Public Function SaveData(ByVal tr As SqlTransaction) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand
        SQL = ""
        Try
            'Address Map
            If ImageS Is Nothing Then
                ImageS = New FileAttachDAO
            End If

            If ModeData = DataMode.ModeNew Then
                ImageS.ModeData = DataMode.ModeNew
            ElseIf ModeData = DataMode.ModeDelete Then
                ImageS.ModeData = DataMode.ModeDelete
            End If
            If ImageS.ModeData <> DataMode.ModeNone Then
                'ModeNone = not change
                ImageS.SaveData(tr)
            End If
            ImageID = ImageS.ID

            Select Case mMode
                Case DataMode.ModeNew
                    mIDs = GenNewID("HistoryID", "History", tr)
                    SQL = " INSERT INTO History  (HistoryID,ImageID,IdentityCard,IdentityCardIssueAt,IdentityCardDate,IdentityCardExpire"
                    SQL &=  " ,Gender,BirthDate,Height,Weight,BloodGroups,Race,Nationality,Religion,TaxID,MaritalStatus"
                    SQL &=  " ,MaritalName,MilitaryStatus,IsDelete )"
                    SQL &=  " VALUES ( @mIDs"
                    SQL &=  " ,  @ImageID "
                    SQL &=  " ,  @IdentityCard "
                    SQL &=  " ,  @IdentityCardIssueAt "
                    SQL &=  " ,  @IdentityCardDate "
                    SQL &=  " ,  @IdentityCardExpire "
                    SQL &=  " ,  @Gender "
                    SQL &=  " ,  @BirthDate "
                    SQL &=  " ,  @Height "
                    SQL &=  " ,  @Weight "
                    SQL &=  " ,  @BloodGroups "
                    SQL &=  " ,  @Race "
                    SQL &=  " ,  @Nationality "
                    SQL &=  " ,  @Religion "
                    SQL &=  " ,  @TaxID "
                    SQL &=  " ,  @MaritalStatus "
                    SQL &=  " ,  @MaritalName "
                    SQL &=  " ,  @MilitaryStatus "
                    SQL &=  " ,  @mIsDelete "
                    SQL &=  " ) "
                Case DataMode.ModeEdit
                    SQL = " UPDATE History "
                    SQL &=  " SET IdentityCard=@IdentityCard "
                    SQL &=  " ,IdentityCardIssueAt=@IdentityCardIssueAt "
                    SQL &=  " ,IdentityCardDate=@IdentityCardDate "
                    SQL &=  " ,IdentityCardExpire=@IdentityCardExpire "
                    SQL &=  " ,Gender=@Gender  "
                    SQL &=  " ,BirthDate=@BirthDate  "
                    SQL &=  " ,Height=@Height  "
                    SQL &=  " ,Weight=@Weight  "
                    SQL &=  " ,BloodGroups=@BloodGroups  "
                    SQL &=  " ,Race=@Race  "
                    SQL &=  " ,Nationality=@Nationality  "
                    SQL &=  " ,Religion=@Religion  "
                    SQL &=  " ,TaxID=@TaxID  "
                    SQL &=  " ,MaritalStatus=@MaritalStatus  "
                    SQL &=  " ,MaritalName=@MaritalName  "
                    SQL &=  " ,MilitaryStatus=@MilitaryStatus  "
                    SQL &=  " ,ImageID  =@ImageID "
                    SQL &=  " WHERE HistoryID= @mIDs"

                Case DataMode.ModeDelete
                    SQL = " UPDATE History SET IsDelete=@mIsDelete "
                    SQL &=  " WHERE HistoryID= @mIDs"
            End Select
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@mIDs", mIDs))
            myCommand.Parameters.Add(New SqlParameter("@IdentityCard", IdentityCard))
            myCommand.Parameters.Add(New SqlParameter("@IdentityCardIssueAt", IdentityCardIssueAt))
            myCommand.Parameters.Add(New SqlParameter("@IdentityCardDate", IdentityCardDate))
            myCommand.Parameters.Add(New SqlParameter("@IdentityCardExpire", IdentityCardExpire))
            myCommand.Parameters.Add(New SqlParameter("@Gender", Gender))
            myCommand.Parameters.Add(New SqlParameter("@BirthDate", BirthDate))
            myCommand.Parameters.Add(New SqlParameter("@Height", Height))
            myCommand.Parameters.Add(New SqlParameter("@Weight", Weight))
            myCommand.Parameters.Add(New SqlParameter("@BloodGroups", BloodGroups))
            myCommand.Parameters.Add(New SqlParameter("@Race", Race))
            myCommand.Parameters.Add(New SqlParameter("@Nationality", Nationality))
            myCommand.Parameters.Add(New SqlParameter("@Religion", Religion))
            myCommand.Parameters.Add(New SqlParameter("@TaxID", TaxID))
            myCommand.Parameters.Add(New SqlParameter("@MaritalStatus", MaritalStatus))
            myCommand.Parameters.Add(New SqlParameter("@MaritalName", MaritalName))
            myCommand.Parameters.Add(New SqlParameter("@MilitaryStatus", MilitaryStatus))
            myCommand.Parameters.Add(New SqlParameter("@ImageID", ImageID))
            Select Case mMode
                Case DataMode.ModeNew
                    myCommand.Parameters.Add(New SqlParameter("@mIsDelete", 0))
                Case DataMode.ModeDelete
                    myCommand.Parameters.Add(New SqlParameter("@mIsDelete", 1))
            End Select
            gConnection.executeInsertSqlCommand(myCommand, tr)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "History.SaveData : " & e.Message)
            Return False
        End Try

    End Function

    Public Sub New()
        mIDs = 0
        mImageID = 0

        mIdentityCard = ""
        mIdentityCardIssueAt = ""
        mIdentityCardDate = Now
        mIdentityCardExpire = Now
        mBirthDate = Now
        mGender = ""
        mHeight = 0
        mWeight = 0
        mBloodGroups = ""
        mRace = ""
        mNationality = ""
        mReligion = ""
        mTaxID = ""
        mMaritalStatus = ""
        mMaritalName = ""
        mMilitaryStatus = ""
    End Sub
End Class
