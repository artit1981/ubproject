Imports DevExpress.XtraEditors

Public Class ucInfo

    Public Sub Init(ByVal pInfo As String, ByVal pFILEID As Image)
        Try
            'txtInfo.Text = pInfo
            MemoEdit1.Text = pInfo
            picInfo.Image = pFILEID
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
        End Try
    End Sub

    
End Class
