Option Explicit On

Public Class MasterControl
    Private WithEvents mCtlForm As frmMaster

    Private mMasterType As MasterType
    Private mCaption As String
    Private mTable As String


    Public Sub Execute(ByVal pMasterType As Integer)
        mMasterType = pMasterType

        Try
            mCtlForm = New frmMaster
            With mCtlForm
                Call SetMasterType()


                .Text = mCaption
                Call LoadData(0)
                .Show()
            End With

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub SetMasterType()
        Dim lcls As New MenuADO

        Try
            If lcls.InitailData(mMasterType) Then
                mCaption = lcls.MenuDisplay
            End If

            mTable = GetMasterTableName(mMasterType)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mCaption & ".LoadData : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Private Sub LoadData(ByVal pID As Long)
        Dim lcls As New MasterDAO
        Dim dataTable As New DataTable()

        Try
            dataTable = lcls.GetDataTable(pID, mTable, False)

            If dataTable.Rows.Count > 0 Then
                mCtlForm.GridControl.DataSource = dataTable
                Call GridStyle()
            Else
                mCtlForm.GridControl.DataSource = Nothing
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mCaption & ".LoadData : " & e.Message)
        Finally
        End Try
    End Sub

    Private Sub GridStyle()
        With mCtlForm.GridView
            .Columns("ID").Width = 0
            .Columns("ID").Caption = "รหัส"
            .Columns("ID").Visible = False

            .Columns("CodeThai").Caption = "ชื่อข้อความ"
            .Columns("CodeThai").Width = 200

            .Columns("CodeEng").Caption = "ชื่อข้อความ (Eng)"
            .Columns("CodeEng").Width = 200

            .Columns("Remark").Caption = "รายละเอียด"
            '.Columns("Remark").Width = 200
            .Columns("Remark").Visible = False

        End With
    End Sub


    Private Function Verify(ByVal pMode As Integer) As Boolean
        Verify = True


        Try
            Select Case pMode
                Case DataMode.ModeNew, DataMode.ModeEdit
                    If Trim(mCtlForm.txtThai.Text) = "" Then
                        SetErrorProvider(mCtlForm.DxErrorProvider1, mCtlForm.txtThai, "กรุณาระบุข้อมูล")
                        Verify = False
                    Else
                        SetErrorProvider(mCtlForm.DxErrorProvider1, mCtlForm.txtThai, "")
                    End If
            End Select
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mCaption & ".Verify : " & e.Message)
        End Try
    End Function

    Private Sub mCtlForm_Delete(ByRef pSuccess As Boolean, ByVal pID As Long) Handles mCtlForm.Delete
        Dim lcls As New MasterDAO
        pSuccess = False
        Try
            lcls.ID = pID
            lcls.ModeData = DataMode.ModeDelete
            If lcls.SaveData(mTable) Then
                pSuccess = True
                Call LoadData(0)
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mCaption & ".mCtlForm_Delete : " & ex.Message)
        End Try
    End Sub



    Private Sub mCtlForm_InitialData(ByVal pID As Long) Handles mCtlForm.InitialData
        Dim lcls As New MasterDAO
        Try
            If lcls.InitailData(pID, mMasterType) Then
                mCtlForm.txtThai.Text = lcls.NameThai.Trim
                mCtlForm.txtEng.Text = lcls.NameEng.Trim
                mCtlForm.txtRemark.Text = lcls.Remark.Trim
                mCtlForm.txtCreateBy.Text = lcls.CreateBy.Trim
                mCtlForm.txtCreateTime.Text = lcls.CreateTime
                mCtlForm.txtModifiBy.Text = lcls.ModifiedBy.Trim
                mCtlForm.txtModifiTime.Text = lcls.ModifiedTime
                mCtlForm.CheckInAcive.Checked = lcls.IsInActive
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mCaption & ".mCtlForm_InitialData : " & ex.Message)
        End Try
    End Sub



    Private Sub mCtlForm_ReLoad(ByVal pID As Long) Handles mCtlForm.ReLoad
        Try
            Call LoadData(pID)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mCaption & ".mCtlForm_ReLoad : " & ex.Message)
        End Try
    End Sub


    Private Sub mCtlForm_Save(ByRef pSuccess As Boolean, ByVal pMode As Integer, ByVal pID As Long) Handles mCtlForm.Save
        Dim lcls As New MasterDAO
        pSuccess = False
        Try
            If Verify(pMode) = True Then
                lcls.ID = pID
                lcls.ModeData = pMode
                lcls.NameThai = mCtlForm.txtThai.Text
                lcls.NameEng = mCtlForm.txtEng.Text
                If mMasterType <> MasterType.QuotationRemark Then
                    lcls.Remark = Left(mCtlForm.txtRemark.Text, 100)
                Else
                    lcls.Remark = Left(mCtlForm.txtRemark.Text, 500)
                End If

                lcls.IsInActive = mCtlForm.CheckInAcive.Checked
                If lcls.CheckExist(mTable) Then
                    mCtlForm.DxErrorProvider1.SetError(mCtlForm.txtThai, "ข้อมูลซ้ำ")
                Else
                    If lcls.SaveData(mTable) Then
                        pSuccess = True
                        Call LoadData(0)
                    End If
                End If
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mCaption & ".mCtlForm_Save : " & ex.Message)
        End Try
    End Sub

End Class
