
Option Explicit On

Public Class frmFindProduct
    Private mDataKey As Collection
    Private mLookFor As String
    Private mCusID As Long
    Private mIsAccept As Boolean = False
    'Private mOrderType As MasterType

    Public ReadOnly Property IsAccept() As Boolean
        Get
            Return mIsAccept
        End Get
    End Property
    Public ReadOnly Property GetDataKey() As Collection
        Get
            Return mDataKey
        End Get
    End Property

    Public WriteOnly Property LookFor() As String
        Set(ByVal value As String)
            mLookFor = value
        End Set
    End Property

    Public Sub Execute(ByRef pLookFor As Integer, ByVal pCusID As Long)
        Try
            'mOrderType = pOrderType
            mCusID = pCusID
            LoadDataProduct()
            Me.ShowDialog()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try

    End Sub

    Private Sub LoadDataProduct()
        Dim lcls As New ProductDAO
        Dim dataTable As New DataTable()
        'Dim SQL As String
        Try
            'If mOrderType = MasterType.StockIn Then
            '    SQL = " and Product.ProductID in (select from Orders)"
            'End If
            Dim rec As frmInformPrice.InformPriceDAOSub
            dataTable = lcls.GetDataTableForCombo(0, mCusID, False, "")
            If dataTable.Rows.Count > 0 Then

                For Each dr As DataRow In dataTable.Rows
                    rec = New frmInformPrice.InformPriceDAOSub
                    rec.IsSelect = False
                    rec.ProductID = dr("ID")
                    rec.ProductCode = ConvertNullToString(dr("ProductCode"))
                    rec.ProductName = ConvertNullToString(dr("ProductName"))
                    rec.ProductRemark = ConvertNullToString(dr("Remark"))
                    rec.PriceStandard = ConvertNullToZero(dr("Price"))
                    bindingSource1.Add(rec)
                Next


                GridControl.DataSource = bindingSource1
                GridView.ViewCaption = "สินค้า"
            Else
                GridControl.DataSource = Nothing
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "frmFindProduct.LoadDataProduct : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub

    Private Sub frmFindProduct_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            GridView.OptionsFind.AllowFindPanel = True
            GridView.OptionsFind.AlwaysVisible = True
            GridView.OptionsFind.HighlightFindResults = True
            GridView.OptionsFind.ShowCloseButton = False
            GridView.OptionsFind.FindFilterColumns = "*"

            GridView.ShowFindPanel()
            GridView.ApplyFindFilter(mLookFor)
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try

    End Sub


    Private Sub GridControl_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl.KeyDown
        If e.KeyData = Keys.Enter Then
            GetKey(False)
            mIsAccept = True
            Me.Close()
        End If
    End Sub


    Private Sub GridView_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView.DoubleClick
        GetKey(False)
        mIsAccept = True
        Me.Close()
    End Sub

    Private Sub GetKey(ByVal pMultiSelect As Boolean)
        Try
            Dim lID As Long

            mDataKey = New Collection
            If GridView.RowCount > 0 Then
                If pMultiSelect = True Then
                    For lRow = 0 To GridView.RowCount
                        If GridView.GetRowCellValue(lRow, "IsSelect") = True Then
                            lID = ConvertNullToZero(GridView.GetRowCellDisplayText(lRow, "ProductID"))
                            If lID > 0 Then
                                mDataKey.Add(lID)
                            End If
                        End If
                    Next
                Else
                    mDataKey.Add(GridView.GetFocusedRowCellValue("ProductID"))
                End If

            End If
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        GetKey(True)
        mIsAccept = True
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Try
            mDataKey = New Collection
            mIsAccept = False
            Me.Close()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try
    End Sub

    Private Sub frmFindProduct_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.Escape Then
            mIsAccept = False
            Me.Close()
        End If
    End Sub


    Private Sub CheckAll_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckAll.CheckedChanged
        If GridView.RowCount > 0 Then
            For lRow = 0 To GridView.RowCount
                GridView.SetRowCellValue(lRow, "IsSelect", CheckAll.CheckState)
            Next
        End If
    End Sub
End Class