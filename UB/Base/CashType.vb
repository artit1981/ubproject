Public Class CashType
    Dim mCashTypeCode As String
    Dim mCashTypeName As String

    Public Property CashTypeCode() As String
        Get
            Return mCashTypeCode
        End Get
        Set(ByVal value As String)
            mCashTypeCode = value
        End Set
    End Property

    Public Property CashTypeName() As String
        Get
            Return mCashTypeName
        End Get
        Set(ByVal value As String)
            mCashTypeName = value
        End Set
    End Property

    Public Sub New()
        mCashTypeCode = ""
        mCashTypeName = ""
    End Sub
End Class
