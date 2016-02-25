 
Public Class frmNotify
    Private mcls As clsNotifi

    Private Sub frmNotify_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim lRow As Long
        Try
            With GridView
                If .RowCount > 0 Then
                    For lRow = 0 To .RowCount
                        If .GetRowCellValue(lRow, "IsClose") = True Then
                            mcls.CloseNotifi(gUserID, ConvertNullToString(.GetRowCellDisplayText(lRow, "RefTable")), ConvertNullToZero(.GetRowCellValue(lRow, "RefID")))
                        End If
                    Next
                End If
            End With
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub

    Private Sub frmNotify_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmNotify_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim lclsNotifi As List(Of clsNotifi)
        Try
            mcls = New clsNotifi
            mcls.InitialNotifi()
            lclsNotifi = mcls.GetNotifiList(gUserID)
            GridControl.DataSource = lclsNotifi

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
    End Sub
End Class