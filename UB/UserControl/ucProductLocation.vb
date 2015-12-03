Option Explicit On

Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class ucProductLocation
    Private mDataDAOs As List(Of ProductLocationSDAO)
    Private clone As DataView
    Dim llngLocationID As Long

    Public Function GetDAOs() As List(Of ProductLocationSDAO)
        Dim lRow As Long
        Dim lDataDAO As ProductLocationSDAO
        Try
            mDataDAOs = New List(Of ProductLocationSDAO)

            If gridView.RowCount > 0 Then
                For lRow = 0 To gridView.RowCount
                    If ConvertNullToZero(gridView.GetRowCellValue(lRow, "LocationDTLID")) <> 0 Then
                        lDataDAO = New ProductLocationSDAO
                        lDataDAO.ID = ConvertNullToZero(gridView.GetRowCellDisplayText(lRow, "ID"))
                        lDataDAO.SEQ = lRow + 1
                        lDataDAO.LocationID = ConvertNullToZero(gridView.GetRowCellValue(lRow, "LocationID"))
                        lDataDAO.LocationDTLID = ConvertNullToZero(gridView.GetRowCellValue(lRow, "LocationDTLID"))
                        lDataDAO.KeepMax = ConvertNullToZero(gridView.GetRowCellDisplayText(lRow, "KeepMax"))
                        lDataDAO.KeepMin = ConvertNullToZero(gridView.GetRowCellDisplayText(lRow, "KeepMin"))
                        lDataDAO.IsInActive = gridView.GetRowCellValue(lRow, "IsInActive")
                        lDataDAO.IsMain = gridView.GetRowCellValue(lRow, "IsMain")
                        mDataDAOs.Add(lDataDAO)
                    End If
                Next
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucProductLocation.GetNoteDAOs : " & e.Message)
        Finally
            lDataDAO = Nothing
        End Try
        Return mDataDAOs
    End Function

    Public Function ShowControl(ByVal pRefID As Long) As Boolean
        Try
            Call LoadData(pRefID)
            Call LoadDataLocaton()
            Call LoadDataLocationDTL(0)
            LocationDTLIDLookUpEdit1.SearchMode = SearchMode.AutoFilter
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucProductLocation.ShowControl : " & e.Message)
            Return False
        End Try
    End Function

    Public Sub ClearControl()
        Try
            Call LoadData(0)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucProductLocation.ClearAll : " & e.Message)
        End Try
    End Sub


    Private Sub LoadData(ByVal pRefID As Long)
        Dim lcls As New ProductLocationSDAO
        Dim dataTable As New DataTable()

        Try
            'bindingSource1 = Nothing
            bindingSource1.DataSource = GetType(MyRecord)
            dataTable = lcls.GetDataTable(pRefID)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    Dim rec As New MyRecord()
                    rec.ID = dr("ID")
                    rec.SEQ = ConvertNullToZero(dr("SEQ"))
                    rec.LocationID = ConvertNullToZero(dr("LocationID"))
                    rec.LocationDTLID = ConvertNullToZero(dr("LocationDTLID"))
                    rec.KeepMax = ConvertNullToZero(dr("KeepMax"))
                    rec.KeepMin = ConvertNullToZero(dr("KeepMin"))
                    rec.IsInActive = dr("IsInActive")
                    rec.IsMain = ConvertNullToString(dr("IsMain"))
                    bindingSource1.Add(rec)

                Next
            End If

            DxErrorProvider1.DataSource = bindingSource1
            DxErrorProvider1.ContainerControl = Me
            gridControl.DataSource = bindingSource1


        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucProductLocation.LoadData : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Private Sub LoadDataLocaton()
        Dim lcls As New LocatonDAO
        Dim dataTable As New DataTable()

        Try
            dataTable = lcls.GetDataTableCombo(0, True)
            LocationIDLookUpEdit.DataSource = dataTable

            'LocationDTLView.OptionsFind.FindFilterColumns = "Location"
            'LocationDTLView.ApplyFindFilter(String.Empty)
            'LocationDTLView.ApplyFindFilter("1")

            'LocationIDLookUpEdit.OptionsView.ShowGroupedColumns = True
            'LocationDTLView.OptionsView.ShowGroupPanel = True
            'LocationDTLView.Columns.ColumnByFieldName("Location").Group()

            'LocationGrid.View.ExpandAllGroups()
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucProductLocation.LoadDataLocaton : " & e.Message)
        Finally
            dataTable = Nothing
            lcls = Nothing
        End Try
    End Sub

    Private Sub LoadDataLocationDTL(ByVal plngRefID As Long)
        Dim lcls As New LocatonDAO
        Dim dataTable As New DataTable()

        Try
            dataTable = lcls.GetDataTableDTL(True)
            LocationDTLIDLookUpEdit1.DataSource = dataTable

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucProductLocation.LoadDataLocationDTL : " & e.Message)
        Finally
            dataTable = Nothing
            lcls = Nothing
        End Try
    End Sub

    Private Sub gridView_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gridView.CellValueChanged
        'Dim View As ColumnView = sender
        'If e.Column Is View.Columns("LocationID") Then
        If e.Column.FieldName = "LocationID" Then
            llngLocationID = e.Value
            gridView.SetRowCellValue(e.RowHandle, "LocationDTLID", 0)
        End If
    End Sub


    Private Sub gridView_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gridView.ValidateRow
        Dim info As New ErrorInfo()
        TryCast(e.Row, MyRecord).GetError(info)
        e.Valid = info.ErrorText = ""

    End Sub

    Private Sub gridView_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gridView.InvalidRowException
        e.ExceptionMode = ExceptionMode.NoAction
    End Sub


    Private Sub gridView_ShownEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridView.ShownEditor
        Dim view As GridView = CType(sender, GridView)
        Try
            If view.FocusedColumn.FieldName = "LocationDTLID" AndAlso _
          TypeOf view.ActiveEditor Is LookUpEdit Then
                Dim edit As LookUpEdit
                Dim table As DataTable
                edit = CType(view.ActiveEditor, LookUpEdit)
                table = CType(edit.Properties.DataSource, DataTable)
                clone = New DataView(table)
                If llngLocationID > 0 Then
                    clone.RowFilter = "[LocationID] = " + llngLocationID.ToString
                End If
                edit.Properties.DataSource = clone
            End If
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Private Sub gridView_HiddenEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridView.HiddenEditor
        If Not clone Is Nothing Then
            clone.Dispose()
            clone = Nothing
        End If
    End Sub

    Public Class MyRecord
        Implements IDXDataErrorInfo

        Private mIDs As Long
        Private mSEQ As Long
        Private mLocationID As Long
        Private mLocationDTLID As Long
        Private mKeepMin As Long
        Private mKeepMax As Long
        Private mIsInActive As Boolean
        Private mIsMain As String


        Public Property LocationID() As Long
            Get
                Return mLocationID
            End Get
            Set(ByVal value As Long)
                mLocationID = value
            End Set
        End Property


        Public Property LocationDTLID() As Long
            Get
                Return mLocationDTLID
            End Get
            Set(ByVal value As Long)
                mLocationDTLID = value
            End Set
        End Property

        Public Property KeepMin() As Long
            Get
                Return mKeepMin
            End Get
            Set(ByVal value As Long)
                mKeepMin = value
            End Set
        End Property


        Public Property KeepMax() As Long
            Get
                Return mKeepMax
            End Get
            Set(ByVal value As Long)
                mKeepMax = value
            End Set
        End Property
        Public Property IsInActive() As Boolean
            Get
                Return mIsInActive
            End Get
            Set(ByVal Value As Boolean)
                mIsInActive = Value
            End Set

        End Property
        Public Property IsMain() As String
            Get
                Return mIsMain
            End Get
            Set(ByVal Value As String)
                mIsMain = Value
            End Set

        End Property

        Public Property SEQ() As Long
            Get
                Return mSEQ
            End Get
            Set(ByVal value As Long)
                mSEQ = value
            End Set
        End Property

        Public Property ID() As Long
            Get
                Return mIDs
            End Get
            Set(ByVal value As Long)
                mIDs = value
            End Set

        End Property

#Region "IDXDataErrorInfo Members"
        Public Sub GetPropertyError(ByVal propertyName As String, ByVal info As ErrorInfo) Implements IDXDataErrorInfo.GetPropertyError
            If propertyName = "LocationID" AndAlso ConvertNullToZero(LocationID) <= 0 Then
                info.ErrorText = String.Format("กรุณาระบุคลังเก็บ", propertyName)
                info.ErrorType = ErrorType.Critical
            End If
            If propertyName = "LocationDTLID" AndAlso ConvertNullToZero(LocationDTLID) <= 0 Then
                info.ErrorText = String.Format("กรุณาระบุตำแหน่งเก็บ", propertyName)
                info.ErrorType = ErrorType.Critical
            End If
        End Sub


        Public Sub GetError(ByVal info As ErrorInfo) Implements IDXDataErrorInfo.GetError
            Dim propertyInfo As New ErrorInfo()
            GetPropertyError("LocationID", propertyInfo)
            If propertyInfo.ErrorText = "" Then
                GetPropertyError("LocationDTLID", propertyInfo)
            End If
            If propertyInfo.ErrorText <> "" Then
                info.ErrorText = "พบข้อผิดพลาด"
            End If
        End Sub
#End Region
    End Class

   



End Class
