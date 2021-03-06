namespace Tasker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ControlsPanelControl = new DevExpress.XtraEditors.PanelControl();
            this.listsSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.delAllSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ndtSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.showDoneListSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.minControlsSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.deleteTaskSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.addTaskSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.tasksGridControl = new DevExpress.XtraGrid.GridControl();
            this.tasksContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.moveToOtherListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasksGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.doneGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.taskDoneRepositoryItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.taskGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.showControlsSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.functionalityPanelControl = new DevExpress.XtraEditors.PanelControl();
            this.functionalityLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.statusBarNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIconContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.summarizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summarizeCurrentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summarizeAllListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskStatusStrip = new System.Windows.Forms.StatusStrip();
            this.jumpListsToolStripSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.listToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.NotasksToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LabelsToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.UrgentPToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.normalPToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.minPToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ControlsPanelControl)).BeginInit();
            this.ControlsPanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tasksGridControl)).BeginInit();
            this.tasksContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tasksGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskDoneRepositoryItemCheckEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionalityPanelControl)).BeginInit();
            this.functionalityPanelControl.SuspendLayout();
            this.notifyIconContextMenuStrip.SuspendLayout();
            this.taskStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlsPanelControl
            // 
            this.ControlsPanelControl.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.ControlsPanelControl.Appearance.Options.UseBackColor = true;
            this.ControlsPanelControl.Controls.Add(this.listsSimpleButton);
            this.ControlsPanelControl.Controls.Add(this.delAllSimpleButton);
            this.ControlsPanelControl.Controls.Add(this.ndtSimpleButton);
            this.ControlsPanelControl.Controls.Add(this.showDoneListSimpleButton);
            this.ControlsPanelControl.Controls.Add(this.minControlsSimpleButton);
            this.ControlsPanelControl.Controls.Add(this.deleteTaskSimpleButton);
            this.ControlsPanelControl.Controls.Add(this.addTaskSimpleButton);
            this.ControlsPanelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlsPanelControl.Location = new System.Drawing.Point(0, 0);
            this.ControlsPanelControl.Name = "ControlsPanelControl";
            this.ControlsPanelControl.Size = new System.Drawing.Size(292, 34);
            this.ControlsPanelControl.TabIndex = 2;
            // 
            // listsSimpleButton
            // 
            this.listsSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.listsSimpleButton.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.listsSimpleButton.Appearance.Options.UseFont = true;
            this.listsSimpleButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.listsSimpleButton.Location = new System.Drawing.Point(104, 5);
            this.listsSimpleButton.Name = "listsSimpleButton";
            this.listsSimpleButton.Size = new System.Drawing.Size(27, 22);
            this.listsSimpleButton.TabIndex = 8;
            this.listsSimpleButton.TabStop = false;
            this.listsSimpleButton.Text = "Ξ";
            this.listsSimpleButton.MouseLeave += new System.EventHandler(this.listsSimpleButton_MouseLeave);
            this.listsSimpleButton.Click += new System.EventHandler(this.listsSimpleButton_Click);
            this.listsSimpleButton.MouseEnter += new System.EventHandler(this.listsSimpleButton_MouseEnter);
            // 
            // delAllSimpleButton
            // 
            this.delAllSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.delAllSimpleButton.Appearance.Font = new System.Drawing.Font("Tahoma", 7.5F);
            this.delAllSimpleButton.Appearance.Options.UseFont = true;
            this.delAllSimpleButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.delAllSimpleButton.Location = new System.Drawing.Point(137, 5);
            this.delAllSimpleButton.Name = "delAllSimpleButton";
            this.delAllSimpleButton.Size = new System.Drawing.Size(27, 22);
            this.delAllSimpleButton.TabIndex = 7;
            this.delAllSimpleButton.TabStop = false;
            this.delAllSimpleButton.Text = "‼";
            this.delAllSimpleButton.MouseLeave += new System.EventHandler(this.delAllSimpleButton_MouseLeave);
            this.delAllSimpleButton.Click += new System.EventHandler(this.delAllSimpleButton_Click);
            this.delAllSimpleButton.MouseEnter += new System.EventHandler(this.delAllSimpleButton_MouseEnter);
            // 
            // ndtSimpleButton
            // 
            this.ndtSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ndtSimpleButton.Appearance.Font = new System.Drawing.Font("Tahoma", 7.5F);
            this.ndtSimpleButton.Appearance.Options.UseFont = true;
            this.ndtSimpleButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.ndtSimpleButton.Location = new System.Drawing.Point(203, 5);
            this.ndtSimpleButton.Name = "ndtSimpleButton";
            this.ndtSimpleButton.Size = new System.Drawing.Size(27, 22);
            this.ndtSimpleButton.TabIndex = 6;
            this.ndtSimpleButton.TabStop = false;
            this.ndtSimpleButton.Text = "₪";
            this.ndtSimpleButton.Visible = false;
            this.ndtSimpleButton.MouseLeave += new System.EventHandler(this.printSimpleButton_MouseLeave);
            this.ndtSimpleButton.MouseEnter += new System.EventHandler(this.printSimpleButton_MouseEnter);
            // 
            // showDoneListSimpleButton
            // 
            this.showDoneListSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.showDoneListSimpleButton.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.showDoneListSimpleButton.Appearance.Options.UseFont = true;
            this.showDoneListSimpleButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.showDoneListSimpleButton.Location = new System.Drawing.Point(71, 5);
            this.showDoneListSimpleButton.Name = "showDoneListSimpleButton";
            this.showDoneListSimpleButton.Size = new System.Drawing.Size(27, 22);
            this.showDoneListSimpleButton.TabIndex = 5;
            this.showDoneListSimpleButton.TabStop = false;
            this.showDoneListSimpleButton.Text = "«";
            this.showDoneListSimpleButton.MouseLeave += new System.EventHandler(this.showDoneListSimpleButton_MouseLeave);
            this.showDoneListSimpleButton.Click += new System.EventHandler(this.showDoneListSimpleButton_Click);
            this.showDoneListSimpleButton.MouseEnter += new System.EventHandler(this.showDoneListSimpleButton_MouseEnter);
            // 
            // minControlsSimpleButton
            // 
            this.minControlsSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.minControlsSimpleButton.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.minControlsSimpleButton.Appearance.Options.UseFont = true;
            this.minControlsSimpleButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.minControlsSimpleButton.Location = new System.Drawing.Point(170, 5);
            this.minControlsSimpleButton.Name = "minControlsSimpleButton";
            this.minControlsSimpleButton.Size = new System.Drawing.Size(27, 22);
            this.minControlsSimpleButton.TabIndex = 4;
            this.minControlsSimpleButton.TabStop = false;
            this.minControlsSimpleButton.Text = "◦";
            this.minControlsSimpleButton.MouseLeave += new System.EventHandler(this.minControlsSimpleButton_MouseLeave);
            this.minControlsSimpleButton.Click += new System.EventHandler(this.MinPanelSimpleButton_Click);
            this.minControlsSimpleButton.MouseEnter += new System.EventHandler(this.minControlsSimpleButton_MouseEnter);
            // 
            // deleteTaskSimpleButton
            // 
            this.deleteTaskSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deleteTaskSimpleButton.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.deleteTaskSimpleButton.Appearance.Options.UseFont = true;
            this.deleteTaskSimpleButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.deleteTaskSimpleButton.Location = new System.Drawing.Point(38, 5);
            this.deleteTaskSimpleButton.Name = "deleteTaskSimpleButton";
            this.deleteTaskSimpleButton.Size = new System.Drawing.Size(27, 22);
            this.deleteTaskSimpleButton.TabIndex = 1;
            this.deleteTaskSimpleButton.TabStop = false;
            this.deleteTaskSimpleButton.Text = "-";
            this.deleteTaskSimpleButton.MouseLeave += new System.EventHandler(this.deleteTaskSimpleButton_MouseLeave);
            this.deleteTaskSimpleButton.Click += new System.EventHandler(this.deleteTaskSimpleButton_Click);
            this.deleteTaskSimpleButton.MouseEnter += new System.EventHandler(this.deleteTaskSimpleButton_MouseEnter);
            // 
            // addTaskSimpleButton
            // 
            this.addTaskSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addTaskSimpleButton.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.addTaskSimpleButton.Appearance.Options.UseFont = true;
            this.addTaskSimpleButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.addTaskSimpleButton.Location = new System.Drawing.Point(5, 5);
            this.addTaskSimpleButton.Name = "addTaskSimpleButton";
            this.addTaskSimpleButton.Size = new System.Drawing.Size(27, 22);
            this.addTaskSimpleButton.TabIndex = 0;
            this.addTaskSimpleButton.TabStop = false;
            this.addTaskSimpleButton.Text = "+";
            this.addTaskSimpleButton.MouseLeave += new System.EventHandler(this.addTaskSimpleButton_MouseLeave);
            this.addTaskSimpleButton.Click += new System.EventHandler(this.addTaskSimpleButton_Click);
            this.addTaskSimpleButton.MouseEnter += new System.EventHandler(this.addTaskSimpleButton_MouseEnter);
            // 
            // tasksGridControl
            // 
            this.tasksGridControl.ContextMenuStrip = this.tasksContextMenuStrip;
            this.tasksGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tasksGridControl.EmbeddedNavigator.Name = "";
            this.tasksGridControl.Location = new System.Drawing.Point(0, 34);
            this.tasksGridControl.MainView = this.tasksGridView;
            this.tasksGridControl.Name = "tasksGridControl";
            this.tasksGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.taskDoneRepositoryItemCheckEdit});
            this.tasksGridControl.Size = new System.Drawing.Size(292, 336);
            this.tasksGridControl.TabIndex = 3;
            this.tasksGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tasksGridView});
            this.tasksGridControl.DoubleClick += new System.EventHandler(this.tasksGridControl_DoubleClick);
            this.tasksGridControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tasksGridControl_KeyDown);
            // 
            // tasksContextMenuStrip
            // 
            this.tasksContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.tasksContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveToOtherListToolStripMenuItem});
            this.tasksContextMenuStrip.Name = "tasksContextMenuStrip";
            this.tasksContextMenuStrip.ShowImageMargin = false;
            this.tasksContextMenuStrip.Size = new System.Drawing.Size(145, 26);
            // 
            // moveToOtherListToolStripMenuItem
            // 
            this.moveToOtherListToolStripMenuItem.Name = "moveToOtherListToolStripMenuItem";
            this.moveToOtherListToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.moveToOtherListToolStripMenuItem.Text = "Move to other list";
            this.moveToOtherListToolStripMenuItem.Click += new System.EventHandler(this.moveToOtherListToolStripMenuItem_Click);
            // 
            // tasksGridView
            // 
            this.tasksGridView.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.tasksGridView.Appearance.Empty.Options.UseBackColor = true;
            this.tasksGridView.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tasksGridView.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.tasksGridView.Appearance.EvenRow.Options.UseBackColor = true;
            this.tasksGridView.Appearance.EvenRow.Options.UseForeColor = true;
            this.tasksGridView.Appearance.OddRow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tasksGridView.Appearance.OddRow.Options.UseBackColor = true;
            this.tasksGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.doneGridColumn,
            this.taskGridColumn});
            this.tasksGridView.GridControl = this.tasksGridControl;
            this.tasksGridView.Name = "tasksGridView";
            this.tasksGridView.OptionsCustomization.AllowColumnMoving = false;
            this.tasksGridView.OptionsCustomization.AllowColumnResizing = false;
            this.tasksGridView.OptionsCustomization.AllowFilter = false;
            this.tasksGridView.OptionsCustomization.AllowGroup = false;
            this.tasksGridView.OptionsCustomization.AllowSort = false;
            this.tasksGridView.OptionsNavigation.UseTabKey = false;
            this.tasksGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.tasksGridView.OptionsView.EnableAppearanceEvenRow = true;
            this.tasksGridView.OptionsView.EnableAppearanceOddRow = true;
            this.tasksGridView.OptionsView.ShowColumnHeaders = false;
            this.tasksGridView.OptionsView.ShowGroupPanel = false;
            this.tasksGridView.OptionsView.ShowIndicator = false;
            this.tasksGridView.RowHeight = 20;
            // 
            // doneGridColumn
            // 
            this.doneGridColumn.Caption = "done";
            this.doneGridColumn.ColumnEdit = this.taskDoneRepositoryItemCheckEdit;
            this.doneGridColumn.FieldName = "done";
            this.doneGridColumn.Name = "doneGridColumn";
            this.doneGridColumn.Visible = true;
            this.doneGridColumn.VisibleIndex = 0;
            this.doneGridColumn.Width = 20;
            // 
            // taskDoneRepositoryItemCheckEdit
            // 
            this.taskDoneRepositoryItemCheckEdit.AutoHeight = false;
            this.taskDoneRepositoryItemCheckEdit.Name = "taskDoneRepositoryItemCheckEdit";
            this.taskDoneRepositoryItemCheckEdit.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.taskDoneRepositoryItemCheckEdit.CheckedChanged += new System.EventHandler(this.taskDoneRepositoryItemCheckEdit_CheckedChanged);
            // 
            // taskGridColumn
            // 
            this.taskGridColumn.Caption = "task";
            this.taskGridColumn.FieldName = "name";
            this.taskGridColumn.Name = "taskGridColumn";
            this.taskGridColumn.OptionsColumn.AllowEdit = false;
            this.taskGridColumn.Visible = true;
            this.taskGridColumn.VisibleIndex = 1;
            this.taskGridColumn.Width = 268;
            // 
            // showControlsSimpleButton
            // 
            this.showControlsSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.showControlsSimpleButton.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.showControlsSimpleButton.Appearance.Options.UseFont = true;
            this.showControlsSimpleButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.showControlsSimpleButton.Location = new System.Drawing.Point(260, 343);
            this.showControlsSimpleButton.Name = "showControlsSimpleButton";
            this.showControlsSimpleButton.Size = new System.Drawing.Size(27, 22);
            this.showControlsSimpleButton.TabIndex = 5;
            this.showControlsSimpleButton.Text = "●";
            this.showControlsSimpleButton.MouseLeave += new System.EventHandler(this.showControlsSimpleButton_MouseLeave);
            this.showControlsSimpleButton.Click += new System.EventHandler(this.showControlsSimpleButton_Click);
            this.showControlsSimpleButton.MouseEnter += new System.EventHandler(this.showControlsSimpleButton_MouseEnter);
            // 
            // functionalityPanelControl
            // 
            this.functionalityPanelControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.functionalityPanelControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.functionalityPanelControl.Appearance.ForeColor = System.Drawing.Color.Black;
            this.functionalityPanelControl.Appearance.Options.UseBackColor = true;
            this.functionalityPanelControl.Appearance.Options.UseForeColor = true;
            this.functionalityPanelControl.Controls.Add(this.functionalityLabelControl);
            this.functionalityPanelControl.Location = new System.Drawing.Point(5, 324);
            this.functionalityPanelControl.Name = "functionalityPanelControl";
            this.functionalityPanelControl.Size = new System.Drawing.Size(249, 20);
            this.functionalityPanelControl.TabIndex = 6;
            // 
            // functionalityLabelControl
            // 
            this.functionalityLabelControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.functionalityLabelControl.Appearance.ForeColor = System.Drawing.Color.Black;
            this.functionalityLabelControl.Appearance.Options.UseBackColor = true;
            this.functionalityLabelControl.Appearance.Options.UseForeColor = true;
            this.functionalityLabelControl.Location = new System.Drawing.Point(4, 4);
            this.functionalityLabelControl.Name = "functionalityLabelControl";
            this.functionalityLabelControl.Size = new System.Drawing.Size(61, 13);
            this.functionalityLabelControl.TabIndex = 0;
            this.functionalityLabelControl.Text = "!@#$%^*()";
            // 
            // statusBarNotifyIcon
            // 
            this.statusBarNotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.statusBarNotifyIcon.ContextMenuStrip = this.notifyIconContextMenuStrip;
            this.statusBarNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("statusBarNotifyIcon.Icon")));
            this.statusBarNotifyIcon.Text = "Tasker";
            this.statusBarNotifyIcon.Visible = true;
            this.statusBarNotifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.statusBarNotifyIcon_MouseClick);
            this.statusBarNotifyIcon.DoubleClick += new System.EventHandler(this.statusBarNotifyIcon_DoubleClick);
            // 
            // notifyIconContextMenuStrip
            // 
            this.notifyIconContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.notifyIconContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summarizeToolStripMenuItem});
            this.notifyIconContextMenuStrip.Name = "notifyIconContextMenuStrip";
            this.notifyIconContextMenuStrip.ShowImageMargin = false;
            this.notifyIconContextMenuStrip.Size = new System.Drawing.Size(112, 26);
            // 
            // summarizeToolStripMenuItem
            // 
            this.summarizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summarizeCurrentListToolStripMenuItem,
            this.summarizeAllListsToolStripMenuItem});
            this.summarizeToolStripMenuItem.Name = "summarizeToolStripMenuItem";
            this.summarizeToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.summarizeToolStripMenuItem.Text = "&Summarize";
            // 
            // summarizeCurrentListToolStripMenuItem
            // 
            this.summarizeCurrentListToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.summarizeCurrentListToolStripMenuItem.Name = "summarizeCurrentListToolStripMenuItem";
            this.summarizeCurrentListToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.summarizeCurrentListToolStripMenuItem.Text = "Summarize current list";
            this.summarizeCurrentListToolStripMenuItem.Click += new System.EventHandler(this.summarizeCurrentListToolStripMenuItem_Click);
            // 
            // summarizeAllListsToolStripMenuItem
            // 
            this.summarizeAllListsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.summarizeAllListsToolStripMenuItem.Name = "summarizeAllListsToolStripMenuItem";
            this.summarizeAllListsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.summarizeAllListsToolStripMenuItem.Text = "Summarize all lists";
            this.summarizeAllListsToolStripMenuItem.Click += new System.EventHandler(this.summarizeAllListsToolStripMenuItem_Click);
            // 
            // taskStatusStrip
            // 
            this.taskStatusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.taskStatusStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.taskStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jumpListsToolStripSplitButton,
            this.toolStripStatusLabel3,
            this.listToolStripStatusLabel,
            this.toolStripStatusLabel2,
            this.NotasksToolStripStatusLabel,
            this.LabelsToolStripStatusLabel,
            this.toolStripStatusLabel1,
            this.UrgentPToolStripStatusLabel,
            this.normalPToolStripStatusLabel,
            this.minPToolStripStatusLabel});
            this.taskStatusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.taskStatusStrip.Location = new System.Drawing.Point(0, 351);
            this.taskStatusStrip.Name = "taskStatusStrip";
            this.taskStatusStrip.Size = new System.Drawing.Size(292, 19);
            this.taskStatusStrip.TabIndex = 7;
            // 
            // jumpListsToolStripSplitButton
            // 
            this.jumpListsToolStripSplitButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.jumpListsToolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.jumpListsToolStripSplitButton.ForeColor = System.Drawing.Color.Black;
            this.jumpListsToolStripSplitButton.Image = ((System.Drawing.Image)(resources.GetObject("jumpListsToolStripSplitButton.Image")));
            this.jumpListsToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.jumpListsToolStripSplitButton.Name = "jumpListsToolStripSplitButton";
            this.jumpListsToolStripSplitButton.Size = new System.Drawing.Size(61, 17);
            this.jumpListsToolStripSplitButton.Text = "Jump to";
            this.jumpListsToolStripSplitButton.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.jumpListsToolStripSplitButton_DropDownItemClicked);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(10, 13);
            this.toolStripStatusLabel3.Text = " ";
            // 
            // listToolStripStatusLabel
            // 
            this.listToolStripStatusLabel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.listToolStripStatusLabel.ForeColor = System.Drawing.Color.White;
            this.listToolStripStatusLabel.Name = "listToolStripStatusLabel";
            this.listToolStripStatusLabel.Size = new System.Drawing.Size(20, 13);
            this.listToolStripStatusLabel.Text = "list";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 13);
            this.toolStripStatusLabel2.Text = " ";
            // 
            // NotasksToolStripStatusLabel
            // 
            this.NotasksToolStripStatusLabel.BackColor = System.Drawing.Color.Crimson;
            this.NotasksToolStripStatusLabel.ForeColor = System.Drawing.Color.LavenderBlush;
            this.NotasksToolStripStatusLabel.Name = "NotasksToolStripStatusLabel";
            this.NotasksToolStripStatusLabel.Size = new System.Drawing.Size(101, 13);
            this.NotasksToolStripStatusLabel.Text = "No Tasks on this list";
            this.NotasksToolStripStatusLabel.Visible = false;
            // 
            // LabelsToolStripStatusLabel
            // 
            this.LabelsToolStripStatusLabel.BackColor = System.Drawing.Color.Black;
            this.LabelsToolStripStatusLabel.ForeColor = System.Drawing.Color.White;
            this.LabelsToolStripStatusLabel.Name = "LabelsToolStripStatusLabel";
            this.LabelsToolStripStatusLabel.Size = new System.Drawing.Size(37, 13);
            this.LabelsToolStripStatusLabel.Text = "Labels";
            this.LabelsToolStripStatusLabel.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 13);
            this.toolStripStatusLabel1.Text = " ";
            // 
            // UrgentPToolStripStatusLabel
            // 
            this.UrgentPToolStripStatusLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.UrgentPToolStripStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.UrgentPToolStripStatusLabel.Name = "UrgentPToolStripStatusLabel";
            this.UrgentPToolStripStatusLabel.Size = new System.Drawing.Size(40, 13);
            this.UrgentPToolStripStatusLabel.Text = "Urgent";
            this.UrgentPToolStripStatusLabel.Visible = false;
            // 
            // normalPToolStripStatusLabel
            // 
            this.normalPToolStripStatusLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.normalPToolStripStatusLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.normalPToolStripStatusLabel.Name = "normalPToolStripStatusLabel";
            this.normalPToolStripStatusLabel.Size = new System.Drawing.Size(40, 13);
            this.normalPToolStripStatusLabel.Text = "Normal";
            this.normalPToolStripStatusLabel.Visible = false;
            // 
            // minPToolStripStatusLabel
            // 
            this.minPToolStripStatusLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.minPToolStripStatusLabel.ForeColor = System.Drawing.Color.DimGray;
            this.minPToolStripStatusLabel.Name = "minPToolStripStatusLabel";
            this.minPToolStripStatusLabel.Size = new System.Drawing.Size(41, 13);
            this.minPToolStripStatusLabel.Text = "Minimal";
            this.minPToolStripStatusLabel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 370);
            this.Controls.Add(this.taskStatusStrip);
            this.Controls.Add(this.functionalityPanelControl);
            this.Controls.Add(this.showControlsSimpleButton);
            this.Controls.Add(this.tasksGridControl);
            this.Controls.Add(this.ControlsPanelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 396);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tasker v2.0";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ControlsPanelControl)).EndInit();
            this.ControlsPanelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tasksGridControl)).EndInit();
            this.tasksContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tasksGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskDoneRepositoryItemCheckEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionalityPanelControl)).EndInit();
            this.functionalityPanelControl.ResumeLayout(false);
            this.functionalityPanelControl.PerformLayout();
            this.notifyIconContextMenuStrip.ResumeLayout(false);
            this.taskStatusStrip.ResumeLayout(false);
            this.taskStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl ControlsPanelControl;
        private DevExpress.XtraEditors.SimpleButton deleteTaskSimpleButton;
        private DevExpress.XtraEditors.SimpleButton addTaskSimpleButton;
        private DevExpress.XtraGrid.GridControl tasksGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView tasksGridView;
        private DevExpress.XtraGrid.Columns.GridColumn doneGridColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit taskDoneRepositoryItemCheckEdit;
        private DevExpress.XtraGrid.Columns.GridColumn taskGridColumn;
        private DevExpress.XtraEditors.SimpleButton minControlsSimpleButton;
        private DevExpress.XtraEditors.SimpleButton showControlsSimpleButton;
        private DevExpress.XtraEditors.SimpleButton showDoneListSimpleButton;
        private DevExpress.XtraEditors.PanelControl functionalityPanelControl;
        private DevExpress.XtraEditors.LabelControl functionalityLabelControl;
        private System.Windows.Forms.NotifyIcon statusBarNotifyIcon;
        private System.Windows.Forms.StatusStrip taskStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel LabelsToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel UrgentPToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel normalPToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel minPToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ContextMenuStrip notifyIconContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem summarizeToolStripMenuItem;
        private DevExpress.XtraEditors.SimpleButton delAllSimpleButton;
        private DevExpress.XtraEditors.SimpleButton listsSimpleButton;
        private System.Windows.Forms.ToolStripStatusLabel listToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel NotasksToolStripStatusLabel;
        private System.Windows.Forms.ToolStripSplitButton jumpListsToolStripSplitButton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ContextMenuStrip tasksContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem moveToOtherListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summarizeCurrentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summarizeAllListsToolStripMenuItem;
        private DevExpress.XtraEditors.SimpleButton ndtSimpleButton;

    }
}