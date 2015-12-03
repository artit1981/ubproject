Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Module modUpdateData


    Public Sub MoveStockIn()
        'Dim lclsStockIn As New StockInDAO
        Dim dataTable As New DataTable()
        Dim pID As Long, Sql As String
        Dim tr As SqlTransaction = Nothing
        Dim myCommand As SqlCommand
        If XtraMessageBox.Show("ยืนยันการปรับปรุงข้อมูล", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
            Try

                ShowProgress(True, "Loading...")

                tr = gConnection.Connection.BeginTransaction


                Sql = "SELECT * "
                Sql = Sql & " FROM StockIn  "
                Sql = Sql & " ORDER BY OrderID "
                dataTable = gConnection.executeSelectQuery(Sql, tr)

                For Each pData As DataRow In dataTable.Rows
                    'lclsStockIn = New StockInDAO
                    'lclsStockIn.InitailData(Int32.Parse(pData("OrderID")), , tr)
                    pID = GenNewID("OrderID", "Orders", tr)
                    Sql = " INSERT INTO Orders  (OrderID,OrderCode,OrderDate,EmpID "
                    Sql = Sql & ",Remark,CreateBy,CreateTime,IsInActive,IsDelete,IsCancel,ImportTXID,TableID,ModifiedTime,ModifiedBy )"
                    Sql = Sql & " VALUES ( @IDs,  @OrderCode,  @OrderDate,  @EmpID,  @Remark,  @gUserID"
                    Sql = Sql & " ,@CreateTime,@IsInActive,@IsDelete,0, @ImportTXID ," & MasterType.StockIn
                    Sql = Sql & " ,@ModifiedTime,@ModifiedBy ) "
                    myCommand = New SqlCommand
                    myCommand.CommandText = Sql
                    myCommand.Parameters.Add(New SqlParameter("@IDs", pID))
                    myCommand.Parameters.Add(New SqlParameter("@OrderCode", ConvertNullToString(pData("OrderCode"))))
                    myCommand.Parameters.Add(New SqlParameter("@EmpID", ConvertNullToZero(pData("EmpID"))))
                    myCommand.Parameters.Add(New SqlParameter("@OrderDate", formatSQLDate(pData("OrderDate"))))
                    myCommand.Parameters.Add(New SqlParameter("@Remark", ConvertNullToString(pData("Remark"))))
                    myCommand.Parameters.Add(New SqlParameter("@gUserID", ConvertNullToZero(pData("CreateBy"))))
                    myCommand.Parameters.Add(New SqlParameter("@IsDelete", ConvertNullToZero(pData("IsDelete"))))
                    myCommand.Parameters.Add(New SqlParameter("@IsInActive", ConvertNullToZero(pData("IsInActive"))))
                    myCommand.Parameters.Add(New SqlParameter("@CreateTime", formatSQLDateTime(pData("CreateTime"))))
                    If IsDate(pData("ModifiedTime")) Then
                        myCommand.Parameters.Add(New SqlParameter("@ModifiedTime", formatSQLDateTime(pData("ModifiedTime"))))
                    Else
                        myCommand.Parameters.Add(New SqlParameter("@ModifiedTime", formatSQLDateTime(Now)))
                    End If
                    If IsNumeric(pData("ModifiedBy")) Then
                        myCommand.Parameters.Add(New SqlParameter("@ModifiedBy", ConvertNullToZero(pData("ModifiedBy"))))
                    Else
                        myCommand.Parameters.Add(New SqlParameter("@ModifiedBy", ConvertNullToZero(1)))
                    End If

                    myCommand.Parameters.Add(New SqlParameter("@ImportTXID", 0))

                    gConnection.executeInsertSqlCommand(myCommand, tr)

                    If ConvertNullToZero(pData("RefOrderID")) > 0 Then
                        Sql = " Insert into OrdersRef (OrderID,RefOrderID,IsDelete) values( " & pID & "," & ConvertNullToZero(pData("RefOrderID")) & ",0)"
                        myCommand = New SqlCommand
                        myCommand.CommandText = Sql
                        gConnection.executeInsertSqlCommand(myCommand, tr)
                    End If

                    Sql = " Update Note set RefID=" & pID & " where RefTable='StockIn' and  RefID=" & ConvertNullToZero(pData("OrderID"))
                    myCommand = New SqlCommand
                    myCommand.CommandText = Sql
                    gConnection.executeInsertSqlCommand(myCommand, tr)

                    Sql = " Update AttachFile set RefID=" & pID & " where RefTable='StockIn' and  RefID=" & ConvertNullToZero(pData("OrderID"))
                    myCommand = New SqlCommand
                    myCommand.CommandText = Sql
                    gConnection.executeInsertSqlCommand(myCommand, tr)

                    Sql = " Update ProductList set RefID=" & pID & " where RefTable='StockIn' and  RefID=" & ConvertNullToZero(pData("OrderID"))
                    myCommand = New SqlCommand
                    myCommand.CommandText = Sql
                    gConnection.executeInsertSqlCommand(myCommand, tr)
                Next

                'Dim lclsUpdate As New UpdateStockDAO
                Sql = "SELECT * "
                Sql = Sql & " FROM UpdateStock  "
                Sql = Sql & " ORDER BY OrderID "
                dataTable = Nothing
                dataTable = gConnection.executeSelectQuery(Sql, tr)
                For Each pData As DataRow In dataTable.Rows
                    'lclsUpdate = New UpdateStockDAO
                    'lclsUpdate.InitailData(Int32.Parse(pData("OrderID")), , tr)
                    pID = GenNewID("OrderID", "Orders", tr)
                    Sql = " INSERT INTO Orders  (OrderID,OrderCode,OrderDate,EmpID"
                    Sql = Sql & ",Remark,CreateBy,CreateTime,IsInActive,IsDelete,IsCancel ,TableID,ModifiedTime,ModifiedBy)  "
                    Sql = Sql & " VALUES ( @IDs"
                    Sql = Sql & " ,  @OrderCode"
                    Sql = Sql & " ,  @OrderDate"
                    Sql = Sql & " ,  @EmpID "
                    Sql = Sql & " ,  @Remark "
                    Sql = Sql & " ,  @gUserID"
                    Sql = Sql & " ,  @CreateTime"
                    Sql = Sql & ",@IsInActive,@IsDelete,0"
                    Sql = Sql & " ,  " & MasterType.UpdateStock
                    Sql = Sql & " ,@ModifiedTime,@ModifiedBy) "
                    myCommand = New SqlCommand
                    myCommand.CommandText = Sql
                    myCommand.Parameters.Add(New SqlParameter("@IDs", pID))
                    myCommand.Parameters.Add(New SqlParameter("@OrderCode", ConvertNullToString(pData("OrderCode"))))
                    myCommand.Parameters.Add(New SqlParameter("@EmpID", ConvertNullToZero(pData("EmpID"))))
                    myCommand.Parameters.Add(New SqlParameter("@OrderDate", formatSQLDate(pData("OrderDate"))))
                    myCommand.Parameters.Add(New SqlParameter("@Remark", ConvertNullToString(pData("Remark"))))
                    myCommand.Parameters.Add(New SqlParameter("@gUserID", ConvertNullToZero(pData("CreateBy"))))
                    myCommand.Parameters.Add(New SqlParameter("@IsDelete", ConvertNullToZero(pData("IsDelete"))))
                    myCommand.Parameters.Add(New SqlParameter("@IsInActive", ConvertNullToZero(pData("IsInActive"))))
                    myCommand.Parameters.Add(New SqlParameter("@CreateTime", formatSQLDateTime(pData("CreateTime"))))
                    If IsDate(pData("ModifiedTime")) Then
                        myCommand.Parameters.Add(New SqlParameter("@ModifiedTime", formatSQLDateTime(pData("ModifiedTime"))))
                    Else
                        myCommand.Parameters.Add(New SqlParameter("@ModifiedTime", formatSQLDateTime(Now)))
                    End If
                    If IsNumeric(pData("ModifiedBy")) Then
                        myCommand.Parameters.Add(New SqlParameter("@ModifiedBy", ConvertNullToZero(pData("ModifiedBy"))))
                    Else
                        myCommand.Parameters.Add(New SqlParameter("@ModifiedBy", ConvertNullToZero(1)))
                    End If

                    gConnection.executeInsertSqlCommand(myCommand, tr)

                    Sql = " Update Note set RefID=" & pID & " where RefTable='UpdateStock' and  RefID=" & ConvertNullToZero(pData("OrderID"))
                    myCommand = New SqlCommand
                    myCommand.CommandText = Sql
                    gConnection.executeInsertSqlCommand(myCommand, tr)

                    Sql = " Update AttachFile set RefID=" & pID & " where RefTable='UpdateStock' and  RefID=" & ConvertNullToZero(pData("OrderID"))
                    myCommand = New SqlCommand
                    myCommand.CommandText = Sql
                    gConnection.executeInsertSqlCommand(myCommand, tr)

                    Sql = " Update ProductList set RefID=" & pID & " where RefTable='UpdateStock' and  RefID=" & ConvertNullToZero(pData("OrderID"))
                    myCommand = New SqlCommand
                    myCommand.CommandText = Sql
                    gConnection.executeInsertSqlCommand(myCommand, tr)
                Next



                Sql = "SELECT OrderID,RefToOrderID "
                Sql = Sql & " FROM Orders where RefToOrderID>0  "
                Sql = Sql & " ORDER BY RefToOrderID,OrderID "
                dataTable = Nothing
                dataTable = gConnection.executeSelectQuery(Sql, tr)
                For Each pData As DataRow In dataTable.Rows
                    If ConvertNullToZero(pData("RefToOrderID")) > 0 Then
                        Sql = " Insert into OrdersRef (OrderID,RefOrderID,IsDelete) values( " & ConvertNullToZero(pData("RefToOrderID")) & "," & ConvertNullToZero(pData("OrderID")) & ",0)"
                        myCommand = New SqlCommand
                        myCommand.CommandText = Sql
                        gConnection.executeInsertSqlCommand(myCommand, tr)
                    End If
                Next

                tr.Commit()
                MessageBox.Show("Success")
            Catch e As Exception
                tr.Rollback()
                Err.Raise(Err.Number, e.Source, "modUpdateDate.MoveStockIn : " & e.Message)
            Finally
                'lclsStockIn = Nothing
                ShowProgress(False, "")
                dataTable = Nothing
            End Try
        End If
    End Sub


End Module
