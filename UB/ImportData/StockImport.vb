Option Explicit On
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.DXErrorProvider
Public Class StockImport
    Private mClassName As String = "StockImport"
    Private mRunningFormatDAO As RunningFormatDAO
    Private mStockPropertyS As List(Of StockProperty)

    Public Property DataDAOs() As List(Of StockProperty)
        Get
            Return mStockPropertyS
        End Get
        Set(ByVal Value As List(Of StockProperty))
            mStockPropertyS = Value
        End Set
    End Property

    Public Function LoadFileToGrid(ByVal pDataTable As DataTable) As String
        Try
            Dim lError As String = "", lErrorList As String = "", lSEQ As Long = 1
            Dim rec As StockProperty
            mStockPropertyS = New List(Of StockProperty)

            If pDataTable.Rows.Count > 0 Then
                For Each dr As DataRow In pDataTable.Rows
                    rec = New StockProperty
                    rec.IsSelect = True  '' 0
                    rec.Code = ConvertNullToString(dr(0))
                    rec.NameThai = ConvertNullToString(dr(1))
                    rec.UnitMain = ConvertNullToString(dr(2), True, 100)
                    rec.LocationDTL = ConvertNullToString(dr(3), True, 100)
                    rec.Units = ConvertNullToZero(dr(4))
                    rec.Cost = ConvertNullToZero(dr(5))
                    lError = GetPropertyError(rec)
                    If lError <> "" Then
                        If lErrorList = "" Then
                            lErrorList = "******** Import Error *********"
                            lErrorList = lErrorList & vbNewLine & " Row : " & lSEQ & lError
                        Else
                            lErrorList = lErrorList & vbNewLine & " Row : " & lSEQ & lError
                        End If
                        rec.IsSelect = False
                    End If
                    lSEQ += 1
                    mStockPropertyS.Add(rec)
                Next
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mClassName & ".LoadFileToGrid : " & e.Message)
        End Try
    End Function

    'Public Function CheckIsError(ByVal pGrid As DevExpress.XtraGrid.Views.Grid.GridView) As Boolean
    '    Dim info As New ErrorInfo()
    '    Dim lIsError = False
    '    CheckIsError = False
    '    Try
    '        If pGrid.RowCount > 0 Then
    '            For lRow = 0 To pGrid.RowCount - 1
    '                TryCast(pGrid.GetRow(lRow), StockProperty).GetError(info)
    '                If info.ErrorText <> "" Then
    '                    lIsError = True
    '                End If
    '            Next
    '        End If
    '        Return lIsError
    '    Catch e As Exception
    '        Err.Raise(Err.Number, e.Source, mClassName & ".CheckIsError : " & e.Message)
    '    Finally
    '    End Try
    'End Function

    Public Function ImportData() As Long()
        Dim tr As SqlTransaction = Nothing
        Dim lclsLog As New ImportLog
        Dim lImportID As Long
        Dim lProList As ProductListDAO
        Dim lProListS As New List(Of ProductListDAO)
        Dim lclsStockIn As New OrderSDAO
        Dim lCount(1) As Long
        lCount(0) = 0 'All
        lCount(1) = 0 'Success
        Try
            For Each clsProperty As StockProperty In mStockPropertyS
                If clsProperty.IsSelect = True Then
                    lProList = New ProductListDAO
                    lProList.Cost = clsProperty.Cost
                    lProList.LocationDTLID = clsProperty.LocationDTLID
                    lProList.ProductID = clsProperty.ProductID
                    lProList.UnitID = clsProperty.UnitMainID
                    lProList.Units = clsProperty.Units
                    lProListS.Add(lProList)
                End If
            Next

            If lProListS.Count > 0 Then
                tr = gConnection.Connection.BeginTransaction

                'Save Import log
                lclsLog.TableID = MasterType.StockIn
                Call lclsLog.SaveData(tr)
                lImportID = lclsLog.ImportTXID

                'Begin import
                lCount(0) = lProListS.Count
                lCount(1) = lProListS.Count

                lclsStockIn.TableID = MasterType.StockIn
                lclsStockIn.ID = 0
                lclsStockIn.ModeData = DataMode.ModeNew
                lclsStockIn.Code = AutoGenCode(MasterType.StockIn, tr)
                lclsStockIn.OrderDate = GetCurrentDate(tr)
                lclsStockIn.EmpID = gEmpID
                lclsStockIn.Remark = "Import stock id # " & lImportID
                lclsStockIn.ProductDAOs = lProListS
                lclsStockIn.RefOrderIDs = 0
                lclsStockIn.ImportTXID = lImportID
                lclsStockIn.SaveData(tr)
                InsertActivity(DataMode.ModeImport, MasterType.StockIn, "", tr)
                tr.Commit()

            End If
            Return lCount
        Catch e As Exception
            tr.Rollback()
            Err.Raise(Err.Number, e.Source, mClassName & ".ImportData : " & e.Message)
        Finally
            lProList = Nothing
            lProListS = Nothing
            lclsStockIn = Nothing
        End Try
    End Function

    Public Function GetPropertyError(ByVal pData As StockProperty) As String
        Dim lError As String = ""
        'If String.IsNullOrEmpty(pData.IsNew) Then
        '    pData.IsNew = "Y" 'Default Y
        'ElseIf pData.IsNew.ToString.Trim <> "Y" And pData.IsNew.ToString.Trim <> "N" Then
        '    lError = lError & vbNewLine & "ข้อมูล IsNew ไม่ถูกต้อง[Y,N]"
        'End If

        If String.IsNullOrEmpty(pData.Code) Then
            lError = lError & vbNewLine & "กรุณาระบุข้อมูลรหัสสินค้า"
        Else
            pData.ProductID = CheckProductFromCode(pData.Code)
            If pData.ProductID = 0 Then
                lError = lError & vbNewLine & "ไม่พบรหัสสินค้า : " & pData.Code
            End If

        End If

        If ConvertNullToZero(pData.Units) <= 0 Then
            lError = lError & vbNewLine & "กรุณาระบุจำนวน"
        End If


        If String.IsNullOrEmpty(pData.UnitMain) Then
            lError = lError & vbNewLine & "กรุณาระบุข้อมูลหน่วยนับ"

        Else
            pData.UnitMainID = CheckUnitFromCode(pData.UnitMain)
            If pData.UnitMainID = 0 Then
                lError = lError & vbNewLine & "ไม่พบหน่วยนับในระบบ"
            End If
        End If


        If ConvertNullToString(pData.LocationDTL) <> "" Then
            pData.LocationDTLID = CheckLocationDTL(pData.LocationDTL)
            If pData.LocationDTLID <= 0 Then
                lError = lError & vbNewLine & "ไม่พบตำแหน่งเก็บสินค้าในระบบ : " & pData.LocationDTL
            End If
        Else
            pData.LocationDTLID = 0
        End If


        Return lError
    End Function


    Private Function CheckProductFromCode(ByVal pCode As String) As Long
        Dim lcls As New ProductDAO
        CheckProductFromCode = 0
        Try
            If lcls.InitailData(0, 0, pCode, "") Then
                Return lcls.ID
            Else
                Return 0
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mClassName & ".CheckProductFromCode : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Function
    Private Function CheckProductFromName(ByVal pNamee As String) As Long
        Dim lcls As New ProductDAO
        CheckProductFromName = 0
        Try
            If lcls.InitailData(0, 0, "", pNamee) Then
                Return lcls.ID
            Else
                Return 0
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mClassName & ".CheckProductFromName : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Function

    Private Function CheckUnitFromCode(ByVal pCode As String) As Long
        Dim lcls As New UnitDAO
        CheckUnitFromCode = 0
        Try
            If lcls.InitailData(0, pCode) Then
                Return lcls.ID
            Else
                Return 0
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mClassName & ".CheckUnitFromCode : " & e.Message)
        Finally
            lcls = Nothing

        End Try
    End Function

    Private Function CheckLocationDTL(ByVal pName As String) As Long
        Dim lcls As New LocationDTLDAO
        CheckLocationDTL = 0
        Try
            If lcls.InitailData(0, pName) Then
                Return lcls.ID
            Else
                Return 0
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, mClassName & ".CheckLocationDTL : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Function

    Public Sub New()
        mRunningFormatDAO = New RunningFormatDAO
        mRunningFormatDAO.InitailData(MasterType.StockIn, Nothing)
    End Sub
End Class

Public Class StockProperty

    Private mClassName As String = "StockProperty"

#Region "Property"
    Private mCode As String
    Private mNameThai As String
    Private mUnitMain As String
    Private mLocationDTL As String
    Private mCost As Decimal
    Private mUnits As Decimal
    Private mProductID As Long
    Private mUnitMainID As Long
    Private mLocationDTLID As Long
    Private mVerifyStep1 As Boolean
    Private mIsSelect As Boolean

    Public Property IsSelect() As Boolean
        Get
            Return mIsSelect
        End Get
        Set(ByVal value As Boolean)
            mIsSelect = value
        End Set
    End Property

    Public Property Code() As String
        Get
            Return mCode
        End Get
        Set(ByVal value As String)
            mCode = value
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

    Public Property UnitMain() As String
        Get
            Return mUnitMain
        End Get
        Set(ByVal value As String)
            mUnitMain = value
        End Set
    End Property

    Public Property LocationDTL() As String
        Get
            Return mLocationDTL
        End Get
        Set(ByVal value As String)
            mLocationDTL = value
        End Set
    End Property

    Public Property Cost() As Decimal
        Get
            Return mCost
        End Get
        Set(ByVal value As Decimal)
            mCost = value
        End Set
    End Property

    Public Property Units() As Decimal
        Get
            Return mUnits
        End Get
        Set(ByVal value As Decimal)
            mUnits = value
        End Set
    End Property

    ''Hide
    Public Property ProductID() As Long
        Get
            Return mProductID
        End Get
        Set(ByVal value As Long)
            mProductID = value
        End Set
    End Property

    Public Property UnitMainID() As Long
        Get
            Return mUnitMainID
        End Get
        Set(ByVal value As Long)
            mUnitMainID = value
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

    Private Property VerifyStep1() As Boolean
        Get
            Return mVerifyStep1
        End Get
        Set(ByVal value As Boolean)
            mVerifyStep1 = value
        End Set
    End Property

#End Region

#Region "Save Product"
    'Public Sub SaveData(ByRef ptr As SqlTransaction, ByVal pImportID As Long)
    '    Dim lcls As New ProductStockDAO
    '    Dim lclsCost As New ProductCostDAO
    '    Try
    '        'Update Stock +
    '        lcls.ProductID = ProductID
    '        lcls.UnitID = UnitMainID
    '        lcls.LocationDTLID = LocationDTLID
    '        lcls.Cost = Cost
    '        lcls.Units = Units
    '        lcls.SaveData(ptr)

    '        'Unodate Cost
    '        lclsCost.ModeData = DataMode.ModeNew
    '        lclsCost.SaveData(ProductID, ProductCostDAO.CostTypes.Average, Cost, 0, ptr)
    '    Catch e As Exception
    '        Err.Raise(Err.Number, e.Source, mClassName & ".SaveData : " & e.Message)
    '    Finally
    '        lcls = Nothing
    '    End Try
    'End Sub



#End Region


    Public Sub New()
        mVerifyStep1 = False
        mIsSelect = True
        mCode = ""
        mNameThai = ""
        mUnitMain = ""
        mLocationDTL = ""
        mUnits = 0
        mCost = 0
        mUnitMainID = 0
        mLocationDTLID = 0
        mProductID = 0
    End Sub
End Class
