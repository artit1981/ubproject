Option Explicit On

Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraGrid.Views.Base
Public Class ucContactRole
    Dim mIsError As Boolean

    Public ReadOnly Property IsError() As Boolean
        Get
            Return mIsError
        End Get
    End Property

    Private mDataDAOs As List(Of OppContactRoleDAO)

    Public Function GetDAOs() As List(Of OppContactRoleDAO)
        Dim lRow As Long
        Dim lDataDAO As OppContactRoleDAO
        Dim info As New ErrorInfo()

        Try
            mDataDAOs = New List(Of OppContactRoleDAO)
            mIsError = False
            If gridView.RowCount > 0 Then
                For lRow = 0 To gridView.RowCount
                    If ConvertNullToZero(gridView.GetRowCellValue(lRow, "ContactID")) <> 0 Then
                        lDataDAO = New OppContactRoleDAO
                        lDataDAO.ID = ConvertNullToZero(gridView.GetRowCellDisplayText(lRow, "ID"))
                        lDataDAO.ContactID = ConvertNullToZero(gridView.GetRowCellValue(lRow, "ContactID"))
                        lDataDAO.ContactRole = ConvertNullToString(gridView.GetRowCellDisplayText(lRow, "ContactRole"))
                        mDataDAOs.Add(lDataDAO)
                        TryCast(gridView.GetRow(lRow), MyRecord).GetError(info)
                        If info.ErrorText <> "" Then
                            mIsError = True
                        End If

                    End If
                Next
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucContactRole.GetNoteDAOs : " & e.Message)
        Finally
            lDataDAO = Nothing
        End Try
        Return mDataDAOs
    End Function

    Public Function ShowControl(ByVal pRefID As Long) As Boolean
        Try
            Call LoadData(pRefID)
            LoadComboContactRole()
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucContactRole.ShowControl : " & e.Message)
            Return False
        End Try
    End Function

    Public Sub ClearControl()
        Try
            bindingSource1.DataSource = GetType(MyRecord)
            gridControl.DataSource = bindingSource1
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucContactRole.ClearAll : " & e.Message)
        End Try
    End Sub


    Private Sub LoadData(ByVal pRefID As Long)
        Dim lcls As New OppContactRoleDAO
        Dim dataTable As New DataTable()

        Try
            bindingSource1.DataSource = GetType(MyRecord)

            dataTable = lcls.GetDataTable(pRefID)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    Dim rec As New MyRecord()
                    rec.ID = dr("ID")
                    rec.ContactID = ConvertNullToZero(dr("ContactID"))
                    rec.ContactName = ConvertNullToString(dr("ContactName"))
                    rec.Email1 = ConvertNullToString(dr("Email1"))
                    rec.Phone1 = ConvertNullToString(dr("Phone1"))
                    rec.Fax = ConvertNullToString(dr("Fax"))
                    rec.ContactRole = ConvertNullToString(dr("ContactRole"))
                    bindingSource1.Add(rec)

                Next
            End If
            DxErrorProvider1.DataSource = bindingSource1
            DxErrorProvider1.ContainerControl = Me
            gridControl.DataSource = bindingSource1
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucContactRole.LoadData : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Private Sub LoadComboContactRole()
        Dim lcls As New MasterDAO
        Dim dataTable As New DataTable()
        Dim pTable As String = ""
        pTable = GetMasterTableName(MasterType.ContactRole)
        Try
            If pTable <> "" Then
                ContactRoleComboBox.Items.Clear()
                dataTable = lcls.GetDataTable(0, pTable, True)
                If dataTable.Rows.Count > 0 Then
                    For Each dr As DataRow In dataTable.Rows
                        ContactRoleComboBox.Items.Add(ConvertNullToString(dr("CodeThai")))
                    Next
                End If
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucContactRole.LoadComboContactRole : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub

    Private Function LoadDataContact(ByVal pName As String, ByVal pAutoAdd As Boolean) As String

        Dim lstrName As String
        LoadDataContact = ""
        Try
            If pName = "" Then
                lstrName = ""
            Else
                lstrName = LoadDataTableContact(0, pName, pAutoAdd)
            End If

            If lstrName <> "" Then
                Return lstrName
            Else
                Dim lfrmFind As New frmFindData
                lfrmFind.LookFor = pName
                lfrmFind.Execute(MasterType.Contacts, 0, 0)

                If ConvertNullToZero(lfrmFind.LookFor) = 0 Then
                    Return ""
                Else
                    lstrName = LoadDataTableContact(lfrmFind.LookFor, "", pAutoAdd)
                    If lstrName <> "" Then
                        Return lstrName
                    End If
                End If
                lfrmFind = Nothing
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucContactRole.LoadDataContact : " & e.Message)
        Finally

        End Try
    End Function

    Private Function LoadDataTableContact(ByVal pllngID As Long, ByVal pUnitCode As String, ByVal pAutoAdd As Boolean) As String
        Dim lcls As New CustomerDAO
        Dim lblnIsInitial As Boolean
        LoadDataTableContact = ""
        Try
            lcls.TableID = MasterType.Contacts
            If pUnitCode <> "" Then
                lblnIsInitial = lcls.InitailData(0, pUnitCode)
            Else
                lblnIsInitial = lcls.InitailData(pllngID, "")
            End If

            If lblnIsInitial Then

                If pAutoAdd Then
                    If Not gridView.GetFocusedRow Is Nothing Then
                        gridView.SetFocusedRowCellValue("ContactID", lcls.ID)
                        gridView.SetFocusedRowCellValue("ContactName", ConvertNullToString(lcls.Title & lcls.FirstName & " " & lcls.LastName))
                        gridView.SetFocusedRowCellValue("Email1", ConvertNullToString(lcls.AddressS.Email1))
                        gridView.SetFocusedRowCellValue("Phone1", ConvertNullToString(lcls.AddressS.Phone1))
                        gridView.SetFocusedRowCellValue("Fax", ConvertNullToString(lcls.AddressS.Fax))
                    Else

                        Dim rec = New MyRecord
                        rec.ContactID = lcls.ID
                        rec.ContactName = ConvertNullToString(lcls.NickName & lcls.FirstName & " " & lcls.LastName)
                        rec.Email1 = ConvertNullToString(lcls.AddressS.Email1)
                        rec.Phone1 = ConvertNullToString(lcls.AddressS.Phone1)
                        rec.Fax = ConvertNullToString(lcls.AddressS.Fax)
                        bindingSource1.Add(rec)
                    End If
                Else
                    gridView.SetFocusedRowCellValue("ContactID", lcls.ID)
                    gridView.SetFocusedRowCellValue("ContactName", ConvertNullToString(lcls.Title & lcls.FirstName & " " & lcls.LastName))
                    gridView.SetFocusedRowCellValue("Email1", ConvertNullToString(lcls.AddressS.Email1))
                    gridView.SetFocusedRowCellValue("Phone1", ConvertNullToString(lcls.AddressS.Phone1))
                    gridView.SetFocusedRowCellValue("Fax", ConvertNullToString(lcls.AddressS.Fax))
                End If

                Return ConvertNullToString(lcls.NickName & lcls.FirstName & " " & lcls.LastName)

            Else
                Return ""
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucContactRole.LoadDataTableContact : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Function

    Private Sub gridView_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gridView.ValidateRow
        Dim info As New ErrorInfo()
        TryCast(e.Row, MyRecord).GetError(info)
        e.Valid = info.ErrorText = ""

    End Sub

    Private Sub gridView_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gridView.InvalidRowException
        e.ExceptionMode = ExceptionMode.NoAction
    End Sub


    Private Sub gridView_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles gridView.ValidatingEditor
        If gridView.FocusedColumn.FieldName = "ContactName" Then
            If e.Value = "" Then
                e.Valid = False
                e.ErrorText = "กรุณาระบุข้อมูล"
            Else
                Dim lValue As String = LoadDataContact(e.Value, False)
                If lValue = "" Then
                    e.Valid = False
                    e.ErrorText = "ไม่พบข้อมูล"
                Else
                    e.Valid = True
                    e.Value = lValue
                End If
            End If
        End If
    End Sub


    Private Sub NameBtn_ButtonPressed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles NameBtn.ButtonPressed
        LoadDataContact("", True)
    End Sub

    Public Class MyRecord
        Implements IDXDataErrorInfo

        Private mIDs As Long
        Private mContactID As Long
        Private mContactName As String
        Private mEmail1 As String
        Private mPhone1 As String
        Private mFax As String
        Private mContactRole As String
        

        Public Property ContactRole() As String
            Get
                Return mContactRole
            End Get
            Set(ByVal value As String)
                mContactRole = value
            End Set
        End Property
        Public Property Fax() As String
            Get
                Return mFax
            End Get
            Set(ByVal value As String)
                mFax = value
            End Set
        End Property
        Public Property Phone1() As String
            Get
                Return mPhone1
            End Get
            Set(ByVal value As String)
                mPhone1 = value
            End Set
        End Property
        Public Property Email1() As String
            Get
                Return mEmail1
            End Get
            Set(ByVal value As String)
                mEmail1 = value
            End Set
        End Property
        Public Property ContactName() As String
            Get
                Return mContactName
            End Get
            Set(ByVal Value As String)
                mContactName = value
            End Set
        End Property
        Public Property ContactID() As Long
            Get
                Return mContactID
            End Get
            Set(ByVal Value As Long)
                mContactID = Value
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

#Region "IDXDataErrorInfo Members"
        Public Sub GetPropertyError(ByVal propertyName As String, ByVal info As ErrorInfo) Implements IDXDataErrorInfo.GetPropertyError
            If propertyName = "ContactName" AndAlso String.IsNullOrEmpty(ContactName) Then
                info.ErrorText = String.Format("กรุณาระบุข้อมูล", propertyName)
                info.ErrorType = ErrorType.Critical
            End If
        End Sub


        Public Sub GetError(ByVal info As ErrorInfo) Implements IDXDataErrorInfo.GetError
            Dim propertyInfo As New ErrorInfo()
            GetPropertyError("ContactName", propertyInfo)
            'If propertyInfo.ErrorText = "" Then
            '    GetPropertyError("Rate", propertyInfo)
            'End If
            
        End Sub
#End Region
    End Class



End Class
