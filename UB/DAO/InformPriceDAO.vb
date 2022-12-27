Option Explicit On
Imports System.Data.SqlClient
Public Class InformPriceDAO
    Inherits iDAO
    Dim mPriceSale As Decimal
    Private mInformPriceDAOs As List(Of InformPriceSubDAO)
    Private mProductTable As DataTable

    Public ReadOnly Property TableName() As String
        Get
            Return "InformPrice"
        End Get
    End Property
    Public Property PriceSale() As Decimal
        Get
            Return mPriceSale
        End Get
        Set(ByVal value As Decimal)
            mPriceSale = value
        End Set

    End Property

    Public ReadOnly Property ProductTable() As DataTable
        Get
            Return mProductTable
        End Get
    End Property

    Public WriteOnly Property InformPriceDAOs() As List(Of InformPriceSubDAO)
        Set(ByVal Value As List(Of InformPriceSubDAO))
            mInformPriceDAOs = Value
        End Set
    End Property

    Public Function CHECKSUM_AGG() As Long
        Dim SQL As String
        Dim dataTable As New DataTable()
        Try
            SQL = "SELECT CHECKSUM_AGG(BINARY_CHECKSUM(*))  "
            SQL &=  " FROM  InformPrice"
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
            Err.Raise(Err.Number, e.Source, "InformPriceDAO.CHECKSUM_AGG : " & e.Message)
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
            SQL &=  " FROM ("
            SQL &=  " SELECT InformPrice.CustomerID AS ID "
            SQL &=  " ,CASE WHEN Customer.CompanyName <>'' THEN Customer.CompanyName ELSE Customer.Title + Customer.Firstname + ' ' + Customer.LastName END Customer "
            SQL &=  " ,InformPrice.CreateTime AS ModifiedTime"
            SQL &=  " FROM InformPrice  "
            SQL &=  " LEFT OUTER JOIN Customer ON InformPrice.CustomerID=Customer.CustomerID  "
            SQL &=  " WHERE InformPrice.IsDelete =0   "
            If pID > 0 Then
                SQL &=  "  AND InformPrice.CustomerID=" & pID
            End If
            SQL &=  "  ) AS A "
            SQL &=  " GROUP BY ID ,Customer "
            SQL &=  " ORDER BY Customer"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "InformPriceDAO.GetDataTable : " & e.Message)
        End Try
        Return dataTable
    End Function

    Private Sub LoadData(ByVal pAccountID As Long, ByVal pProID As Long, Optional ByVal pProGroupID As Long = 0, Optional ByVal pProCategID As Long = 0 _
                                 , Optional ByVal pProTypeID As Long = 0, Optional ByVal pProBandID As Long = 0)
        Dim SQL As String = ""
        Dim dataTable As New DataTable()

        Try

            SQL &=  "SELECT 0 as IsSelect, Inform.InformPriceID,Inform.ProductID,Inform.CreateTime,Inform.CreateBy"
            SQL &=  " ,Inform.ProductCode,Inform.ProductName,Inform.CostAdjust,Inform.PriceInform,Inform.PriceInform as PriceInformOld,sum(Stock.Units) as Unit"
            SQL &= " ,Inform.PriceStandard,Inform.Price1,Inform.Price2,Inform.Price3 ,Inform.Price4 ,Inform.Price5 ,Inform.Price6,Inform.PriceOnline  "
            SQL &=  " ,Inform.ProductRemark "
            SQL &=  " FROM ( "
            If pAccountID > 0 Then
                SQL &=  "SELECT  InformPrice.InformPriceID,InformPrice.ProductID,InformPrice.CreateTime,InformPrice.CreateBy"
                SQL &=  " ,Product.ProductCode,Product.ProductName ,InformPrice.PriceInform,InformPrice.CostAdjust,Product.Remark as ProductRemark   "
                SQL &= " ,Product.PriceStandard,Product.Price1,Product.Price2,Product.Price3 ,Product.Price4 ,Product.Price5 ,Product.Price6,InformPrice.PriceOnline  "
                SQL &=  " FROM InformPrice "
                SQL &=  " Inner join Product ON Product.ProductID=InformPrice.ProductID "
                SQL &=  " WHERE InformPrice.IsDelete =0 and Product.IsDelete =0  AND InformPrice.CustomerID =" & pAccountID
                If pProID > 0 Then
                    SQL &=  " AND InformPrice.ProductID =" & pProID
                End If
                If pProGroupID > 0 Then
                    SQL &=  " AND Product.ProductGroupID =" & pProGroupID
                End If
                If pProCategID > 0 Then
                    SQL &=  " AND Product.ProductCategoryID =" & pProCategID
                End If
                If pProTypeID > 0 Then
                    SQL &=  " AND Product.ProductTypeID =" & pProTypeID
                End If
                If pProBandID > 0 Then
                    SQL &=  " AND Product.ProductBrandID =" & pProBandID
                End If
                SQL &=  " UNION ALL "
            End If
            SQL &=  " SELECT  0 as InformPriceID,Product.ProductID ,Product.CreateTime,Product.CreateBy"
            SQL &=  " ,Product.ProductCode,Product.ProductName ,0 AS PriceInform,0 as CostAdjust,Product.Remark as ProductRemark "
            SQL &= " ,Product.PriceStandard,Product.Price1,Product.Price2,Product.Price3 ,Product.Price4 ,Product.Price5 ,Product.Price6 ,0 as PriceOnline "
            SQL &=  " FROM Product "
            SQL &=  " WHERE Product.IsDelete =0 "
            If pProID > 0 Then
                SQL &=  " AND Product.ProductID =" & pProID
            End If
            If pProGroupID > 0 Then
                SQL &=  " AND Product.ProductGroupID =" & pProGroupID
            End If
            If pProCategID > 0 Then
                SQL &=  " AND Product.ProductCategoryID =" & pProCategID
            End If
            If pProTypeID > 0 Then
                SQL &=  " AND Product.ProductTypeID =" & pProTypeID
            End If
            If pProBandID > 0 Then
                SQL &=  " AND Product.ProductBrandID =" & pProBandID
            End If
            If pAccountID > 0 Then
                SQL &=  " AND Product.ProductID NOT IN (SELECT ProductID FROM InformPrice WHERE CustomerID=" & pAccountID & " )"
            End If
            SQL &=  " ) AS Inform"
            SQL &=  " LEFT OUTER JOIN Product_Stock Stock ON Stock.ProductID=Inform.ProductID and IsSumStock=1"
            'SQL = SQL & " LEFT OUTER JOIN ( Select Campaign.CampaignID,Campaign.Subject,ProductList.ProductID,CustomerList.CustomerID "
            'SQL = SQL & "       from Campaign,ProductList,CustomerList"
            'SQL = SQL & "       where ProductList.RefID=Campaign.CampaignID and ProductList.IsDelete =0 and ProductList.RefTable='Campaign' "
            'SQL = SQL & "       CustomerList.RefID=Campaign.CampaignID and ProductList.IsDelete =0 and CustomerList.RefTableID= " & MasterType.Campaign
            'SQL = SQL & " "
            'SQL = SQL & "  ) CampaignID ON Campaign.ProductID=Inform.ProductID "
            'If pAccountID > 0 Then
            '    SQL &=  "       and Campaign.CustomerID=" & pAccountID
            'End If

            SQL &=  " Group BY Inform.InformPriceID,Inform.ProductID,Inform.CreateTime,Inform.CreateBy,Inform.ProductCode,Inform.ProductName"
            SQL &=  " ,Inform.PriceInform,Inform.ProductRemark"
            SQL &=  " ,Inform.CostAdjust"
            SQL &= " ,Inform.PriceStandard,Inform.Price1,Inform.Price2,Inform.Price3 ,Inform.Price4 ,Inform.Price5 ,Inform.Price6,Inform.PriceOnline  "
            SQL &=  " ORDER BY Inform.ProductCode,Inform.ProductName"

            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            mProductTable = dataTable
            If pProID > 0 Then
                If dataTable.Rows.Count > 0 Then
                    For Each dr As DataRow In dataTable.Rows
                        mPriceSale = ConvertNullToZero(dr("PriceInform"))
                        Exit For
                    Next
                End If
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "InformPriceDAO.LoadData : " & e.Message)
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
            SQL &=  " FROM " & TableName
            SQL &=  " WHERE IsInActive = 0 AND CustomerID=" & pCusID

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
            Err.Raise(Err.Number, e.Source, "InformPriceDAO.InitailData : " & e.Message)
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
            If mInformPriceDAOs.Count > 0 Then
                tr = gConnection.Connection.BeginTransaction
                Select Case ModeData
                    Case DataMode.ModeNew, DataMode.ModeEdit
                        For Each rec As InformPriceSubDAO In mInformPriceDAOs
                            If ConvertNullToZero(rec.ProductID) > 0 Then
                                If ConvertNullToZero(rec.InformPriceID) = 0 Then
                                    SQL = " INSERT INTO " & TableName & " (CustomerID,ProductID,PriceInform,CostAdjust"
                                    SQL &=  " ,CreateBy,CreateTime,IsInActive,IsDelete "
                                    SQL &=  " )"
                                    SQL &=  " VALUES ( @mIDs"
                                    SQL &=  " ,  @ProductID"
                                    SQL &=  " ,  @PriceInform"
                                    SQL &=  " ,  @CostAdjust"
                                    SQL &=  " ,  @gUserID"
                                    SQL &=  " ,  @CreateTime"
                                    SQL &=  " ,  @IsInActive"
                                    SQL &=  " ,  @IsDelete"
                                    SQL &=  " ) "
                                Else
                                    SQL = " Update " & TableName
                                    SQL &=  " Set PriceInform=@PriceInform"
                                    SQL &=  " , CostAdjust=@CostAdjust"
                                    SQL &=  " where InformPriceID=@InformPriceID"

                                End If

                                myCommand = New SqlCommand
                                myCommand.CommandText = SQL
                                myCommand.Parameters.Add(New SqlParameter("@mIDs", ID))
                                myCommand.Parameters.Add(New SqlParameter("@InformPriceID ", ConvertNullToZero(rec.InformPriceID)))
                                myCommand.Parameters.Add(New SqlParameter("@ProductID", ConvertNullToZero(rec.ProductID)))
                                myCommand.Parameters.Add(New SqlParameter("@PriceInform", ConvertNullToZero(rec.PriceInform)))
                                myCommand.Parameters.Add(New SqlParameter("@CostAdjust", ConvertNullToZero(rec.CostAdjust)))
                                myCommand.Parameters.Add(New SqlParameter("@gUserID", gUserID))
                                myCommand.Parameters.Add(New SqlParameter("@CreateTime", formatSQLDateTime(GetCurrentDate(tr))))
                                myCommand.Parameters.Add(New SqlParameter("@IsInActive", IsInActive))
                                myCommand.Parameters.Add(New SqlParameter("@IsDelete", 0))
                                gConnection.executeInsertSqlCommand(myCommand, tr)

                                'If ConvertNullToZero(rec.ProductID) > 0 Then
                                '    SQL = " Update Product"
                                '    SQL &=  " Set PriceStandard=" & ConvertNullToZero(rec.PriceStandard)
                                '    SQL &=  " , Price1=" & ConvertNullToZero(rec.Price1)
                                '    SQL &=  " , Price2=" & ConvertNullToZero(rec.Price2)
                                '    SQL &=  " , Price3=" & ConvertNullToZero(rec.Price3)
                                '    SQL &=  " , Price4=" & ConvertNullToZero(rec.Price4)
                                '    SQL &=  " , Price5=" & ConvertNullToZero(rec.Price5)
                                '    SQL &=  " , Price6=" & ConvertNullToZero(rec.Price6)
                                '    SQL &=  " where ProductID=" & ConvertNullToZero(rec.ProductID)
                                '    myCommand = New SqlCommand
                                '    myCommand.CommandText = SQL
                                '    gConnection.executeInsertSqlCommand(myCommand, tr)
                                'End If

                            End If
                        Next

                    Case DataMode.ModeDelete
                        SQL = " DELETE FROM InformPrice "
                        SQL &=  " WHERE CustomerID =" & ID
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
            Err.Raise(Err.Number, e.Source, "InformPriceDAO.SaveData : " & e.Message)
            Return False
        End Try

    End Function

    Public Function CheckExist() As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT CustomerID  FROM " & TableName
            SQL &=  " WHERE IsDelete =0 AND CustomerID=" & ConvertNullToZero(ID)
            If ModeData = DataMode.ModeEdit Then
                SQL &=  " AND CustomerID <> " & ID
            End If
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            Return dataTable.Rows.Count > 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "InformPriceDAO.CheckExist : " & e.Message)
            Return False
        Finally
            dataTable = Nothing
        End Try

    End Function

    Public Function CheckIsToUse() As Boolean ''ถูกใช้งานอยู่ ???
        'Dim MSG As String = ""
        ''Dim SQL As String
        ''Dim dataTable As New DataTable()

        'Try
        '    'SQL = "SELECT LeadID  FROM Lead"
        '    'SQL = SQL & " WHERE IsDelete =0 AND Subject='" & Trim(mSubject) & "'"
        '    'If mMode = DataMode.ModeEdit Then
        '    '    SQL &=  " AND LeadID <> " & mIDs
        '    'End If
        '    'dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        '    'Return dataTable.Rows.Count > 0
        'Catch e As Exception
        '    Err.Raise(Err.Number, e.Source, "InformPriceDAO.CheckNotExist : " & e.Message)
        'End Try
        Return False
    End Function

    Public Sub New()
        mInformPriceDAOs = Nothing
        mPriceSale = 0
    End Sub
End Class
