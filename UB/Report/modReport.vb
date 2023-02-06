Imports DevExpress.XtraReports.UI

'Imports DevExpress.XtraReports.UI
'Imports System.Data.SqlClient

Module modReport
    'Private mOrderType As MasterType
    Public Sub PrintReportOrder(ByVal pMasterType As Long, ByVal pOrderID As Long)
        Dim lfrmReport As New frmPreReport
        lfrmReport.InitialForm(pMasterType, pOrderID, "", GetCurrentDate(Nothing), 0, Nothing, "", Nothing, Nothing)
        lfrmReport.ShowDialog()
        'pReport.ShowPreview()
    End Sub

    Public Sub PrintPayment(ByVal pOrderID As Long)
        Dim lfrmReport As New frmPreReport
        lfrmReport.InitialForm(1000, pOrderID, "", GetCurrentDate(Nothing), 0, Nothing, "", Nothing, Nothing)
        lfrmReport.ShowDialog()
    End Sub

    Public Sub PrintCheque(ByVal pChequeID As Long, ByVal pcls As ChequeDAO)
        Dim lfrmReport As New frmPreReport
        lfrmReport.InitialForm(1001, 0, "", GetCurrentDate(Nothing), pChequeID, pcls, "", Nothing, Nothing)
        lfrmReport.ShowDialog()
    End Sub

    Public Sub PrintBarCode(ByVal pProName As String, ByVal pBarCodeList As List(Of SnDAO))
        Dim lfrmReport As New frmPreReport
        lfrmReport.InitialForm(1002, 0, "", GetCurrentDate(Nothing), 0, Nothing, pProName, pBarCodeList, Nothing)
        lfrmReport.ShowDialog()
    End Sub

    Public Sub ExecuteReportComm(ByVal pReport As XtraReport)
        Dim lfrmReport As New frmPreReport
        lfrmReport.InitialForm(1003, 0, "", GetCurrentDate(Nothing), 0, Nothing, "", Nothing, pReport)
        lfrmReport.ShowDialog()
    End Sub

    Public Sub PrintTaxAtPay(ByVal pOrderID As Long, ByVal pTaxNo As String, ByVal pReportDate As Date)
        Dim lfrmReport As New frmPreReport
        lfrmReport.InitialForm(1004, pOrderID, pTaxNo, pReportDate, 0, Nothing, "", Nothing, Nothing)
        lfrmReport.ShowDialog()
    End Sub

    Public Sub ExecuteReportTax(ByVal pReport As XtraReport)
        Dim lfrmReport As New frmPreReport
        lfrmReport.InitialForm(1005, 0, "", GetCurrentDate(Nothing), 0, Nothing, "", Nothing, pReport)
        lfrmReport.ShowDialog()
    End Sub


    Public Sub BuildCompanyAddress(ByRef pclsReport As TmpOrderDAO, ByVal pType As Integer)
        Dim lclsCompanyDAO As New CompanyDAO
        Try
            If lclsCompanyDAO.InitailData(gCompanyID) Then
                pclsReport.Company = lclsCompanyDAO.CompanyName
                If pType = MasterType.InvoiceOnline Then
                    If ConvertNullToZero(lclsCompanyDAO.IsMainCompany) = 1 Then  ' *** ใช้กลับกัน 0 = is main , 1 2 3 =Brance
                        pclsReport.Company &= " (สำนักงานใหญ่)"
                    Else
                        pclsReport.Company &= " (สาขา " & ConvertNullToZero(lclsCompanyDAO.Branch) & ")"
                    End If
                End If
                If lclsCompanyDAO.Owner = "" Then
                    pclsReport.CompanyOwner = lclsCompanyDAO.CompanyName
                Else
                    pclsReport.CompanyOwner = lclsCompanyDAO.Owner
                End If
                pclsReport.CompanyPhone = lclsCompanyDAO.AddressS.Phone1
                pclsReport.CompanyFAX = lclsCompanyDAO.AddressS.Fax
                pclsReport.CompanyAddress = lclsCompanyDAO.AddressS.AddressShort
                pclsReport.CompanyTax = lclsCompanyDAO.TaxID
                pclsReport.CompanyBankAccount = lclsCompanyDAO.BankAccount
                pclsReport.IsMainCompany = lclsCompanyDAO.IsMainCompany
                pclsReport.CompanyBranch = lclsCompanyDAO.Branch
                pclsReport.CompanyMail = lclsCompanyDAO.AddressS.Email1
                pclsReport.CompanyWeb = lclsCompanyDAO.AddressS.Website
                pclsReport.LogoID = lclsCompanyDAO.HistoryDAO.ImageID
                pclsReport.CompanyBankAccount = lclsCompanyDAO.BankAccount
                If ConvertNullToZero(lclsCompanyDAO.IsMainCompany) = 1 Then  ' *** ใช้กลับกัน 0 = is main , 1 2 3 =Brance
                    pclsReport.IsMainCompany = 0
                Else
                    pclsReport.IsMainCompany = ConvertNullToZero(lclsCompanyDAO.Branch)
                End If
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "modReport.BuildCompanyAddress : " & ex.Message)
        Finally
        End Try
    End Sub

End Module
