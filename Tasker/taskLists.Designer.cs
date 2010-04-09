namespace Tasker
{
    partial class taskLists
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
            this.listsGridControl = new DevExpress.XtraGrid.GridControl();
            this.addRemoveContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.listGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AddModifyListGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.addListSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.listNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.listsGridControl)).BeginInit();
            this.addRemoveContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddModifyListGroupControl)).BeginInit();
            this.AddModifyListGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listNameTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // listsGridControl
            // 
            this.listsGridControl.ContextMenuStrip = this.addRemoveContextMenuStrip;
            this.listsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listsGridControl.EmbeddedNavigator.Name = "";
            this.listsGridControl.Location = new System.Drawing.Point(0, 0);
            this.listsGridControl.MainView = this.listsGridView;
            this.listsGridControl.Name = "listsGridControl";
            this.listsGridControl.Size = new System.Drawing.Size(206, 247);
            this.listsGridControl.TabIndex = 0;
            this.listsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.listsGridView});
            this.listsGridControl.DoubleClick += new System.EventHandler(this.listsGridControl_DoubleClick);
            // 
            // addRemoveContextMenuStrip
            // 
            this.addRemoveContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeListToolStripMenuItem,
            this.modifyListToolStripMenuItem});
            this.addRemoveContextMenuStrip.Name = "addRemoveContextMenuStrip";
            this.addRemoveContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.addRemoveContextMenuStrip.ShowImageMargin = false;
            this.addRemoveContextMenuStrip.Size = new System.Drawing.Size(116, 70);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.addToolStripMenuItem.Text = "&Add a list";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeListToolStripMenuItem
            // 
            this.removeListToolStripMenuItem.Name = "removeListToolStripMenuItem";
            this.removeListToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.removeListToolStripMenuItem.Text = "&Remove list";
            this.removeListToolStripMenuItem.Click += new System.EventHandler(this.removeListToolStripMenuItem_Click);
            // 
            // modifyListToolStripMenuItem
            // 
            this.modifyListToolStripMenuItem.Name = "modifyListToolStripMenuItem";
            this.modifyListToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.modifyListToolStripMenuItem.Text = "&Modify list";
            this.modifyListToolStripMenuItem.Click += new System.EventHandler(this.modifyListToolStripMenuItem_Click);
            // 
            // listsGridView
            // 
            this.listsGridView.Appearance.EvenRow.BackColor = System.Drawing.Color.Gainsboro;
            this.listsGridView.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.listsGridView.Appearance.EvenRow.Options.UseBackColor = true;
            this.listsGridView.Appearance.EvenRow.Options.UseForeColor = true;
            this.listsGridView.Appearance.OddRow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listsGridView.Appearance.OddRow.Options.UseBackColor = true;
            this.listsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.listGridColumn});
            this.listsGridView.GridControl = this.listsGridControl;
            this.listsGridView.Name = "listsGridView";
            this.listsGridView.OptionsCustomization.AllowColumnMoving = false;
            this.listsGridView.OptionsCustomization.AllowColumnResizing = false;
            this.listsGridView.OptionsCustomization.AllowFilter = false;
            this.listsGridView.OptionsCustomization.AllowGroup = false;
            this.listsGridView.OptionsCustomization.AllowSort = false;
            this.listsGridView.OptionsNavigation.UseTabKey = false;
            this.listsGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.listsGridView.OptionsView.EnableAppearanceEvenRow = true;
            this.listsGridView.OptionsView.EnableAppearanceOddRow = true;
            this.listsGridView.OptionsView.ShowColumnHeaders = false;
            this.listsGridView.OptionsView.ShowGroupPanel = false;
            this.listsGridView.OptionsView.ShowIndicator = false;
            this.listsGridView.RowHeight = 20;
            // 
            // listGridColumn
            // 
            this.listGridColumn.Caption = "list";
            this.listGridColumn.FieldName = "name";
            this.listGridColumn.Name = "listGridColumn";
            this.listGridColumn.OptionsColumn.AllowEdit = false;
            this.listGridColumn.Visible = true;
            this.listGridColumn.VisibleIndex = 0;
            this.listGridColumn.Width = 268;
            // 
            // AddModifyListGroupControl
            // 
            this.AddModifyListGroupControl.Controls.Add(this.addListSimpleButton);
            this.AddModifyListGroupControl.Controls.Add(this.listNameTextEdit);
            this.AddModifyListGroupControl.Location = new System.Drawing.Point(5, 78);
            this.AddModifyListGroupControl.Name = "AddModifyListGroupControl";
            this.AddModifyListGroupControl.Size = new System.Drawing.Size(198, 50);
            this.AddModifyListGroupControl.TabIndex = 1;
            this.AddModifyListGroupControl.Text = "Add a list";
            // 
            // addListSimpleButton
            // 
            this.addListSimpleButton.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.addListSimpleButton.Appearance.Options.UseFont = true;
            this.addListSimpleButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.addListSimpleButton.Location = new System.Drawing.Point(166, 24);
            this.addListSimpleButton.Name = "addListSimpleButton";
            this.addListSimpleButton.Size = new System.Drawing.Size(27, 22);
            this.addListSimpleButton.TabIndex = 1;
            this.addListSimpleButton.Text = "+";
            this.addListSimpleButton.Click += new System.EventHandler(this.addListSimpleButton_Click);
            // 
            // listNameTextEdit
            // 
            this.listNameTextEdit.Location = new System.Drawing.Point(5, 25);
            this.listNameTextEdit.Name = "listNameTextEdit";
            this.listNameTextEdit.Size = new System.Drawing.Size(155, 20);
            this.listNameTextEdit.TabIndex = 0;
            this.listNameTextEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listNameTextEdit_KeyDown);
            // 
            // taskLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 247);
            this.Controls.Add(this.AddModifyListGroupControl);
            this.Controls.Add(this.listsGridControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "taskLists";
            this.Text = " Lists";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.taskLists_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.taskLists_KeyDown);
            this.Load += new System.EventHandler(this.taskLists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listsGridControl)).EndInit();
            this.addRemoveContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddModifyListGroupControl)).EndInit();
            this.AddModifyListGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listNameTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl listsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView listsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn listGridColumn;
        private DevExpress.XtraEditors.GroupControl AddModifyListGroupControl;
        private DevExpress.XtraEditors.TextEdit listNameTextEdit;
        private DevExpress.XtraEditors.SimpleButton addListSimpleButton;
        private System.Windows.Forms.ContextMenuStrip addRemoveContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyListToolStripMenuItem;


    }
}