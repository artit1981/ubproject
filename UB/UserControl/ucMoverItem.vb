Public Class ucMoverItem
    Public Function GetSelectItem() As String
        Dim lItemList As String = "0" ', row As DataRowView
        Dim lTableRight As DataTable
        lTableRight = lsRight.DataSource
        Try
            'For Each item As Object In lsRight.Items
            '    row = CType(item, DataRowView)
            '    If lItemList = "" Then
            '        lItemList = ConvertNullToZero(row(0))
            '    Else
            '        lItemList = lItemList & "," & ConvertNullToZero(row(0))
            '    End If
            'Next
            For Each item As DataRow In lTableRight.Rows
                If lItemList = "" Then
                    lItemList = ConvertNullToZero(item.Item(0))
                Else
                    lItemList = lItemList & "," & ConvertNullToZero(item.Item(0))
                End If
            Next

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucMoverItem.GetSelectItem : " & e.Message)
        End Try
        Return lItemList
    End Function

    Public Function ShowControl(ByVal pDataTable As DataTable, ByVal pColValue As String, ByVal pColDisplay As String) As Boolean
        Dim lRightTable As DataTable
        Try
            pDataTable.PrimaryKey = New DataColumn() {pDataTable.Columns(pColValue)}
            
            lRightTable = pDataTable.Clone
            lRightTable.Clear()

            chkAllLeft.CheckState = CheckState.Checked
            chkAllRight.CheckState = CheckState.Unchecked

            lsLeft.DataSource = pDataTable
            lsLeft.DisplayMember = pColDisplay
            lsLeft.ValueMember = pColValue
           
            lsRight.DataSource = lRightTable
            lsRight.DisplayMember = pColDisplay
            lsRight.ValueMember = pColValue
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucMoverItem.ShowControl : " & e.Message)

        End Try
    End Function

    Private Sub chkAllLeft_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAllLeft.CheckedChanged
        If chkAllLeft.CheckState = CheckState.Checked Then
            lsLeft.CheckAll()
        Else
            lsLeft.UnCheckAll()
        End If
    End Sub

    Private Sub chkAllRight_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAllRight.CheckedChanged
        If chkAllRight.CheckState = CheckState.Checked Then
            lsRight.CheckAll()
        Else
            lsRight.UnCheckAll()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As System.EventArgs) Handles btnAdd.Click
        Dim lTableLeft As DataTable, lTableRight As DataTable, lrow As DataRow, lDatarow As DataRowView
        Dim lKey As New List(Of Long)
        Try
            ShowProgress(True, "Loading...")
            lTableLeft = lsLeft.DataSource
            lTableRight = lsRight.DataSource
           
            For Each item As Object In lsLeft.CheckedItems
                lDatarow = CType(item, DataRowView)
                lKey.Add(ConvertNullToZero(lDatarow(0)))
            Next

            For Each iKey As Long In lKey
                If iKey > 0 Then
                    lrow = lTableLeft.Rows.Find(iKey)
                    lTableRight.ImportRow(lrow)
                    lTableLeft.Rows.Remove(lrow)
                End If
            Next
            chkAllLeft.CheckState = CheckState.Unchecked
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "ucMoverItem.btnAdd_Click : " & ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As System.EventArgs) Handles btnRemove.Click
        Dim lTableLeft As DataTable, lTableRight As DataTable, lrow As DataRow, lDatarow As DataRowView
        Dim lKey As New List(Of Long)
        Try
            ShowProgress(True, "Loading...")
            lTableLeft = lsLeft.DataSource
            lTableRight = lsRight.DataSource

            For Each item As Object In lsRight.CheckedItems
                lDatarow = CType(item, DataRowView)
                lKey.Add(ConvertNullToZero(lDatarow(0)))
            Next

            For Each iKey As Long In lKey
                If iKey > 0 Then
                    lrow = lTableRight.Rows.Find(iKey)
                    lTableLeft.ImportRow(lrow)
                    lTableRight.Rows.Remove(lrow)
                End If
            Next
            chkAllRight.CheckState = CheckState.Unchecked
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "ucMoverItem.btnRemove_Click : " & ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub lsLeft_DoubleClick(sender As Object, e As System.EventArgs) Handles lsLeft.DoubleClick
        Dim lTableLeft As DataTable, lTableRight As DataTable, row As DataRow, iKey As Long

        Try
            ShowProgress(True, "Loading...")

            lTableLeft = lsLeft.DataSource
            lTableRight = lsRight.DataSource

            iKey = lsLeft.GetItemValue(lsLeft.SelectedIndex)
            If iKey > 0 Then
                row = lTableLeft.Rows.Find(iKey)
                lTableRight.ImportRow(row)
                lTableLeft.Rows.Remove(row)
                chkAllLeft.CheckState = CheckState.Unchecked
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "ucMoverItem.lsLeft_DoubleClick : " & ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub lsRight_DoubleClick(sender As Object, e As System.EventArgs) Handles lsRight.DoubleClick
        Dim lTableLeft As DataTable, lTableRight As DataTable, row As DataRow, iKey As Long

        Try
            ShowProgress(True, "Loading...")

            lTableLeft = lsLeft.DataSource
            lTableRight = lsRight.DataSource

            iKey = lsRight.GetItemValue(lsRight.SelectedIndex)
            If iKey > 0 Then
                row = lTableRight.Rows.Find(iKey)
                lTableLeft.ImportRow(row)
                lTableRight.Rows.Remove(row)
                chkAllRight.CheckState = CheckState.Unchecked
            End If
        Catch ex As Exception
            Err.Raise(Err.Number, ex.Source, "ucMoverItem.lsRight_DoubleClick : " & ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub
End Class
