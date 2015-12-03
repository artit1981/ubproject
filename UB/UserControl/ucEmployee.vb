Option Explicit On

Imports DevExpress.XtraEditors.Controls
'Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraGrid.Views.Base
Public Class ucEmployee
    Dim mIsError As Boolean
    Private mRefID As Long = 0
    Private mRefTableID As Long = 0

    Public ReadOnly Property IsError() As Boolean
        Get
            Return mIsError
        End Get
    End Property

    Private mDataDAOs As List(Of EmployeeListDAO)

    Public Function GetDAOs() As List(Of EmployeeListDAO)
        Dim lRow As Long
        Dim lDataDAO As EmployeeListDAO
        Dim lEmpID As Long = 0
        Try
            mDataDAOs = New List(Of EmployeeListDAO)
            mIsError = False
            If gridView.RowCount > 0 Then
                For lRow = 0 To gridView.RowCount
                    lEmpID = ConvertNullToZero(gridView.GetRowCellValue(lRow, "EmpID"))
                    If lEmpID > 0 Then
                        lDataDAO = New EmployeeListDAO
                        lDataDAO.EmpID = lEmpID
                        mDataDAOs.Add(lDataDAO)
                    End If
                Next
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucContactRole.GetNoteDAOs : " & e.Message)
        Finally
            lDataDAO = Nothing
        End Try
        Return mDataDAOs
    End Function

    Public Function ShowControl(ByVal pRefID As Long, ByVal pRefTableID As Long, ByVal pIsDelete As Integer) As Boolean
        Try
            mRefID = pRefID
            mRefTableID = pRefTableID
            Call LoadData(pIsDelete)
            Return True
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucContactRole.ShowControl : " & e.Message)
            Return False
        End Try
    End Function

    Public Sub ClearControl()
        Try

            gridControl.DataSource = Nothing
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucContactRole.ClearAll : " & e.Message)
        End Try
    End Sub


    Private Sub LoadData(ByVal pIsDelete As Integer)
        Dim lcls As New EmployeeListDAO
        Dim dataTable As New DataTable()

        Try
            dataTable = lcls.GetDataTable(mRefID, mRefTableID, pIsDelete)
            gridControl.DataSource = dataTable
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucContactRole.LoadData : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Sub

    
    Private Function LoadDataContact(ByVal pName As String, ByVal pAutoAdd As Boolean) As String

        Dim lstrName As String
        LoadDataContact = ""
        Try
            If pName = "" Then
                lstrName = ""
            Else
                lstrName = LoadDataTableContact(0, pName, pAutoAdd)
            End If

            If lstrName <> "" Then
                Return lstrName
            Else
                Dim lfrmFind As New frmFindEmployee
                lfrmFind.LookFor = pName
                lfrmFind.Execute()
                If lfrmFind.IsAccept Then
                    If lfrmFind.GetDataKey.Count > 0 Then
                        For i = 1 To lfrmFind.GetDataKey.Count
                            If ConvertNullToZero(lfrmFind.GetDataKey(i)) > 0 Then
                                LoadDataTableContact(ConvertNullToZero(lfrmFind.GetDataKey(i)), "", pAutoAdd)

                            End If
                        Next
                        lfrmFind = Nothing
                    End If
                End If
                 
            End If
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucContactRole.LoadDataContact : " & e.Message)
        Finally

        End Try
    End Function

    Private Function LoadDataTableContact(ByVal pllngID As Long, ByVal pUnitCode As String, ByVal pAutoAdd As Boolean) As String
        Dim lcls As New EmployeeDAO
        Dim lblnIsInitial As Boolean
        LoadDataTableContact = ""
        Try

            If pUnitCode <> "" Then
                lblnIsInitial = lcls.InitailData(0, pUnitCode)
            Else
                lblnIsInitial = lcls.InitailData(pllngID, "")
            End If

            If lblnIsInitial Then

                If pAutoAdd Then
                    Dim newRow As DataRow = (TryCast(gridControl.DataSource, DataTable)).NewRow()
                    newRow("EmpID") = lcls.ID
                    newRow("EmpName") = ConvertNullToString(lcls.CustomerName)
                    newRow("EmpCode") = ConvertNullToString(lcls.EmpCode)
                    If IsNothing(lcls.PositionDAO) = False Then
                        newRow("PositionName") = ConvertNullToString(lcls.PositionDAO.NameThai)
                    End If
                    If IsNothing(lcls.AddressS) = False Then
                        newRow("Email1") = ConvertNullToString(lcls.AddressS.Email1)
                        newRow("Phone1") = ConvertNullToString(lcls.AddressS.Phone1)
                    End If
                 
                    TryCast(gridControl.DataSource, DataTable).Rows.Add(newRow)
                    gridControl.RefreshDataSource()
                Else
                    gridView.SetFocusedRowCellValue("EmpID", lcls.ID)
                    gridView.SetFocusedRowCellValue("EmpName", ConvertNullToString(lcls.Title & lcls.FirstName & " " & lcls.LastName))
                    gridView.SetFocusedRowCellValue("EmpCode", ConvertNullToString(lcls.EmpCode))
                    If IsNothing(lcls.PositionDAO) = False Then
                        gridView.SetFocusedRowCellValue("PositionName", ConvertNullToString(lcls.PositionDAO.NameThai))
                    End If
                    If IsNothing(lcls.AddressS) = False Then
                        gridView.SetFocusedRowCellValue("Email1", ConvertNullToString(lcls.AddressS.Email1))
                        gridView.SetFocusedRowCellValue("Phone1", ConvertNullToString(lcls.AddressS.Phone1))
                    End If
                  
                End If

                Return ConvertNullToString(lcls.CustomerName)

            Else
                Return ""
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucContactRole.LoadDataTableContact : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Function
  

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        LoadDataContact("", True)
    End Sub
End Class
