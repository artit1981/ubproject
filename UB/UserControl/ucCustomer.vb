Option Explicit On
Public Class ucCustomer
    Dim mIsError As Boolean
    Private mRefID As Long = 0
    Private mRefTableID As Long = 0

    Public ReadOnly Property IsError() As Boolean
        Get
            Return mIsError
        End Get
    End Property

    Private mDataDAOs As List(Of CustomerListDAO)

    Public Function GetDAOs() As List(Of CustomerListDAO)
        Dim lRow As Long
        Dim lDataDAO As CustomerListDAO
        Dim lCusID As Long = 0
        Try
            mDataDAOs = New List(Of CustomerListDAO)
            mIsError = False
            If gridView.RowCount > 0 Then
                For lRow = 0 To gridView.RowCount
                    lCusID = ConvertNullToZero(gridView.GetRowCellValue(lRow, "CustomerID"))
                    If lCusID > 0 Then
                        lDataDAO = New CustomerListDAO
                        lDataDAO.CustomerID = lCusID
                        mDataDAOs.Add(lDataDAO)
                    End If

                Next
            End If

        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucCustomer.GetNoteDAOs : " & e.Message)
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
            Err.Raise(Err.Number, e.Source, "ucCustomer.ShowControl : " & e.Message)
            Return False
        End Try
    End Function

    Public Sub ClearControl()
        Try

            gridControl.DataSource = Nothing
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucCustomer.ClearAll : " & e.Message)
        End Try
    End Sub


    Private Sub LoadData(ByVal pIsDelete As Integer)
        Dim lcls As New CustomerListDAO
        Dim dataTable As New DataTable()

        Try
            dataTable = lcls.GetDataTable(mRefID, mRefTableID, pIsDelete)
            gridControl.DataSource = dataTable
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "ucCustomer.LoadData : " & e.Message)
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
                Dim lfrmFind As New frmFindCustomer
                lfrmFind.LookFor = pName
                If mRefTableID = MasterType.Campaign Then
                    lfrmFind.CusMasterType = MasterType.Contacts
                Else
                    lfrmFind.CusMasterType = MasterType.Agency
                End If
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
            Err.Raise(Err.Number, e.Source, "ucCustomer.LoadDataContact : " & e.Message)
        Finally

        End Try
    End Function

    Private Function LoadDataTableContact(ByVal pllngID As Long, ByVal pUnitCode As String, ByVal pAutoAdd As Boolean) As String
        Dim lcls As New CustomerDAO
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
                    newRow("CustomerID") = lcls.ID
                    newRow("CusName") = ConvertNullToString(lcls.CustomerName)
                    newRow("CustomerCode") = ConvertNullToString(lcls.Code)
                    newRow("CustomerType") = ConvertNullToString(lcls.CustomerType)

                    If IsNothing(lcls.AddressS) = False Then
                        newRow("Email1") = ConvertNullToString(lcls.AddressS.Email1)
                        newRow("Phone1") = ConvertNullToString(lcls.AddressS.Phone1)
                    End If

                    TryCast(gridControl.DataSource, DataTable).Rows.Add(newRow)

                    Dim lRelateCusID As Long = 0
                    If lcls.CompanyRelateID > 0 Then
                        lRelateCusID = lcls.CompanyRelateID
                    ElseIf lcls.CompanyParentID > 0 Then
                        lRelateCusID = lcls.CompanyParentID
                    End If
                    If lRelateCusID > 0 Then
                        If lcls.InitailData(lRelateCusID, "") Then
                            newRow = (TryCast(gridControl.DataSource, DataTable)).NewRow()
                            newRow("CustomerID") = lcls.ID
                            newRow("CusName") = ConvertNullToString(lcls.CustomerName)
                            newRow("CustomerCode") = ConvertNullToString(lcls.Code)
                            newRow("CustomerType") = ConvertNullToString(lcls.CustomerType)

                            If IsNothing(lcls.AddressS) = False Then
                                newRow("Email1") = ConvertNullToString(lcls.AddressS.Email1)
                                newRow("Phone1") = ConvertNullToString(lcls.AddressS.Phone1)
                            End If

                            TryCast(gridControl.DataSource, DataTable).Rows.Add(newRow)
                        End If
                    End If

                        gridControl.RefreshDataSource()
                Else
                    gridView.SetFocusedRowCellValue("CustomerID", lcls.ID)
                    gridView.SetFocusedRowCellValue("CusName", ConvertNullToString(lcls.CustomerName))
                    gridView.SetFocusedRowCellValue("CustomerCode", ConvertNullToString(lcls.Code))
                    gridView.SetFocusedRowCellValue("CustomerType", ConvertNullToString(lcls.CustomerType))
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
            Err.Raise(Err.Number, e.Source, "ucCustomer.LoadDataTableContact : " & e.Message)
        Finally
            lcls = Nothing
        End Try
    End Function


    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        LoadDataContact("", True)
    End Sub
End Class
