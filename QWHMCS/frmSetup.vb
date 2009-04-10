Public Class frmSetup
    Public objIniFile As IniFile
    Public aPath As String
    Public qClose As Boolean
    Private Sub frmSetup_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If qClose = True Then
            End
        End If
    End Sub
    Private Sub frmSetup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        aPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location)
        objIniFile = New IniFile(aPath & "\settings.ini")
        If objIniFile.GetString("Settings", "Setup", "0") = "0" Then
            qClose = True
        Else
            qClose = False
        End If
        If SetupDurumu = True Then
            objIniFile = New IniFile(aPath & "\settings.ini")
            txtOpenTicket.EditValue = objIniFile.GetString("Language", "LOpenTicket", "Open Tickets")
            txtClosedTicket.EditValue = objIniFile.GetString("Language", "LClosedTicket", "Closed Tickets")
            txtAnswered.EditValue = objIniFile.GetString("Language", "LAnswered", "Answered Tickets")
            txtCusAnswered.EditValue = objIniFile.GetString("Language", "LCusAnswered", "Customer Replied")
            txtcmdOpen.EditValue = objIniFile.GetString("Language", "LcmdOpen", "Open Ticket")
            txtcmdClose.EditValue = objIniFile.GetString("Language", "LcmdClose", "Close")
            txtcmdHide.EditValue = objIniFile.GetString("Language", "LcmdHide", "Hide")
            txtcmdRefresh.EditValue = objIniFile.GetString("Language", "LcmdRefresh", "Refresh")
            txtcmdSettings.EditValue = objIniFile.GetString("Language", "LcmdSettings", "Settings")
            txtcolDate.EditValue = objIniFile.GetString("Language", "LColDate", "Date")
            txtcolDepartment.EditValue = objIniFile.GetString("Language", "LColDepartment", "Department")
            txtcolName.EditValue = objIniFile.GetString("Language", "LColName", "Name")
            txtcolSubName.EditValue = objIniFile.GetString("Language", "LColSubName", "Surname")
            txtcolTitle.EditValue = objIniFile.GetString("Language", "LColTitle", "Title")
            txtcolStatus.EditValue = objIniFile.GetString("Language", "LColStatus", "Status")
            txtcolUrgency.EditValue = objIniFile.GetString("Language", "LColUrgency", "Urgency")
            txtBaloonCaption.EditValue = objIniFile.GetString("Language", "LBaloonCaption", "New Ticket/Answer")
            txtBaloonNewTicket.EditValue = objIniFile.GetString("Language", "LBaloonNewTicket", "A new support ticket has been opened.")
            txtBaloonNewAnswer.EditValue = objIniFile.GetString("Language", "LBaloonNewAnswer", "A new support ticket response has been made.")
            txtErrorDatabase.EditValue = objIniFile.GetString("Language", "LErrorDatabase", "Database Connection Problem !")
            txtRefreshRate.EditValue = objIniFile.GetString("Settings", "RefreshRate", 30)
            txtTransparent.Value = objIniFile.GetString("Settings", "Transparency", 90)
            ComboBoxEdit1.Text = objIniFile.GetString("Settings", "Skin", "Blue")
            txtWHMCSAddress.EditValue = objIniFile.GetString("WHMCS", "Address", "")
            txtAPIAddress.EditValue = objIniFile.GetString("WHMCS", "APIAddress", "")
            txtAPIUsername.EditValue = objIniFile.GetString("WHMCS", "APIUsername", "")
            txtAPIPassword.EditValue = objIniFile.GetString("WHMCS", "APIPassword", "")
        Else
            objIniFile = New IniFile(aPath & "\settings.ini")
            txtOpenTicket.EditValue = "Open Tickets"
            txtClosedTicket.EditValue = "Closed Tickets"
            txtAnswered.EditValue = "Answered Tickets"
            txtCusAnswered.EditValue = "Customer Replied"
            txtcmdOpen.EditValue = "Open Ticket"
            txtcmdClose.EditValue = "Close"
            txtcmdHide.EditValue = "Hide"
            txtcmdRefresh.EditValue = "Refresh"
            txtcmdSettings.EditValue = "Settings"
            txtcolDate.EditValue = "Date"
            txtcolDepartment.EditValue = "Department"
            txtcolName.EditValue = "Name"
            txtcolSubName.EditValue = "Surname"
            txtcolTitle.EditValue = "Title"
            txtcolStatus.EditValue = "Status"
            txtcolUrgency.EditValue = "Urgency"
            txtBaloonCaption.EditValue = "New Ticket/Answer"
            txtBaloonNewTicket.EditValue = "A new support ticket has been opened."
            txtBaloonNewAnswer.EditValue = "A new support ticket response has been made."
            txtErrorDatabase.EditValue = "QWHMCS API Connection Error !"
            txtRefreshRate.EditValue = 30
            txtTransparent.Value = 90
            ComboBoxEdit1.Text = "Blue"
            txtWHMCSAddress.EditValue = "http://www.example.com/whmcs/admin"
            txtAPIAddress.EditValue = "http://www.example.com/whmcs/includes"
            txtAPIUsername.EditValue = Nothing
            txtAPIPassword.EditValue = Nothing
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
        If Len(txtWHMCSAddress.EditValue) = 0 Or Len(txtAPIAddress.EditValue) = 0 Or Len(txtAPIUsername.EditValue) = 0 Or Len(txtAPIPassword.EditValue) = 0 Then
            MsgBox("WHMCS Address or API Address is Empty. Please enter and try again.", MsgBoxStyle.Critical, "QWHMCS")
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
        objIniFile.WriteString("Language", "LErrorDatabase", txtErrorDatabase.EditValue)
        objIniFile.WriteString("Settings", "RefreshRate", txtRefreshRate.EditValue)
        objIniFile.WriteString("Settings", "Transparency", txtTransparent.Value)
        objIniFile.WriteString("Settings", "Skin", ComboBoxEdit1.Text)
        objIniFile.WriteString("WHMCS", "Address", txtWHMCSAddress.EditValue)
        objIniFile.WriteString("WHMCS", "APIAddress", txtAPIAddress.EditValue)
        objIniFile.WriteString("WHMCS", "APIUsername", txtAPIUsername.EditValue)
        objIniFile.WriteString("WHMCS", "APIPassword", txtAPIPassword.EditValue)
        objIniFile.WriteString("Settings", "Setup", "1")
        If Len(LColDepartment) <> 0 Then
            MsgBox("Settings are applied to the program must be restarted.", MsgBoxStyle.Information, "QWHMCS")
        End If
        qClose = False
        Me.Close()
    End Sub

    Private Sub ComboBoxEdit1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEdit1.SelectedIndexChanged
        frmMain.DefaultLookAndFeel1.LookAndFeel.SkinName = ComboBoxEdit1.Text
    End Sub
End Class