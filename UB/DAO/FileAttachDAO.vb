Option Explicit On

Imports System.Data.SqlClient
Imports System.IO
Public Class FileAttachDAO
    Private mMode As DataMode
    Private mIDs As Long
    Private mRefID As Long
    Private mRefTable As String
    Private mFileName As String
    Private mFileType As String
    Private mFilePath As String
    Private mFileSize As Decimal
    Private mCreateBy As String
    Private mCreateTime As DateTime
    Private mImage As Image

    ''' <summary>
    ''' Thumbnail image abort target
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ThumbnailCallback() As Boolean

        Return False

    End Function

#Region "Property"



    Public Property FileName() As String
        Get
            Return mFileName
        End Get
        Set(ByVal value As String)
            mFileName = value
        End Set
    End Property

    Public Property FileType() As String
        Get
            Return mFileType
        End Get
        Set(ByVal value As String)
            mFileType = value
        End Set
    End Property

    Public Property FileSize() As Decimal
        Get
            Return mFileSize
        End Get
        Set(ByVal value As Decimal)
            mFileSize = value
        End Set

    End Property

    Public Property ID() As Long
        Get
            Return mIDs
        End Get
        Set(ByVal value As Long)
            mIDs = value
        End Set
    End Property

    Public Property RefID() As Long
        Get
            Return mRefID
        End Get
        Set(ByVal value As Long)
            mRefID = value
        End Set

    End Property
    Public Property RefTable() As String
        Get
            Return mRefTable
        End Get
        Set(ByVal value As String)
            mRefTable = value
        End Set
    End Property


    Public Property FilePath() As String
        Get
            Return mFilePath
        End Get
        Set(ByVal value As String)
            mFilePath = value
        End Set
    End Property

    Public Property ModeData() As Integer
        Get
            Return mMode
        End Get
        Set(ByVal Value As Integer)
            mMode = Value
        End Set
    End Property


    Public Property CreateBy() As String
        Get
            Return mCreateBy
        End Get
        Set(ByVal value As String)
            mCreateBy = value
        End Set
    End Property


    Public Property CreateTime() As DateTime
        Get
            Return mCreateTime
        End Get
        Set(ByVal value As DateTime)
            mCreateTime = value
        End Set

    End Property

    Public ReadOnly Property Images() As Image
        Get
            Return mImage
        End Get
    End Property
#End Region

    Public Function InitailData(ByVal pID As Long, ByRef pTr As SqlTransaction) As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()
        Dim lUserDAO As New UserDAO
        Try
            SQL = "SELECT A.FileName,A.FileData,A.FileType,A.FileSize,A.CreateBy"
            SQL = SQL & " ,A.CreateTime,A.FileID ,A.RefID,A.RefTable "
            SQL = SQL & " FROM AttachFile A "
            SQL = SQL & " WHERE  A.FileID =" & pID
            SQL = SQL & " ORDER BY A.FileID"

            dataTable = gConnection.executeSelectQuery(SQL, pTr)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    mMode = DataMode.ModeNone
                    mIDs = Int32.Parse(dr("FileID"))
                    mFileName = dr("FileName").ToString
                    mFileType = dr("FileType").ToString
                    mFileSize = ConvertNullToZero(dr("FileSize"))
                    mRefID = ConvertNullToZero(dr("RefID"))
                    mRefTable = dr("RefTable").ToString
                    mCreateTime = dr("CreateTime")
                    If lUserDAO.InitailData(True, ConvertNullToZero(dr("CreateBy")), "", pTr) Then
                        mCreateBy = lUserDAO.UserName
                    Else
                        mCreateBy = ""
                    End If

                    'Get image data from DB
                    If IsDBNull(dr("FileData")) Then
                        mFilePath = ""
                        mImage = Nothing
                    Else
                        Dim fileData As Byte() = DirectCast(dr("FileData"), Byte())
                        Dim sTempFileName As String = Application.StartupPath & "\" & mFileName & "." & mFileType
                        If Not fileData Is Nothing Then
                            'Read image data into a file stream 
                            Using fs As New FileStream(sTempFileName, FileMode.OpenOrCreate, FileAccess.Write)
                                fs.Write(fileData, 0, fileData.Length)
                                'Set image variable value using memory stream. 
                                fs.Flush()
                                fs.Close()
                            End Using
                            mFilePath = sTempFileName


                            'Load Image
                            Select Case UCase(mFileType)
                                Case "BMP", "JPG", "GIF", "PNG"
                                    'Read image data into a memory stream 
                                    Using ms As New MemoryStream(fileData, 0, fileData.Length)
                                        ms.Write(fileData, 0, fileData.Length)
                                        'Set image variable value using memory stream.
                                        mImage = Image.FromStream(ms, True)
                                    End Using
                                Case Else
                                    mImage = Nothing
                            End Select

                        End If
                    End If

                    Return True
                    Exit For
                Next
            End If
            dataTable = Nothing
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "FileAttachDAO.InitailData : " & e.Message)
            Return False
        End Try

    End Function

    Public Sub BuildImage(ByVal pstrFilePath As String)
        Try
            ' set delegate
            Dim currentCallback = New Image.GetThumbnailImageAbort(AddressOf ThumbnailCallback)

            'Chouse file
            Dim lstrFilePath As String
            If pstrFilePath <> "" Then
                lstrFilePath = pstrFilePath
            Else
                lstrFilePath = mFilePath
            End If


            If lstrFilePath <> "" Then
                ' get the current image
                Dim currentBmp As New Bitmap(lstrFilePath)

                ' thumbnail the image to the size
                ' of the picture box
                mImage = currentBmp.GetThumbnailImage(320, 200, currentCallback, IntPtr.Zero)

                ' clear everything out
                currentBmp = Nothing
            End If

            currentCallback = Nothing

        Catch e As Exception
            mImage = Nothing
            Err.Raise(Err.Number, e.Source, "FileAttachDAO.BuildImage : " & e.Message)
        End Try

    End Sub



    Public Function GetDataTable(ByVal pTable As String, ByVal pRefID As Long, ByRef tr As SqlTransaction) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT A.FileName AS FileName ,A.FileType AS FileType,A.FileSize AS FileSize,B.USERNAME AS CreateBy "
            SQL = SQL & " ,A.CreateTime AS CreateTime,A.FileID AS ID,A.RefID AS RefID ,A.RefTable AS RefTable ,'' AS FilePath ,0 AS ModeData"
            SQL = SQL & " FROM AttachFile A "
            SQL = SQL & " LEFT OUTER JOIN Admin_User B ON A.CreateBy=B.UserID "
            SQL = SQL & " WHERE RefTable = '" & pTable & "' "
            SQL = SQL & " AND RefID =" & pRefID
            SQL = SQL & " ORDER BY FileID"
            dataTable = gConnection.executeSelectQuery(SQL, tr)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "FileAttachDAO.GetDataTable : " & e.Message)
        End Try
        Return dataTable
    End Function


    Public Function SaveData(ByVal tr As SqlTransaction) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand
        Dim imageData As Byte()

        SQL = ""
        Try
            Select Case mMode
                Case DataMode.ModeNew
                    mIDs = GenNewID("FileID", "AttachFile", tr)
                    SQL = " INSERT INTO AttachFile  (FileID,RefID,RefTable,FileName,FileType,FileSize,FilePath,FileData,CreateBy,CreateTime )"
                    SQL = SQL & " VALUES ( @mIDs"
                    SQL = SQL & " ,  @mRefID"
                    SQL = SQL & " ,  @mRefTable"
                    SQL = SQL & " ,  @mFileName"
                    SQL = SQL & " ,  @mFileType"
                    SQL = SQL & " ,  @mFileSize"
                    SQL = SQL & " ,  @mFilePath"
                    If ConvertNullToString(mFilePath) = "" Then
                        SQL = SQL & " ,  Null"
                    Else
                        SQL = SQL & " ,  @imageData"
                    End If
                    SQL = SQL & " ,  @gUserID"
                    SQL = SQL & " ,  @CreateTime"
                    SQL = SQL & " ) "
                Case DataMode.ModeEdit
                    SQL = " UPDATE AttachFile SET  "
                    SQL = SQL & " RefID=@mRefID"
                    SQL = SQL & " ,RefTable=@mRefTable"
                    SQL = SQL & " ,FileName=@mFileName"
                    SQL = SQL & " ,FileType=@mFileType"
                    SQL = SQL & " ,FileSize=@mFileSize"
                    SQL = SQL & " ,FilePath=@mFilePath"
                    If ConvertNullToString(mFilePath) = "" Then
                        SQL = SQL & " ,FileData=Null"
                    Else
                        SQL = SQL & " ,FileData=@imageData"
                    End If
                    SQL = SQL & " ,CreateBy=@gUserID"
                    SQL = SQL & " ,CreateTime=@CreateTime"
                    SQL = SQL & " WHERE FileID= @mIDs"
                Case DataMode.ModeDelete
                    SQL = " DELETE FROM AttachFile  "
                    SQL = SQL & " WHERE FileID= @mIDs"
            End Select
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@mIDs", mIDs))
            myCommand.Parameters.Add(New SqlParameter("@mRefID", Trim(mRefID)))
            myCommand.Parameters.Add(New SqlParameter("@mRefTable", mRefTable.Trim))
            myCommand.Parameters.Add(New SqlParameter("@mFileName", mFileName.Trim))
            myCommand.Parameters.Add(New SqlParameter("@mFileType", mFileType.Trim))
            myCommand.Parameters.Add(New SqlParameter("@mFileSize", mFileSize))
            myCommand.Parameters.Add(New SqlParameter("@mFilePath", mFilePath.Trim))
            myCommand.Parameters.Add(New SqlParameter("@gUserID", gUserID))
            myCommand.Parameters.Add(New SqlParameter("@CreateTime", formatSQLDateTime(GetCurrentDate(tr))))

            'Convert File to bytes Array  
            If ConvertNullToString(mFilePath) <> "" Then
                If mMode <> DataMode.ModeDelete Then
                    imageData = ReadFile(mFilePath.Trim)
                    myCommand.Parameters.Add(New SqlParameter("@imageData", imageData))
                End If
            End If
            gConnection.executeInsertSqlCommand(myCommand, tr)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "FileAttachDAO.SaveData : " & e.Message)
            Return False
        End Try

    End Function

    Private Function ReadFile(ByVal pFileNamePath As String) As Byte()
        Dim data As Byte() = Nothing
        Dim fInfo As New FileInfo(pFileNamePath)
        Dim numBytes As Long = fInfo.Length

        Try
            Dim fStream As New FileStream(pFileNamePath, FileMode.Open, FileAccess.Read)
            Dim br As New BinaryReader(fStream)
            data = br.ReadBytes(CInt(numBytes))

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "FileAttachDAO.ReadFile : " & ex.Message)
        End Try
        Return data
    End Function

    '    Public Function CheckExist() As Boolean
    '        Dim SQL As String
    '        Dim dataTable As New DataTable()

    '        Try
    '            SQL = "SELECT PREFIXID  FROM Prefix"
    '            SQL = SQL & " WHERE CodeThai='" & Trim(mCodeThai) & "'"
    '            If mMode = DataMode.ModeEdit Then
    '                SQL = SQL & " AND PREFIXID <> " & mIDs
    '            End If
    '            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
    '            Return dataTable.Rows.Count > 0
    '        Catch e As Exception
    '            Err.Raise(Err.Number, e.Source, "CheckExist : " & e.Message)
    '            Return False
    '        End Try

    '    End Function


    Public Sub New()
        mMode = DataMode.ModeNone
        mIDs = 0
        mRefID = 0
        mRefTable = ""
        mFileName = ""
        mFileType = ""
        mFilePath = ""
        mFileSize = 0
        mCreateBy = ""
        mCreateTime = Now
        mImage = Nothing
    End Sub
End Class
