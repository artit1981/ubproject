Option Explicit On

Imports DevExpress.XtraEditors
Imports DevExpress.LookAndFeel
Imports System.Configuration


Friend Class Program
    Private Sub New()
    End Sub
    <STAThread()> _
    Shared Sub Main()

        gUserID = 1
        gPrivilegeID = 1
        gUserName = "artit"
        Try
            Application.SetCompatibleTextRenderingDefault(False)
            frmSplash.Show()
            Application.DoEvents()
            AppConfigFileSettings.LoadAppSettings()

            gConnection = New DBConnection
            InitSkins()
            Application.EnableVisualStyles()

            Application.Run(New frmLogin())
 
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End
        Finally
        End Try

    End Sub

    Shared Sub InitSkins()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        'DevExpress.UserSkins.OfficeSkins.Register()
        UserLookAndFeel.Default.SetSkinStyle(gSkinName)

    End Sub

End Class


