Public Class ucCampaignDTL
    Public Function ShowControl(ByVal pCampaignDTLList As List(Of CampaignDetail))
        Try
            GridControl1.DataSource = pCampaignDTLList
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucCampaignDTL.ShowControl : " & e.Message)
            Return False
        End Try
    End Function
End Class
