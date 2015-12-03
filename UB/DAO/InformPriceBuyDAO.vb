Option Explicit On
Imports System.Data.SqlClient
Public Class InformPriceBuyDAO
    Inherits iDAO
    Dim mPriceBuy As Decimal
    Private mProductTable As DataTable
    Private mProductDAOs As List(Of frmInformPriceBuy.InformPriceBuyDAOSub)

    Public ReadOnly Property TableName() As String
        Get
            Return "InformPriceBuy"
        End Get
    End Property
    Public Property PriceBuy() As Decimal
        Get
            Return mPriceBuy
        End Get
        Set(ByVal value As Decimal)
            mPriceBuy = value
        End Set

    End Property

    Public ReadOnly Property ProductTable() As DataTable
        Get
            Return mProductTable
        End Get
    End Property

    Public WriteOnly Property ProductDAOs() As List(Of frmInformPriceBuy.InformPriceBuyDAOSub)
        Set(ByVal Value As List(Of frmInformPriceBuy.InformPriceBuyDAOSub))
            mProductDAOs = Value
        End Set
    End Property

    Public Function CHECKSUM_AGG() As Long
        Dim SQL As String
        Dim dataTable As New DataTable()
        Try
            SQL = "SELECT CHECKSUM_AGG(BINARY_CHECKSUM(*))  "
            SQL = SQL & " FROM  InformPriceBuy"
            SQL = SQL & " WITH (NOLOCK);"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    Return ConvertNullToZero(dr(0))
                    Exit For
                Next
            End If
            Return 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "InformPriceBuyDAO.CHECKSUM_AGG : " & e.Message)
            Return 0
        Finally
            dataTable = Nothing
        End Try
    End Function

    Public Function GetDataTable(ByVal pID As Long) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT  ID ,Customer "
            SQL = SQL & " FROM ("
            SQL = SQL & " SELECT InformPrice.CustomerID AS ID "
            SQL = SQL & " ,CASE WHEN Customer.CompanyName <>'' THEN Customer.CompanyName ELSE Customer.Title + Customer.Firstname + ' ' + Customer.LastName END Customer "
            'SQL = SQL & " ,InformPrice.CreateTime AS ModifiedTime"
            SQL = SQL & " FROM InformPriceBuy as InformPrice  "
            SQL = SQL & " LEFT OUTER JOIN Customer ON InformPrice.CustomerID=Customer.CustomerID  "
            SQL = SQL & " WHERE InformPrice.IsDelete =0   "
            If pID > 0 Then
                SQL = SQL & "  AND InformPrice.CustomerID=" & pID
            End If
            SQL = SQL & "  ) AS A "
            SQL = SQL & " GROUP BY ID ,Customer "
            SQL = SQL & " ORDER BY Customer"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "InformPriceBuyDAO.GetDataTable : " & e.Message)
        End Try
        Return dataTable
    End Function

    Private Sub LoadData(ByVal pAccountID As Long, ByVal pProID As Long, Optional ByVal pProGroupID As Long = 0, Optional ByVal pProCategID As Long = 0 _
                                 , Optional ByVal pProTypeID As Long = 0, Optional ByVal pProBandID As Long = 0)
        Dim SQL As String = ""
        Dim dataTable As New DataTable()
        Try
            'mProductDAOs = Nothing
            'mProductDAOs = New List(Of frmInformPriceBuy.InformPriceBuyDAOSub)

            SQL = SQL & "SELECT  Inform.InformPriceID,Inform.ProductID,Inform.CreateTime,Inform.CreateBy"
            SQL = SQL & " ,Inform.ProductCode,Inform.ProductName,Inform.PriceStandard,Inform.Price1,Inform.Price2 "
            SQL = SQL & " ,Inform.Price3,Inform.PriceInform,Inform.PriceInform as PriceInformOld"
            SQL = SQL & " ,Inform.Discount,Inform.Discount as DiscountOld,sum(Stock.Units) as Unit    "
            SQL = SQL & " FROM ( "
            If pAccountID > 0 Then
                SQL = SQL & "SELECT  InformPrice.InformPriceID,Product.ProductID,InformPrice.CreateTime,InformPrice.CreateBy"
                SQL = SQL & " ,Product.ProductCode,Product.ProductName,Product.PriceStandard,Product.Price1,Product.Price2 "
                SQL = SQL & " ,Product.Price3,InformPrice.PriceInform,InformPrice.Discount   "
                SQL = SQL & " FROM InformPriceBuy as InformPrice "
                SQL = SQL & " LEFT OUTER JOIN Product ON Product.ProductID=InformPrice.ProductID "
                SQL = SQL & " WHERE InformPrice.IsDelete =0  AND InformPrice.CustomerID =" & pAccountID
                If pProID > 0 Then
                    SQL = SQL & " AND InformPrice.ProductID =" & pProID
                End If
                If pProGroupID > 0 Then
                    SQL = SQL & " AND Product.ProductGroupID =" & pProGroupID
                End If
                If pProCategID > 0 Then
                    SQL = SQL & " AND Product.ProductCategoryID =" & pProCategID
                End If
                If pProTypeID > 0 Then
                    SQL = SQL & " AND Product.ProductTypeID =" & pProTypeID
                End If
                If pProBandID > 0 Then
                    SQL = SQL & " AND Product.ProductBrandID =" & pProBandID
                End If
                SQL = SQL & " UNION ALL "
            End If
            SQL = SQL & " SELECT 0 as InformPriceID, Product.ProductID ,Product.CreateTime,Product.CreateBy"
            SQL = SQL & " ,Product.ProductCode,Product.ProductName,Product.PriceStandard,Product.Price1,Product.Price2 "
            SQL = SQL & " ,Product.Price3,0 AS PriceInform,0 AS Discount    "
            SQL = SQL & " FROM Product "
            SQL = SQL & " WHERE Product.IsDelete =0 "
            If pProID > 0 Then
                SQL = SQL & " AND Product.ProductID =" & pProID
            End If
            If pProGroupID > 0 Then
                SQL = SQL & " AND Product.ProductGroupID =" & pProGroupID
            End If
            If pProCategID > 0 Then
                SQL = SQL & " AND Product.ProductCategoryID =" & pProCategID
            End If
            If pProTypeID > 0 Then
                SQL = SQL & " AND Product.ProductTypeID =" & pProTypeID
            End If
            If pProBandID > 0 Then
                SQL = SQL & " AND Product.ProductBrandID =" & pProBandID
            End If
            If pAccountID > 0 Then
                SQL = SQL & " AND Product.ProductID NOT IN (SELECT ProductID FROM InformPriceBuy WHERE CustomerID=" & pAccountID & " )"
            End If
            SQL = SQL & " ) AS Inform"
            SQL = SQL & " LEFT OUTER JOIN Product_Stock Stock ON Stock.ProductID=Inform.ProductID and IsSumStock=1"

            SQL = SQL & " Group BY Inform.InformPriceID,Inform.ProductID,Inform.CreateTime,Inform.CreateBy,Inform.ProductCode,Inform.ProductName"
            SQL = SQL & " ,Inform.PriceStandard,Inform.Price1,Inform.Price2,Inform.Price3,Inform.PriceInform,Inform.Discount "
            SQL = SQL & " ORDER BY Inform.ProductCode,Inform.ProductName"

            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            mProductTable = dataTable
            If pProID > 0 Then
                If dataTable.Rows.Count > 0 Then
                    For Each dr As DataRow In dataTable.Rows
                        mPriceBuy = ConvertNullToZero(dr("PriceInform"))
                        Exit For
                    Next
                End If
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "InformPriceBuyDAO.LoadData : " & e.Message)
        End Try

    End Sub

    Public Function InitailData(ByVal pCusID As Long, ByVal pProID As Long, Optional ByVal tr As SqlTransaction = Nothing _
                               , Optional ByVal pProGroupID As Long = 0, Optional ByVal pProCategID As Long = 0 _
                                 , Optional ByVal pProTypeID As Long = 0, Optional ByVal pProBandID As Long = 0) As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()
        Dim lUserDAO As New UserDAO
        Try
            SQL = "SELECT *   "
            SQL = SQL & " FROM InformPriceBuy"
            SQL = SQL & " WHERE IsInActive = 0 AND CustomerID=" & pCusID

            dataTable = gConnection.executeSelectQuery(SQL, tr)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows

                    ID = Int32.Parse(dr("CustomerID"))
                    IsInActive = dr("IsInActive")
                    CreateTime = ConvertNullToDateTime(dr("CreateTime"))
                    If lUserDAO.InitailData(True, ConvertNullToZero(dr("CreateBy")), "", tr) Then
                        CreateBy = lUserDAO.UserName
                    Else
                        CreateBy = ""
                    End If
                    FileAttachs = LoadFileAttach(ID, TableName, tr)
                    'If pProID <= 0 Then
                    LoadData(ID, pProID, pProGroupID, pProCategID, pProTypeID, pProBandID)
                    'End If

                    Return True
                    Exit For
                Next
            Else
                LoadData(0, pProID, pProGroupID, pProCategID, pProTypeID, pProBandID)
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "InformPriceBuyDAO.InitailData : " & e.Message)
            Return False
        Finally
            lUserDAO = Nothing
            dataTable = Nothing
        End Try

    End Function

    Public Function SaveData() As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand
        Dim tr As SqlTransaction = Nothing

        SQL = ""
        Try
            If mProductDAOs.Count > 0 Then
                tr = gConnection.Connection.BeginTransaction
                Select Case ModeData

                    Case DataMode.ModeNew, DataMode.ModeEdit
                        For Each rec As InformPriceSubDAO In mProductDAOs
                            If ConvertNullToZero(rec.ProductID) > 0 Then
                                If ConvertNullToZero(rec.InformPriceID) = 0 Then
                                    SQL = " INSERT INTO InformPriceBuy (CustomerID,ProductID,PriceInform,Discount"
                                    SQL = SQL & " ,CreateBy,CreateTime,IsInActive,IsDelete "
                                    SQL = SQL & " )"
                                    SQL = SQL & " VALUES ( @mIDs"
                                    SQL = SQL & " ,  @ProductID"
                                    SQL = SQL & " ,  @PriceInform"
                                    SQL = SQL & " ,  @Discount"
                                    SQL = SQL & " ,  @gUserID"
                                    SQL = SQL & " ,  @CreateTime"
                                    SQL = SQL & " ,  @IsInActive"
                                    SQL = SQL & " ,  @IsDelete"
                                    SQL = SQL & " ) "
                                Else
                                    SQL = " Update InformPriceBuy "
                                    SQL = SQL & " Set PriceInform=@PriceInform"
                                    SQL = SQL & " , Discount=@Discount"
                                    SQL = SQL & " where InformPriceID=@InformPriceID"
                                End If
                               
                                myCommand = New SqlCommand
                                myCommand.CommandText = SQL
                                myCommand.Parameters.Add(New SqlParameter("@mIDs", ID))
                                myCommand.Parameters.Add(New SqlParameter("@InformPriceID ", ConvertNullToZero(rec.InformPriceID)))
                                myCommand.Parameters.Add(New SqlParameter("@ProductID", ConvertNullToZero(rec.ProductID)))
                                myCommand.Parameters.Add(New SqlParameter("@PriceInform", ConvertNullToZero(rec.PriceInform)))
                                myCommand.Parameters.Add(New SqlParameter("@Discount", ConvertNullToZero(rec.Discount)))
                                myCommand.Parameters.Add(New SqlParameter("@gUserID", gUserID))
                                myCommand.Parameters.Add(New SqlParameter("@CreateTime", formatSQLDateTime(GetCurrentDate(tr))))
                                myCommand.Parameters.Add(New SqlParameter("@IsInActive", IsInActive))
                                myCommand.Parameters.Add(New SqlParameter("@IsDelete", 0))
                                gConnection.executeInsertSqlCommand(myCommand, tr)
                            End If
                        Next



                    Case DataMode.ModeDelete
                        SQL = " DELETE FROM InformPriceBuy "
                        SQL = SQL & " WHERE CustomerID =" & ID
                        myCommand = New SqlCommand
                        myCommand.CommandText = SQL
                        gConnection.executeInsertSqlCommand(myCommand, tr)

                End Select

                SaveNote(NoteDAOs, ModeData, ID, TableName, tr)
                SaveAttachFile(FileAttachs, ModeData, ID, TableName, tr)

                tr.Commit()
                Return True
            End If
        Catch e As Exception
            tr.Rollback()
            Err.Raise(Err.Number, e.Source, "InformPriceBuyDAO.SaveData : " & e.Message)
            Return False
        End Try

    End Function

    Public Function CheckExist() As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT CustomerID  FROM InformPriceBuy"
            SQL = SQL & " WHERE IsDelete =0 AND CustomerID=" & ConvertNullToZero(ID)
            If ModeData = DataMode.ModeEdit Then
                SQL = SQL & " AND CustomerID <> " & ID
            End If
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            Return dataTable.Rows.Count > 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "InformPriceBuyDAO.CheckExist : " & e.Message)
            Return False
        Finally
            dataTable = Nothing
        End Try

    End Function

    Public Function CheckIsToUse() As Boolean ''ถูกใช้งานอยู่ ???

        Return False
    End Function

    Public Sub New()
        mProductDAOs = Nothing
        mPriceBuy = 0
    End Sub
End Class
