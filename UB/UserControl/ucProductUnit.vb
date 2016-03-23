Option Explicit On

Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraGrid.Views.Base

Public Class ucProductUnit

    Dim mIsError As String

    Public ReadOnly Property IsError() As String
        Get
            Return mIsError
        End Get
    End Property

    Private mDataDAOs As List(Of ProductUnitDAO)

    Public Function GetDAOs(ByVal pUnitMainID As Long) As List(Of ProductUnitDAO)
        Dim lRow As Long
        Dim lDataDAO As ProductUnitDAO
        Dim info As New ErrorInfo()
        Dim lclProduct As New ProductDAO
        Dim lPreRate As Decimal = 0
        Try
            mDataDAOs = New List(Of ProductUnitDAO)
            mIsError = ""
            If gridView.RowCount > 0 Then
                For lRow = 0 To gridView.RowCount
                    If ConvertNullToZero(gridView.GetRowCellValue(lRow, "UnitID")) <> 0 Then
                        lDataDAO = New ProductUnitDAO
                        lDataDAO.ID = ConvertNullToZero(gridView.GetRowCellDisplayText(lRow, "ID"))
                        lDataDAO.UnitID = ConvertNullToZero(gridView.GetRowCellValue(lRow, "UnitID"))
                        lDataDAO.SEQ = lRow + 1
                        lDataDAO.Rate = ConvertNullToZero(gridView.GetRowCellDisplayText(lRow, "Rate"))
                        lDataDAO.IsInActive = gridView.GetRowCellValue(lRow, "IsInActive")
                        lDataDAO.Remark = gridView.GetRowCellDisplayText(lRow, "Remark")
                        mDataDAOs.Add(lDataDAO)
                        'If pUnitMainID = lDataDAO.UnitID Then
                        '    mIsError = "ไม่สามารถระบุหน่วยนับหลักได้"
                        'End If
                        'If lRow = 0 Then
                        '    If pUnitMainID <> lDataDAO.UnitID Then
                        '        mIsError = "หน่วยนับเริ่มต้นต้องเป็นหน่วยนับหลัก"
                        '    End If
                        'Else
                        '    If lDataDAO.Rate <= lPreRate Then
                        '        mIsError = gridView.GetRowCellDisplayText(lRow, "UnitName") & " : อัตราส่วนต้องมากกว่าลำดับก่อนหน้า"
                        '    End If
                        'End If

                        lPreRate = lDataDAO.Rate


                        If mIsError = "" Then
                            TryCast(gridView.GetRow(lRow), MyRecord).GetError(info)
                            mIsError = info.ErrorText
                        End If

                    End If
                Next
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucProductUnit.GetDAOs : " & e.Message)
        Finally
            lDataDAO = Nothing
        End Try
        Return mDataDAOs
    End Function

    Public Function ShowControl(ByVal pRefID As Long, ByVal pBuyOrSell As Integer) As Boolean
        Try
            Call LoadData(pRefID, pBuyOrSell)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucProductUnit.ShowControl : " & e.Message)
            Return False
        End Try
    End Function

    Public Sub ClearControl()
        Try
            bindingSource1.DataSource = GetType(MyRecord)
            gridControl.DataSource = bindingSource1
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucProductUnit.ClearAll : " & e.Message)
        End Try
    End Sub


    Private Sub LoadData(ByVal pRefID As Long, ByVal pBuyOrSell As Integer)
        Dim lcls As New ProductUnitDAO
        Dim dataTable As New DataTable()

        Try
            bindingSource1.DataSource = GetType(MyRecord)

            dataTable = lcls.GetDataTable(pRefID, pBuyOrSell)
            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    Dim rec As New MyRecord()
                    rec.ID = dr("ID")
                    rec.SEQ = ConvertNullToZero(dr("SEQ"))
                    rec.Rate = ConvertNullToZero(dr("Rate"))
                    rec.IsInActive = dr("IsInActive")
                    rec.UnitID = ConvertNullToZero(dr("UnitID"))
                    rec.UnitCode = ConvertNullToString(dr("UnitCode"))
                    rec.UnitName = ConvertNullToString(dr("UnitName"))
                    rec.Remark = ConvertNullToString(dr("Remark"))
                    bindingSource1.Add(rec)

                Next
            End If
            DxErrorProvider1.DataSource = bindingSource1
            DxErrorProvider1.ContainerControl = Me
            gridControl.DataSource = bindingSource1
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucProductUnit.LoadData : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    Private Function LoadDataUnit(ByVal pUnitCode As String, ByVal pAutoAdd As Boolean) As String

        Dim lstrUnitCode As String
        LoadDataUnit = ""
        Try
            If pUnitCode = "" Then
                lstrUnitCode = ""
            Else
                lstrUnitCode = LoadDataTableUnit(0, pUnitCode, pAutoAdd)
            End If

            If lstrUnitCode <> "" Then
                Return lstrUnitCode
            Else
                Dim lfrmFind As New frmFindData
                lfrmFind.LookFor = pUnitCode
                lfrmFind.Execute(MasterType.UnitBar, 0, 2)

                If ConvertNullToZero(lfrmFind.LookFor) = 0 Then
                    Return ""
                Else
                    lstrUnitCode = LoadDataTableUnit(lfrmFind.LookFor, "", pAutoAdd)
                    If lstrUnitCode <> "" Then
                        Return lstrUnitCode
                    End If
                End If
                lfrmFind = Nothing
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucProductUnit.LoadDataUnit : " & e.Message)
        Finally

        End Try
    End Function

    Private Function LoadDataTableUnit(ByVal pllngID As Long, ByVal pUnitCode As String, ByVal pAutoAdd As Boolean) As String
        Dim lcls As New UnitDAO
        Dim dataTable As New DataTable()
        LoadDataTableUnit = ""
        Try
            If pUnitCode <> "" Then
                dataTable = lcls.GetDataTable(0, True, pUnitCode)
            Else
                dataTable = lcls.GetDataTable(pllngID, True, "")
            End If

            If dataTable.Rows.Count > 0 Then
                For Each dr As DataRow In dataTable.Rows
                    If pAutoAdd Then
                        If Not gridView.GetFocusedRow Is Nothing Then
                            gridView.SetFocusedRowCellValue("UnitID", ConvertNullToZero(dr("ID")))
                            gridView.SetFocusedRowCellValue("UnitName", ConvertNullToString(dr("CodeThai")))
                            gridView.SetFocusedRowCellValue("UnitCode", ConvertNullToString(dr("UnitCode")))
                        Else

                            Dim rec = New MyRecord
                            rec.UnitID = ConvertNullToZero(dr("ID"))
                            rec.UnitCode = ConvertNullToString(dr("UnitCode"))
                            rec.UnitName = ConvertNullToString(dr("CodeThai"))
                            bindingSource1.Add(rec)
                        End If
                    Else
                        gridView.SetFocusedRowCellValue("UnitID", ConvertNullToZero(dr("ID")))
                        gridView.SetFocusedRowCellValue("UnitName", ConvertNullToString(dr("CodeThai")))
                        gridView.SetFocusedRowCellValue("UnitCode", ConvertNullToString(dr("UnitCode")))
                    End If

                    Return ConvertNullToString(dr("UnitCode"))
                    Exit For
                Next
            Else
                Return ""
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucProductUnit.LoadDataTableUnit : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Function

    Private Sub gridView_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gridView.ValidateRow
        Dim info As New ErrorInfo()
        TryCast(e.Row, MyRecord).GetError(info)
        e.Valid = info.ErrorText = ""

    End Sub

    Private Sub gridView_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gridView.InvalidRowException
        e.ExceptionMode = ExceptionMode.NoAction
    End Sub


    Private Sub gridView_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles gridView.ValidatingEditor
        If gridView.FocusedColumn.FieldName = "UnitCode" Then
            If e.Value = "" Then
                e.Valid = False
                e.ErrorText = "กรุณาระบุข้อมูล"
            Else
                Dim lValue As String = LoadDataUnit(e.Value, False)
                If lValue = "" Then
                    e.Valid = False
                    e.ErrorText = "ไม่พบข้อมูล"
                Else
                    e.Valid = True
                    e.Value = lValue
                End If
            End If
        End If
    End Sub


    Private Sub UnitBtn_ButtonPressed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles UnitBtn.ButtonPressed
        LoadDataUnit("", True)
    End Sub

    Public Class MyRecord
        Implements IDXDataErrorInfo

        Private mIDs As Long
        Private mSEQ As Long
        Private mUnitID As Long
        Private mRate As Decimal
        Private mRemark As String
        Private mUnitCode As String
        Private mUnitName As String
        Private mIsInActive As Boolean


        Public Property UnitCode() As String
            Get
                Return mUnitCode
            End Get
            Set(ByVal value As String)
                mUnitCode = value
            End Set
        End Property


        Public Property UnitName() As String
            Get
                Return mUnitName
            End Get
            Set(ByVal value As String)
                mUnitName = value
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

        Public Property IsInActive() As Boolean
            Get
                Return mIsInActive
            End Get
            Set(ByVal Value As Boolean)
                mIsInActive = Value
            End Set

        End Property
        Public Property Rate() As Decimal
            Get
                Return mRate
            End Get
            Set(ByVal Value As Decimal)
                mRate = Value
            End Set
        End Property

        Public Property UnitID() As Long
            Get
                Return mUnitID
            End Get
            Set(ByVal Value As Long)
                mUnitID = Value
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
            If propertyName = "UnitCode" AndAlso String.IsNullOrEmpty(UnitCode) Then
                info.ErrorText = String.Format("กรุณาระบุข้อมูล", propertyName)
                info.ErrorType = ErrorType.Critical
            End If
            If propertyName = "Rate" AndAlso ConvertNullToZero(Rate) <= 0 Then
                info.ErrorText = String.Format("อัตราส่วนต้องมากกว่า 0", propertyName)
                info.ErrorType = ErrorType.Critical
            End If
        End Sub


        Public Sub GetError(ByVal info As ErrorInfo) Implements IDXDataErrorInfo.GetError
            Dim propertyInfo As New ErrorInfo()
            GetPropertyError("UnitCode", propertyInfo)
            If propertyInfo.ErrorText = "" Then
                GetPropertyError("Rate", propertyInfo)
            End If
            If propertyInfo.ErrorText <> "" Then
                info.ErrorText = "พบข้อผิดพลาด"
            End If
        End Sub
#End Region
    End Class




End Class
