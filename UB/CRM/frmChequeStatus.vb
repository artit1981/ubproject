Option Explicit On
Imports DevExpress.XtraEditors
Imports System.Data.SqlClient

Public Class frmChequeStatus
    Inherits iEditForm
    Private Const mFormName As String = "frmChequeStatus"


#Region "Overrides"
    Protected Overrides Sub OnLoadForm(ByVal pMode As Integer, ByVal pID As Long, ByVal pOrderType As Long, ByVal pclsConvert As iOrder, ByVal pCusID As Long)
        Try
            InitialForm()
            Call LoadData(pMode, pID)

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".OnLoadForm : " & e.Message)
        End Try
    End Sub

    Protected Overrides Sub ClearAllForm(ByVal pMode As Integer)
        Try
            MyBase.ClearAllForm(pMode)
            Select Case pMode
                Case DataMode.ModeNew, DataMode.ModeCopy, DataMode.ModeConvert

                Case DataMode.ModeEdit
                    'AccountCode.Properties.ReadOnly = True
                    'btnGenID.Enabled = False
            End Select
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".ClearAllForm : " & e.Message)
        End Try

    End Sub

    Private Sub InitialForm()
        Try
            Addbar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            PrintBar2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            ChequeDateFrom.EditValue = DateAdd(DateInterval.Month, -1, GetCurrentDate(Nothing))
            ChequeDateTo.EditValue = GetCurrentDate(Nothing)
            SetComboBank()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".InitialCombo : " & e.Message)
        End Try
    End Sub

    Private Sub SetComboBank()
        Try
            SetSearchLookBank(BankID)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mFormName & ".SetComboBank : " & e.Message)
        End Try
    End Sub

    Protected Overrides Function Save(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        Dim tr As SqlTransaction = Nothing
        Dim lSuccessTX As Long = 0
        Dim lDataDAOsAll = New List(Of ChequeDAO)
        Dim lDataDAOs = New List(Of ChequeDAO)
        Try

            lDataDAOs = UcCheque1.GetDAOs(0)
            For Each pSubCheque As ChequeDAO In lDataDAOs
                If pSubCheque.ChequeStatus <> "N" Then
                    lSuccessTX = lSuccessTX + 1
                End If
            Next

            If lSuccessTX = 0 Then
                ShowProgress(False, "")
                MessageBox.Show("กรุณาเลือกรายการเพื่ออนุมัติ", "อนุมัติรายการ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                ShowProgress(False, "")
                If XtraMessageBox.Show(Me, "ยืนยันการอนุมัติรายการจำนวน " & lSuccessTX & " ใช่หรือไม่", "อนุมัติรายการ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    tr = gConnection.Connection.BeginTransaction
                    lSuccessTX = 0
                    For Each pSubCheque As ChequeDAO In lDataDAOs
                        If pSubCheque.ChequeStatus <> "N" Then
                            pSubCheque.ModeData = DataMode.ModeEdit
                            If pSubCheque.ChequeStatus = "P" Then
                                pSubCheque.ChequeDatePass = GetCurrentDate(tr)
                            ElseIf pSubCheque.ChequeStatus = "R" Then
                                pSubCheque.ChequeDateStop = GetCurrentDate(tr)
                            End If
                            pSubCheque.SaveData(tr)
                            lSuccessTX = lSuccessTX + 1
                        End If

                    Next
                    tr.Commit()
                    MessageBox.Show("อนุมัติรายการทั้งหมด " & lSuccessTX & " รายการ", "อนุมัติรายการ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call LoadData(pMode, pID)
                End If
            End If
        Catch ex As Exception
            tr.Rollback()
            Err.Raise(Err.Number, ex.Source, mFormName & ".Save : " & ex.Message)
            Return False
        Finally
            lDataDAOs = Nothing
        End Try
    End Function

    Protected Overrides Sub OnClosedForm()
        'mcls = Nothing
    End Sub
#End Region


#Region "Private"
    Private Function LoadData(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        Dim lBankID As Long = 0
        Try

            lBankID = ConvertNullToZero(BankID.EditValue)
            UcCheque1.ShowControl(True, -1, lBankID, ChequeDateFrom.EditValue, ChequeDateTo.EditValue, True)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".LoadData : " & ex.Message)
            Return False
        Finally

        End Try
    End Function

    'Private Function Verify() As Boolean
    '    Try
    '        DxErrorProvider1.ClearErrors()
    '        'If Trim(AccountCode.Text) = "" Then
    '        '    SetErrorProvider(DxErrorProvider1, AccountCode, "กรุณาระบุข้อมูล")
    '        'ElseIf mcls.CheckExist() Then
    '        '    SetErrorProvider(DxErrorProvider1, AccountCode, "ข้อมูลซ้ำ")
    '        'End If

    '        'If Trim(txtCompanyName.Text) = "" Then
    '        '    SetErrorProvider(DxErrorProvider1, txtCompanyName, "กรุณาระบุข้อมูล")
    '        'End If

    '        'Return DxErrorProvider1.HasErrors = False
    '        Return True
    '    Catch e As Exception
    '        Err.Raise(Err.Number, e.Source, mFormName & ".Verify : " & e.Message)
    '    End Try
    'End Function
#End Region

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        LoadData(0, 0)
    End Sub
End Class