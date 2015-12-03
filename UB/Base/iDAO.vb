Option Explicit On

Public Class iDAO
    Private mMode As DataMode
    Private mIDs As Long
    Private mCode As String
    Private mNameThai As String
    Private mNameEng As String
    Private mRemark As String
    Private mCreateBy As String
    Private mModifiedBy As String
    Private mCreateTime As String
    Private mModifiedTime As String
    Private mIsInActive As Boolean
    Private mFileAttachs As List(Of FileAttachDAO)
    Private mNoteDAOs As List(Of NoteDAO)
    Dim mImportTXID As Long

    Public Property ModeData() As Integer
        Get
            Return mMode
        End Get
        Set(ByVal Value As Integer)
            mMode = Value
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

    Public Property Code() As String
        Get
            Return mCode
        End Get
        Set(ByVal value As String)
            mCode = value
        End Set
    End Property


    Public Property NameThai() As String
        Get
            Return mNameThai
        End Get
        Set(ByVal value As String)
            mNameThai = value
        End Set
    End Property

    Public Property NameEng() As String
        Get
            Return mNameEng
        End Get
        Set(ByVal value As String)
            mNameEng = value
        End Set
    End Property

    Public Property Remark() As String
        Get
            Return mRemark
        End Get
        Set(ByVal value As String)
            mRemark = value
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

    Public Property ModifiedBy() As String
        Get
            Return mModifiedBy
        End Get
        Set(ByVal value As String)
            mModifiedBy = value
        End Set
    End Property

    Public Property CreateTime() As String
        Get
            Return mCreateTime
        End Get
        Set(ByVal value As String)
            mCreateTime = value
        End Set

    End Property
    Public Property ModifiedTime() As String
        Get
            Return mModifiedTime
        End Get
        Set(ByVal value As String)
            mModifiedTime = value
        End Set
    End Property

    Public Property IsInActive() As Boolean
        Get
            Return mIsInActive
        End Get
        Set(ByVal value As Boolean)
            mIsInActive = value
        End Set
    End Property

    Public Property FileAttachs() As List(Of FileAttachDAO)
        Get
            Return mFileAttachs
        End Get
        Set(ByVal Value As List(Of FileAttachDAO))
            mFileAttachs = Value
        End Set
    End Property


    Public Property NoteDAOs() As List(Of NoteDAO)
        Get
            Return mNoteDAOs
        End Get
        Set(ByVal Value As List(Of NoteDAO))
            mNoteDAOs = Value
        End Set
    End Property

    Public Property ImportTXID() As Long
        Get
            Return mImportTXID
        End Get
        Set(ByVal value As Long)
            mImportTXID = value
        End Set

    End Property

    Public Sub New()
        ID = 0
        Code = ""
        NameThai = ""
        NameEng = ""
        Remark = ""
        CreateBy = ""
        ModifiedBy = ""
        CreateTime = ""
        ModifiedTime = ""
        IsInActive = False
        mFileAttachs = Nothing
        mNoteDAOs = Nothing
        mImportTXID = 0
    End Sub
End Class
