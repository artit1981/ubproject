Public Class ChequeStatus
    Dim mChequeStatusCode As String
    Dim mChequeStatusName As String

    Public Property ChequeStatusCode() As String
        Get
            Return mChequeStatusCode
        End Get
        Set(ByVal value As String)
            mChequeStatusCode = value
        End Set
    End Property

    Public Property ChequeStatusName() As String
        Get
            Return mChequeStatusName
        End Get
        Set(ByVal value As String)
            mChequeStatusName = value
        End Set
    End Property

    Public Sub New()
        mChequeStatusCode = ""
        mChequeStatusName = ""
    End Sub

End Class
