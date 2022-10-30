Option Explicit On

Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Controls

Module modDAO

    Public Enum RefOrderStatus
        NotToRef = 1
        RefSome = 2
        RefAll = 3
    End Enum

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
            dataTable.DefaultView.Sort = "ID"
            pCombo.Properties.DataSource = dataTable
            pCombo.Properties.DisplayMember = "NameThai"
            pCombo.Properties.ValueMember = "ID"
            pCombo.ItemIndex = 0
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
            dataTable.DefaultView.Sort = "ID"
            pCombo.Properties.DataSource = dataTable
            pCombo.Properties.DisplayMember = "Code"
            pCombo.Properties.ValueMember = "ID"
            pCombo.ItemIndex = 0
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
            Err.Raise(Err.Number, e.Source, "modDAO.SetSearchLookCustomer : " & e.Message)
        Finally
            lcls = Nothing
            dataTable = Nothing
        End Try
    End Sub


    Public Sub SetSearchLookCampaign(ByVal pCombo As DevExpress.XtraEditors.SearchLookUpEdit, ByVal pStartDate As Date, ByVal pExpireDate As Date, ByVal pLoadAll As Boolean)
        Dim lcls As New CampaignDAO
        Dim dataTable As New DataTable()
        Try
            lcls.TableID = MasterType.Accounts
            dataTable = lcls.GetDataTableCombo(0, True, pStartDate, pExpireDate, pLoadAll)
            pCombo.Properties.DataSource = dataTable
            pCombo.Properties.DisplayMember = "Subject"
            pCombo.Properties.ValueMember = "CampaignID"
            pCombo.EditValue = DBNull.Value
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "modDAO.SetSearchLookCampaign : " & e.Message)
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

    Public Function GetCurrentDate(ByRef tr As SqlTransaction) As DateTime

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
                SQL &=  lstrWhere
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
                    ElseIf ModeData = DataMode.ModeNew Then
                        Note.ModeData = DataMode.ModeNew
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


End Module
