Option Explicit On
Imports System.Data.SqlClient
Public Class RunningFormatSNDAO
    Inherits iDAO



#Region "Property"

    Dim mFormatFront As String
    Dim mFormatDate As String
    Dim mFormatMidle As String
    Dim mRunningCount As Integer
    Dim mFormatYear As String
    Dim mLastNo As Long
    Dim mIsReset As Boolean

    Public Property LastNo() As Long
        Get
            Return mLastNo
        End Get
        Set(ByVal value As Long)
            mLastNo = value
        End Set
    End Property


    Public Property FormatYear() As String
        Get
            Return mFormatYear
        End Get
        Set(ByVal value As String)
            mFormatYear = value
        End Set
    End Property

    Public Property RunningCount() As Integer
        Get
            Return mRunningCount
        End Get
        Set(ByVal value As Integer)
            mRunningCount = value
        End Set
    End Property

    Public Property FormatMidle() As String
        Get
            Return mFormatMidle
        End Get
        Set(ByVal value As String)
            mFormatMidle = value
        End Set
    End Property

    Public Property FormatDate() As String
        Get
            Return mFormatDate
        End Get
        Set(ByVal value As String)
            mFormatDate = value
        End Set
    End Property


    Public Property FormatFront() As String
        Get
            Return mFormatFront
        End Get
        Set(ByVal value As String)
            mFormatFront = value
        End Set
    End Property

    Public Property IsReset() As Boolean
        Get
            Return mIsReset
        End Get
        Set(ByVal value As Boolean)
            mIsReset = value
        End Set
    End Property

#End Region


    Public Function InitailData(ByRef tr As SqlTransaction) As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()
        Dim lUserDAO As New UserDAO
        Try
            SQL = "SELECT *   "
            SQL &= " FROM RunningFormatSN"
            dataTable = gConnection.executeSelectQuery(SQL, tr)
            If dataTable.Rows.Count = 0 Then

            Else
                For Each dr As DataRow In dataTable.Rows
                    'ID = Int32.Parse(dr("MenuID"))

                    FormatFront = ConvertNullToString(dr("FormatFront"))
                    FormatDate = ConvertNullToString(dr("FormatDate"))
                    FormatMidle = ConvertNullToString(dr("FormatMidle"))
                    FormatYear = ConvertNullToString(dr("FormatYear"))
                    RunningCount = ConvertNullToZero(dr("RunningCount"))
                    CreateBy = ""
                    CreateTime = ""
                    ModifiedTime = ConvertNullToDateTime(dr("ModifiedTime"))
                    If tr Is Nothing Then
                        If lUserDAO.InitailData(True, ConvertNullToZero(dr("ModifiedBy")), "") Then
                            ModifiedBy = lUserDAO.UserName
                        Else
                            ModifiedBy = ""
                        End If
                    End If

                    Return True
                    Exit For
                Next

            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "RunningFormatDAO.InitailData : " & e.Message)
            Return False
        Finally
            lUserDAO = Nothing
            dataTable = Nothing
        End Try

    End Function




    Public Function SaveData(ByVal tr As SqlTransaction) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand

        SQL = ""
        Try
            Select Case ModeData

                Case DataMode.ModeEdit
                    SQL = " UPDATE RunningFormatSN SET "
                    SQL &= " FormatFront=''"
                    SQL &= " ,FormatDate=@FormatDate"
                    SQL &= " ,FormatMidle=@FormatMidle"
                    SQL &= " ,RunningCount=@RunningCount"
                    SQL &= " ,FormatYear= @FormatYear"
                    SQL &= " ,ModifiedBy= @gUserID"
                    SQL &= " ,ModifiedTime= @CreateTime"
                Case DataMode.ModeDelete
            End Select
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@FormatFront", Trim(FormatFront)))
            myCommand.Parameters.Add(New SqlParameter("@FormatDate", Trim(FormatDate)))
            myCommand.Parameters.Add(New SqlParameter("@FormatMidle", Trim(FormatMidle)))
            myCommand.Parameters.Add(New SqlParameter("@FormatYear", Trim(FormatYear)))
            myCommand.Parameters.Add(New SqlParameter("@RunningCount", ConvertNullToZero(RunningCount)))
            myCommand.Parameters.Add(New SqlParameter("@LastNo", ConvertNullToZero(LastNo)))

            myCommand.Parameters.Add(New SqlParameter("@gUserID", gUserID))
            myCommand.Parameters.Add(New SqlParameter("@CreateTime", formatSQLDateTime(GetCurrentDate(tr))))


            gConnection.executeInsertSqlCommand(myCommand, tr)

            If IsReset = True Then
                Dim lclsSN As New SnDAO
                lclsSN.ResetRunningNo(tr)
            End If


            Return True
        Catch e As Exception

            Err.Raise(Err.Number, e.Source, "RunningFormatDAO.SaveData : " & e.Message)
            Return False
        End Try

    End Function



    Public Function ResetFlag(ByVal tr As SqlTransaction) As Boolean
        Dim SQL As String
        Dim myCommand As SqlCommand

        SQL = ""
        Try
            If IsReset = True And ID > 0 Then

                SQL = " UPDATE RunningFormatSN SET "
                SQL &= " IsReset=0"
                SQL &= " WHERE MenuID= " & ID
                myCommand = New SqlCommand
                myCommand.CommandText = SQL
                gConnection.executeInsertSqlCommand(myCommand, tr)
            End If


            Return True
        Catch e As Exception

            Err.Raise(Err.Number, e.Source, "RunningFormatDAO.ResetFlag : " & e.Message)
            Return False
        End Try

    End Function

    Public Sub New()

        mFormatFront = ""
        mFormatDate = ""
        mFormatMidle = ""
        mRunningCount = 0
        mFormatYear = ""
        mLastNo = 0

        mIsReset = False
    End Sub
End Class
