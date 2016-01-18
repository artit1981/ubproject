Option Explicit On

Imports DevExpress.XtraEditors
Imports System.Data.SqlClient

Public Class frmUpdateStockLog

    Dim mProductListDAO As ProductListDAO


    Public WriteOnly Property ProductListDAO() As ProductListDAO
        Set(ByVal value As ProductListDAO)
            mProductListDAO = value
        End Set
    End Property


    Private Sub frmSN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            ProductCode.EditValue = mProductListDAO.ProductCode
            ProductName.EditValue = mProductListDAO.ProductName
            Units.EditValue = mProductListDAO.Units
            txtUnitName.EditValue = mProductListDAO.UnitName
            'Location
            Dim lclsLocation As New LocationDTLDAO
            If lclsLocation.InitailData(mProductListDAO.LocationDTLID) Then
                txtLocation.EditValue = lclsLocation.NameThai
            End If

            btnSN.Enabled = (mProductListDAO.IsSN = 1)

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try
         
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click
       
    End Sub

    Private Sub LoadData()
        Dim lstrErr As String = ""
        Try
            If Not mProductListDAO Is Nothing Then

            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "frmUpdateStockLog.LoadData : " & e.Message)
        End Try
    End Sub
End Class