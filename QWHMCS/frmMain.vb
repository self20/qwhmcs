Imports System.Net
Imports System.IO
Imports System.Text
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
        Me.Text = "QWHMCS - WHMCS Ticket Track System - " & Application.ProductVersion
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
        RefreshRate = objIniFile.GetString("Settings", "RefreshRate", 30)
        Transparency = objIniFile.GetString("Settings", "Transparency", 90)
        YourSign = objIniFile.GetString("Settings", "YourSign", "")
        MaxTicket = objIniFile.GetString("Settings", "MaxTicket", 0)
        DefaultLookAndFeel1.LookAndFeel.SkinName = objIniFile.GetString("Settings", "Skin", "Blue")
        'Language Settings
        frmEditor.coldate1.Caption = LName(24)
        frmEditor.cold_name1.Caption = LName(36)
        tabOpen.Text = LName(18)
        tabCustomer_Reply.Text = LName(19)
        tabAnswered.Text = LName(20)
        tabInProgress.Text = LName(21)
        tabOnHold.Text = LName(22)
        tabClosed.Text = LName(23)
        cmdAc.Caption = LName(17)
        cmdAyarlar.Caption = LName(1)
        cmdGizle.Caption = LName(15)
        cmdKapat.Caption = LName(16)
        coldate1.Caption = LName(24)
        coldate2.Caption = LName(24)
        coldate3.Caption = LName(24)
        coldate4.Caption = LName(24)
        coldate5.Caption = LName(24)
        coldate6.Caption = LName(24)
        cold_name1.Caption = LName(25)
        cold_name2.Caption = LName(25)
        cold_name3.Caption = LName(25)
        cold_name4.Caption = LName(25)
        cold_name5.Caption = LName(25)
        cold_name6.Caption = LName(25)
        colu_name1.Caption = LName(26)
        colu_name2.Caption = LName(26)
        colu_name3.Caption = LName(26)
        colu_name4.Caption = LName(26)
        colu_name5.Caption = LName(26)
        colu_name6.Caption = LName(26)
        colu_subname1.Caption = LName(27)
        colu_subname2.Caption = LName(27)
        colu_subname3.Caption = LName(27)
        colu_subname4.Caption = LName(27)
        colu_subname5.Caption = LName(27)
        colu_subname6.Caption = LName(27)
        coltitle1.Caption = LName(28)
        coltitle2.Caption = LName(28)
        coltitle3.Caption = LName(28)
        coltitle4.Caption = LName(28)
        coltitle5.Caption = LName(28)
        coltitle6.Caption = LName(28)
        colstatus1.Caption = LName(29)
        colstatus2.Caption = LName(29)
        colstatus3.Caption = LName(29)
        colstatus4.Caption = LName(29)
        colstatus5.Caption = LName(29)
        colstatus6.Caption = LName(29)
        colurgency1.Caption = LName(30)
        colurgency2.Caption = LName(30)
        colurgency3.Caption = LName(30)
        colurgency4.Caption = LName(30)
        colurgency5.Caption = LName(30)
        colurgency6.Caption = LName(30)
        Me.Opacity = Transparency / 100
        Zaman = RefreshRate
    End Sub
    Public Function Doldur(Optional ByVal Ilk As Boolean = False) As Boolean
        Application.DoEvents()
        lbStatus.Caption = LName(43)
        lbStatus.Glyph = My.Resources.hist_16
        Application.DoEvents()
        Try
            Dim Ds2 As New DataSet
            Dim readXML As String
            readXML = XMLDownload(TabbedControlGroup1.SelectedTabPage.Tag)
            If readXML = "No Record" Then
                If Ilk = True Then
                    AcikTicketSayisi = Int(XMLDownload(5))
                    CevapBekleyenTicketSayisi = Int(XMLDownload(6))
                End If
                GridControl1.DataSource = Nothing
                GridControl2.DataSource = Nothing
                GridControl3.DataSource = Nothing
                GridControl4.DataSource = Nothing
                GridControl5.DataSource = Nothing
                GridControl6.DataSource = Nothing
                lbStatus.Caption = LName(42)
                lbStatus.Glyph = My.Resources.play_16
                Exit Function
            End If
            Ds2 = XmlString2DataSet(readXML)
            If Ilk = True Then
                AcikTicketSayisi = Int(XMLDownload(5))
                CevapBekleyenTicketSayisi = Int(XMLDownload(6))
            Else
                tAcikTicketSayisi = Int(XMLDownload(5))
                tCevapBekleyenTicketSayisi = Int(XMLDownload(6))
                If tAcikTicketSayisi > AcikTicketSayisi Then
                    My.Computer.Audio.Play(aPath & "\alarm.wav", AudioPlayMode.BackgroundLoop)
                    ni1.ShowBalloonTip(0, LName(46), LName(47), ToolTipIcon.Info)
                    AcikTicketSayisi = tAcikTicketSayisi
                End If
                If tCevapBekleyenTicketSayisi > CevapBekleyenTicketSayisi Then
                    My.Computer.Audio.Play(aPath & "\alarm.wav", AudioPlayMode.BackgroundLoop)
                    ni1.ShowBalloonTip(0, LName(46), LName(48), ToolTipIcon.Info)
                    CevapBekleyenTicketSayisi = tCevapBekleyenTicketSayisi
                End If
            End If
            Select Case TabbedControlGroup1.SelectedTabPage.Name
                Case "tabOpen"
                    GridControl1.DataSource = Ds2.Tables(0)
                    If GridView1.DataRowCount <> 0 Then
                        cmdAc.Enabled = True
                    Else
                        cmdAc.Enabled = False
                    End If
                Case "tabCustomer_Reply"
                    GridControl3.DataSource = Ds2.Tables(0)
                    If GridView3.DataRowCount <> 0 Then
                        cmdAc.Enabled = True
                    Else
                        cmdAc.Enabled = False
                    End If
                Case "tabAnswered"
                    GridControl2.DataSource = Ds2.Tables(0)
                    If GridView2.DataRowCount <> 0 Then
                        cmdAc.Enabled = True
                    Else
                        cmdAc.Enabled = False
                    End If
                Case "tabClosed"
                    GridControl4.DataSource = Ds2.Tables(0)
                    If GridView4.DataRowCount <> 0 Then
                        cmdAc.Enabled = True
                    Else
                        cmdAc.Enabled = False
                    End If
                Case "tabInProgress"
                    GridControl5.DataSource = Ds2.Tables(0)
                    If GridView5.DataRowCount <> 0 Then
                        cmdAc.Enabled = True
                    Else
                        cmdAc.Enabled = False
                    End If
                Case "tabOnHold"
                    GridControl6.DataSource = Ds2.Tables(0)
                    If GridView6.DataRowCount <> 0 Then
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
            lbStatus.Caption = LName(42)
            lbStatus.Glyph = My.Resources.play_16
        Catch ex As Exception
            lbStatus.Caption = LName(45)
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
        cmdYenile.Caption = Zaman
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
            Case "tabInProgress"
                DRow = GridView5.GetDataRow(GridView5.FocusedRowHandle)
            Case "tabOnHold"
                DRow = GridView6.GetDataRow(GridView6.FocusedRowHandle)
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
                Case "tabInProgress"
                    DRow = GridView5.GetDataRow(GridView5.FocusedRowHandle)
                Case "tabOnHold"
                    DRow = GridView6.GetDataRow(GridView6.FocusedRowHandle)
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
