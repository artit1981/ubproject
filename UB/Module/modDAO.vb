﻿Option Explicit On

Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Controls

Module modDAO

    Public Sub SetComboMaster(ByVal pCombo As DevExpress.XtraEditors.ComboBoxEdit, ByVal pMasterType As MasterType, ByVal pUseCodeThai As Boolean)
        Dim lcls As New MasterDAO
        Dim dataTable As New DataTable()
        Dim pTable As String = ""

        pTable = GetMasterTableName(pMasterType)
        Try
            If pTable <> "" Then
                pCombo.Properties.Items.Clear()
                dataTable = lcls.GetDataTable(0, pTable, True)
                If dataTable.Rows.Count > 0 Then
                    For Each dr As DataRow In dataTable.Rows
                        If pUseCodeThai Then
                            pCombo.Properties.Items.Add(ConvertNullToString(dr("CodeThai")))
                        Else
                            pCombo.Properties.Items.Add(ConvertNullToString(dr("CodeEng")))
                        End If

                    Next
                End If
                pCombo.SelectedIndex = -1
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SetComboMaster : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try

    End Sub

    Public Sub SetComboMasterLook(ByVal pCombo As DevExpress.XtraEditors.LookUpEdit, ByVal pMasterType As MasterType, Optional ByVal pSortByID As Boolean = False)
        Dim lcls As New MasterDAO
        Dim dataTable As New DataTable()
        Dim pTable As String = ""

        pTable = GetMasterTableName(pMasterType)
        Try
            dataTable = lcls.GetDataTable(0, pTable, True, pSortByID)
            pCombo.Properties.DataSource = dataTable
            pCombo.Properties.DisplayMember = "CodeThai"
            pCombo.Properties.ValueMember = "ID"
            pCombo.EditValue = DBNull.Value
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SetComboMasterLook : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub

    Public Sub SetLookUpTerritory(ByVal pCombo As DevExpress.XtraEditors.LookUpEdit)
        Dim lcls As New TerritoryDAO
        Dim dataTable As New DataTable()


        Try
            dataTable = lcls.GetDataTable(0, True)
            pCombo.Properties.DataSource = dataTable
            pCombo.Properties.DisplayMember = "NameThai"
            pCombo.Properties.ValueMember = "ID"
            pCombo.EditValue = DBNull.Value
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SetLookUpTerritory : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try

    End Sub


    Public Sub SetLookUpCreditRole(ByVal pCombo As DevExpress.XtraEditors.LookUpEdit)
        Dim lcls As New CreditRoleDAO
        Dim dataTable As New DataTable()


        Try
            dataTable = lcls.GetDataTable(0, True)
            pCombo.Properties.DataSource = dataTable
            pCombo.Properties.DisplayMember = "CreditRoleCode"
            pCombo.Properties.ValueMember = "ID"
            pCombo.EditValue = DBNull.Value
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SetLookUpCreditRole : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try

    End Sub



    Public Sub SetLookUpCreditGroup(ByVal pCombo As DevExpress.XtraEditors.LookUpEdit)
        Dim lcls As New CreditGroupDAO
        Dim dataTable As New DataTable()


        Try
            dataTable = lcls.GetDataTable(0, True)
            pCombo.Properties.DataSource = dataTable
            pCombo.Properties.DisplayMember = "CreditGroupCode"
            pCombo.Properties.ValueMember = "ID"
            pCombo.EditValue = DBNull.Value
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SetLookUpCreditGroup : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try

    End Sub



    Public Sub SetLookUpProType(ByVal pCombo As DevExpress.XtraEditors.LookUpEdit, ByVal pProCategoryID As Long)
        Dim lcls As New ProductTypeDAO
        Dim dataTable As New DataTable()

        Try
            dataTable = lcls.GetDataTable(0, True, pProCategoryID)
            pCombo.Properties.DataSource = dataTable
            pCombo.Properties.DisplayMember = "NameThai"
            pCombo.Properties.ValueMember = "ID"
            pCombo.EditValue = DBNull.Value
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SetLookUpProType : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try


    End Sub

    Public Sub SetLookUpProCategory(ByVal pCombo As DevExpress.XtraEditors.LookUpEdit)
        Dim lcls As New ProductCategoryDAO
        Dim dataTable As New DataTable()
        Try
            dataTable = lcls.GetDataTable(0, True)
            pCombo.Properties.DataSource = dataTable
            pCombo.Properties.DisplayMember = "NameThai"
            pCombo.Properties.ValueMember = "ID"
            pCombo.EditValue = DBNull.Value
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SetLookUpProCategory : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub

    Public Sub SetLookUpLocationDTL(ByVal pCombo As DevExpress.XtraEditors.LookUpEdit)
        Dim lcls As New LocationDTLDAO
        Dim dataTable As New DataTable()
        Try
            dataTable = lcls.GetDataTableDTL(0)
            pCombo.Properties.DataSource = dataTable
            pCombo.Properties.DisplayMember = "NameThai"
            pCombo.Properties.ValueMember = "ID"
            'pCombo.EditValue = DBNull.Value
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SetLookUpLocationDTL : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub


    Public Sub SetLookUpDepartment(ByVal pCombo As DevExpress.XtraEditors.LookUpEdit)
        Dim lcls As New DepartmentDAO
        Dim dataTable As New DataTable()


        Try
            dataTable = lcls.GetDataTable(0, True)
            pCombo.Properties.DataSource = dataTable
            pCombo.Properties.DisplayMember = "NameThai"
            pCombo.Properties.ValueMember = "ID"
            pCombo.EditValue = DBNull.Value
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SetLookUpDepartment : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try

    End Sub


    Public Sub SetLookUpOppStage(ByVal pCombo As DevExpress.XtraEditors.LookUpEdit)
        Dim lcls As New OpportunityStageDAO
        Dim dataTable As New DataTable()


        Try
            dataTable = lcls.GetDataTable(0, True)
            pCombo.Properties.DataSource = dataTable
            pCombo.Properties.DisplayMember = "NameThai"
            pCombo.Properties.ValueMember = "ID"
            pCombo.EditValue = DBNull.Value
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SetLookUpOppStage : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try

    End Sub


    Public Sub SetLookUpVatType(ByVal pCombo As DevExpress.XtraEditors.LookUpEdit)
        Dim lcls As New VatTypeDAO
        Dim dataTable As New DataTable()


        Try
            dataTable = lcls.GetDataTable(0, True)
            pCombo.Properties.DataSource = dataTable
            pCombo.Properties.DisplayMember = "NameThai"
            pCombo.Properties.ValueMember = "ID"
            pCombo.EditValue = DBNull.Value
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SetLookUpVatType : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try

    End Sub


    Public Sub SetLookUpBankDocType(ByVal pCombo As DevExpress.XtraEditors.LookUpEdit)
        Dim lcls As New BankDocType
        Dim lList As New List(Of BankDocType)
        Try
            lcls.BankDocTypeCode = "CD"
            lcls.BankDocTypeName = "บัตรเครดิต"
            lList.Add(lcls)

            lcls = New BankDocType
            lcls.CashTypeCode = "D"
            lcls.BankDocTypeCode = "CHI"
            lcls.BankDocTypeName = "รายการเงินสดรับ"
            lList.Add(lcls)
            lcls = New BankDocType
            lcls.CashTypeCode = "W"
            lcls.BankDocTypeCode = "CHO"
            lcls.BankDocTypeName = "รายการเงินสดจ่าย"
            lList.Add(lcls)
            lcls = New BankDocType
            lcls.CashTypeCode = "D"
            lcls.BankDocTypeCode = "CL"
            lcls.BankDocTypeName = "ฝากโดยเช็คธนาคารอื่น"
            lList.Add(lcls)
            lcls = New BankDocType
            lcls.CashTypeCode = "W"
            lcls.BankDocTypeCode = "CM"
            lcls.BankDocTypeName = "ค่าธรรมเนียม"
            lList.Add(lcls)
            lcls = New BankDocType
            lcls.CashTypeCode = "W"
            lcls.BankDocTypeCode = "CW"
            lcls.BankDocTypeName = "ถอนโดยเช็ค(เช็คจ่าย)"
            lList.Add(lcls)
            lcls = New BankDocType
            lcls.CashTypeCode = "D"
            lcls.BankDocTypeCode = "HC"
            lcls.BankDocTypeName = "ฝากโดยเช็ค(เช็ครับ)"
            lList.Add(lcls)
            lcls = New BankDocType
            lcls.BankDocTypeCode = "LC"
            lcls.BankDocTypeName = "เล็ตเตอร์ออฟเครดิต"
            lList.Add(lcls)
            lcls = New BankDocType
            lcls.CashTypeCode = "D"
            lcls.BankDocTypeCode = "TRD"
            lcls.BankDocTypeName = "ฝากโดยการโอน"
            lList.Add(lcls)
            lcls = New BankDocType
            lcls.CashTypeCode = "W"
            lcls.BankDocTypeCode = "TRW"
            lcls.BankDocTypeName = "ถอนโดยการโอน"
            lList.Add(lcls)

            pCombo.Properties.DataSource = lList
            pCombo.Properties.DisplayMember = "BankDocTypeName"
            pCombo.Properties.ValueMember = "BankDocTypeCode"
            'pCombo.EditValue = DBNull.Value
            pCombo.Properties.ShowHeader = False
            Dim coll As LookUpColumnInfoCollection = pCombo.Properties.Columns
            coll.Add(New LookUpColumnInfo("BankDocTypeCode", 0))
            coll.Add(New LookUpColumnInfo("BankDocTypeName", 0))

            pCombo.Properties.BestFitMode = BestFitMode.BestFitResizePopup
            pCombo.Properties.SearchMode = SearchMode.AutoComplete
            pCombo.Properties.AutoSearchColumnIndex = 1

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SetLookUpBankDocType : " & e.Message)
        Finally
            lcls = Nothing
        End Try

    End Sub


    Public Sub SetLookUpCostType(ByVal pCombo As DevExpress.XtraEditors.LookUpEdit)
        Dim lcls As New CostType
        Dim lList As New List(Of CostType)
        Try
            lcls.CostTypeCode = ProductCostDAO.CostTypes.Average
            lcls.CostTypeName = "Average"
            lList.Add(lcls)
             
            pCombo.Properties.DataSource = lList
            pCombo.Properties.DisplayMember = "CostTypeName"
            pCombo.Properties.ValueMember = "CostTypeCode"
            pCombo.EditValue = DBNull.Value
            pCombo.Properties.ShowHeader = False
            Dim coll As LookUpColumnInfoCollection = pCombo.Properties.Columns
            coll.Add(New LookUpColumnInfo("CostTypeCode", 0))
            coll.Add(New LookUpColumnInfo("CostTypeName", 0))

            pCombo.Properties.BestFitMode = BestFitMode.BestFitResizePopup
            pCombo.Properties.SearchMode = SearchMode.AutoComplete
            pCombo.Properties.AutoSearchColumnIndex = 1

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SetLookUpCostType : " & e.Message)
        Finally
            lcls = Nothing
        End Try

    End Sub



    Public Sub SetLookUpCashType(ByVal pCombo As DevExpress.XtraEditors.LookUpEdit)
        Dim lcls As New CashType
        Dim lList As New List(Of CashType)
        Try
            lcls.CashTypeCode = "D"
            lcls.CashTypeName = "Deposit"
            lList.Add(lcls)
            lcls = New CashType
            lcls.CashTypeCode = "W"
            lcls.CashTypeName = "Withdraw"
            lList.Add(lcls)

            pCombo.Properties.DataSource = lList
            pCombo.Properties.DisplayMember = "CashTypeName"
            pCombo.Properties.ValueMember = "CashTypeCode"
            pCombo.EditValue = DBNull.Value
            pCombo.Properties.ShowHeader = False
            Dim coll As LookUpColumnInfoCollection = pCombo.Properties.Columns
            coll.Add(New LookUpColumnInfo("CashTypeCode", 0))
            coll.Add(New LookUpColumnInfo("CashTypeName", 0))

            pCombo.Properties.BestFitMode = BestFitMode.BestFitResizePopup
            pCombo.Properties.SearchMode = SearchMode.AutoComplete
            pCombo.Properties.AutoSearchColumnIndex = 1

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SetLookUpCashType : " & e.Message)
        Finally
            lcls = Nothing
        End Try

    End Sub


    Public Sub SetLookUpChequeStep(ByVal pCombo As DevExpress.XtraEditors.LookUpEdit)
        Dim lcls As New ChequeStep
        Dim lList As New List(Of ChequeStep)
        Try
            lcls.ChequeStepCode = "W"
            lcls.ChequeStepName = "รอนำเข้าธนาคาร"
            lList.Add(lcls)
            lcls = New ChequeStep
            lcls.ChequeStepCode = "D"
            lcls.ChequeStepName = "นำเข้าธนาคารแล้ว"
            lList.Add(lcls)

            pCombo.Properties.DataSource = lList
            pCombo.Properties.DisplayMember = "ChequeStepName"
            pCombo.Properties.ValueMember = "ChequeStepCode"
            pCombo.EditValue = DBNull.Value
            pCombo.Properties.ShowHeader = False
            Dim coll As LookUpColumnInfoCollection = pCombo.Properties.Columns
            coll.Add(New LookUpColumnInfo("ChequeStepCode", 0))
            coll.Add(New LookUpColumnInfo("ChequeStepName", 0))

            pCombo.Properties.BestFitMode = BestFitMode.BestFitResizePopup
            pCombo.Properties.SearchMode = SearchMode.AutoComplete
            pCombo.Properties.AutoSearchColumnIndex = 1

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SetLookUpChequeStep : " & e.Message)
        Finally
            lcls = Nothing
        End Try

    End Sub


    Public Sub SetLookUpChequeStatus(ByVal pCombo As DevExpress.XtraEditors.LookUpEdit)
        Dim lcls As New ChequeStatus
        Dim lList As New List(Of ChequeStatus)
        Try
            lcls.ChequeStatusCode = "N"
            lcls.ChequeStatusName = "เพิ่งได้รับ"
            lList.Add(lcls)
            lcls = New ChequeStatus
            lcls.ChequeStatusCode = "P"
            lcls.ChequeStatusName = "ผ่านแล้ว"
            lList.Add(lcls)
            lcls = New ChequeStatus
            lcls.ChequeStatusCode = "R"
            lcls.ChequeStatusName = "เช็คคืน"
            lList.Add(lcls)

            pCombo.Properties.DataSource = lList
            pCombo.Properties.DisplayMember = "ChequeStatusName"
            pCombo.Properties.ValueMember = "ChequeStatusCode"
            pCombo.EditValue = DBNull.Value
            pCombo.Properties.ShowHeader = False
            Dim coll As LookUpColumnInfoCollection = pCombo.Properties.Columns
            coll.Add(New LookUpColumnInfo("ChequeStatusCode", 0))
            coll.Add(New LookUpColumnInfo("ChequeStatusName", 0))

            pCombo.Properties.BestFitMode = BestFitMode.BestFitResizePopup
            pCombo.Properties.SearchMode = SearchMode.AutoComplete
            pCombo.Properties.AutoSearchColumnIndex = 1

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SetLookUpChequeStatus : " & e.Message)
        Finally
            lcls = Nothing
        End Try

    End Sub

    Public Sub SetLookUpCurrency(ByVal pCombo As DevExpress.XtraEditors.LookUpEdit)
        Dim lcls As New CurrencyDAO
        Dim dataTable As New DataTable()
        Try
            dataTable = lcls.GetDataTable(0, True)
            pCombo.Properties.DataSource = dataTable
            pCombo.Properties.DisplayMember = "Code"
            pCombo.Properties.ValueMember = "ID"
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SetLookUpCurrency : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try

    End Sub


    Public Sub SetLookProBrand(ByVal pCombo As DevExpress.XtraEditors.LookUpEdit, ByVal pProCategoryID As Long)
        Dim lcls As New ProductBrandDAO
        Dim dataTable As New DataTable()
        Try

            dataTable = lcls.GetDataTable(0, True, pProCategoryID)
            pCombo.Properties.DataSource = dataTable
            pCombo.Properties.DisplayMember = "NameThai"
            pCombo.Properties.ValueMember = "ID"
            pCombo.EditValue = DBNull.Value
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SetLookProBrand : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub



    Public Sub SetLookProGroup(ByVal pCombo As DevExpress.XtraEditors.LookUpEdit, ByVal pProCategoryID As Long)
        Dim lcls As New MasterDAO
        Dim dataTable As New DataTable()
        Dim pTable As String = ""
        Try

            pTable = GetMasterTableName(MasterType.ProductGroup)
            dataTable = lcls.GetDataTable(0, pTable, True, , pProCategoryID)
            pCombo.Properties.DataSource = dataTable
            pCombo.Properties.DisplayMember = "CodeThai"
            pCombo.Properties.ValueMember = "ID"
            pCombo.EditValue = DBNull.Value
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SetLookProGroup : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub

    Public Sub SetComboMasterSearch(ByVal pCombo As DevExpress.XtraEditors.SearchLookUpEdit, ByVal pMasterType As MasterType)
        Dim lcls As New MasterDAO
        Dim dataTable As New DataTable()
        Dim pTable As String = ""

        pTable = GetMasterTableName(pMasterType)
        Try
            dataTable = lcls.GetDataTable(0, pTable, True)
            pCombo.Properties.DataSource = dataTable
            pCombo.Properties.DisplayMember = "CodeThai"
            pCombo.Properties.ValueMember = "ID"
            pCombo.EditValue = DBNull.Value
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SetComboMasterSearch : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try

    End Sub

    Public Sub SetComboEmployee(ByVal pCombo As DevExpress.XtraEditors.SearchLookUpEdit)
        Dim lcls As New EmployeeDAO
        Dim dataTable As New DataTable()
        Try
            dataTable = lcls.GetDataTableForCombo(0, True)
            pCombo.Properties.DataSource = dataTable
            pCombo.Properties.DisplayMember = "NAME"
            pCombo.Properties.ValueMember = "ID"
            pCombo.EditValue = DBNull.Value
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SetComboEmployee : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub

    Public Sub SetComboContact(ByVal pCombo As DevExpress.XtraEditors.SearchLookUpEdit)
        Dim lcls As New CustomerDAO
        Dim dataTable As New DataTable()
        Try
            lcls.TableID = MasterType.Contacts
            dataTable = lcls.GetDataTableForCombo(True, False, False)
            pCombo.Properties.DataSource = dataTable
            pCombo.Properties.DisplayMember = "CusName"
            pCombo.Properties.ValueMember = "ID"
            pCombo.EditValue = DBNull.Value
            pCombo.Properties.View.ViewCaption = "Contacts"
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SetComboContact : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub


    Public Sub SetComboUnits(ByVal pCombo As DevExpress.XtraEditors.SearchLookUpEdit)
        Dim lcls As New UnitDAO
        Dim dataTable As New DataTable()
        Try
            dataTable = lcls.GetDataTable(0, True)
            pCombo.Properties.DataSource = dataTable
            pCombo.Properties.DisplayMember = "CodeThai"
            pCombo.Properties.ValueMember = "ID"
            pCombo.EditValue = DBNull.Value
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SetComboEmployee : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try

    End Sub


    Public Sub SetSearchLookAgency(ByVal pCombo As DevExpress.XtraEditors.SearchLookUpEdit)
        Dim lcls As New CustomerDAO
        Dim dataTable As New DataTable()
        Try
            lcls.TableID = MasterType.Agency
            dataTable = lcls.GetDataTableForCombo(True, True, False)
            pCombo.Properties.DataSource = dataTable
            pCombo.Properties.DisplayMember = "CusName"
            pCombo.Properties.ValueMember = "ID"
            pCombo.EditValue = DBNull.Value
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SetSearchLookAgency : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub


    Public Sub SetSearchLookBank(ByVal pCombo As DevExpress.XtraEditors.SearchLookUpEdit)
        Dim lcls As New BankDAO
        Dim dataTable As New DataTable()
        Try

            dataTable = lcls.GetDataTable(0, True)
            pCombo.Properties.DataSource = dataTable
            pCombo.Properties.DisplayMember = "NameThai"
            pCombo.Properties.ValueMember = "ID"
            pCombo.EditValue = DBNull.Value
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SetSearchLookBank : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub



    Public Sub SetSearchLookBankAccount(ByVal pCombo As DevExpress.XtraEditors.SearchLookUpEdit, ByVal pCusID As Long, ByVal pBankID As Long)
        Dim lcls As New BankAccountDAO
        Dim dataTable As New DataTable()
        Try

            dataTable = lcls.GetDataTable(0, True, pCusID, pBankID)
            pCombo.Properties.DataSource = dataTable
            pCombo.Properties.DisplayMember = "BankAccountNo"
            pCombo.Properties.ValueMember = "ID"
            pCombo.EditValue = DBNull.Value
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SetSearchLookBankAccount : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub


    Public Sub SetSearchLookCustomer(ByVal pCombo As DevExpress.XtraEditors.SearchLookUpEdit, ByVal pSelectBoth As Boolean, ByVal pCus_Agency As Boolean)
        Dim lcls As New CustomerDAO
        Dim dataTable As New DataTable()
        Try
            lcls.TableID = MasterType.Accounts
            dataTable = lcls.GetDataTableForCombo(True, pSelectBoth, pCus_Agency)
            pCombo.Properties.DataSource = dataTable
            pCombo.Properties.DisplayMember = "CusName"
            pCombo.Properties.ValueMember = "ID"
            pCombo.EditValue = DBNull.Value
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SetComboCustomer : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub


    Public Sub SetSearchLookOpportunity(ByVal pCombo As DevExpress.XtraEditors.SearchLookUpEdit, ByVal pCustomerID As Long, ByVal pEffectDate As Date)
        Dim lcls As New OpportunityDAO
        Dim dataTable As New DataTable()
        Try
            dataTable = lcls.GetDataTableForCombo(pCustomerID, pEffectDate)
            pCombo.Properties.DataSource = dataTable
            pCombo.Properties.DisplayMember = "OppName"
            pCombo.Properties.ValueMember = "ID"
            pCombo.EditValue = DBNull.Value
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SetSearchLookOpportunity : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub


    Public Sub SetSearchLookQuotation(ByVal pCombo As DevExpress.XtraEditors.SearchLookUpEdit, ByVal pCustomerID As Long, ByVal pEffectDate As Date)
        Dim lcls As New OrderSDAO
        Dim dataTable As New DataTable()
        Try
            lcls.TableID = MasterType.Quotation
            dataTable = lcls.GetDataTableForCombo(MasterType.Quotation, MasterType.Quotation, pCustomerID, pEffectDate, True, "")
            pCombo.Properties.DataSource = dataTable
            pCombo.Properties.DisplayMember = "Code"
            pCombo.Properties.ValueMember = "ID"
            pCombo.EditValue = DBNull.Value
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SetSearchLookQuotation : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub


    Public Sub SetSearchLookReserve(ByVal pCombo As DevExpress.XtraEditors.SearchLookUpEdit, ByVal pCustomerID As Long, ByVal pEffectDate As Date)
        Dim lcls As New OrderSDAO
        Dim dataTable As New DataTable()
        Try
            lcls.TableID = MasterType.Reserve
            dataTable = lcls.GetDataTableForCombo(MasterType.Reserve, MasterType.Reserve, pCustomerID, pEffectDate, True, "")
            pCombo.Properties.DataSource = dataTable
            pCombo.Properties.DisplayMember = "Code"
            pCombo.Properties.ValueMember = "ID"
            pCombo.EditValue = DBNull.Value
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SetSearchLookReserve : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub

    Public Sub SetSearchLookOrder(ByVal pCombo As DevExpress.XtraEditors.SearchLookUpEdit, ByVal pCustomerID As Long, ByVal pEffectDate As Date, ByRef pIsOpenOnly As Boolean)
        Dim lcls As New OrderSDAO
        Dim dataTable As New DataTable()
        Try
            dataTable = lcls.GetDataTableForCombo(MasterType.SellOrders, MasterType.SellOrders, pCustomerID, pEffectDate, pIsOpenOnly, "")
            pCombo.Properties.DataSource = dataTable
            pCombo.Properties.DisplayMember = "Code"
            pCombo.Properties.ValueMember = "ID"
            pCombo.EditValue = DBNull.Value
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SetSearchLookOrder : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub

    Public Function GetMasterTableName(ByVal pMasterType As MasterType) As String
        Dim pTable As String = ""
        Dim lcls As New MenuADO
        Try
            If lcls.InitailData(pMasterType) Then
                pTable = lcls.TableNames
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.GetMasterTableName : " & e.Message)
        Finally
            lcls = Nothing
        End Try
        Return pTable
    End Function

    Public Function GetCurrentDate(ByVal tr As SqlTransaction) As DateTime

        Dim SQL As String
        Dim dataTable As New DataTable()
        Dim lUserDAO As New UserDAO
        Try
            SQL = " Select GetDate()"

            dataTable = gConnection.executeSelectQuery(SQL, tr)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    GetCurrentDate = dr(0)
                    Exit For
                Next
            Else
                Return Now
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.GetCurrentDate : " & e.Message)
            Return Now
        Finally
            dataTable = Nothing
        End Try

    End Function

    Public Function GenNewID(ByVal pFiledName As String, ByVal pTableName As String, ByRef tr As SqlTransaction) As Long

        Dim SQL As String, lstrWhere As String = ""
        Dim dataTable As New DataTable()
        Dim lID As Long
        'If pTableName = "Orders" Then
        '    pTableName = "SystemCounter"
        '    pFiledName = "MaxID"
        '    lstrWhere = " Where TableName='Orders'"
        '    'ElseIf pTableName = "Account" Then
        '    '    pTableName = "SystemCounter"
        '    '    pFiledName = "MaxID"
        '    '    lstrWhere = " Where TableName='Account'"
        'End If
        Try
            SQL = "SELECT MAX(" & pFiledName & ") AS ID FROM " & pTableName
            If lstrWhere <> "" Then
                SQL = SQL & lstrWhere
            End If
            dataTable = gConnection.executeSelectQuery(SQL, tr)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    lID = ConvertNullToZero(dr("ID"))
                    lID = lID + 1
                Next
            Else
                lID = 1
            End If
        Catch e As Exception
            lID = 1
            Err.Raise(Err.Number, e.Source, "modDAO.GenNewID : " & e.Message)
        Finally
            dataTable = Nothing
        End Try
        Return lID
    End Function

    Public Function SaveAddress(ByVal AddressS As AddressDAO, ByVal ModeData As DataMode, ByRef tr As SqlTransaction) As Long
        Try
            'Address 
            If AddressS Is Nothing Then
                AddressS = New AddressDAO
                AddressS.ImageS = New FileAttachDAO
            End If

            'Address Map
            If AddressS.ImageS Is Nothing Then
                AddressS.ImageS = New FileAttachDAO
            End If

            If ModeData = DataMode.ModeNew Then
                AddressS.ImageS.ModeData = DataMode.ModeNew
            ElseIf ModeData = DataMode.ModeDelete Then
                AddressS.ImageS.ModeData = DataMode.ModeDelete
            End If
            If AddressS.ImageS.ModeData <> DataMode.ModeNone Then
                'ModeNone = not change
                If AddressS.ImageS Is Nothing And AddressS.ImageID > 0 Then
                    AddressS.ImageS.InitailData(AddressS.ImageID, tr)
                End If

                AddressS.ImageS.SaveData(tr)
            End If
            AddressS.ImageID = AddressS.ImageS.ID

            AddressS.ModeData = ModeData
            AddressS.SaveData(tr)
            Return AddressS.ID
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SaveAddress : " & e.Message)
        End Try

    End Function

    Public Sub SaveAttachFile(ByVal FileAttachs As List(Of FileAttachDAO), ByVal ModeData As DataMode, ByVal ID As Long, ByVal TableName As String, ByRef tr As SqlTransaction)
        Try
            'Save Attach file
            Dim lToSave As Boolean = False
            If Not FileAttachs Is Nothing Then
                If FileAttachs.Count > 0 Then
                    For Each File As FileAttachDAO In FileAttachs
                        lToSave = False
                        If ModeData = DataMode.ModeNew Or ModeData = DataMode.ModeDelete Then
                            lToSave = True
                            File.ModeData = ModeData
                        ElseIf File.ModeData = DataMode.ModeNew Or File.ModeData = DataMode.ModeEdit Then
                            lToSave = True
                        End If

                        If lToSave = True Then
                            File.RefID = ID
                            File.RefTable = TableName
                            File.SaveData(tr)
                        End If
                    Next
                End If
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SaveAttachFile : " & e.Message)
        End Try
    End Sub

    'Public Sub SaveProductList(ByRef ProductList As List(Of ProductListDAO), ByVal ModeData As DataMode, ByVal RefID As Long, ByVal TableName As String _
    '                           , ByRef tr As SqlTransaction, ByVal pIsSumStock As Boolean)
    '    Dim lstrStayIDList As String = "", lSEQ As Long = 1
    '    Dim lclsSN As SnDAO, lclsSN2 As SnDAO
    '    Dim lSNTable As DataTable
    '    Dim lOrderList As New List(Of Long), lSNInList As String = ""
    '    Dim lUpdateStstus As Boolean = False

    '    Try
    '        If ProductList Is Nothing Then
    '            '**** not delete prolist when delete order
    '        ElseIf ProductList.Count = 0 Then

    '        Else
    '            For Each pProList As ProductListDAO In ProductList
    '                pProList.RefID = RefID
    '                pProList.RefTable = TableName
    '                pProList.SEQ = lSEQ
    '                If ModeData = DataMode.ModeDelete Then
    '                    pProList.ModeData = DataMode.ModeDelete
    '                ElseIf ModeData = DataMode.ModeNew Then
    '                    pProList.ModeData = DataMode.ModeNew
    '                    pProList.IsConfirm = 0
    '                End If

    '                If pProList.SaveData(tr) Then
    '                    If ModeData = DataMode.ModeEdit Then
    '                        If pProList.ID > 0 Then
    '                            lstrStayIDList = IIf(lstrStayIDList = "", pProList.ID, lstrStayIDList & "," & pProList.ID)
    '                        End If
    '                    End If

    '                    '*** SN
    '                    If ModeData = DataMode.ModeDelete Then
    '                        'Re Open status
    '                        If TableName = MasterType.SellOrders.ToString Then
    '                            lOrderList = New List(Of Long)
    '                            lOrderList.Add(RefID)

    '                            lclsSN = New SnDAO
    '                            lSNTable = lclsSN.GetDataTable(lOrderList, pProList.ID, pProList.ProductID, "", tr, ModeData = DataMode.ModeDelete)
    '                            For Each dr2 As DataRow In lSNTable.Rows
    '                                lclsSN2 = New SnDAO
    '                                lclsSN2.SetStatusBySN(tr, ConvertNullToZero(dr2("ProductID")), ConvertNullToString(dr2("SerialNumberNo")), "New")
    '                            Next
    '                        End If

    '                        'Delete
    '                        lclsSN2 = New SnDAO
    '                        lclsSN2.DeleteFromModeDelete(tr, RefID, pProList.ID)

    '                    Else
    '                        If IsNothing(pProList.SNList) = False Then
    '                            For Each pclsSN As SnDAO In pProList.SNList
    '                                lUpdateStstus = False
    '                                lclsSN = pclsSN
    '                                If ModeData = DataMode.ModeNew Then
    '                                    lclsSN.SerialNumberID = 0
    '                                    If TableName = MasterType.StockIn.ToString Or TableName = MasterType.UpdateStock.ToString Then
    '                                        lclsSN.Status = "New"
    '                                    Else
    '                                        lclsSN.Status = "None"
    '                                    End If
    '                                End If
    '                                If TableName = MasterType.UpdateStock.ToString And pProList.Units < 0 Then
    '                                    lclsSN.Status = "None"
    '                                    lUpdateStstus = True
    '                                End If
    '                                lclsSN.OrderID = RefID
    '                                lclsSN.ProductListID = pProList.ID
    '                                lclsSN.ProductID = pProList.ProductID
    '                                lclsSN.SerialNumberNo = pclsSN.SerialNumberNo
    '                                lclsSN.SaveData(tr, ModeData, lUpdateStstus)

    '                                'Close SN
    '                                If TableName = MasterType.SellOrders.ToString Then
    '                                    lclsSN2 = New SnDAO
    '                                    lclsSN2.SetStatusBySN(tr, pProList.ProductID, lclsSN.SerialNumberNo, "Close")
    '                                End If

    '                                If ModeData = DataMode.ModeEdit Then
    '                                    If lclsSN.SerialNumberID > 0 Then
    '                                        lSNInList = IIf(lSNInList = "", lclsSN.SerialNumberID, lSNInList & "," & lclsSN.SerialNumberID)
    '                                    End If
    '                                End If
    '                            Next

    '                            If lSNInList <> "" And ModeData = DataMode.ModeEdit Then
    '                                If TableName = MasterType.SellOrders.ToString Then
    '                                    lclsSN2 = New SnDAO
    '                                    lclsSN2.SetStatusBySNAtRemove(tr, RefID, pProList.ProductID, lSNInList, "New")
    '                                End If
    '                                lclsSN2 = New SnDAO
    '                                lclsSN2.DeleteRemoveData(tr, RefID, pProList.ProductID, lSNInList)
    '                            End If
    '                            lSNInList = ""
    '                        End If
    '                    End If
    '                    '*** SN


    '                End If
    '                lSEQ = lSEQ + 1
    '            Next

    '            'Delete Remove Item

    '            If ModeData = DataMode.ModeEdit And lstrStayIDList <> "" Then
    '                Dim ProList As New ProductListDAO
    '                ProList.RefID = RefID
    '                ProList.RefTable = TableName
    '                ProList.DeleteRemoveData(tr, lstrStayIDList)

    '                'SN
    '                If TableName = MasterType.SellOrders.ToString Then
    '                    lclsSN = New SnDAO
    '                    lclsSN.SetStatusFromProListRemove(tr, RefID, lstrStayIDList, "New")
    '                End If

    '                lclsSN2 = New SnDAO
    '                lclsSN2.DeleteFromProListRemove(tr, RefID, lstrStayIDList)
    '            End If
    '        End If

    '    Catch e As Exception
    '        Err.Raise(Err.Number, e.Source, "modDAO.SaveProductList" & e.Message)
    '    End Try

    'End Sub




    Public Sub SaveApproveUserDtl(ByVal pApproveType As Long, ByVal ApproveUserDtlList As List(Of ApproveUserDTLDAO), ByVal ModeData As DataMode, ByRef tr As SqlTransaction)
        Dim lstrStayIDList As String = ""
        Dim ApproveUserDtlList2 As New ApproveUserDTLDAO
        Try
            If ApproveUserDtlList Is Nothing Then
                'Delete All Ref Item
                If ModeData = DataMode.ModeDelete Then
                    ApproveUserDtlList2 = New ApproveUserDTLDAO
                    ApproveUserDtlList2.ApproveType = pApproveType
                    ApproveUserDtlList2.DeleteAllData(tr)
                End If
            ElseIf ApproveUserDtlList.Count = 0 Then

            Else
                For Each ProductLocat As ApproveUserDTLDAO In ApproveUserDtlList
                    ProductLocat.ApproveType = pApproveType
                    If ModeData = DataMode.ModeDelete Then
                        ProductLocat.ModeData = DataMode.ModeDelete
                    ElseIf ModeData = DataMode.ModeNew Then
                        ProductLocat.ModeData = DataMode.ModeNew
                    End If

                    If ProductLocat.SaveData(tr) Then
                        If ModeData = DataMode.ModeEdit Then
                            If ProductLocat.ApproveUserDtlID > 0 Then
                                lstrStayIDList = IIf(lstrStayIDList = "", ProductLocat.ApproveUserDtlID, lstrStayIDList & "," & ProductLocat.ApproveUserDtlID)
                            End If
                        End If
                    End If
                Next
                'Delete Remove Item
                ApproveUserDtlList2 = New ApproveUserDTLDAO
                ApproveUserDtlList2.ApproveType = pApproveType
                If ModeData = DataMode.ModeEdit And lstrStayIDList <> "" Then
                    ApproveUserDtlList2.DeleteRemoveData(tr, lstrStayIDList)
                End If
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SaveApproveUserDtl" & e.Message)
        End Try

    End Sub

    Public Sub SaveOrderList(ByVal OrderList As List(Of SubOrder), ByVal ModeData As DataMode, ByVal BillID As Long, ByRef tr As SqlTransaction)
        'Dim lstrStayIDList As String = ""

        Try
            If OrderList Is Nothing Then
                'Delete All Ref Item
                If ModeData = DataMode.ModeDelete Then
                    Dim lSubOrder As New OrderSDetailDAO
                    lSubOrder.BillID = BillID
                    lSubOrder.DeleteAllData(tr)
                End If
            ElseIf OrderList.Count = 0 Then

            Else
                If ModeData <> DataMode.ModeEdit Then
                    For Each pSubOrder As OrderSDetailDAO In OrderList
                        pSubOrder.BillID = BillID
                        pSubOrder.ModeData = ModeData

                        If pSubOrder.SaveData(tr) Then

                        End If
                    Next
                End If
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SaveOrderList" & e.Message)
        End Try

    End Sub


    Public Sub SavePledge(ByVal pPledgeList As List(Of PledgeDAO), ByVal ModeData As DataMode, ByVal pRefOrderID As Long, ByRef tr As SqlTransaction)
        Try
            If pPledgeList Is Nothing Then
                'Delete All Ref Item
                If ModeData = DataMode.ModeDelete Then
                    Dim lSubOrder As New PledgeDAO
                    lSubOrder.RefOrderID = pRefOrderID
                    lSubOrder.DeleteAllData(tr)
                End If
            ElseIf pPledgeList.Count > 0 Then
                For Each pSubOrder As PledgeDAO In pPledgeList
                    pSubOrder.RefOrderID = pRefOrderID
                    pSubOrder.ModeData = ModeData
                    If pSubOrder.SaveData(tr) Then

                    End If
                Next
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SavePledge" & e.Message)
        End Try

    End Sub

    Public Sub SaveCheque(ByVal pChequeList As List(Of ChequeDAO), ByVal ModeData As DataMode, ByVal pRefOrderID As Long, ByRef tr As SqlTransaction)
        Try
            If pChequeList Is Nothing Then
                'Delete All Ref Item
                If ModeData = DataMode.ModeDelete Then
                    Dim lSubOrder As New ChequeDAO
                    lSubOrder.RefOrderID = pRefOrderID
                    lSubOrder.DeleteAllData(tr)
                End If
            ElseIf pChequeList.Count > 0 Then
                For Each pSubOrder As ChequeDAO In pChequeList
                    pSubOrder.RefOrderID = pRefOrderID
                    pSubOrder.ModeData = ModeData
                    If pSubOrder.SaveData(tr) Then

                    End If
                Next
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SaveCheque" & e.Message)
        End Try
    End Sub

    Public Sub SaveTaxOrder(ByVal pTaxOrderList As List(Of TaxOrderDAO), ByVal ModeData As DataMode, ByVal pRefOrderID As Long, ByRef tr As SqlTransaction)
        Try
            If pTaxOrderList Is Nothing Then
                'Delete All Ref Item
                If ModeData = DataMode.ModeDelete Then
                    Dim lSubOrder As New TaxOrderDAO
                    lSubOrder.RefOrderID = pRefOrderID
                    lSubOrder.DeleteAllData(tr)
                End If
            ElseIf pTaxOrderList.Count > 0 Then
                For Each pSubOrder As TaxOrderDAO In pTaxOrderList
                    pSubOrder.RefOrderID = pRefOrderID
                    If pSubOrder.SaveData(tr, ModeData) Then

                    End If
                Next
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SaveCheque" & e.Message)
        End Try
    End Sub
     
    Public Sub SetFlagProductList(ByVal ProductList As List(Of ProductListDAO), ByVal IsConfirm As Boolean, ByVal pID As Long, ByRef tr As SqlTransaction)
        Try
            If ProductList Is Nothing Then
            ElseIf ProductList.Count = 0 Then
            Else
                For Each ProductLocat As ProductListDAO In ProductList
                    ProductLocat.SaveToConfirm(pID, ProductLocat.ProductListRefID, IsConfirm, tr)
                Next
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SetFlagProductList" & e.Message)
        End Try

    End Sub
 
    Public Function LoadFileAttach(ByVal ID As Long, ByVal TableName As String, ByRef tr As SqlTransaction) As List(Of FileAttachDAO)
        Dim dataTable As New DataTable()
        Dim lFileAttach As New FileAttachDAO
        Dim FileAttachs = New List(Of FileAttachDAO)()
        Try
            dataTable = Nothing
            dataTable = lFileAttach.GetDataTable(TableName, ID, tr)
            If dataTable.Rows.Count > 0 Then
                For Each dr1 As DataRow In dataTable.Rows
                    'add file to List(Of ..
                    lFileAttach = New FileAttachDAO()
                    lFileAttach.ModeData = DataMode.ModeEdit
                    lFileAttach.ID = Int32.Parse(dr1("ID"))
                    lFileAttach.RefID = Int32.Parse(dr1("RefID"))
                    lFileAttach.RefTable = TableName
                    lFileAttach.FileName = ConvertNullToString(dr1("FileName"))
                    lFileAttach.FileType = ConvertNullToString(dr1("FileType"))
                    lFileAttach.FilePath = ""
                    lFileAttach.FileSize = Format(ConvertNullToZero(dr1("FileSize")), "#,##0.00")
                    lFileAttach.CreateBy = ConvertNullToString(dr1("CreateBy"))
                    lFileAttach.CreateTime = dr1("CreateTime")
                    FileAttachs.Add(lFileAttach)
                Next
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.LoadFileAttach : " & e.Message)
        Finally
            lFileAttach = Nothing
            dataTable = Nothing
        End Try
        Return FileAttachs

    End Function
    Public Sub SaveNote(ByVal NoteDAOs As List(Of NoteDAO), ByVal ModeData As DataMode, ByVal ID As Long, ByVal TableName As String, ByRef tr As SqlTransaction)
        Try
            If NoteDAOs Is Nothing Then
                If ModeData = DataMode.ModeDelete Then
                    Dim Note = New NoteDAO
                    Note.RefID = ID
                    Note.RefTable = TableName
                    Note.DeleteAllData(tr)
                End If
            ElseIf NoteDAOs.Count = 0 Then

            Else
                For Each Note As NoteDAO In NoteDAOs
                    Note.RefID = ID
                    Note.RefTable = TableName
                    If ModeData = DataMode.ModeDelete Then
                        Note.ModeData = DataMode.ModeDelete
                    End If
                    Note.SaveData(tr)
                Next
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SaveNote : " & e.Message)
        End Try
    End Sub

    Public Sub SaveEmployeeList(ByVal EmployeeLists As List(Of EmployeeListDAO), ByVal ModeData As DataMode, ByVal pRefID As Long, ByVal pRefTableID As Long, ByRef tr As SqlTransaction)
        Try
            Dim lcls = New EmployeeListDAO
            lcls.RefID = pRefID
            lcls.RefTableID = pRefTableID

            If ModeData = DataMode.ModeDelete Then
                If EmployeeLists Is Nothing Then
                    lcls.DeleteAllData(tr)
                End If
            ElseIf EmployeeLists.Count = 0 Then
                ''
            Else
                If ModeData = DataMode.ModeEdit Then 'Clear Old data
                    lcls.ClearOldData(tr)
                End If

                For Each pcls As EmployeeListDAO In EmployeeLists
                    pcls.RefID = pRefID
                    pcls.RefTableID = pRefTableID
                    pcls.EmpID = pcls.EmpID
                    pcls.ModeData = ModeData
                    pcls.SaveData(tr)
                Next
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SaveEmployeeList : " & e.Message)
        End Try
    End Sub

    Public Sub SaveCustomerList(ByVal CustomerLists As List(Of CustomerListDAO), ByVal ModeData As DataMode, ByVal pRefID As Long, ByVal pRefTableID As Long, ByRef tr As SqlTransaction)
        Try
            Dim lcls = New CustomerListDAO
            lcls.RefID = pRefID
            lcls.RefTableID = pRefTableID

            If ModeData = DataMode.ModeDelete Then
                If CustomerLists Is Nothing Then
                    lcls.DeleteAllData(tr)
                End If
            ElseIf CustomerLists.Count = 0 Then
                ''
            Else
                If ModeData = DataMode.ModeEdit Then 'Clear Old data
                    lcls.ClearOldData(tr)
                End If

                For Each pcls As CustomerListDAO In CustomerLists
                    pcls.RefID = pRefID
                    pcls.RefTableID = pRefTableID
                    pcls.CustomerID = pcls.CustomerID
                    pcls.ModeData = ModeData
                    pcls.SaveData(tr)
                Next
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SaveCustomerList : " & e.Message)
        End Try
    End Sub
    Public Sub UpdateLastID(ByVal MenuID As MasterType, ByRef tr As SqlTransaction)
        Dim lcls As New RunningFormatDAO

        Try
            Dim lGenCode As String = ""
            lcls.InitailData(MenuID, tr)
            lcls.ResetFlag(tr)

        Catch e As Exception

            Err.Raise(Err.Number, e.Source, "modDAO.UpdateLastID : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    
    Public Sub UpdateLaedStatus(ByVal LeadID As Long, ByVal pStatus As String, ByRef tr As SqlTransaction)
        Dim lcls As New CustomerDAO

        Try
            Dim lGenCode As String = ""
            lcls.TableID = MasterType.Lead
            lcls.InitailData(LeadID, , tr)
            lcls.ModeData = DataMode.ModeEdit
            lcls.LeadStatus = pStatus
            lcls.SaveData(tr)

        Catch e As Exception

            Err.Raise(Err.Number, e.Source, "modDAO.UpdateLastID : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Public Function CompareUnitIsClose(ByVal pRefOrderID As Long, ByVal pCurrentTable As String, RefFromTable As String, ByRef ptr As SqlTransaction) As Boolean
        Dim SQL As String
        Dim DataTable As DataTable
        Dim lCurrentUnit As Long = 0, lRefFromUnit As Long = 0
        SQL = ""
        SQL = "SELECT Sum(p1.Units) as Units  "
        SQL = SQL & " FROM ProductList p1"
        SQL = SQL & " WHERE p1.IsDelete =0  "
        SQL = SQL & " AND p1.RefTable in (" & RefFromTable & " )"
        SQL = SQL & " AND p1.RefID =" & pRefOrderID
        DataTable = New DataTable
        DataTable = gConnection.executeSelectQuery(SQL, ptr)
        For Each pRow In DataTable.Rows
            lRefFromUnit = ConvertNullToZero(pRow("Units"))
            Exit For
        Next

        SQL = "SELECT Sum(p1.Units) as Units  "
        SQL = SQL & " FROM ProductList p1"
        SQL = SQL & " WHERE p1.IsDelete =0  "
        SQL = SQL & " AND p1.RefTable in (" & pCurrentTable & " )"
        SQL = SQL & " AND p1.ProductListRefID in ( "
        SQL = SQL & "   select p2.ProductListID from ProductList p2 "
        SQL = SQL & "   WHERE p2.IsDelete =0  "
        SQL = SQL & "   AND p2.RefID =" & pRefOrderID
        SQL = SQL & "   AND p2.RefTable in (" & RefFromTable & "))"
        DataTable = New DataTable
        DataTable = gConnection.executeSelectQuery(SQL, ptr)
        For Each pRow In DataTable.Rows
            lCurrentUnit = ConvertNullToZero(pRow("Units"))
            Exit For
        Next

        If lCurrentUnit < lRefFromUnit Then 'ยังดึงรายการมาทำไม่ครบ
            Return False
        Else
            Return True ' Is close
        End If
    End Function

    'Public Sub UpdateRefOrderStatus(ByVal pOrderType As Long, ByVal pParentOrderID As Long, ByVal pRefOrderID As Long, ByVal pStatus As String, ByRef ptr As SqlTransaction, ByVal pMode As DataMode)
    '    Dim SQL As String, lTableNameThai As String = "", lStatus As String = ""
    '    Dim tr As SqlTransaction = Nothing
    '    Dim DataTable As DataTable
    '    Dim lRefOrderType As MasterType, lCount As Long = 0
    '    'Dim lCurrentUnit As Long = 0, lRefFromUnit As Long = 0
    '    SQL = ""
    '    Try
    '        If ptr Is Nothing Then
    '            tr = gConnection.Connection.BeginTransaction
    '        Else
    '            tr = ptr
    '        End If

    '        Dim lclsRefOrder As New OrderSDAO
    '        lRefOrderType = lclsRefOrder.GetOrderTypeFromID(pRefOrderID, tr)

    '        If pOrderType = MasterType.StockIn Then 'Ref from PO
    '            SQL = "SELECT p1.*  "
    '            SQL = SQL & " FROM ProductList p1"
    '            SQL = SQL & " WHERE p1.IsDelete =0  "
    '            SQL = SQL & " AND p1.RefTable in ('PurchaseOrder' )"
    '            SQL = SQL & " AND p1.RefID =" & pRefOrderID
    '            SQL = SQL & " AND p1.ProductListID not in ( "
    '            SQL = SQL & "   select p2.ProductListRefID from ProductList p2 "
    '            SQL = SQL & "   WHERE p2.IsDelete =0  and p2.ProductListRefID>0"
    '            SQL = SQL & "   AND p2.RefTable ='StockIn' )"
    '            DataTable = gConnection.executeSelectQuery(SQL, tr)
    '            If IsNothing(DataTable) OrElse DataTable.Rows.Count = 0 Then
    '                If CompareUnitIsClose(pRefOrderID, "'StockIn'", "'PurchaseOrder'", tr) = False Then
    '                    lStatus = "Waiting"
    '                Else
    '                    lStatus = "Receive"
    '                End If
    '            Else
    '                lStatus = "Waiting"
    '            End If

    '            SQL = " UPDATE Orders SET "
    '            SQL = SQL & " OrderStatus='" & lStatus & "'"
    '            SQL = SQL & " where OrderID=" & ConvertNullToZero(pRefOrderID)
    '            gConnection.executeInsertQuery(SQL, tr)
    '        ElseIf pOrderType = MasterType.Invoice And lRefOrderType = MasterType.Borrow Then
    '            If pMode = DataMode.ModeDelete Then
    '                SQL = "SELECT p1.*  "
    '                SQL = SQL & " FROM ProductList p1"
    '                SQL = SQL & " WHERE p1.IsDelete =0  "
    '                SQL = SQL & " AND p1.RefTable in ('Borrow' )"
    '                SQL = SQL & " AND p1.RefID =" & pRefOrderID
    '                SQL = SQL & " AND p1.ProductListID   in ( "
    '                SQL = SQL & "   select p2.ProductListRefID from ProductList p2 "
    '                SQL = SQL & "   WHERE p2.IsDelete =0  and p2.ProductListRefID>0"
    '                SQL = SQL & "   AND p2.RefTable in( 'Invoice' ) )"
    '                DataTable = gConnection.executeSelectQuery(SQL, tr)
    '                If IsNothing(DataTable) OrElse DataTable.Rows.Count = 0 Then
    '                    lStatus = "Open"
    '                Else
    '                End If
    '            Else ' new ,Edit
    '                SQL = "SELECT p1.*  "
    '                SQL = SQL & " FROM ProductList p1"
    '                SQL = SQL & " WHERE p1.IsDelete =0  "
    '                SQL = SQL & " AND p1.RefTable in ('Borrow' )"
    '                SQL = SQL & " AND p1.RefID =" & pRefOrderID
    '                SQL = SQL & " AND p1.ProductListID not in ( "
    '                SQL = SQL & "   select p2.ProductListRefID from ProductList p2 "
    '                SQL = SQL & "   WHERE p2.IsDelete =0  and p2.ProductListRefID>0"
    '                SQL = SQL & "   AND p2.RefTable in( 'Invoice' ) )"
    '                DataTable = gConnection.executeSelectQuery(SQL, tr)
    '                If IsNothing(DataTable) OrElse DataTable.Rows.Count = 0 Then
    '                    If CompareUnitIsClose(pRefOrderID, "'Invoice'", "'Borrow'", tr) = False Then
    '                        lStatus = "Waiting"
    '                    Else
    '                        lStatus = "Close"
    '                    End If
    '                Else
    '                    lStatus = "Waiting"
    '                End If
    '            End If
    '            SQL = " UPDATE Orders SET "
    '            SQL = SQL & " OrderStatus='" & lStatus & "'"
    '            SQL = SQL & " where OrderID=" & ConvertNullToZero(pRefOrderID)
    '            gConnection.executeInsertQuery(SQL, tr)
    '        ElseIf pOrderType = MasterType.Borrow Or pOrderType = MasterType.Invoice Or pOrderType = MasterType.Shiping Then 'Ref from Sell
    '            If pMode = DataMode.ModeDelete Then
    '                SQL = "SELECT p1.*  "
    '                SQL = SQL & " FROM ProductList p1"
    '                SQL = SQL & " WHERE p1.IsDelete =0  "
    '                SQL = SQL & " AND p1.RefTable in ('SellOrders' )"
    '                SQL = SQL & " AND p1.RefID =" & pRefOrderID
    '                SQL = SQL & " AND p1.ProductListID  in ( "
    '                SQL = SQL & "   select p2.ProductListRefID from ProductList p2 "
    '                SQL = SQL & "   WHERE p2.IsDelete =0  and p2.ProductListRefID>0"
    '                SQL = SQL & "   AND p2.RefTable in('Borrow','Invoice','Shiping') )"
    '                DataTable = gConnection.executeSelectQuery(SQL, tr)
    '                If IsNothing(DataTable) OrElse DataTable.Rows.Count = 0 Then
    '                    lStatus = "Open"
    '                Else
    '                    lStatus = "Waiting"
    '                End If
    '            Else
    '                SQL = "SELECT p1.*  "
    '                SQL = SQL & " FROM ProductList p1"
    '                SQL = SQL & " WHERE p1.IsDelete =0  "
    '                SQL = SQL & " AND p1.RefTable in ('SellOrders' )"
    '                SQL = SQL & " AND p1.RefID =" & pRefOrderID
    '                SQL = SQL & " AND p1.ProductListID not in ( "
    '                SQL = SQL & "   select p2.ProductListRefID from ProductList p2 "
    '                SQL = SQL & "   WHERE p2.IsDelete =0  and p2.ProductListRefID>0"
    '                SQL = SQL & "   AND p2.RefTable in('Borrow','Invoice','Shiping') )"
    '                DataTable = gConnection.executeSelectQuery(SQL, tr)
    '                If IsNothing(DataTable) OrElse DataTable.Rows.Count = 0 Then
    '                    If CompareUnitIsClose(pRefOrderID, "'Borrow','Invoice','Shiping'", "SellOrders", tr) = False Then
    '                        lStatus = "Waiting"
    '                    Else
    '                        lStatus = "Close"
    '                    End If
    '                Else
    '                    lStatus = "Waiting"
    '                End If
    '            End If
    '            SQL = " UPDATE Orders SET "
    '            SQL = SQL & " OrderStatus='" & lStatus & "'"
    '            SQL = SQL & " where OrderID=" & ConvertNullToZero(pRefOrderID)
    '            gConnection.executeInsertQuery(SQL, tr)
    '        ElseIf pOrderType = MasterType.InvoiceBuy Or pOrderType = MasterType.ShipingBuy Then ' 
    '            If pMode = DataMode.ModeDelete Then
    '                SQL = "SELECT p1.*  "
    '                SQL = SQL & " FROM ProductList p1"
    '                SQL = SQL & " WHERE p1.IsDelete =0  "
    '                SQL = SQL & " AND p1.RefTable ='PurchaseOrder'"
    '                SQL = SQL & " AND p1.RefID =" & pRefOrderID
    '                SQL = SQL & " AND p1.ProductListID  in ( "
    '                SQL = SQL & "   select p2.ProductListRefID from ProductList p2 "
    '                SQL = SQL & "   WHERE p2.IsDelete =0  and p2.ProductListRefID>0"
    '                SQL = SQL & "   AND p2.RefTable in ('InvoiceBuy','ShipingBuy') )"
    '                DataTable = gConnection.executeSelectQuery(SQL, tr)
    '                If IsNothing(DataTable) OrElse DataTable.Rows.Count = 0 Then
    '                    lStatus = "Open" 'PO ที่ทำ InvoiceBuy,ShipingBuy  หมดแล้ว
    '                Else
    '                    lStatus = "Waiting"
    '                End If
    '            Else
    '                SQL = "SELECT p1.*  "
    '                SQL = SQL & " FROM ProductList p1"
    '                SQL = SQL & " WHERE p1.IsDelete =0  "
    '                SQL = SQL & " AND p1.RefTable ='PurchaseOrder'"
    '                SQL = SQL & " AND p1.RefID =" & pRefOrderID
    '                SQL = SQL & " AND p1.ProductListID not in ( "
    '                SQL = SQL & "   select p2.ProductListRefID from ProductList p2 "
    '                SQL = SQL & "   WHERE p2.IsDelete =0  and p2.ProductListRefID>0"
    '                SQL = SQL & "   AND p2.RefTable in ('InvoiceBuy','ShipingBuy') )"
    '                DataTable = gConnection.executeSelectQuery(SQL, tr)
    '                If IsNothing(DataTable) OrElse DataTable.Rows.Count = 0 Then
    '                    If CompareUnitIsClose(pRefOrderID, "'InvoiceBuy','ShipingBuy'", "PurchaseOrder", tr) = False Then
    '                        lStatus = "Waiting"
    '                    Else
    '                        lStatus = "Close"
    '                    End If
    '                Else
    '                    'lStatus = "Waiting"
    '                End If
    '            End If
    '            If lStatus <> "" Then
    '                SQL = " UPDATE Orders SET "
    '                SQL = SQL & " OrderStatus='" & lStatus & "'"
    '                SQL = SQL & " where OrderID=" & ConvertNullToZero(pRefOrderID)
    '                gConnection.executeInsertQuery(SQL, tr)
    '            End If
    '        ElseIf pOrderType = MasterType.Reserve Then 'Ref from QUOTAION
    '            If pMode = DataMode.ModeDelete Then 'เช็ค QUOTAION โดนดึงไปทำ Reserve บางส่วนไหม ถ้าไม่คืนเป็น Open ถ้ามีเป็น Waiting 
    '                SQL = "SELECT p1.*  "
    '                SQL = SQL & " FROM ProductList p1"
    '                SQL = SQL & " WHERE p1.IsDelete =0  "
    '                SQL = SQL & " AND p1.RefTable ='Quotation'"
    '                SQL = SQL & " AND p1.RefID =" & pRefOrderID
    '                SQL = SQL & " AND p1.ProductListID in ( "
    '                SQL = SQL & "   select p2.ProductListRefID from ProductList p2 "
    '                SQL = SQL & "   WHERE p2.IsDelete =0  and p2.ProductListRefID>0"
    '                SQL = SQL & "   AND p2.RefTable in('Reserve','SellOrders') )"
    '                DataTable = gConnection.executeSelectQuery(SQL, tr)
    '                If IsNothing(DataTable) OrElse DataTable.Rows.Count = 0 Then
    '                    lStatus = "Open" 'Quotation ที่ทำ Reserve,SellOrders หมดแล้ว
    '                Else
    '                    lStatus = "Waiting" 'รอทำ Reserve  
    '                End If
    '            Else
    '                SQL = "SELECT p1.*  "
    '                SQL = SQL & " FROM ProductList p1"
    '                SQL = SQL & " WHERE p1.IsDelete =0  "
    '                SQL = SQL & " AND p1.RefTable in ('Quotation' )"
    '                SQL = SQL & " AND p1.RefID =" & pRefOrderID
    '                SQL = SQL & " AND p1.ProductListID not in ( "
    '                SQL = SQL & "   select p2.ProductListRefID from ProductList p2 "
    '                SQL = SQL & "   WHERE p2.IsDelete =0  and p2.ProductListRefID>0"
    '                SQL = SQL & "   AND p2.RefTable in('Reserve','SellOrders') )"
    '                DataTable = gConnection.executeSelectQuery(SQL, tr)
    '                If IsNothing(DataTable) OrElse DataTable.Rows.Count = 0 Then
    '                    'lStatus = "Close" 'Quotation ที่ทำ Reserve,SellOrders หมดแล้ว
    '                    If CompareUnitIsClose(pRefOrderID, "'Reserve','SellOrders'", "Quotation", tr) = False Then
    '                        lStatus = "Waiting"
    '                    Else
    '                        lStatus = "Close"
    '                    End If
    '                Else
    '                    lStatus = "Waiting"
    '                End If
    '            End If

    '            SQL = " UPDATE Orders SET "
    '            SQL = SQL & " OrderStatus='" & lStatus & "'"
    '            SQL = SQL & " where OrderID=" & ConvertNullToZero(pRefOrderID)
    '            gConnection.executeInsertQuery(SQL, tr)

    '        ElseIf pOrderType = MasterType.SellOrders Then
    '            If pMode = DataMode.ModeDelete And lRefOrderType = MasterType.Quotation Then
    '                SQL = "SELECT p1.*  "
    '                SQL = SQL & " FROM ProductList p1"
    '                SQL = SQL & " WHERE p1.IsDelete =0  "
    '                SQL = SQL & " AND p1.RefTable ='Quotation'"
    '                SQL = SQL & " AND p1.RefID =" & pRefOrderID
    '                SQL = SQL & " AND p1.ProductListID in ( "
    '                SQL = SQL & "   select p2.ProductListRefID from ProductList p2 "
    '                SQL = SQL & "   WHERE p2.IsDelete =0  and p2.ProductListRefID>0"
    '                SQL = SQL & "   AND p2.RefTable in('Reserve','SellOrders') )"
    '                DataTable = gConnection.executeSelectQuery(SQL, tr)
    '                If IsNothing(DataTable) OrElse DataTable.Rows.Count = 0 Then
    '                    lStatus = "Open" 'Quotation ที่ยังไม่เคยทำ Reserve,SellOrders  
    '                Else
    '                    lCount = DataTable.Rows.Count

    '                    SQL = "SELECT p1.*  "
    '                    SQL = SQL & " FROM ProductList p1"
    '                    SQL = SQL & " WHERE p1.IsDelete =0  "
    '                    SQL = SQL & " AND p1.RefTable ='Quotation'"
    '                    SQL = SQL & " AND p1.RefID =" & pRefOrderID
    '                    SQL = SQL & " AND p1.ProductListID in ( "
    '                    SQL = SQL & "   select p2.ProductListRefID from ProductList p2 "
    '                    SQL = SQL & "   WHERE p2.IsDelete =0  and p2.ProductListRefID>0"
    '                    SQL = SQL & "   AND p2.RefTable in('Reserve','SellOrders') )"
    '                    DataTable = gConnection.executeSelectQuery(SQL, tr)
    '                    If IsNothing(DataTable) OrElse DataTable.Rows.Count = 0 Then
    '                        lStatus = "Open" 'Quotation ที่ยังไม่เคยทำ Reserve,SellOrders  
    '                    Else
    '                        lStatus = "Waiting" 'รอทำ Reserve  ,SellOrders
    '                    End If

    '                    lStatus = "Waiting" 'รอทำ Reserve  ,SellOrders
    '                End If
    '            ElseIf pMode = DataMode.ModeDelete And lRefOrderType = MasterType.Reserve Then '  ใบสั่งขายดึง Reserve มาทำ
    '                SQL = "SELECT p1.*  "
    '                SQL = SQL & " FROM ProductList p1"
    '                SQL = SQL & " WHERE p1.IsDelete =0  "
    '                SQL = SQL & " AND p1.RefTable ='Reserve'"
    '                SQL = SQL & " AND p1.RefID =" & pRefOrderID
    '                SQL = SQL & " AND p1.ProductListID not in ( "
    '                SQL = SQL & "   select p2.ProductListRefID from ProductList p2 "
    '                SQL = SQL & "   WHERE p2.IsDelete =0  and p2.ProductListRefID>0"
    '                SQL = SQL & "   AND p2.RefTable ='SellOrders' )"
    '                DataTable = gConnection.executeSelectQuery(SQL, tr)
    '                If IsNothing(DataTable) OrElse DataTable.Rows.Count = 0 Then
    '                    lStatus = "Open" 'Reserve ที่ยังไม่เคยทำ  SellOrders  
    '                Else
    '                    lStatus = "Waiting" 'รอทำ SellOrders  
    '                End If
    '            ElseIf (pMode = DataMode.ModeNew Or pMode = DataMode.ModeEdit) And lRefOrderType = MasterType.Quotation Then
    '                SQL = "SELECT p1.*  "
    '                SQL = SQL & " FROM ProductList p1"
    '                SQL = SQL & " WHERE p1.IsDelete =0  "
    '                SQL = SQL & " AND p1.RefTable in ('Quotation' )"
    '                SQL = SQL & " AND p1.RefID =" & pRefOrderID
    '                SQL = SQL & " AND p1.ProductListID not in ( "
    '                SQL = SQL & "   select p2.ProductListRefID from ProductList p2 "
    '                SQL = SQL & "   WHERE p2.IsDelete =0  and p2.ProductListRefID>0"
    '                SQL = SQL & "   AND p2.RefTable in('Reserve','SellOrders') )"
    '                DataTable = gConnection.executeSelectQuery(SQL, tr)
    '                If IsNothing(DataTable) OrElse DataTable.Rows.Count = 0 Then
    '                    'lStatus = "Close" 'Quotation ที่ทำ Reserve,SellOrders หมดแล้ว
    '                    If CompareUnitIsClose(pRefOrderID, "'Reserve','SellOrders'", "Quotation", tr) = False Then
    '                        lStatus = "Waiting"
    '                    Else
    '                        lStatus = "Close"
    '                    End If
    '                Else
    '                    lStatus = "Waiting"
    '                End If
    '            Else 'Reserve
    '                SQL = "SELECT p1.*  "
    '                SQL = SQL & " FROM ProductList p1"
    '                SQL = SQL & " WHERE p1.IsDelete =0  "
    '                SQL = SQL & " AND p1.RefTable ='Reserve'"
    '                SQL = SQL & " AND p1.RefID =" & pRefOrderID
    '                SQL = SQL & " AND p1.ProductListID not in ( "
    '                SQL = SQL & "   select p2.ProductListRefID from ProductList p2 "
    '                SQL = SQL & "   WHERE p2.IsDelete =0  and p2.ProductListRefID>0"
    '                SQL = SQL & "   AND p2.RefTable in ('SellOrders') )"
    '                DataTable = gConnection.executeSelectQuery(SQL, tr)
    '                If IsNothing(DataTable) OrElse DataTable.Rows.Count = 0 Then
    '                    'lStatus = "Close" 'Reserve ที่ทำ SellOrders หมดแล้ว
    '                    If CompareUnitIsClose(pRefOrderID, "'SellOrders'", "Reserve", tr) = False Then
    '                        lStatus = "Waiting"
    '                    Else
    '                        lStatus = "Close"
    '                    End If
    '                Else
    '                    'lStatus = "Waiting"
    '                End If
    '            End If
    '            If lStatus <> "" Then
    '                SQL = " UPDATE Orders SET "
    '                SQL = SQL & " OrderStatus='" & lStatus & "'"
    '                SQL = SQL & " where OrderID=" & ConvertNullToZero(pRefOrderID)
    '                gConnection.executeInsertQuery(SQL, tr)
    '            End If
    '        Else ''อื่นๆ
    '            If ConvertNullToString(pStatus) <> "" Then
    '                SQL = " UPDATE Orders SET "
    '                SQL = SQL & " OrderStatus='" & ConvertNullToString(pStatus) & "'"
    '                SQL = SQL & " where OrderID=" & ConvertNullToZero(pRefOrderID)
    '                gConnection.executeInsertQuery(SQL, tr)
    '            End If
    '        End If

    '        If pMode = DataMode.ModeNew Then
    '            SQL = " Insert into OrdersRef (OrderID,RefOrderID,IsDelete) values( " & pParentOrderID & "," & pRefOrderID & ",0)"
    '            gConnection.executeInsertQuery(SQL, tr)
    '        ElseIf pMode = DataMode.ModeDelete Then
    '            SQL = " delete from OrdersRef where OrderID=" & pParentOrderID & " and RefOrderID=" & pRefOrderID
    '            gConnection.executeInsertQuery(SQL, tr)
    '        End If
    '    Catch e As Exception
    '        Err.Raise(Err.Number, e.Source, "modDAO.UpdateRefOrderStatus : " & e.Message)
    '    Finally
    '        'lcls = Nothing
    '    End Try
    'End Sub


    'UpdateRefOrderStatus ***** ก่อนเช็คจำนวนรวม
    Public Sub UpdateRefOrderStatus(ByVal pOrderType As Long, ByVal pParentOrderID As Long, ByVal pRefOrderID As Long, ByVal pStatus As String, ByRef ptr As SqlTransaction, ByVal pMode As DataMode)
        Dim SQL As String, lTableNameThai As String = "", lStatus As String = ""
        Dim tr As SqlTransaction = Nothing
        Dim DataTable As DataTable
        Dim lRefOrderType As MasterType, lCount As Long = 0
        Dim lRefFromUnit As Long, lCurrentUnit As Long
        SQL = ""
        Try
            If ptr Is Nothing Then
                tr = gConnection.Connection.BeginTransaction
            Else
                tr = ptr
            End If

            Dim lclsRefOrder As New OrderSDAO
            lRefOrderType = lclsRefOrder.GetOrderTypeFromID(pRefOrderID, tr)

            If pOrderType = MasterType.StockIn Then 'Ref from PO
                'If pIsClose = False Then
                '    lStatus = "Waiting"
                'Else
                SQL = "SELECT p1.*  "
                SQL = SQL & " FROM ProductList p1"
                SQL = SQL & " WHERE p1.IsDelete =0  "
                SQL = SQL & " AND p1.RefTable in ('PurchaseOrder' )"
                SQL = SQL & " AND p1.RefID =" & pRefOrderID
                SQL = SQL & " AND p1.ProductListID not in ( "
                SQL = SQL & "   select p2.ProductListRefID from ProductList p2 "
                SQL = SQL & "   WHERE p2.IsDelete =0  and p2.ProductListRefID>0"
                SQL = SQL & "   AND p2.RefTable ='StockIn' )"
                DataTable = gConnection.executeSelectQuery(SQL, tr)
                If IsNothing(DataTable) OrElse DataTable.Rows.Count = 0 Then
                    'check unit
                    SQL = "SELECT Sum(p1.Units) as Units  "
                    SQL = SQL & " FROM ProductList p1"
                    SQL = SQL & " WHERE p1.IsDelete =0  "
                    SQL = SQL & " AND p1.RefTable in ('PurchaseOrder' )"
                    SQL = SQL & " AND p1.RefID =" & pRefOrderID
                    DataTable = New DataTable
                    DataTable = gConnection.executeSelectQuery(SQL, tr)
                    For Each pRow In DataTable.Rows
                        lRefFromUnit = ConvertNullToZero(pRow("Units"))
                        Exit For
                    Next

                    SQL = "SELECT Sum(p1.Units) as Units  "
                    SQL = SQL & " FROM ProductList p1"
                    SQL = SQL & " WHERE p1.IsDelete =0  "
                    SQL = SQL & " AND p1.RefTable in ('StockIn' )"
                    SQL = SQL & " AND p1.ProductListRefID in ( "
                    SQL = SQL & "   select p2.ProductListID from ProductList p2 "
                    SQL = SQL & "   WHERE p2.IsDelete =0  "
                    SQL = SQL & "   AND p2.RefID =" & pRefOrderID
                    SQL = SQL & "   AND p2.RefTable ='PurchaseOrder' )"
                    DataTable = New DataTable
                    DataTable = gConnection.executeSelectQuery(SQL, tr)
                    For Each pRow In DataTable.Rows
                        lCurrentUnit = ConvertNullToZero(pRow("Units"))
                        Exit For
                    Next

                    If lRefFromUnit > lCurrentUnit Then
                        lStatus = "Waiting"
                    Else
                        lStatus = "Receive"
                    End If
                Else
                    lStatus = "Waiting"
                End If
                'End If
                SQL = " UPDATE Orders SET "
                SQL = SQL & " OrderStatus='" & lStatus & "'"
                SQL = SQL & " where OrderID=" & ConvertNullToZero(pRefOrderID)
                gConnection.executeInsertQuery(SQL, tr)
            ElseIf pOrderType = MasterType.Invoice And lRefOrderType = MasterType.Borrow Then
                If pMode = DataMode.ModeDelete Then
                    SQL = "SELECT p1.*  "
                    SQL = SQL & " FROM ProductList p1"
                    SQL = SQL & " WHERE p1.IsDelete =0  "
                    SQL = SQL & " AND p1.RefTable in ('Borrow' )"
                    SQL = SQL & " AND p1.RefID =" & pRefOrderID
                    SQL = SQL & " AND p1.ProductListID   in ( "
                    SQL = SQL & "   select p2.ProductListRefID from ProductList p2 "
                    SQL = SQL & "   WHERE p2.IsDelete =0  and p2.ProductListRefID>0"
                    SQL = SQL & "   AND p2.RefTable in( 'Invoice' ) )"
                    DataTable = gConnection.executeSelectQuery(SQL, tr)
                    If IsNothing(DataTable) OrElse DataTable.Rows.Count = 0 Then
                        lStatus = "Open"
                    Else
                    End If
                Else ' new ,Edit
                    SQL = "SELECT p1.*  "
                    SQL = SQL & " FROM ProductList p1"
                    SQL = SQL & " WHERE p1.IsDelete =0  "
                    SQL = SQL & " AND p1.RefTable in ('Borrow' )"
                    SQL = SQL & " AND p1.RefID =" & pRefOrderID
                    SQL = SQL & " AND p1.ProductListID not in ( "
                    SQL = SQL & "   select p2.ProductListRefID from ProductList p2 "
                    SQL = SQL & "   WHERE p2.IsDelete =0  and p2.ProductListRefID>0"
                    SQL = SQL & "   AND p2.RefTable in( 'Invoice' ) )"
                    DataTable = gConnection.executeSelectQuery(SQL, tr)
                    If IsNothing(DataTable) OrElse DataTable.Rows.Count = 0 Then
                        lStatus = "Close"
                    Else
                        lStatus = "Waiting"
                    End If
                End If
                SQL = " UPDATE Orders SET "
                SQL = SQL & " OrderStatus='" & lStatus & "'"
                SQL = SQL & " where OrderID=" & ConvertNullToZero(pRefOrderID)
                gConnection.executeInsertQuery(SQL, tr)
            ElseIf pOrderType = MasterType.Borrow Or pOrderType = MasterType.Invoice Or pOrderType = MasterType.Shiping Then 'Ref from Sell
                If pMode = DataMode.ModeDelete Then
                    SQL = "SELECT p1.*  "
                    SQL = SQL & " FROM ProductList p1"
                    SQL = SQL & " WHERE p1.IsDelete =0  "
                    SQL = SQL & " AND p1.RefTable in ('SellOrders' )"
                    SQL = SQL & " AND p1.RefID =" & pRefOrderID
                    SQL = SQL & " AND p1.ProductListID  in ( "
                    SQL = SQL & "   select p2.ProductListRefID from ProductList p2 "
                    SQL = SQL & "   WHERE p2.IsDelete =0  and p2.ProductListRefID>0"
                    SQL = SQL & "   AND p2.RefTable in('Borrow','Invoice','Shiping') )"
                    DataTable = gConnection.executeSelectQuery(SQL, tr)
                    If IsNothing(DataTable) OrElse DataTable.Rows.Count = 0 Then
                        lStatus = "Open"
                    Else
                        lStatus = "Waiting"
                    End If
                Else
                    SQL = "SELECT p1.*  "
                    SQL = SQL & " FROM ProductList p1"
                    SQL = SQL & " WHERE p1.IsDelete =0  "
                    SQL = SQL & " AND p1.RefTable in ('SellOrders' )"
                    SQL = SQL & " AND p1.RefID =" & pRefOrderID
                    SQL = SQL & " AND p1.ProductListID not in ( "
                    SQL = SQL & "   select p2.ProductListRefID from ProductList p2 "
                    SQL = SQL & "   WHERE p2.IsDelete =0  and p2.ProductListRefID>0"
                    SQL = SQL & "   AND p2.RefTable in('Borrow','Invoice','Shiping') )"
                    DataTable = gConnection.executeSelectQuery(SQL, tr)
                    If IsNothing(DataTable) OrElse DataTable.Rows.Count = 0 Then
                        lStatus = "Close"
                    Else
                        lStatus = "Waiting"
                    End If
                End If

                'End If
                SQL = " UPDATE Orders SET "
                SQL = SQL & " OrderStatus='" & lStatus & "'"
                SQL = SQL & " where OrderID=" & ConvertNullToZero(pRefOrderID)
                gConnection.executeInsertQuery(SQL, tr)
            ElseIf pOrderType = MasterType.InvoiceBuy Or pOrderType = MasterType.ShipingBuy Then ' 
                If pMode = DataMode.ModeDelete Then
                    SQL = "SELECT p1.*  "
                    SQL = SQL & " FROM ProductList p1"
                    SQL = SQL & " WHERE p1.IsDelete =0  "
                    SQL = SQL & " AND p1.RefTable ='PurchaseOrder'"
                    SQL = SQL & " AND p1.RefID =" & pRefOrderID
                    SQL = SQL & " AND p1.ProductListID not in ( "
                    SQL = SQL & "   select p2.ProductListRefID from ProductList p2 "
                    SQL = SQL & "   WHERE p2.IsDelete =0  and p2.ProductListRefID>0"
                    SQL = SQL & "   AND p2.RefTable ='StockIn' )"
                    DataTable = gConnection.executeSelectQuery(SQL, tr)
                    If IsNothing(DataTable) OrElse DataTable.Rows.Count = 0 Then
                        lStatus = "Receive" 'PO ที่ทำ stockin หมดแล้ว
                    Else
                        lStatus = "Waiting" 'รอทำ stockin  
                    End If
                Else
                    SQL = "SELECT p1.*  "
                    SQL = SQL & " FROM ProductList p1"
                    SQL = SQL & " WHERE p1.IsDelete =0  "
                    SQL = SQL & " AND p1.RefTable ='PurchaseOrder'"
                    SQL = SQL & " AND p1.RefID =" & pRefOrderID
                    SQL = SQL & " AND p1.ProductListID not in ( "
                    SQL = SQL & "   select p2.ProductListRefID from ProductList p2 "
                    SQL = SQL & "   WHERE p2.IsDelete =0  and p2.ProductListRefID>0"
                    SQL = SQL & "   AND p2.RefTable in ('InvoiceBuy','ShipingBuy') )"
                    DataTable = gConnection.executeSelectQuery(SQL, tr)
                    If IsNothing(DataTable) OrElse DataTable.Rows.Count = 0 Then
                        lStatus = "Close" 'PO ที่ทำ InvoiceBuy หมดแล้ว
                    Else
                        'lStatus = "Waiting"
                    End If
                End If
                If lStatus <> "" Then
                    SQL = " UPDATE Orders SET "
                    SQL = SQL & " OrderStatus='" & lStatus & "'"
                    SQL = SQL & " where OrderID=" & ConvertNullToZero(pRefOrderID)
                    gConnection.executeInsertQuery(SQL, tr)
                End If
            ElseIf pOrderType = MasterType.Reserve Then 'Ref from QUOTAION
                If pMode = DataMode.ModeDelete Then 'เช็ค QUOTAION โดนดึงไปทำ Reserve บางส่วนไหม ถ้าไม่คืนเป็น Open ถ้ามีเป็น Waiting 
                    SQL = "SELECT p1.*  "
                    SQL = SQL & " FROM ProductList p1"
                    SQL = SQL & " WHERE p1.IsDelete =0  "
                    SQL = SQL & " AND p1.RefTable ='Quotation'"
                    SQL = SQL & " AND p1.RefID =" & pRefOrderID
                    SQL = SQL & " AND p1.ProductListID in ( "
                    SQL = SQL & "   select p2.ProductListRefID from ProductList p2 "
                    SQL = SQL & "   WHERE p2.IsDelete =0  and p2.ProductListRefID>0"
                    SQL = SQL & "   AND p2.RefTable in('Reserve','SellOrders') )"
                    DataTable = gConnection.executeSelectQuery(SQL, tr)
                    If IsNothing(DataTable) OrElse DataTable.Rows.Count = 0 Then
                        lStatus = "Open" 'Quotation ที่ทำ Reserve,SellOrders หมดแล้ว
                    Else
                        lStatus = "Waiting" 'รอทำ Reserve  
                    End If
                Else
                    SQL = "SELECT p1.*  "
                    SQL = SQL & " FROM ProductList p1"
                    SQL = SQL & " WHERE p1.IsDelete =0  "
                    SQL = SQL & " AND p1.RefTable in ('Quotation' )"
                    SQL = SQL & " AND p1.RefID =" & pRefOrderID
                    SQL = SQL & " AND p1.ProductListID not in ( "
                    SQL = SQL & "   select p2.ProductListRefID from ProductList p2 "
                    SQL = SQL & "   WHERE p2.IsDelete =0  and p2.ProductListRefID>0"
                    SQL = SQL & "   AND p2.RefTable in('Reserve','SellOrders') )"
                    DataTable = gConnection.executeSelectQuery(SQL, tr)
                    If IsNothing(DataTable) OrElse DataTable.Rows.Count = 0 Then
                        lStatus = "Close" 'Quotation ที่ทำ Reserve,SellOrders หมดแล้ว
                    Else
                        lStatus = "Waiting"
                    End If
                End If

                SQL = " UPDATE Orders SET "
                SQL = SQL & " OrderStatus='" & lStatus & "'"
                SQL = SQL & " where OrderID=" & ConvertNullToZero(pRefOrderID)
                gConnection.executeInsertQuery(SQL, tr)

            ElseIf pOrderType = MasterType.SellOrders Then
                If pMode = DataMode.ModeDelete And lRefOrderType = MasterType.Quotation Then
                    SQL = "SELECT p1.*  "
                    SQL = SQL & " FROM ProductList p1"
                    SQL = SQL & " WHERE p1.IsDelete =0  "
                    SQL = SQL & " AND p1.RefTable ='Quotation'"
                    SQL = SQL & " AND p1.RefID =" & pRefOrderID
                    SQL = SQL & " AND p1.ProductListID in ( "
                    SQL = SQL & "   select p2.ProductListRefID from ProductList p2 "
                    SQL = SQL & "   WHERE p2.IsDelete =0  and p2.ProductListRefID>0"
                    SQL = SQL & "   AND p2.RefTable in('Reserve','SellOrders') )"
                    DataTable = gConnection.executeSelectQuery(SQL, tr)
                    If IsNothing(DataTable) OrElse DataTable.Rows.Count = 0 Then
                        lStatus = "Open" 'Quotation ที่ยังไม่เคยทำ Reserve,SellOrders  
                    Else
                        lCount = DataTable.Rows.Count

                        SQL = "SELECT p1.*  "
                        SQL = SQL & " FROM ProductList p1"
                        SQL = SQL & " WHERE p1.IsDelete =0  "
                        SQL = SQL & " AND p1.RefTable ='Quotation'"
                        SQL = SQL & " AND p1.RefID =" & pRefOrderID
                        SQL = SQL & " AND p1.ProductListID in ( "
                        SQL = SQL & "   select p2.ProductListRefID from ProductList p2 "
                        SQL = SQL & "   WHERE p2.IsDelete =0  and p2.ProductListRefID>0"
                        SQL = SQL & "   AND p2.RefTable in('Reserve','SellOrders') )"
                        DataTable = gConnection.executeSelectQuery(SQL, tr)
                        If IsNothing(DataTable) OrElse DataTable.Rows.Count = 0 Then
                            lStatus = "Open" 'Quotation ที่ยังไม่เคยทำ Reserve,SellOrders  
                        Else
                            lStatus = "Waiting" 'รอทำ Reserve  ,SellOrders
                        End If

                        lStatus = "Waiting" 'รอทำ Reserve  ,SellOrders
                    End If
                ElseIf pMode = DataMode.ModeDelete And lRefOrderType = MasterType.Reserve Then '  ใบสั่งขายดึง Reserve มาทำ
                    SQL = "SELECT p1.*  "
                    SQL = SQL & " FROM ProductList p1"
                    SQL = SQL & " WHERE p1.IsDelete =0  "
                    SQL = SQL & " AND p1.RefTable ='Reserve'"
                    SQL = SQL & " AND p1.RefID =" & pRefOrderID
                    SQL = SQL & " AND p1.ProductListID not in ( "
                    SQL = SQL & "   select p2.ProductListRefID from ProductList p2 "
                    SQL = SQL & "   WHERE p2.IsDelete =0  and p2.ProductListRefID>0"
                    SQL = SQL & "   AND p2.RefTable ='SellOrders' )"
                    DataTable = gConnection.executeSelectQuery(SQL, tr)
                    If IsNothing(DataTable) OrElse DataTable.Rows.Count = 0 Then
                        lStatus = "Open" 'Reserve ที่ยังไม่เคยทำ  SellOrders  
                    Else
                        lStatus = "Waiting" 'รอทำ SellOrders  
                    End If
                ElseIf (pMode = DataMode.ModeNew Or pMode = DataMode.ModeEdit) And lRefOrderType = MasterType.Quotation Then
                    SQL = "SELECT p1.*  "
                    SQL = SQL & " FROM ProductList p1"
                    SQL = SQL & " WHERE p1.IsDelete =0  "
                    SQL = SQL & " AND p1.RefTable in ('Quotation' )"
                    SQL = SQL & " AND p1.RefID =" & pRefOrderID
                    SQL = SQL & " AND p1.ProductListID not in ( "
                    SQL = SQL & "   select p2.ProductListRefID from ProductList p2 "
                    SQL = SQL & "   WHERE p2.IsDelete =0  and p2.ProductListRefID>0"
                    SQL = SQL & "   AND p2.RefTable in('Reserve','SellOrders') )"
                    DataTable = gConnection.executeSelectQuery(SQL, tr)
                    If IsNothing(DataTable) OrElse DataTable.Rows.Count = 0 Then
                        lStatus = "Close" 'Quotation ที่ทำ Reserve,SellOrders หมดแล้ว
                    Else
                        lStatus = "Waiting"
                    End If
                Else 'Reserve
                    SQL = "SELECT p1.*  "
                    SQL = SQL & " FROM ProductList p1"
                    SQL = SQL & " WHERE p1.IsDelete =0  "
                    SQL = SQL & " AND p1.RefTable ='Reserve'"
                    SQL = SQL & " AND p1.RefID =" & pRefOrderID
                    SQL = SQL & " AND p1.ProductListID not in ( "
                    SQL = SQL & "   select p2.ProductListRefID from ProductList p2 "
                    SQL = SQL & "   WHERE p2.IsDelete =0  and p2.ProductListRefID>0"
                    SQL = SQL & "   AND p2.RefTable in ('SellOrders') )"
                    DataTable = gConnection.executeSelectQuery(SQL, tr)
                    If IsNothing(DataTable) OrElse DataTable.Rows.Count = 0 Then
                        lStatus = "Close" 'Reserve ที่ทำ SellOrders หมดแล้ว
                    Else
                        'lStatus = "Waiting"
                    End If
                End If
                If lStatus <> "" Then
                    SQL = " UPDATE Orders SET "
                    SQL = SQL & " OrderStatus='" & lStatus & "'"
                    SQL = SQL & " where OrderID=" & ConvertNullToZero(pRefOrderID)
                    gConnection.executeInsertQuery(SQL, tr)
                End If
            Else ''อื่นๆ
                If ConvertNullToString(pStatus) <> "" Then
                    SQL = " UPDATE Orders SET "
                    SQL = SQL & " OrderStatus='" & ConvertNullToString(pStatus) & "'"
                    SQL = SQL & " where OrderID=" & ConvertNullToZero(pRefOrderID)
                    gConnection.executeInsertQuery(SQL, tr)
                End If
            End If

            If pMode = DataMode.ModeNew Then
                SQL = " Insert into OrdersRef (OrderID,RefOrderID,IsDelete) values( " & pParentOrderID & "," & pRefOrderID & ",0)"
                gConnection.executeInsertQuery(SQL, tr)
            ElseIf pMode = DataMode.ModeDelete Then
                SQL = " delete from OrdersRef where OrderID=" & pParentOrderID & " and RefOrderID=" & pRefOrderID
                gConnection.executeInsertQuery(SQL, tr)
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.UpdateRefOrderStatus : " & e.Message)
        Finally
            'lcls = Nothing
        End Try
    End Sub

    Public Sub UpdateRefReserveStatus(ByVal pOrderType As Long, ByVal pParentOrderID As Long, ByVal pRefOrderID As Long, ByRef ptr As SqlTransaction, ByVal pMode As DataMode)
        Dim SQL As String, lTableNameThai As String = "", lStatus As String = ""
        Dim tr As SqlTransaction = Nothing
        Dim DataTable As DataTable
        Dim lCount As Long = 0
        SQL = ""
        Try
            If ptr Is Nothing Then
                tr = gConnection.Connection.BeginTransaction
            Else
                tr = ptr
            End If

            SQL = "SELECT p1.*  "
            SQL = SQL & " FROM ProductList p1"
            SQL = SQL & " WHERE p1.IsDelete =0  "
            SQL = SQL & " AND p1.RefTable in ('Reserve' )"
            SQL = SQL & " AND p1.RefID =" & pRefOrderID
            SQL = SQL & " AND p1.ProductListID not in ( "
            SQL = SQL & "   select p2.ProductListRefID from ProductList p2 "
            SQL = SQL & "   WHERE p2.IsDelete =0  and p2.ProductListRefID>0"
            SQL = SQL & "   AND p2.RefTable in ('PurchaseOrder','CancelPO') )"
            DataTable = gConnection.executeSelectQuery(SQL, tr)
            If IsNothing(DataTable) OrElse DataTable.Rows.Count = 0 Then
                lStatus = "Ordered"
            Else
                lStatus = "Ordering"
            End If

            If pOrderType = MasterType.PurchaseOrder Or pOrderType = MasterType.CancelPO Then
                SQL = " UPDATE Orders SET "
                SQL = SQL & " MakePOStatus='" & lStatus & "'"
                SQL = SQL & " where OrderID=" & ConvertNullToZero(pRefOrderID)
                gConnection.executeInsertQuery(SQL, tr)

            End If

            If pMode = DataMode.ModeNew Then
                SQL = " Insert into OrdersRef (OrderID,RefOrderID,RefReserveID,IsDelete) values( " & pParentOrderID & ",0," & pRefOrderID & ",0)"
                gConnection.executeInsertQuery(SQL, tr)
            ElseIf pMode = DataMode.ModeDelete Then
                SQL = " delete from OrdersRef where OrderID=" & pParentOrderID & " and RefReserveID=" & pRefOrderID
                gConnection.executeInsertQuery(SQL, tr)
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.UpdateRefReserveStatus : " & e.Message)
        Finally
            'lcls = Nothing
        End Try
    End Sub
    Public Sub UpdateOrderByBill(ByVal RefBillID As Long, ByVal OrderID As Long, ByRef tr As SqlTransaction)
        Dim lcls As New OrderSDAO
        Try
            If lcls.InitailData(OrderID, "", tr) = True Then
                lcls.ModeData = DataMode.ModeEdit
                lcls.RefBillID = RefBillID
                If RefBillID > 0 Then
                    lcls.OrderStatus = "Billed"
                Else
                    lcls.OrderStatus = "Open"
                End If
                lcls.SaveData(tr)
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.UpdateOrderByBill : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Public Sub UpdateOrderByReceipt(ByVal RefReceiptID As Long, ByVal OrderID As Long, ByVal PayAmount As Decimal, ByRef tr As SqlTransaction)
        Dim lcls As New OrderSDAO
        Try
            If lcls.InitailData(OrderID, "", tr) = True Then
                lcls.ModeData = DataMode.ModeEdit
                lcls.RefReceiptID = RefReceiptID
                lcls.PayTotal = PayAmount
                If RefReceiptID > 0 Then
                    lcls.OrderStatus = "Close"
                ElseIf lcls.RefBillID > 0 Then
                    lcls.OrderStatus = "Billed"
                Else
                    lcls.OrderStatus = "Open"
                End If
                lcls.SaveData(tr)
            End If
        Catch e As Exception

            Err.Raise(Err.Number, e.Source, "modDAO.UpdateOrderByReceipt : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

End Module
