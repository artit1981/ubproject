Option Explicit On

Imports System.Data.SqlClient

Public Class ProvinceDAO
    Inherits iDAO
    Dim mGeoID As Long = 0
#Region "Property"

    Public ReadOnly Property TableName() As String
        Get
            Return "Province"
        End Get
    End Property


    Public Property GeoID() As Long
        Get
            Return mGeoID
        End Get
        Set(ByVal value As Long)
            mGeoID = value
        End Set
    End Property

#End Region

    Public Function CHECKSUM_AGG() As Long
        Dim SQL As String
        Dim dataTable As New DataTable()
        Try
            SQL = "SELECT CHECKSUM_AGG(BINARY_CHECKSUM(*)) FROM Province WITH (NOLOCK);"

            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    Return ConvertNullToZero(dr(0))
                    Exit For
                Next
            End If
            Return 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProvinceDAO.CHECKSUM_AGG : " & e.Message)
            Return 0
        Finally
            dataTable = Nothing
        End Try
    End Function


    Public Function InitailData(ByVal pID As Long) As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()
        Dim lUserDAO As New UserDAO

        Try
            SQL = "SELECT *   "
            SQL = SQL & " FROM Province "
            SQL = SQL & " WHERE ProvinceID=" & pID

            SQL = SQL & " ORDER BY ProvinceName"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    ID = Int32.Parse(dr("ProvinceID"))
                    IsInActive = dr("IsInActive")
                    NameThai = dr("ProvinceName").ToString
                    NameEng = dr("ProvinceNameEng").ToString
                    Code = dr("ProvinceCode").ToString
                    Remark = dr("Remark").ToString
                    CreateTime = ConvertNullToDateTime(dr("CreateTime"))
                    ModifiedTime = ConvertNullToDateTime(dr("ModifiedTime"))
                    If lUserDAO.InitailData(True, ConvertNullToZero(dr("CreateBy")), "") Then
                        CreateBy = lUserDAO.UserName
                    Else
                        CreateBy = ""
                    End If

                    If ConvertNullToZero(dr("CreateBy")) = ConvertNullToZero(dr("ModifiedBy")) Then
                        ModifiedBy = CreateBy
                    Else
                        If lUserDAO.InitailData(True, ConvertNullToZero(dr("ModifiedBy")), "") Then
                            ModifiedBy = lUserDAO.UserName
                        Else
                            ModifiedBy = ""
                        End If
                    End If
                    GeoID = ConvertNullToZero(dr("GeoID"))

                    Return True
                    Exit For
                Next

            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProvinceDAO.InitailData : " & e.Message)
            Return False
        Finally
            lUserDAO = Nothing
            dataTable = Nothing
        End Try
    End Function

    Public Function GetInfoHtml() As String
        Dim Info As String = ""

        Return Info
    End Function

    Public Function GetDataTable() As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT ProvinceID AS ID, ProvinceCode, ProvinceName,ProvinceNameEng "
            SQL = SQL & " FROM Province   "
            SQL = SQL & " WHERE IsDelete=0 ORDER BY ProvinceName"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProvinceDAO.GetDataTable : " & e.Message)
        End Try
        Return dataTable
    End Function

    Public Function SaveData() As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand
        Dim tr As SqlTransaction = Nothing
        SQL = ""
        Try

            tr = gConnection.Connection.BeginTransaction

            Select Case ModeData
                Case DataMode.ModeNew
                    ID = GenNewID("ProvinceID", "Province", tr)
                    SQL = " INSERT INTO Province  (ProvinceID,GeoID,ProvinceCode,ProvinceName,ProvinceNameEng,Remark"
                    SQL = SQL & " ,CreateBy,CreateTime,IsInActive,IsDelete)"
                    SQL = SQL & " VALUES ( @mIDs"
                    SQL = SQL & " ,  @GeoID"
                    SQL = SQL & " ,  @mIDCode"
                    SQL = SQL & " ,  @mNameThai"
                    SQL = SQL & " ,  @mNameEng"
                    SQL = SQL & " ,  @mRemark"
                    SQL = SQL & " ,  @gUserID"
                    SQL = SQL & " ,  @CreateTime"
                    SQL = SQL & " ,  @mIsInActive"
                    SQL = SQL & " ,  @mIsDelete"
                    SQL = SQL & " ) "
                Case DataMode.ModeEdit
                    SQL = " UPDATE Province SET "
                    SQL = SQL & " GeoID=@GeoID"
                    SQL = SQL & " ,ProvinceCode=@mIDCode"
                    SQL = SQL & " ,ProvinceName=@mNameThai"
                    SQL = SQL & " ,ProvinceNameEng=@mNameEng"
                    SQL = SQL & " ,Remark= @mRemark"
                    SQL = SQL & " ,ModifiedBy= @gUserID"
                    SQL = SQL & " ,ModifiedTime= @CreateTime"
                    SQL = SQL & " ,IsInActive= @mIsInActive"
                    SQL = SQL & " WHERE ProvinceID= @mIDs"
                Case DataMode.ModeDelete
                    SQL = " UPDATE Province SET IsDelete=@mIsDelete "
                    SQL = SQL & " ,ModifiedBy= @gUserID"
                    SQL = SQL & " ,ModifiedTime= @CreateTime"
                    SQL = SQL & " WHERE ProvinceID= @mIDs"
            End Select
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@mIDs", ID))
            myCommand.Parameters.Add(New SqlParameter("@GeoID", GeoID))
            myCommand.Parameters.Add(New SqlParameter("@mIDCode", ConvertNullToString(ID)))
            myCommand.Parameters.Add(New SqlParameter("@mNameThai", Trim(NameThai)))
            myCommand.Parameters.Add(New SqlParameter("@mNameEng", Trim(NameEng)))
            myCommand.Parameters.Add(New SqlParameter("@mRemark", Trim(Remark)))
            myCommand.Parameters.Add(New SqlParameter("@gUserID", gUserID))
            myCommand.Parameters.Add(New SqlParameter("@CreateTime", formatSQLDateTime(GetCurrentDate(tr))))
            myCommand.Parameters.Add(New SqlParameter("@mIsInActive", IsInActive))

            Select Case ModeData
                Case DataMode.ModeNew
                    myCommand.Parameters.Add(New SqlParameter("@mIsDelete", 0))
                Case DataMode.ModeDelete
                    myCommand.Parameters.Add(New SqlParameter("@mIsDelete", 1))
            End Select
            gConnection.executeInsertSqlCommand(myCommand, tr)


            tr.Commit()
            Return True
        Catch e As Exception
            tr.Rollback()
            Err.Raise(Err.Number, e.Source, "ProvinceDAO.SaveData : " & e.Message)
            Return False
        End Try

    End Function

    Public Function CheckExist() As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT ProvinceID  FROM Province"
            SQL = SQL & " WHERE IsDelete =0 AND ProvinceName='" & Trim(NameThai) & "'"
            If ModeData = DataMode.ModeEdit Then
                SQL = SQL & " AND ProvinceID <> " & ID
            End If
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            Return dataTable.Rows.Count > 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProvinceDAO.CheckExist : " & e.Message)
            Return False
        Finally
            dataTable = Nothing
        End Try

    End Function

    Public Function CheckIsToUse() As Boolean ''ถูกใช้งานอยู่ ???
        'Dim MSG As String = ""
        'Dim SQL As String
        'Dim dataTable As New DataTable()

        'Try
        '    SQL = "SELECT DepartmentID  FROM Position"
        '    SQL = SQL & " WHERE IsDelete =0 AND DepartmentID=" & ID
        '    dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        '    Return dataTable.Rows.Count = 0
        'Catch e As Exception
        '    Err.Raise(Err.Number, e.Source, "ProvinceDAO.CheckNotExist : " & e.Message)
        'Finally
        '    dataTable = Nothing
        'End Try
        Return False
    End Function

    Public Sub New()

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub



End Class
