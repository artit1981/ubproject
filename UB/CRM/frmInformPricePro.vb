Option Explicit On
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmInformPricePro
    Inherits iEditForm

    Private Const mFormName As String = "frmInformPricePro"
    Private mcls As New InformPriceProDAO
    Private mIsFromLoad As Boolean
    Private mMode As DataMode
    Private mProductList As New List(Of ProductListDAO)
    Private mIDs As Long
    Private mIsOnLoad As Boolean = False
#Region "Overrides"
    Protected Overrides Sub OnLoadForm(ByVal pMode As Integer, ByVal pID As Long, ByVal pOrderType As Long, ByVal pclsConvert As iOrder, ByVal pCusID As Long)
        Try
            Me.Text = "กำหนดราคาสินค้า"
            mMode = pMode
            mIsFromLoad = True
            Me.Addbar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.PrintBar2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            InitialCombo()
            chkAutoRow.Checked = True
            mIDs = pID
            Call LoadData(pMode, pID)
            ExportPrivilege()
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
        XtraTabControl1.SelectedTabPage = GeneralTabPage
        Try
            mcls.ID = pID
            mcls.ModeData = pMode

            mcls.ProductDAOs = GetDAOs()
            If Verify() = True Then
                Return mcls.SaveData()
            Else
                ShowProgress(False, "")
                XtraMessageBox.Show(Me, "พบข้อผิดพลาดกรุณาตรวจสอบ", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".Save : " & ex.Message)
            Return False
        End Try
    End Function

    Protected Overrides Sub OnClosedForm()
        mcls = Nothing

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




#End Region

#Region "Private"

    Private Function ExportPrivilege() As Boolean
        Dim lcls As New PrivilegeDAO
        Dim lIsEnable As Boolean
        Try

            If lcls.InitailData(gPrivilegeID, MasterType.OrderHisExport) Then

                PanelControl2.Visible = (lcls.PrivilegeData And Privilege.Visible) = Privilege.Visible
                lIsEnable = (lcls.PrivilegeData And Privilege.Enable) = Privilege.Enable
                btnExportExcel.Enabled = lIsEnable

            Else
                btnExportExcel.Enabled = False
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".ExportPrivilege : " & ex.Message)
            Return False
        Finally
            lcls = Nothing
        End Try
    End Function

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

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click

        Try
            ShowProgress(True, "Loading...")
            LoadDataGrid()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try

    End Sub

    Private Sub LoadDataGrid()
        Dim lCusID As Long
        Try
            mIsOnLoad = True

            chkSelectAll.Checked = False

            InitialGrid(lCusID)

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".LoadDataGrid : " & ex.Message)
        Finally
            mIsOnLoad = False
        End Try
    End Sub

    Private Function LoadData(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        Try
            If pMode = DataMode.ModeNew Then

            ElseIf pMode = DataMode.ModeEdit Then
                InitialGrid(pID)

            End If


        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".LoadData : " & ex.Message)
            Return False
        Finally

        End Try
    End Function

    Private Function InitialGrid(ByVal pID As Long) As Boolean
        Dim lProGroupID As Long, lProCateID As Long, lProType As Long, lProBrand As Long
        Try
            mIsOnLoad = True

            lProGroupID = ConvertNullToZero(ProductGroupID.EditValue)
            lProCateID = ConvertNullToZero(ProductCategoryID.EditValue)
            lProType = ConvertNullToZero(ProductTypeID.EditValue)
            lProBrand = ConvertNullToZero(ProductBrandID.EditValue)
            bindingSource1.DataSource = Nothing

            Call mcls.InitailData(Nothing, lProGroupID, lProCateID, lProType, lProBrand)
            If IsNothing(mcls.ProductTable) = False Then
                bindingSource1.DataSource = mcls.ProductTable
            End If
            DxErrorProvider1.DataSource = bindingSource1
            DxErrorProvider1.ContainerControl = Me
            gridControl.DataSource = bindingSource1
            If mIsFromLoad = True Then
                gridView.OptionsView.RowAutoHeight = chkAutoRow.Checked = True
                RepositoryItemMemoEdit1.LinesCount = 0
            End If

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".InitialGrid : " & ex.Message)
            Return False
        Finally
            mIsOnLoad = False
        End Try
    End Function



    Private Function Verify() As Boolean
        Try
            DxErrorProvider1.ClearErrors()


            Return DxErrorProvider1.HasErrors = False
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".Verify : " & e.Message)
        End Try
    End Function


    Public Function GetDAOs() As List(Of InformPriceSubDAO)
        Dim lRow As Long
        Dim lDataDAO As InformPriceSubDAO
        Dim lDataDAOs = New List(Of InformPriceSubDAO)
        Try
            If gridView.RowCount > 0 Then
                For lRow = 0 To gridView.RowCount
                    If gridView.GetRowCellValue(lRow, "IsSelect") = 1 Then
                        lDataDAO = New InformPriceSubDAO
                        lDataDAO.ProductID = ConvertNullToZero(gridView.GetRowCellValue(lRow, "ProductID"))
                        lDataDAO.ProductCode = ConvertNullToString(gridView.GetRowCellValue(lRow, "ProductCode"))
                        lDataDAO.ProductName = ConvertNullToString(gridView.GetRowCellValue(lRow, "ProductName"))
                        lDataDAO.Price1 = ConvertNullToZero(gridView.GetRowCellValue(lRow, "Price1"))
                        lDataDAO.Price2 = ConvertNullToZero(gridView.GetRowCellValue(lRow, "Price2"))
                        lDataDAO.Price3 = ConvertNullToZero(gridView.GetRowCellValue(lRow, "Price3"))
                        lDataDAO.Price4 = ConvertNullToZero(gridView.GetRowCellValue(lRow, "Price4"))
                        lDataDAO.Price5 = ConvertNullToZero(gridView.GetRowCellValue(lRow, "Price5"))
                        lDataDAO.Price6 = ConvertNullToZero(gridView.GetRowCellValue(lRow, "Price6"))
                        lDataDAO.PriceStandard = ConvertNullToZero(gridView.GetRowCellValue(lRow, "PriceStandard"))
                        lDataDAO.CostID = ConvertNullToZero(gridView.GetRowCellValue(lRow, "CostID"))
                        lDataDAO.Cost = ConvertNullToZero(gridView.GetRowCellValue(lRow, "Cost"))
                        lDataDAOs.Add(lDataDAO)
                    End If
                Next
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".GetDAOs : " & e.Message)
        Finally
            lDataDAO = Nothing
        End Try
        Return lDataDAOs
    End Function


    Public Sub SetSelectAll()
        Dim lRow As Long, lIsSelect As Integer = 0
        Try
            If chkSelectAll.Checked Then
                lIsSelect = 1
            Else
                lIsSelect = 0
            End If

            If gridView.RowCount > 0 Then
                ShowProgress(True, "Loading...")
                For lRow = 0 To gridView.RowCount
                    gridView.SetRowCellValue(lRow, "IsSelect", lIsSelect)
                Next
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetSelectAll : " & e.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

#End Region



    Public Class InformPriceDAOSub
        Inherits InformPriceSubDAO
        Implements IDXDataErrorInfo



#Region "IDXDataErrorInfo Members"
        Public Sub GetPropertyError(ByVal propertyName As String, ByVal info As ErrorInfo) Implements IDXDataErrorInfo.GetPropertyError
            If propertyName = "PriceInform" AndAlso (Not IsNumeric(PriceInform)) Then
                PriceInform = 0
            End If
        End Sub


        Public Sub GetError(ByVal info As ErrorInfo) Implements IDXDataErrorInfo.GetError
            Dim propertyInfo As New ErrorInfo()
            GetPropertyError("PriceInform", propertyInfo)
            If propertyInfo.ErrorText <> "" Then
                info.ErrorText = "พบข้อผิดพลาด"
            Else
            End If
        End Sub
#End Region
    End Class




    Private Sub chkAutoRow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAutoRow.CheckedChanged
        'InitialGrid(mIDs)
        gridView.OptionsView.RowAutoHeight = chkAutoRow.Checked = True
        RepositoryItemMemoEdit1.LinesCount = 0
        gridView.RefreshData()
    End Sub

    Private Sub chkSelectAll_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSelectAll.CheckedChanged
        If mIsOnLoad = False Then
            Call SetSelectAll()
        End If
    End Sub

    Private Sub btnCalc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Dim lRow As Long, lBase As Decimal = 0, lCalc As Decimal = 0
        Try
            If gridView.RowCount = 0 Then Exit Sub
            If gridView.RowCount > 0 Then
                For lRow = 0 To gridView.RowCount
                    If gridView.GetRowCellValue(lRow, "IsSelect") = 1 Then

                        ShowProgress(True, "Loading...")

                        If ConvertNullToZero(calcPriceStandard.EditValue) <> 0 Then
                            lBase = ConvertNullToZero(gridView.GetRowCellValue(lRow, "PriceStandard"))
                            lCalc = lBase * (ConvertNullToZero(calcPriceStandard.EditValue) / 100)
                            lCalc = Format(ConvertNullToZero(lBase + lCalc), "#,##0.00")
                            gridView.SetRowCellValue(lRow, "PriceStandard", lCalc)
                        End If

                        If ConvertNullToZero(calcPrice1.EditValue) <> 0 Then
                            lBase = ConvertNullToZero(gridView.GetRowCellValue(lRow, "Price1"))
                            lCalc = lBase * (ConvertNullToZero(calcPrice1.EditValue) / 100)
                            lCalc = Format(ConvertNullToZero(lBase + lCalc), "#,##0.00")
                            gridView.SetRowCellValue(lRow, "Price1", lCalc)
                        End If

                        'use cost for base
                        lBase = ConvertNullToZero(gridView.GetRowCellValue(lRow, "Price1"))

                        If ConvertNullToZero(calcPrice2.EditValue) <> 0 Then
                            If rdoCalcType.EditValue = 2 Then
                                lBase = ConvertNullToZero(gridView.GetRowCellValue(lRow, "Price2"))
                            End If
                            lCalc = lBase * (ConvertNullToZero(calcPrice2.EditValue) / 100)
                            lCalc = Format(ConvertNullToZero(lBase + lCalc), "#,##0.00")
                            gridView.SetRowCellValue(lRow, "Price2", lCalc)
                        End If
                        If ConvertNullToZero(calcPrice3.EditValue) <> 0 Then
                            If rdoCalcType.EditValue = 2 Then
                                lBase = ConvertNullToZero(gridView.GetRowCellValue(lRow, "Price3"))
                            End If
                            lCalc = lBase * (ConvertNullToZero(calcPrice3.EditValue) / 100)
                            lCalc = Format(ConvertNullToZero(lBase + lCalc), "#,##0.00")
                            gridView.SetRowCellValue(lRow, "Price3", lCalc)
                        End If
                        If ConvertNullToZero(calcPrice4.EditValue) <> 0 Then
                            If rdoCalcType.EditValue = 2 Then
                                lBase = ConvertNullToZero(gridView.GetRowCellValue(lRow, "Price4"))
                            End If
                            lCalc = lBase * (ConvertNullToZero(calcPrice4.EditValue) / 100)
                            lCalc = Format(ConvertNullToZero(lBase + lCalc), "#,##0.00")
                            gridView.SetRowCellValue(lRow, "Price4", lCalc)
                        End If
                        If ConvertNullToZero(calcPrice5.EditValue) <> 0 Then
                            If rdoCalcType.EditValue = 2 Then
                                lBase = ConvertNullToZero(gridView.GetRowCellValue(lRow, "Price5"))
                            End If
                            lCalc = lBase * (ConvertNullToZero(calcPrice5.EditValue) / 100)
                            lCalc = Format(ConvertNullToZero(lBase + lCalc), "#,##0.00")
                            gridView.SetRowCellValue(lRow, "Price5", lCalc)
                        End If
                        If ConvertNullToZero(calcPrice6.EditValue) <> 0 Then
                            If rdoCalcType.EditValue = 2 Then
                                lBase = ConvertNullToZero(gridView.GetRowCellValue(lRow, "Price6"))
                            End If
                            lCalc = lBase * (ConvertNullToZero(calcPrice6.EditValue) / 100)
                            lCalc = Format(ConvertNullToZero(lBase + lCalc), "#,##0.00")
                            gridView.SetRowCellValue(lRow, "Price6", lCalc)
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            ShowProgress(False, "")
            ShowErrorMsg(False, ex.Message)

        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Try
            If XtraMessageBox.Show(Me, "ยืนยันรีเซตข้อมูล", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                ShowProgress(True, "Loading...")
                LoadDataGrid()
                calcPrice1.EditValue = 0
                calcPrice2.EditValue = 0
                calcPrice3.EditValue = 0
                calcPrice4.EditValue = 0
                calcPrice5.EditValue = 0
                calcPrice6.EditValue = 0
                calcPriceStandard.EditValue = 0
            End If
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub btnExportExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportExcel.Click
        Try
            Dim lfrm As New frmPreExport
            lfrm.InitialForm("ProductPrice", gridControl)
            lfrm.ShowDialog()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try
    End Sub

    Private Sub btnImage_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnImage.ButtonClick
        Dim lfrmView As New frmViewImage
        Dim lclsProduct As ProductDAO
        Dim rowHandle As Integer, llngProID As Long
        Try
            If gridView.RowCount = 0 Then Exit Sub
            rowHandle = (TryCast(gridControl.MainView, ColumnView)).FocusedRowHandle
            If rowHandle < 0 Then Exit Sub
            llngProID = gridView.GetRowCellDisplayText(rowHandle, "ProductID")
            If llngProID > 0 Then
                lclsProduct = New ProductDAO
                lclsProduct.ID = llngProID
                lfrmView.LoadFrom(lclsProduct.ProductImageS(Nothing))
                lfrmView.ShowDialog()
            End If

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try
    End Sub
End Class