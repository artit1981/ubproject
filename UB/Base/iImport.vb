Public Interface iImport
    ''Property DataDAOs() As Object

    Property DataDAOs As List(Of Object)

    Sub LoadFileToGrid(ByVal pDataTable As DataTable, ByRef pBindingSource As BindingSource)

End Interface
