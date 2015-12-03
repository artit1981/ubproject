Option Explicit On
Imports DevExpress.XtraEditors
Public Class StockInControl
    Implements iControl
    Private Const mCaption As String = "นำสินค้าเข้าระบบ"
    Private WithEvents mCtlForm As frmControls
    Private mCHECKSUM_AGG As Long

    Public Sub Execute(ByVal pOrderType As Integer) Implements iControl.Execute
        Try
            mCtlForm = New frmControls
            With mCtlForm
                .Text = mCaption
                .MdiParent = frmMain
                .OptionBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                .DatePanel.Visible = True
                Call LoadData()
                Call InitialFilterCon(mCtlForm.cboFindIn, FilterBy.Code + FilterBy.EmpName)  'Call Global function
                Call SetControlMenuPrivilege(mCtlForm, MasterType.StockIn)
                .Show()
            End With

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try

    End Sub



    Private Sub LoadData()
        Dim lcls As New StockInDAO
        Dim dataTable As New DataTable()
        Dim SQL As String = ""
        Dim lIsActiveOnly As Boolean = True
        Try
            If mCtlForm.DatePanel.Visible = True Then
                SQL = " and Orders.OrderDate between '" & formatSQLDate(mCtlForm.dtpDateFrom.EditValue) & "'" & "  and '" & formatSQLDate(mCtlForm.dtpDateTo.EditValue) & "'"
                If mCtlForm.chkShowDelete.Checked = True Then
                    lIsActiveOnly = False
                Else
                    lIsActiveOnly = True
                End If
            End If

            dataTable = lcls.GetDataTable(0, lIsActiveOnly, SQL)

            If dataTable.Rows.Count > 0 Then
                mCtlForm.GridControl.DataSource = dataTable
                mCtlForm.GridView.ViewCaption = mCaption
                mCtlForm.GridView.MoveLastVisible()
                Call GridStyle()
            Else
                mCtlForm.GridControl.DataSource = Nothing
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "StockInControl.LoadData : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub


    Private Sub GridStyle()
        With mCtlForm.GridView
            .Columns("IsDelete").Visible = False
            .Columns("ID").Visible = False
            .Columns("LocationDTL").Visible = False
            .Columns("Code").Caption = "เลขที่เอกสาร"
            .Columns("Code").Width = 300
            .Columns("OrderDate").Caption = "วันที่"
            .Columns("OrderDate").Width = 150
            .Columns("LocationDTL").Caption = "คลังเก็บ"
            .Columns("LocationDTL").Width = 200
            .Columns("EMPNAME").Caption = "ผู้ทำรายการ"
            .Columns("EMPNAME").Width = 250
            .Columns("Remark").Caption = "ราละเอียด"
            .Columns("Remark").Width = 400
            .Columns("ModifiedTime").Caption = "แก้ไขล่าสุด"
            .Columns("ModifiedTime").Width = 200
            .Columns("ModifiedTime").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        End With
    End Sub


    Private Sub mCtlForm_AddNew() Handles mCtlForm.AddNew
        Try
            Call ShowForm(DataMode.ModeNew, 0)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "StockInControl.mCtlForm_AddNew : " & ex.Message)
        End Try
    End Sub

    Private Sub ShowForm(ByVal pMode As Integer, ByVal pID As Long)
        Dim lFormEdit As New frmStockIn
        Try
            With lFormEdit
                .Caption = mCaption
                .MdiParent = frmMain
                .ModeData = pMode
                .IDs = pID
                .OrderType = MasterType.StockIn
                .Show()
            End With

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "StockInControl.ShowForm : " & ex.Message)
        End Try
    End Sub

    Private Sub mCtlForm_CHeckRefresh() Handles mCtlForm.CHeckRefresh
        Dim lcls As New StockInDAO
        Dim lCurrent As Long
        Try
            lCurrent = lcls.CHECKSUM_AGG
            If mCHECKSUM_AGG <> lCurrent Then
                LoadData()
                mCHECKSUM_AGG = lCurrent
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "StockInControl.mCtlForm_CHeckRefresh : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Private Sub mCtlForm_Copy(ByVal pID As Long) Handles mCtlForm.Copy
        Try
            Call ShowForm(DataMode.ModeCopy, pID)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "StockInControl.mCtlForm_Copy : " & ex.Message)
        End Try
    End Sub



    Private Sub mCtlForm_Delete(ByVal pID As Long) Handles mCtlForm.Delete
        Dim lcls As New StockInDAO

        Try

            If lcls.InitailData(pID) Then  ''ถูกใช้งานอยู่ ???
                If lcls.CheckNotExist = False Then  ''ถูกใช้งานอยู่ ???
                    lcls.ID = pID
                    lcls.ModeData = DataMode.ModeDelete
                    If lcls.SaveData() Then
                        Call LoadData()
                    End If
                End If
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "StockInControl.mCtlForm_Delete : " & ex.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Private Sub mCtlForm_Edit(ByVal pID As Long) Handles mCtlForm.Edit
        Try
            Call ShowForm(DataMode.ModeEdit, pID)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "StockInControl.mCtlForm_Edit : " & ex.Message)
        End Try
    End Sub

    Private Sub mCtlForm_Import() Handles mCtlForm.Import
        frmImport.MasterTypes = MasterType.StockIn
        frmImport.Show()
    End Sub

    Private Sub mCtlForm_InitDetail(ByVal pID As Long) Handles mCtlForm.InitDetail
        'Dim lclsLeadDAO As New LeadDAO

        'Try
        '    If lclsLeadDAO.InitailData(pID) Then

        '        mCtlForm.UcInfo1.Init(lclsLeadDAO.GetInfoHtml, Nothing)
        '    End If
        'Catch ex As Exception
        '    Err.Raise(Err.Number, ex.Source, "StockInControl.mCtlForm_InitDetail : " & ex.Message)
        'Finally
        '    lclsLeadDAO = Nothing
        'End Try
    End Sub

    Private Sub mCtlForm_InitStatus(ByVal pID As Long) Handles mCtlForm.InitStatus
        Dim lcls As New StockInDAO
        Try
             
            lcls.TableID = MasterType.StockIn
            If lcls.InitailData(pID) Then
                mCtlForm.DeleteBar.Enabled = (lcls.OrderStatus <> "Close")
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "StockInControl.mCtlForm_InitStatus : " & ex.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Private Sub mCtlForm_RefreshFind() Handles mCtlForm.RefreshFind
        Try
            Dim findText As String = mCtlForm.GridView.FindFilterText
            Dim lstrCon As String = InitialFilterMapping(mCtlForm.cboFindIn.SelectedItem)  'Call Global function
            mCtlForm.GridView.OptionsFind.FindFilterColumns = lstrCon
            mCtlForm.GridView.ApplyFindFilter(String.Empty)
            mCtlForm.GridView.ApplyFindFilter(findText)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "StockInControl.mCtlForm_ReLoad : " & ex.Message)
        End Try
    End Sub

    Private Sub mCtlForm_ReLoad() Handles mCtlForm.ReLoad
        Try
            Call LoadData()
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "StockInControl.mCtlForm_ReLoad : " & ex.Message)
        End Try
    End Sub

End Class
