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

            SQL &=  " SELECT   0 as IsSelect, Product.ProductID  ,Product.ProductCode,Product.ProductName"
            SQL &=  " ,MAX(Product.PriceStandard) AS PriceStandard,MAX(Cost.Cost) AS Cost,MAX(Product.Price1) AS Price1"
            SQL &=  " ,MAX(Product.Price2) AS Price2 ,MAX(Product.Price3) AS Price3,MAX(Product.Price4) AS Price4"
            SQL &=  " ,MAX(Product.Price5) AS Price5 ,MAX(Product.Price6) AS Price6,Product.Remark as ProductRemark "
            SQL &=  " FROM Product "
            SQL &=  " left outer join Product_CostAVG Cost on Cost.ProductID=Product.ProductID and Cost.IsDelete=0"
            SQL &=  " WHERE Product.IsDelete =0 "
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
            SQL &=  " GROUP BY Product.ProductID,Product.ProductCode,Product.ProductName,Product.Remark "
            SQL &=  " ORDER BY ProductCode,ProductName"

            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            mProductTable = dataTable

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "InformPriceProDAO.LoadData : " & e.Message)
        End Try

    End Sub


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
                                SQL &=  " Set PriceStandard=" & ConvertNullToZero(rec.PriceStandard)
                                SQL &=  " , Price1=" & ConvertNullToZero(rec.Price1)
                                SQL &=  " , Price2=" & ConvertNullToZero(rec.Price2)
                                SQL &=  " , Price3=" & ConvertNullToZero(rec.Price3)
                                SQL &=  " , Price4=" & ConvertNullToZero(rec.Price4)
                                SQL &=  " , Price5=" & ConvertNullToZero(rec.Price5)
                                SQL &=  " , Price6=" & ConvertNullToZero(rec.Price6)
                                SQL &=  " where ProductID=" & ConvertNullToZero(rec.ProductID)
                                myCommand = New SqlCommand
                                myCommand.CommandText = SQL
                                gConnection.executeInsertSqlCommand(myCommand, tr)
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
