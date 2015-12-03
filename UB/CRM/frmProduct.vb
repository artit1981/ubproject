Option Explicit On
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Public Class frmProduct
    Inherits iEditForm
    Private Const mFormName As String = "frmProduct"
    Private mIsFromLoad As Boolean
    Private mcls As New ProductDAO
    Private mUnitMainID As Long

#Region "Overrides"
    Protected Overrides Sub OnLoadForm(ByVal pMode As Integer, ByVal pID As Long, ByVal pOrderType As Long, ByVal pclsConvert As iOrder, ByVal pCusID As Long)
        Try
            mIsFromLoad = True
            InitialCombo()
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
                Case DataMode.ModeNew, DataMode.ModeCopy
                    ClearForm(GeneralTabPage)
                    ClearForm(GroupTabPage)
                    ClearForm(UcAdmin1)
                    UcFileAttach1.ClearControl()
                    UcNote1.ClearControl()
                    UcProductLocation1.ClearControl()
                    UcProductUnitBuy.ClearControl()
                    UcProductUnitSell.ClearControl()
                    UcProductLists1.ClearControl()
                    UcProductLists2.ClearControl()
                    UcImage_41.ClearControl()
            End Select
            lblKeepErrorUnitBuy.Visible = False
            lblKeepErrorUnitSell.Visible = False
            lblKeepError2.Visible = False
            TabControl1.SelectedTabPage = GeneralTabPage
            ProductCode.Select()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".ClearAllForm : " & e.Message)
        Finally
            mIsFromLoad = False
        End Try
    End Sub

    Protected Overrides Function Save(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        TabControl1.SelectedTabPage = GeneralTabPage
        Try
            mcls.ModeData = pMode
            mcls.Code = ProductCode.Text
            mcls.NameThai = ProductNameS.Text
            mcls.NameEng = ProductNameEng.Text
            mcls.CostType = CostType.EditValue
            mcls.TaxType = TaxType.Checked
            mcls.IsSN = IIf(IsSN.Checked, 1, 0)
            mcls.PriceStandard = ConvertNullToZero(txtPriceStandart.EditValue)
            mcls.Price1 = ConvertNullToZero(Price1.EditValue)
            mcls.Price2 = ConvertNullToZero(Price2.EditValue)
            mcls.Price3 = ConvertNullToZero(Price3.EditValue)
            mcls.Price4 = ConvertNullToZero(Price4.EditValue)
            mcls.Price5 = ConvertNullToZero(Price5.EditValue)
            mcls.Price6 = ConvertNullToZero(Price6.EditValue)
            mcls.Weight = ConvertNullToString(Weight.EditValue)
            mcls.Size = ConvertNullToString(Sizes.EditValue)
            mcls.Generation = ConvertNullToString(Generation.EditValue)
            mcls.Color = ConvertNullToString(Color.EditValue)
            mcls.UnitMainID = ConvertNullToZero(UnitMainID.EditValue)
            mcls.UnitSecondID = ConvertNullToZero(UnitSecondID.EditValue)
            mcls.ProductCategoryID = ConvertNullToZero(ProductCategoryID.EditValue)
            mcls.ProductBrandID = ConvertNullToZero(ProductBrandID.EditValue)
            mcls.ProductTypeID = ConvertNullToZero(ProductTypeID.EditValue)
            mcls.ProductGroupID = ConvertNullToZero(ProductGroupID.EditValue)
            mcls.ProductGroup1 = ConvertNullToZero(ProductGroup1.EditValue)
            mcls.ProductGroup2 = ConvertNullToZero(ProductGroup2.EditValue)
            mcls.ProductGroup3 = ConvertNullToZero(ProductGroup3.EditValue)
            mcls.ProductGroup4 = ConvertNullToZero(ProductGroup4.EditValue)
            mcls.ProductGroup5 = ConvertNullToZero(ProductGroup5.EditValue)
            mcls.ProductDimension1 = ConvertNullToZero(ProductDimension1.EditValue)
            mcls.ProductDimension2 = ConvertNullToZero(ProductDimension2.EditValue)
            mcls.ProductDimension3 = ConvertNullToZero(ProductDimension3.EditValue)
            mcls.ProductDimension4 = ConvertNullToZero(ProductDimension4.EditValue)
            mcls.ProductDimension5 = ConvertNullToZero(ProductDimension5.EditValue)
            mcls.GuaranteeDay = ConvertNullToZero(GuaranteeDay.EditValue)
            mcls.Remark = Remark.Text.Trim
            mcls.IsInActive = UcAdmin1.CheckInAcive.Checked
            mcls.NoteDAOs = UcNote1.GetNoteDAOs
            mcls.FileAttachs = UcFileAttach1.GetFileAttachs
            mcls.ProductImageS(Nothing) = UcImage_41.GetFileAttachs()
            mcls.ProductLocationSDAOs = UcProductLocation1.GetDAOs
            mcls.ProductUnitBuyDAOs = UcProductUnitBuy.GetDAOs(mcls.UnitMainID)
            mcls.ProductUnitSellDAOs = UcProductUnitSell.GetDAOs(mcls.UnitMainID)
            mcls.ProductSubstituteDAOs = UcProductLists1.GetDAOs(False, True, False, Nothing, False, 0, False, "", 0, "")

            'If unit buy/sell blank assign unit main
            Dim lProUnitDAO As ProductUnitDAO
            If mcls.ProductUnitBuyDAOs.Count <= 0 Then
                lProUnitDAO = New ProductUnitDAO
                lProUnitDAO.UnitID = mcls.UnitMainID
                lProUnitDAO.Rate = 1
                mcls.ProductUnitBuyDAOs.Add(lProUnitDAO)
            End If
            If mcls.ProductUnitSellDAOs.Count <= 0 Then
                lProUnitDAO = New ProductUnitDAO
                lProUnitDAO.UnitID = mcls.UnitMainID
                lProUnitDAO.Rate = 1
                mcls.ProductUnitSellDAOs.Add(lProUnitDAO)
            End If
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

#Region "Private"
    Private Sub InitialCombo()
        Try
            SetCombo1Unit()
            SetCombo2Unit()
            SetComboProductCategory()
            SetComboProductBrand(0)
            SetComboProductType(0)
            SetComboProductGroupID(0)
            SetComboProductGroup(0)
            SetComboProductGroup(1)
            SetComboProductGroup(2)
            SetComboProductGroup(3)
            SetComboProductGroup(4)
            SetComboProductDimension(0)
            SetComboProductDimension(1)
            SetComboProductDimension(2)
            SetComboProductDimension(3)
            SetComboProductDimension(4)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".InitialCombo : " & e.Message)
        End Try
    End Sub

    Private Function LoadData(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        Try
            If pMode = DataMode.ModeNew Then
                UcImage_41.InitailData(Nothing)
                CostType.EditValue = 1
                ProductCode.EditValue = AutoGenCode(MasterType.Product)
            ElseIf pMode = DataMode.ModeEdit Or pMode = DataMode.ModeCopy Then

                If mcls.InitailData(pID, 0, "", "") Then
                    If pMode = DataMode.ModeEdit Then
                        ProductCode.Text = mcls.Code
                        UcAdmin1.CheckInAcive.Checked = mcls.IsInActive
                        UcAdmin1.txtCreateBy.Text = mcls.CreateBy.Trim
                        UcAdmin1.txtCreateTime.Text = mcls.CreateTime
                        UcAdmin1.txtModifiBy.Text = mcls.ModifiedBy.Trim
                        UcAdmin1.txtModifiTime.Text = mcls.ModifiedTime

                        UcFileAttach1.ShowControl(mcls.FileAttachs)
                        UcImage_41.InitailData(mcls.ProductImageS(Nothing))

                        CostType.Properties.ReadOnly = True

                    ElseIf pMode = DataMode.ModeCopy Then
                        MyBase.SetMode = DataMode.ModeNew
                        ProductCode.EditValue = AutoGenCode(MasterType.Product)
                    End If

                    ProductNameS.Text = mcls.NameThai
                    ProductNameEng.Text = mcls.NameEng
                    CostType.EditValue = mcls.CostType
                    txtPriceStandart.EditValue = mcls.PriceStandard
                    Price1.EditValue = mcls.Price1
                    Price2.EditValue = mcls.Price2
                    Price3.EditValue = mcls.Price3
                    Price4.EditValue = mcls.Price4
                    Price5.EditValue = mcls.Price5
                    Price6.EditValue = mcls.Price6
                    Weight.EditValue = mcls.Weight
                    Sizes.EditValue = mcls.Size
                    Generation.EditValue = mcls.Generation
                    Color.EditValue = mcls.Color
                    TaxType.Checked = mcls.TaxType
                    IsSN.Checked = IIf(mcls.IsSN = 1, True, False)
                    UnitSecondID.EditValue = mcls.UnitSecondID
                    UnitMainID.EditValue = mcls.UnitMainID
                    mUnitMainID = mcls.UnitMainID
                    ProductCategoryID.EditValue = mcls.ProductCategoryID
                    ProductTypeID.EditValue = mcls.ProductTypeID
                    ProductBrandID.EditValue = mcls.ProductBrandID
                    ProductGroupID.EditValue = mcls.ProductGroupID
                    'If Not IsNothing(mcls.ProductBrand) Then
                    '    If Not IsNothing(mcls.ProductBrand.ProductType) Then
                    '        ProductType.EditValue = mcls.ProductBrand.ProductType.NameThai
                    '        If Not IsNothing(mcls.ProductBrand.ProductType.ProductCategory) Then
                    '            ProductCategory.EditValue = mcls.ProductBrand.ProductType.ProductCategory.NameThai
                    '        End If
                    '    End If
                    'End If
                    ProductGroup1.EditValue = mcls.ProductGroup1
                    ProductGroup2.EditValue = mcls.ProductGroup2
                    ProductGroup3.EditValue = mcls.ProductGroup3
                    ProductGroup4.EditValue = mcls.ProductGroup4
                    ProductGroup5.EditValue = mcls.ProductGroup5
                    ProductDimension1.EditValue = mcls.ProductDimension1
                    ProductDimension2.EditValue = mcls.ProductDimension2
                    ProductDimension3.EditValue = mcls.ProductDimension3
                    ProductDimension4.EditValue = mcls.ProductDimension4
                    ProductDimension5.EditValue = mcls.ProductDimension5
                    GuaranteeDay.EditValue = mcls.GuaranteeDay
                    Remark.Text = mcls.Remark
                End If
            End If
            UcNote1.ShowControl(mcls.TableName, pID)
            UcProductLocation1.ShowControl(pID)
            UcProductUnitBuy.ShowControl(pID, 1)
            UcProductUnitSell.ShowControl(pID, 2)
            gCustomerID = 0
            Dim lOrderList As New List(Of Long)
            lOrderList.Add(pID)
            UcProductLists1.ShowControl(pMode, lOrderList, mcls.TableName, ProColumn.UnitName + ProColumn.Remark, False, True, Nothing, True, mcls.TableName, False, False, 0, "")
            UcProductLists2.ShowControl(pMode, lOrderList, mcls.TableName & "_ProSet", ProColumn.UnitName + ProColumn.Remark + ProColumn.Price + ProColumn.Units _
                                        , False, True, Nothing, True, mcls.TableName, False, False, 0, "")
            'Default Control
            ProSetTabPage.PageEnabled = IsProductSet.Checked
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".LoadData : " & ex.Message)
            Return False
        Finally

        End Try
    End Function

    Private Function Verify() As Boolean
        Try
            lblKeepErrorUnitBuy.Visible = False
            lblKeepErrorUnitSell.Visible = False
            lblKeepError2.Visible = False
            DxErrorProvider1.ClearErrors()

            If Trim(ProductCode.Text) = "" Then
                SetErrorProvider(DxErrorProvider1, ProductCode, "กรุณาระบุข้อมูล")
            ElseIf mcls.CheckExist() Then
                SetErrorProvider(DxErrorProvider1, ProductCode, "ข้อมูลซ้ำ")
            End If

            If Trim(ProductNameS.Text) = "" Then
                SetErrorProvider(DxErrorProvider1, ProductNameS, "กรุณาระบุข้อมูล")
            End If

            If DxErrorProvider1.HasErrors = False Then
                If ConvertNullToZero(UnitMainID.EditValue) <= 0 Then
                    SetErrorProvider(DxErrorProvider1, UnitMainID, "กรุณาระบุข้อมูล")
                End If

            End If

            If txtPriceStandart.EditValue < 0 Then
                SetErrorProvider(DxErrorProvider1, txtPriceStandart, "ข้อมูลต้องมากกว่าหรือเท่ากับ 0")
            End If

            If DxErrorProvider1.HasErrors = False Then
                If mcls.ProductUnitBuyDAOs.Count <= 0 Then
                    lblKeepErrorUnitBuy.Text = "กรุณาระบุหน่วยซื้อส่วนใหญ่"
                    lblKeepErrorUnitBuy.Visible = True
                    TabControl1.SelectedTabPage = UnitBuyTabPage
                    Return False
                ElseIf UcProductUnitBuy.IsError <> "" Then
                    lblKeepErrorUnitBuy.Text = UcProductUnitBuy.IsError
                    lblKeepErrorUnitBuy.Visible = True
                    TabControl1.SelectedTabPage = UnitBuyTabPage
                    Return False
                End If
            End If

            If DxErrorProvider1.HasErrors = False Then
                If mcls.ProductUnitSellDAOs.Count <= 0 Then
                    lblKeepErrorUnitSell.Text = "กรุณาระบุหน่วยขายส่วนใหญ่"
                    lblKeepErrorUnitSell.Visible = True
                    TabControl1.SelectedTabPage = UnitSellTabPage
                    Return False
                ElseIf UcProductUnitSell.IsError <> "" Then
                    lblKeepErrorUnitSell.Text = UcProductUnitSell.IsError
                    lblKeepErrorUnitSell.Visible = True
                    TabControl1.SelectedTabPage = UnitSellTabPage
                    Return False
                End If
            End If

            If DxErrorProvider1.HasErrors = False Then
                If mcls.ProductLocationSDAOs.Count <= 0 Then
                    lblKeepError2.Text = "กรุณาระบุคลังสินค้า"
                    lblKeepError2.Visible = True
                    TabControl1.SelectedTabPage = LocationTabPage
                End If
            End If

            If DxErrorProvider1.HasErrors = False Then
                If UcProductLists1.IsError <> "" Then
                    TabControl1.SelectedTabPage = SubstituteTabPage
                    Return False
                End If
            End If

            Return DxErrorProvider1.HasErrors = False
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".Verify : " & e.Message)
        End Try
    End Function
#End Region

#Region "Set combo"
    Private Sub SetCombo1Unit()
        Try
            SetComboUnits(UnitMainID)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboUnit : " & e.Message)
        End Try
    End Sub
    Private Sub SetCombo2Unit()
        Try
            SetComboUnits(UnitSecondID)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboUnit : " & e.Message)
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

    Private Sub SetComboCostType()
        Try
            SetLookUpCostType(CostType)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboCostType : " & e.Message)
        End Try
    End Sub

  


    Private Sub SetComboProductGroup(ByVal pIndex As Integer)
        Try
            Select Case pIndex
                Case 0 Or 1 : SetComboMasterSearch(ProductGroup1, MasterType.ProductGroup)
                Case 0 Or 2 : SetComboMasterSearch(ProductGroup2, MasterType.ProductGroup)
                Case 0 Or 3 : SetComboMasterSearch(ProductGroup3, MasterType.ProductGroup)
                Case 0 Or 4 : SetComboMasterSearch(ProductGroup4, MasterType.ProductGroup)
                Case 0 Or 5 : SetComboMasterSearch(ProductGroup5, MasterType.ProductGroup)

            End Select
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboProductGroup : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboProductDimension(ByVal pIndex As Integer)
        Try
            Select Case pIndex
                Case 0 Or 1 : SetComboMasterSearch(ProductDimension1, MasterType.ProductDimension)
                Case 0 Or 2 : SetComboMasterSearch(ProductDimension2, MasterType.ProductDimension)
                Case 0 Or 3 : SetComboMasterSearch(ProductDimension3, MasterType.ProductDimension)
                Case 0 Or 4 : SetComboMasterSearch(ProductDimension4, MasterType.ProductDimension)
                Case 0 Or 5 : SetComboMasterSearch(ProductDimension5, MasterType.ProductDimension)

            End Select
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboProductDimension : " & e.Message)
        End Try

    End Sub

    'Private Sub InitialProBrand(ByVal pProBrandID As Long)
    '    Dim lclsProBand As ProductBrandDAO
    '    Try
    '        If pProBrandID > 0 And mIsFromLoad = False Then
    '            lclsProBand = New ProductBrandDAO
    '            lclsProBand.InitailData(pProBrandID, Nothing, "")
    '            ProductType.EditValue = lclsProBand.ProductType.NameThai
    '            ProductCategory.EditValue = lclsProBand.ProductType.ProductCategory.NameThai
    '        End If
    '    Catch e As Exception
    '        Err.Raise(Err.Number, e.Source, mFormName & ".InitialProBrand : " & e.Message)
    '    End Try

    'End Sub
#End Region

#Region "Event"
    Private Sub FormChangedComponent1_FormControlChanged1(ByVal sender As Object, ByVal e As FormChangedEventArgs) Handles FormChangedComponent1.FormControlChanged
        MyBase.CheckFormChanged()
    End Sub
    Private Sub FomulaRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FomulaRefresh.Click
        Try
            ShowProgress(True, "Loading...")

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub UnitSecondRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitSecondRefresh.Click
        Try
            ShowProgress(True, "Loading...")
            SetCombo2Unit()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub


    Private Sub ProductGroup1Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductGroup1Refresh.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboProductGroup(1)
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub ProductGroup2Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductGroup2Refresh.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboProductGroup(2)
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub ProductGroup3Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductGroup3Refresh.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboProductGroup(3)
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub ProductGroup4Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductGroup4Refresh.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboProductGroup(4)
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub ProductGroup5Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductGroup5Refresh.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboProductGroup(5)
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub Dimension1Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dimension1Refresh.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboProductDimension(1)
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub Dimension2Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dimension2Refresh.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboProductDimension(2)
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub Dimension3Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dimension3Refresh.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboProductDimension(3)
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub Dimension4Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dimension4Refresh.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboProductDimension(4)
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub Dimension5Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dimension5Refresh.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboProductDimension(5)
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub UnitRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitRefresh.Click
        Try
            ShowProgress(True, "Loading...")
            SetCombo1Unit()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub btnGenID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenID.Click
        Try
            ShowProgress(True, "Loading...")
            ProductCode.EditValue = AutoGenCode(MasterType.Product)
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub IsProductSet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IsProductSet.CheckedChanged
        ProSetTabPage.PageEnabled = IsProductSet.Checked
    End Sub

    Private Sub btnBrandRefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBrandRefresh.Click
        Try
            SetComboProductBrand(ConvertNullToZero(ProductCategoryID.EditValue))
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    'Private Sub ProductBrandID_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProductBrandID.EditValueChanged
    '    'Try
    '    '    InitialProBrand(ConvertNullToZero(ProductBrandID.EditValue))
    '    'Catch ex As Exception
    '    '    ShowErrorMsg(False, ex.Message)
    '    'End Try
    'End Sub

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
#End Region

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
                SetComboProductGroupID(ConvertNullToZero(ProductCategoryID.EditValue))
                SetComboProductType(ConvertNullToZero(ProductCategoryID.EditValue))
                SetComboProductBrand(ConvertNullToZero(ProductCategoryID.EditValue))

            End If
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

  
    Private Sub UnitMainID_EditValueChanged(sender As Object, e As System.EventArgs) Handles UnitMainID.EditValueChanged
        Dim lcls As ProductStockDAO
        Try
            If mIsFromLoad = False Then
                If ModeData = DataMode.ModeEdit And UnitMainID.EditValue <> mUnitMainID Then
                    lcls = New ProductStockDAO

                End If
                ShowProgress(True, "Loading...")
                SetComboProductGroupID(ConvertNullToZero(ProductCategoryID.EditValue))
                SetComboProductType(ConvertNullToZero(ProductCategoryID.EditValue))
                SetComboProductBrand(ConvertNullToZero(ProductCategoryID.EditValue))

            End If
        Catch ex As Exception
            ShowProgress(False, "")
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub
 
End Class