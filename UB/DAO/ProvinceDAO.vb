Option Explicit On
Public Class ProvinceDAO


    Public Function GetDataTable() As DataTable
        Dim SQL As String
        Dim dataTable As New DataTable()

        Try
            SQL = "SELECT  ProvinceName "
            SQL = SQL & " FROM Province   "
            SQL = SQL & " ORDER BY ProvinceName"
            dataTable = gConnection.executeSelectQuery(SQL, Nothing)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ProvinceDAO.GetDataTable : " & e.Message)
        End Try
        Return dataTable
    End Function

End Class
