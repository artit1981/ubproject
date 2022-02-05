Option Explicit On

Imports DevExpress.XtraEditors
Imports System.Data.SqlClient

Public Class frmApproveTX
    Inherits iEditForm
    Private Const mFormName As String = "frmApproveTX"
    'Dim mcls As New ApproveTX

#Region "Overrides"
    Protected Overrides Sub OnLoadForm(ByVal pMode As Integer, ByVal pID As Long, ByVal pOrderType As Long, ByVal pclsConvert As iOrder, ByVal pCusID As Long)
        Try
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

    Protected Overrides Function Save(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        Dim tr As SqlTransaction = Nothing
        Dim lSuccessTX As Long = 0
        Try
            Dim lDataDAOs = New List(Of ApproveTX)
            lDataDAOs = UcApproveTX1.GetDAOs
            If lDataDAOs.Count = 0 Then
                ShowProgress(False, "")
                MessageBox.Show("กรุณาเลือกรายการเพื่ออนุมัติ", "อนุมัติรายการ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                ShowProgress(False, "")
                If XtraMessageBox.Show(Me, "ยืนยันการอนุมัติรายการจำนวน " & lDataDAOs.Count & " ใช่หรือไม่", "อนุมัติรายการ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    tr = gConnection.Connection.BeginTransaction
                    For Each pclsApprove As ApproveTX In lDataDAOs
                        If gLimitAmount < pclsApprove.OrderAmount And pclsApprove.ApproveType = 2 Then
                            MessageBox.Show("อนุมัติรายการ " & pclsApprove.OrderCode & " ไม่สำเร็จ เนื่องจาดยอดเงินเกินวงเงินอนุมัติ", "อนุมัติ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            tr.Rollback()
                            Return False
                        Else
                            pclsApprove.ModeData = DataMode.ModeEdit
                            pclsApprove.SaveData(tr)
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
        End Try
    End Function

    Protected Overrides Sub OnClosedForm()
        'mcls = Nothing
    End Sub
#End Region


#Region "Private"
    Private Function LoadData(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        Dim lclsProvince As New ProvinceDAO
        Try
            If pMode = DataMode.ModeNew Then

            ElseIf pMode = DataMode.ModeConvert Then

                MyBase.SetMode = DataMode.ModeNew
            ElseIf pMode = DataMode.ModeEdit Or pMode = DataMode.ModeCopy Then

                'If mcls.InitailData(pID) Then
                '    If pMode = DataMode.ModeEdit Then

                '    ElseIf pMode = DataMode.ModeCopy Then
                '        MyBase.SetMode = DataMode.ModeNew
                '    End If
                'End If
            End If

            UcApproveTX1.ShowControl(False)
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, mFormName & ".LoadData : " & ex.Message)
            Return False
        Finally
            lclsProvince = Nothing
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
End Class