
Imports System.Data.SqlClient


Public Class ProductCostDAO
    Private mMode As DataMode
    Public Enum CostTypes
        Average = 1
        FIFO = 2
    End Enum

    Private mCost As Double
    Private mCostType As CostTypes
    Private mCostID As Long

    Public Property ModeData() As Integer
        Get
            Return mMode
        End Get
        Set(ByVal Value As Integer)
            mMode = Value
        End Set
    End Property
    Public Property CostID() As Long
        Get
            Return mCostID
        End Get
        Set(ByVal Value As Long)
            mCostID = Value
        End Set
    End Property
    Public Property Cost() As Double
        Get
            Return mCost
        End Get
        Set(ByVal value As Double)
            mCost = value
        End Set
    End Property
    Public Property CostType() As CostTypes
        Get
            Return mCostType
        End Get
        Set(ByVal value As CostTypes)
            mCostType = value
        End Set
    End Property


    Public Function InitailData(ByVal pProID As Long, ByVal pCostType As CostTypes, ByVal pProListID As Long, ByRef tr As SqlTransaction) As Boolean
        Dim SQL As String = ""
        Dim dataTable As New DataTable()
        Try
            If pCostType > 0 Then
                mCostType = pCostType
            End If

            Select Case mCostType
                Case CostTypes.Average
                    SQL = "SELECT *   "
                    SQL &=  " FROM Product_CostAVG"
                    SQL &=  " WHERE ProductID=" & pProID
                    SQL &=  " AND IsDelete=0 "
                    'If pProListID > 0 Then
                    '    SQL &=  " AND ProductListID=" & pProListID
                    'End If
                    SQL &=  " Order by CostID Desc"
            End Select

            dataTable = gConnection.executeSelectQuery(SQL, tr)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    Cost = ConvertNullToZero(dr("Cost"))
                    CostID = ConvertNullToZero(dr("CostID"))
                    Return True
                    Exit For
                Next
            Else
                Return False
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProductCostDAO.InitailData : " & e.Message)
            Return False
        Finally
            dataTable = Nothing
        End Try

    End Function

    Public Function SaveData(ByVal pProID As Long, ByVal pCostType As CostTypes, ByVal pNewCost As Decimal, ByVal pProListID As Long, ByRef ptr As SqlTransaction) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand
        Dim tr As SqlTransaction = Nothing

        SQL = ""
        Try
            If ptr Is Nothing Then
                tr = gConnection.Connection.BeginTransaction
            Else
                tr = ptr
            End If

            If pCostType > 0 Then
                mCostType = pCostType
            End If
            Select mMode
                Case DataMode.ModeNew, DataMode.ModeEdit
                    Select Case mCostType
                        Case CostTypes.Average
                            If InitailData(pProID, pCostType, pProListID, ptr) Then
                                mCost = Math.Round((mCost + pNewCost) / 2, 2)
                                SQL = " UPDATE Product_CostAVG SET "
                                SQL &=  " IsDelete=1"
                                SQL &=  " WHERE CostID=" & CostID
                                myCommand = New SqlCommand
                                myCommand.CommandText = SQL
                                gConnection.executeInsertSqlCommand(myCommand, tr)
                            Else
                                mCost = pNewCost
                            End If

                            SQL = " INSERT INTO Product_CostAVG (ProductID,Cost,ProductListID ,IsDelete )"
                            SQL &=  " VALUES ( " & pProID
                            SQL &=  " ," & ConvertNullToZero(mCost)
                            SQL &=  " ," & pProListID
                            SQL &=  " ,0) "
                            myCommand = New SqlCommand
                            myCommand.CommandText = SQL
                            gConnection.executeInsertSqlCommand(myCommand, tr)

                            If ptr Is Nothing Then tr.Commit()

                    End Select
                Case DataMode.ModeDelete
                    'If InitailData(pProID, pCostType, pProListID, ptr) Then
                    '    mCost = Math.Round((mCost + pNewCost) / 2, 2)
                    '    SQL = " UPDATE Product_CostAVG SET "
                    '    SQL &=  " IsDelete=1"
                    '    SQL &=  " WHERE CostID=" & CostID
                    '    myCommand = New SqlCommand
                    '    myCommand.CommandText = SQL
                    '    gConnection.executeInsertSqlCommand(myCommand, tr)
                    'Else
                    '    mCost = pNewCost
                    'End If
                Case Else
                    Return False
                    Exit Function
            End Select


            Return True
        Catch e As Exception
            tr.Rollback()
            Err.Raise(Err.Number, e.Source, "ProductCostDAO.SaveData : " & e.Message)
            Return False
        End Try

    End Function



    Public Sub New()
        mCostType = 1 'Average
        mCost = 0
        mMode = DataMode.ModeNone
    End Sub
End Class
