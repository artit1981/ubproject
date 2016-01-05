Option Explicit On

Imports DevExpress.XtraGrid.Columns

Public Class frmOrderDTL
    Inherits iEditForm

    Private mOrderMode As DataMode
    Private mColData As ProColumn
    Private mProList As List(Of ProductListDAO)

    Public Property OrderMode() As Integer
        Get
            Return mOrderMode
        End Get
        Set(ByVal value As Integer)
            mOrderMode = value
        End Set
    End Property

    Public Property ColData() As Integer
        Get
            Return mColData
        End Get
        Set(ByVal value As Integer)
            mColData = value
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
        Me.Addbar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.PrintBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.PrintBar2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.PrintChequeBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.PrintPaymantBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.OptionSubItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

        Dim bindingSource1 = New BindingSource
        Dim lProSub As ProductSubDAO

        bindingSource1.DataSource = GetType(ProductSubDAO)

        For Each pProlist As ProductListDAO In ProList
            lProSub = New ProductSubDAO
            lProSub.IsSelect = True
            lProSub.ID = pProlist.ID
            lProSub.SEQ = pProlist.SEQ
            lProSub.ProductID = pProlist.ProductID
            lProSub.ProductCode = pProlist.ProductCode
            lProSub.ProductNames = pProlist.ProductName
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
            lProSub.Units_Old = pProlist.Units_Old
            lProSub.IsShow = pProlist.IsShow
            lProSub.IsMerge = pProlist.IsMerge
            lProSub.UnitMainID = pProlist.UnitMainID
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
            .Columns("LocationDTLID").Visible = (mColData And ProColumn.LocationDTLID) = ProColumn.LocationDTLID
            .Columns("UnitName").Visible = (mColData And ProColumn.UnitName) = ProColumn.UnitName
            .Columns("Remark").Visible = (mColData And ProColumn.Remark) = ProColumn.Remark
            .Columns("KeepMin").Visible = (mColData And ProColumn.KeepMin) = ProColumn.KeepMin
            If (mColData And ProColumn.Units) = ProColumn.Units Then
                .Columns("AdjustUnit").Visible = True
                .Columns("SN").Visible = True
            Else
                .Columns("AdjustUnit").Visible = False
                .Columns("SN").Visible = False
            End If

            .Columns("Price").Visible = (mColData And ProColumn.Price) = ProColumn.Price
            .Columns("Cost").Visible = (mColData And ProColumn.Cost) = ProColumn.Cost
            .Columns("Total").Visible = (mColData And ProColumn.Total) = ProColumn.Total
            .Columns("Discount").Visible = (mColData And ProColumn.Discount) = ProColumn.Discount
            .Columns("IsSelect").Visible = (mColData And ProColumn.IsSelect) = ProColumn.IsSelect

            gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False
            gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False
            If .Columns("LocationDTLID").Visible Then .Columns("LocationDTLID").OptionsColumn.ReadOnly = True
            If .Columns("UnitName").Visible Then .Columns("UnitName").OptionsColumn.ReadOnly = True
            If .Columns("Remark").Visible Then .Columns("Remark").OptionsColumn.ReadOnly = True
            If .Columns("Units").Visible Then .Columns("Units").OptionsColumn.ReadOnly = True
            If .Columns("KeepMin").Visible Then .Columns("KeepMin").OptionsColumn.ReadOnly = True
            If .Columns("Price").Visible Then .Columns("Price").OptionsColumn.ReadOnly = True
            If .Columns("Cost").Visible Then .Columns("Cost").OptionsColumn.ReadOnly = True
            If .Columns("Total").Visible Then .Columns("Total").OptionsColumn.ReadOnly = True
            If .Columns("Discount").Visible Then .Columns("Discount").OptionsColumn.ReadOnly = True
            If .Columns("LocationDTLID").Visible Then .Columns("LocationDTLID").OptionsColumn.ReadOnly = True
            .Columns("ProductCode").OptionsColumn.ReadOnly = True
            .Columns("ProductNames").OptionsColumn.ReadOnly = True
            .Columns("UnitName").OptionsColumn.ReadOnly = True
            .Columns("ProductCode").OptionsColumn.ReadOnly = True
            gridView.Columns("IsShow").FilterInfo = New ColumnFilterInfo("[IsShow]=1 OR [IsDelete]=0  ")
        End With
    End Sub
End Class