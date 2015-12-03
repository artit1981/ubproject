Public Class BankDocType
    Dim mBankDocTypeCode As String
    Dim mBankDocTypeName As String
    Dim mCashTypeCode As String

    Public Property CashTypeCode() As String
        Get
            Return mCashTypeCode
        End Get
        Set(ByVal value As String)
            mCashTypeCode = value
        End Set
    End Property

    Public Property BankDocTypeCode() As String
        Get
            Return mBankDocTypeCode
        End Get
        Set(ByVal value As String)
            mBankDocTypeCode = value
        End Set
    End Property

    Public Property BankDocTypeName() As String
        Get
            Return mBankDocTypeName
        End Get
        Set(ByVal value As String)
            mBankDocTypeName = value
        End Set
    End Property

    Public Sub New()
        mBankDocTypeCode = ""
        mBankDocTypeName = ""
        mCashTypeCode = ""
    End Sub
End Class
