Public Class CostType
    Dim mCostTypeID As ProductCostDAO.CostTypes
    Dim mCostTypeName As String

    Public Property CostTypeCode() As ProductCostDAO.CostTypes
        Get
            Return mCostTypeID
        End Get
        Set(ByVal value As ProductCostDAO.CostTypes)
            mCostTypeID = value
        End Set
    End Property

    Public Property CostTypeName() As String
        Get
            Return mCostTypeName
        End Get
        Set(ByVal value As String)
            mCostTypeName = value
        End Set
    End Property

    Public Sub New()
        mCostTypeID = ProductCostDAO.CostTypes.Average
        mCostTypeName = ""
    End Sub
End Class
