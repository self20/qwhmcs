<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Ds1 = New QWHMCS.ds1
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl
        Me.cmdHide = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAc = New DevExpress.XtraEditors.SimpleButton
        Me.cmdKapat = New DevExpress.XtraEditors.SimpleButton
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.Ds1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coltid = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldid = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coluserid = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colname = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colemail = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cold_name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colu_name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colu_subname = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coltitle = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colmessage = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colstatus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colurgency = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collastreply = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ni1 = New System.Windows.Forms.NotifyIcon(Me.components)
        CType(Me.Ds1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Ds1
        '
        Me.Ds1.DataSetName = "ds1"
        Me.Ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cmdHide)
        Me.LayoutControl1.Controls.Add(Me.cmdAc)
        Me.LayoutControl1.Controls.Add(Me.cmdKapat)
        Me.LayoutControl1.Controls.Add(Me.RadioGroup1)
        Me.LayoutControl1.Controls.Add(Me.cmdRefresh)
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(674, 340)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cmdHide
        '
        Me.cmdHide.Image = Global.QWHMCS.My.Resources.Resources.confg_16
        Me.cmdHide.Location = New System.Drawing.Point(462, 42)
        Me.cmdHide.Name = "cmdHide"
        Me.cmdHide.Size = New System.Drawing.Size(97, 24)
        Me.cmdHide.StyleController = Me.LayoutControl1
        Me.cmdHide.TabIndex = 6
        Me.cmdHide.Text = "Gizle"
        '
        'cmdAc
        '
        Me.cmdAc.Image = Global.QWHMCS.My.Resources.Resources.ntwrk_16
        Me.cmdAc.Location = New System.Drawing.Point(462, 7)
        Me.cmdAc.Name = "cmdAc"
        Me.cmdAc.Size = New System.Drawing.Size(97, 24)
        Me.cmdAc.StyleController = Me.LayoutControl1
        Me.cmdAc.TabIndex = 6
        Me.cmdAc.Text = "Ticket'i Aç"
        '
        'cmdKapat
        '
        Me.cmdKapat.Image = Global.QWHMCS.My.Resources.Resources.close_16
        Me.cmdKapat.Location = New System.Drawing.Point(570, 7)
        Me.cmdKapat.Name = "cmdKapat"
        Me.cmdKapat.Size = New System.Drawing.Size(98, 24)
        Me.cmdKapat.StyleController = Me.LayoutControl1
        Me.cmdKapat.TabIndex = 6
        Me.cmdKapat.Text = "Kapat"
        '
        'RadioGroup1
        '
        Me.RadioGroup1.EditValue = "Open"
        Me.RadioGroup1.Location = New System.Drawing.Point(7, 7)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Columns = 2
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("Open", "Açık Ticket"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Customer-Reply", "Cevap Bekleyen Ticket"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Answered", "Cevaplanan Ticket"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Closed", "Kapalı Ticket")})
        Me.RadioGroup1.Size = New System.Drawing.Size(272, 59)
        Me.RadioGroup1.StyleController = Me.LayoutControl1
        Me.RadioGroup1.TabIndex = 6
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Image = Global.QWHMCS.My.Resources.Resources.ref_16
        Me.cmdRefresh.Location = New System.Drawing.Point(570, 42)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(98, 24)
        Me.cmdRefresh.StyleController = Me.LayoutControl1
        Me.cmdRefresh.TabIndex = 5
        Me.cmdRefresh.Text = "Yenile"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbltickets"
        Me.GridControl1.DataSource = Me.Ds1BindingSource
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(7, 77)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(661, 257)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'Ds1BindingSource
        '
        Me.Ds1BindingSource.DataSource = Me.Ds1
        Me.Ds1BindingSource.Position = 0
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.coltid, Me.coldid, Me.coluserid, Me.colname, Me.colemail, Me.colc, Me.coldate, Me.cold_name, Me.colu_name, Me.colu_subname, Me.coltitle, Me.colmessage, Me.colstatus, Me.colurgency, Me.collastreply})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
        Me.GridView1.OptionsMenu.EnableFooterMenu = False
        Me.GridView1.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colid
        '
        Me.colid.Caption = "id"
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'coltid
        '
        Me.coltid.Caption = "tid"
        Me.coltid.FieldName = "tid"
        Me.coltid.Name = "coltid"
        '
        'coldid
        '
        Me.coldid.Caption = "did"
        Me.coldid.FieldName = "did"
        Me.coldid.Name = "coldid"
        '
        'coluserid
        '
        Me.coluserid.Caption = "userid"
        Me.coluserid.FieldName = "userid"
        Me.coluserid.Name = "coluserid"
        '
        'colname
        '
        Me.colname.Caption = "name"
        Me.colname.FieldName = "name"
        Me.colname.Name = "colname"
        '
        'colemail
        '
        Me.colemail.Caption = "email"
        Me.colemail.FieldName = "email"
        Me.colemail.Name = "colemail"
        '
        'colc
        '
        Me.colc.Caption = "c"
        Me.colc.FieldName = "c"
        Me.colc.Name = "colc"
        '
        'coldate
        '
        Me.coldate.Caption = "Tarih"
        Me.coldate.DisplayFormat.FormatString = "d"
        Me.coldate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.coldate.FieldName = "date"
        Me.coldate.Name = "coldate"
        Me.coldate.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.coldate.Visible = True
        Me.coldate.VisibleIndex = 0
        Me.coldate.Width = 106
        '
        'cold_name
        '
        Me.cold_name.Caption = "Bölüm"
        Me.cold_name.FieldName = "d_name"
        Me.cold_name.Name = "cold_name"
        Me.cold_name.Visible = True
        Me.cold_name.VisibleIndex = 1
        Me.cold_name.Width = 87
        '
        'colu_name
        '
        Me.colu_name.Caption = "Adı"
        Me.colu_name.FieldName = "u_name"
        Me.colu_name.Name = "colu_name"
        Me.colu_name.Visible = True
        Me.colu_name.VisibleIndex = 2
        Me.colu_name.Width = 87
        '
        'colu_subname
        '
        Me.colu_subname.Caption = "Soyadı"
        Me.colu_subname.FieldName = "u_subname"
        Me.colu_subname.Name = "colu_subname"
        Me.colu_subname.Visible = True
        Me.colu_subname.VisibleIndex = 3
        Me.colu_subname.Width = 87
        '
        'coltitle
        '
        Me.coltitle.Caption = "Başlık"
        Me.coltitle.FieldName = "title"
        Me.coltitle.Name = "coltitle"
        Me.coltitle.Visible = True
        Me.coltitle.VisibleIndex = 4
        Me.coltitle.Width = 137
        '
        'colmessage
        '
        Me.colmessage.Caption = "message"
        Me.colmessage.FieldName = "message"
        Me.colmessage.Name = "colmessage"
        '
        'colstatus
        '
        Me.colstatus.Caption = "Durum"
        Me.colstatus.FieldName = "status"
        Me.colstatus.Name = "colstatus"
        Me.colstatus.Visible = True
        Me.colstatus.VisibleIndex = 5
        Me.colstatus.Width = 67
        '
        'colurgency
        '
        Me.colurgency.Caption = "Öncelik"
        Me.colurgency.FieldName = "urgency"
        Me.colurgency.Name = "colurgency"
        Me.colurgency.Visible = True
        Me.colurgency.VisibleIndex = 6
        Me.colurgency.Width = 69
        '
        'collastreply
        '
        Me.collastreply.Caption = "lastreply"
        Me.collastreply.FieldName = "lastreply"
        Me.collastreply.Name = "collastreply"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.EmptySpaceItem1, Me.LayoutControlItem5, Me.LayoutControlItem4, Me.LayoutControlItem2, Me.LayoutControlItem6})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(674, 340)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 70)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem1.Size = New System.Drawing.Size(672, 268)
        Me.LayoutControlItem1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.RadioGroup1
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(283, 70)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(283, 70)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem3.Size = New System.Drawing.Size(283, 70)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(283, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(172, 70)
        Me.EmptySpaceItem1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cmdAc
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(455, 0)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(108, 35)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(108, 35)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem5.Size = New System.Drawing.Size(108, 35)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlItem5.Text = "LayoutControlItem5"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextToControlDistance = 0
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cmdKapat
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(563, 0)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(109, 35)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(109, 35)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem4.Size = New System.Drawing.Size(109, 35)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlItem4.Text = "LayoutControlItem4"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmdRefresh
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(563, 35)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(0, 35)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(100, 35)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem2.Size = New System.Drawing.Size(109, 35)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cmdHide
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(455, 35)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem6.Size = New System.Drawing.Size(108, 35)
        Me.LayoutControlItem6.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlItem6.Text = "LayoutControlItem6"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextToControlDistance = 0
        Me.LayoutControlItem6.TextVisible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 30000
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1000
        '
        'ni1
        '
        Me.ni1.Icon = CType(resources.GetObject("ni1.Icon"), System.Drawing.Icon)
        Me.ni1.Text = "QWHMCS - WHMCS Ticket Takip Sistemi"
        Me.ni1.Visible = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 340)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Opacity = 0.9
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QWHMCS - WHMCS Ticket Takip Sistemi"
        CType(Me.Ds1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Ds1 As QWHMCS.ds1
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Ds1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coluserid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colemail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cold_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colu_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colu_subname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltitle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmessage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colurgency As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collastreply As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cmdKapat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdAc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ni1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents cmdHide As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

End Class
