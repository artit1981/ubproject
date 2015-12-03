Imports System.Data.SqlClient

Module modConfig
    Public Enum eViewLevel
        OnlyOwner = 1
        Group = 2
        All = 3
    End Enum

    'Approve
    Public gCompanyID As Long
    Public gIsApproveQua As Boolean
    Public gIsApproveReserve As Boolean
    Public gIsApproveSellOrder As Boolean
    Public gIsApproveOffer As Boolean
    Public gIsApproveBuyOrder As Boolean
    Public gIsCheckLimitReserve As Boolean
    Public gIsCheckLimitSellOrder As Boolean
    Public gViewLevel As eViewLevel
    Public gLimitAmount As Double
 
End Module
