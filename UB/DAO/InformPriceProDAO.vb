Option Explicit On
Imports System.Data.SqlClient
Public Class InformPriceProDAO
    Inherits iDAO

    Private mProductDAOs As List(Of InformPriceSubDAO)
    Private mProductTable As DataTable

    Public ReadOnly Property TableName() As String
        Get
            Return "Product"
        End Get
    End Property

    Public ReadOnly Property ProductTable() As DataTable
        Get
            Return mProductTable
        End Get
    End Property

    Public WriteOnly Property ProductDAOs() As List(Of InformPriceSubDAO)
        Set(ByVal Value As List(Of InformPriceSubDAO))
            mProductDAOs = Value
        End Set
    End Property

    Public Function CHECKSUM_AGG() As Long
        Try
            Return 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "InformPriceProDAO.CHECKSUM_AGG : " & e.Message)
            Return 0
        Finally

        End Try
    End Function

    Public Function GetDataTable(ByVal pID As Long) As DataTable
        Return Nothing
    End Function

    Private Sub LoadData(ByVal pProGroupID As Long, ByVal pProCategID As Long, ByVal pProTypeID As Long, ByVal pProBandID As Long)
        Dim SQL As String = ""
        Dim dataTable As New DataTable()
        Try

            SQL &= " SELECT   0 as IsSelect, ProductID  ,ProductCode,ProductName"
            SQL &= " ,PriceStandard AS PriceStandard,Cost AS Cost,Price1 AS Price1"
            SQL &= " ,Price2 AS Price2 ,Price3 AS Price3,Price4 AS Price4"
            SQL &= " ,Price5 AS Price5 ,Price6 AS Price6,ProductRemark,CostID "
            SQL &= " FROM [vInformPricePro] "

            SQL &= " WHERE 1=1 "
            If pProGroupID > 0 Then
                SQL &= " AND ProductGroupID =" & pProGroupID
            End If
            If pProCategID > 0 Then
                SQL &= " AND ProductCategoryID =" & pProCategID
            End If
            If pProTypeID > 0 Then
                SQL &= " AND ProductTypeID =" & pProTypeID
            End If
            If pProBandID > 0 Then
                SQL &= " AND ProductBrandID =" & pProBandID
            End If

            SQL &= " ORDER BY ProductName"

            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            mProductTable = dataTable

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "InformPriceProDAO.LoadData : " & e.Message)
        End Try

    End Sub

    Public Function GetDtProFromSKU(ByVal psku As String) As DataTable
        Dim SQL As String

        Try
            SQL = "SELECT ProductID ,ProductCode,ProductName "
            SQL &= " ,PriceStandard AS PriceStandard,Cost AS Cost,Price1 AS Price1"
            SQL &= " ,Price2 AS Price2 ,Price3 AS Price3,Price4 AS Price4"
            SQL &= " ,Price5 AS Price5 ,Price6 AS Price6,ProductRemark,CostID "
            SQL &= " FROM [vInformPricePro] "
            SQL &= " WHERE sku1 ='" & psku.Trim & "'"
            SQL &= " or sku2 ='" & psku.Trim & "'"
            SQL &= " or sku3 ='" & psku.Trim & "'"
            SQL &= " or sku4 ='" & psku.Trim & "'"
            SQL &= " or sku5 ='" & psku.Trim & "'"
            Dim dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            Return dataTable
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductDAO.GetDtProFromSKU : " & e.Message)

        Finally

        End Try

    End Function
    Public Function InitailData(ByVal tr As SqlTransaction _
                                 , Optional ByVal pProGroupID As Long = 0, Optional ByVal pProCategID As Long = 0 _
                                 , Optional ByVal pProTypeID As Long = 0, Optional ByVal pProBandID As Long = 0) As Boolean
        Try
            LoadData(pProGroupID, pProCategID, pProTypeID, pProBandID)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "InformPriceDAO.InitailData : " & e.Message)
            Return False
        Finally
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
                                SQL = " Update Product"
                                SQL &= " Set PriceStandard=" & ConvertNullToZero(rec.PriceStandard)
                                SQL &= " , Price1=" & ConvertNullToZero(rec.Price1)
                                SQL &= " , Price2=" & ConvertNullToZero(rec.Price2)
                                SQL &= " , Price3=" & ConvertNullToZero(rec.Price3)
                                SQL &= " , Price4=" & ConvertNullToZero(rec.Price4)
                                SQL &= " , Price5=" & ConvertNullToZero(rec.Price5)
                                SQL &= " , Price6=" & ConvertNullToZero(rec.Price6)
                                SQL &= " where ProductID=" & ConvertNullToZero(rec.ProductID)
                                myCommand = New SqlCommand
                                myCommand.CommandText = SQL
                                gConnection.executeInsertSqlCommand(myCommand, tr)
                                If ConvertNullToZero(rec.CostID) > 0 Then
                                    SQL = " UPDATE Product_CostAVG SET "
                                    SQL &= " Cost=" & ConvertNullToZero(rec.Cost)
                                    SQL &= " ,ProductListID=0"
                                    SQL &= " WHERE CostID=" & rec.CostID
                                    myCommand = New SqlCommand
                                    myCommand.CommandText = SQL
                                    gConnection.executeInsertSqlCommand(myCommand, tr)
                                Else

                                    SQL = " INSERT INTO Product_CostAVG (ProductID,Cost,ProductListID ,IsDelete )"
                                    SQL &= " VALUES ( " & rec.ProductID
                                    SQL &= " ," & ConvertNullToZero(rec.Cost)
                                    SQL &= " ,0"
                                    SQL &= " ,0) "
                                    myCommand = New SqlCommand
                                    myCommand.CommandText = SQL
                                    gConnection.executeInsertSqlCommand(myCommand, tr)
                                End If
                            End If
                        Next
                End Select

                SaveNote(NoteDAOs, ModeData, ID, TableName, tr)
                SaveAttachFile(FileAttachs, ModeData, ID, TableName, tr)

                tr.Commit()
                Return True
            End If
        Catch e As Exception
            tr.Rollback()
            Err.Raise(Err.Number, e.Source, "InformPriceProDAO.SaveData : " & e.Message)
            Return False
        End Try

    End Function



    Public Sub New()
        mProductDAOs = Nothing

    End Sub
End Class
