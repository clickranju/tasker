namespace Taskerv1
{
    partial class AddModifyTask
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.taskNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.minimalRadioButton = new System.Windows.Forms.RadioButton();
            this.aboveNormalRadioButton = new System.Windows.Forms.RadioButton();
            this.normalRadioButton = new System.Windows.Forms.RadioButton();
            this.urgentRadioButton = new System.Windows.Forms.RadioButton();
            
            this.addTaskLinkLabel = new System.Windows.Forms.LinkLabel();
            this.priorityPictureBox = new System.Windows.Forms.PictureBox();
            this.cancelLinkLabel = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priorityPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 26);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Taskerv1.Properties.Resources.banner;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Task Name";
            // 
            // taskNameTextBox
            // 
            this.taskNameTextBox.Location = new System.Drawing.Point(80, 32);
            this.taskNameTextBox.Name = "taskNameTextBox";
            this.taskNameTextBox.Size = new System.Drawing.Size(219, 22);
            this.taskNameTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Priority";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.minimalRadioButton);
            this.panel2.Controls.Add(this.aboveNormalRadioButton);
            this.panel2.Controls.Add(this.normalRadioButton);
            this.panel2.Controls.Add(this.urgentRadioButton);
            this.panel2.Location = new System.Drawing.Point(80, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 97);
            this.panel2.TabIndex = 1;
            // 
            // minimalRadioButton
            // 
            this.minimalRadioButton.AutoSize = true;
            this.minimalRadioButton.Location = new System.Drawing.Point(3, 75);
            this.minimalRadioButton.Name = "minimalRadioButton";
            this.minimalRadioButton.Size = new System.Drawing.Size(63, 18);
            this.minimalRadioButton.TabIndex = 3;
            this.minimalRadioButton.TabStop = true;
            this.minimalRadioButton.Text = "Minimal";
            this.minimalRadioButton.UseVisualStyleBackColor = true;
            this.minimalRadioButton.CheckedChanged += new System.EventHandler(this.minimalRadioButton_CheckedChanged);
            // 
            // aboveNormalRadioButton
            // 
            this.aboveNormalRadioButton.AutoSize = true;
            this.aboveNormalRadioButton.Location = new System.Drawing.Point(3, 27);
            this.aboveNormalRadioButton.Name = "aboveNormalRadioButton";
            this.aboveNormalRadioButton.Size = new System.Drawing.Size(101, 18);
            this.aboveNormalRadioButton.TabIndex = 1;
            this.aboveNormalRadioButton.TabStop = true;
            this.aboveNormalRadioButton.Text = "Above Normal";
            this.aboveNormalRadioButton.UseVisualStyleBackColor = true;
            this.aboveNormalRadioButton.CheckedChanged += new System.EventHandler(this.aboveNormalRadioButton_CheckedChanged);
            // 
            // normalRadioButton
            // 
            this.normalRadioButton.AutoSize = true;
            this.normalRadioButton.Location = new System.Drawing.Point(3, 51);
            this.normalRadioButton.Name = "normalRadioButton";
            this.normalRadioButton.Size = new System.Drawing.Size(62, 18);
            this.normalRadioButton.TabIndex = 2;
            this.normalRadioButton.TabStop = true;
            this.normalRadioButton.Text = "Normal";
            this.normalRadioButton.UseVisualStyleBackColor = true;
            this.normalRadioButton.CheckedChanged += new System.EventHandler(this.normalRadioButton_CheckedChanged);
            // 
            // urgentRadioButton
            // 
            this.urgentRadioButton.AutoSize = true;
            this.urgentRadioButton.Location = new System.Drawing.Point(3, 3);
            this.urgentRadioButton.Name = "urgentRadioButton";
            this.urgentRadioButton.Size = new System.Drawing.Size(63, 18);
            this.urgentRadioButton.TabIndex = 0;
            this.urgentRadioButton.TabStop = true;
            this.urgentRadioButton.Text = "Urgent";
            this.urgentRadioButton.UseVisualStyleBackColor = true;
            this.urgentRadioButton.CheckedChanged += new System.EventHandler(this.urgentRadioButton_CheckedChanged);
            // 
            // addTaskLinkLabel
            // 
            this.addTaskLinkLabel.AutoSize = true;
            this.addTaskLinkLabel.Location = new System.Drawing.Point(164, 160);
            this.addTaskLinkLabel.Name = "addTaskLinkLabel";
            this.addTaskLinkLabel.Size = new System.Drawing.Size(58, 14);
            this.addTaskLinkLabel.TabIndex = 2;
            this.addTaskLinkLabel.TabStop = true;
            this.addTaskLinkLabel.Text = "Add Task";
            this.addTaskLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addTaskLinkLabel_LinkClicked);
            // 
            // priorityPictureBox
            // 
            this.priorityPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priorityPictureBox.Image = global::Taskerv1.Properties.Resources.minimal;
            this.priorityPictureBox.Location = new System.Drawing.Point(33, 80);
            this.priorityPictureBox.Name = "priorityPictureBox";
            this.priorityPictureBox.Size = new System.Drawing.Size(30, 10);
            this.priorityPictureBox.TabIndex = 7;
            this.priorityPictureBox.TabStop = false;
            // 
            // cancelLinkLabel
            // 
            this.cancelLinkLabel.AutoSize = true;
            this.cancelLinkLabel.Location = new System.Drawing.Point(228, 160);
            this.cancelLinkLabel.Name = "cancelLinkLabel";
            this.cancelLinkLabel.Size = new System.Drawing.Size(71, 14);
            this.cancelLinkLabel.TabIndex = 8;
            this.cancelLinkLabel.TabStop = true;
            this.cancelLinkLabel.Text = "Cancel Task";
            this.cancelLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cancelLinkLabel_LinkClicked);
            // 
            // AddModifyTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(311, 180);
            this.ControlBox = false;
            this.Controls.Add(this.cancelLinkLabel);
            this.Controls.Add(this.addTaskLinkLabel);
            this.Controls.Add(this.priorityPictureBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.taskNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddModifyTask";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddTask_KeyDown);
            this.Load += new System.EventHandler(this.AddTask_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priorityPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox taskNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton aboveNormalRadioButton;
        private System.Windows.Forms.RadioButton normalRadioButton;
        private System.Windows.Forms.RadioButton urgentRadioButton;
        private System.Windows.Forms.RadioButton minimalRadioButton;
        private System.Windows.Forms.PictureBox priorityPictureBox;
        private System.Windows.Forms.LinkLabel addTaskLinkLabel;
        private System.Windows.Forms.LinkLabel cancelLinkLabel;
    }
}