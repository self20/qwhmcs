<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetup))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.english = New DevExpress.XtraGrid.Columns.GridColumn
        Me.newvalue = New DevExpress.XtraGrid.Columns.GridColumn
        Me.desc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtSign = New DevExpress.XtraEditors.MemoEdit
        Me.txtMaxTicket = New DevExpress.XtraEditors.SpinEdit
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtAPIPassword = New DevExpress.XtraEditors.TextEdit
        Me.txtAPIUsername = New DevExpress.XtraEditors.TextEdit
        Me.txtAPIAddress = New DevExpress.XtraEditors.TextEdit
        Me.txtTransparent = New DevExpress.XtraEditors.TrackBarControl
        Me.txtRefreshRate = New DevExpress.XtraEditors.SpinEdit
        Me.txtWHMCSAddress = New DevExpress.XtraEditors.TextEdit
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup
        Me.tabGeneral = New DevExpress.XtraLayout.LayoutControlGroup
        Me.lblWAdminAdd = New DevExpress.XtraLayout.LayoutControlItem
        Me.lblWApiAdd = New DevExpress.XtraLayout.LayoutControlItem
        Me.lblApiUsername = New DevExpress.XtraLayout.LayoutControlItem
        Me.lblApiPassword = New DevExpress.XtraLayout.LayoutControlItem
        Me.lblRefreshRate = New DevExpress.XtraLayout.LayoutControlItem
        Me.lblSkin = New DevExpress.XtraLayout.LayoutControlItem
        Me.lblTranparentRate = New DevExpress.XtraLayout.LayoutControlItem
        Me.lblMaxTicket = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.lblSignature = New DevExpress.XtraLayout.LayoutControlItem
        Me.tabLanguage = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSign.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaxTicket.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAPIPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAPIUsername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAPIAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTransparent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRefreshRate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWHMCSAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblWAdminAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblWApiAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblApiUsername, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblApiPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRefreshRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSkin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTranparentRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMaxTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSignature, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabLanguage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cmdClose)
        Me.LayoutControl1.Controls.Add(Me.cmdSave)
        Me.LayoutControl1.Controls.Add(Me.txtSign)
        Me.LayoutControl1.Controls.Add(Me.txtMaxTicket)
        Me.LayoutControl1.Controls.Add(Me.ComboBoxEdit1)
        Me.LayoutControl1.Controls.Add(Me.txtAPIPassword)
        Me.LayoutControl1.Controls.Add(Me.txtAPIUsername)
        Me.LayoutControl1.Controls.Add(Me.txtAPIAddress)
        Me.LayoutControl1.Controls.Add(Me.txtTransparent)
        Me.LayoutControl1.Controls.Add(Me.txtRefreshRate)
        Me.LayoutControl1.Controls.Add(Me.txtWHMCSAddress)
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(642, 498)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.QWHMCS.My.Resources.Resources.close_16
        Me.cmdClose.Location = New System.Drawing.Point(560, 4)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(76, 24)
        Me.cmdClose.StyleController = Me.LayoutControl1
        Me.cmdClose.TabIndex = 32
        Me.cmdClose.Text = "####"
        '
        'cmdSave
        '
        Me.cmdSave.Image = Global.QWHMCS.My.Resources.Resources.play_16
        Me.cmdSave.Location = New System.Drawing.Point(473, 4)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(76, 24)
        Me.cmdSave.StyleController = Me.LayoutControl1
        Me.cmdSave.TabIndex = 31
        Me.cmdSave.Tag = "4"
        Me.cmdSave.Text = "####"
        '
        'GridControl1
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(16, 67)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(608, 413)
        Me.GridControl1.TabIndex = 40
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.id, Me.english, Me.newvalue, Me.desc})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'id
        '
        Me.id.Caption = "ID"
        Me.id.FieldName = "id"
        Me.id.Name = "id"
        '
        'english
        '
        Me.english.Caption = "English Text"
        Me.english.FieldName = "english"
        Me.english.Name = "english"
        Me.english.OptionsColumn.AllowEdit = False
        Me.english.Visible = True
        Me.english.VisibleIndex = 0
        '
        'newvalue
        '
        Me.newvalue.Caption = "Your Language"
        Me.newvalue.FieldName = "newvalue"
        Me.newvalue.Name = "newvalue"
        Me.newvalue.Visible = True
        Me.newvalue.VisibleIndex = 1
        '
        'desc
        '
        Me.desc.Caption = "Description"
        Me.desc.FieldName = "desc"
        Me.desc.Name = "desc"
        Me.desc.OptionsColumn.AllowEdit = False
        Me.desc.Visible = True
        Me.desc.VisibleIndex = 2
        '
        'txtSign
        '
        Me.txtSign.Location = New System.Drawing.Point(16, 266)
        Me.txtSign.Name = "txtSign"
        Me.txtSign.Size = New System.Drawing.Size(233, 173)
        Me.txtSign.StyleController = Me.LayoutControl1
        Me.txtSign.TabIndex = 39
        '
        'txtMaxTicket
        '
        Me.txtMaxTicket.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtMaxTicket.Location = New System.Drawing.Point(53, 210)
        Me.txtMaxTicket.Name = "txtMaxTicket"
        Me.txtMaxTicket.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtMaxTicket.Size = New System.Drawing.Size(196, 20)
        Me.txtMaxTicket.StyleController = Me.LayoutControl1
        Me.txtMaxTicket.TabIndex = 38
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(538, 185)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Properties.Items.AddRange(New Object() {"Black", "Blue", "Caramel", "iMaginary", "Lilian", "The Asphalt World"})
        Me.ComboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(86, 20)
        Me.ComboBoxEdit1.StyleController = Me.LayoutControl1
        Me.ComboBoxEdit1.TabIndex = 37
        '
        'txtAPIPassword
        '
        Me.txtAPIPassword.Location = New System.Drawing.Point(53, 154)
        Me.txtAPIPassword.Name = "txtAPIPassword"
        Me.txtAPIPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAPIPassword.Size = New System.Drawing.Size(571, 20)
        Me.txtAPIPassword.StyleController = Me.LayoutControl1
        Me.txtAPIPassword.TabIndex = 36
        '
        'txtAPIUsername
        '
        Me.txtAPIUsername.Location = New System.Drawing.Point(53, 123)
        Me.txtAPIUsername.Name = "txtAPIUsername"
        Me.txtAPIUsername.Size = New System.Drawing.Size(571, 20)
        Me.txtAPIUsername.StyleController = Me.LayoutControl1
        Me.txtAPIUsername.TabIndex = 35
        '
        'txtAPIAddress
        '
        Me.txtAPIAddress.Location = New System.Drawing.Point(53, 92)
        Me.txtAPIAddress.Name = "txtAPIAddress"
        Me.txtAPIAddress.Size = New System.Drawing.Size(571, 20)
        Me.txtAPIAddress.StyleController = Me.LayoutControl1
        Me.txtAPIAddress.TabIndex = 34
        '
        'txtTransparent
        '
        Me.txtTransparent.EditValue = 30
        Me.txtTransparent.Location = New System.Drawing.Point(297, 182)
        Me.txtTransparent.Name = "txtTransparent"
        Me.txtTransparent.Properties.Maximum = 100
        Me.txtTransparent.Properties.Minimum = 30
        Me.txtTransparent.Properties.TickFrequency = 5
        Me.txtTransparent.Size = New System.Drawing.Size(193, 45)
        Me.txtTransparent.StyleController = Me.LayoutControl1
        Me.txtTransparent.TabIndex = 24
        Me.txtTransparent.Value = 30
        '
        'txtRefreshRate
        '
        Me.txtRefreshRate.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRefreshRate.Location = New System.Drawing.Point(53, 182)
        Me.txtRefreshRate.Name = "txtRefreshRate"
        Me.txtRefreshRate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtRefreshRate.Size = New System.Drawing.Size(196, 20)
        Me.txtRefreshRate.StyleController = Me.LayoutControl1
        Me.txtRefreshRate.TabIndex = 23
        '
        'txtWHMCSAddress
        '
        Me.txtWHMCSAddress.Location = New System.Drawing.Point(53, 64)
        Me.txtWHMCSAddress.Name = "txtWHMCSAddress"
        Me.txtWHMCSAddress.Size = New System.Drawing.Size(571, 20)
        Me.txtWHMCSAddress.StyleController = Me.LayoutControl1
        Me.txtWHMCSAddress.TabIndex = 8
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.TabbedControlGroup1, Me.LayoutControlItem28, Me.LayoutControlItem29, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(642, 498)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'TabbedControlGroup1
        '
        Me.TabbedControlGroup1.CustomizationFormText = "TabbedControlGroup1"
        Me.TabbedControlGroup1.Location = New System.Drawing.Point(0, 29)
        Me.TabbedControlGroup1.Name = "TabbedControlGroup1"
        Me.TabbedControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.TabbedControlGroup1.SelectedTabPage = Me.tabGeneral
        Me.TabbedControlGroup1.SelectedTabPageIndex = 0
        Me.TabbedControlGroup1.Size = New System.Drawing.Size(640, 467)
        Me.TabbedControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
        Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.tabGeneral, Me.tabLanguage})
        Me.TabbedControlGroup1.Text = "TabbedControlGroup1"
        '
        'tabGeneral
        '
        Me.tabGeneral.CustomizationFormText = "####"
        Me.tabGeneral.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lblWAdminAdd, Me.lblWApiAdd, Me.lblApiUsername, Me.lblApiPassword, Me.lblRefreshRate, Me.lblSkin, Me.lblTranparentRate, Me.lblMaxTicket, Me.EmptySpaceItem3, Me.lblSignature})
        Me.tabGeneral.Location = New System.Drawing.Point(0, 0)
        Me.tabGeneral.Name = "tabGeneral"
        Me.tabGeneral.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.tabGeneral.Size = New System.Drawing.Size(619, 424)
        Me.tabGeneral.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.tabGeneral.Text = "####"
        '
        'lblWAdminAdd
        '
        Me.lblWAdminAdd.Control = Me.txtWHMCSAddress
        Me.lblWAdminAdd.CustomizationFormText = "WHMCS Address"
        Me.lblWAdminAdd.Location = New System.Drawing.Point(0, 0)
        Me.lblWAdminAdd.Name = "lblWAdminAdd"
        Me.lblWAdminAdd.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 2, 2)
        Me.lblWAdminAdd.Size = New System.Drawing.Size(619, 25)
        Me.lblWAdminAdd.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lblWAdminAdd.Text = "####"
        Me.lblWAdminAdd.TextSize = New System.Drawing.Size(32, 20)
        '
        'lblWApiAdd
        '
        Me.lblWApiAdd.Control = Me.txtAPIAddress
        Me.lblWApiAdd.CustomizationFormText = "API Address"
        Me.lblWApiAdd.Location = New System.Drawing.Point(0, 25)
        Me.lblWApiAdd.Name = "lblWApiAdd"
        Me.lblWApiAdd.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lblWApiAdd.Size = New System.Drawing.Size(619, 31)
        Me.lblWApiAdd.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lblWApiAdd.Text = "####"
        Me.lblWApiAdd.TextSize = New System.Drawing.Size(32, 20)
        '
        'lblApiUsername
        '
        Me.lblApiUsername.Control = Me.txtAPIUsername
        Me.lblApiUsername.CustomizationFormText = "API Username"
        Me.lblApiUsername.Location = New System.Drawing.Point(0, 56)
        Me.lblApiUsername.Name = "lblApiUsername"
        Me.lblApiUsername.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lblApiUsername.Size = New System.Drawing.Size(619, 31)
        Me.lblApiUsername.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lblApiUsername.Text = "####"
        Me.lblApiUsername.TextSize = New System.Drawing.Size(32, 20)
        '
        'lblApiPassword
        '
        Me.lblApiPassword.Control = Me.txtAPIPassword
        Me.lblApiPassword.CustomizationFormText = "API Password"
        Me.lblApiPassword.Location = New System.Drawing.Point(0, 87)
        Me.lblApiPassword.Name = "lblApiPassword"
        Me.lblApiPassword.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lblApiPassword.Size = New System.Drawing.Size(619, 31)
        Me.lblApiPassword.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lblApiPassword.Text = "####"
        Me.lblApiPassword.TextSize = New System.Drawing.Size(32, 20)
        '
        'lblRefreshRate
        '
        Me.lblRefreshRate.Control = Me.txtRefreshRate
        Me.lblRefreshRate.CustomizationFormText = "Refresh Rate"
        Me.lblRefreshRate.Location = New System.Drawing.Point(0, 118)
        Me.lblRefreshRate.Name = "lblRefreshRate"
        Me.lblRefreshRate.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 2, 2)
        Me.lblRefreshRate.Size = New System.Drawing.Size(244, 25)
        Me.lblRefreshRate.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lblRefreshRate.Text = "####"
        Me.lblRefreshRate.TextSize = New System.Drawing.Size(32, 20)
        '
        'lblSkin
        '
        Me.lblSkin.Control = Me.ComboBoxEdit1
        Me.lblSkin.CustomizationFormText = "Skin"
        Me.lblSkin.Location = New System.Drawing.Point(485, 118)
        Me.lblSkin.Name = "lblSkin"
        Me.lblSkin.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lblSkin.Size = New System.Drawing.Size(134, 306)
        Me.lblSkin.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lblSkin.Text = "####"
        Me.lblSkin.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.lblSkin.TextSize = New System.Drawing.Size(32, 20)
        '
        'lblTranparentRate
        '
        Me.lblTranparentRate.Control = Me.txtTransparent
        Me.lblTranparentRate.CustomizationFormText = "Transparent Rate"
        Me.lblTranparentRate.Location = New System.Drawing.Point(244, 118)
        Me.lblTranparentRate.Name = "lblTranparentRate"
        Me.lblTranparentRate.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 2, 2)
        Me.lblTranparentRate.Size = New System.Drawing.Size(241, 306)
        Me.lblTranparentRate.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lblTranparentRate.Text = "####"
        Me.lblTranparentRate.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.lblTranparentRate.TextSize = New System.Drawing.Size(32, 20)
        '
        'lblMaxTicket
        '
        Me.lblMaxTicket.Control = Me.txtMaxTicket
        Me.lblMaxTicket.CustomizationFormText = "Max. Ticket View (If zero is unlimited)"
        Me.lblMaxTicket.Location = New System.Drawing.Point(0, 143)
        Me.lblMaxTicket.Name = "lblMaxTicket"
        Me.lblMaxTicket.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lblMaxTicket.Size = New System.Drawing.Size(244, 31)
        Me.lblMaxTicket.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lblMaxTicket.Text = "####"
        Me.lblMaxTicket.TextSize = New System.Drawing.Size(32, 20)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 383)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(244, 41)
        Me.EmptySpaceItem3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'lblSignature
        '
        Me.lblSignature.Control = Me.txtSign
        Me.lblSignature.CustomizationFormText = "Your Sign"
        Me.lblSignature.Location = New System.Drawing.Point(0, 174)
        Me.lblSignature.Name = "lblSignature"
        Me.lblSignature.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lblSignature.Size = New System.Drawing.Size(244, 209)
        Me.lblSignature.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lblSignature.Text = "####"
        Me.lblSignature.TextLocation = DevExpress.Utils.Locations.Top
        Me.lblSignature.TextSize = New System.Drawing.Size(32, 20)
        '
        'tabLanguage
        '
        Me.tabLanguage.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tabLanguage.AppearanceGroup.Options.UseFont = True
        Me.tabLanguage.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tabLanguage.AppearanceItemCaption.Options.UseFont = True
        Me.tabLanguage.CustomizationFormText = "Language Settings"
        Me.tabLanguage.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4})
        Me.tabLanguage.Location = New System.Drawing.Point(0, 0)
        Me.tabLanguage.Name = "tabLanguage"
        Me.tabLanguage.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.tabLanguage.Size = New System.Drawing.Size(619, 424)
        Me.tabLanguage.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.tabLanguage.Text = "####"
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.GridControl1
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem4.Size = New System.Drawing.Size(619, 424)
        Me.LayoutControlItem4.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlItem4.Text = "LayoutControlItem4"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem28
        '
        Me.LayoutControlItem28.Control = Me.cmdSave
        Me.LayoutControlItem28.CustomizationFormText = "Save"
        Me.LayoutControlItem28.Location = New System.Drawing.Point(466, 0)
        Me.LayoutControlItem28.MinSize = New System.Drawing.Size(48, 27)
        Me.LayoutControlItem28.Name = "LayoutControlItem28"
        Me.LayoutControlItem28.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 2, 2)
        Me.LayoutControlItem28.Size = New System.Drawing.Size(87, 29)
        Me.LayoutControlItem28.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem28.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlItem28.Text = "Save"
        Me.LayoutControlItem28.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem28.TextToControlDistance = 0
        Me.LayoutControlItem28.TextVisible = False
        '
        'LayoutControlItem29
        '
        Me.LayoutControlItem29.Control = Me.cmdClose
        Me.LayoutControlItem29.CustomizationFormText = "LayoutControlItem29"
        Me.LayoutControlItem29.Location = New System.Drawing.Point(553, 0)
        Me.LayoutControlItem29.Name = "LayoutControlItem29"
        Me.LayoutControlItem29.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 2, 2)
        Me.LayoutControlItem29.Size = New System.Drawing.Size(87, 29)
        Me.LayoutControlItem29.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlItem29.Text = "LayoutControlItem29"
        Me.LayoutControlItem29.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem29.TextToControlDistance = 0
        Me.LayoutControlItem29.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(466, 29)
        Me.EmptySpaceItem1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 498)
        Me.Controls.Add(Me.LayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSetup"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "####"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSign.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaxTicket.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAPIPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAPIUsername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAPIAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTransparent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRefreshRate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWHMCSAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblWAdminAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblWApiAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblApiUsername, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblApiPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRefreshRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSkin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTranparentRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMaxTicket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSignature, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabLanguage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtWHMCSAddress As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTransparent As DevExpress.XtraEditors.TrackBarControl
    Friend WithEvents txtRefreshRate As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtAPIPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAPIUsername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAPIAddress As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
    Friend WithEvents tabLanguage As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents tabGeneral As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lblWAdminAdd As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lblTranparentRate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lblWApiAdd As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lblApiUsername As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lblApiPassword As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lblRefreshRate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblSkin As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtMaxTicket As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lblMaxTicket As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtSign As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents lblSignature As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents english As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents newvalue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents desc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
End Class
