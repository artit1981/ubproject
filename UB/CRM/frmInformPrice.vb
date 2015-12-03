Option Explicit On
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class frmInformPrice
    Inherits iEditForm

    Private Const mFormName As String = "frmInformPrice"
    Private mcls As New InformPriceDAO
    Private mIsFromLoad As Boolean
    Private mMode As DataMode
    Private mProductList As New List(Of ProductSubDAO)
    Private mOrderType As MasterType
    Private mIDs As Long
    Private mIsOnLoad As Boolean = False
#Region "Overrides"
    Protected Overrides Sub OnLoadForm(ByVal pMode As Integer, ByVal pID As Long, ByVal pOrderType As Long, ByVal pclsConvert As iOrder, ByVal pCusID As Long)
        Try
            Me.Text = "แจ้งราคาขาย"
            mMode = pMode
            mOrderType = pOrderType
            mIsFromLoad = True
            txtListCount.EditValue = "0"
            InitialCombo()
            btnMakeOrder.Enabled = False
            chkAutoRow.Checked = True
            mIDs = pID
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
                    ClearForm(UcAdmin1)
                    UcFileAttach1.ClearControl()
                    UcNote1.ClearControl()
                    CustomerID.Properties.ReadOnly = False
            End Select

            XtraTabControl1.SelectedTabPage = GeneralTabPage
            CustomerID.Select()

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
            mcls.ID = ConvertNullToZero(CustomerID.EditValue)
            mcls.IsInActive = UcAdmin1.CheckInAcive.Checked
            mcls.NoteDAOs = UcNote1.GetNoteDAOs
            mcls.FileAttachs = UcFileAttach1.GetFileAttachs
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

    Private Sub btnCustomerID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomerID.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboCustomer()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub CustomerID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerID.EditValueChanged
        Dim lCusID As Long
        If mIsFromLoad = False Then
            Try
                ShowProgress(True, "Loading...")
                lCusID = ConvertNullToZero(CustomerID.EditValue)
                If mIsFromLoad = False And lCusID > 0 Then
                    mIsFromLoad = True
                    InitialGrid(lCusID)
                    mIsFromLoad = False
                End If
                InitialCusInfo(lCusID)

            Catch ex As Exception
                mIsFromLoad = False
                ShowProgress(False, "")
                ShowErrorMsg(False, ex.Message)
            Finally
                ShowProgress(False, "")
            End Try
        End If

    End Sub


    Private Sub btnAddPro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPro.Click
        Try
            AddingOrder()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub btnMakeOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMakeOrder.Click
        Try

            Dim lFormEdit As New frmOrderS
            With lFormEdit
                .OrderType = MasterType.Quotation
                .Caption = "ใบเสนอราคา"
                .MdiParent = frmMain
                .ModeData = DataMode.ModeNew
                .IDs = 0
                .ProductList = mProductList
                .CusID = ConvertNullToZero(CustomerID.EditValue)
                .Show()
            End With
        Catch ex As Exception
            ShowProgress(False, "")
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

#End Region

#Region "Private"

    Private Sub InitialCombo()
        Try
            SetComboCustomer()
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
            lCusID = ConvertNullToZero(CustomerID.EditValue)

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
                CustomerID.Properties.ReadOnly = False
            ElseIf pMode = DataMode.ModeEdit Then
                InitialGrid(pID)
                CustomerID.EditValue = mcls.ID
                UcAdmin1.CheckInAcive.Checked = mcls.IsInActive
                UcAdmin1.txtCreateBy.Text = mcls.CreateBy.Trim
                UcAdmin1.txtCreateTime.Text = mcls.CreateTime
                UcAdmin1.txtModifiBy.Text = mcls.ModifiedBy.Trim
                UcAdmin1.txtModifiTime.Text = mcls.ModifiedTime
                ''FileAttachs
                UcFileAttach1.ShowControl(mcls.FileAttachs)
                'Lockcontrol
                CustomerID.Properties.ReadOnly = True
                btnCustomerID.Enabled = False
            End If

            'Note
            UcNote1.ShowControl(mcls.TableName, pID)

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".LoadData : " & ex.Message)
            Return False
        Finally
            'lcls = Nothing
            'dataTable = Nothing
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
            'bindingSource1.DataSource = GetType(InformPriceSubDAO)

            Call mcls.InitailData(pID, 0, , lProGroupID, lProCateID, lProType, lProBrand)
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


    Private Sub InitialCusInfo(ByVal plngCustomerID As Long)
        Dim lcls As New iPerson
        Try

            If plngCustomerID > 0 Then
                lcls = New CustomerDAO
                lcls.InitailData(plngCustomerID)
                If lcls.CriterionPriceID > 0 Then
                    Dim lclsCrit As New MasterDAO
                    lclsCrit.InitailData(lcls.CriterionPriceID, MasterType.CriterionPrice)
                    CriterionPrice.EditValue = lclsCrit.NameThai
                End If
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".InitialCusInfo : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub


    Private Function Verify() As Boolean
        Try
            DxErrorProvider1.ClearErrors()

            If ConvertNullToZero(CustomerID.EditValue) = 0 Then
                SetErrorProvider(DxErrorProvider1, CustomerID, "กรุณาระบุลูกค้า")
            ElseIf mcls.CheckExist() = True Then
                SetErrorProvider(DxErrorProvider1, CustomerID, "ข้อมูลซ้ำ")
            End If

            'If mcls.ProductDAOs.Count = 0 Then
            '    Return False
            'End If
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
                        lDataDAO.InformPriceID = ConvertNullToZero(gridView.GetRowCellValue(lRow, "InformPriceID"))
                        lDataDAO.ProductID = ConvertNullToZero(gridView.GetRowCellValue(lRow, "ProductID"))
                        lDataDAO.ProductCode = ConvertNullToString(gridView.GetRowCellValue(lRow, "ProductCode"))
                        lDataDAO.ProductName = ConvertNullToString(gridView.GetRowCellValue(lRow, "ProductName"))
                        lDataDAO.CostAdjust = ConvertNullToZero(gridView.GetRowCellValue(lRow, "CostAdjust"))
                        lDataDAO.PriceInform = ConvertNullToZero(gridView.GetRowCellValue(lRow, "PriceInform"))
                        'lDataDAO.PriceStandard = ConvertNullToZero(gridView.GetRowCellValue(lRow, "PriceStandard"))
                        'lDataDAO.Price1 = ConvertNullToZero(gridView.GetRowCellValue(lRow, "Price1"))
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


    Private Sub AddingOrder()
        Dim lcls As ProductSubDAO
        Dim rowHandle As Integer, llngProID As Long, lIndex As Integer
        Try
            If gridView.RowCount = 0 Then Exit Sub
            rowHandle = (TryCast(gridControl.MainView, ColumnView)).FocusedRowHandle
            If rowHandle < 0 Then Exit Sub

            llngProID = gridView.GetRowCellDisplayText(rowHandle, "ProductID")

            'Check duplicate
            lIndex = mProductList.FindIndex(Function(m As ProductSubDAO) m.ProductID = llngProID)
            If lIndex >= 0 Then
                MsgBox("รายการสินค้าซ้ำ", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "แจ้งเตือน")
            Else
                ShowProgress(True, "Loading...")
                lcls = InitialProductForAdd(llngProID, ConvertNullToZero(CustomerID.EditValue), mOrderType)
                mProductList.Add(lcls)
                txtListCount.EditValue = txtListCount.EditValue + 1
                btnMakeOrder.Enabled = True
            End If
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

#End Region

#Region "Set combo"
    Private Sub SetComboCustomer()
        Try
            SetSearchLookCustomer(CustomerID, True, False)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboCustomer : " & e.Message)
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

   

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        mProductList.Clear()
        txtListCount.EditValue = "0"
        btnMakeOrder.Enabled = False
    End Sub

    Private Sub chkAutoRow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAutoRow.CheckedChanged
        'InitialGrid(mIDs)
        gridView.OptionsView.RowAutoHeight = chkAutoRow.Checked = True
        RepositoryItemMemoEdit1.LinesCount = 0
        gridView.RefreshData()
    End Sub

    Private Sub chkSelectAll_CheckedChanged(sender As Object, e As System.EventArgs) Handles chkSelectAll.CheckedChanged
        If mIsOnLoad = False Then
            Call SetSelectAll()
        End If
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As System.EventArgs) Handles btnCalc.Click
        Dim lRow As Long, lCost As Decimal = 0, lCalc As Decimal = 0
        Try
            If gridView.RowCount = 0 Then Exit Sub
            If gridView.RowCount > 0 Then
                For lRow = 0 To gridView.RowCount
                    If gridView.GetRowCellValue(lRow, "IsSelect") = 1 Then

                        ShowProgress(True, "Loading...")

                        lCost = ConvertNullToZero(gridView.GetRowCellValue(lRow, "CostAdjust"))
                        If lCost > 0 Then
                           
                            If ConvertNullToZero(calcPriceInform.EditValue) <> 0 Then
                                lCalc = lCost * (ConvertNullToZero(calcPriceInform.EditValue) / 100)
                                lCalc = Format(ConvertNullToZero(lCost + lCalc), "#,##0.00")
                                gridView.SetRowCellValue(lRow, "PriceInform", lCalc)
                            End If
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
    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        Try
            If XtraMessageBox.Show(Me, "ยืนยันรีเซตข้อมูล", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                ShowProgress(True, "Loading...")
                LoadDataGrid()
                calcPriceInform.EditValue = 0
            End If
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

   
End Class