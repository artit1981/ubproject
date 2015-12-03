Option Explicit On

Imports DevExpress.XtraEditors

Partial Public Class iReport
  
    Private mCaption As String
   

#Region "Property"

    Public WriteOnly Property Caption() As String
        Set(ByVal Value As String)
            mCaption = Value
        End Set
    End Property


#End Region

#Region "call child"
    Protected Overridable Sub ClearAllForm()
        Try
            Me.Text = mCaption
        Catch e As Exception
            Err.Raise(Err.Number, e.Source, "iReport.ClearAllForm : " & e.Message)
        End Try
    End Sub
 
    Protected Overridable Sub Print()
    End Sub
#End Region


    'Private Sub FormChangedComponent1_FormControlChanged(ByVal sender As Object, ByVal e As FormChangedEventArgs)
    '    CheckFormChanged()
    'End Sub

    Private Sub iEditForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub iEditForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
       
    End Sub

    Private Sub iReport_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub iEditForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            ClearAllForm()
        Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally

        End Try

    End Sub

    Private Sub ExitBar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ExitBar.ItemClick
        Me.Close()
    End Sub


    Private Sub PrintBar2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles PrintBar2.ItemClick
        Try
            ShowProgress(True, "Loading...")
            Me.Print()
         Catch ex As Exception
            ShowErrorMsg(False, ex.Message)
        Finally
            ShowProgress(False, "")
        End Try
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class