Option Explicit On
Imports System.Data.SqlClient

Public Class OpportunityStageDAO
    Inherits iDAO
    Private mPercents As Double

#Region "Property"

    Public ReadOnly Property TableName() As String
        Get
            Return "OpportunityStage"
        End Get
    End Property


    Public Property Percents() As Double
        Get
            Return mPercents
        End Get
        Set(ByVal value As Double)
            mPercents = value
        End Set
    End Property

#End Region

    Public Function CHECKSUM_AGG() As Long
        Dim SQL As String
        Dim dataTable As New DataTable()
        Try
            SQL = "SELECT CHECKSUM_AGG(BINARY_CHECKSUM(*)) FROM " & TableName & " WITH (NOLOCK);"

            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    Return ConvertNullToZero(dr(0))
                    Exit For
                Next
            End If
            Return 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "OpportunityStageDAO.CHECKSUM_AGG : " & e.Message)
            Return 0
        Finally
            dataTable = Nothing
        End Try
    End Function


    Public Function InitailData(ByVal pID As Long) As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()
        Dim lUserDAO As New UserDAO
        Try
            SQL = "SELECT *   "
            SQL = SQL & " FROM dbo.OpportunityStage "
            SQL = SQL & " WHERE OpportunityStageID=" & pID

            SQL = SQL & " ORDER BY NameThai"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    ID = Int32.Parse(dr("OpportunityStageID"))
                    IsInActive = dr("IsInActive")
                    NameThai = dr("NameThai").ToString
                    NameEng = dr("NameEng").ToString
                    Remark = dr("Remark").ToString
                    Percents = ConvertNullToZero(dr("Percents"))
                    CreateTime = ConvertNullToDateTime(dr("CreateTime"))
                    ModifiedTime = ConvertNullToDateTime(dr("ModifiedTime"))
                    If lUserDAO.InitailData(True, ConvertNullToZero(dr("CreateBy")), "") Then
                        CreateBy = lUserDAO.UserName
                    Else
                        CreateBy = ""
                    End If

                    If ConvertNullToZero(dr("CreateBy")) = ConvertNullToZero(dr("ModifiedBy")) Then
                        ModifiedBy = CreateBy
                    Else
                        If lUserDAO.InitailData(True, ConvertNullToZero(dr("ModifiedBy")), "") Then
                            ModifiedBy = lUserDAO.UserName
                        Else
                            ModifiedBy = ""
                        End If
                    End If

                    FileAttachs = LoadFileAttach(ID, TableName, Nothing)

                    Return True
                    Exit For
                Next
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "OpportunityStageDAO.InitailData : " & e.Message)
            Return False
        Finally
            lUserDAO = Nothing
            dataTable = Nothing
        End Try

    End Function


    Public Function GetInfoHtml() As String
        Dim Info As String = ""
        'Try

        '    Info = Constants.vbCrLf & Constants.vbCrLf & "ชื่อแผนก: " & NameThai
        '    Info &= Constants.vbCrLf & "ชื่อแผนก: " & NameThai
        '    Info &= Constants.vbCrLf & "ชื่อแผนก (Eng): " & NameEng
        '    Info &= Constants.vbCrLf & "หัวหน้าแผนก: "
        '    If Not Manager Is Nothing Then
        '        Info &= Manager.Title & Manager.FirstName & " " & Manager.LastName
        '    End If
        '    Info &= Constants.vbCrLf & "รายละเอียด: " & Remark

        'Catch e As Exception
        '    Err.Raise(Err.Number, e.Source, "OpportunityStageDAO.GetInfoHtml : " & e.Message)

        'End Try
        Return Info
    End Function


    Public Function GetDataTable(ByVal pID As Long, ByVal pOnlyActive As Boolean) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT OpportunityStageID AS ID,NameThai,Percents"
            SQL = SQL & " FROM OpportunityStage  "
            SQL = SQL & " WHERE IsDelete =0   "
            If pID > 0 Then
                SQL = SQL & "  AND OpportunityStageID=" & pID
            End If
            If pOnlyActive = True Then
                SQL = SQL & "  AND IsInActive = 0"
            End If
            SQL = SQL & " ORDER BY NameThai"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "OpportunityStageDAO.GetDataTable : " & e.Message)
        End Try
        Return dataTable
    End Function

    Public Function SaveData() As Boolean
        Dim SQL As String
        Dim llngAddressID As Long = 0
        Dim myCommand As SqlCommand
        Dim tr As SqlTransaction = Nothing
        SQL = ""
        Try

            tr = gConnection.Connection.BeginTransaction

            Select Case ModeData
                Case DataMode.ModeNew
                    ID = GenNewID("OpportunityStageID", "OpportunityStage", tr)
                    SQL = " INSERT INTO OpportunityStage  (OpportunityStageID,Percents,NameThai,NameEng,Remark"
                    SQL = SQL & " ,CreateBy,CreateTime,IsInActive,IsDelete)"
                    SQL = SQL & " VALUES ( @mIDs"
                    SQL = SQL & " ,  @Percents"
                    SQL = SQL & " ,  @mNameThai"
                    SQL = SQL & " ,  @mNameEng"
                    SQL = SQL & " ,  @mRemark"
                    SQL = SQL & " ,  @gUserID"
                    SQL = SQL & " ,  @CreateTime"
                    SQL = SQL & " ,  @mIsInActive"
                    SQL = SQL & " ,  @mIsDelete"
                    SQL = SQL & " ) "
                Case DataMode.ModeEdit
                    SQL = " UPDATE OpportunityStage SET "
                    SQL = SQL & " ,NameThai=@mNameThai"
                    SQL = SQL & " ,Percents=@Percents"
                    SQL = SQL & " ,NameEng=@mNameEng"
                    SQL = SQL & " ,Remark= @mRemark"
                    SQL = SQL & " ,ModifiedBy= @gUserID"
                    SQL = SQL & " ,ModifiedTime= @CreateTime"
                    SQL = SQL & " ,IsInActive= @mIsInActive"
                    SQL = SQL & " WHERE OpportunityStageID= @mIDs"
                Case DataMode.ModeDelete
                    SQL = " UPDATE OpportunityStage SET IsDelete=@mIsDelete "
                    SQL = SQL & " ,ModifiedBy= @gUserID"
                    SQL = SQL & " ,ModifiedTime= @CreateTime"
                    SQL = SQL & " WHERE OpportunityStageID= @mIDs"
            End Select
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@mIDs", ID))
            myCommand.Parameters.Add(New SqlParameter("@Percents", Percents))
            myCommand.Parameters.Add(New SqlParameter("@mNameThai", Trim(NameThai)))
            myCommand.Parameters.Add(New SqlParameter("@mNameEng", Trim(NameEng)))
            myCommand.Parameters.Add(New SqlParameter("@mRemark", Trim(Remark)))
            myCommand.Parameters.Add(New SqlParameter("@gUserID", gUserID))
            myCommand.Parameters.Add(New SqlParameter("@CreateTime", formatSQLDateTime(GetCurrentDate(tr))))
            myCommand.Parameters.Add(New SqlParameter("@mIsInActive", IsInActive))

            Select Case ModeData
                Case DataMode.ModeNew
                    myCommand.Parameters.Add(New SqlParameter("@mIsDelete", 0))
                Case DataMode.ModeDelete
                    myCommand.Parameters.Add(New SqlParameter("@mIsDelete", 1))
            End Select
            gConnection.executeInsertSqlCommand(myCommand, tr)

            'Save Note
            SaveNote(NoteDAOs, ModeData, ID, TableName, tr)

            'Save Attach file
            SaveAttachFile(FileAttachs, ModeData, ID, TableName, tr)



            tr.Commit()
            Return True
        Catch e As Exception
            tr.Rollback()
            Err.Raise(Err.Number, e.Source, "OpportunityStageDAO.SaveData : " & e.Message)
            Return False
        End Try

    End Function

    Public Function CheckExist() As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT DepartmentID  FROM Department"
            SQL = SQL & " WHERE IsDelete =0 AND IDCode='" & Trim(Code) & "'"
            If ModeData = DataMode.ModeEdit Then
                SQL = SQL & " AND DepartmentID <> " & ID
            End If
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            Return dataTable.Rows.Count > 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "OpportunityStageDAO.CheckExist : " & e.Message)
            Return False
        Finally
            dataTable = Nothing
        End Try

    End Function

    Public Function CheckIsToUse() As Boolean ''ถูกใช้งานอยู่ ???

        'Dim SQL As String
        'Dim dataTable As New DataTable()

        'Try
        '    SQL = "SELECT DepartmentID  FROM Position"
        '    SQL = SQL & " WHERE IsDelete =0 AND DepartmentID=" & ID
        '    dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        '    Return dataTable.Rows.Count = 0
        'Catch e As Exception
        '    Err.Raise(Err.Number, e.Source, "OpportunityStageDAO.CheckNotExist : " & e.Message)
        'Finally
        '    dataTable = Nothing
        'End Try
        Return False
    End Function

    Public Sub New()
        mPercents = 0
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
