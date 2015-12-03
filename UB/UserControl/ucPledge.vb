Imports DevExpress.XtraGrid.Views.Grid

Public Class ucPledge
    Private bindingSource1 As BindingSource
    Private mDataDAOs As List(Of PledgeDAO)
    Private mIsReadOnly As Boolean
    Private mIsError As Boolean
    Private mTotal As Double


    Public ReadOnly Property IsError() As Boolean
        Get
            Return mIsError
        End Get
    End Property

    Public ReadOnly Property Totals() As Double
        Get
            Return mTotal
        End Get
    End Property

#Region "Public"
    Public Function ShowControl(ByVal pRefOrderID As Long, ByRef pIsReadOnly As Boolean) As Boolean
        Dim dataTable As New DataTable()
        Dim lcls As New PledgeDAO
        Try
            mIsReadOnly = pIsReadOnly
            dataTable = lcls.GetDataTable(pRefOrderID)
 
            gridControl.DataSource = dataTable
            GridStyle()
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucPledge.ShowControl : " & e.Message)
            Return False
        End Try
    End Function



    Public Function GetDAOs() As List(Of PledgeDAO)
        Dim lRow As Long
        Dim lDataDAO As PledgeDAO
        Try
            mTotal = 0
            mDataDAOs = New List(Of PledgeDAO)
            If gridView.RowCount > 0 Then
                For lRow = 0 To gridView.RowCount
                    If ConvertNullToString(gridView.GetRowCellValue(lRow, "OrderCode")) <> "" Then
                        lDataDAO = New PledgeDAO
                        lDataDAO.ID = ConvertNullToZero(gridView.GetRowCellDisplayText(lRow, "ID"))
                        'lDataDAO.RefOrderID = ConvertNullToZero(GridView.GetRowCellDisplayText(lRow, "RefOrderID"))
                        lDataDAO.OrderCode = ConvertNullToString(gridView.GetRowCellDisplayText(lRow, "OrderCode"))
                        lDataDAO.OrderDate = gridView.GetRowCellDisplayText(lRow, "OrderDate")
                        lDataDAO.Total = ConvertNullToZero(gridView.GetRowCellValue(lRow, "Total"))
                        lDataDAO.Remark = ConvertNullToString(gridView.GetRowCellDisplayText(lRow, "Remark"))
                        mTotal = mTotal + lDataDAO.Total
                        mDataDAOs.Add(lDataDAO)
                        'mIsError = True
                    End If
                Next
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucPledge.GetDAOs : " & e.Message)
        Finally
            lDataDAO = Nothing
        End Try
        Return mDataDAOs
    End Function

    Public Sub ClearControl()
        Try
            If Not bindingSource1 Is Nothing Then
                bindingSource1.Clear()
                bindingSource1.DataSource = GetType(PledgeDAO)
                GridControl.DataSource = bindingSource1
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucPledge.ClearAll : " & e.Message)
        End Try
    End Sub
#End Region

#Region "Private"
    Private Sub GridStyle()
        With GridView
            'GridView.OptionsBehavior.ReadOnly = mIsReadOnly
            '.Columns("ID").Visible = False
            '.Columns("CusName").Visible = False
            '.Columns("IsSelect").Visible = True
            '.Columns("GrandTotal").Visible = True
            '.Columns("OrderCode").Visible = True
            '.Columns("BillTotal").Visible = (mColData And OrdColumn.BillTotal) = OrdColumn.BillTotal
            '.Columns("BillType").Visible = (mColData And OrdColumn.BillType) = OrdColumn.BillType
            '.Columns("Remark").Visible = (mColData And OrdColumn.Remark) = OrdColumn.Remark
        End With
    End Sub

    'Private Sub LoadData(ByVal pBillID As Long)
    '    Dim lcls As New PledgeDAO
    '    Dim dataTable As New DataTable()

    '    Try
    '        dataTable = lcls.GetDataTable(pBillID)
    '        If dataTable.Rows.Count > 0 Then
    '            For Each dr As DataRow In dataTable.Rows
    '                Dim rec As New PledgeDAO()
    '                rec.ID = dr("ID")
    '                rec.RefOrderID = ConvertNullToZero(dr("RefOrderID"))
    '                rec.OrderCode = ConvertNullToString(dr("OrderCode"))
    '                rec.OrderDate = dr("OrderDate")
    '                rec.PledgeTotal = ConvertNullToZero(dr("Total"))
    '                rec.Remark = ConvertNullToString(dr("Remark"))
    '                bindingSource1.Add(rec)
    '            Next
    '        End If
    '    Catch e As Exception
    '        Err.Raise(Err.Number, e.Source, "ucPledge.LoadData : " & e.Message)
    '    Finally
    '        lcls = Nothing
    '    End Try
    'End Sub


#End Region
 
    Private Sub gridView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gridView.InitNewRow
        Dim view As GridView = CType(sender, GridView)
        view.SetRowCellValue(e.RowHandle, view.Columns("OrderDate"), DateTime.Today)
        view.SetRowCellValue(e.RowHandle, view.Columns("ID"), 0)
        view.SetRowCellValue(e.RowHandle, view.Columns("Total"), 0)
        view.SetRowCellValue(e.RowHandle, view.Columns("Remark"), "")
    End Sub
End Class
