Option Explicit On
Imports System.IO

Public Class ucHistory
    Dim mcurrentFiles As FileAttachDAO         ' the current Files (displayed)
    Dim mMode As DataMode

    Dim mIDs As Long
    Dim mImageID As Long

    Public Function InitailData(ByVal lcls As HistoryDAO) As Boolean
        Try
            If Not lcls Is Nothing Then
                mIDs = lcls.ID
                mImageID = lcls.ImageID

                IdentityCard.Text = lcls.IdentityCard
                IdentityCardIssueAt.Text = lcls.IdentityCardIssueAt
                IdentityCardDate.EditValue = lcls.IdentityCardDate
                IdentityCardExpire.EditValue = lcls.IdentityCardExpire
                Gender.Text = lcls.Gender
                BirthDate.EditValue = lcls.BirthDate
                Heights.Text = lcls.Height
                Weight.Text = lcls.Weight
                BloodGroups.Text = lcls.BloodGroups
                Race.Text = lcls.Race
                Nationality.Text = lcls.Nationality
                Religion.Text = lcls.Religion
                TaxID.Text = lcls.TaxID
                MaritalStatus.Text = lcls.MaritalStatus
                MaritalName.Text = lcls.MaritalName
                MilitaryStatus.Text = lcls.MilitaryStatus

                'ImageS
                mcurrentFiles = lcls.ImageS
                If mcurrentFiles Is Nothing Then
                    picPhoto.Image = Nothing
                Else
                    picPhoto.Image = mcurrentFiles.Images
                End If

            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucHistory.InitailData : " & e.Message)
            Return False
        End Try

    End Function


    Public Function GetDAO() As HistoryDAO

        Try
            Dim lcls As New HistoryDAO
            lcls.ID = mIDs
            lcls.IdentityCard = IdentityCard.Text.Trim
            lcls.IdentityCardIssueAt = IdentityCardIssueAt.Text.Trim
            lcls.IdentityCardDate = IdentityCardDate.EditValue
            lcls.IdentityCardExpire = IdentityCardExpire.EditValue
            lcls.Gender = Gender.Text.Trim
            lcls.BirthDate = BirthDate.EditValue
            lcls.Height = ConvertNullToZero(Heights.Text)
            lcls.Weight = ConvertNullToZero(Weight.Text)
            lcls.BloodGroups = BloodGroups.Text.Trim
            lcls.Race = Race.Text.Trim
            lcls.Nationality = Nationality.Text.Trim
            lcls.Religion = Religion.Text.Trim
            lcls.TaxID = TaxID.Text.Trim
            lcls.MaritalStatus = MaritalStatus.Text.Trim
            lcls.MaritalName = MaritalName.Text.Trim
            lcls.MilitaryStatus = MilitaryStatus.Text.Trim
            lcls.ImageS = mcurrentFiles
            Return lcls
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucHistory.GetDAO : " & e.Message)
            Return Nothing
        End Try

    End Function

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
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


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            'Clear file  
            mcurrentFiles.ModeData = DataMode.ModeEdit
            mcurrentFiles.FilePath = ""
            picPhoto.Image = Nothing
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Try
            mcurrentFiles.InitailData(mImageID, Nothing)
            picPhoto.Image = mcurrentFiles.Images
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

#Region "FileDialog"

    Public Sub ClearControl()
        Try
            picPhoto.Image = Nothing
            ClearForm(GroupData)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucHistory.ClearAll : " & e.Message)
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

    Private Sub AddFile(ByVal pFileNamePath As String)
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
            If mcurrentFiles Is Nothing Then
                mcurrentFiles = New FileAttachDAO()
            End If

            mcurrentFiles.ModeData = DataMode.ModeEdit
            mcurrentFiles.ID = mImageID
            mcurrentFiles.RefID = mIDs
            mcurrentFiles.FileName = sTemp(0)
            mcurrentFiles.FileType = Replace(Extension, ".", "")
            mcurrentFiles.FilePath = sFileNamePath
            mcurrentFiles.FileSize = Format((GetSize(sFileNamePath) / 1024), "#,##0.00")
            mcurrentFiles.CreateBy = gUserName
            mcurrentFiles.CreateTime = GetCurrentDate(Nothing)
            mcurrentFiles.BuildImage("")
            picPhoto.Image = mcurrentFiles.Images
        Catch ex As Exception

            Err.Raise(Err.Number, ex.Source, "ucHistory.AddFile : " & ex.Message)
        End Try
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

        ' Add any initialization after the InitializeComponent() call.
        Gender.Properties.Items.Clear()
        Gender.Properties.Items.Add("ชาย")
        Gender.Properties.Items.Add("หญิง")

        BloodGroups.Properties.Items.Clear()
        BloodGroups.Properties.Items.Add("A")
        BloodGroups.Properties.Items.Add("AB")
        BloodGroups.Properties.Items.Add("B")
        BloodGroups.Properties.Items.Add("O")

        MaritalStatus.Properties.Items.Clear()
        MaritalStatus.Properties.Items.Add("โสด")
        MaritalStatus.Properties.Items.Add("สมรส")
        MaritalStatus.Properties.Items.Add("หย่า")
        MaritalStatus.Properties.Items.Add("หม้าย")

        MilitaryStatus.Properties.Items.Clear()
        MilitaryStatus.Properties.Items.Add("ผ่านการเกณฑ์ทหารแล้ว")
        MilitaryStatus.Properties.Items.Add("ผ่อนผัน")
        MilitaryStatus.Properties.Items.Add("ได้รับการยกเล้น")
        MilitaryStatus.Properties.Items.Add("อื่นๆ")
    End Sub

    Private Sub picPhoto_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPhoto.DoubleClick
        Try
            'mcurrentFiles.InitailData(mImageID, Nothing)
            If mcurrentFiles.FilePath <> "" Then
                Process.Start(mcurrentFiles.FilePath)
            End If
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub


    Private Sub picPhoto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPhoto.EditValueChanged

    End Sub
End Class
