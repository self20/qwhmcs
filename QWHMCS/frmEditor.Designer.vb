<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditor
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl
        Me.txtMessage = New DevExpress.XtraEditors.MemoEdit
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.coldate1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cold_name1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtLastReply = New DevExpress.XtraEditors.TextEdit
        Me.txtSubject = New DevExpress.XtraEditors.TextEdit
        Me.txtStatus = New DevExpress.XtraEditors.TextEdit
        Me.txtDepartment = New DevExpress.XtraEditors.TextEdit
        Me.txtClient = New DevExpress.XtraEditors.TextEdit
        Me.txtTicketID = New DevExpress.XtraEditors.TextEdit
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar
        Me.cmdReply = New DevExpress.XtraBars.BarButtonItem
        Me.cmdSendClose = New DevExpress.XtraBars.BarButtonItem
        Me.cmdCloseTicket = New DevExpress.XtraBars.BarButtonItem
        Me.cmdOpenWHMCS = New DevExpress.XtraBars.BarButtonItem
        Me.cmdCloseViewer = New DevExpress.XtraBars.BarButtonItem
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.lbStatus = New DevExpress.XtraBars.BarStaticItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.cmdSendTicket = New DevExpress.XtraBars.BarButtonItem
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtMessage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLastReply.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDepartment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClient.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTicketID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtMessage)
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Controls.Add(Me.txtLastReply)
        Me.LayoutControl1.Controls.Add(Me.txtSubject)
        Me.LayoutControl1.Controls.Add(Me.txtStatus)
        Me.LayoutControl1.Controls.Add(Me.txtDepartment)
        Me.LayoutControl1.Controls.Add(Me.txtClient)
        Me.LayoutControl1.Controls.Add(Me.txtTicketID)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(799, 451)
        Me.LayoutControl1.TabIndex = 1
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(7, 264)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(786, 181)
        Me.txtMessage.StyleController = Me.LayoutControl1
        Me.txtMessage.TabIndex = 15
        '
        'GridControl1
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(10, 121)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(780, 129)
        Me.GridControl1.TabIndex = 14
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.coldate1, Me.cold_name1, Me.GridColumn1})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
        Me.GridView1.OptionsMenu.EnableFooterMenu = False
        Me.GridView1.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'coldate1
        '
        Me.coldate1.Caption = "Tarih"
        Me.coldate1.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.coldate1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.coldate1.FieldName = "date"
        Me.coldate1.Name = "coldate1"
        Me.coldate1.Visible = True
        Me.coldate1.VisibleIndex = 0
        Me.coldate1.Width = 171
        '
        'cold_name1
        '
        Me.cold_name1.Caption = "Kimden"
        Me.cold_name1.FieldName = "kim"
        Me.cold_name1.Name = "cold_name1"
        Me.cold_name1.Visible = True
        Me.cold_name1.VisibleIndex = 1
        Me.cold_name1.Width = 520
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "GridColumn1"
        Me.GridColumn1.FieldName = "message"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'txtLastReply
        '
        Me.txtLastReply.Location = New System.Drawing.Point(480, 90)
        Me.txtLastReply.Name = "txtLastReply"
        Me.txtLastReply.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtLastReply.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtLastReply.Properties.ReadOnly = True
        Me.txtLastReply.Size = New System.Drawing.Size(310, 20)
        Me.txtLastReply.StyleController = Me.LayoutControl1
        Me.txtLastReply.TabIndex = 13
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(84, 90)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtSubject.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtSubject.Properties.ReadOnly = True
        Me.txtSubject.Size = New System.Drawing.Size(311, 20)
        Me.txtSubject.StyleController = Me.LayoutControl1
        Me.txtSubject.TabIndex = 12
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(480, 59)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtStatus.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtStatus.Properties.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(310, 20)
        Me.txtStatus.StyleController = Me.LayoutControl1
        Me.txtStatus.TabIndex = 11
        '
        'txtDepartment
        '
        Me.txtDepartment.Location = New System.Drawing.Point(84, 59)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtDepartment.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtDepartment.Properties.ReadOnly = True
        Me.txtDepartment.Size = New System.Drawing.Size(311, 20)
        Me.txtDepartment.StyleController = Me.LayoutControl1
        Me.txtDepartment.TabIndex = 10
        '
        'txtClient
        '
        Me.txtClient.Location = New System.Drawing.Point(480, 28)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtClient.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtClient.Properties.ReadOnly = True
        Me.txtClient.Size = New System.Drawing.Size(310, 20)
        Me.txtClient.StyleController = Me.LayoutControl1
        Me.txtClient.TabIndex = 8
        '
        'txtTicketID
        '
        Me.txtTicketID.Location = New System.Drawing.Point(84, 28)
        Me.txtTicketID.Name = "txtTicketID"
        Me.txtTicketID.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtTicketID.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTicketID.Properties.ReadOnly = True
        Me.txtTicketID.Size = New System.Drawing.Size(311, 20)
        Me.txtTicketID.StyleController = Me.LayoutControl1
        Me.txtTicketID.TabIndex = 7
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(799, 451)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup2.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlGroup2.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlGroup2.CustomizationFormText = "Ticket Information"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem7, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem8, Me.LayoutControlItem5, Me.LayoutControlItem11})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(797, 257)
        Me.LayoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.LayoutControlGroup2.Text = "Ticket Information"
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtTicketID
        Me.LayoutControlItem4.CustomizationFormText = "Ticket ID"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem4.Size = New System.Drawing.Size(396, 31)
        Me.LayoutControlItem4.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlItem4.Text = "Ticket ID"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(69, 20)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtDepartment
        Me.LayoutControlItem7.CustomizationFormText = "Department"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 31)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem7.Size = New System.Drawing.Size(396, 31)
        Me.LayoutControlItem7.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlItem7.Text = "Department"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(69, 20)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtSubject
        Me.LayoutControlItem9.CustomizationFormText = "Subject"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 62)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem9.Size = New System.Drawing.Size(396, 31)
        Me.LayoutControlItem9.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlItem9.Text = "Subject"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(69, 20)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtLastReply
        Me.LayoutControlItem10.CustomizationFormText = "Last Reply"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(396, 62)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem10.Size = New System.Drawing.Size(395, 31)
        Me.LayoutControlItem10.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlItem10.Text = "Last Reply"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(69, 20)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtStatus
        Me.LayoutControlItem8.CustomizationFormText = "Status"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(396, 31)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem8.Size = New System.Drawing.Size(395, 31)
        Me.LayoutControlItem8.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlItem8.Text = "Status"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(69, 20)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtClient
        Me.LayoutControlItem5.CustomizationFormText = "Client"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(396, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem5.Size = New System.Drawing.Size(395, 31)
        Me.LayoutControlItem5.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlItem5.Text = "Client"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(69, 20)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.GridControl1
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 93)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem11.Size = New System.Drawing.Size(791, 140)
        Me.LayoutControlItem11.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlItem11.Text = "LayoutControlItem11"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextToControlDistance = 0
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtMessage
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 257)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem1.Size = New System.Drawing.Size(797, 192)
        Me.LayoutControlItem1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdReply, Me.lbStatus, Me.cmdCloseTicket, Me.cmdCloseViewer, Me.cmdOpenWHMCS, Me.cmdSendClose, Me.cmdSendTicket})
        Me.BarManager1.MaxItemId = 21
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.cmdReply, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.cmdSendTicket, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.cmdSendClose, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.cmdCloseTicket, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.cmdOpenWHMCS, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.cmdCloseViewer, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DisableClose = True
        Me.Bar1.OptionsBar.DisableCustomization = True
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Tools"
        '
        'cmdReply
        '
        Me.cmdReply.Caption = "Reply Ticket"
        Me.cmdReply.Glyph = Global.QWHMCS.My.Resources.Resources.ntwrk_16
        Me.cmdReply.Id = 0
        Me.cmdReply.Name = "cmdReply"
        '
        'cmdSendClose
        '
        Me.cmdSendClose.Caption = "Send && Close Ticket"
        Me.cmdSendClose.Glyph = Global.QWHMCS.My.Resources.Resources.lgicn_16
        Me.cmdSendClose.Id = 19
        Me.cmdSendClose.Name = "cmdSendClose"
        Me.cmdSendClose.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'cmdCloseTicket
        '
        Me.cmdCloseTicket.Caption = "Close Ticket"
        Me.cmdCloseTicket.Glyph = Global.QWHMCS.My.Resources.Resources.lock_16
        Me.cmdCloseTicket.Id = 15
        Me.cmdCloseTicket.Name = "cmdCloseTicket"
        '
        'cmdOpenWHMCS
        '
        Me.cmdOpenWHMCS.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.cmdOpenWHMCS.Caption = "Open in WHMCS"
        Me.cmdOpenWHMCS.Glyph = Global.QWHMCS.My.Resources.Resources.exp_16
        Me.cmdOpenWHMCS.Id = 17
        Me.cmdOpenWHMCS.Name = "cmdOpenWHMCS"
        '
        'cmdCloseViewer
        '
        Me.cmdCloseViewer.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.cmdCloseViewer.Caption = "Close Viewer"
        Me.cmdCloseViewer.Glyph = Global.QWHMCS.My.Resources.Resources.close_16
        Me.cmdCloseViewer.Id = 16
        Me.cmdCloseViewer.Name = "cmdCloseViewer"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.lbStatus, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'lbStatus
        '
        Me.lbStatus.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.lbStatus.Id = 10
        Me.lbStatus.Name = "lbStatus"
        Me.lbStatus.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'cmdSendTicket
        '
        Me.cmdSendTicket.Caption = "Send Ticket"
        Me.cmdSendTicket.Glyph = Global.QWHMCS.My.Resources.Resources.mail_16
        Me.cmdSendTicket.Id = 20
        Me.cmdSendTicket.Name = "cmdSendTicket"
        Me.cmdSendTicket.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'frmEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmEditor"
        Me.Text = "Ticket Viewer"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtMessage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLastReply.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDepartment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClient.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTicketID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtLastReply As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSubject As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtStatus As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDepartment As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtClient As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTicketID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents coldate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cold_name1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents cmdReply As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Public WithEvents lbStatus As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdCloseTicket As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdCloseViewer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdOpenWHMCS As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtMessage As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdSendClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdSendTicket As DevExpress.XtraBars.BarButtonItem
End Class
