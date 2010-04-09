using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Tasker
{
    public partial class AddTaskForm : DevExpress.XtraEditors.XtraForm
    {
        string mode;
        string task;
        Point MainFormPosition;
        Size MainFormSize;

        public AddTaskForm(Point mainFormPosition, Size mainFormSize)
        {
            InitializeComponent();
            MainFormPosition = mainFormPosition;
            MainFormSize = mainFormSize;
        }

        public string Mode
        {
            get { return mode; }
            set { mode = value; }
        }

        public string Task
        {
            get { return task; }
            set { task = value; }
        }

        private void AddTaskForm_Load(object sender, EventArgs e)
        {
            SetPositionAndSize();

            this.Text = " " + mode + " a task";

            if (mode == "MODIFY")
            {
                taskTextEdit.Text = task;
                taskTextEdit.Focus();
            }
        }

        private void SetPositionAndSize()
        {
            Point NewFormPosition = new Point(MainFormPosition.X+20,MainFormPosition.Y+40);
            this.Location = NewFormPosition;

            Size NewFormSize = new Size(MainFormSize.Width - 95, 77);
            this.Size = NewFormSize;

        }

        private void doneLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Perform_AddtaskOperation();
        }

        private void AddTaskForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();

            else if (e.KeyCode == Keys.Enter)
                Perform_AddtaskOperation();
        }

        private void Perform_AddtaskOperation()
        {
            if (taskTextEdit.Text.Trim() == "")
            {
                taskTextEdit.Focus();
                return;
            }

            else
            {
                task = taskTextEdit.Text;
                this.Close();
            }
        }

        private void AddTaskForm_Shown(object sender, EventArgs e)
        {
            if (mode.ToUpper() == "ADD")
                taskTextEdit.Text = "";
        }
    }
}