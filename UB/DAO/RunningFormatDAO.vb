Option Explicit On
Imports System.Data.SqlClient
Public Class RunningFormatDAO
    Inherits iDAO



#Region "Property"
    Dim mSystem As String
    Dim mMenuDisplay As String
    Dim mModule As String
    Dim mFormatFront As String
    Dim mFormatDate As String
    Dim mFormatMidle As String
    Dim mRunningCount As Integer
    Dim mFormatYear As String
    Dim mLastNo As Long
    Dim mLocationDTLID As Long
    Dim mIsReset As Boolean

    Public Property LastNo() As Long
        Get
            Return mLastNo
        End Get
        Set(ByVal value As Long)
            mLastNo = value
        End Set
    End Property


    Public Property FormatYear() As String
        Get
            Return mFormatYear
        End Get
        Set(ByVal value As String)
            mFormatYear = value
        End Set
    End Property

    Public Property RunningCount() As Integer
        Get
            Return mRunningCount
        End Get
        Set(ByVal value As Integer)
            mRunningCount = value
        End Set
    End Property

    Public Property FormatMidle() As String
        Get
            Return mFormatMidle
        End Get
        Set(ByVal value As String)
            mFormatMidle = value
        End Set
    End Property

    Public Property FormatDate() As String
        Get
            Return mFormatDate
        End Get
        Set(ByVal value As String)
            mFormatDate = value
        End Set
    End Property


    Public Property FormatFront() As String
        Get
            Return mFormatFront
        End Get
        Set(ByVal value As String)
            mFormatFront = value
        End Set
    End Property

    Public Property MenuDisplay() As String
        Get
            Return mMenuDisplay
        End Get
        Set(ByVal value As String)
            mMenuDisplay = value
        End Set
    End Property

    Public Property Modules() As String
        Get
            Return mModule
        End Get
        Set(ByVal value As String)
            mModule = value
        End Set
    End Property

    Public Property System() As String
        Get
            Return mSystem
        End Get
        Set(ByVal value As String)
            mSystem = value
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

    Public Property IsReset() As Boolean
        Get
            Return mIsReset
        End Get
        Set(ByVal value As Boolean)
            mIsReset = value
        End Set
    End Property

#End Region

    Private ReadOnly Property TableName() As String
        Get
            Return "RunningFormat"
        End Get
    End Property

    Public Function GenerateCode(ByRef tr As SqlTransaction) As String
        Dim lstrExam As String = "", lRunCount As String = "", lLastCount As Long
        Try
            If FormatFront <> "None" Then
                lstrExam = FormatFront
            End If
            If FormatDate <> "None" Then
                FormatDate = Replace(FormatDate, "mm", "MM")
                If FormatYear = "TH" Then
                    lstrExam = lstrExam & Now.ToString(FormatDate, cTH)
                Else
                    lstrExam = lstrExam & Now.ToString(FormatDate, cEN)
                End If

            End If
            If FormatMidle <> "None" Then
                lstrExam = lstrExam & FormatMidle
            End If

            For i = 1 To RunningCount
                lRunCount = lRunCount & "0"
            Next

            'Get Last no
            lLastCount = GetLastNo(tr, ID)

            lLastCount = lLastCount + 1
            lstrExam = lstrExam & lLastCount.ToString(lRunCount)

            Return lstrExam
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "RunningFormatDAO.DisplayExam : " & ex.Message)
            Return False
        Finally
        End Try
    End Function

    Private Function GetLastNo(ByRef tr As SqlTransaction, ByVal pTableID As Long) As Long
        Dim SQL As String = ""
        Dim dataTable As New DataTable()
        Dim lTableID As MasterType = 0

        lTableID = pTableID
        Try

            'Get Last no
            Select Case lTableID
                Case MasterType.SellOrders, MasterType.Shiping, MasterType.Reserve, MasterType.Invoice, MasterType.InvoiceOnline, MasterType.Bill, MasterType.AddCredit _
                    , MasterType.Receipt, MasterType.ReduceCredit, MasterType.Claim, MasterType.Quotation, MasterType.PurchaseOrder _
                    , MasterType.Asset, MasterType.InvoiceBuy, MasterType.AddCreditBuy, MasterType.ReduceCreditBuy, MasterType.ClaimOut _
                    , MasterType.ReceiptBuy, MasterType.ShipingBuy, MasterType.Borrow, MasterType.ClaimOut, MasterType.StockIn, MasterType.UpdateStock _
                    , MasterType.ReceiptCut, MasterType.Expose, MasterType.CancelPO, MasterType.Quotation2, MasterType.ClaimResult, MasterType.ClaimReturn
                    SQL = " select top 2 right(OrderCode ," & RunningCount & ") AS ID"
                    SQL &=  " FROM Orders"
                    SQL &=  " WHERE IsDelete=0 and TableID=" & pTableID
                    SQL &=  " order by year(OrderDate) desc, right(OrderCode ," & RunningCount & ") Desc"
                Case MasterType.Employee
                    SQL = " select  right(EmpCode ," & RunningCount & ") AS ID"
                    SQL &=  " FROM Employee"
                    SQL &=  " WHERE  IsDelete=0 "
                    SQL &=  " order by right(EmpCode ," & RunningCount & ") Desc"
                Case MasterType.Product
                    SQL = " select  right(ProductCode ," & RunningCount & ") AS ID"
                    SQL &=  " FROM Product"
                    SQL &=  " WHERE  IsDelete=0 "
                    SQL &=  " order by right(ProductCode ," & RunningCount & ") Desc"
                Case MasterType.Lead, MasterType.Accounts, MasterType.Contacts, MasterType.Agency
                    SQL = " select  right(CustomerCode ," & RunningCount & ") AS ID"
                    SQL &=  " FROM Customer"
                    SQL &=  " WHERE  IsDelete=0 and CustomerType='" & lTableID.ToString & "'"
                    SQL &=  " order by right(CustomerCode ," & RunningCount & ") Desc"
                Case MasterType.TaxNumber
                    SQL = " select top 2 right(TaxNumber ," & RunningCount & ") AS ID"
                    SQL &=  " FROM Orders"
                    SQL &=  " WHERE IsDelete=0 and TaxNumber <> ''"
                    SQL &=  " order by OrderDate desc, right(TaxNumber ," & RunningCount & ") Desc"
            End Select

            If IsReset = True Then
                Return 0
            ElseIf SQL = "" Then
                Return 0
            Else
                dataTable = gConnection.executeSelectQuery(SQL, tr)
                If dataTable.Rows.Count > 0 Then
                    For Each dr As DataRow In dataTable.Rows
                        If IsNumeric(dr("ID")) Then
                            Return Int32.Parse(dr("ID"))
                        Else
                            Return 0
                        End If

                        Exit For
                    Next
                End If
            End If

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "RunningFormatDAO.GetLastNo : " & ex.Message)
            Return False
        Finally
        End Try

    End Function
    Public Function CHECKSUM_AGG() As Long
        Dim SQL As String
        Dim dataTable As New DataTable()
        Try
            SQL = "SELECT CHECKSUM_AGG(BINARY_CHECKSUM(*))  "
            SQL &=  " FROM  " & TableName
            SQL &=  " WITH (NOLOCK);"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    Return ConvertNullToZero(dr(0))
                    Exit For
                Next
            End If
            Return 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "RunningFormatDAO.CHECKSUM_AGG : " & e.Message)
            Return 0
        Finally
            dataTable = Nothing
        End Try
    End Function


    Public Function InitailData(ByVal pID As Long, ByRef tr As SqlTransaction) As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()
        Dim lUserDAO As New UserDAO
        Try
            SQL = "SELECT *   "
            SQL &=  " FROM " & TableName
            SQL &=  " WHERE MenuID=" & pID
            dataTable = gConnection.executeSelectQuery(SQL, tr)
            If dataTable.Rows.Count = 0 Then

            Else
                For Each dr As DataRow In dataTable.Rows
                    ID = Int32.Parse(dr("MenuID"))
                    System = ConvertNullToString(dr("System"))
                    Modules = ConvertNullToString(dr("Module"))
                    MenuDisplay = ConvertNullToString(dr("MenuDisplay"))
                    MenuDisplay = ConvertNullToString(dr("MenuDisplay"))
                    FormatFront = ConvertNullToString(dr("FormatFront"))
                    FormatDate = ConvertNullToString(dr("FormatDate"))
                    FormatMidle = ConvertNullToString(dr("FormatMidle"))
                    FormatYear = ConvertNullToString(dr("FormatYear"))
                    RunningCount = ConvertNullToZero(dr("RunningCount"))
                    LocationDTLID = ConvertNullToZero(dr("LocationDTLID"))
                    IsReset = ConvertNullToZero(dr("IsReset"))
                    LastNo = GetLastNo(tr, ID)
                    CreateBy = ""
                    CreateTime = ""
                    ModifiedTime = ConvertNullToDateTime(dr("ModifiedTime"))
                    If tr Is Nothing Then
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
            Err.Raise(Err.Number, e.Source, "RunningFormatDAO.InitailData : " & e.Message)
            Return False
        Finally
            lUserDAO = Nothing
            dataTable = Nothing
        End Try

    End Function


    Public Function GetDataTable() As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT MenuID AS ID, System ,MenuDisplay"
            SQL &=  " FROM RunningFormat  "
            SQL &=  " ORDER BY  System ,MenuDisplay"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "RunningFormatDAO.GetDataTable : " & e.Message)
        End Try
        Return dataTable

    End Function


    Public Function SaveData(ByVal tr As SqlTransaction) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand

        SQL = ""
        Try
            Select Case ModeData

                Case DataMode.ModeEdit
                    SQL = " UPDATE RunningFormat SET "
                    SQL &=  " FormatFront=@FormatFront"
                    SQL &=  " ,FormatDate=@FormatDate"
                    SQL &=  " ,FormatMidle=@FormatMidle"
                    SQL &=  " ,RunningCount=@RunningCount"
                    SQL &=  " ,FormatYear= @FormatYear"
                    SQL &=  " ,IsReset= " & IIf(IsReset = True, 1, 0)
                    SQL &=  " ,LocationDTLID= @LocationDTLID"
                    SQL &=  " ,ModifiedBy= @gUserID"
                    SQL &=  " ,ModifiedTime= @CreateTime"
                    SQL &=  " WHERE MenuID= @mIDs"
                Case DataMode.ModeDelete
            End Select
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@mIDs", ID))
            myCommand.Parameters.Add(New SqlParameter("@FormatFront", Trim(FormatFront)))
            myCommand.Parameters.Add(New SqlParameter("@FormatDate", Trim(FormatDate)))
            myCommand.Parameters.Add(New SqlParameter("@FormatMidle", Trim(FormatMidle)))
            myCommand.Parameters.Add(New SqlParameter("@FormatYear", Trim(FormatYear)))
            myCommand.Parameters.Add(New SqlParameter("@RunningCount", ConvertNullToZero(RunningCount)))
            myCommand.Parameters.Add(New SqlParameter("@LastNo", ConvertNullToZero(LastNo)))
            myCommand.Parameters.Add(New SqlParameter("@LocationDTLID", ConvertNullToZero(LocationDTLID)))
            myCommand.Parameters.Add(New SqlParameter("@gUserID", gUserID))
            myCommand.Parameters.Add(New SqlParameter("@CreateTime", formatSQLDateTime(GetCurrentDate(tr))))


            gConnection.executeInsertSqlCommand(myCommand, tr)

            'Save Note
            SaveNote(NoteDAOs, ModeData, ID, TableName, tr)


            Return True
        Catch e As Exception

            Err.Raise(Err.Number, e.Source, "RunningFormatDAO.SaveData : " & e.Message)
            Return False
        End Try

    End Function



    Public Function ResetFlag(ByVal tr As SqlTransaction) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand

        SQL = ""
        Try
            If IsReset = True And ID > 0 Then

                SQL = " UPDATE RunningFormat SET "
                SQL &=  " IsReset=0"
                SQL &=  " WHERE MenuID= " & ID
                myCommand = New SqlCommand
                myCommand.CommandText = SQL
                gConnection.executeInsertSqlCommand(myCommand, tr)
            End If


            Return True
        Catch e As Exception

            Err.Raise(Err.Number, e.Source, "RunningFormatDAO.ResetFlag : " & e.Message)
            Return False
        End Try

    End Function

    Public Sub New()
        mSystem = ""
        mMenuDisplay = ""
        mModule = ""
        mFormatFront = ""
        mFormatDate = ""
        mFormatMidle = ""
        mRunningCount = 0
        mFormatYear = ""
        mLastNo = 0
        mLocationDTLID = 0
        mIsReset = False
    End Sub
End Class
