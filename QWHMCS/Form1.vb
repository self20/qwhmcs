Public Class Form1
    Dim AcikTicketSayisi As Long
    Dim KapaliTicketSayisi As Long
    Dim CevaplananTicketSayisi As Long
    Dim CevapBekleyenTicketSayisi As Long
    Dim tAcikTicketSayisi As Long
    Dim tKapaliTicketSayisi As Long
    Dim tCevaplananTicketSayisi As Long
    Dim tCevapBekleyenTicketSayisi As Long
    Dim WHMCSAddress As String
    Dim Zaman As Long = 30
    Dim Gorunuyormu As Boolean = True

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ni1.Visible = False
        ni1.Dispose()
    End Sub
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim objIniFile As IniFile
        Dim aPath As String
        aPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location)
        objIniFile = New IniFile(aPath & "\settings.ini")
        WHMCSAddress = objIniFile.GetString("WHMCS", "Address", "")
        ConStrSirket = String.Format("DRIVER={{MySQL ODBC 3.51 Driver}};SERVER={0};UID={1};PWD={2};DATABASE={3};OPTION=16427", objIniFile.GetString("Server", "Hostname", ""), objIniFile.GetString("Server", "Username", ""), objIniFile.GetString("Server", "Password", ""), objIniFile.GetString("Server", "Database", ""))
        BaglantiSirket = New Odbc.OdbcConnection
        BaglantiSirket.ConnectionString = ConStrSirket
        If objIniFile.GetString("Settings", "AboutBox", "true") = "true" Then
            Dim frmabout As New AboutBox1
            frmabout.ShowDialog()
        End If
        LOpenTicket = objIniFile.GetString("Language", "LOpenTicket", "Open Ticket")
        LClosedTicket = objIniFile.GetString("Language", "LClosedTicket", "Closed Ticket")
        LAnswered = objIniFile.GetString("Language", "LAnswered", "Answered Ticket")
        LCusAnswered = objIniFile.GetString("Language", "LCusAnswered", "Customer-Answered")
        LcmdOpen = objIniFile.GetString("Language", "LcmdOpen", "Open Ticket")
        LcmdClose = objIniFile.GetString("Language", "LcmdClose", "Close")
        LcmdHide = objIniFile.GetString("Language", "LcmdHide", "Hide")
        LcmdRefresh = objIniFile.GetString("Language", "LcmdRefresh", "Refresh")
        LColDate = objIniFile.GetString("Language", "LColDate", "Date")
        LColDepartment = objIniFile.GetString("Language", "LColDepartment", "Department")
        LColName = objIniFile.GetString("Language", "LColName", "Name")
        LColSubName = objIniFile.GetString("Language", "LColSubName", "Subname")
        LColTitle = objIniFile.GetString("Language", "LColTitle", "Title")
        LColStatus = objIniFile.GetString("Language", "LColStatus", "Status")
        LColUrgency = objIniFile.GetString("Language", "LColUrgency", "Urgency")
        LBaloonCaption = objIniFile.GetString("Language", "LBaloonCaption", "New Ticket/Answer")
        LBaloonNewTicket = objIniFile.GetString("Language", "LBaloonNewTicket", "A new support ticket has been opened.")
        LBaloonNewAnswer = objIniFile.GetString("Language", "LBaloonNewAnswer", "A new support ticket response has been made.")
        LErrorDatabase = objIniFile.GetString("Language", "LBaloonNewAnswer", "Database Connection Problem !")
        RefreshRate = objIniFile.GetString("Settings", "RefreshRate", 30)
        Transparency = objIniFile.GetString("Settings", "Transparency", 90)
        cmdAc.Text = LcmdOpen
        cmdKapat.Text = LcmdClose
        cmdRefresh.Text = LcmdRefresh
        cmdHide.Text = LcmdHide
        coldate.Caption = LColDate
        cold_name.Caption = LColDepartment
        colu_name.Caption = LColName
        colu_subname.Caption = LColSubName
        coltitle.Caption = LColTitle
        colstatus.Caption = LColStatus
        colurgency.Caption = LColUrgency
        RadioGroup1.Properties.Items(0).Description = LOpenTicket
        RadioGroup1.Properties.Items(1).Description = LCusAnswered
        RadioGroup1.Properties.Items(2).Description = LAnswered
        RadioGroup1.Properties.Items(3).Description = LClosedTicket
        Me.Opacity = Transparency / 100
        Zaman = RefreshRate
        Doldur(True)
    End Sub
    Public Function Doldur(Optional ByVal Ilk As Boolean = False) As Boolean
        Try
            Dim aPath As String
            aPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location)
            Dim Wherestr As String
            Wherestr = String.Format(" WHERE tbltickets.`status` LIKE '{0}' ", RadioGroup1.EditValue)
            Dim kayitset As New DataTable
            kayitset = SorguMySQL(SorguSekli.Tablo, BaglantiSirket, "SELECT " & _
    "tbltickets.id, " & _
    "tbltickets.tid, " & _
    "tbltickets.did, " & _
    "tbltickets.userid, " & _
    "tbltickets.name, " & _
    "tbltickets.email, " & _
    "tbltickets.c, " & _
    "tbltickets.`date`, " & _
    "tbltickets.title, " & _
    "tbltickets.message, " & _
    "tbltickets.`status`, " & _
    "tbltickets.urgency, " & _
    "tbltickets.admin, " & _
    "tbltickets.attachment, " & _
    "tbltickets.lastreply, " & _
    "tbltickets.flag, " & _
    "tbltickets.clientunread, " & _
    "tbltickets.adminunread, " & _
    "tbltickets.replyingadmin, " & _
    "tbltickets.replyingtime, " & _
    "tbltickets.service, " & _
    "tblticketdepartments.name AS d_name, " & _
    "tblclients.firstname AS u_name, " & _
    "tblclients.lastname AS u_subname " & _
    "        FROM " & _
    "        tbltickets " & _
    "Inner Join tblticketdepartments ON tblticketdepartments.id = tbltickets.did " & _
    "Inner Join tblclients ON tblclients.id = tbltickets.userid " & Wherestr & _
    "ORDER BY DATE DESC,ID DESC")
            Ds1.tbltickets.Clear()
            Ds1.tbltickets.Merge(kayitset)
            If GridView1.DataRowCount <> 0 Then
                cmdAc.Enabled = True
            Else
                cmdAc.Enabled = False
            End If
            If Ilk = True Then
                AcikTicketSayisi = SorguMySQL(SorguSekli.Tek, BaglantiSirket, "Select COUNT(ID) FROM tblticketlog WHERE action = 'New Support Ticket Opened'")
                CevapBekleyenTicketSayisi = SorguMySQL(SorguSekli.Tek, BaglantiSirket, "Select COUNT(ID) FROM tblticketlog WHERE action = 'New Ticket Response made by User'")
            Else
                tAcikTicketSayisi = SorguMySQL(SorguSekli.Tek, BaglantiSirket, "Select COUNT(ID) FROM tblticketlog WHERE action = 'New Support Ticket Opened'")
                tCevapBekleyenTicketSayisi = SorguMySQL(SorguSekli.Tek, BaglantiSirket, "Select COUNT(ID) FROM tblticketlog WHERE action = 'New Ticket Response made by User'")
                If tAcikTicketSayisi > AcikTicketSayisi Then
                    My.Computer.Audio.Play(aPath & "\alarm.wav", AudioPlayMode.BackgroundLoop)
                    ni1.ShowBalloonTip(0, LBaloonCaption, LBaloonNewTicket, ToolTipIcon.Info)
                    AcikTicketSayisi = tAcikTicketSayisi
                End If
                If tCevapBekleyenTicketSayisi > CevapBekleyenTicketSayisi Then
                    My.Computer.Audio.Play(aPath & "\alarm.wav", AudioPlayMode.BackgroundLoop)
                    ni1.ShowBalloonTip(0, LBaloonCaption, LBaloonNewAnswer, ToolTipIcon.Info)
                    CevapBekleyenTicketSayisi = tCevapBekleyenTicketSayisi
                End If
            End If
        Catch ex As Exception
            MsgBox(LErrorDatabase, MsgBoxStyle.Critical)
            Exit Function
        End Try
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Timer2.Stop()
        Zaman = RefreshRate
        Doldur(False)
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Zaman = Zaman - 1
        Me.Text = "QWHMCS - WHMCS Ticket Track System - " & Zaman
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        Doldur(False)
    End Sub

    Private Sub ni1_BalloonTipClicked(ByVal sender As Object, ByVal e As System.EventArgs) Handles ni1.BalloonTipClicked
        Me.Show()
        My.Computer.Audio.Stop()
    End Sub

    Private Sub ni1_BalloonTipClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles ni1.BalloonTipClosed
        My.Computer.Audio.Stop()
    End Sub

    Private Sub ni1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ni1.DoubleClick
        If Gorunuyormu = True Then
            Me.Hide()
            Gorunuyormu = False
        Else
            Me.Show()
            Gorunuyormu = True
        End If
    End Sub

    Private Sub cmdKapat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdKapat.Click
        Me.Close()
    End Sub

    Private Sub RadioGroup1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioGroup1.SelectedIndexChanged
        Doldur(False)
    End Sub

    Private Sub cmdAc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAc.Click
        Dim DRow As DataRow
        DRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Process.Start(WHMCSAddress & "/supporttickets.php?action=viewticket&id=" & DRow("id"))
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHide.Click
        Me.Hide()
        Gorunuyormu = False
    End Sub
End Class
