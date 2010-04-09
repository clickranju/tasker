using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Taskerv1
{
    public partial class AddModifyTask : Form
    {
        TreeNode NewTask;
        int P=0;

        public AddModifyTask(Point MainFormLocation)
        {
            InitializeComponent();
            MainFormLocation.X += 20;
            MainFormLocation.Y += 60;
            Size resolution = SystemInformation.PrimaryMonitorSize;

            if (MainFormLocation.X + this.Size.Width > resolution.Width)
                MainFormLocation.X -= ((this.Size.Width + MainFormLocation.X) - resolution.Width) + 20;

            this.Location = MainFormLocation;
        }

        public int p
        {
            get { return P; }
            set { P = value; }
        }

        public TreeNode newTask
        {
            get { return NewTask; }
            set { NewTask = value; }
        }

        private void plusButton_Click(object sender, EventArgs e)
        {

        }

        private void urgentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (urgentRadioButton.Checked == true)
            {
                SetPriority("URGENT");
            }
        }

        private void AddTask_Load(object sender, EventArgs e)
        {
            if (P == 0)
                normalRadioButton.Checked = true;
            else
            {
                normalRadioButton.Checked = true;
                taskNameTextBox.Text = NewTask.Text;
            }
        }

        private void SetPriority(string pr)
        {
            switch (pr)
            {
                case "URGENT":
                    priorityPictureBox.Image = Taskerv1.Properties.Resources.urgent;
                    P = 4;
                    break;
                case "ABOVENORMAL":
                    priorityPictureBox.Image = Taskerv1.Properties.Resources.above_normal;
                    P = 3;
                    break;
                case "NORMAL":
                    priorityPictureBox.Image = Taskerv1.Properties.Resources.normal;
                    P = 2;
                    break;
                case "MINIMAL":
                    priorityPictureBox.Image = Taskerv1.Properties.Resources.minimal;
                    P = 1;
                    break;
            }
        }

        private void aboveNormalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (aboveNormalRadioButton.Checked == true)
            {
                SetPriority("ABOVENORMAL");
            }
        }

        private void normalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (normalRadioButton.Checked == true)
            {
                SetPriority("NORMAL");
            }
        }

        private void minimalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (minimalRadioButton.Checked == true)
            {
                SetPriority("MINIMAL");
            }
        }

        private void AddTask_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                EscapeButtonOperation();
            }

            else if (e.KeyCode == Keys.Enter)
            {
                AddTaskOperation();
            }

            else
            {
                return;
            }
        }

        private void EscapeButtonOperation()
        {
            if (taskNameTextBox.Text != "")
            {
                taskNameTextBox.Text = "";
                normalRadioButton.Checked = true;
            }

            else
                this.Close();
        }

        private void addTaskLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddTaskOperation();
        }

        private void AddTaskOperation()
        {
            if (taskNameTextBox.Text == "")
                taskNameTextBox.Focus();
            else
            {
                NewTask = new TreeNode(taskNameTextBox.Text);
                this.Close();
            }
        }

        private void cancelLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EscapeButtonOperation();
        }
    }
}