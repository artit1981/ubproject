Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Public Class frmUpdateStock
    Private Const mFormName As String = "frmUpdateStock"
    Private mIsFromLoad As Boolean = False

    Private Sub frmCheckStock_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.Text = "Update Stock"
            mIsFromLoad = True
            InitialCombo()
            LoadData()
            mIsFromLoad = False
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try

    End Sub


#Region "Private"
    Private Sub InitialCombo()
        Try
            SetComboProductCategory()
            SetComboProductBrand(0)
            SetComboProductType(0)
            SetComboProductGroupID(0)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".InitialCombo : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboProductCategory()
        Try
            SetLookUpProCategory(ProductCategoryID)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboProductCategory : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboProductBrand(ByVal pProCategoryID As Long)
        Try
            SetLookProBrand(ProductBrandID, pProCategoryID)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboProductBrand : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboProductType(ByVal pProCategoryID As Long)
        Try
            SetLookUpProType(ProductTypeID, pProCategoryID)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboProductType : " & e.Message)
        End Try
    End Sub
    Private Sub SetComboProductGroupID(ByVal pProCategoryID As Long)
        Try
            SetLookProGroup(ProductGroupID, pProCategoryID)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboProductGroupID : " & e.Message)
        End Try
    End Sub
    Private Function LoadData() As Boolean
        Try
            Dim lcls As New ProductStockDAO
            Dim dataTable As New DataTable()

            dataTable = lcls.GetDataStockByLocation2(ConvertNullToZero(ProductCategoryID.EditValue), ConvertNullToZero(ProductTypeID.EditValue) _
                                          , ConvertNullToZero(ProductGroupID.EditValue), ConvertNullToZero(ProductBrandID.EditValue))
            If dataTable.Rows.Count > 0 Then
                If dataTable.Rows.Count > 0 Then
                    gridControl.DataSource = dataTable
                    gridView.ViewCaption = "Update Stock"
                Else
                    gridControl.DataSource = Nothing
                End If
            Else
                gridControl.DataSource = Nothing
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".LoadData : " & e.Message)
        Finally
        End Try
    End Function

#End Region

#Region "Event"



    Private Sub btnBrandRefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBrandRefresh.Click
        Try
            SetComboProductBrand(ConvertNullToZero(ProductCategoryID.EditValue))
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Try
            ShowProgress(True, "Loading...")
            LoadData()

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub


    Private Sub btnProductCategory_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProductCategory.Click
        Try
            SetComboProductCategory()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub btnProductType_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProductType.Click
        Try
            SetComboProductType(ConvertNullToZero(ProductCategoryID.EditValue))
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub btnProductGroup_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProductGroup.Click
        Try
            SetComboProductGroupID(ConvertNullToZero(ProductCategoryID.EditValue))
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub


    Private Sub ProductCategoryID_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProductCategoryID.EditValueChanged
        Try
            If mIsFromLoad = False Then
                SetComboProductType(ConvertNullToZero(ProductCategoryID.EditValue))
                SetComboProductBrand(ConvertNullToZero(ProductCategoryID.EditValue))
                SetComboProductGroupID(ConvertNullToZero(ProductCategoryID.EditValue))
            End If
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

#End Region

    Private Sub frmCheckStock_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.Escape Then
            Me.Close() 'ssds
        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub RepositoryItemButtonEdit_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemButtonEdit.ButtonClick
        Dim rowHandle As Integer
        Dim lFrmEditStock As New frmUpdateStockDTL
        Dim lProductListDAO As ProductListDAO
        Dim lResult As DialogResult
        Try

            If gridView.RowCount = 0 Then Exit Sub
            rowHandle = (TryCast(gridControl.MainView, ColumnView)).FocusedRowHandle
            If rowHandle < 0 Then Exit Sub
            lProductListDAO = New ProductListDAO
            lProductListDAO.ProductID = gridView.GetRowCellValue(rowHandle, "ProductID")
            lProductListDAO.ProductCode = gridView.GetRowCellValue(rowHandle, "ProductCode")
            lProductListDAO.ProductName = gridView.GetRowCellValue(rowHandle, "ProductName")
            lProductListDAO.LocationDTLID = gridView.GetRowCellValue(rowHandle, "LocationDTLID")
            lProductListDAO.UnitName = gridView.GetRowCellValue(rowHandle, "Unit")
            lProductListDAO.Units = gridView.GetRowCellValue(rowHandle, "Units")
            lProductListDAO.IsSN = gridView.GetRowCellValue(rowHandle, "IsSN")
            lProductListDAO.UnitID = gridView.GetRowCellValue(rowHandle, "UnitID")
            lFrmEditStock.ProductListDAO = lProductListDAO
            lResult = lFrmEditStock.ShowDialog()
            If lResult = Windows.Forms.DialogResult.OK Then
                LoadData()
            End If

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub


    Private Sub RepositoryItemButtonHist_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemButtonHist.ButtonClick
        Try
            Dim rowHandle As Integer
            Dim lFrmEditStock As New frmUpdateStockLog
            Dim lProductListDAO As ProductListDAO

            Try

                If gridView.RowCount = 0 Then Exit Sub
                rowHandle = (TryCast(gridControl.MainView, ColumnView)).FocusedRowHandle
                If rowHandle < 0 Then Exit Sub
                lProductListDAO = New ProductListDAO
                lProductListDAO.ProductID = gridView.GetRowCellValue(rowHandle, "ProductID")
                lProductListDAO.ProductCode = gridView.GetRowCellValue(rowHandle, "ProductCode")
                lProductListDAO.ProductName = gridView.GetRowCellValue(rowHandle, "ProductName")
                lProductListDAO.LocationDTLID = gridView.GetRowCellValue(rowHandle, "LocationDTLID")
                lProductListDAO.UnitName = gridView.GetRowCellValue(rowHandle, "Unit")
                lProductListDAO.Units = gridView.GetRowCellValue(rowHandle, "Units")
                lProductListDAO.IsSN = gridView.GetRowCellValue(rowHandle, "IsSN")
                lProductListDAO.UnitID = gridView.GetRowCellValue(rowHandle, "UnitID")
                lFrmEditStock.ProductListDAO = lProductListDAO
                lFrmEditStock.ShowDialog()
                

            Catch ex As Exception
                ShowErrorMsg(False, ex.Message)
            End Try

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub
End Class
