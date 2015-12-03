Option Explicit On
Imports System.Data.SqlClient

Public Class ApproveTX

    Inherits iDAO

#Region "Property"

    Dim mOrderID As Long
    Dim mOrderType As String
    Dim mOrderTable As String
    Dim mOrderCode As String
    Dim mOrderDate As Date
    Dim mOrderAmount As Decimal
    Dim mApproveStatus As String
    Dim mOrderBy As String
    Dim mApproveType As Integer

    Public ReadOnly Property TableName() As String
        Get
            Return "ApproveTX"
        End Get
    End Property

    Public Property OrderID() As Long
        Get
            Return mOrderID
        End Get
        Set(ByVal Value As Long)
            mOrderID = Value
        End Set
    End Property

    Public Property OrderType() As String
        Get
            Return mOrderType
        End Get
        Set(ByVal Value As String)
            mOrderType = Value
        End Set
    End Property

    Public Property OrderTable() As String
        Get
            Return mOrderTable
        End Get
        Set(ByVal Value As String)
            mOrderTable = Value
        End Set
    End Property

    Public Property OrderCode() As String
        Get
            Return mOrderCode
        End Get
        Set(ByVal Value As String)
            mOrderCode = Value
        End Set
    End Property

    Public Property OrderDate() As Date
        Get
            Return mOrderDate
        End Get
        Set(ByVal Value As Date)
            mOrderDate = Value
        End Set
    End Property
    Public Property OrderAmount() As Decimal
        Get
            Return mOrderAmount
        End Get
        Set(ByVal Value As Decimal)
            mOrderAmount = Value
        End Set
    End Property

    Public Property ApproveStatus() As String
        Get
            Return mApproveStatus
        End Get
        Set(ByVal Value As String)
            mApproveStatus = Value
        End Set
    End Property

    Public Property OrderBy() As String
        Get
            Return mOrderBy
        End Get
        Set(ByVal Value As String)
            mOrderBy = Value
        End Set
    End Property

    Public Property ApproveType() As Integer
        Get
            Return mApproveType
        End Get
        Set(ByVal Value As Integer)
            mApproveType = Value
        End Set
    End Property
#End Region

    Public Function CHECKSUM_AGG() As Long
        Dim SQL As String
        Dim dataTable As New DataTable()
        Try
            SQL = "SELECT CHECKSUM_AGG(BINARY_CHECKSUM(*)) FROM ApproveTX WITH (NOLOCK);"

            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    Return ConvertNullToZero(dr(0))
                    Exit For
                Next
            End If
            Return 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ApproveTX.CHECKSUM_AGG : " & e.Message)
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
            SQL = SQL & " FROM ApproveTX "
            SQL = SQL & " WHERE ApproveTXID=" & pID

            SQL = SQL & " ORDER BY ApproveTXID"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    ID = Int32.Parse(dr("ApproveTXID"))
                    OrderID = ConvertNullToZero(dr("OrderID"))
                    OrderType = ConvertNullToString(dr("OrderType"))
                    OrderTable = ConvertNullToString(dr("OrderTable"))
                    OrderCode = ConvertNullToString(dr("OrderCode"))
                    OrderDate = Date.Parse(dr("OrderDate"))
                    OrderAmount = ConvertNullToZero(dr("OrderAmount"))
                    ApproveStatus = ConvertNullToZero(dr("ApproveStatus"))
                    OrderBy = ConvertNullToString(dr("OrderBy"))
                    ApproveType = ConvertNullToZero(dr("ApproveType"))

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
                     
                    Return True
                    Exit For
                Next

            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ApproveTX.InitailData : " & e.Message)
            Return False
        Finally
            lUserDAO = Nothing
            dataTable = Nothing
        End Try

    End Function


    Public Function GetInfoHtml() As String
        Dim Info As String = ""
        'Try

        '    Info = Constants.vbCrLf & Constants.vbCrLf & "รหัสแผนก: " & Code
        '    Info &= Constants.vbCrLf & "ชื่อแผนก: " & NameThai
        '    Info &= Constants.vbCrLf & "ชื่อแผนก (Eng): " & NameEng
        '    Info &= Constants.vbCrLf & "หัวหน้าแผนก: "
        '    If Not Manager Is Nothing Then
        '        Info &= Manager.Title & Manager.FirstName & " " & Manager.LastName
        '    End If
        '    Info &= Constants.vbCrLf & "รายละเอียด: " & Remark

        'Catch e As Exception
        '    Err.Raise(Err.Number, e.Source, "ApproveTX.GetInfoHtml : " & e.Message)

        'End Try
        Return Info
    End Function


    Public Function GetDataTable() As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()
        Try
            SQL = "SELECT * "
            SQL = SQL & " FROM ApproveTX  "
            SQL = SQL & " WHERE ApproveStatus='Wait Approve'  "

            If gIsApproveLimitUser = False And gIsApproveOrderUser = False Then
                SQL &= " and 1>2 "
            ElseIf gIsApproveLimitUser = True And gIsApproveOrderUser = True Then

            ElseIf gIsApproveOrderUser = True Then
                SQL = SQL & " AND ApproveType =1   "
            ElseIf gIsApproveLimitUser = True Then
                SQL = SQL & " ApproveType=2   "
            End If
            SQL = SQL & " ORDER BY ApproveTXID"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ApproveTX.GetDataTable : " & e.Message)
        End Try
        Return dataTable
    End Function

  
    Public Function SaveData(ByRef ptr As SqlTransaction) As Boolean
        Dim SQL As String
        Dim llngAddressID As Long = 0
        Dim myCommand As SqlCommand
        Dim tr As SqlTransaction = Nothing
        SQL = ""
        Try
            If ptr Is Nothing Then
                tr = gConnection.Connection.BeginTransaction
            Else
                tr = ptr
            End If

            Select Case ModeData
                Case DataMode.ModeNew
                    ID = GenNewID("ApproveTXID", "ApproveTX", tr)
                    SQL = " INSERT INTO ApproveTX  (ApproveTXID,OrderID,OrderType,OrderTable,OrderCode,OrderDate"
                    SQL = SQL & " ,OrderAmount,ApproveStatus ,Remark,OrderBy,ApproveType"
                    SQL = SQL & " ,CreateBy,CreateTime )"
                    SQL = SQL & " VALUES ( @ApproveTXID"
                    SQL = SQL & " ,  @OrderID"
                    SQL = SQL & " ,  @OrderType"
                    SQL = SQL & " ,  @OrderTable"
                    SQL = SQL & " ,  @OrderCode"
                    SQL = SQL & " ,  @OrderDate"
                    SQL = SQL & " ,  @OrderAmount"
                    SQL = SQL & " ,  @ApproveStatus"
                    SQL = SQL & " ,  @Remark"
                    SQL = SQL & " ,  @OrderBy"
                    SQL = SQL & " ,  @ApproveType"
                    SQL = SQL & " ,  @gUserID"
                    SQL = SQL & " ,  @CreateTime"
                    SQL = SQL & " ) "
                Case DataMode.ModeEdit
                    SQL = " UPDATE ApproveTX SET "
                    SQL = SQL & " Remark=@Remark"
                    SQL = SQL & " ,ApproveStatus= @ApproveStatus"
                    SQL = SQL & " ,ModifiedBy= @gUserID"
                    SQL = SQL & " ,ModifiedTime= @CreateTime"
                    SQL = SQL & " WHERE ApproveTXID= @ApproveTXID"
                Case DataMode.ModeDelete
                    'SQL = " UPDATE ApproveUser SET IsDelete=@mIsDelete "
                    'SQL = SQL & " ,ModifiedBy= @gUserID"
                    'SQL = SQL & " ,ModifiedTime= @CreateTime"
                    'SQL = SQL & " WHERE ApproveUserID= @ApproveUserID"
            End Select
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@ApproveTXID", ID))
            myCommand.Parameters.Add(New SqlParameter("@OrderID", OrderID))
            myCommand.Parameters.Add(New SqlParameter("@OrderType", Trim(OrderType)))
            myCommand.Parameters.Add(New SqlParameter("@OrderTable", Trim(OrderTable)))
            myCommand.Parameters.Add(New SqlParameter("@OrderCode", Trim(OrderCode)))
            myCommand.Parameters.Add(New SqlParameter("@OrderDate", OrderDate))
            myCommand.Parameters.Add(New SqlParameter("@OrderAmount", ConvertNullToZero(OrderAmount)))
            myCommand.Parameters.Add(New SqlParameter("@ApproveStatus", Trim(ApproveStatus)))
            myCommand.Parameters.Add(New SqlParameter("@Remark", Trim(Remark)))
            myCommand.Parameters.Add(New SqlParameter("@OrderBy", Trim(OrderBy)))
            myCommand.Parameters.Add(New SqlParameter("@ApproveType", ConvertNullToZero(ApproveType)))
            myCommand.Parameters.Add(New SqlParameter("@gUserID", gUserID))
            myCommand.Parameters.Add(New SqlParameter("@CreateTime", formatSQLDateTime(GetCurrentDate(tr))))

            'Select Case ModeData
            '    Case DataMode.ModeNew
            '        myCommand.Parameters.Add(New SqlParameter("@mIsDelete", 0))
            '    Case DataMode.ModeDelete
            '        myCommand.Parameters.Add(New SqlParameter("@mIsDelete", 1))
            'End Select
            gConnection.executeInsertSqlCommand(myCommand, tr)

            If ModeData = DataMode.ModeEdit And (ApproveStatus = "Approve" Or ApproveStatus = "Not Approve") Then
                SetOrderApproveTX(OrderTable, OrderID, OrderType, ApproveType, ApproveStatus, tr)
            End If

            If ptr Is Nothing Then tr.Commit()
            Return True
        Catch e As Exception
            If ptr Is Nothing Then tr.Rollback()
            Err.Raise(Err.Number, e.Source, "ApproveTX.SaveData : " & e.Message)
            Return False
        End Try

    End Function

    Public Function CheckExist() As Boolean
        'Dim SQL As String
        'Dim dataTable As New DataTable()
        Return False
        'Try
        '    'SQL = "SELECT DepartmentID  FROM Department"
        '    'SQL = SQL & " WHERE IsDelete =0 AND IDCode='" & Trim(Code) & "'"
        '    'If ModeData = DataMode.ModeEdit Then
        '    '    SQL = SQL & " AND DepartmentID <> " & ID
        '    'End If
        '    'dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        '    'Return dataTable.Rows.Count > 0
        'Catch ex As Exception
        '    Err.Raise(Err.Number, ex.Source, "ApproveTX.CheckExist : " & ex.Message)
        '    Return False
        'Finally

        '    'dataTable = Nothing
        'End Try

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
        '    Err.Raise(Err.Number, e.Source, "ApproveTX.CheckNotExist : " & e.Message)
        'Finally
        '    dataTable = Nothing
        'End Try
        Return False
    End Function

    Public Sub New()
        mOrderID = 0
        mOrderType = ""
        mOrderTable = ""
        mOrderCode = ""
        mOrderDate = Now
        mOrderAmount = 0
        mApproveStatus = ""
        mOrderBy = ""
        mApproveType = 0
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
