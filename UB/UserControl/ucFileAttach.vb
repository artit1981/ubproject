Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Public Class ucFileAttach
    Private mFileAttachs As List(Of FileAttachDAO)       ' a container for the Files collection

    'Public ReadOnly Property FileAttachs() As List(Of FileAttachDAO)
    '    Get
    '        Return mFileAttachs
    '    End Get
    '    'Set(ByVal value As List(Of FileAttachDAO))
    '    '    mFileAttachs = value
    '    'End Set
    'End Property


    Public Function GetFileAttachs() As List(Of FileAttachDAO)
        Return mFileAttachs
    End Function

    Public Function ShowControl(ByVal pFileAttachs As List(Of FileAttachDAO)) As Boolean
        'Dim dataTable As New DataTable()
        'Dim lFileAttach As New FileAttachDAO
        Try
            'Load FileAttach
            mFileAttachs = pFileAttachs
            GridControl.DataSource = Nothing
            GridControl.DataSource = mFileAttachs
            If Not mFileAttachs Is Nothing Then
                Call GridStyle()
            End If

            Return True


        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucFileAttach.ShowControl : " & e.Message)
            Return False
        End Try

    End Function

#Region "FileDialog"

    Public Sub ClearControl()
        Try
            mFileAttachs = Nothing
            mFileAttachs = New List(Of FileAttachDAO)()
            GridControl.DataSource = Nothing
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucFileAttach.ClearAll : " & e.Message)
        End Try
    End Sub


    Private Function GetOpenFileDialog() As OpenFileDialog
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.CheckPathExists = True
        openFileDialog.CheckFileExists = True
        openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.GIF)|*.bmp;*.jpg;*.jpeg;*.GIF|" + _
            "PNG files (*.png)|*.png|text files (*.text)|*.txt|doc files (*.doc;*.docx)|*.doc;*.docx|pdf files (*.pdf)|*.pdf"
        openFileDialog.Multiselect = False
        openFileDialog.AddExtension = True
        openFileDialog.ValidateNames = True
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer)
        Return openFileDialog
    End Function

    Private Sub AddFile(ByVal pFileNamePath As String)
        Dim sFileNamePath As String = ""
        Dim sFileName As String = ""
        Dim sTemp As Array, lIsFind As Boolean
        Dim currentFiles As FileAttachDAO         ' the current Files (displayed)
        If pFileNamePath = "" Then
            Exit Sub
        End If

        Try
            sFileNamePath = pFileNamePath.Trim
            Dim Extension As String = System.IO.Path.GetExtension(sFileNamePath)
            sFileName = System.IO.Path.GetFileName(sFileNamePath)
            sTemp = Split(sFileName, ".")

            'Search index
            lIsFind = False
            If mFileAttachs Is Nothing Then
                mFileAttachs = New List(Of FileAttachDAO)
            Else
                For Each lFile As FileAttachDAO In mFileAttachs
                    If sFileName = lFile.FileName.Trim & "." & lFile.FileType.Trim Then
                        lIsFind = True
                        Exit For
                    End If
                Next
            End If
            If lIsFind = True Then
                XtraMessageBox.Show("ชื่อไฟล์ซ้ำ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                'add file to List(Of ..
                currentFiles = New FileAttachDAO()
                currentFiles.ModeData = DataMode.ModeNew
                currentFiles.ID = 0
                currentFiles.RefID = 0
                currentFiles.FileName = sTemp(0)
                currentFiles.FileType = Replace(Extension, ".", "")
                currentFiles.FilePath = sFileNamePath
                currentFiles.FileSize = Format((GetSize(sFileNamePath) / 1024), "#,##0.00")
                currentFiles.CreateBy = gUserName
                currentFiles.CreateTime = GetCurrentDate(Nothing)

                mFileAttachs.Add(currentFiles)
                GridControl.DataSource = Nothing
                GridControl.DataSource = mFileAttachs
                Call GridStyle()
            End If

        Catch ex As Exception

            Err.Raise(Err.Number, ex.Source, "ucFileAttach.AddFile : " & ex.Message)
        End Try
    End Sub

    Private Sub GridStyle()
        With GridView
            .Columns("FileName").Caption = "File Name"
            .Columns("FileName").Width = 200

            .Columns("FileType").Caption = "File Type"
            .Columns("FileType").Width = 100

            .Columns("FileSize").Caption = "File Size(KB)"
            .Columns("FileSize").Width = 100
            .Columns("FileSize").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric

            .Columns("CreateBy").Caption = "Attach by"
            .Columns("CreateBy").Width = 100


            .Columns("CreateTime").Caption = "Attach Time"
            .Columns("CreateTime").Width = 150
            .Columns("CreateTime").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom


            .Columns("ID").Visible = False
            .Columns("RefID").Visible = False
            .Columns("RefTable").Visible = False
            .Columns("FilePath").Visible = False
            .Columns("ModeData").Visible = False
            .Columns("Images").Visible = False

        End With
    End Sub

    Private Function GetSize(ByVal sPath As String) As Long
        Dim fInfo As New FileInfo(sPath)
        Dim numBytes As Long = fInfo.Length
        Return numBytes
    End Function

#End Region


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        mFileAttachs = Nothing
        ' Add any initialization after the InitializeComponent() call.
        ' create new File data list
        mFileAttachs = New List(Of FileAttachDAO)()

    End Sub

    Private Sub btnAddFile_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddFile.ItemClick
        Dim sFileNamePath As String = ""
        Try
            Using OpenFileDialog As OpenFileDialog = Me.GetOpenFileDialog()
                If (OpenFileDialog.ShowDialog(Me) = DialogResult.OK) Then
                    sFileNamePath = OpenFileDialog.FileName
                    Call AddFile(sFileNamePath)
                Else 'Cancel                
                    Exit Sub
                End If
            End Using
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub btnOpenFile_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOpenFile.ItemClick
        Dim rowHandle As Integer, lFileID As Long
        Dim lFileAttach As New FileAttachDAO
        Try
            If GridView.RowCount = 0 Then Exit Sub
            rowHandle = (TryCast(GridControl.MainView, ColumnView)).FocusedRowHandle


            If rowHandle < 0 Then Exit Sub
            lFileID = GridView.GetRowCellDisplayText(rowHandle, "ID")
            If lFileAttach.InitailData(lFileID, Nothing) Then
                Process.Start(lFileAttach.FilePath)
            End If
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try
    End Sub

    Private Sub btnRemoveFile_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRemoveFile.ItemClick
        Dim rowHandle As Integer, lFileID As Long, lIndexID As Long = 0, lIsFind As Boolean = False
        Dim lFileAttach As New FileAttachDAO
        Dim lFileName As String
        Try
            If GridView.RowCount = 0 Then Exit Sub
            rowHandle = (TryCast(GridControl.MainView, ColumnView)).FocusedRowHandle


            If rowHandle < 0 Then Exit Sub

            lFileName = GridView.GetRowCellDisplayText(rowHandle, "FileName")

            'Search index
            For Each lFile As FileAttachDAO In mFileAttachs
                If lFileName.Trim = lFile.FileName.Trim Then
                    lIsFind = True
                    Exit For
                End If
                lIndexID = lIndexID + 1
            Next

            If lIsFind = True Then
                lFileID = GridView.GetRowCellDisplayText(rowHandle, "ID")
                If lFileID > 0 Then
                    If lFileAttach.InitailData(lFileID, Nothing) Then
                        If XtraMessageBox.Show(Me, "ต้องการลบข้อมูลใช่หรือไม่ (ไฟล์นี้จะถูกลบออกจากฐานข้อมูลทันที)", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                            ''Delete fromDB
                            lFileAttach.ModeData = DataMode.ModeDelete
                            Dim myCommandS As New List(Of SqlCommand)
                            lFileAttach.SaveData(Nothing)

                            mFileAttachs.RemoveAt(lIndexID)
                            GridControl.DataSource = Nothing
                            GridControl.DataSource = mFileAttachs
                            Call GridStyle()
                        End If
                    End If
                End If


            End If
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try
    End Sub

    Private Sub GridView_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView.FocusedRowChanged
        Dim rowHandle As Integer, lFileID As Long
        Dim lFileAttach As New FileAttachDAO
        Try
            If GridView.RowCount = 0 Then
                btnOpenFile.Enabled = False
                btnRemoveFile.Enabled = False
            Else
                rowHandle = (TryCast(GridControl.MainView, ColumnView)).FocusedRowHandle

                If rowHandle < 0 Then
                    btnOpenFile.Enabled = False
                    btnRemoveFile.Enabled = False
                Else
                    lFileID = ConvertNullToZero(GridView.GetRowCellDisplayText(rowHandle, "ID"))
                    If lFileID <= 0 Then
                        btnOpenFile.Enabled = False
                        btnRemoveFile.Enabled = True
                    Else
                        btnOpenFile.Enabled = True
                        btnRemoveFile.Enabled = True
                    End If
                End If

            End If
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub


End Class
