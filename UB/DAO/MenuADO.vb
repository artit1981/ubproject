Option Explicit On
Public Class MenuADO
    Private mIDs As Long
    Private mShowMode As Long
    Private mSystem As String
    Private mModule As String
    Private mMenuName As String
    Private mMenuDisplay As String
    Private mTableName As String

    Public Property TableNames() As String
        Get
            Return mTableName
        End Get
        Set(ByVal value As String)
            mTableName = value
        End Set
    End Property

    Public Property MenuDisplay() As String
        Get
            Return mMenuDisplay
        End Get
        Set(ByVal value As String)
            mMenuDisplay = value
        End Set
    End Property

    Public Property MenuName() As String
        Get
            Return mMenuName
        End Get
        Set(ByVal value As String)
            mMenuName = value
        End Set
    End Property

    Public Property Modules() As String
        Get
            Return mModule
        End Get
        Set(ByVal value As String)
            mModule = value
        End Set
    End Property

    Public Property System() As String
        Get
            Return mSystem
        End Get
        Set(ByVal value As String)
            mSystem = value
        End Set
    End Property

    Public Property ShowMode() As Long
        Get
            Return mShowMode
        End Get
        Set(ByVal value As Long)
            mShowMode = value
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

    Private ReadOnly Property TableName() As String
        Get
            Return "Menu"
        End Get
    End Property


    Public Function InitailData(ByVal pID As Long) As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()
        Try
            SQL = "SELECT *   "
            SQL &=  " FROM " & TableName
            SQL &=  " WHERE MenuID=" & pID
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    ID = Int32.Parse(dr("MenuID"))
                    ShowMode = ConvertNullToZero(dr("ShowMode"))
                    System = ConvertNullToString(dr("System"))
                    Modules = ConvertNullToString(dr("Module"))
                    MenuName = ConvertNullToString(dr("MenuName"))
                    MenuDisplay = ConvertNullToString(dr("MenuDisplay"))
                    TableNames = ConvertNullToString(dr("TableName"))
                    Return True
                    Exit For
                Next

            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "MenuADO.InitailData : " & e.Message)
            Return False
        Finally
            dataTable = Nothing
        End Try

    End Function


    Public Function GetDataTable() As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT MenuID,ShowMode,System,Module,MenuName,MenuDisplay"
            SQL &=  " ,IsVisible,IsEnable,IsAdd,IsEdit,IsDelete,IsPrint,IsImport"
            SQL &=  " ,IsCreateQuick,IsCopy,IsAssign,IsConvert "
            SQL &=  " FROM Menu  "
            SQL &=  " ORDER BY System,Module,MenuName,MenuDisplay"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "MenuADO.GetDataTable : " & e.Message)
        End Try
        Return dataTable

    End Function

    Public Function GetDataTableForCombo() As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT MenuID,MenuDisplay"
            SQL &=  " FROM Menu  "
            SQL &=  " ORDER BY MenuDisplay "
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "MenuADO.GetDataTableForCombo : " & e.Message)
        End Try
        Return dataTable

    End Function

    Public Sub New()
        mIDs = 0
        mShowMode = 0
        mSystem = ""
        mModule = ""
        mMenuName = ""
        mMenuDisplay = ""
        mTableName = ""
    End Sub
End Class
