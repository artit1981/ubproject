Option Explicit On
Imports System.Data.SqlClient
Public Class UpdateStockDAO
    Inherits iOrder
#Region "Property"



    Public Overrides ReadOnly Property TableName() As String
        Get
            Return "UpdateStock"
        End Get
    End Property

 

#End Region

    Public Function CHECKSUM_AGG() As Long
        Dim SQL As String
        Dim dataTable As New DataTable()
        Try
            SQL = "SELECT CHECKSUM_AGG(BINARY_CHECKSUM(*)) FROM Orders WITH (NOLOCK);"

            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    Return ConvertNullToZero(dr(0))
                    Exit For
                Next
            End If
            Return 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "UpdateStock.CHECKSUM_AGG : " & e.Message)
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
            SQL = SQL & " FROM Orders "
            SQL = SQL & " WHERE OrderID=" & pID
            SQL = SQL & " ORDER BY OrderCode"
            dataTable = gConnection.executeSelectQuery(SQL, tr)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows

                    Code = dr("OrderCode").ToString
                    EmpID = ConvertNullToZero(dr("EmpID"))
                    'RefOrderID = ConvertNullToZero(dr("RefOrderID"))
                    'LocationDTLID = ConvertNullToZero(dr("LocationDTLID"))
                    If IsDBNull(dr("OrderDate")) Then
                        OrderDate = GetCurrentDate(tr)
                    Else
                        OrderDate = dr("OrderDate")
                    End If
                    Remark = ConvertNullToString(dr("Remark"))
                     
                    'Person
                    ID = Int32.Parse(dr("OrderID"))
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

                    FileAttachs = LoadFileAttach(ID, TableName, tr)

                    Return True
                    Exit For
                Next 
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "UpdateStock.InitailData : " & e.Message)
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
        '    Err.Raise(Err.Number, e.Source, "UpdateStock.GetInfoHtml : " & e.Message)

        'End Try
        Return Info
    End Function


    Public Function GetDataTable(ByVal pID As Long, ByVal pOnlyActive As Boolean, Optional ByVal pOtherCondition As String = "", Optional ByRef ptr As SqlTransaction = Nothing) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()
        Try
            SQL = "SELECT Orders.OrderID AS ID,Orders.OrderCode AS Code,Orders.OrderDate,'' as LocationDTL" 'Product_LocationDTL.NameThai as LocationDTL   "
            SQL = SQL & " ,Employee.Title + Employee.Firstname + ' ' + Employee.LastName AS EMPNAME,Orders.ModifiedTime,Orders.Remark"
            SQL = SQL & " FROM Orders  "
            SQL = SQL & " LEFT OUTER JOIN Employee ON Orders.EmpID=Employee.EmpID  "
            'SQL = SQL & " LEFT OUTER JOIN Product_LocationDTL ON Orders.LocationDTLID=Product_LocationDTL.LocationDTLID  "
            SQL = SQL & " WHERE Orders.TableID=" & MasterType.UpdateStock
            If pID > 0 Then
                SQL = SQL & "  AND Orders.OrderID=" & pID
            End If
            If pOnlyActive = True Then
                SQL = SQL & "  and Orders.IsDelete =0   "
            End If
            If pOtherCondition <> "" Then
                SQL = SQL & pOtherCondition
            End If
            SQL = SQL & " ORDER BY Orders.OrderCode"
            dataTable = gConnection.executeSelectQuery(SQL, ptr)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "UpdateStock.GetDataTable : " & e.Message)
        End Try
        Return dataTable
    End Function


    Public Overrides Function SaveData(Optional ByRef ptr As SqlTransaction = Nothing) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand
        Dim tr As SqlTransaction = Nothing
        Dim lProInList As String = ""
        SQL = ""
        Try
            If ptr Is Nothing Then
                tr = gConnection.Connection.BeginTransaction
            Else
                tr = ptr
            End If

            Select Case ModeData
                Case DataMode.ModeNew
                    EmpID = gEmpID
                    ID = GenNewID("OrderID", "Orders", tr)
                    SQL = " INSERT INTO Orders  (OrderID,OrderCode,OrderDate,EmpID"
                    SQL = SQL & ",Remark,CreateBy,CreateTime,IsInActive,IsDelete,TableID" ',LocationDTLID  "
                    SQL = SQL & " )"
                    SQL = SQL & " VALUES ( @IDs"
                    SQL = SQL & " ,  @OrderCode"
                    SQL = SQL & " ,  @OrderDate"
                    SQL = SQL & " ,  @EmpID "
                    SQL = SQL & " ,  @Remark "
                    SQL = SQL & " ,  @gUserID"
                    SQL = SQL & " ,  @CreateTime"
                    SQL = SQL & " ,  @IsInActive"
                    SQL = SQL & " ,  @IsDelete"
                    SQL = SQL & ",   " & MasterType.UpdateStock
                    'SQL = SQL & " ,  @LocationDTLID"

                    SQL = SQL & " ) "
                Case DataMode.ModeEdit
                    SQL = " UPDATE Orders SET "
                    SQL = SQL & " EmpID=@EmpID"
                    SQL = SQL & " ,Remark=@Remark "
                    SQL = SQL & " ,ModifiedBy= @gUserID"
                    SQL = SQL & " ,ModifiedTime= @CreateTime"
                    SQL = SQL & " ,IsInActive= @IsInActive"
                    SQL = SQL & " WHERE OrderID= @IDs"
                Case DataMode.ModeDelete
                    SQL = " UPDATE Orders SET IsDelete=@IsDelete "
                    SQL = SQL & " ,ModifiedBy= @gUserID"
                    SQL = SQL & " ,ModifiedTime= @CreateTime"
                    SQL = SQL & " WHERE OrderID= @IDs"
            End Select
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@IDs", ID))
            myCommand.Parameters.Add(New SqlParameter("@OrderCode", Trim(Code)))
            myCommand.Parameters.Add(New SqlParameter("@EmpID", ConvertNullToZero(EmpID)))
            'myCommand.Parameters.Add(New SqlParameter("@LocationDTLID", ConvertNullToZero(LocationDTLID)))
            myCommand.Parameters.Add(New SqlParameter("@OrderDate", formatSQLDate(OrderDate)))
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

            SaveNote(NoteDAOs, ModeData, ID, TableName, tr)
            SaveAttachFile(FileAttachs, ModeData, ID, TableName, tr)

            'Update Stock +
            'Initial ALL List
            If ProductDAOs Is Nothing OrElse ProductDAOs.Count = 0 Then
                BuildProductList(ID, TableName, tr)
            End If

            Dim lclsStock As ProductStockDAO
            Dim lclsStock_Old As ProductStockDAO

            If ProductDAOs Is Nothing Then
            ElseIf ProductDAOs.Count = 0 Then
            Else
                For Each ProductList As ProductListDAO In ProductDAOs
                    lclsStock = New ProductStockDAO
                    lclsStock.ProductID = ProductList.ProductID
                    lclsStock.UnitID = ProductList.UnitID
                    lclsStock.LocationDTLID = ProductList.LocationDTLID
                    lclsStock.Cost = ProductList.Cost

                    If ModeData = DataMode.ModeDelete Then
                        lclsStock.Units = ProductList.Units * -1
                    ElseIf ProductList.ID = 0 Then
                        lclsStock.Units = ProductList.Units * 1
                    ElseIf ProductList.ID > 0 Then
                        'if change location in mode edit
                        If ProductList.LocationDTLID <> ProductList.LocationDTLID_Old Then
                            'Remove unit from old location stock
                            lclsStock_Old = New ProductStockDAO
                            lclsStock_Old.ProductID = ProductList.ProductID
                            lclsStock_Old.UnitID = ProductList.UnitID
                            lclsStock_Old.LocationDTLID = ProductList.LocationDTLID_Old
                            lclsStock_Old.Cost = ProductList.Cost
                            lclsStock_Old.Units = ProductList.Units_Old * -1
                            lclsStock_Old.SaveData(tr, False, False, ID, Code)
                            lclsStock_Old.SaveData(tr, True, False, ID, Code)

                            'Add new unit to new location
                            lclsStock.Units = ProductList.Units
                        Else
                            If ProductList.Units = ProductList.Units_Old Then
                                lclsStock.Units = 0
                            Else
                                lclsStock.Units = (ProductList.Units - ProductList.Units_Old)
                            End If
                        End If
                    End If
                    If ModeData = DataMode.ModeEdit Then
                        'Build prolist
                        If ProductList.ID > 0 Then
                            lProInList = IIf(lProInList = "", ProductList.ID, lProInList & "," & ProductList.ID)
                        End If
                    End If

                    'If ModeData = DataMode.ModeNew Then
                    '    lcls.Units = ProductList.Units * 1
                    'ElseIf ModeData = DataMode.ModeEdit Then
                    '    lcls.Units = ProductList.Units * 1
                    '    'Build prolist
                    '    If ProductList.ID > 0 Then
                    '        lProInList = IIf(lProInList = "", ProductList.ID, lProInList & "," & ProductList.ID)
                    '    End If
                    '    If ProductList.Units = ProductList.Units_Old Then
                    '        lcls.Units = 0
                    '    Else
                    '        lcls.Units = (ProductList.Units - ProductList.Units_Old)
                    '    End If
                    'Else
                    '    lcls.Units = ProductList.Units * -1
                    'End If


                    lclsStock.SaveData(tr, False, False, ID, Code)
                    lclsStock.SaveData(tr, True, False, ID, Code)
                Next
                If lProInList <> "" Then
                    'Update for delete row
                    Dim lclsProlist As New ProductListDAO
                    Dim dataTable As New DataTable()
                    dataTable = lclsProlist.GetDataTable(ID, TableName, tr, False, lProInList)

                    For Each dr As DataRow In dataTable.Rows
                        lclsStock = New ProductStockDAO
                        lclsStock.ProductID = ConvertNullToZero(dr("ProductID"))
                        lclsStock.UnitID = ConvertNullToZero(dr("UnitID"))
                        lclsStock.LocationDTLID = ConvertNullToZero(dr("LocationDTLID"))
                        lclsStock.Units = ConvertNullToZero(dr("Units")) * -1

                        lclsStock.SaveData(tr, False, False, ID, Code)
                        lclsStock.SaveData(tr, True, False, ID, Code)
                    Next
                End If
            End If
            If ModeData <> DataMode.ModeDelete Then
                SaveProductList(ProductDAOs, ModeData, ID, TableName, tr)
            End If

            If ModeData = DataMode.ModeNew Then
                UpdateLastID(MasterType.UpdateStock, tr)
            End If
            InsertActivity(ModeData, MasterType.UpdateStock, Code, tr)
            If ptr Is Nothing Then tr.Commit()

            Return True
        Catch e As Exception
            If ptr Is Nothing Then tr.Rollback()
            Err.Raise(Err.Number, e.Source, "UpdateStock.SaveData : " & e.Message)
            Return False
        End Try

    End Function

    Private Sub BuildProductList(ByVal pRefID As Long, ByVal pRefTable As String, ByRef ptr As SqlTransaction)
        Dim lcls As New ProductListDAO
        Dim dataTable As New DataTable()

        Try
            ProductDAOs = New List(Of ProductListDAO)
            dataTable = lcls.GetDataTable(pRefID, pRefTable, ptr, False, "")
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    Dim rec As New ProductListDAO
                    rec.ID = dr("ID")
                    rec.SEQ = ConvertNullToZero(dr("SEQ"))
                    rec.ProductID = ConvertNullToZero(dr("ProductID"))
                    rec.ProductName = ConvertNullToString(dr("ProductName"))
                    rec.ProductNameExt = ConvertNullToString(dr("ProductNameExt"))
                    rec.LocationDTLID = ConvertNullToZero(dr("LocationDTLID"))
                    rec.UnitID = ConvertNullToZero(dr("UnitID"))
                    rec.Remark = ConvertNullToString(dr("Remark"))
                    rec.KeepMin = ConvertNullToZero(dr("KeepMin"))
                    rec.Units = ConvertNullToZero(dr("Units"))
                    rec.Price = ConvertNullToZero(dr("Price"))
                    rec.Cost = ConvertNullToZero(dr("Cost"))
                    rec.Discount = ConvertNullToZero(dr("Discount"))
                    rec.Total = ConvertNullToZero(dr("Total"))
                    ProductDAOs.Add(rec)
                Next
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "OrderSDAO.BuildProductList : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub

    Public Overrides Function CheckExist() As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT OrderID  FROM Orders"
            SQL = SQL & " WHERE IsDelete =0 AND OrderCode='" & Trim(Code) & "'"
            If ModeData = DataMode.ModeEdit Then
                SQL = SQL & " AND OrderID <> " & ID
            End If
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            Return dataTable.Rows.Count > 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "UpdateStock.CheckExist : " & e.Message)
            Return False
        Finally
            dataTable = Nothing
        End Try

    End Function

    Public Function CheckNotExist() As Boolean ''ถูกใช้งานอยู่ ???

        'Dim SQL As String
        'Dim dataTable As New DataTable()

        Try
            'SQL = "SELECT LeadID  FROM Lead"
            'SQL = SQL & " WHERE IsDelete =0 AND Subject='" & Trim(mSubject) & "'"
            'If mMode = DataMode.ModeEdit Then
            '    SQL = SQL & " AND LeadID <> " & mIDs
            'End If
            'dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            'Return dataTable.Rows.Count > 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "UpdateStock.CheckNotExist : " & e.Message)
        End Try
        Return False
    End Function
     
    Public Sub New()

    End Sub
End Class
