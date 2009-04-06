Public Class frmMain
    Dim AcikTicketSayisi As Long
    Dim KapaliTicketSayisi As Long
    Dim CevaplananTicketSayisi As Long
    Dim CevapBekleyenTicketSayisi As Long
    Dim tAcikTicketSayisi As Long
    Dim tKapaliTicketSayisi As Long
    Dim tCevaplananTicketSayisi As Long
    Dim tCevapBekleyenTicketSayisi As Long
    Dim Zaman As Long = 30
    Dim Gorunuyormu As Boolean = True
    Dim frmEditor As New frmEditor
    Dim sClosing As Boolean = False
    Dim aPath As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location)
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        sClosing = True
        Try
            frmEditor.Dispose()
            frmEditor = Nothing
            ni1.Visible = False
            ni1.Dispose()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        System.Net.ServicePointManager.Expect100Continue = False
        frmEditor.Show()
        frmEditor.Hide()
        Dim objIniFile As IniFile
        If DosyaVarmıYokmu(aPath & "\settings.ini") = False Then
            SetupDurumu = False
            Dim frmSetup As New frmSetup
            frmSetup.ShowDialog()
        End If
        objIniFile = New IniFile(aPath & "\settings.ini")
        If objIniFile.GetString("Settings", "Setup", "0") = "0" Then
            SetupDurumu = True
            Dim frmSetup As New frmSetup
            frmSetup.ShowDialog()
        End If
        WHMCSAddress = objIniFile.GetString("WHMCS", "Address", "")
        APIAddress = objIniFile.GetString("WHMCS", "APIAddress", "")
        APIUsername = objIniFile.GetString("WHMCS", "APIUsername", "")
        APIPassword = objIniFile.GetString("WHMCS", "APIPassword", "")
        ConStrSirket = String.Format("DRIVER={{MySQL ODBC 3.51 Driver}};SERVER={0};UID={1};PWD={2};DATABASE={3};OPTION=16427", objIniFile.GetString("Server", "Hostname", ""), objIniFile.GetString("Server", "Username", ""), objIniFile.GetString("Server", "Password", ""), objIniFile.GetString("Server", "Database", ""))
        BaglantiSirket = New Odbc.OdbcConnection
        BaglantiSirket.ConnectionString = ConStrSirket
        If objIniFile.GetString("Settings", "AboutBox", "true") = "true" Then
            Dim frmabout As New frmAbout
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
        LcmdSettings = objIniFile.GetString("Language", "LcmdSettings", "Settings")
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
        cmdAc.Caption = LcmdOpen
        cmdKapat.Caption = LcmdClose
        cmdYenile.Caption = LcmdRefresh
        cmdYenile.Description = LcmdRefresh
        cmdGizle.Caption = LcmdHide
        cmdAyarlar.Caption = LcmdSettings
        coldate1.Caption = LColDate
        coldate2.Caption = LColDate
        coldate3.Caption = LColDate
        coldate4.Caption = LColDate
        cold_name1.Caption = LColDepartment
        cold_name2.Caption = LColDepartment
        cold_name3.Caption = LColDepartment
        cold_name4.Caption = LColDepartment
        colu_name1.Caption = LColName
        colu_name2.Caption = LColName
        colu_name3.Caption = LColName
        colu_name4.Caption = LColName
        colu_subname1.Caption = LColSubName
        colu_subname2.Caption = LColSubName
        colu_subname3.Caption = LColSubName
        colu_subname4.Caption = LColSubName
        coltitle1.Caption = LColTitle
        coltitle2.Caption = LColTitle
        coltitle3.Caption = LColTitle
        coltitle4.Caption = LColTitle
        colstatus1.Caption = LColStatus
        colstatus2.Caption = LColStatus
        colstatus3.Caption = LColStatus
        colstatus4.Caption = LColStatus
        colurgency1.Caption = LColUrgency
        colurgency2.Caption = LColUrgency
        colurgency3.Caption = LColUrgency
        colurgency4.Caption = LColUrgency
        tabOpen.Text = LOpenTicket
        tabCustomer_Reply.Text = LCusAnswered
        tabAnswered.Text = LAnswered
        tabClosed.Text = LClosedTicket
        Me.Opacity = Transparency / 100
        Zaman = RefreshRate
    End Sub
    Public Function Doldur(Optional ByVal Ilk As Boolean = False) As Boolean
        Application.DoEvents()
        lbStatus.Caption = "Connecting Database..."
        lbStatus.Glyph = My.Resources.hist_16
        Application.DoEvents()
        Try
            Dim Wherestr As String
            Wherestr = String.Format(" WHERE tbltickets.`status` LIKE '{0}' ", TabbedControlGroup1.SelectedTabPage.Name.Substring(3).Replace("_", "-"))
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
            Select Case TabbedControlGroup1.SelectedTabPage.Name
                Case "tabOpen"
                    If GridView1.DataRowCount <> 0 Then
                        cmdAc.Enabled = True
                    Else
                        cmdAc.Enabled = False
                    End If
                Case "tabCustomer_Reply"
                    If GridView3.DataRowCount <> 0 Then
                        cmdAc.Enabled = True
                    Else
                        cmdAc.Enabled = False
                    End If
                Case "tabAnswered"
                    If GridView2.DataRowCount <> 0 Then
                        cmdAc.Enabled = True
                    Else
                        cmdAc.Enabled = False
                    End If
                Case "tabClosed"
                    If GridView4.DataRowCount <> 0 Then
                        cmdAc.Enabled = True
                    Else
                        cmdAc.Enabled = False
                    End If
                Case Else
                    If GridView1.DataRowCount <> 0 Then
                        cmdAc.Enabled = True
                    Else
                        cmdAc.Enabled = False
                    End If
            End Select
            lbStatus.Caption = "Ready"
            lbStatus.Glyph = My.Resources.play_16
        Catch ex As Exception
            lbStatus.Caption = "Database Error!"
            lbStatus.Glyph = My.Resources.cancl_16
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
        lbRefreshTime.Caption = "(" & Zaman & ")"
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

    Private Sub frmMain_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Doldur(True)
        Timer1.Enabled = True
        Timer2.Enabled = True
        Shell(aPath & "\qupdate.exe /Tray /TimerIntro /TimerFinal")
        If GridView1.DataRowCount <> 0 Then
            cmdAc.Enabled = True
        Else
            cmdAc.Enabled = False
        End If
    End Sub

    Private Sub cmdAc_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdAc.ItemClick
        Timer1.Enabled = False
        Timer2.Enabled = False
        Dim DRow As DataRow
        Select Case TabbedControlGroup1.SelectedTabPage.Name
            Case "tabOpen"
                DRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Case "tabCustomer_Reply"
                DRow = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            Case "tabAnswered"
                DRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            Case "tabClosed"
                DRow = GridView4.GetDataRow(GridView4.FocusedRowHandle)
            Case Else
                DRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        End Select
        frmEditor.TicketShow()
        frmEditor.ShowDialog()
        Doldur(False)
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub

    Private Sub cmdAyarlar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdAyarlar.ItemClick
        SetupDurumu = True
        Dim frmsetup As New frmSetup
        frmsetup.ShowDialog()
    End Sub

    Private Sub cmdYenile_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdYenile.ItemClick
        Timer1.Stop()
        Timer2.Stop()
        Zaman = RefreshRate
        Doldur(False)
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub cmdKapat_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdKapat.ItemClick
        Me.Close()
    End Sub

    Private Sub cmdGizle_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdGizle.ItemClick
        Me.Hide()
        Gorunuyormu = False
    End Sub

    Private Sub TabbedControlGroup1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraLayout.LayoutTabPageChangedEventArgs) Handles TabbedControlGroup1.SelectedPageChanged
        If sClosing = False Then
            Timer1.Stop()
            Timer2.Stop()
            Zaman = RefreshRate
            Doldur(False)
            Timer1.Start()
            Timer2.Start()
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdAbout.ItemClick
        Dim frmAbout As New frmAbout
        frmAbout.ShowDialog()
    End Sub

    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick, GridView2.DoubleClick, GridView3.DoubleClick, GridView4.DoubleClick
        If sender.DataRowCount <> 0 Then
            Timer1.Enabled = False
            Timer2.Enabled = False
            Dim DRow As DataRow
            Select Case TabbedControlGroup1.SelectedTabPage.Name
                Case "tabOpen"
                    DRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                Case "tabCustomer_Reply"
                    DRow = GridView3.GetDataRow(GridView3.FocusedRowHandle)
                Case "tabAnswered"
                    DRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
                Case "tabClosed"
                    DRow = GridView4.GetDataRow(GridView4.FocusedRowHandle)
                Case Else
                    DRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            End Select
            frmEditor.TicketShow()
            frmEditor.ShowDialog()
            Doldur(False)
            Timer1.Enabled = True
            Timer2.Enabled = True
        End If
    End Sub
End Class
