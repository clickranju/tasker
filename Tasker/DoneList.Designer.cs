namespace Tasker
{
    partial class DoneList
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.doneTasksGridControl = new DevExpress.XtraGrid.GridControl();
            this.doneTasksGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.doneGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.taskDoneRepositoryItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.taskGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.delDoneTaskSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.removeAllDoneTasksSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.closeDoneTasksSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doneTasksGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doneTasksGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskDoneRepositoryItemCheckEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.doneTasksGridControl);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(263, 266);
            this.panelControl1.TabIndex = 0;
            // 
            // doneTasksGridControl
            // 
            this.doneTasksGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doneTasksGridControl.EmbeddedNavigator.Name = "";
            this.doneTasksGridControl.Location = new System.Drawing.Point(2, 36);
            this.doneTasksGridControl.MainView = this.doneTasksGridView;
            this.doneTasksGridControl.Name = "doneTasksGridControl";
            this.doneTasksGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.taskDoneRepositoryItemCheckEdit});
            this.doneTasksGridControl.Size = new System.Drawing.Size(259, 228);
            this.doneTasksGridControl.TabIndex = 6;
            this.doneTasksGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.doneTasksGridView});
            // 
            // doneTasksGridView
            // 
            this.doneTasksGridView.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.doneTasksGridView.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.doneTasksGridView.Appearance.EvenRow.Options.UseBackColor = true;
            this.doneTasksGridView.Appearance.EvenRow.Options.UseForeColor = true;
            this.doneTasksGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.doneGridColumn,
            this.taskGridColumn});
            this.doneTasksGridView.GridControl = this.doneTasksGridControl;
            this.doneTasksGridView.Name = "doneTasksGridView";
            this.doneTasksGridView.OptionsCustomization.AllowColumnMoving = false;
            this.doneTasksGridView.OptionsCustomization.AllowColumnResizing = false;
            this.doneTasksGridView.OptionsCustomization.AllowFilter = false;
            this.doneTasksGridView.OptionsCustomization.AllowGroup = false;
            this.doneTasksGridView.OptionsCustomization.AllowSort = false;
            this.doneTasksGridView.OptionsNavigation.UseTabKey = false;
            this.doneTasksGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.doneTasksGridView.OptionsView.EnableAppearanceEvenRow = true;
            this.doneTasksGridView.OptionsView.ShowColumnHeaders = false;
            this.doneTasksGridView.OptionsView.ShowGroupPanel = false;
            this.doneTasksGridView.OptionsView.ShowIndicator = false;
            this.doneTasksGridView.RowHeight = 20;
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
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.delDoneTaskSimpleButton);
            this.panelControl2.Controls.Add(this.removeAllDoneTasksSimpleButton);
            this.panelControl2.Controls.Add(this.closeDoneTasksSimpleButton);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(259, 34);
            this.panelControl2.TabIndex = 5;
            // 
            // delDoneTaskSimpleButton
            // 
            this.delDoneTaskSimpleButton.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.delDoneTaskSimpleButton.Appearance.Options.UseFont = true;
            this.delDoneTaskSimpleButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.delDoneTaskSimpleButton.Location = new System.Drawing.Point(38, 6);
            this.delDoneTaskSimpleButton.Name = "delDoneTaskSimpleButton";
            this.delDoneTaskSimpleButton.Size = new System.Drawing.Size(27, 22);
            this.delDoneTaskSimpleButton.TabIndex = 7;
            this.delDoneTaskSimpleButton.TabStop = false;
            this.delDoneTaskSimpleButton.Text = "-";
            this.delDoneTaskSimpleButton.Click += new System.EventHandler(this.delDoneTaskSimpleButton_Click);
            // 
            // removeAllDoneTasksSimpleButton
            // 
            this.removeAllDoneTasksSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.removeAllDoneTasksSimpleButton.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.removeAllDoneTasksSimpleButton.Appearance.Options.UseFont = true;
            this.removeAllDoneTasksSimpleButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.removeAllDoneTasksSimpleButton.Location = new System.Drawing.Point(227, 6);
            this.removeAllDoneTasksSimpleButton.Name = "removeAllDoneTasksSimpleButton";
            this.removeAllDoneTasksSimpleButton.Size = new System.Drawing.Size(27, 22);
            this.removeAllDoneTasksSimpleButton.TabIndex = 6;
            this.removeAllDoneTasksSimpleButton.TabStop = false;
            this.removeAllDoneTasksSimpleButton.Text = "!";
            this.removeAllDoneTasksSimpleButton.Click += new System.EventHandler(this.removeAllDoneTasksSimpleButton_Click);
            // 
            // closeDoneTasksSimpleButton
            // 
            this.closeDoneTasksSimpleButton.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.closeDoneTasksSimpleButton.Appearance.Options.UseFont = true;
            this.closeDoneTasksSimpleButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.closeDoneTasksSimpleButton.Location = new System.Drawing.Point(5, 6);
            this.closeDoneTasksSimpleButton.Name = "closeDoneTasksSimpleButton";
            this.closeDoneTasksSimpleButton.Size = new System.Drawing.Size(27, 22);
            this.closeDoneTasksSimpleButton.TabIndex = 5;
            this.closeDoneTasksSimpleButton.TabStop = false;
            this.closeDoneTasksSimpleButton.Text = "X";
            this.closeDoneTasksSimpleButton.Click += new System.EventHandler(this.closeDoneTasksSimpleButton_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(82, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(94, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Done Task List";
            // 
            // DoneList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 266);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DoneList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "DoneList";
            this.Shown += new System.EventHandler(this.DoneList_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DoneList_KeyDown);
            this.Load += new System.EventHandler(this.DoneList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doneTasksGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doneTasksGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskDoneRepositoryItemCheckEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl doneTasksGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView doneTasksGridView;
        private DevExpress.XtraGrid.Columns.GridColumn doneGridColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit taskDoneRepositoryItemCheckEdit;
        private DevExpress.XtraGrid.Columns.GridColumn taskGridColumn;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton closeDoneTasksSimpleButton;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton removeAllDoneTasksSimpleButton;
        private DevExpress.XtraEditors.SimpleButton delDoneTaskSimpleButton;

    }
}