Option Explicit On

Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmInformPriceBuy
    Inherits iEditForm

    Private Const mFormName As String = "frmInformPriceBuy"
    Private mcls As New InformPriceBuyDAO
    Private mIsFromLoad As Boolean
    Private mMode As DataMode

#Region "Overrides"
    Protected Overrides Sub OnLoadForm(ByVal pMode As Integer, ByVal pID As Long, ByVal pOrderType As Long, ByVal pclsConvert As iOrder, ByVal pCusID As Long)
        Try
            Me.Text = "แจ้งราคาซื้อ"
            mMode = pMode
            mIsFromLoad = True
            chkAutoRow.Checked = True
            Dim point1 As New Point(10, 10)

            'GroupControl1.Height = 24
            'point1 = New Point(11, 129)
            'gridControl.Location = point1

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
                Case DataMode.ModeNew
                    ClearForm(GeneralTabPage)
                    ClearForm(UcAdmin1)
                    UcFileAttach1.ClearControl()
                    UcNote1.ClearControl()
                    AgencyID.Properties.ReadOnly = False
            End Select

            XtraTabControl1.SelectedTabPage = GeneralTabPage
            AgencyID.Select()

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
            mcls.ID = ConvertNullToZero(AgencyID.EditValue)
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

    Private Sub FormChangedComponent1_FormControlChanged1(ByVal sender As Object, ByVal e As FormChangedEventArgs) Handles FormChangedComponent1.FormControlChanged
        MyBase.CheckFormChanged()
    End Sub



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
    'Private Sub ProductGroupID_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProductGroupID.EditValueChanged
    '    Try
    '        If mIsFromLoad = False Then
    '            SetComboProductCategory(ConvertNullToZero(ProductGroupID.EditValue))
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


    Private Function LoadData(ByVal pMode As Integer, ByVal pID As Long) As Boolean

        Try
            If pMode = DataMode.ModeNew Then
                AgencyID.Properties.ReadOnly = False
            ElseIf pMode = DataMode.ModeEdit Then
                InitialGrid(pID)
                AgencyID.EditValue = mcls.ID
                UcAdmin1.CheckInAcive.Checked = mcls.IsInActive
                UcAdmin1.txtCreateBy.Text = mcls.CreateBy.Trim
                UcAdmin1.txtCreateTime.Text = mcls.CreateTime
                UcAdmin1.txtModifiBy.Text = mcls.ModifiedBy.Trim
                UcAdmin1.txtModifiTime.Text = mcls.ModifiedTime
                ''FileAttachs
                UcFileAttach1.ShowControl(mcls.FileAttachs)
                'Lockcontrol
                AgencyID.Properties.ReadOnly = True

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
            lProGroupID = ConvertNullToZero(ProductGroupID.EditValue)
            lProCateID = ConvertNullToZero(ProductCategoryID.EditValue)
            lProType = ConvertNullToZero(ProductTypeID.EditValue)
            lProBrand = ConvertNullToZero(ProductBrandID.EditValue)

            bindingSource1.DataSource = Nothing

            Call mcls.InitailData(pID, 0, Nothing, lProGroupID, lProCateID, lProType, lProBrand)
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

            If ConvertNullToZero(AgencyID.EditValue) = 0 Then
                SetErrorProvider(DxErrorProvider1, AgencyID, "กรุณาระบุเจ้าหนี้")
            ElseIf mcls.CheckExist() = True Then
                SetErrorProvider(DxErrorProvider1, AgencyID, "ข้อมูลซ้ำ")
            End If

            'If mcls.ProductDAOs.Count = 0 Then
            '    Return False
            'End If
            Return DxErrorProvider1.HasErrors = False
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".Verify : " & e.Message)
        End Try
    End Function


    Public Function GetDAOs() As List(Of InformPriceBuyDAOSub)
        Dim lRow As Long
        Dim lDataDAO As InformPriceBuyDAOSub
        Dim lDataDAOs = New List(Of InformPriceBuyDAOSub)
        Try
            If gridView.RowCount > 0 Then
                For lRow = 0 To gridView.RowCount
                    If ConvertNullToZero(gridView.GetRowCellValue(lRow, "ProductID")) <> 0 And _
                        (ConvertNullToZero(gridView.GetRowCellValue(lRow, "PriceInform")) <> ConvertNullToZero(gridView.GetRowCellValue(lRow, "PriceInformOld")) _
                        Or ConvertNullToZero(gridView.GetRowCellValue(lRow, "Discount")) <> ConvertNullToZero(gridView.GetRowCellValue(lRow, "DiscountOld"))) Then
                        lDataDAO = New InformPriceBuyDAOSub
                        lDataDAO.InformPriceID = ConvertNullToZero(gridView.GetRowCellValue(lRow, "InformPriceID"))
                        lDataDAO.ProductID = ConvertNullToZero(gridView.GetRowCellValue(lRow, "ProductID"))
                        lDataDAO.ProductCode = ConvertNullToString(gridView.GetRowCellValue(lRow, "ProductCode"))
                        lDataDAO.ProductName = ConvertNullToString(gridView.GetRowCellValue(lRow, "ProductName"))
                        lDataDAO.Price1 = ConvertNullToZero(gridView.GetRowCellValue(lRow, "Price1"))
                        lDataDAO.Price2 = ConvertNullToZero(gridView.GetRowCellValue(lRow, "Price2"))
                        lDataDAO.Price3 = ConvertNullToZero(gridView.GetRowCellValue(lRow, "Price3"))
                        lDataDAO.PriceInform = ConvertNullToZero(gridView.GetRowCellValue(lRow, "PriceInform"))
                        lDataDAO.Discount = ConvertNullToZero(gridView.GetRowCellValue(lRow, "Discount"))
                        lDataDAO.PriceStandard = ConvertNullToZero(gridView.GetRowCellValue(lRow, "PriceStandard"))
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

#End Region

#Region "Set combo"
    Private Sub SetComboCustomer()
        Try
            SetSearchLookAgency(AgencyID)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboCustomer : " & e.Message)
        End Try
    End Sub

#End Region


    Public Class InformPriceBuyDAOSub
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

    Private Sub AgencyID_EditValueChanged(sender As Object, e As System.EventArgs) Handles AgencyID.EditValueChanged
        Dim lCusID As Long

        Try
            lCusID = ConvertNullToZero(AgencyID.EditValue)
            If mIsFromLoad = False And lCusID > 0 Then
                mIsFromLoad = True
                InitialGrid(lCusID)
                mIsFromLoad = False
            End If
            InitialCusInfo(lCusID)

        Catch ex As Exception
            mIsFromLoad = False
            ShowErrorMsg(False, ex.Message)

        End Try
    End Sub



    Private Sub chkFind_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFind.CheckedChanged
        Dim point1 As New Point(10, 10)
        If chkFind.CheckState = CheckState.Checked Then
            GroupControl1.Height = 85
            point1 = New Point(11, 184)
            gridControl.Location = point1
        Else
            GroupControl1.Height = 24
            point1 = New Point(11, 129)
            gridControl.Location = point1
        End If
    End Sub
    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Dim lCusID As Long
        Try
            lCusID = ConvertNullToZero(AgencyID.EditValue)

            InitialGrid(lCusID)
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try

    End Sub

    Private Sub chkAutoRow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAutoRow.CheckedChanged
        'InitialGrid(mIDs)
        gridView.OptionsView.RowAutoHeight = chkAutoRow.Checked = True
        RepositoryItemMemoEdit1.LinesCount = 0
        gridView.RefreshData()
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