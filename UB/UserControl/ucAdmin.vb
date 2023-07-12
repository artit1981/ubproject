Public Class ucAdmin
    Public Sub ClearAll()
        Try

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucAdmin.ClearAll : " & e.Message)
        End Try
    End Sub

End Class
