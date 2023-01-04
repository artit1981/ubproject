Option Explicit On
Imports System.Data.SqlClient
Public Class CommissionDAO
    Inherits iOrder

#Region "Property"

    Private mSubject As String = ""
    Dim mStartDate As Date
    Dim mCommissionType As Integer = 0
    Dim mDtlList As List(Of CommissionDtlDAO)


    Public Overrides ReadOnly Property TableName() As String
        Get
            Return "Commission"
        End Get
    End Property

    Public Property DtlList() As List(Of CommissionDtlDAO)
        Get
            Return mDtlList
        End Get
        Set(ByVal value As List(Of CommissionDtlDAO))
            mDtlList = value
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


    Public Property CommissionType() As Integer
        Get
            Return mCommissionType
        End Get
        Set(ByVal value As Integer)
            mCommissionType = value
        End Set
    End Property


#End Region

    Public Function CHECKSUM_AGG() As Long
        Dim SQL As String
        Dim dataTable As New DataTable()
        Try
            SQL = "SELECT CHECKSUM_AGG(BINARY_CHECKSUM(*)) FROM " & TableName & " WITH (NOLOCK);"

            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    Return ConvertNullToZero(dr(0))
                    Exit For
                Next
            End If
            Return 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "CommissionDAO.CHECKSUM_AGG : " & e.Message)
            Return 0
        Finally
            dataTable = Nothing
        End Try
    End Function

    Public Overrides Function InitailData(ByVal pID As Long, Optional ByVal pName As String = "", Optional ByVal tr As SqlTransaction = Nothing) As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()
        Dim lUserDAO As New UserDAO

        Try
            SQL = "SELECT *   "
            SQL &= " FROM Commission "
            SQL &= " WHERE 1=1"
            If pID > 0 Then
                SQL &= " and CommissionID=" & pID
            End If
            If pName.Trim <> "" Then
                SQL &= " and Subject='" & pName.Trim & "'"
            End If

            dataTable = gConnection.executeSelectQuery(SQL, tr)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows

                    Subject = ConvertNullToString(dr("Subject"))
                    ID = ConvertNullToZero(dr("CommissionID"))

                    CommissionType = ConvertNullToZero(dr("CommissionType"))

                    If IsDBNull(dr("StartDate")) Then
                        StartDate = GetCurrentDate(tr)
                    Else
                        StartDate = dr("StartDate")
                    End If
                    If IsDBNull(dr("ExpireDate")) Then
                        ExpireDate = GetCurrentDate(tr)
                    Else
                        ExpireDate = dr("ExpireDate")
                    End If

                    Remark = ConvertNullToString(dr("Remark"))

                    IsInActive = dr("IsInActive")
                    CreateTime = ConvertNullToDateTime(dr("CreateTime"))
                    ModifiedTime = ConvertNullToDateTime(dr("ModifiedTime"))
                    If lUserDAO.InitailData(True, ConvertNullToZero(dr("CreateBy")), "", tr) Then
                        CreateBy = lUserDAO.UserName
                    Else
                        CreateBy = ""
                    End If

                    If ConvertNullToZero(dr("CreateBy")) = ConvertNullToZero(dr("ModifiedBy")) Then
                        ModifiedBy = CreateBy
                    Else
                        If lUserDAO.InitailData(True, ConvertNullToZero(dr("ModifiedBy")), "", tr) Then
                            ModifiedBy = lUserDAO.UserName
                        Else
                            ModifiedBy = ""
                        End If
                    End If


                    Return True
                    Exit For
                Next
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "CommissionDAO.InitailData : " & e.Message)
            Return False
        Finally
            lUserDAO = Nothing
            dataTable = Nothing
        End Try

    End Function


    Public Function GetInfoHtml() As String
        Dim Info As String = ""
        'Try
        '    Info = Constants.vbCrLf & Constants.vbCrLf & mSubject
        '    Info &= Constants.vbCrLf & Constants.vbCrLf & "ชื่อ - สกุล: " & Title & FirstName & " " & LastName
        '    Info &= Constants.vbCrLf & "บริษัท: " & CompanyName
        '    Info &= Constants.vbCrLf & "โทรศัพท์มือถือ: " & AddressS.MobilePhone
        '    Info &= Constants.vbCrLf & "เบอร์โทรศัพท์: " & AddressS.Phone1
        '    Info &= Constants.vbCrLf & "เบอร์โทรสาร: " & AddressS.Fax
        '    Info &= Constants.vbCrLf & "อีเมลล์: " & AddressS.Email1
        'Catch e As Exception
        '    Err.Raise(Err.Number, e.Source, "CommissionDAO.GetInfoHtml : " & e.Message)

        'End Try
        Return Info
    End Function


    Public Function GetDataTable(ByVal pID As Long, ByVal pOnlyActive As Boolean) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT CommissionID,Subject  , StartDate, ExpireDate,IsDelete"
            SQL &= " FROM Commission  "
            SQL &= " WHERE 0=0   "
            If pID > 0 Then
                SQL &= "  AND CommissionID=" & pID
            End If
            If pOnlyActive = True Then
                SQL &= " AND IsDelete =0   "
                SQL &= " AND IsInActive = 0"
            End If

            SQL &= " ORDER BY Subject"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "CommissionDAO.GetDataTable : " & e.Message)
        End Try
        Return dataTable
    End Function


    'Public Function GetDataTableCombo(ByVal pID As Long, ByVal pOnlyActive As Boolean, ByVal pStartDate As Date, ByVal pExpireDate As Date, ByVal pLoadAll As Boolean) As DataTable
    '    Dim SQL As String
    '    Dim dataTable As New DataTable()

    '    Try
    '        SQL = "SELECT Campaign.CampaignID,Campaign.Subject  "
    '        SQL &= "  , StartDate, ExpireDate,Case when CampaignStatus=3 then 'Fail' when CampaignStatus=2 then 'Success' else 'Open' end CampaignStatus "
    '        SQL &= " FROM Campaign  "
    '        SQL &= " WHERE Campaign.IsDelete =0   "
    '        If pID > 0 Then
    '            SQL &= "  AND Campaign.CampaignID=" & pID
    '        End If
    '        If pOnlyActive = True And pLoadAll = False Then
    '            SQL &= "  AND Campaign.IsInActive = 0"
    '        End If
    '        If pLoadAll = False Then
    '            SQL &= "  AND Campaign.StartDate <= '" & formatSQLDate(pStartDate) & "'"
    '            SQL &= "  AND Campaign.ExpireDate >= '" & formatSQLDate(pExpireDate) & "'"
    '        End If


    '        SQL &= " ORDER BY Campaign.CampaignID"
    '        dataTable = gConnection.executeSelectQuery(SQL, Nothing)
    '    Catch e As Exception
    '        Err.Raise(Err.Number, e.Source, "CommissionDAO.GetDataTableCombo : " & e.Message)
    '    End Try
    '    Return dataTable
    'End Function


    Public Overrides Function SaveData(Optional ByRef ptr As SqlTransaction = Nothing) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand
        Dim tr As SqlTransaction = Nothing

        SQL = ""
        Try
            tr = gConnection.Connection.BeginTransaction

            Select Case ModeData
                Case DataMode.ModeNew

                    EmpID = gEmpID
                    ID = GenNewID("CommissionID", "Commission", tr)
                    SQL = " INSERT INTO Commission (CommissionID,Subject,CommissionType,StartDate ,ExpireDate, Remark "
                    SQL &= " ,CreateBy,CreateTime,IsInActive,IsDelete  "
                    SQL &= " )"
                    SQL &= " VALUES ( @IDs"
                    SQL &= " ,  @Subject"
                    SQL &= " ,  @CommissionType"
                    SQL &= " ,  @StartDate"
                    SQL &= " ,  @ExpireDate"
                    SQL &= " ,  @Remark "
                    SQL &= " ,  @gUserID"
                    SQL &= " ,  @CreateTime"
                    SQL &= " ,  @IsInActive"
                    SQL &= " ,  @IsDelete"
                    SQL &= " ) "
                Case DataMode.ModeEdit
                    SQL = " UPDATE Commission SET "
                    SQL &= " Subject=@Subject"
                    SQL &= " , CommissionType=@CommissionType "
                    SQL &= " , StartDate=@StartDate "
                    SQL &= " , ExpireDate=@ExpireDate "
                    SQL &= " , Remark=@Remark "
                    SQL &= " ,ModifiedBy= @gUserID"
                    SQL &= " ,ModifiedTime= @CreateTime"
                    SQL &= " ,IsInActive= @IsInActive"
                    SQL &= " WHERE CommissionID= @IDs"
                Case DataMode.ModeDelete
                    SQL = " UPDATE Commission SET IsDelete=@IsDelete "
                    SQL &= " ,ModifiedBy= @gUserID"
                    SQL &= " ,ModifiedTime= @CreateTime"
                    SQL &= " WHERE CommissionID= @IDs"
            End Select
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@IDs", ID))
            myCommand.Parameters.Add(New SqlParameter("@Subject", Trim(Subject)))
            myCommand.Parameters.Add(New SqlParameter("@CommissionType", ConvertNullToZero(CommissionType)))
            myCommand.Parameters.Add(New SqlParameter("@StartDate", formatSQLDate(StartDate)))
            myCommand.Parameters.Add(New SqlParameter("@ExpireDate", formatSQLDate(ExpireDate)))
            myCommand.Parameters.Add(New SqlParameter("@Remark", ConvertNullToString(Remark)))
            myCommand.Parameters.Add(New SqlParameter("@gUserID", gUserID))
            myCommand.Parameters.Add(New SqlParameter("@CreateTime", formatSQLDateTime(GetCurrentDate(tr))))
            myCommand.Parameters.Add(New SqlParameter("@IsInActive", IsInActive))


            Select Case ModeData
                Case DataMode.ModeNew
                    myCommand.Parameters.Add(New SqlParameter("@IsDelete", 0))
                Case DataMode.ModeDelete
                    myCommand.Parameters.Add(New SqlParameter("@IsDelete", 1))
            End Select

            gConnection.executeInsertSqlCommand(myCommand, tr)

            For Each pData In DtlList
                pData.SaveData(tr)
            Next


            SaveNote(NoteDAOs, ModeData, ID, TableName, tr)


            tr.Commit()
            Return True
        Catch e As Exception
            tr.Rollback()
            Err.Raise(Err.Number, e.Source, "CommissionDAO.SaveData : " & e.Message)
            Return False
        End Try

    End Function


    Public Overrides Function CheckExist() As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT CommissionID  FROM Commission"
            SQL &= " WHERE IsDelete =0 AND Subject='" & Trim(mSubject) & "'"
            If ModeData = DataMode.ModeEdit Then
                SQL &= " AND CommissionID <> " & ID
            End If
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            Return dataTable.Rows.Count > 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "CommissionDAO.CheckExist : " & e.Message)
            Return False
        Finally
            dataTable = Nothing
        End Try

    End Function




End Class
