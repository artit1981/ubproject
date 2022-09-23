
Imports System.Data.SqlClient


Public Class LocatonDAO
    Inherits iDAO

    Private mEmpID As Long
    Private mEmpGroupID As Long
    Private mPrivilegeBy As String
    Private mAddressDAO As AddressDAO
    Private mclsEmployee As EmployeeDAO
    Private mclsEmployeeGroup As MasterDAO
    Private mLocationDtlDAOs As List(Of LocationDTLDAO)

    Public Property LocationDtlDAOs() As List(Of LocationDTLDAO)
        Get
            Return mLocationDtlDAOs
        End Get
        Set(ByVal Value As List(Of LocationDTLDAO))
            mLocationDtlDAOs = Value
        End Set
    End Property

    Public Property AddressS() As AddressDAO
        Get
            Return mAddressDAO
        End Get
        Set(ByVal Value As AddressDAO)
            mAddressDAO = Value
        End Set
    End Property

    Public Property PrivilegeBy() As String
        Get
            Return mPrivilegeBy
        End Get
        Set(ByVal value As String)
            mPrivilegeBy = value
        End Set

    End Property
    Public Property EmpGroupID() As Long
        Get
            Return mEmpGroupID
        End Get
        Set(ByVal value As Long)
            mEmpGroupID = value
        End Set

    End Property

    Public ReadOnly Property EmpGroup() As MasterDAO
        Get
            If EmpGroupID > 0 And mclsEmployeeGroup Is Nothing Then
                mclsEmployeeGroup = Nothing
                mclsEmployeeGroup = New MasterDAO
                mclsEmployeeGroup.InitailData(EmpGroupID, MasterType.EmpGroup)
            End If
            Return mclsEmployeeGroup
        End Get
    End Property

    Public Property EmpID() As Long
        Get
            Return mEmpID
        End Get
        Set(ByVal value As Long)
            mEmpID = value
        End Set
    End Property

    Public ReadOnly Property Employee() As EmployeeDAO
        Get
            If EmpGroupID > 0 And mclsEmployee Is Nothing Then
                mclsEmployee = Nothing
                mclsEmployee = New EmployeeDAO
                mclsEmployee.InitailData(EmpID)
            End If
            Return mclsEmployee
        End Get
    End Property

    Public ReadOnly Property TableName() As String
        Get
            Return "Product_Location"
        End Get
    End Property

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
            Err.Raise(Err.Number, e.Source, "LocatonDAO.CHECKSUM_AGG : " & e.Message)
            Return 0
        Finally
            dataTable = Nothing
        End Try
    End Function

    Public Function InitailData(ByVal pID As Long, ByRef tr As SqlTransaction) As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()
        Dim lUserDAO As New UserDAO
        Try
            SQL = "SELECT *   "
            SQL &=  " FROM " & TableName
            SQL &=  " WHERE LocationID=" & pID

            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows

                    ID = Int32.Parse(dr("LocationID"))
                    IsInActive = dr("IsInActive")
                    NameThai = dr("NameThai").ToString
                    NameEng = dr("NameEng").ToString
                    Code = dr("IDCode").ToString
                    Remark = dr("Remark").ToString
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

                    EmpID = ConvertNullToZero(dr("EmpID"))
                    PrivilegeBy = ConvertNullToString(dr("PrivilegeBy"))
                    EmpGroupID = ConvertNullToZero(dr("EmpGroupID"))

                    'Load AddressDAO
                    AddressS = Nothing
                    AddressS = New AddressDAO
                    AddressS.InitailData(ConvertNullToZero(dr("AddressID")), tr)

                    'Load FileAttach
                    FileAttachs = LoadFileAttach(ID, TableName, tr)

                    Return True
                    Exit For
                Next
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "LocatonDAO.InitailData : " & e.Message)
            Return False
        Finally
            lUserDAO = Nothing
            dataTable = Nothing
        End Try

    End Function

    Public Function LocationDtl(ByVal ID As Long, ByRef pTr As SqlTransaction) As List(Of LocationDTLDAO)
        Dim dataTable As New DataTable()
        Dim lDataDAO As New LocationDTLDAO
        Dim LocationDtls = New List(Of LocationDTLDAO)()
        Try
            dataTable = Nothing
            dataTable = lDataDAO.GetDataTable(ID, pTr)
            If dataTable.Rows.Count > 0 Then
                For Each dr2 As DataRow In dataTable.Rows
                    lDataDAO = New LocationDTLDAO()
                    lDataDAO.ModeData = DataMode.ModeEdit
                    lDataDAO.ID = Int32.Parse(dr2("ID"))
                    lDataDAO.IDCode = ConvertNullToString(dr2("IDCode"))
                    lDataDAO.NameThai = ConvertNullToString(dr2("NameThai"))
                    lDataDAO.Remark = ConvertNullToString(dr2("Remark"))

                    LocationDtls.Add(lDataDAO)
                Next
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "LocatonDAO.LocationDtl : " & e.Message)
        Finally
            lDataDAO = Nothing
            dataTable = Nothing
        End Try
        Return LocationDtls
    End Function

    Public Function GetInfoHtml() As String
        Dim Info As String = ""
        Try

            Info = Constants.vbCrLf & Constants.vbCrLf & "รหัสคลัง: " & Code
            Info &= Constants.vbCrLf & "ชื่อคลัง: " & NameThai
            Info &= Constants.vbCrLf & "ชื่อคลัง (Eng): " & NameEng
            Info &= Constants.vbCrLf & "ผู้ดูแล: "
            If Not Employee Is Nothing Then
                Info &= Employee.Title & Employee.FirstName & " " & Employee.LastName
            End If
            Info &= Constants.vbCrLf & "สิทธิ์การใช้งาน: " & PrivilegeBy
            Info &= Constants.vbCrLf & "กลุ่มพนักงาน: "
            If Not EmpGroup Is Nothing Then
                Info &= EmpGroup.NameThai
            End If
            Info &= Constants.vbCrLf & "รายละเอียด: " & Remark

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "LocatonDAO.GetInfoHtml : " & e.Message)

        End Try
        Return Info
    End Function

    Public Function GetDataTable(ByVal pID As Long, ByVal pOnlyActive As Boolean) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT LocationID AS ID,IDCode,NameThai,PrivilegeBy "
            SQL &=  " FROM Product_Location  "
            SQL &=  " WHERE IsDelete =0   "
            If pID > 0 Then
                SQL &=  "  AND LocationID=" & pID
            End If
            If pOnlyActive = True Then
                SQL &=  "  AND IsInActive = 0"
            End If
            SQL &=  " ORDER BY IDCode,NameThai"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "LocatonDAO.GetDataTable : " & e.Message)
        End Try
        Return dataTable
    End Function

    Public Function GetDataTableCombo(ByVal pID As Long, ByVal pOnlyActive As Boolean) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT LocationID AS ID,IDCode,NameThai"
            SQL &=  " FROM Product_Location "

            SQL &=  " WHERE IsDelete =0   "
            If pID > 0 Then
                SQL &=  "  AND LocationID=" & pID
            End If
            If pOnlyActive = True Then
                SQL &=  "  AND IsInActive = 0"
            End If
            SQL &=  " ORDER BY IDCode,NameThai"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "LocatonDAO.GetDataTable : " & e.Message)
        End Try
        Return dataTable
    End Function

    Public Function GetDataTableDTL(ByVal pOnlyActive As Boolean) As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT P.LocationID AS LocationID,D.NameThai AS LocationDTL,D.LocationDTLID  "
            SQL &=  " FROM Product_LocationDTL D"
            SQL &=  " LEFT OUTER JOIN Product_Location P ON D.RefID=P.LocationID AND P.IsDelete =0   "
            'SQL = SQL & " WHERE D.IsDelete =0   "

            If pOnlyActive = True Then
                SQL &=  "  AND IsInActive = 0"
            End If
            'SQL = SQL & " ORDER BY P.NameThai ,D.NameThai"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "LocatonDAO.GetDataTableDTL : " & e.Message)
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

            llngAddressID = SaveAddress(AddressS, ModeData, tr)

            Select Case ModeData
                Case DataMode.ModeNew

                    ID = GenNewID("LocationID", "Product_Location", tr)
                    SQL = " INSERT INTO Product_Location  (LocationID,IDCode,NameThai,NameEng"
                    SQL &=  " ,Remark,EmpID,PrivilegeBy,EmpGroupID "
                    SQL &=  " ,CreateBy,CreateTime,IsInActive,IsDelete "

                    SQL &=  " )"
                    SQL &=  " VALUES ( @mIDs"
                    SQL &=  " ,  @IDCode"
                    SQL &=  " ,  @NameThai"
                    SQL &=  " ,  @NameEng"
                    SQL &=  " ,  @Remark"
                    SQL &=  " ,  @EmpID"
                    SQL &=  " ,  @PrivilegeBy"
                    SQL &=  " ,  @EmpGroupID"
                    SQL &=  " ,  @gUserID"
                    SQL &=  " ,  @CreateTime"
                    SQL &=  " ,  @mIsInActive"
                    SQL &=  " ,  @mIsDelete"
                    SQL &=  " ) "
                Case DataMode.ModeEdit
                    SQL = " UPDATE Product_Location SET "
                    SQL &=  " IDCode=@IDCode"
                    SQL &=  " ,NameThai=@NameThai"
                    SQL &=  " ,NameEng=@NameEng"
                    SQL &=  " ,Remark=@Remark"
                    SQL &=  " ,EmpID=@EmpID"
                    SQL &=  " ,PrivilegeBy=@PrivilegeBy"
                    SQL &=  " ,EmpGroupID=@EmpGroupID"
                    SQL &=  " ,ModifiedBy= @gUserID"
                    SQL &=  " ,ModifiedTime= @CreateTime"
                    SQL &=  " ,IsInActive= @mIsInActive"
                    SQL &=  " WHERE LocationID= @mIDs"
                Case DataMode.ModeDelete
                    SQL = " UPDATE Product_Location SET IsDelete=@mIsDelete "
                    SQL &=  " ,ModifiedBy= @gUserID"
                    SQL &=  " ,ModifiedTime= @CreateTime"
                    SQL &=  " WHERE LocationID= @mIDs"
            End Select
            myCommand = New SqlCommand
            myCommand.CommandText = SQL
            myCommand.Parameters.Add(New SqlParameter("@mIDs", ID))
            myCommand.Parameters.Add(New SqlParameter("@IDCode", Trim(Code)))
            myCommand.Parameters.Add(New SqlParameter("@NameThai", Trim(NameThai)))
            myCommand.Parameters.Add(New SqlParameter("@NameEng", Trim(NameEng)))
            myCommand.Parameters.Add(New SqlParameter("@Remark", Trim(Remark)))
            myCommand.Parameters.Add(New SqlParameter("@EmpID", ConvertNullToZero(EmpID)))
            myCommand.Parameters.Add(New SqlParameter("@PrivilegeBy", ConvertNullToString(PrivilegeBy)))
            myCommand.Parameters.Add(New SqlParameter("@EmpGroupID", ConvertNullToZero(EmpGroupID)))

            myCommand.Parameters.Add(New SqlParameter("@gUserID", gUserID))
            myCommand.Parameters.Add(New SqlParameter("@CreateTime", formatSQLDateTime(GetCurrentDate(tr))))
            myCommand.Parameters.Add(New SqlParameter("@mIsInActive", IsInActive))

            myCommand.Parameters.Add(New SqlParameter("@AddressID", llngAddressID))
            Select Case ModeData
                Case DataMode.ModeNew
                    myCommand.Parameters.Add(New SqlParameter("@mIsDelete", 0))
                Case DataMode.ModeDelete
                    myCommand.Parameters.Add(New SqlParameter("@mIsDelete", 1))
            End Select

            gConnection.executeInsertSqlCommand(myCommand, tr)

            'Save SaveLocationDtl
            SaveLocationDtl(tr)

            'Save Note
            SaveNote(NoteDAOs, ModeData, ID, TableName, tr)

            'Save Attach file
            SaveAttachFile(FileAttachs, ModeData, ID, TableName, tr)

            tr.Commit()
            Return True
        Catch e As Exception
            tr.Rollback()
            Err.Raise(Err.Number, e.Source, "LocatonDAO.SaveData : " & e.Message)
            Return False
        End Try

    End Function

    Private Sub SaveLocationDtl(ByVal tr As SqlTransaction)
        Dim lstrStayIDList As String = ""
        Try
            If LocationDtlDAOs Is Nothing Then
                LocationDtlDAOs = LocationDtl(ID, tr)
            End If
            If LocationDtlDAOs Is Nothing Then

            ElseIf LocationDtlDAOs.Count = 0 Then
                'If ModeData <> DataMode.ModeDelete Then
                '    Dim Note = New NoteDAO
                '    Note.RefID = ID
                '    Note.RefTable = TableName
                '    Note.ModeData = ModeData
                '    myCommand = Nothing
                '    myCommand = Note.SaveData
                'End If
            Else
                For Each Location As LocationDTLDAO In LocationDtlDAOs
                    Location.RefID = ID
                    If ModeData = DataMode.ModeDelete Then
                        Location.ModeData = DataMode.ModeDelete
                    End If
                    If Location.SaveData(tr) Then
                        If ModeData = DataMode.ModeEdit Then
                            If Location.ID > 0 Then
                                lstrStayIDList = IIf(lstrStayIDList = "", Location.ID, lstrStayIDList & "," & Location.ID)
                            End If
                        End If
                    End If
                Next

                'Delete Remove Item
                Dim Location2 As New LocationDTLDAO
                Location2.RefID = ID
                If ModeData = DataMode.ModeEdit And lstrStayIDList <> "" Then
                    Location2.DeleteRemoveData(tr, lstrStayIDList)
                End If

            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "LocatonDAO.SaveLocationDtl : " & e.Message)
        End Try
    End Sub

    Public Function CheckExist() As Boolean
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT LocationID  FROM Product_Location"
            SQL &=  " WHERE IsDelete =0  "
            SQL &=  "  AND IDCode='" & Trim(Code) & "'"
            If ModeData = DataMode.ModeEdit Then
                SQL &=  " AND LocationID <> " & ID
            End If
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            Return dataTable.Rows.Count > 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "LocatonDAO.CheckExist : " & e.Message)
            Return False
        Finally
            dataTable = Nothing
        End Try

    End Function

    Public Function CheckIsToUse() As Boolean ''ถูกใช้งานอยู่ ???

        'Dim SQL As String
        'Dim dataTable As New DataTable()

        Try
            'SQL = "SELECT LeadID  FROM Lead"
            'SQL = SQL & " WHERE IsDelete =0 AND Subject='" & Trim(mSubject) & "'"
            'If mMode = DataMode.ModeEdit Then
            '    SQL &=  " AND LeadID <> " & mIDs
            'End If
            'dataTable = gConnection.executeSelectQuery(SQL, Nothing)
            'Return dataTable.Rows.Count > 0
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "LocatonDAO.CheckNotExist : " & e.Message)
        End Try
        Return False
    End Function


    Public Sub New()
        mEmpID = 0
        mEmpGroupID = 0
        mPrivilegeBy = ""
        mAddressDAO = Nothing
        mclsEmployee = Nothing
        mclsEmployeeGroup = Nothing
    End Sub
End Class
