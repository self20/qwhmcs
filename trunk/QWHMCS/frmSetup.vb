Public Class frmSetup
    Public objIniFile As IniFile
    Public aPath As String
    Private Sub frmSetup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        aPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location)
        If SetupDurumu = True Then
            objIniFile = New IniFile(aPath & "\settings.ini")
            txtOpenTicket.EditValue = objIniFile.GetString("Language", "LOpenTicket", "Open Ticket")
            txtClosedTicket.EditValue = objIniFile.GetString("Language", "LClosedTicket", "Closed Ticket")
            txtAnswered.EditValue = objIniFile.GetString("Language", "LAnswered", "Answered Ticket")
            txtCusAnswered.EditValue = objIniFile.GetString("Language", "LCusAnswered", "Customer-Answered")
            txtcmdOpen.EditValue = objIniFile.GetString("Language", "LcmdOpen", "Open Ticket")
            txtcmdClose.EditValue = objIniFile.GetString("Language", "LcmdClose", "Close")
            txtcmdHide.EditValue = objIniFile.GetString("Language", "LcmdHide", "Hide")
            txtcmdRefresh.EditValue = objIniFile.GetString("Language", "LcmdRefresh", "Refresh")
            txtcmdSettings.EditValue = objIniFile.GetString("Language", "LcmdSettings", "Settings")
            txtcolDate.EditValue = objIniFile.GetString("Language", "LColDate", "Date")
            txtcolDepartment.EditValue = objIniFile.GetString("Language", "LColDepartment", "Department")
            txtcolName.EditValue = objIniFile.GetString("Language", "LColName", "Name")
            txtcolSubName.EditValue = objIniFile.GetString("Language", "LColSubName", "Subname")
            txtcolTitle.EditValue = objIniFile.GetString("Language", "LColTitle", "Title")
            txtcolStatus.EditValue = objIniFile.GetString("Language", "LColStatus", "Status")
            txtcolUrgency.EditValue = objIniFile.GetString("Language", "LColUrgency", "Urgency")
            txtBaloonCaption.EditValue = objIniFile.GetString("Language", "LBaloonCaption", "New Ticket/Answer")
            txtBaloonNewTicket.EditValue = objIniFile.GetString("Language", "LBaloonNewTicket", "A new support ticket has been opened.")
            txtBaloonNewAnswer.EditValue = objIniFile.GetString("Language", "LBaloonNewAnswer", "A new support ticket response has been made.")
            txtErrorDatabase.EditValue = objIniFile.GetString("Language", "LBaloonNewAnswer", "Database Connection Problem !")
            txtRefreshRate.EditValue = objIniFile.GetString("Settings", "RefreshRate", 30)
            txtTransparent.Value = objIniFile.GetString("Settings", "Transparency", 90)
            txtWHMCSAddress.EditValue = objIniFile.GetString("WHMCS", "Address", "")
            txtHostname.EditValue = objIniFile.GetString("Server", "Hostname", "")
            txtUsername.EditValue = objIniFile.GetString("Server", "Username", "")
            txtPassword.EditValue = objIniFile.GetString("Server", "Password", "")
            txtDatabase.EditValue = objIniFile.GetString("Server", "Database", "")
            If objIniFile.GetString("Settings", "AboutBox", "True") = True Then
                radioAbout.EditValue = True
            Else
                radioAbout.EditValue = False
            End If
        Else
            objIniFile = New IniFile(aPath & "\settings.ini")
            txtOpenTicket.EditValue = "Open Ticket"
            txtClosedTicket.EditValue = "Closed Ticket"
            txtAnswered.EditValue = "Answered Ticket"
            txtCusAnswered.EditValue = "Customer-Answered"
            txtcmdOpen.EditValue = "Open Ticket"
            txtcmdClose.EditValue = "Close"
            txtcmdHide.EditValue = "Hide"
            txtcmdRefresh.EditValue = "Refresh"
            txtcmdSettings.EditValue = "Settings"
            txtcolDate.EditValue = "Date"
            txtcolDepartment.EditValue = "Department"
            txtcolName.EditValue = "Name"
            txtcolSubName.EditValue = "Subname"
            txtcolTitle.EditValue = "Title"
            txtcolStatus.EditValue = "Status"
            txtcolUrgency.EditValue = "Urgency"
            txtBaloonCaption.EditValue = "New Ticket/Answer"
            txtBaloonNewTicket.EditValue = "A new support ticket has been opened."
            txtBaloonNewAnswer.EditValue = "A new support ticket response has been made."
            txtErrorDatabase.EditValue = "Database Connection Problem !"
            txtRefreshRate.EditValue = 30
            txtTransparent.Value = 90
            txtWHMCSAddress.EditValue = ""
            txtHostname.EditValue = ""
            txtUsername.EditValue = ""
            txtPassword.EditValue = ""
            txtDatabase.EditValue = ""
            radioAbout.EditValue = True
        End If
    End Sub

    Private Sub txtTransparent_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTransparent.EditValueChanged
        Me.Opacity = txtTransparent.Value / 100
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        If SetupDurumu = False Then
            End
        Else
            Me.Close()
        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If Len(txtHostname.EditValue) = 0 Or Len(txtDatabase.EditValue) = 0 Or Len(txtWHMCSAddress.EditValue) = 0 Or Len(txtUsername.EditValue) = 0 Or Len(txtPassword.EditValue) = 0 Then
            MsgBox("Database Settings or WHMCS Address is Empty. Please enter and try again.", MsgBoxStyle.Critical, "QWHMCS")
            Exit Sub
        End If
        objIniFile.WriteString("Language", "LOpenTicket", txtOpenTicket.EditValue)
        objIniFile.WriteString("Language", "LClosedTicket", txtClosedTicket.EditValue)
        objIniFile.WriteString("Language", "LAnswered", txtAnswered.EditValue)
        objIniFile.WriteString("Language", "LCusAnswered", txtCusAnswered.EditValue)
        objIniFile.WriteString("Language", "LcmdOpen", txtcmdOpen.EditValue)
        objIniFile.WriteString("Language", "LcmdClose", txtcmdClose.EditValue)
        objIniFile.WriteString("Language", "LcmdHide", txtcmdHide.EditValue)
        objIniFile.WriteString("Language", "LcmdRefresh", txtcmdRefresh.EditValue)
        objIniFile.WriteString("Language", "LcmdSettings", txtcmdSettings.EditValue)
        objIniFile.WriteString("Language", "LColDate", txtcolDate.EditValue)
        objIniFile.WriteString("Language", "LColDepartment", txtcolDepartment.EditValue)
        objIniFile.WriteString("Language", "LColName", txtcolName.EditValue)
        objIniFile.WriteString("Language", "LColSubName", txtcolSubName.EditValue)
        objIniFile.WriteString("Language", "LColTitle", txtcolTitle.EditValue)
        objIniFile.WriteString("Language", "LColStatus", txtcolStatus.EditValue)
        objIniFile.WriteString("Language", "LColUrgency", txtcolUrgency.EditValue)
        objIniFile.WriteString("Language", "LBaloonCaption", txtBaloonCaption.EditValue)
        objIniFile.WriteString("Language", "LBaloonNewTicket", txtBaloonNewTicket.EditValue)
        objIniFile.WriteString("Language", "LBaloonNewAnswer", txtBaloonNewAnswer.EditValue)
        objIniFile.WriteString("Language", "LBaloonNewAnswer", txtErrorDatabase.EditValue)
        objIniFile.WriteString("Settings", "RefreshRate", txtRefreshRate.EditValue)
        objIniFile.WriteString("Settings", "Transparency", txtTransparent.Value)
        objIniFile.WriteString("WHMCS", "Address", txtWHMCSAddress.EditValue)
        objIniFile.WriteString("Server", "Hostname", txtHostname.EditValue)
        objIniFile.WriteString("Server", "Username", txtUsername.EditValue)
        objIniFile.WriteString("Server", "Password", txtPassword.EditValue)
        objIniFile.WriteString("Server", "Database", txtDatabase.EditValue)
        If radioAbout.EditValue = True Then
            objIniFile.WriteString("Settings", "AboutBox", "True")
        Else
            objIniFile.WriteString("Settings", "AboutBox", "False")
        End If
        objIniFile.WriteString("Settings", "Setup", "1")
        If Len(LColDepartment) <> 0 Then
            MsgBox("Settings are applied to the program must be restarted.", MsgBoxStyle.Information, "QWHMCS")
        End If
        Me.Close()
    End Sub
End Class