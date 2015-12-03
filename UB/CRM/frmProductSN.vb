Option Explicit On
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider
Imports System.Data.SqlClient

Public Class frmProductSN
    Inherits iEditForm

    Private Const mFormName As String = "frmProductSN"
    Private mIsFromLoad As Boolean


#Region "Overrides"
    Protected Overrides Sub OnLoadForm(ByVal pMode As Integer, ByVal pID As Long, ByVal pOrderType As Long, ByVal pclsConvert As iOrder, ByVal pCusID As Long)
        Try
            Me.Text = "ข้อมูลสินค้า S/N"

            mIsFromLoad = True
            InitialCombo()
            chkAutoRow.Checked = True
            Call LoadData(pMode, pID)

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".OnLoadForm : " & e.Message)
        Finally
            mIsFromLoad = False
        End Try
    End Sub

    Protected Overrides Sub ClearAllForm(ByVal pMode As Integer)
        Try
            mIsFromLoad = True
            MyBase.ClearAllForm(pMode)
            Select Case pMode
                Case DataMode.ModeNew
                    ClearForm(GeneralTabPage)

            End Select
            XtraTabControl1.SelectedTabPage = GeneralTabPage

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".ClearAllForm : " & e.Message)
        Finally
            mIsFromLoad = False
        End Try
    End Sub

    Protected Overrides Function Save(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        Dim lRow As Long
        Dim SQL As String

        Dim tr As SqlTransaction = Nothing

        Try

            If gridView.RowCount > 0 Then
                tr = gConnection.Connection.BeginTransaction
                For lRow = 0 To gridView.RowCount
                    If ConvertNullToZero(gridView.GetRowCellValue(lRow, "ProductID")) > 0 Then
                        SQL = " Update Product"
                        SQL = SQL & " Set IsSN=" & ConvertNullToZero(gridView.GetRowCellValue(lRow, "IsSN"))
                        SQL = SQL & " where ProductID=" & ConvertNullToZero(gridView.GetRowCellValue(lRow, "ProductID"))
                        gConnection.executeInsertQuery(SQL, tr)
                    End If
                Next
                tr.Commit()
                Return True
            End If
        Catch ex As Exception
            tr.Rollback()
            Err.Raise(Err.Number, ex.Source, mFormName & ".Save : " & ex.Message)
            Return False
        End Try
    End Function

    Protected Overrides Sub OnClosedForm()


    End Sub
#End Region

#Region "Event"


    Private Sub btnBrandRefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBrandRefresh.Click
        Try
            SetComboProductBrand(ConvertNullToZero(ProductTypeID.EditValue))
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
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

    Private Sub FormChangedComponent1_FormControlChanged1(ByVal sender As Object, ByVal e As FormChangedEventArgs) Handles FormChangedComponent1.FormControlChanged
        MyBase.CheckFormChanged()
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click

        Try
            
            InitialGrid()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try

    End Sub

#End Region

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

    Private Function LoadData(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        Try

            InitialGrid()

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".LoadData : " & ex.Message)
            Return False
        Finally
            'lcls = Nothing
            'dataTable = Nothing
        End Try
    End Function

    Private Function InitialGrid() As Boolean
        Dim lProGroupID As Long, lProCateID As Long, lProType As Long, lProBrand As Long
        Dim SQL As String = ""
        Dim dataTable As New DataTable()
        Try
            lProGroupID = ConvertNullToZero(ProductGroupID.EditValue)
            lProCateID = ConvertNullToZero(ProductCategoryID.EditValue)
            lProType = ConvertNullToZero(ProductTypeID.EditValue)
            lProBrand = ConvertNullToZero(ProductBrandID.EditValue)
            'bindingSource1.DataSource = Nothing

            SQL = SQL & "SELECT ProductID , ProductCode, ProductName,Remark,IsSN" ',case when IsSN=0 then False else True end IsSN"
            SQL = SQL & " FROM   Product  "
            SQL = SQL & " WHERE  Product.IsDelete =0   "
            If lProGroupID > 0 Then
                SQL = SQL & " AND Product.ProductGroupID =" & lProGroupID
            End If
            If lProCateID > 0 Then
                SQL = SQL & " AND Product.ProductCategoryID =" & lProCateID
            End If
            If lProType > 0 Then
                SQL = SQL & " AND Product.ProductTypeID =" & lProType
            End If
            If lProBrand > 0 Then
                SQL = SQL & " AND Product.ProductBrandID =" & lProBrand
            End If
            SQL = SQL & " ORDER BY ProductCode,ProductName"

            dataTable = gConnection.executeSelectQuery(SQL, Nothing)

            If IsNothing(dataTable) = False Then
                gridControl.DataSource = dataTable
            End If

            'DxErrorProvider1.DataSource = bindingSource1
            'DxErrorProvider1.ContainerControl = Me
            'gridControl.DataSource = bindingSource1
            If mIsFromLoad = True Then
                gridView.OptionsView.RowAutoHeight = chkAutoRow.Checked = True
                RepositoryItemMemoEdit1.LinesCount = 0
            End If

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".InitialGrid : " & ex.Message)
            Return False
        Finally

        End Try
    End Function

     

#End Region



    Private Sub chkAutoRow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAutoRow.CheckedChanged
        'InitialGrid(mIDs)
        gridView.OptionsView.RowAutoHeight = chkAutoRow.Checked = True
        RepositoryItemMemoEdit1.LinesCount = 0
        gridView.RefreshData()
    End Sub
     

    Private Sub btnSNList_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnSNList.ButtonClick
       
    End Sub
End Class