Option Explicit On

Imports System.Data.SqlClient


Public Class CustomerListDAO
    Inherits iPerson
    Private mRefID As Long = 0
    Private mRefTableID As Long = 0
    Private mCustomerID As Long = 0

    Public Property RefID() As Long
        Get
            Return mRefID
        End Get
        Set(ByVal value As Long)
            mRefID = value
        End Set
    End Property

    Public Property RefTableID() As Long
        Get
            Return mRefTableID
        End Get
        Set(ByVal value As Long)
            mRefTableID = value
        End Set
    End Property

    Public Property CustomerID() As Long
        Get
            Return mCustomerID
        End Get
        Set(ByVal value As Long)
            mCustomerID = value
        End Set
    End Property



    Public Overrides Function InitailData(ByVal pID As Long, Optional ByVal pName As String = "", Optional ByVal tr As SqlTransaction = Nothing) As Boolean
        'Dim SQL As String
        'Dim dataTable As New DataTable()
        'Dim lUserDAO As New UserDAO
        ''Dim lFileAttach As New FileAttachDAO
        'Try
        '    SQL = "SELECT *   "
        '    SQL &=  " FROM Employee "
        '    SQL &=  " WHERE 1=1"
        '    If pID > 0 Then
        '        SQL &=  " and EmpID=" & pID
        '    End If
        '    If pName <> "" Then
        '        SQL &=  " and Firstname like '%" & pName & "%'"
        '    End If
        '    SQL &=  " ORDER BY EmpCode"
        '    dataTable = gConnection.executeSelectQuery(SQL, tr)
        '    If dataTable.Rows.Count > 0 Then
        '        For Each dr As DataRow In dataTable.Rows
        '            'Employee 
        '            If IsDBNull(dr("StartDate")) Then
        '                StartDate = GetCurrentDate(tr)
        '            Else
        '                StartDate = dr("StartDate")
        '            End If
        '            EmpCode = ConvertNullToString(dr("EmpCode"))
        '            WorkingStatus = ConvertNullToString(dr("WorkingStatus"))

        '            'Person
        '            ID = Int32.Parse(dr("EmpID"))
        '            IsInActive = dr("IsInActive")
        '            Title = ConvertNullToString(dr("Title"))
        '            FirstName = ConvertNullToString(dr("Firstname"))
        '            LastName = ConvertNullToString(dr("LastName"))
        '            TitleEng = ConvertNullToString(dr("TitleEng"))
        '            FirstNameEng = ConvertNullToString(dr("FirstNameEng"))
        '            LastNameEng = ConvertNullToString(dr("LastNameEng"))
        '            NickName = ConvertNullToString(dr("NickName"))


        '            Remark = dr("Remark").ToString
        '            CreateTime = ConvertNullToDateTime(dr("CreateTime"))
        '            ModifiedTime = ConvertNullToDateTime(dr("ModifiedTime"))
        '            If lUserDAO.InitailData(True, ConvertNullToZero(dr("CreateBy")), "", tr) Then
        '                CreateBy = lUserDAO.UserName
        '            Else
        '                CreateBy = ""
        '            End If

        '            If ConvertNullToZero(dr("CreateBy")) = ConvertNullToZero(dr("ModifiedBy")) Then
        '                ModifiedBy = CreateBy
        '            Else
        '                If lUserDAO.InitailData(True, ConvertNullToZero(dr("ModifiedBy")), "", tr) Then
        '                    ModifiedBy = lUserDAO.UserName
        '                Else
        '                    ModifiedBy = ""
        '                End If
        '            End If
        '            If ConvertNullToZero(dr("ViewLevel")) = 0 Then
        '                ViewLevel = eViewLevel.All
        '            Else
        '                ViewLevel = ConvertNullToZero(dr("ViewLevel"))
        '            End If

        '            TerritoryID = ConvertNullToZero(dr("TerritoryID"))
        '            EmpGroupID = ConvertNullToZero(dr("EmpGroupID"))
        '            Commission = ConvertNullToZero(dr("Commission"))

        '            'Load Position
        '            PositionID = ConvertNullToZero(dr("PositionID"))

        '            'Load AddressDAO
        '            AddressS = Nothing
        '            AddressS = New AddressDAO
        '            AddressS.InitailData(ConvertNullToZero(dr("AddressID")), tr)

        '            'Load HistoryDAO
        '            HistoryDAO = Nothing
        '            HistoryDAO = New HistoryDAO
        '            HistoryDAO.InitailData(ConvertNullToZero(dr("HistoryID")), tr)



        '            'Load FileAttach
        '            FileAttachs = LoadFileAttach(ID, TableName, tr)

        '            Return True
        '            Exit For
        '        Next
        '    End If

        'Catch e As Exception
        '    Err.Raise(Err.Number, e.Source, "CustomerListDAO.InitailData : " & e.Message)
        '    Return False
        'Finally
        '    lUserDAO = Nothing
        '    dataTable = Nothing
        'End Try

    End Function

    Public Function GetDataTable(ByVal pRefID As Long, ByVal pRefTableID As Long, ByVal pIsDelete As Integer) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT CustomerList.CustomerID ,Customer.CustomerCode "
            SQL &=  " ,case when Customer.CompanyName='' then Customer.Title + Customer.Firstname "
            SQL &=  " + ' ' + Customer.LastName else Customer.CompanyName end CusName"
            SQL &=  " ,CustomerType "
            SQL &=  " ,Address.Phone1,Address.Email1 "

            SQL &=  " FROM CustomerList  "
            SQL &=  " LEFT OUTER JOIN Customer ON Customer.CustomerID=CustomerList.CustomerID  "
            SQL &=  " LEFT OUTER JOIN Address ON Customer.AddressID=Address.AddressID  "
            'If pRefID > 0 Then
            SQL &=  "  where CustomerList.RefID=" & pRefID
            'End If
            'If pRefTableID > 0 Then
            SQL &=  "  AND CustomerList.RefTableID=" & pRefTableID
            'End If
            SQL &=  " AND CustomerList.IsDelete =" & pIsDelete
            SQL &=  " ORDER BY Customer.CustomerCode "
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "CustomerListDAO.GetDataTable : " & e.Message)
        End Try
        Return dataTable
    End Function



    Public Overrides Function SaveData(Optional ByRef ptr As SqlTransaction = Nothing) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand
        SQL = ""
        Try
            Select Case ModeData
                Case DataMode.ModeNew, DataMode.ModeEdit
                    SQL = " INSERT INTO CustomerList  (RefID,RefTableID,CustomerID,IsDelete )"
                    SQL &=  " VALUES ( @mRefID"
                    SQL &=  " ,  @mRefTable"
                    SQL &=  " ,  @mCustomerID"
                    SQL &=  " ,  0"
                    SQL &=  " ) "
                Case DataMode.ModeDelete
                    SQL = "  Update CustomerList Set IsDelete=1 "
                    SQL &=  " WHERE RefTableID= @mRefTable"
                    SQL &=  " AND RefID= @mRefID"
                Case Else
                    Return False
                    Exit Function
            End Select
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@mRefID", RefID))
            myCommand.Parameters.Add(New SqlParameter("@mRefTable", RefTableID))
            myCommand.Parameters.Add(New SqlParameter("@mCustomerID", CustomerID))
            gConnection.executeInsertSqlCommand(myCommand, ptr)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "CustomerListDAO.SaveData : " & e.Message)
            Return False
        End Try
    End Function

    Public Function ClearOldData(ByVal tr As SqlTransaction) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand
        SQL = ""
        Try
            If RefID > 0 And RefTableID > 0 Then
                SQL = " Delete from  CustomerList  "
                SQL &=  " WHERE RefTableID= @mRefTable"
                SQL &=  " AND RefID= @mRefID"
                myCommand = New SqlCommand
                myCommand.CommandText = SQL
                myCommand.Parameters.Add(New SqlParameter("@mRefID", RefID))
                myCommand.Parameters.Add(New SqlParameter("@mRefTable", RefTableID))
                gConnection.executeInsertSqlCommand(myCommand, tr)
            End If

            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "CustomerListDAO.ClearOldData : " & e.Message)
            Return False
        End Try
    End Function


    Public Function DeleteAllData(ByVal tr As SqlTransaction) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand
        SQL = ""
        Try
            If RefID > 0 And RefTableID > 0 Then
                SQL = " Update CustomerList Set IsDelete=1 "
                SQL &=  " WHERE RefTableID= @mRefTable"
                SQL &=  " AND RefID= @mRefID"
                myCommand = New SqlCommand
                myCommand.CommandText = SQL
                myCommand.Parameters.Add(New SqlParameter("@mRefID", RefID))
                myCommand.Parameters.Add(New SqlParameter("@mRefTable", RefTableID))
                gConnection.executeInsertSqlCommand(myCommand, tr)
            End If

            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "CustomerListDAO.DeleteAllData : " & e.Message)
            Return False
        End Try
    End Function

End Class
