Option Explicit On

Imports DevExpress.XtraEditors

Public Class frmSNUpdateStatus

    Dim mProductName As String
    Dim mProductCode As String
    Dim mUnit As Long
    Dim mSnList As List(Of SnDAO)
    Private mIsFromLoad As Boolean
    Dim mProductIDs As Long

    Public Property SnList() As List(Of SnDAO)
        Get
            Return mSnList
        End Get
        Set(ByVal value As List(Of SnDAO))
            mSnList = value
        End Set
    End Property

    Public WriteOnly Property ProductCodes() As String
        Set(ByVal value As String)
            mProductCode = value
        End Set
    End Property

    Public WriteOnly Property ProductNames() As String
        Set(ByVal value As String)
            mProductName = value
        End Set
    End Property

    Public WriteOnly Property Unit() As Long
        Set(ByVal value As Long)
            mUnit = value
        End Set
    End Property

    Public WriteOnly Property ProductIDs() As Long
        Set(ByVal value As Long)
            mProductIDs = value
        End Set
    End Property

    Private Sub frmSN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mIsFromLoad = True

        Init()
        ProductCode.EditValue = mProductCode
        ProductName.EditValue = mProductName

        mIsFromLoad = False
    End Sub

    Private Sub Init()
        Try
            If mIsFromLoad = False Then
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "frmSN.Init : " & e.Message)
        Finally
        End Try
    End Sub

    Private Sub LoadSN()
        Dim lclsSN As New SnDAO
        Dim dataSN As New DataTable()
        Try
            mSnList = New List(Of SnDAO)
            dataSN = lclsSN.GetDataTable(Nothing, 0, mProductIDs, "'New','Close'", Nothing, False, "", False)
            For Each dr2 As DataRow In dataSN.Rows
                lclsSN = New SnDAO
                lclsSN.IsSelect = False
                lclsSN.SerialNumberID = ConvertNullToZero(dr2("SerialNumberID"))
                lclsSN.SerialNumberNo = ConvertNullToString(dr2("SerialNumberNo"))
                lclsSN.Status = ConvertNullToString(dr2("Status"))
                lclsSN.IsDelete = ConvertNullToZero(dr2("IsDelete"))
                mSnList.Add(lclsSN)
            Next
            GridControl1.DataSource = mSnList
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "frmSN.LoadSN : " & ex.Message)
        Finally
        End Try
    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        mSnList = New List(Of SnDAO)
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim lRow As Long = 0
        Dim lSnData As SnDAO
        Try
            If GridView1.RowCount > 0 Then
                If XtraMessageBox.Show(Me, "ยืนยันการแก้ไขสถานะ", "SerialNumber", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    For lRow = 0 To GridView1.RowCount
                        If GridView1.GetRowCellValue(lRow, "IsSelect") = True Then
                            lSnData = New SnDAO
                            lSnData.SerialNumberID = GridView1.GetRowCellValue(lRow, "SerialNumberID")
                            lSnData.SerialNumberNo = GridView1.GetRowCellValue(lRow, "SerialNumberNo")
                            lSnData.Status = ConvertNullToString(SNStatus.EditValue)
                            lSnData.SaveData(Nothing, DataMode.ModeEdit)
                        End If
                    Next
                    LoadSN()
                End If
            End If

        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        End Try

    End Sub


    Private Sub InitialProduct(ByVal pProID As Long, ByVal pProCode As String)
        Dim lcls As New ProductDAO
        If lcls.InitailData(pProID, 0, pProCode, "", Nothing) Then
            ProductName.EditValue = lcls.NameThai
            ProductCode.EditValue = lcls.Code
            mProductIDs = lcls.ID
            LoadSN()
        Else
            ShowProgress(False, "")
            MessageBox.Show("ไม่พบสินค้ารหัส : " & pProCode, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ProductCode.Focus()
            ProductCode.SelectAll()
        End If
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Try
            Dim lfrmFind As New frmFindProduct
            Dim i As Long
            'lfrmFind.LookFor = ConvertNullToString(ProductCode.EditValue)
            lfrmFind.Execute(MasterType.Product, gCustomerID)
            If lfrmFind.IsAccept Then
                If lfrmFind.GetDataKey.Count > 0 Then
                    ShowProgress(True, "Loading....")
                    For i = 1 To lfrmFind.GetDataKey.Count
                        If ConvertNullToZero(lfrmFind.GetDataKey(i)) > 0 Then
                            InitialProduct(ConvertNullToZero(lfrmFind.GetDataKey(i)), "")

                        End If
                    Next
                    lfrmFind = Nothing
                End If
            End If
            ShowProgress(False, "")
        Catch ex As Exception
            ShowProgress(False, "")
            ShowErrorMsg(False, ex.Message)
        Finally

        End Try
    End Sub


End Class