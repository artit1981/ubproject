Option Explicit On


Public Class frmConvertLead
    Private mConVertType As Integer
    Public ReadOnly Property IsSelectContact() As Integer
        '0 none
        '1 Contact
        '2 Account
        Get
            Return mConVertType
        End Get
    End Property

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If IsContact.EditValue = True Then
            mConVertType = 1
        Else
            mConVertType = 2
        End If
        Me.Close()
    End Sub

    Private Sub frmConvertLead_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        IsContact.EditValue = True
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        mConVertType = 0
        Me.Close()
        'Dim report As New OrdersReport

        'Dim SQL As String
        'Dim lDataTableList As New List(Of DBConnection.DataTableList)


        'Try
        '    Dim lDataTable As DBConnection.DataTableList

        '    SQL = "SELECT Orders.* "
        '    SQL = SQL & " FROM Orders  "
        '    SQL = SQL & " WHERE Orders.OrderID=7"
        '    lDataTable = New DBConnection.DataTableList
        '    lDataTable.SQL = SQL
        '    lDataTable.TableName = "Orders"
        '    lDataTableList.Add(lDataTable)


        '    SQL = "SELECT ProductList.* "
        '    SQL = SQL & " FROM ProductList  "
        '    SQL = SQL & " WHERE ProductList.RefTable='Orders' AND ProductList.RefID=7"
        '    lDataTable = New DBConnection.DataTableList
        '    lDataTable.SQL = SQL
        '    lDataTable.TableName = "ProductList"
        '    lDataTableList.Add(lDataTable)


        '    report.DataSource = gConnection.executeSelectDS(lDataTableList)
        '    report.DetailReport.DataMember = "Orders"
        '    report.DetailReport1.DataMember = "ProductList"
        '    report.ShowPreview()

        'Catch ex As Exception
        '    Err.Raise(Err.Number, ex.Source, "DepartmentControl.LoadData : " & ex.Message)
        'Finally

        '    'DataTable = Nothing
        'End Try

    End Sub
End Class