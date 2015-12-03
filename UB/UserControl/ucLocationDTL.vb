Option Explicit On

Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class ucLocationDTL
    Private mDataDAOs As List(Of LocationDTLDAO)

    Public Function GetNoteDAOs() As List(Of LocationDTLDAO)
        Dim lRow As Long
        Dim lDataDAO As LocationDTLDAO
        Try
            mDataDAOs = New List(Of LocationDTLDAO)

            If gridView.RowCount > 0 Then
                For lRow = 0 To gridView.RowCount
                    If gridView.GetRowCellDisplayText(lRow, "IDCode").Trim <> "" Then
                        lDataDAO = New LocationDTLDAO
                        lDataDAO.ID = ConvertNullToZero(gridView.GetRowCellDisplayText(lRow, "ID"))
                        lDataDAO.IDCode = gridView.GetRowCellDisplayText(lRow, "IDCode")
                        lDataDAO.NameThai = gridView.GetRowCellDisplayText(lRow, "NameThai")
                        lDataDAO.Remark = gridView.GetRowCellDisplayText(lRow, "Remark")
                        mDataDAOs.Add(lDataDAO)
                    End If
                Next
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucLocationDTL.GetNoteDAOs : " & e.Message)
        Finally
            lDataDAO = Nothing
        End Try
        Return mDataDAOs
    End Function

    Public Function ShowControl(ByVal pRefID As Long) As Boolean
        Try
            bindingSource1 = Nothing
            bindingSource1 = New BindingSource
            Call LoadData(pRefID)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucLocationDTL.ShowControl : " & e.Message)
            Return False
        End Try
    End Function

    Public Sub ClearControl()
        Try
            Call LoadData(0)
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucLocationDTL.ClearAll : " & e.Message)
        End Try
    End Sub


    Private Sub LoadData(ByVal pRefID As Long)
        Dim lcls As New LocationDTLDAO
        Dim dataTable As New DataTable()

        Try
            bindingSource1.DataSource = GetType(MyRecord)

            If pRefID > 0 Then
                dataTable = lcls.GetDataTable(pRefID, Nothing)
                If dataTable.Rows.Count > 0 Then
                    For Each dr As DataRow In dataTable.Rows
                        Dim rec As New MyRecord()
                        rec.ID = dr("ID")
                        rec.IDCode = ConvertNullToString(dr("IDCode"))
                        rec.NameThai = ConvertNullToString(dr("NameThai"))
                        rec.Remark = ConvertNullToString(dr("Remark"))
                        bindingSource1.Add(rec)

                    Next
                End If
            End If
            DxErrorProvider1.DataSource = bindingSource1
            DxErrorProvider1.ContainerControl = Me
            gridControl.DataSource = bindingSource1


        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucLocationDTL.LoadData : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Private Sub gridView_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gridView.ValidateRow
        Dim info As New ErrorInfo()
        TryCast(e.Row, MyRecord).GetError(info)
        e.Valid = info.ErrorText = ""

    End Sub

    Private Sub gridView_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gridView.InvalidRowException
        e.ExceptionMode = ExceptionMode.NoAction
    End Sub

    Public Class MyRecord
        Implements IDXDataErrorInfo
        Private mIDs As Long
        Private mIDCode As String
        Private mNameThai As String
        Private mRemark As String

        Public Property ID() As Long
            Get
                Return mIDs
            End Get
            Set(ByVal value As Long)
                mIDs = value
            End Set
        End Property

        Public Property IDCode() As String
            Get
                Return mIDCode
            End Get
            Set(ByVal value As String)
                mIDCode = value
            End Set
        End Property

        Public Property NameThai() As String
            Get
                Return mNameThai
            End Get
            Set(ByVal value As String)
                mNameThai = value
            End Set

        End Property

        Public Property Remark() As String
            Get
                Return mRemark
            End Get
            Set(ByVal value As String)
                mRemark = value
            End Set
        End Property


#Region "IDXDataErrorInfo Members"
        Public Sub GetPropertyError(ByVal propertyName As String, ByVal info As ErrorInfo) Implements IDXDataErrorInfo.GetPropertyError
            If propertyName = "IDCode" AndAlso String.IsNullOrEmpty(IDCode) Then
                info.ErrorText = String.Format("กรุณาระบุรหัสตำแหน่งเก็บ", propertyName)
                info.ErrorType = ErrorType.Critical
            End If
            If propertyName = "NameThai" AndAlso String.IsNullOrEmpty(NameThai) Then
                info.ErrorText = String.Format("กรุณาระบุชื่อตำแหน่งเก็บ", propertyName)
                info.ErrorType = ErrorType.Critical
            End If
        End Sub


        Public Sub GetError(ByVal info As ErrorInfo) Implements IDXDataErrorInfo.GetError
            Dim propertyInfo As New ErrorInfo()
            GetPropertyError("IDCode", propertyInfo)
            If propertyInfo.ErrorText = "" Then
                GetPropertyError("NameThai", propertyInfo)
            End If
            If propertyInfo.ErrorText <> "" Then
                info.ErrorText = "พบข้อผิดพลาด"
            End If
        End Sub
#End Region
    End Class

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class
