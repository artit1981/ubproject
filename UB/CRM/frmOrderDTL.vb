Option Explicit On

Imports DevExpress.XtraGrid.Columns

Public Class frmOrderDTL
    Inherits iEditForm

    Private mIsSave As Boolean = False
    Private mProList As List(Of ProductListDAO)

    Public Property IsSave() As Boolean
        Get
            Return mIsSave
        End Get
        Set(ByVal value As Boolean)
            mIsSave = value
        End Set
    End Property

    Public Property ProList() As List(Of ProductListDAO)
        Get
            Return mProList
        End Get
        Set(ByVal value As List(Of ProductListDAO))
            mProList = value
        End Set
    End Property


    Private Sub frmOrderDTL_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        IsSave = False
        Me.Text = "ยืนยันการแก้ไขรายการ"
        Me.Addbar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.PrintBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.PrintBar2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.PrintChequeBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.PrintPaymantBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.OptionSubItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

        Dim bindingSource1 = New BindingSource
        Dim lProSub As ProductListDAO

        bindingSource1.DataSource = GetType(ProductListDAO)
        LoadDataLocationDTL()

        For Each pProlist As ProductListDAO In ProList
            lProSub = New ProductListDAO
            lProSub.IsSelect = True
            lProSub.ID = pProlist.ID
            lProSub.SEQ = pProlist.SEQ
            lProSub.ProductID = pProlist.ProductID
            lProSub.ProductCode = pProlist.ProductCode
            lProSub.ProductName = pProlist.ProductName
            lProSub.ProductNameExt = pProlist.ProductNameExt
            lProSub.LocationDTLID = pProlist.LocationDTLID
            lProSub.LocationDTLID_Old = pProlist.LocationDTLID
            lProSub.ProductListRefID = pProlist.ProductListRefID
            lProSub.UnitID = pProlist.UnitID
            lProSub.UnitName = pProlist.UnitName
            lProSub.Remark = pProlist.Remark
            lProSub.KeepMin = pProlist.KeepMin
            lProSub.Units = pProlist.Units
            lProSub.AdjustUnit = pProlist.AdjustUnit
            lProSub.RateUnit = pProlist.RateUnit
            lProSub.Price = pProlist.Price
            lProSub.Cost = pProlist.Cost
            lProSub.Discount = pProlist.Discount
            lProSub.Total = pProlist.Total
            lProSub.UnitMainID = pProlist.UnitMainID
            If lProSub.UnitID = lProSub.UnitMainID Then
                lProSub.Units_Old = pProlist.Units_Old
            Else
                lProSub.Units_Old = pProlist.AdjustUnit_Old
            End If

            lProSub.IsShow = pProlist.IsShow
            lProSub.IsMerge = pProlist.IsMerge

            lProSub.IsDelete = pProlist.IsDelete
            lProSub.IsSN = pProlist.IsSN
            lProSub.SNList = pProlist.SNList
            bindingSource1.Add(lProSub)
        Next
        gridControl.DataSource = bindingSource1
        GridStyle()
    End Sub

    Private Sub GridStyle()
        With gridView
            .Columns("ID").Visible = False
            .Columns("SEQ").Visible = False
            .Columns("ProductID").Visible = False
            .Columns("UnitID").Visible = False
            .Columns("ProductListRefID").Visible = False
            .Columns("LocationDTLID").Visible = True
            .Columns("UnitName").Visible = True
            .Columns("Remark").Visible = True
            .Columns("KeepMin").Visible = False

            .Columns("AdjustUnit").Visible = True
            .Columns("SN").Visible = True
            .Columns("Units_Old").Visible = True

            
            .Columns("Price").Visible = True
            .Columns("Cost").Visible = False
            .Columns("Total").Visible = True
            .Columns("Discount").Visible = True
            .Columns("IsSelect").Visible = False

            gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False
            gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False
            gridView.OptionsBehavior.ReadOnly = True
            'If .Columns("LocationDTLID").Visible Then .Columns("LocationDTLID").OptionsColumn.ReadOnly = True
            'If .Columns("UnitName").Visible Then .Columns("UnitName").OptionsColumn.ReadOnly = True
            'If .Columns("Remark").Visible Then .Columns("Remark").OptionsColumn.ReadOnly = True
            'If .Columns("Units").Visible Then .Columns("Units").OptionsColumn.ReadOnly = True
            'If .Columns("KeepMin").Visible Then .Columns("KeepMin").OptionsColumn.ReadOnly = True
            'If .Columns("Price").Visible Then .Columns("Price").OptionsColumn.ReadOnly = True
            'If .Columns("Cost").Visible Then .Columns("Cost").OptionsColumn.ReadOnly = True
            'If .Columns("Total").Visible Then .Columns("Total").OptionsColumn.ReadOnly = True
            'If .Columns("Discount").Visible Then .Columns("Discount").OptionsColumn.ReadOnly = True
            'If .Columns("LocationDTLID").Visible Then .Columns("LocationDTLID").OptionsColumn.ReadOnly = True
            '.Columns("ProductCode").OptionsColumn.ReadOnly = True
            '.Columns("ProductName").OptionsColumn.ReadOnly = True
            '.Columns("UnitName").OptionsColumn.ReadOnly = True
            '.Columns("ProductCode").OptionsColumn.ReadOnly = True
            gridView.Columns("IsShow").FilterInfo = New ColumnFilterInfo("[IsShow]=1 ")
        End With
    End Sub

    Private Sub LoadDataLocationDTL()
        Dim lcls As New ProductLocationSDAO
        Dim dataTable As New DataTable()

        Try
            dataTable = lcls.GetDataTableDTL(0, "")
            LocationDTLIDLookUpEdit1.DataSource = dataTable
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucProductLists.LoadDataLocationDTL : " & e.Message)
        Finally
            dataTable = Nothing
            lcls = Nothing
        End Try
    End Sub

    Protected Overrides Function Save(ByVal pMode As Integer, ByVal pID As Long) As Boolean
        IsSave = True
        Me.Close()
    End Function

    Private Sub gridView_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles gridView.RowStyle
        If (e.RowHandle >= 0) Then
            If ConvertNullToZero(gridView.GetRowCellValue(e.RowHandle, gridView.Columns("IsDelete"))) = 1 Then
                e.Appearance.BackColor = Color.WhiteSmoke
                e.Appearance.ForeColor = Color.Red
            ElseIf ConvertNullToZero(gridView.GetRowCellValue(e.RowHandle, gridView.Columns("ID"))) = 0 Then
                e.Appearance.BackColor = Color.LightGreen
            Else
                If ConvertNullToZero(gridView.GetRowCellValue(e.RowHandle, gridView.Columns("UnitID"))) = ConvertNullToZero(gridView.GetRowCellValue(e.RowHandle, gridView.Columns("UnitMainID"))) Then
                    If ConvertNullToZero(gridView.GetRowCellValue(e.RowHandle, gridView.Columns("Units_Old"))) <> ConvertNullToZero(gridView.GetRowCellValue(e.RowHandle, gridView.Columns("Units"))) Then
                        e.Appearance.BackColor = Color.LightYellow
                    End If
                Else
                    If ConvertNullToZero(gridView.GetRowCellValue(e.RowHandle, gridView.Columns("Units_Old"))) <> ConvertNullToZero(gridView.GetRowCellValue(e.RowHandle, gridView.Columns("AdjustUnit"))) Then
                        e.Appearance.BackColor = Color.LightYellow
                    End If
                End If
            End If

        End If
    End Sub
End Class