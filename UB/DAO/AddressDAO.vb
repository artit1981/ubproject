Option Explicit On

Imports System.Data.SqlClient
Public Class AddressDAO
    Dim mMode As DataMode
    Dim mIDs As Long
    Dim mImageID As Long
    Dim mRemark As String
    Dim mAddressNo As String
    Dim mAddressName As String
    Dim mGroupNo As String
    Dim mBuilding As String
    Dim mStreet As String
    Dim mLane As String
    Dim mDistrict As String
    Dim mAmphur As String
    Dim mProvince As String
    Dim mPostalCode As String
    Dim mCountry As String
    Dim mContactName As String
    Dim mMobilePhone As String
    Dim mPhone1 As String
    Dim mPhone2 As String
    Dim mPhone3 As String
    Dim mFax As String
    Dim mEmail1 As String
    Dim mEmail2 As String
    Dim mEmail3 As String
    Dim mWebsite As String

    'Map (Image)
    Private mImageS As FileAttachDAO

#Region "Property"


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

    Public Property Remark() As String
        Get
            Return mRemark
        End Get
        Set(ByVal Value As String)
            mRemark = Value
        End Set
    End Property

    Public Property AddressName() As String
        Get
            Return mAddressName
        End Get
        Set(ByVal Value As String)
            mAddressName = Value
        End Set
    End Property

    Public Property AddressNo() As String
        Get
            Return mAddressNo
        End Get
        Set(ByVal Value As String)
            mAddressNo = Value
        End Set

    End Property

    Public Property GroupNo() As String
        Get
            Return mGroupNo
        End Get
        Set(ByVal Value As String)
            mGroupNo = Value
        End Set
    End Property

    Public Property Building() As String
        Get
            Return mBuilding
        End Get
        Set(ByVal Value As String)
            mBuilding = Value
        End Set
    End Property

    Public Property Lane() As String
        Get
            Return mLane
        End Get
        Set(ByVal Value As String)
            mLane = Value
        End Set
    End Property

    Public Property Street() As String
        Get
            Return mStreet
        End Get
        Set(ByVal Value As String)
            mStreet = Value
        End Set
    End Property

    Public Property District() As String
        Get
            Return mDistrict
        End Get
        Set(ByVal Value As String)
            mDistrict = Value
        End Set
    End Property

    Public Property Amphur() As String
        Get
            Return mAmphur
        End Get
        Set(ByVal Value As String)
            mAmphur = Value
        End Set
    End Property

    Public Property Province() As String
        Get
            Return mProvince
        End Get
        Set(ByVal Value As String)
            mProvince = Value
        End Set
    End Property

    Public Property PostalCode() As String
        Get
            Return mPostalCode
        End Get
        Set(ByVal Value As String)
            mPostalCode = Value
        End Set
    End Property

    Public Property Country() As String
        Get
            Return mCountry
        End Get
        Set(ByVal Value As String)
            mCountry = Value
        End Set
    End Property

    Public Property ContactName() As String
        Get
            Return mContactName
        End Get
        Set(ByVal Value As String)
            mContactName = Value
        End Set
    End Property

    Public Property MobilePhone() As String
        Get
            Return mMobilePhone
        End Get
        Set(ByVal Value As String)
            mMobilePhone = Value
        End Set
    End Property

    Public Property Phone1() As String
        Get
            Return mPhone1
        End Get
        Set(ByVal Value As String)
            mPhone1 = Value
        End Set
    End Property

    Public Property Phone2() As String
        Get
            Return mPhone2
        End Get
        Set(ByVal Value As String)
            mPhone2 = Value
        End Set
    End Property

    Public Property Phone3() As String
        Get
            Return mPhone3
        End Get
        Set(ByVal Value As String)
            mPhone3 = Value
        End Set
    End Property

    Public Property Fax() As String
        Get
            Return mFax
        End Get
        Set(ByVal Value As String)
            mFax = Value
        End Set
    End Property

    Public Property Email1() As String
        Get
            Return mEmail1
        End Get
        Set(ByVal Value As String)
            mEmail1 = Value
        End Set
    End Property

    Public Property Email2() As String
        Get
            Return mEmail2
        End Get
        Set(ByVal Value As String)
            mEmail2 = Value
        End Set
    End Property

    Public Property Email3() As String
        Get
            Return mEmail3
        End Get
        Set(ByVal Value As String)
            mEmail3 = Value
        End Set
    End Property

    Public Property Website() As String
        Get
            Return mWebsite
        End Get
        Set(ByVal Value As String)
            mWebsite = Value
        End Set
    End Property

    Public ReadOnly Property AddressShort() As String
        Get
            Return BuildAddress(False)
        End Get
    End Property

    Public ReadOnly Property AddressLong() As String
        Get
            Return BuildAddress(True)
        End Get
    End Property
#End Region

    Private Function BuildAddress(ByVal pIsLong As Boolean) As String
        Dim lstrAddress As String
        If AddressName <> "" Then
            lstrAddress = AddressName
        Else
            lstrAddress = AddressNo
            If pIsLong Then
                If mGroupNo.Trim <> "" Then
                    lstrAddress = lstrAddress & " หมู่ที่ " & mGroupNo.Trim
                End If
                If mBuilding.Trim <> "" Then
                    lstrAddress = lstrAddress & " หมู่บ้าน/อาคาร " & mBuilding.Trim
                End If
                If mLane.Trim <> "" Then
                    lstrAddress = lstrAddress & " ซอย " & mLane.Trim
                End If
                If mStreet.Trim <> "" Then
                    lstrAddress = lstrAddress & " ถนน " & mStreet.Trim
                End If
                If mDistrict.Trim <> "" Then
                    lstrAddress = lstrAddress & vbNewLine & " ตำบล/แขวง " & mDistrict.Trim
                End If
                If mAmphur.Trim <> "" Then
                    lstrAddress = lstrAddress & " อำเภอ/เขต " & mAmphur.Trim
                End If

                lstrAddress = lstrAddress & vbNewLine & " จังหวัด " & mProvince.Trim
                lstrAddress = lstrAddress & " " & mPostalCode.Trim
            Else
                If mGroupNo.Trim <> "" Then
                    lstrAddress = lstrAddress & " หมู่ " & mGroupNo.Trim
                End If
                If mLane.Trim <> "" Then
                    lstrAddress = lstrAddress & " ซ." & mLane.Trim
                End If
                If mStreet.Trim <> "" Then
                    lstrAddress = lstrAddress & " ถ." & mStreet.Trim
                End If

                lstrAddress = lstrAddress & " ต." & mDistrict.Trim
                lstrAddress = lstrAddress & " อ." & mAmphur.Trim
                lstrAddress = lstrAddress & vbNewLine & " จ." & mProvince.Trim
                lstrAddress = lstrAddress & " " & mPostalCode.Trim
            End If
        End If


        Return lstrAddress.Trim
    End Function

    Public Function InitailData(ByVal pAdressID As Long, ByRef tr As SqlTransaction) As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT * "
            SQL &=  " FROM Address  "
            SQL &=  " WHERE AddressID =" & pAdressID

            dataTable = gConnection.executeSelectQuery(SQL, tr)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    mIDs = Int32.Parse(dr("AddressID"))
                    mImageID = ConvertNullToZero(dr("ImageID"))
                    mRemark = dr("Remark").ToString
                    mAddressNo = dr("AddressNo").ToString
                    mAddressName = dr("AddressName").ToString
                    mGroupNo = dr("GroupNo").ToString
                    mBuilding = dr("Building").ToString
                    mLane = dr("Lane").ToString
                    mStreet = dr("Street").ToString
                    mDistrict = dr("District").ToString
                    mAmphur = dr("Amphur").ToString
                    mProvince = dr("Province").ToString
                    mPostalCode = dr("PostalCode").ToString
                    mCountry = dr("Country").ToString
                    mContactName = dr("ContactName").ToString
                    mMobilePhone = dr("MobilePhone").ToString
                    mPhone1 = dr("Phone1").ToString
                    mPhone2 = dr("Phone2").ToString
                    mPhone3 = dr("Phone3").ToString
                    mFax = dr("Fax").ToString
                    mEmail1 = dr("Email1").ToString
                    mEmail2 = dr("Email2").ToString
                    mEmail3 = dr("Email3").ToString
                    mWebsite = dr("Website").ToString

                    If mImageID > 0 And tr Is Nothing Then
                        mImageS = New FileAttachDAO
                        mImageS.InitailData(mImageID, tr)
                    End If

                    Return True
                    Exit For
                Next

            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "AddressDAO.InitailData : " & e.Message)
            Return False
        Finally
            dataTable = Nothing
        End Try

    End Function


    Public Function SaveData(ByVal tr As SqlTransaction) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand
        SQL = ""
        Try
            Select Case mMode
                Case DataMode.ModeNew
                    mIDs = GenNewID("AddressID", "Address", tr)
                    SQL = " INSERT INTO Address  (AddressID,AddressName,AddressNo,GroupNo,Building,Lane,Street,District"
                    SQL &=  " ,Amphur,Province,PostalCode,Country,ContactName,MobilePhone "
                    SQL &=  " ,Phone1,Phone2,Phone3,Fax,Email1,Email2,Email3,Website,ImageID,Remark,IsDelete )"
                    SQL &=  " VALUES ( @mIDs"
                    SQL &=  " ,  @AddressName "
                    SQL &=  " ,  @AddressNo "
                    SQL &=  " ,  @GroupNo "
                    SQL &=  " ,  @Building "
                    SQL &=  " ,  @Lane "
                    SQL &=  " ,  @Street "
                    SQL &=  " ,  @District "
                    SQL &=  " ,  @Amphur "
                    SQL &=  " ,  @Province "
                    SQL &=  " ,  @PostalCode "
                    SQL &=  " ,  @Country "
                    SQL &=  " ,  @ContactName "
                    SQL &=  " ,  @MobilePhone "
                    SQL &=  " ,  @Phone1 "
                    SQL &=  " ,  @Phone2 "
                    SQL &=  " ,  @Phone3 "
                    SQL &=  " ,  @Fax "
                    SQL &=  " ,  @Email1 "
                    SQL &=  " ,  @Email2 "
                    SQL &=  " ,  @Email3 "
                    SQL &=  " ,  @Website "
                    SQL &=  " ,  @ImageID "
                    SQL &=  " ,  @Remark "
                    SQL &=  " ,  @mIsDelete "
                    SQL &=  " ) "
                Case DataMode.ModeEdit
                    SQL = " UPDATE Address "
                    SQL &=  " SET AddressName=@AddressName "
                    SQL &=  " ,AddressNo=@AddressNo "
                    SQL &=  " ,GroupNo  =@GroupNo "
                    SQL &=  " ,Building  =@Building "
                    SQL &=  " ,Lane  =@Lane "
                    SQL &=  " ,Street  =@Street "
                    SQL &=  " ,District  =@District "
                    SQL &=  " ,Amphur  =@Amphur "
                    SQL &=  " ,Province  =@Province "
                    SQL &=  " ,PostalCode  =@PostalCode "
                    SQL &=  " ,Country  =@Country "
                    SQL &=  " ,ContactName  =@ContactName "
                    SQL &=  " ,MobilePhone  =@MobilePhone "
                    SQL &=  " ,Phone1  =@Phone1 "
                    SQL &=  " ,Phone2  =@Phone2 "
                    SQL &=  " ,Phone3  =@Phone3 "
                    SQL &=  " ,Fax  =@Fax "
                    SQL &=  " ,Email1  =@Email1 "
                    SQL &=  " ,Email2  =@Email2 "
                    SQL &=  " ,Email3  =@Email3 "
                    SQL &=  " ,Website  =@Website "
                    SQL &=  " ,ImageID  =@ImageID "
                    SQL &=  " ,Remark  =@Remark "
                    SQL &=  " WHERE AddressID= @mIDs"

                Case DataMode.ModeDelete
                    SQL = " UPDATE Address SET IsDelete=@mIsDelete "
                    SQL &=  " WHERE AddressID= @mIDs"
            End Select
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@mIDs", mIDs))
            myCommand.Parameters.Add(New SqlParameter("@AddressName", AddressName))
            myCommand.Parameters.Add(New SqlParameter("@AddressNo", AddressNo))
            myCommand.Parameters.Add(New SqlParameter("@GroupNo", GroupNo))
            myCommand.Parameters.Add(New SqlParameter("@Building", Building))
            myCommand.Parameters.Add(New SqlParameter("@Lane", Lane))
            myCommand.Parameters.Add(New SqlParameter("@Street", Street))
            myCommand.Parameters.Add(New SqlParameter("@District", District))
            myCommand.Parameters.Add(New SqlParameter("@Amphur", Amphur))
            myCommand.Parameters.Add(New SqlParameter("@Province", Province))
            myCommand.Parameters.Add(New SqlParameter("@PostalCode", PostalCode))
            myCommand.Parameters.Add(New SqlParameter("@Country", Country))
            myCommand.Parameters.Add(New SqlParameter("@ContactName", ContactName))
            myCommand.Parameters.Add(New SqlParameter("@MobilePhone", MobilePhone))
            myCommand.Parameters.Add(New SqlParameter("@Phone1", Phone1))
            myCommand.Parameters.Add(New SqlParameter("@Phone2", Phone2))
            myCommand.Parameters.Add(New SqlParameter("@Phone3", Phone3))
            myCommand.Parameters.Add(New SqlParameter("@Fax", Fax))
            myCommand.Parameters.Add(New SqlParameter("@Email1", Email1))
            myCommand.Parameters.Add(New SqlParameter("@Email2", Email2))
            myCommand.Parameters.Add(New SqlParameter("@Email3", Email3))
            myCommand.Parameters.Add(New SqlParameter("@Website", Website))
            myCommand.Parameters.Add(New SqlParameter("@ImageID", ImageID))
            myCommand.Parameters.Add(New SqlParameter("@Remark", Remark))
            Select Case mMode
                Case DataMode.ModeNew
                    myCommand.Parameters.Add(New SqlParameter("@mIsDelete", 0))
                Case DataMode.ModeDelete
                    myCommand.Parameters.Add(New SqlParameter("@mIsDelete", 1))
            End Select
            gConnection.executeInsertSqlCommand(myCommand, tr)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "AddressDAO.SaveData : " & e.Message)
            Return False
        End Try

    End Function


    Public Sub New()
        mIDs = 0
        mImageID = 0
        mRemark = ""
        mAddressNo = ""
        mAddressName = ""
        mGroupNo = ""
        mBuilding = ""
        mStreet = ""
        mLane = ""
        mDistrict = ""
        mAmphur = ""
        mProvince = ""
        mPostalCode = ""
        mCountry = ""
        mContactName = ""
        mMobilePhone = ""
        mPhone1 = ""
        mPhone2 = ""
        mPhone3 = ""
        mFax = ""
        mEmail1 = ""
        mEmail2 = ""
        mEmail3 = ""
        mWebsite = ""
        mImageS = Nothing
    End Sub
End Class
