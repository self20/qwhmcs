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
        Me.lblGroupTicketInfo = New DevExpress.XtraLayout.LayoutControlGroup
        Me.lblTicketID = New DevExpress.XtraLayout.LayoutControlItem
        Me.lblDepartment = New DevExpress.XtraLayout.LayoutControlItem
        Me.lblTitle = New DevExpress.XtraLayout.LayoutControlItem
        Me.lblLastReply = New DevExpress.XtraLayout.LayoutControlItem
        Me.lblStatus = New DevExpress.XtraLayout.LayoutControlItem
        Me.lblName = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar
        Me.cmdReply = New DevExpress.XtraBars.BarButtonItem
        Me.cmdSendTicket = New DevExpress.XtraBars.BarButtonItem
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
        CType(Me.lblGroupTicketInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTicketID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDepartment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblLastReply, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblName, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.coldate1.Caption = "####"
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
        Me.cold_name1.Caption = "####"
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
        Me.txtLastReply.Location = New System.Drawing.Point(447, 90)
        Me.txtLastReply.Name = "txtLastReply"
        Me.txtLastReply.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtLastReply.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtLastReply.Properties.ReadOnly = True
        Me.txtLastReply.Size = New System.Drawing.Size(343, 20)
        Me.txtLastReply.StyleController = Me.LayoutControl1
        Me.txtLastReply.TabIndex = 13
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(51, 90)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtSubject.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtSubject.Properties.ReadOnly = True
        Me.txtSubject.Size = New System.Drawing.Size(344, 20)
        Me.txtSubject.StyleController = Me.LayoutControl1
        Me.txtSubject.TabIndex = 12
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(447, 59)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtStatus.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtStatus.Properties.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(343, 20)
        Me.txtStatus.StyleController = Me.LayoutControl1
        Me.txtStatus.TabIndex = 11
        '
        'txtDepartment
        '
        Me.txtDepartment.Location = New System.Drawing.Point(51, 59)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtDepartment.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtDepartment.Properties.ReadOnly = True
        Me.txtDepartment.Size = New System.Drawing.Size(344, 20)
        Me.txtDepartment.StyleController = Me.LayoutControl1
        Me.txtDepartment.TabIndex = 10
        '
        'txtClient
        '
        Me.txtClient.Location = New System.Drawing.Point(447, 28)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtClient.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtClient.Properties.ReadOnly = True
        Me.txtClient.Size = New System.Drawing.Size(343, 20)
        Me.txtClient.StyleController = Me.LayoutControl1
        Me.txtClient.TabIndex = 8
        '
        'txtTicketID
        '
        Me.txtTicketID.Location = New System.Drawing.Point(51, 28)
        Me.txtTicketID.Name = "txtTicketID"
        Me.txtTicketID.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtTicketID.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTicketID.Properties.ReadOnly = True
        Me.txtTicketID.Size = New System.Drawing.Size(344, 20)
        Me.txtTicketID.StyleController = Me.LayoutControl1
        Me.txtTicketID.TabIndex = 7
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lblGroupTicketInfo, Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(799, 451)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'lblGroupTicketInfo
        '
        Me.lblGroupTicketInfo.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblGroupTicketInfo.AppearanceGroup.Options.UseFont = True
        Me.lblGroupTicketInfo.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblGroupTicketInfo.AppearanceItemCaption.Options.UseFont = True
        Me.lblGroupTicketInfo.CustomizationFormText = "Ticket Information"
        Me.lblGroupTicketInfo.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lblTicketID, Me.lblDepartment, Me.lblTitle, Me.lblLastReply, Me.lblStatus, Me.lblName, Me.LayoutControlItem11})
        Me.lblGroupTicketInfo.Location = New System.Drawing.Point(0, 0)
        Me.lblGroupTicketInfo.Name = "lblGroupTicketInfo"
        Me.lblGroupTicketInfo.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lblGroupTicketInfo.Size = New System.Drawing.Size(797, 257)
        Me.lblGroupTicketInfo.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.lblGroupTicketInfo.Text = "####"
        '
        'lblTicketID
        '
        Me.lblTicketID.Control = Me.txtTicketID
        Me.lblTicketID.CustomizationFormText = "Ticket ID"
        Me.lblTicketID.Location = New System.Drawing.Point(0, 0)
        Me.lblTicketID.Name = "lblTicketID"
        Me.lblTicketID.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lblTicketID.Size = New System.Drawing.Size(396, 31)
        Me.lblTicketID.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lblTicketID.Text = "####"
        Me.lblTicketID.TextSize = New System.Drawing.Size(36, 20)
        '
        'lblDepartment
        '
        Me.lblDepartment.Control = Me.txtDepartment
        Me.lblDepartment.CustomizationFormText = "Department"
        Me.lblDepartment.Location = New System.Drawing.Point(0, 31)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lblDepartment.Size = New System.Drawing.Size(396, 31)
        Me.lblDepartment.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lblDepartment.Text = "####"
        Me.lblDepartment.TextSize = New System.Drawing.Size(36, 20)
        '
        'lblTitle
        '
        Me.lblTitle.Control = Me.txtSubject
        Me.lblTitle.CustomizationFormText = "Subject"
        Me.lblTitle.Location = New System.Drawing.Point(0, 62)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lblTitle.Size = New System.Drawing.Size(396, 31)
        Me.lblTitle.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lblTitle.Text = "####"
        Me.lblTitle.TextSize = New System.Drawing.Size(36, 20)
        '
        'lblLastReply
        '
        Me.lblLastReply.Control = Me.txtLastReply
        Me.lblLastReply.CustomizationFormText = "Last Reply"
        Me.lblLastReply.Location = New System.Drawing.Point(396, 62)
        Me.lblLastReply.Name = "lblLastReply"
        Me.lblLastReply.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lblLastReply.Size = New System.Drawing.Size(395, 31)
        Me.lblLastReply.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lblLastReply.Text = "####"
        Me.lblLastReply.TextSize = New System.Drawing.Size(36, 20)
        '
        'lblStatus
        '
        Me.lblStatus.Control = Me.txtStatus
        Me.lblStatus.CustomizationFormText = "Status"
        Me.lblStatus.Location = New System.Drawing.Point(396, 31)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lblStatus.Size = New System.Drawing.Size(395, 31)
        Me.lblStatus.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lblStatus.Text = "####"
        Me.lblStatus.TextSize = New System.Drawing.Size(36, 20)
        '
        'lblName
        '
        Me.lblName.Control = Me.txtClient
        Me.lblName.CustomizationFormText = "Client"
        Me.lblName.Location = New System.Drawing.Point(396, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lblName.Size = New System.Drawing.Size(395, 31)
        Me.lblName.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lblName.Text = "####"
        Me.lblName.TextSize = New System.Drawing.Size(36, 20)
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
        Me.cmdReply.Caption = "####"
        Me.cmdReply.Glyph = Global.QWHMCS.My.Resources.Resources.ntwrk_16
        Me.cmdReply.Id = 0
        Me.cmdReply.Name = "cmdReply"
        '
        'cmdSendTicket
        '
        Me.cmdSendTicket.Caption = "####"
        Me.cmdSendTicket.Glyph = Global.QWHMCS.My.Resources.Resources.mail_16
        Me.cmdSendTicket.Id = 20
        Me.cmdSendTicket.Name = "cmdSendTicket"
        Me.cmdSendTicket.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'cmdSendClose
        '
        Me.cmdSendClose.Caption = "####"
        Me.cmdSendClose.Glyph = Global.QWHMCS.My.Resources.Resources.lgicn_16
        Me.cmdSendClose.Id = 19
        Me.cmdSendClose.Name = "cmdSendClose"
        Me.cmdSendClose.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'cmdCloseTicket
        '
        Me.cmdCloseTicket.Caption = "####"
        Me.cmdCloseTicket.Glyph = Global.QWHMCS.My.Resources.Resources.lock_16
        Me.cmdCloseTicket.Id = 15
        Me.cmdCloseTicket.Name = "cmdCloseTicket"
        '
        'cmdOpenWHMCS
        '
        Me.cmdOpenWHMCS.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.cmdOpenWHMCS.Caption = "####"
        Me.cmdOpenWHMCS.Glyph = Global.QWHMCS.My.Resources.Resources.exp_16
        Me.cmdOpenWHMCS.Id = 17
        Me.cmdOpenWHMCS.Name = "cmdOpenWHMCS"
        '
        'cmdCloseViewer
        '
        Me.cmdCloseViewer.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.cmdCloseViewer.Caption = "####"
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
        Me.Text = "####"
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
        CType(Me.lblGroupTicketInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTicketID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDepartment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblLastReply, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblName, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblGroupTicketInfo As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lblTicketID As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lblDepartment As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lblTitle As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lblLastReply As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lblStatus As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lblName As DevExpress.XtraLayout.LayoutControlItem
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
