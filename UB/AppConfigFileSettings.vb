Public Class AppConfigFileSettings
    ''' <summary>
    ''' UpdateAppSettings: It will update the app.Config file AppConfig key values
    ''' </summary>
    ''' <param name="KeyName">AppConfigs KeyName</param>
    ''' <param name="KeyValue">AppConfigs KeyValue</param>
    ''' <remarks></remarks>
    Public Shared Sub UpdateAppSettings(ByVal KeyName As String, ByVal KeyValue As String)

        Select Case KeyName
            Case "DBServerName" : My.Settings.DBServerName = KeyValue
            Case "DatabaseName" : My.Settings.DatabaseName = KeyValue
            Case "DatabaseUserID" : My.Settings.DatabaseUserID = KeyValue
            Case "DatabasePwd" : My.Settings.DatabasePwd = KeyValue
            Case "LastLogin" : My.Settings.LastLogin = KeyValue
            Case "SkinName" : My.Settings.SkinName = KeyValue
            Case "OpenTab" : My.Settings.OpenTab = KeyValue
        End Select
        My.Settings.Save()
        'Dim XmlDoc As New XmlDocument()
        'XmlDoc.Load(Application.StartupPath & "\Config.config")
        'For Each xElement As XmlElement In XmlDoc.DocumentElement
        '    If xElement.Name = "appSettings" Then
        '        For Each xNode As XmlNode In xElement.ChildNodes
        '            If xNode.Attributes(0).Value = KeyName Then
        '                xNode.Attributes(1).Value = KeyValue.Trim
        '            End If
        '        Next
        '    End If
        'Next

        'XmlDoc.Save(Application.StartupPath & "\Config.config")
    End Sub

    Public Shared Sub LoadAppSettings()
        gDBServerName = My.Settings.DBServerName
        gDatabaseName = My.Settings.DatabaseName
        gDBUser = My.Settings.DatabaseUserID
        gDBPass = My.Settings.DatabasePwd
        gLastLogin = My.Settings.LastLogin
        gSkinName = My.Settings.SkinName
        gOpenTab = My.Settings.OpenTab

        'Dim XmlDoc As New XmlDocument()
        'XmlDoc.Load(Application.StartupPath & "\Config.config")
        'For Each xElement As XmlElement In XmlDoc.DocumentElement
        '    If xElement.Name = "appSettings" Then
        '        For Each xNode As XmlNode In xElement.ChildNodes
        '            Select Case xNode.Attributes(0).Value
        '                Case "DBServerName"
        '                    gDBServerName = xNode.Attributes(1).Value
        '                Case "DatabaseName"
        '                    gDatabaseName = xNode.Attributes(1).Value
        '                Case "DatabaseUserID"
        '                    gDBUser = xNode.Attributes(1).Value
        '                Case "DatabasePwd"
        '                    gDBPass = xNode.Attributes(1).Value
        '                Case "LastLogin"
        '                    gLastLogin = xNode.Attributes(1).Value
        '                Case "SkinName"
        '                    gSkinName = xNode.Attributes(1).Value
        '                Case "OpenTab"
        '                    gOpenTab = xNode.Attributes(1).Value
        '            End Select

        '        Next
        '    End If
        'Next
        gConString = "server=" & gDBServerName & ";database=" & gDatabaseName & ";uid=" & gDBUser & ";pwd=" & gDBPass & ";application name=BS stress utility"
    End Sub
End Class
