Option Explicit On

Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.XtraEditors

Public Class ucAddress
    Dim mcurrentFiles As FileAttachDAO         ' the current Files (displayed)
    Dim mMode As DataMode

    Dim mIDs As Long
    Dim mImageID As Long
  

    Public Function InitailData(ByVal lclsAddress As AddressDAO, ByVal pProvinceTable As DataTable) As Boolean

        Try
            If Not pProvinceTable Is Nothing Then
                SetCombo(pProvinceTable)
            End If


            If Not lclsAddress Is Nothing Then


                mIDs = lclsAddress.ID
                mImageID = lclsAddress.ImageID

                AddressName.Text = lclsAddress.AddressName
                AddressNo.Text = lclsAddress.AddressNo
                GroupNo.Text = lclsAddress.GroupNo
                Building.Text = lclsAddress.Building
                Lane.Text = lclsAddress.Lane
                Street.Text = lclsAddress.Street
                District.Text = lclsAddress.District
                Amphur.Text = lclsAddress.Amphur
                Province.Text = lclsAddress.Province
                PostalCode.Text = lclsAddress.PostalCode
                Country.Text = lclsAddress.Country
                ContactName.Text = lclsAddress.ContactName
                MobilePhone.Text = lclsAddress.MobilePhone
                Phone1.Text = lclsAddress.Phone1
                Phone2.Text = lclsAddress.Phone2
                Phone3.Text = lclsAddress.Phone3
                Fax.Text = lclsAddress.Fax
                Email1.Text = lclsAddress.Email1
                Email2.Text = lclsAddress.Email2
                Email3.Text = lclsAddress.Email3
                Website.Text = lclsAddress.Website
                Remarks.Text = lclsAddress.Remark

                'Map
                mcurrentFiles = lclsAddress.ImageS
                If mcurrentFiles Is Nothing Then
                    picMap.Image = Nothing
                Else
                    picMap.Image = mcurrentFiles.Images
                End If

            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucAddress.InitailData : " & e.Message)
            Return False
        End Try

    End Function


    Public Function GetAddressDAO() As AddressDAO

        Try
            Dim lcls As New AddressDAO
            lcls.ID = mIDs
            lcls.AddressName = AddressName.Text.Trim
            lcls.AddressNo = AddressNo.Text.Trim
            lcls.GroupNo = GroupNo.Text.Trim
            lcls.Building = Building.Text.Trim
            lcls.Lane = Lane.Text.Trim
            lcls.Street = Street.Text.Trim
            lcls.District = District.Text.Trim
            lcls.Amphur = Amphur.Text.Trim
            lcls.Province = Province.Text.Trim
            lcls.PostalCode = PostalCode.Text.Trim
            lcls.Country = Country.Text.Trim
            lcls.ContactName = ContactName.Text.Trim
            lcls.MobilePhone = MobilePhone.Text.Trim
            lcls.Phone1 = Phone1.Text.Trim
            lcls.Phone2 = Phone2.Text.Trim
            lcls.Phone3 = Phone3.Text.Trim
            lcls.Fax = Fax.Text.Trim
            lcls.Email1 = Email1.Text.Trim
            lcls.Email2 = Email2.Text.Trim
            lcls.Email3 = Email3.Text.Trim
            lcls.Website = Website.Text.Trim
            lcls.Remark = Remarks.Text.Trim
            lcls.ImageS = mcurrentFiles
            Return lcls
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucAddress.GetAddressDAO : " & e.Message)
            Return Nothing
        End Try

    End Function

    Private Sub SetCombo(ByVal pProvinceTable As DataTable)
        Try
            If pProvinceTable.Rows.Count > 0 Then
                For Each pRow As DataRow In pProvinceTable.Rows
                    Province.Properties.Items.Add(pRow.Item(0))
                Next
                'Province.Properties.ValueMember = "ProvinceName"
                'Province.Properties.DisplayMember = "ProvinceName"
                'Province.Properties.DataSource = pProvinceTable

                'Province.EditValue = ""
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucAddress.SetCombo : " & e.Message)
        End Try
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


#Region "FileDialog"

    Public Sub ClearControl()
        Try
            picMap.Image = Nothing
            Remarks.Text = ""
            ClearForm(AddressTabPage)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucAddress.ClearAll : " & e.Message)
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
            mcurrentFiles.RefID = 0
            mcurrentFiles.FileName = sTemp(0)
            mcurrentFiles.FileType = Replace(Extension, ".", "")
            mcurrentFiles.FilePath = sFileNamePath
            mcurrentFiles.FileSize = Format((GetSize(sFileNamePath) / 1024), "#,##0.00")
            mcurrentFiles.CreateBy = gUserName
            mcurrentFiles.CreateTime = GetCurrentDate(Nothing)
            mcurrentFiles.BuildImage("")
            picMap.Image = mcurrentFiles.Images
        Catch ex As Exception

            Err.Raise(Err.Number, ex.Source, "ucAddress.AddFile : " & ex.Message)
        End Try
    End Sub


    Private Function GetSize(ByVal sPath As String) As Long
        Dim fInfo As New FileInfo(sPath)
        Dim numBytes As Long = fInfo.Length
        Return numBytes
    End Function

#End Region

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
            picMap.Image = Nothing
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Try
            mcurrentFiles.InitailData(mImageID, Nothing)
            picMap.Image = mcurrentFiles.Images
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub picMap_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles picMap.DoubleClick
        Try
            'mcurrentFiles.InitailData(mImageID, Nothing)
            If mcurrentFiles.FilePath <> "" Then
                Process.Start(mcurrentFiles.FilePath)
            End If
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub
     
End Class
