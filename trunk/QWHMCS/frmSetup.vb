Public Class frmSetup
    Public objIniFile As IniFile
    Public aPath As String
    Public qClose As Boolean
    Dim DS As New DataSet
    Private Sub frmSetup_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If qClose = True Then
            End
        End If
    End Sub
    Private Sub frmSetup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Language Setting
        Me.Text = LName(1)
        tabGeneral.Text = LName(2)
        tabLanguage.Text = LName(3)
        cmdSave.Text = LName(4)
        cmdClose.Text = LName(5)
        lblWAdminAdd.Text = LName(6)
        lblWApiAdd.Text = LName(7)
        lblApiUsername.Text = LName(8)
        lblApiPassword.Text = LName(9)
        lblRefreshRate.Text = LName(10)
        lblTranparentRate.Text = LName(11)
        lblSkin.Text = LName(12)
        lblMaxTicket.Text = LName(13)
        lblSignature.Text = LName(14)

        Dim YourSignStr As String
        aPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location)
        objIniFile = New IniFile(aPath & "\settings.ini")
        If objIniFile.GetString("Settings", "Setup", "0") = "0" Then
            qClose = True
        Else
            qClose = False
        End If
        DS.ReadXml(aPath & "\Language.xml")
        GridControl1.DataSource = DS.Tables("Language")
        If SetupDurumu = True Then
            objIniFile = New IniFile(aPath & "\settings.ini")
            txtRefreshRate.EditValue = objIniFile.GetString("Settings", "RefreshRate", 30)
            txtTransparent.Value = objIniFile.GetString("Settings", "Transparency", 90)
            ComboBoxEdit1.Text = objIniFile.GetString("Settings", "Skin", "Blue")
            txtMaxTicket.EditValue = objIniFile.GetString("Settings", "MaxTicket", 0)
            YourSignStr = objIniFile.GetString("Settings", "YourSign", "")
            If Len(YourSignStr) <> 0 Then
                txtSign.EditValue = YourSignStr.ToString.Replace("|", vbCrLf)
            End If
            txtWHMCSAddress.EditValue = objIniFile.GetString("WHMCS", "Address", "")
            txtAPIAddress.EditValue = objIniFile.GetString("WHMCS", "APIAddress", "")
            txtAPIUsername.EditValue = objIniFile.GetString("WHMCS", "APIUsername", "")
            txtAPIPassword.EditValue = objIniFile.GetString("WHMCS", "APIPassword", "")
        Else
            objIniFile = New IniFile(aPath & "\settings.ini")
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

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        If SetupDurumu = False Then
            End
        Else
            Me.Close()
        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If Len(txtWHMCSAddress.EditValue) = 0 Or Len(txtAPIAddress.EditValue) = 0 Or Len(txtAPIUsername.EditValue) = 0 Or Len(txtAPIPassword.EditValue) = 0 Then
            MsgBox("WHMCS Address or API Address is Empty. Please enter and try again.", MsgBoxStyle.Critical, "QWHMCS")
            Exit Sub
        End If
        objIniFile.WriteString("Settings", "RefreshRate", txtRefreshRate.EditValue)
        objIniFile.WriteString("Settings", "Transparency", txtTransparent.Value)
        objIniFile.WriteString("Settings", "Skin", ComboBoxEdit1.Text)
        objIniFile.WriteString("Settings", "YourSign", txtSign.EditValue.ToString.Replace(vbCrLf, "|"))
        objIniFile.WriteString("Settings", "MaxTicket", txtMaxTicket.EditValue)
        objIniFile.WriteString("WHMCS", "Address", txtWHMCSAddress.EditValue)
        objIniFile.WriteString("WHMCS", "APIAddress", txtAPIAddress.EditValue)
        objIniFile.WriteString("WHMCS", "APIUsername", txtAPIUsername.EditValue)
        objIniFile.WriteString("WHMCS", "APIPassword", txtAPIPassword.EditValue)
        objIniFile.WriteString("Settings", "Setup", "1")
        DS.WriteXml(aPath & "\Language.xml")
        MsgBox("Settings are applied to the program must be restarted.", MsgBoxStyle.Information, "QWHMCS")
        qClose = False
        Me.Close()
    End Sub

    Private Sub ComboBoxEdit1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEdit1.SelectedIndexChanged
        frmMain.DefaultLookAndFeel1.LookAndFeel.SkinName = ComboBoxEdit1.Text
    End Sub
End Class