Public Class ChequeStep
    Dim mChequeStepCode As String
    Dim mChequeStepName As String

    Public Property ChequeStepCode() As String
        Get
            Return mChequeStepCode
        End Get
        Set(ByVal value As String)
            mChequeStepCode = value
        End Set
    End Property

    Public Property ChequeStepName() As String
        Get
            Return mChequeStepName
        End Get
        Set(ByVal value As String)
            mChequeStepName = value
        End Set
    End Property

    Public Sub New()
        mChequeStepCode = ""
        mChequeStepName = ""
    End Sub
End Class
