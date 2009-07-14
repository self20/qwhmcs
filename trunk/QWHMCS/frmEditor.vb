Public Class frmEditor
    Dim TicReply As Boolean = True
    Dim TicketID As Long
    Private Sub frmEditor_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub
    Private Sub cmdKapat_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdCloseViewer.ItemClick
        Me.Hide()
        frmMain.Focus()
    End Sub
    Private Sub cmdReply_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdReply.ItemClick
        txtMessage.EditValue = Nothing
        cmdSendTicket.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        cmdSendClose.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        cmdReply.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub

    Public Function TicketShow() As Boolean
        Try
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
            Dim Ds2 As New DataSet
            Ds2 = XmlString2DataSet(XMLDownload(7, DRow("id")))
            GridControl1.DataSource = Ds2.Tables(0)
            If txtStatus.EditValue = "Closed" Then
                cmdCloseTicket.Enabled = False
            Else
                cmdCloseTicket.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("Error:" & ex.Message, MsgBoxStyle.Critical)
        End Try

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
        lbStatus.Glyph = My.Resources.hist_16
        lbStatus.Caption = "Ticket Closing..."
        If XMLDownload("closeticket", TicketID) = "success" Then
            lbStatus.Caption = "Ticket Closed."
            lbStatus.Glyph = My.Resources.play_16
            cmdCloseTicket.Enabled = False
            txtStatus.Text = "Closed"
        Else
            lbStatus.Caption = "Ticket Not Closed ! Please Try Again."
            lbStatus.Glyph = My.Resources.cancl_16
        End If
    End Sub

    Private Sub cmdSendTicket_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdSendTicket.ItemClick
        lbStatus.Caption = "Ticket Sending. Please Wait."
        lbStatus.Glyph = My.Resources.hist_16
        Application.DoEvents()
        If Curl(APIAddress & "/api.php", String.Format("&action=addticketreply&username={0}&password={1}&ticketid={2}&adminusername={0}&message={3}", APIUsername, ConvertStringToMD5(APIPassword), TicketID, txtMessage.EditValue() & vbCrLf & vbCrLf & YourSign.Replace("|", vbCrLf))) = True Then
            lbStatus.Caption = "Ticket Sended."
            lbStatus.Glyph = My.Resources.play_16
            cmdSendTicket.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            cmdSendClose.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            cmdReply.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Else
            lbStatus.Caption = "Ticket Not Sended ! Please Try Again."
            lbStatus.Glyph = My.Resources.cancl_16
        End If
        TicketShow()
    End Sub

    Private Sub cmdSendClose_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdSendClose.ItemClick
        lbStatus.Caption = "Ticket Sending. Please Wait."
        lbStatus.Glyph = My.Resources.hist_16
        Application.DoEvents()
        If Curl(APIAddress & "/api.php", String.Format("&action=addticketreply&username={0}&password={1}&ticketid={2}&adminusername={0}&message={3}", APIUsername, ConvertStringToMD5(APIPassword), TicketID, txtMessage.EditValue() & vbCrLf & vbCrLf & YourSign.Replace("|", vbCrLf))) = True Then
            lbStatus.Caption = "Ticket Sended."
            lbStatus.Glyph = My.Resources.play_16
            cmdSendTicket.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            cmdSendClose.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            cmdReply.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            lbStatus.Glyph = My.Resources.hist_16
            lbStatus.Caption = "Ticket Closing..."
            If XMLDownload("closeticket", TicketID) = "success" Then
                lbStatus.Caption = "Ticket Closed."
                lbStatus.Glyph = My.Resources.play_16
                cmdCloseTicket.Enabled = False
                txtStatus.Text = "Closed"
                cmdSendTicket.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                cmdSendClose.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                cmdReply.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Else
                lbStatus.Caption = "Ticket Not Closed ! Please Try Again."
                lbStatus.Glyph = My.Resources.cancl_16
            End If

        Else
            lbStatus.Caption = "Ticket Not Sended ! Please Try Again."
            lbStatus.Glyph = My.Resources.cancl_16
        End If
        TicketShow()
    End Sub
End Class