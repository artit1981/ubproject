Option Explicit On

Imports DevExpress.XtraEditors

Public Class frmProductCategory
    Inherits iEditForm
    Private Const mFormName As String = "frmProductCategory"
    Dim mcls As New ProductCategoryDAO
#Region "Overrides"
    Protected Overrides Sub OnLoadForm(ByVal pMode As Integer, ByVal pID As Long, ByVal pOrderType As Long, ByVal pclsConvert As iOrder, ByVal pCusID As Long)
        Try

            Call LoadData(pMode, pID)

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".OnLoadForm : " & e.Message)
        End Try
    End Sub

    Protected Overrides Sub ClearAllForm(ByVal pMode As Integer)
        Try
            MyBase.ClearAllForm(pMode)
            Select Case pMode
                Case DataMode.ModeNew
                    ClearForm(GeneralTabPage)
                    ClearForm(UcAdmin1)
                    UcFileAttach1.ClearControl()
                    UcNote1.ClearControl()
            End Select

            XtraTabControl1.SelectedTabPage = GeneralTabPage
            IDCode.Select()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".ClearAllForm : " & e.Message)
        End Try
    End Sub

    Protected Overrides Function Save(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        XtraTabControl1.SelectedTabPage = GeneralTabPage
        Try
            mcls.ID = pID
            mcls.ModeData = pMode
            mcls.Code = IDCode.Text.Trim
            mcls.NameThai = txtNameThai.Text.Trim
            mcls.NameEng = txtNameEng.Text.Trim
            mcls.Remark = Remark.Text.Trim
            mcls.IsInActive = UcAdmin1.CheckInAcive.Checked
            'mcls.ProductGroupID = ConvertNullToZero(ProductGroupID.GetColumnValue("ID"))
            mcls.NoteDAOs = UcNote1.GetNoteDAOs
            mcls.FileAttachs = UcFileAttach1.GetFileAttachs

            'ProductType
            Dim sQN As String = ""
            For Each item As Object In ProductTypeID.CheckedItems
                Dim row As DataRowView = CType(item, DataRowView)
                If sQN = "" Then
                    sQN = ConvertNullToString(row(0))
                Else
                    sQN = sQN & "," & ConvertNullToString(row(0))
                End If
            Next
            mcls.ProductTypeIDList = sQN

            'ProductGroup
            sQN = ""
            For Each item As Object In ProductGroupID.CheckedItems
                Dim row As DataRowView = CType(item, DataRowView)
                If sQN = "" Then
                    sQN = ConvertNullToString(row(0))
                Else
                    sQN = sQN & "," & ConvertNullToString(row(0))
                End If
            Next
            mcls.ProductGroupIDList = sQN

            'ProductBrand
            sQN = ""
            For Each item As Object In ProductBrandID.CheckedItems
                Dim row As DataRowView = CType(item, DataRowView)
                If sQN = "" Then
                    sQN = ConvertNullToString(row(0))
                Else
                    sQN = sQN & "," & ConvertNullToString(row(0))
                End If
            Next
            mcls.ProductBrandIDList = sQN

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

    Private Sub btnRefreshProductGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            ShowProgress(True, "Loading...")
            'SetComboProductGroup()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub



#End Region

#Region "Private"



    Private Function LoadData(ByVal pMode As Integer, ByVal pID As Long) As Boolean

        Try
            If pMode = DataMode.ModeNew Then
                SetComboProductGroup("", ProductGroupID)
                SetComboProductType("", ProductTypeID)
                SetComboProductBrand("", ProductBrandID)
            ElseIf pMode = DataMode.ModeEdit Then
                If mcls.InitailData(pID, Nothing, "") Then
                    IDCode.Text = mcls.Code
                    txtNameThai.Text = mcls.NameThai
                    txtNameEng.Text = mcls.NameEng
                    Remark.Text = mcls.Remark

                    UcAdmin1.CheckInAcive.Checked = mcls.IsInActive
                    UcAdmin1.txtCreateBy.Text = mcls.CreateBy.Trim
                    UcAdmin1.txtCreateTime.Text = mcls.CreateTime
                    UcAdmin1.txtModifiBy.Text = mcls.ModifiedBy.Trim
                    UcAdmin1.txtModifiTime.Text = mcls.ModifiedTime

                    ''FileAttachs
                    UcFileAttach1.ShowControl(mcls.FileAttachs)

                    'CheckList
                    SetComboProductGroup(mcls.ProductGroupIDList, ProductGroupID)
                    SetComboProductType(mcls.ProductTypeIDList, ProductTypeID)
                    SetComboProductBrand(mcls.ProductBrandIDList, ProductBrandID)
                End If
            End If

            UcNote1.ShowControl(mcls.TableName, pID)

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".LoadData : " & ex.Message)
            Return False
        Finally

        End Try
    End Function


    Private Function Verify() As Boolean
        Try
            DxErrorProvider1.ClearErrors()

            If Trim(IDCode.Text) = "" Then
                SetErrorProvider(DxErrorProvider1, IDCode, "กรุณาระบุข้อมูล")
            ElseIf mcls.CheckExist() Then
                SetErrorProvider(DxErrorProvider1, IDCode, "ข้อมูลซ้ำ")
            End If

            If Trim(txtNameThai.Text) = "" Then
                SetErrorProvider(DxErrorProvider1, txtNameThai, "กรุณาระบุข้อมูล")
            End If

            'If ConvertNullToZero(ProductGroupID.EditValue) = 0 Then
            '    SetErrorProvider(DxErrorProvider1, ProductGroupID, "กรุณาระบุข้อมูล")
            'End If



            Return DxErrorProvider1.HasErrors = False
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".Verify : " & e.Message)
        End Try
    End Function


#End Region

#Region "Set combo"







#End Region

End Class