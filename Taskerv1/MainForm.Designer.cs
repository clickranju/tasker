namespace Taskerv1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tasksTreeView = new System.Windows.Forms.TreeView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeAllDoneTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.xButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.aboutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 26);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Taskerv1.Properties.Resources.banner;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.Controls.Add(this.tasksTreeView);
            this.panel2.Location = new System.Drawing.Point(0, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 358);
            this.panel2.TabIndex = 2;
            // 
            // tasksTreeView
            // 
            this.tasksTreeView.CheckBoxes = true;
            this.tasksTreeView.ContextMenuStrip = this.contextMenuStrip;
            this.tasksTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tasksTreeView.Font = new System.Drawing.Font("Tahoma", 9F);
            this.tasksTreeView.FullRowSelect = true;
            this.tasksTreeView.Indent = 20;
            this.tasksTreeView.ItemHeight = 16;
            this.tasksTreeView.Location = new System.Drawing.Point(0, 0);
            this.tasksTreeView.Name = "tasksTreeView";
            this.tasksTreeView.Scrollable = false;
            this.tasksTreeView.ShowLines = false;
            this.tasksTreeView.ShowPlusMinus = false;
            this.tasksTreeView.ShowRootLines = false;
            this.tasksTreeView.Size = new System.Drawing.Size(321, 358);
            this.tasksTreeView.TabIndex = 0;
            this.tasksTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tasksTreeView_NodeMouseDoubleClick);
            this.tasksTreeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tasksTreeView_AfterCheck);
            this.tasksTreeView.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.tasksTreeView_BeforeCollapse);
            this.tasksTreeView.DragDrop += new System.Windows.Forms.DragEventHandler(this.tasksTreeView_DragDrop);
            this.tasksTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tasksTreeView_AfterSelect);
            this.tasksTreeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tasksTreeView_MouseDown);
            this.tasksTreeView.DragEnter += new System.Windows.Forms.DragEventHandler(this.tasksTreeView_DragEnter);
            this.tasksTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tasksTreeView_NodeMouseClick);
            this.tasksTreeView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tasksTreeView_KeyDown);
            this.tasksTreeView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.tasksTreeView_ItemDrag);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeAllDoneTasksToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.ShowImageMargin = false;
            this.contextMenuStrip.Size = new System.Drawing.Size(168, 26);
            // 
            // removeAllDoneTasksToolStripMenuItem
            // 
            this.removeAllDoneTasksToolStripMenuItem.Name = "removeAllDoneTasksToolStripMenuItem";
            this.removeAllDoneTasksToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.removeAllDoneTasksToolStripMenuItem.Text = "&Remove all done tasks";
            this.removeAllDoneTasksToolStripMenuItem.Click += new System.EventHandler(this.removeAllDoneTasksToolStripMenuItem_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Tasker";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // xButton
            // 
            this.xButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.xButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xButton.BackgroundImage")));
            this.xButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.xButton.Location = new System.Drawing.Point(243, 389);
            this.xButton.Name = "xButton";
            this.xButton.Size = new System.Drawing.Size(33, 25);
            this.xButton.TabIndex = 1;
            this.xButton.TabStop = false;
            this.xButton.UseVisualStyleBackColor = true;
            this.xButton.Click += new System.EventHandler(this.xButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.plusButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plusButton.BackgroundImage")));
            this.plusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.plusButton.Location = new System.Drawing.Point(282, 389);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(33, 25);
            this.plusButton.TabIndex = 0;
            this.plusButton.TabStop = false;
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            this.plusButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.plusButton_KeyDown);
            // 
            // aboutLinkLabel
            // 
            this.aboutLinkLabel.AutoSize = true;
            this.aboutLinkLabel.Location = new System.Drawing.Point(196, 394);
            this.aboutLinkLabel.Name = "aboutLinkLabel";
            this.aboutLinkLabel.Size = new System.Drawing.Size(41, 14);
            this.aboutLinkLabel.TabIndex = 3;
            this.aboutLinkLabel.TabStop = true;
            this.aboutLinkLabel.Text = "About";
            this.aboutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutLinkLabel_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(321, 417);
            this.Controls.Add(this.aboutLinkLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.xButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView tasksTreeView;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button xButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.LinkLabel aboutLinkLabel;
        private System.Windows.Forms.ToolStripMenuItem removeAllDoneTasksToolStripMenuItem;
    }
}

