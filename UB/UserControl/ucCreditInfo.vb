Public Class ucCreditInfo
    Private mFormName As String = "ucCreditInfo"
    Private mCusID As Long

    Public Sub ShowControl(ByVal pCusID As Long, ByVal pMode As Integer)
        mCusID = pCusID
        SetPrivilege(pMode)
        SetComboCreditRole()
        SetComboCurrency()
        SetComboTerritory()
        SetComboCriterionPrice()
        SetVatType()
        SetComboCreditGroup()
        SetComboEmp()
        SetComboCustomerZone()
        SetComboCustomerGroup()
        SetComboBankAccount(0)
    End Sub


    Private Function SetPrivilege(ByVal pMode As Integer) As Boolean
        Dim lcls As New PrivilegeDAO
        Try
            If pMode = DataMode.ModeEdit Then
                If lcls.InitailData(gPrivilegeID, MasterType.ManageTeam) Then

                    GroupPrivilege.Visible = (lcls.PrivilegeData And Privilege.Visible) = Privilege.Visible
                    GroupPrivilege.Enabled = (lcls.PrivilegeData And Privilege.Enable) = Privilege.Enable

                Else
                    GroupPrivilege.Enabled = False
                End If
            Else
                GroupPrivilege.Enabled = True
                GroupPrivilege.Visible = True
            End If

        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".SetPrivilege : " & ex.Message)
            Return False
        Finally
            lcls = Nothing
        End Try
    End Function
     


    Private Sub btnRefreshTerritory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshTerritory.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboTerritory()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try

    End Sub

    Private Sub btnRefreshCreditRule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshCreditRule.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboCreditRole()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub btnRefreshCurrency_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshCurrency.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboCurrency()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub
    Private Sub btnCriterionPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCriterionPrice.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboCriterionPrice()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub btnVatTypeID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVatTypeID.Click
        Try
            ShowProgress(True, "Loading...")
            SetVatType()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try


    End Sub
    Private Sub SetComboTerritory()
        Try
            SetLookUpTerritory(cboTerritory)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboTerritory : " & e.Message)
        End Try
    End Sub

    Private Sub SetVatType()
        Try
            SetLookUpVatType(VatTypeID)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetVatType : " & e.Message)
        End Try
    End Sub
    Private Sub SetComboCreditRole()
        Try
            SetLookUpCreditRole(cboCreditRule)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboCreditRole : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboCreditGroup()
        Try
            SetLookUpCreditGroup(CreditGroupID)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboCreditGroup : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboCurrency()
        Try
            SetLookUpCurrency(cboCurrency)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboCurrency : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboCriterionPrice()
        Try
            SetComboMasterLook(CriterionPriceID, MasterType.CriterionPrice)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboCriterionPrice : " & e.Message)
        End Try

    End Sub


    Private Sub SetComboBankAccount(ByVal pIndex As Integer)
        Try
            Select Case pIndex
                Case 1
                    SetSearchLookBankAccount(BankAccountID1, mCusID, 0)
                Case 2
                    SetSearchLookBankAccount(BankAccountID2, mCusID, 0)
                Case 3
                    SetSearchLookBankAccount(BankAccountID3, mCusID, 0)
                Case Else
                    SetSearchLookBankAccount(BankAccountID1, mCusID, 0)
                    SetSearchLookBankAccount(BankAccountID2, mCusID, 0)
                    SetSearchLookBankAccount(BankAccountID3, mCusID, 0)

            End Select

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboBankAccount : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboCustomerZone()
        Try
            SetComboMasterLook(CustomerZoneID, MasterType.CustomerZone)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboCustomerZone : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboCustomerGroup()
        Try
            SetComboMasterLook(CustomerGroupID, MasterType.CustomerGroup)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".CustomerGroup : " & e.Message)
        End Try
    End Sub

    Private Sub CreditGroupID_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles CreditGroupID.EditValueChanged
        If Not CreditGroupID.EditValue Is DBNull.Value Then
            CreditAmount.Enabled = Not (CreditGroupID.EditValue > 0)
        Else
            CreditAmount.Enabled = True
        End If

    End Sub

    Private Sub btnCreditGroupID_Click(sender As System.Object, e As System.EventArgs) Handles btnCreditGroupID.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboCreditGroup()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub
    Private Sub SetComboEmp()
        Try
            Call SetComboEmployee(cboEmp)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboEmp : " & e.Message)
        End Try
    End Sub
   
    Private Sub btnEmp_Click(sender As System.Object, e As System.EventArgs) Handles btnEmp.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboEmp()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try

    End Sub
 
    

    Private Sub btnRefreshCustomerZone_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRefreshCustomerZone.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboCustomerZone()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub btnCustomerGroup_Click(sender As System.Object, e As System.EventArgs) Handles btnCustomerGroup.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboCustomerGroup()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub
 
    'Private Sub IsMainCompany_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Branch.Enabled = IsMainCompanyNo.Checked = True
    '    Branch.TabStop = IsMainCompanyNo.Checked = True
    'End Sub

    Private Sub IsMainCompanyYes_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles IsMainCompanyYes.CheckedChanged
        Branch.Enabled = IsMainCompanyYes.Checked = False
        Branch.TabStop = IsMainCompanyYes.Checked = False
    End Sub

    Private Sub btnBankAccountID1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBankAccountID1.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboBankAccount(1)
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub btnBankAccountID2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBankAccountID2.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboBankAccount(2)
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub btnBankAccountID3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBankAccountID3.Click
        Try
            ShowProgress(True, "Loading...")
            SetComboBankAccount(3)
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub
End Class
