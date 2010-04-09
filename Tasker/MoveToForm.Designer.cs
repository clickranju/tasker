namespace Tasker
{
    partial class MoveToForm
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
            this.listsTextBox = new System.Windows.Forms.TextBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listsTextBox
            // 
            this.listsTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.listsTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.listsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listsTextBox.Location = new System.Drawing.Point(2, 2);
            this.listsTextBox.Name = "listsTextBox";
            this.listsTextBox.Size = new System.Drawing.Size(226, 20);
            this.listsTextBox.TabIndex = 0;
            this.listsTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listsTextBox_KeyDown);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.listsTextBox);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(230, 25);
            this.panelControl1.TabIndex = 2;
            // 
            // MoveToForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 25);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MoveToForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Move to";
            this.Shown += new System.EventHandler(this.MoveToForm_Shown);
            this.Load += new System.EventHandler(this.MoveToForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox listsTextBox;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}