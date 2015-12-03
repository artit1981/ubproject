
Option Explicit On
 
Public Class frmFindData
    Dim mKey As String
    Dim mType As MasterType
    Dim mProductID As Long

    Public Property LookFor() As String
        Get
            Return mKey
        End Get
        Set(ByVal value As String)
            mKey = value
        End Set
    End Property

    Public Sub Execute(ByRef pLookFor As Integer, ByVal pProductID As Long)
        'pProductID Use for filter UOM
        Try
            mType = pLookFor
            mProductID = pProductID
            Select Case mType
                Case MasterType.UnitBar
                    If pProductID > 0 Then
                        LoadDataUOM(pProductID)
                    Else
                        LoadDataUnit()
                    End If
                Case MasterType.Contacts : LoadDataContact()
                Case MasterType.Employee : LoadDataEmp()
            End Select

            Me.ShowDialog()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try

    End Sub


    Private Sub LoadDataUnit()
        Dim lcls As New UnitDAO
        Dim dataTable As New DataTable()
        Try
            dataTable = lcls.GetDataTable(0, True)
            If dataTable.Rows.Count > 0 Then
                GridControl.DataSource = dataTable
                GridView.ViewCaption = "หน่วยนับ"
            Else
                GridControl.DataSource = Nothing
            End If
            With GridView
                .Columns("ID").Visible = False
                
                .Columns("UnitCode").Caption = "รหัสหน่วยนับ"
                .Columns("UnitCode").Width = 400

                .Columns("CodeThai").Caption = "ชื่อหน่วยนับ"
                .Columns("CodeThai").Width = 700
               
            End With
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "frmFindData.LoadDataUnit : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub


    Private Sub LoadDataUOM(ByVal pProductID As Long)
        Dim lcls As New ProductUnitDAO
        Dim dataTable As New DataTable()
        Try
            dataTable = lcls.GetDataTable(pProductID, 2, 0, "")
            If dataTable.Rows.Count > 0 Then
                GridControl.DataSource = dataTable
                GridView.ViewCaption = "หน่วยนับ"
                With GridView
                    .Columns("ID").Visible = False
                    .Columns("SEQ").Visible = False
                    .Columns("UnitID").Visible = False
                    .Columns("Remark").Visible = False
                    .Columns("RefID").Visible = False
                    .Columns("IsInActive").Visible = False

                    .Columns("UnitCode").Caption = "รหัสหน่วยนับ"
                    .Columns("UnitCode").Width = 400

                    .Columns("UnitName").Caption = "ชื่อหน่วยนับ"
                    .Columns("UnitName").Width = 700
                    .Columns("Rate").Caption = "อัตราส่วน"
                    .Columns("Rate").Width = 300

                End With
            Else
                GridControl.DataSource = Nothing
            End If
          
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "frmFindData.LoadDataUOM : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub
     

    Private Sub LoadDataContact()
        Dim lcls As New CustomerDAO
        Dim dataTable As New DataTable()
        Try
            lcls.TableID = MasterType.Contacts
            dataTable = lcls.GetDataTableForCombo(True, False, False)
            If dataTable.Rows.Count > 0 Then
                GridControl.DataSource = dataTable
                GridView.ViewCaption = "Contacts"
            Else
                GridControl.DataSource = Nothing
            End If
            With GridView
                .Columns("ID").Visible = False
                .Columns("Code").Caption = "รหัสลูกค้า"
                .Columns("Code").Width = 300
                .Columns("CusName").Caption = "ชื่อ - นามสกุล"
                .Columns("CusName").Width = 250
                .Columns("CompanyName").Caption = "ชื่อบริษัท"
                .Columns("CompanyName").Width = 250
                .Columns("EMPNAME").Caption = "ผู้รับผิดชอบ"
                .Columns("EMPNAME").Width = 250
                .Columns("ModifiedTime").Visible = False
                .Columns("Phone1").Caption = "โทรศัพท์"
                .Columns("Phone1").Width = 100
                .Columns("Fax").Caption = "โทรสาร"
                .Columns("Fax").Width = 100
                .Columns("Email1").Caption = "อีเมล์"
                .Columns("Email1").Width = 100
            End With
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "frmFindData.LoadDataContact : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub

    Private Sub LoadDataEmp()
        Dim lcls As New EmployeeDAO
        Dim dataTable As New DataTable()
        Try 'EmpID AS ID,EmpCode,Title + Firstname + ' ' + LastName AS NAME
            dataTable = lcls.GetDataTableForCombo(0, True)
            'dataTable.Columns.Add("IsSelect")
            If dataTable.Rows.Count > 0 Then
                GridControl.DataSource = dataTable
                GridView.ViewCaption = "Employee"
            Else
                GridControl.DataSource = Nothing
            End If
            With GridView
                .Columns("ID").Visible = False
                .Columns("EmpCode").Caption = "รหัสพนักงาน"
                .Columns("EmpCode").Width = 300
                .Columns("NAME").Caption = "ชื่อ - นามสกุล"
                .Columns("NAME").Width = 500
                
            End With
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "frmFindData.LoadDataEmp : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub


    Private Sub frmFindData_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            GridView.OptionsFind.AllowFindPanel = True
            GridView.OptionsFind.AlwaysVisible = True
            GridView.OptionsFind.HighlightFindResults = True
            GridView.OptionsFind.ShowCloseButton = False
            GridView.OptionsFind.FindFilterColumns = "*"

            GridView.ShowFindPanel()
            GridView.ApplyFindFilter(mKey)
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try
         
    End Sub
      

    Private Sub GridControl_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl.KeyDown
        If e.KeyData = Keys.Enter Then
            GetKey()
            Me.Close()
        End If
    End Sub

  
    Private Sub GridView_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView.DoubleClick
        GetKey()
        Me.Close()
    End Sub

    Private Sub GetKey()
        Try
            If mType = MasterType.UnitBar Then
                If mProductID > 0 Then ''UOM
                    LookFor = GridView.GetFocusedRowCellValue("UnitID")
                Else ''Unit
                    LookFor = GridView.GetFocusedRowCellValue("ID")
                End If
                GridView.GetSelectedRows()
            Else
                LookFor = GridView.GetFocusedRowCellValue("ID")
            End If

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try
    End Sub

    Private Sub frmFindData_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class