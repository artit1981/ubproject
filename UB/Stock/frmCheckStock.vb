Public Class frmCheckStock 
    Private Const mFormName As String = "frmCheckStock"
    Private mIsFromLoad As Boolean = False

    Private Sub frmCheckStock_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            mIsFromLoad = True
            'ShowProgress(True, "Loading...")
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

           
            dataTable = lcls.GetDataStockByLocation(ConvertNullToZero(ProductCategoryID.EditValue), ConvertNullToZero(ProductTypeID.EditValue) _
                                          , ConvertNullToZero(ProductGroupID.EditValue), ConvertNullToZero(ProductBrandID.EditValue))
            If dataTable.Rows.Count > 0 Then
                 If dataTable.Rows.Count > 0 Then
                    GridControl.DataSource = dataTable
                    GridView.ViewCaption = "Stock"
                    Call GridStyle()
                Else
                    GridControl.DataSource = Nothing
                End If

            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".LoadData : " & e.Message)
        Finally
        End Try
    End Function


    Private Sub GridStyle()
        With GridView

            .Columns("ProductID").Visible = False
            .Columns("UnitID").Visible = False
           
            .Columns("ProductCode").Caption = "รหัสสินค้า"
            .Columns("ProductCode").Width = 150

            .Columns("ProductName").Caption = "ชื่อสินค้า"
            .Columns("ProductName").Width = 400

            .Columns("UnitName").Caption = "หน่วยสินค้า"
            .Columns("UnitName").Width = 100

            .Columns("Remark").Caption = "รายละเอียด"
            .Columns("Remark").Width = 200


        End With
    End Sub

#End Region


#Region "Event"
    
    

    Private Sub btnBrandRefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBrandRefresh.Click
        Try
            SetComboProductBrand(ConvertNullToZero(ProductCategoryID.EditValue))
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub btnFind_Click(ByVal sender As Object, ByVal e As System.EventArgs)
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
    'Private Sub ProductGroupID_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProductGroupID.EditValueChanged
    '    Try
    '        If mIsFromLoad = False Then
    '            SetComboProductCategory()
    '        End If
    '    Catch ex As Exception
    '        ShowErrorMsg(False, ex.Message)
    '    End Try
    'End Sub

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

    'Private Sub ProductTypeID_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProductTypeID.EditValueChanged
    '    Try
    '        If mIsFromLoad = False Then
    '            SetComboProductBrand(ConvertNullToZero(ProductTypeID.EditValue))
    '        End If
    '    Catch ex As Exception
    '        ShowErrorMsg(False, ex.Message)
    '    End Try
    'End Sub
#End Region

    Private Sub btnFind_Click_1(sender As System.Object, e As System.EventArgs) Handles btnFind.Click
        Try
            ShowProgress(True, "Loading...")
            LoadData()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

  
    Private Sub btnExportExcel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExportExcel.Click
        Try
            Dim lfrm As New frmPreExport
            lfrm.InitialForm("Stock", gridControl)
            lfrm.ShowDialog()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try
    End Sub
    Private Sub frmCheckStock_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
End Class
