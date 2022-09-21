
Public Class frmOverdue

    Private mOverdueData As DataTable
    Public WriteOnly Property OverdueData() As DataTable
        Set(ByVal value As DataTable)
            mOverdueData = value
        End Set
    End Property


    Private Sub frmOverdue_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmOverdue_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try

            GridControl.DataSource = mOverdueData

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub
End Class