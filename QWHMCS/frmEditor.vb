Public Class frmEditor
    Dim TicReply As Boolean = True
    Dim TicketID As Long
    Private Sub frmEditor_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub
    Private Sub cmdKapat_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdCloseViewer.ItemClick
        Me.Hide()
    End Sub
    Private Sub cmdReply_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdReply.ItemClick
        If TicReply = True Then
            txtMessage.EditValue = Nothing
            cmdReply.Caption = "Send Reply"
            TicReply = False
            txtMessage.Focus()
        Else
            lbStatus.Caption = "Ticket Sending. Please Wait."
            lbStatus.Glyph = My.Resources.hist_16
            Application.DoEvents()
            If Curl(APIAddress & "/api.php", String.Format("&action=addticketreply&username={0}&password={1}&ticketid={2}&adminusername={0}&message={3}", APIUsername, ConvertStringToMD5(APIPassword), TicketID, txtMessage.EditValue())) = True Then
                lbStatus.Caption = "Ticket Sended."
                lbStatus.Glyph = My.Resources.play_16
            Else
                lbStatus.Caption = "Ticket Not Sended ! Please Try Again."
                lbStatus.Glyph = My.Resources.cancl_16
            End If
            TicketShow()
            TicReply = True
        End If
    End Sub

    Public Function TicketShow() As Boolean
        Dim DRow As DataRow
        Select Case frmMain.TabbedControlGroup1.SelectedTabPage.Name
            Case "tabOpen"
                DRow = frmMain.GridView1.GetDataRow(frmMain.GridView1.FocusedRowHandle)
            Case "tabCustomer_Reply"
                DRow = frmMain.GridView3.GetDataRow(frmMain.GridView3.FocusedRowHandle)
            Case "tabAnswered"
                DRow = frmMain.GridView2.GetDataRow(frmMain.GridView2.FocusedRowHandle)
            Case "tabClosed"
                DRow = frmMain.GridView4.GetDataRow(frmMain.GridView4.FocusedRowHandle)
            Case Else
                DRow = frmMain.GridView1.GetDataRow(frmMain.GridView1.FocusedRowHandle)
        End Select
        TicketID = DRow("id")
        txtTicketID.EditValue = DRow("id") & " - " & DRow("tid")
        txtDepartment.EditValue = DRow("d_name")
        txtClient.EditValue = DRow("u_name") & " " & DRow("u_subname")
        txtSubject.EditValue = DRow("title")
        txtStatus.EditValue = DRow("status")
        txtLastReply.EditValue = DRow("lastreply")
        txtMessage.Lines = StripHTML(DRow("message")).Replace(vbCr, String.Empty).Split(vbCrLf.ToCharArray())
        SorguGridMySQL(0, BaglantiSirket, String.Format("select tbltickets.id as tid,IF(LENGTH(admin)=0,IF(userid=0,CONCAT(name,' (',tbltickets.email,')'),CONCAT(tblclients.firstname,' ',tblclients.lastname)),admin) as kim,date,message from tbltickets left join tblclients on tblclients.id = tbltickets.userid where tbltickets.id={0} " & _
        "union " & _
        "select tid,IF(LENGTH(admin)=0,IF(userid=0,CONCAT(name,' (',tblticketreplies.email,')'),CONCAT(tblclients.firstname,' ',tblclients.lastname)),admin) as kim,date,message from tblticketreplies left join tblclients on tblclients.id = tblticketreplies.userid where tblticketreplies.tid={0}", DRow("id")), GridControl1)
        If txtStatus.EditValue = "Closed" Then
            cmdCloseTicket.Enabled = False
        Else
            cmdCloseTicket.Enabled = True
        End If
    End Function

    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If GridView1.DataRowCount <> 0 Then
            lbStatus.Caption = "Connecting Database..."
            lbStatus.Glyph = My.Resources.hist_16
            Application.DoEvents()
            Dim DRow As DataRow
            DRow = GridView1.GetDataRow(e.FocusedRowHandle)
            txtMessage.Lines = StripHTML(DRow("message")).Replace(vbCr, String.Empty).Split(vbCrLf.ToCharArray())
            lbStatus.Caption = "Ready"
            lbStatus.Glyph = My.Resources.play_16
            Application.DoEvents()
        Else

        End If
    End Sub

    Private Sub cmdOpenWHMCS_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdOpenWHMCS.ItemClick
        If GridView1.DataRowCount <> 0 Then
            Dim DRow As DataRow
            Select Case frmMain.TabbedControlGroup1.SelectedTabPage.Name
                Case "tabOpen"
                    DRow = frmMain.GridView1.GetDataRow(frmMain.GridView1.FocusedRowHandle)
                Case "tabCustomer_Reply"
                    DRow = frmMain.GridView3.GetDataRow(frmMain.GridView3.FocusedRowHandle)
                Case "tabAnswered"
                    DRow = frmMain.GridView2.GetDataRow(frmMain.GridView2.FocusedRowHandle)
                Case "tabClosed"
                    DRow = frmMain.GridView4.GetDataRow(frmMain.GridView4.FocusedRowHandle)
                Case Else
                    DRow = frmMain.GridView1.GetDataRow(frmMain.GridView1.FocusedRowHandle)
            End Select
            Process.Start(WHMCSAddress & "/supporttickets.php?action=viewticket&id=" & DRow("id"))
        End If
    End Sub

    Private Sub cmdCloseTicket_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdCloseTicket.ItemClick
        MsgBox("Coming Soon...", MsgBoxStyle.Information, ":)")
    End Sub
End Class