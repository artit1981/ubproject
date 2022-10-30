Option Explicit On

Imports System.IO


Public Class ucImage_4
    Dim mFileAttachs As List(Of FileAttachDAO)
    Dim mImageID(0 To 3) As Long

    Public ReadOnly Property GetFileAttachs() As List(Of FileAttachDAO)
        Get
            Return mFileAttachs
        End Get
    End Property

    Public Function InitailData(ByVal lcurrentFiles As List(Of FileAttachDAO)) As Boolean

        Try
            mFileAttachs = lcurrentFiles
            If mFileAttachs Is Nothing Then
                Call InnitialNew()
            ElseIf mFileAttachs.Count = 0 Then
                Call InnitialNew()
            Else
                For i = 0 To mFileAttachs.Count - 1
                    If i <= 3 Then
                        If mFileAttachs(i) Is Nothing Then
                            mImageID(i) = 0
                            Select Case i
                                Case 0 : picPro1.Image = Nothing
                                Case 1 : picPro2.Image = Nothing
                                Case 2 : picPro3.Image = Nothing
                                Case 3 : picPro4.Image = Nothing
                            End Select
                            picPro1.Image = Nothing
                        Else
                            mImageID(i) = mFileAttachs(i).ID
                            mFileAttachs(i).InitailData(mImageID(i), Nothing)
                            Select Case i
                                Case 0 : picPro1.Image = mFileAttachs(i).Images
                                Case 1 : picPro2.Image = mFileAttachs(i).Images
                                Case 2 : picPro3.Image = mFileAttachs(i).Images
                                Case 3 : picPro4.Image = mFileAttachs(i).Images
                            End Select
                        End If
                    End If
                Next
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucImage_4.InitailData : " & e.Message)
            Return False
        End Try

    End Function



#Region "FileDialog"

    Public Sub ClearControl()
        Try
            picPro1.Image = Nothing
            picPro2.Image = Nothing
            picPro3.Image = Nothing
            picPro4.Image = Nothing
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucImage_4.ClearAll : " & e.Message)
        End Try
    End Sub


    Private Function GetOpenFileDialog() As OpenFileDialog
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.CheckPathExists = True
        openFileDialog.CheckFileExists = True
        openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.GIF)|*.bmp;*.jpg;*.jpeg;*.GIF|" + _
            "PNG files (*.png)|*.png"
        openFileDialog.Multiselect = False
        openFileDialog.AddExtension = True
        openFileDialog.ValidateNames = True
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer)
        Return openFileDialog
    End Function

    Private Sub InnitialNew()
        Try
            Dim lFileAttachs As FileAttachDAO
            mFileAttachs = New List(Of FileAttachDAO)
            For pIndex = 0 To 3
                lFileAttachs = New FileAttachDAO
                lFileAttachs.ModeData = DataMode.ModeNew
                lFileAttachs.ID = 0
                lFileAttachs.RefID = 0
                lFileAttachs.FileName = ""
                lFileAttachs.FileType = ""
                lFileAttachs.FilePath = ""
                lFileAttachs.FileSize = 0
                lFileAttachs.CreateBy = gUserName
                lFileAttachs.CreateTime = Now
                lFileAttachs.BuildImage("")
                mFileAttachs.Add(lFileAttachs)
            Next
        Catch ex As Exception

            Err.Raise(Err.Number, ex.Source, "ucImage_4.InnitialNew : " & ex.Message)
        End Try
    End Sub

    Private Sub AddFile(ByVal pIndex As Integer, ByVal pFileNamePath As String)
        Dim sFileNamePath As String = ""
        Dim sFileName As String = ""
        Dim sTemp As Array

        If pFileNamePath = "" Then
            Exit Sub
        End If

        Try
            sFileNamePath = pFileNamePath.Trim
            Dim Extension As String = System.IO.Path.GetExtension(sFileNamePath)
            sFileName = System.IO.Path.GetFileName(sFileNamePath)
            sTemp = Split(sFileName, ".")
            'add file to List(Of ..
            If mFileAttachs(pIndex) Is Nothing Then
                mFileAttachs(pIndex) = New FileAttachDAO()
            End If
            mFileAttachs(pIndex).ModeData = DataMode.ModeEdit
            'mcurrentFiles(pIndex).ID = mIDs
            mFileAttachs(pIndex).RefID = 0
            mFileAttachs(pIndex).FileName = sTemp(0)
            mFileAttachs(pIndex).FileType = Replace(Extension, ".", "")
            mFileAttachs(pIndex).FilePath = sFileNamePath
            mFileAttachs(pIndex).FileSize = Format((GetSize(sFileNamePath) / 1024), "#,##0.00")
            mFileAttachs(pIndex).CreateBy = gUserName
            mFileAttachs(pIndex).CreateTime = Now
            mFileAttachs(pIndex).BuildImage("")
            Select Case pIndex
                Case 0 : picPro1.Image = mFileAttachs(pIndex).Images
                Case 1 : picPro2.Image = mFileAttachs(pIndex).Images
                Case 2 : picPro3.Image = mFileAttachs(pIndex).Images
                Case 3 : picPro4.Image = mFileAttachs(pIndex).Images
            End Select

        Catch ex As Exception

            Err.Raise(Err.Number, ex.Source, "ucImage_4.AddFile : " & ex.Message)
        End Try
    End Sub


    Private Function GetSize(ByVal sPath As String) As Long
        Dim fInfo As New FileInfo(sPath)
        Dim numBytes As Long = fInfo.Length
        Return numBytes
    End Function

    Private Sub Add_Click(ByVal pIndex As Integer)
        Dim sFileNamePath As String = ""
        Try
            Using OpenFileDialog As OpenFileDialog = Me.GetOpenFileDialog()
                If (OpenFileDialog.ShowDialog(Me) = DialogResult.OK) Then
                    sFileNamePath = OpenFileDialog.FileName
                    Call AddFile(pIndex, sFileNamePath)
                Else 'Cancel                
                    Exit Sub
                End If
            End Using
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub


    Private Sub Delete_Click(ByVal pIndex As Integer)
        Try
            'Clear file  
            mFileAttachs(pIndex).ModeData = DataMode.ModeEdit
            mFileAttachs(pIndex).FilePath = ""
            Select Case pIndex
                Case 0 : picPro1.Image = Nothing
                Case 1 : picPro2.Image = Nothing
                Case 2 : picPro3.Image = Nothing
                Case 3 : picPro4.Image = Nothing
            End Select

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal pIndex As Integer)

        Try
            mFileAttachs(pIndex).InitailData(mImageID(pIndex), Nothing)
            Select Case pIndex
                Case 0 : picPro1.Image = mFileAttachs(pIndex).Images
                Case 1 : picPro2.Image = mFileAttachs(pIndex).Images
                Case 2 : picPro3.Image = mFileAttachs(pIndex).Images
                Case 3 : picPro4.Image = mFileAttachs(pIndex).Images
            End Select
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

#End Region

    Private Sub btnAdd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd1.Click
        Add_Click(0)
    End Sub

    Private Sub btnAdd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd2.Click
        Add_Click(1)
    End Sub

    Private Sub btnAdd3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd3.Click
        Add_Click(2)
    End Sub

    Private Sub btnAdd4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd4.Click
        Add_Click(3)
    End Sub

    Private Sub btnDelete1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete1.Click
        Delete_Click(0)
    End Sub

    Private Sub btnDelete2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete2.Click
        Delete_Click(1)
    End Sub

    Private Sub btnDelete3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete3.Click
        Delete_Click(2)
    End Sub

    Private Sub btnDelete4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete4.Click
        Delete_Click(3)
    End Sub

    Private Sub btnCancel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel1.Click
        Cancel_Click(0)
    End Sub

    Private Sub btnCancel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel2.Click
        Cancel_Click(1)
    End Sub

    Private Sub btnCancel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel3.Click
        Cancel_Click(2)
    End Sub

    Private Sub btnCancel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel4.Click
        Cancel_Click(3)
    End Sub

    Private Sub picPro1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPro1.DoubleClick
        Try
            If mFileAttachs(0).FilePath <> "" Then
                Process.Start(mFileAttachs(0).FilePath)
            End If

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub picPro2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPro2.DoubleClick
        Try
            If mFileAttachs(1).FilePath <> "" Then
                Process.Start(mFileAttachs(1).FilePath)
            End If

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub picPro3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPro3.DoubleClick
        Try
            If mFileAttachs(2).FilePath <> "" Then
                Process.Start(mFileAttachs(2).FilePath)
            End If

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub picPro4_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPro4.DoubleClick
        Try
            If mFileAttachs(3).FilePath <> "" Then
                Process.Start(mFileAttachs(3).FilePath)
            End If

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

End Class
