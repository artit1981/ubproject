Public Class ucApproveTX
    Private mDataDAOs As List(Of ApproveTX)
    Private mIsReaOnly As Boolean
    Private bindingSource1 As New BindingSource

    Public Function ShowControl(ByVal pIsReaOnly As Boolean) As Boolean
        Try
            mIsReaOnly = pIsReaOnly
            ClearControl()
            Call LoadData()

            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucApproveTX.ShowControl : " & e.Message)
            Return False
        End Try
    End Function



    Public Function GetDAOs() As List(Of ApproveTX)
        Dim lRow As Long
        Dim lDataDAO As ApproveTX

        Try
            mDataDAOs = New List(Of ApproveTX)

            If gridView.RowCount > 0 Then
                For lRow = 0 To gridView.RowCount
                    If ConvertNullToZero(gridView.GetRowCellValue(lRow, "ID")) <> 0 Then
                        If gridView.GetRowCellDisplayText(lRow, "ApproveStatus") = EnumStatus.Approve.ToString Or gridView.GetRowCellDisplayText(lRow, "ApproveStatus") = EnumStatus.NotApprove.ToString Then
                            lDataDAO = New ApproveTX
                            lDataDAO.ID = ConvertNullToZero(gridView.GetRowCellDisplayText(lRow, "ID"))
                            lDataDAO.OrderID = ConvertNullToZero(gridView.GetRowCellValue(lRow, "OrderID"))
                            lDataDAO.OrderType = ConvertNullToString(gridView.GetRowCellDisplayText(lRow, "OrderType"))
                            lDataDAO.OrderTable = ConvertNullToString(gridView.GetRowCellDisplayText(lRow, "OrderTable"))
                            lDataDAO.OrderCode = ConvertNullToString(gridView.GetRowCellDisplayText(lRow, "OrderCode"))
                            lDataDAO.OrderBy = ConvertNullToString(gridView.GetRowCellDisplayText(lRow, "OrderBy"))
                            lDataDAO.OrderDate = gridView.GetRowCellValue(lRow, "OrderDate")
                            lDataDAO.OrderAmount = ConvertNullToZero(gridView.GetRowCellValue(lRow, "OrderAmount"))
                            lDataDAO.ApproveStatus = gridView.GetRowCellDisplayText(lRow, "ApproveStatus")
                            lDataDAO.ApproveType = ConvertNullToZero(gridView.GetRowCellValue(lRow, "ApproveType"))
                            lDataDAO.Remark = gridView.GetRowCellDisplayText(lRow, "Remark")

                            mDataDAOs.Add(lDataDAO)
                        End If

                    End If
                Next
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucApproveTX.GetDAOs : " & e.Message)
        Finally
            lDataDAO = Nothing
        End Try
        Return mDataDAOs
    End Function

    Public Sub ClearControl()
        Try
            bindingSource1.Clear()
            bindingSource1.DataSource = GetType(ApproveTX)
            gridControl.DataSource = bindingSource1
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucApproveTX.ClearAll : " & e.Message)
        End Try
    End Sub

    Private Sub LoadData()
        Dim lcls As New ApproveTX
        Dim dataTable As New DataTable()

        Try
            bindingSource1.DataSource = GetType(ApproveTX)
            dataTable = lcls.GetDataTable()
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    Dim rec As New ApproveTX()

                    rec.ID = dr("ApproveTXID")
                    rec.OrderID = ConvertNullToZero(dr("OrderID"))
                    rec.OrderType = ConvertNullToString(dr("OrderType"))
                    rec.OrderTable = ConvertNullToString(dr("OrderTable"))
                    rec.OrderCode = ConvertNullToString(dr("OrderCode"))
                    rec.OrderBy = ConvertNullToString(dr("OrderBy"))
                    rec.OrderDate = dr("OrderDate")
                    rec.OrderAmount = ConvertNullToZero(dr("OrderAmount"))
                    rec.ApproveStatus = ConvertNullToString(dr("ApproveStatus"))
                    rec.ApproveType = ConvertNullToZero(dr("ApproveType"))
                    rec.Remark = ConvertNullToString(dr("Remark"))
                    rec.ModeData = DataMode.ModeEdit
                    bindingSource1.Add(rec)
                Next
            End If
            gridControl.DataSource = bindingSource1
            GridStyle()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucApproveTX.LoadData : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub


    Private Sub GridStyle()
        With gridView
            If mIsReaOnly = True Then
                gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False
                gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False
                'If .Columns("Discount").Visible Then .Columns("Discount").OptionsColumn.ReadOnly = True 
            End If
        End With
    End Sub


End Class
