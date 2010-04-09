using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CommonTools;
using System.Collections;

namespace Tasker
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        Sql Csql;
        Basic B;
        BindingSource TasksBs;
        SortedList CheckedTask;
        DataRowView CurrentSelectedRow;
        string Query;
        bool FormVisible = true;
        int ListId;

        public MainForm()
        {
            InitializeComponent();
            Csql = new Sql();
            B = new Basic();
            TasksBs = new BindingSource();
            TasksBs.PositionChanged += new EventHandler(TasksBs_PositionChanged);
            CheckedTask = new SortedList();
        }

        void TasksBs_PositionChanged(object sender, EventArgs e)
        {
            CurrentSelectedRow = (DataRowView)TasksBs.Current;
            Perform_UpdateLabelsAndPriorities();
        }

        private enum Functionalities
        {
            Add,Delete,Hide,Done,Unhide,None,ndt,DelAll,Lists
        }

        private void MinPanelSimpleButton_Click(object sender, EventArgs e)
        {
            Perform_HideControlsOperation();
        }

        private void showControlsSimpleButton_Click(object sender, EventArgs e)
        {
            Perform_ShowControlsOperation();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            showControlsSimpleButton.Visible = false;
            functionalityPanelControl.Visible = false;
            
        }

        private void Perform_LoadJumpList()
        {
            jumpListsToolStripSplitButton.DropDown.Items.Clear();

            Query = "select id,name from lists";
            DataTable dt = Csql.ExecuteQuery(Query);

            foreach (DataRow dr in dt.Rows)
            {
                ToolStripItem tsmi = new ToolStripMenuItem(dr["name"].ToString());
                tsmi.Tag = dr["id"];
                jumpListsToolStripSplitButton.DropDown.Items.Add(tsmi);
            }

            ToolStripItem Man = new ToolStripMenuItem("Manage Lists");
            Man.Tag = "Man";
            jumpListsToolStripSplitButton.DropDown.Items.Add(Man);
        }

        private void CheckLastUsedList()
        {
            Query = "select lastlistused from prefs";
            DataTable dt = Csql.ExecuteQuery(Query);
            if (dt.Rows.Count != 0)
                ListId = Convert.ToInt32(dt.Rows[0]["lastlistused"]);
            else
                ListId = 1;
        }

        private void SetPreviousLocationAndSize()
        {
            DataTable dt = new DataTable();
            int Xlocation, Ylocation,width,height;

            Query = "select xloc,yloc,width,height from prefs";

            dt = Csql.ExecuteQuery(Query);
            if (dt.Rows.Count == 0)
                return;

            Xlocation = Convert.ToInt32(dt.Rows[0]["xloc"]);
            Ylocation = Convert.ToInt32(dt.Rows[0]["yloc"]);
            width = Convert.ToInt32(dt.Rows[0]["width"]);
            height = Convert.ToInt32(dt.Rows[0]["height"]);

            Point NewPosition = new Point(Xlocation,Ylocation);
            Size NewSize = new Size(width, height);
            this.Location = NewPosition;
            this.Size = NewSize;
        }

        private void ShowFunction(Functionalities functToShow)
        {
            switch (functToShow)
            {
                case Functionalities.Add:
                    functionalityPanelControl.Visible = true;
                    functionalityLabelControl.Text = "Add a new task; Shortcut: Enter";
                    break;

                case Functionalities.Delete:
                    functionalityPanelControl.Visible = true;
                    functionalityLabelControl.Text = "Delete selected task; Shortcut: Del";
                    break;

                case Functionalities.Done:
                    functionalityPanelControl.Visible = true;
                    functionalityLabelControl.Text = "Show done tasks; Shortcut: D";
                    break;

                case Functionalities.Hide:
                    functionalityPanelControl.Visible = true;
                    functionalityLabelControl.Text = "Hide panel to just focus on tasks; Shortcut: H";
                    break;

                case Functionalities.Unhide:
                    functionalityPanelControl.Visible = true;
                    functionalityLabelControl.Text = "Show panel; Shortcut: S";
                    break;

                case Functionalities.None:
                    functionalityPanelControl.Visible = false;
                    break;

                case Functionalities.ndt:
                    functionalityPanelControl.Visible = true;
                    functionalityLabelControl.Text = "Switch to NowDoThis View; Shortcut: P";
                    break;

                case Functionalities.DelAll:
                    functionalityPanelControl.Visible = true;
                    functionalityLabelControl.Text = "Delete all Undone Tasks; Shortcut: Shift + del";
                    break;

                case Functionalities.Lists:
                    functionalityPanelControl.Visible = true;
                    functionalityLabelControl.Text = "Select from available lists; Shortcut: L";
                    break;
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Csql.EstablishConnection(DataBaseType.SQLite, Environment.CurrentDirectory + "\\tasks.db");
            SetPreviousLocationAndSize();
            B.SqlConnection = Csql;
            ShowFunction(Functionalities.None);
            CheckLastUsedList();
            GetExistingTasks();
            Perform_LoadJumpList();
        }

        private void GetExistingTasks()
        {
            DataTable dt = new DataTable();
            Query = @"select t.id,t.name,t.done,r.rawtasks,t.listid from tasks as t 
                      inner join rawtask as r on t.id = r.taskid
                      where t.done != 1 and t.listid = " + ListId;
            dt = Csql.ExecuteQuery(Query);
            TasksBs.DataSource = dt;
            tasksGridControl.DataSource = TasksBs;

            if (dt.Rows.Count == 0)
                NotasksToolStripStatusLabel.Visible = true;
            else
                NotasksToolStripStatusLabel.Visible = false;

            Query = "select name from lists where id = " + ListId;
            dt = new DataTable();
            dt = Csql.ExecuteQuery(Query);
            listToolStripStatusLabel.Text = dt.Rows[0]["name"].ToString();
            CurrentSelectedRow = (DataRowView)TasksBs.Current;
        }

        private void taskDoneRepositoryItemCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            int CheckedTaskId;
            CheckedTaskId = GetSelectedTaskId();
            if (CheckedTaskId == -1)
                return;
            TransferToDoneList(CheckedTaskId);
            Perform_UpdateLabelsAndPriorities();
        }

        private void TransferToDoneList(int CheckedTaskId)
        {
            Query = "update tasks set done = 1 where id = " + CheckedTaskId + "";
            Csql.ExecuteNonQuery(Query);
            GetExistingTasks();
        }

        private int GetSelectedTaskId()
        {
            if (CurrentSelectedRow == null)
                return -1;
            return Convert.ToInt32(CurrentSelectedRow["id"]);
        }

        private int GetSelectedListId()
        {
            if (CurrentSelectedRow == null)
                return -1;
            return Convert.ToInt32(CurrentSelectedRow["listid"]);
        }

        private string GetSelectedTaskName()
        {
            if (CurrentSelectedRow == null)
                return "";
            return CurrentSelectedRow["name"].ToString();
        }

        private string GetSelectedRawTaskName()
        {
            if (CurrentSelectedRow == null)
                return "";
            return CurrentSelectedRow["rawtasks"].ToString();
        }

        private void showDoneListSimpleButton_Click(object sender, EventArgs e)
        {
            Perform_DoneListOperation();
        }

        
        private void deleteTaskSimpleButton_Click(object sender, EventArgs e)
        {
            Perform_DelOperation();
        }

        private void addTaskSimpleButton_Click(object sender, EventArgs e)
        {
            Perform_AddOperation();
        }

        private void Perform_DoneListOperation()
        {
            DoneList dl = new DoneList(this.Location, this.Size);
            dl.SqlConnection = Csql;
            dl.ShowDialog();
            GetExistingTasks();
            Perform_UpdateLabelsAndPriorities();
        }

        private void Perform_DelOperation()
        {
            if (tasksGridView.RowCount == 0)
                return;

            int TaskToDelete = GetSelectedTaskId();

            if (TaskToDelete == -1)
                return;

            Query = "delete from tasks where id = " + TaskToDelete + "";
            Csql.ExecuteNonQuery(Query);

            Query = "delete from labels where taskid = " + TaskToDelete + "";
            Csql.ExecuteNonQuery(Query);

            Query = "delete from priorities where taskid = " + TaskToDelete + "";
            Csql.ExecuteNonQuery(Query);

            Query = "delete from rawtask where taskid = " + TaskToDelete + "";
            Csql.ExecuteNonQuery(Query);

            GetExistingTasks();
        }

        private void Perform_AddOperation()
        {
            string TaskToBeAdded = "";

            AddTaskForm atf = new AddTaskForm(this.Location,this.Size);
            atf.Mode = "ADD";
            atf.ShowDialog();
            TaskToBeAdded = atf.Task;
            if (TaskToBeAdded == null || TaskToBeAdded.Trim() == "")
                return;

            Perform_ProcessTask(TaskToBeAdded,-1);

            GetExistingTasks();
        }

        private void Perform_UpdateLabelsAndPriorities()
        {
            UrgentPToolStripStatusLabel.Visible = false;
            normalPToolStripStatusLabel.Visible = false;
            minPToolStripStatusLabel.Visible = false;
            LabelsToolStripStatusLabel.Visible = false;

            int SelectedTaskId = GetSelectedTaskId();

            if (SelectedTaskId == -1)
                return;

            Query = @"select l.label, p.priority from labels as l 
                      inner join priorities as p on l.taskid = p.taskid
                      where l.taskid = " + SelectedTaskId;

            DataTable dt = Csql.ExecuteQuery(Query);

            if (dt.Rows[0]["label"].ToString().Trim() != "")
            {
                LabelsToolStripStatusLabel.Visible = true;
                LabelsToolStripStatusLabel.Text = dt.Rows[0]["label"].ToString();
            }

            switch (dt.Rows[0]["priority"].ToString().Trim())
            {
                case "U":
                    UrgentPToolStripStatusLabel.Visible = true;
                    break;

                case "N":
                    normalPToolStripStatusLabel.Visible = true;
                    break;

                case "L":
                    minPToolStripStatusLabel.Visible = true;
                    break;
            }

            //tasksGridControl_Click(null, null);
        }

        private void Perform_ShowControlsOperation()
        {
            ControlsPanelControl.Visible = true;
            showControlsSimpleButton.Visible = false;
            taskStatusStrip.Visible = true;
        }

        private void Perform_HideControlsOperation()
        {
            ControlsPanelControl.Visible = false;
            showControlsSimpleButton.Visible = true;
            taskStatusStrip.Visible = false;
        }

        private void Perform_ProcessTask(string TaskToBeAdded, int TaskId)
        {
            //<College, IDC, Assignments> Transmission Modes Due July 20th [U]
            int LabelStartPos, LabelEndPos, PriStartPos;
            int LablesCollectionLength;
            string LabelsCollection = "", Priority = "", RawTask = "";

            RawTask = TaskToBeAdded;

            LabelStartPos = TaskToBeAdded.IndexOf('<');
            LabelEndPos = TaskToBeAdded.IndexOf('>');

            if (LabelStartPos != -1 && LabelEndPos != -1)
            {
                LablesCollectionLength = LabelEndPos - LabelStartPos;

                LabelsCollection = TaskToBeAdded.Substring(LabelStartPos + 1, LablesCollectionLength - 1);

                TaskToBeAdded = TaskToBeAdded.Remove(LabelStartPos, LablesCollectionLength + 1);
            }

            PriStartPos = TaskToBeAdded.IndexOf('[');

            if (PriStartPos != -1)
            {
                Priority = TaskToBeAdded[PriStartPos + 1].ToString();
                TaskToBeAdded = TaskToBeAdded.Remove(PriStartPos, 3);
            }

            if (TaskId == -1)
            {
                Perform_write(RawTask, TaskToBeAdded, LabelsCollection, Priority);
            }

            else
            {
                Perform_write(RawTask, TaskToBeAdded, LabelsCollection, Priority, TaskId);
            }

        }

        private void Perform_write(string RawTask, string TaskToBeAdded, string LabelsCollection, string Priority)
        {
            int NewTaskId, NewPriId, NewLabelId, NewRawTaskId;

            NewTaskId = B.GetMaxId("id", "tasks") + 1;
            NewPriId = B.GetMaxId("id", "priorities") + 1;
            NewLabelId = B.GetMaxId("id", "labels") + 1;
            NewRawTaskId = B.GetMaxId("id", "rawtask") + 1;

            Query = "insert into tasks values (" + NewTaskId + ",'" + TaskToBeAdded + "',0,"+ListId+")";
            Csql.ExecuteNonQuery(Query);

            Query = "insert into labels values (" + NewLabelId + "," + NewTaskId + ",'" + LabelsCollection + "')";
            Csql.ExecuteNonQuery(Query);

            Query = "insert into priorities values (" + NewPriId + "," + NewTaskId + ",'" + Priority + "')";
            Csql.ExecuteNonQuery(Query);

            Query = "insert into rawtask values (" + NewRawTaskId + "," + NewTaskId + ",'" + RawTask + "')";
            Csql.ExecuteNonQuery(Query);
        }

        private void Perform_write(string RawTask, string TaskToBeAdded, string LabelsCollection, string Priority, int TaskId)
        {
            Query = "update tasks set name = '" + TaskToBeAdded + "' where id = " + TaskId;
            Csql.ExecuteNonQuery(Query);

            Query = "update labels set label = '" + LabelsCollection + "' where taskid = " + TaskId;
            Csql.ExecuteNonQuery(Query);

            Query = "update priorities set priority = '" + Priority + "' where taskid = " + TaskId;
            Csql.ExecuteNonQuery(Query);

            Query = "update rawtask set rawtasks = '" + RawTask + "' where taskid = " + TaskId;
            Csql.ExecuteNonQuery(Query);
        }

        private void tasksGridControl_DoubleClick(object sender, EventArgs e)
        {
            Perform_ModifyOperation();
        }

        #region Enter and leave functions
        private void addTaskSimpleButton_MouseEnter(object sender, EventArgs e)
        {
            ShowFunction(Functionalities.Add);
        }

        private void addTaskSimpleButton_MouseLeave(object sender, EventArgs e)
        {
            ShowFunction(Functionalities.None);
        }

        private void deleteTaskSimpleButton_MouseEnter(object sender, EventArgs e)
        {
            ShowFunction(Functionalities.Delete);
        }

        private void deleteTaskSimpleButton_MouseLeave(object sender, EventArgs e)
        {
            ShowFunction(Functionalities.None);
        }

        private void showDoneListSimpleButton_MouseEnter(object sender, EventArgs e)
        {
            ShowFunction(Functionalities.Done);
        }

        private void showDoneListSimpleButton_MouseLeave(object sender, EventArgs e)
        {
            ShowFunction(Functionalities.None);
        }

        private void minControlsSimpleButton_MouseEnter(object sender, EventArgs e)
        {
            ShowFunction(Functionalities.Hide);
        }

        private void minControlsSimpleButton_MouseLeave(object sender, EventArgs e)
        {
            ShowFunction(Functionalities.None);
        }

        private void showControlsSimpleButton_MouseEnter(object sender, EventArgs e)
        {
            ShowFunction(Functionalities.Unhide);
        }

        private void showControlsSimpleButton_MouseLeave(object sender, EventArgs e)
        {
            ShowFunction(Functionalities.None);
        }

        private void listsSimpleButton_MouseEnter(object sender, EventArgs e)
        {
            ShowFunction(Functionalities.Lists);
        }

        private void listsSimpleButton_MouseLeave(object sender, EventArgs e)
        {
            ShowFunction(Functionalities.None);
        }

        private void printSimpleButton_MouseEnter(object sender, EventArgs e)
        {
            ShowFunction(Functionalities.ndt);
        }

        private void printSimpleButton_MouseLeave(object sender, EventArgs e)
        {
            ShowFunction(Functionalities.None);
        }

        private void delAllSimpleButton_MouseEnter(object sender, EventArgs e)
        {
            ShowFunction(Functionalities.DelAll);
        }

        private void delAllSimpleButton_MouseLeave(object sender, EventArgs e)
        {
            ShowFunction(Functionalities.None);
        }
        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataTable dt = new DataTable();

            Query = "select * from prefs";
            dt = Csql.ExecuteQuery(Query);

            if (dt.Rows.Count != 0)
            {
                Query = "update prefs set xloc = " + this.Location.X + ", yloc = " + this.Location.Y + ", width = " + this.Size.Width + ", height = " + this.Size.Height + ", lastlistused = " + ListId;
            }

            else
            {
                Query = "insert into prefs(xloc,yloc,width,height,lastlistused) values(" + this.Location.X + "," + this.Location.Y + "," + this.Size.Width + "," + this.Size.Height + "," + ListId + ")";
            }

            Csql.ExecuteNonQuery(Query);

            Csql.close();
        }

        private void tasksGridControl_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift == true)
            {
                if (e.KeyCode == Keys.Delete)
                    Perform_DeleteAllOperation();
            }

            else
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        Perform_AddOperation();
                        break;

                    case Keys.Delete:
                        Perform_DelOperation();
                        break;

                    case Keys.H:
                        Perform_HideControlsOperation();
                        break;

                    case Keys.D:
                        Perform_DoneListOperation();
                        break;

                    case Keys.S:
                        Perform_ShowControlsOperation();
                        break;

                    case Keys.M:
                        Perform_ModifyOperation();
                        break;

                    case Keys.L:
                        Perform_ShowListOperation();
                        break;

                    case Keys.P:
                        //Perform_PrintTasksOperation();
                        break;
                }
            }
        }

        private void Perform_DeleteAllOperation()
        {
            DialogResult Result = MessageBox.Show("Are you sure you want to delete all the undone tasks on this list?", "Tasker v2.0", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Result == DialogResult.Yes)
            {
                Query = "delete from labels where taskid in (select id from tasks where listid = " + ListId + ")";
                Csql.ExecuteNonQuery(Query);

                Query = "delete from priorities where taskid in (select id from tasks where listid = " + ListId + ")";
                Csql.ExecuteNonQuery(Query);

                Query = "delete from rawtask where taskid in (select id from tasks where listid = " + ListId + ")";
                Csql.ExecuteNonQuery(Query);

                Query = "delete from tasks where listid = " + ListId;
                Csql.ExecuteNonQuery(Query);

                GetExistingTasks();
            }

            else
                return;
        }

        private void Perform_PrintTasksOperation()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        private void Perform_ShowListOperation()
        {
            taskLists tl = new taskLists(this.Location);
            tl.selectedListId = ListId;
            tl.SqlConnection = Csql;
            tl.ShowDialog();
            ListId = tl.selectedListId;
            GetExistingTasks();
            Perform_LoadJumpList();
            Perform_UpdateLabelsAndPriorities();
        }

        private void Perform_ModifyOperation()
        {
            int idToModify = GetSelectedTaskId();

            if (idToModify == -1)
                return;

            string taskToModify = GetSelectedRawTaskName();
            string modifiedTask = "";

            AddTaskForm atf = new AddTaskForm(this.Location,this.Size);
            atf.Mode = "MODIFY";
            atf.Task = taskToModify;
            atf.ShowDialog();
            modifiedTask = atf.Task;

            Perform_ProcessTask(modifiedTask, idToModify);
            Perform_UpdateLabelsAndPriorities();

            GetExistingTasks();

            CurrentSelectedRow = (DataRowView)TasksBs.Current;
        }

        private void statusBarNotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            if (FormVisible == true)
            {
                this.Hide();
                FormVisible = false;
            }
            else if (FormVisible == false)
            {
                this.Show();
                FormVisible = true;
            }
        }

        private void statusBarNotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            this.TopMost = true;
            this.TopMost = false;
        }

        private void Perform_summarizeTasks(string Mode)
        {
            int TotalTasks = 0, TotalDoneTasks = 0;

            if (Mode == "ALL")
            {
                DataTable dt = new DataTable();
                Query = "select count(*) as total from tasks where done = 0";
                dt = Csql.ExecuteQuery(Query);
                TotalTasks = Convert.ToInt32(dt.Rows[0]["total"]);

                dt = new DataTable();
                Query = "select count(*) as total from tasks where done = 1";
                dt = Csql.ExecuteQuery(Query);
                TotalDoneTasks = Convert.ToInt32(dt.Rows[0]["total"]);

                statusBarNotifyIcon.BalloonTipTitle = "Summary - All lists";
            }

            else if (Mode == "CURRENT")
            {
                DataTable dt = new DataTable();
                Query = "select count(*) as total from tasks where done = 0 and listid = " + ListId;
                dt = Csql.ExecuteQuery(Query);
                TotalTasks = Convert.ToInt32(dt.Rows[0]["total"]);

                dt = new DataTable();
                Query = "select count(*) as total from tasks where done = 1 and listid = " + ListId;
                dt = Csql.ExecuteQuery(Query);
                TotalDoneTasks = Convert.ToInt32(dt.Rows[0]["total"]);

                statusBarNotifyIcon.BalloonTipTitle = "Summary - Current List";
            }
            
            statusBarNotifyIcon.BalloonTipText = "Total Undone Tasks = " + TotalTasks + "\r\nTotal Done Tasks = " + TotalDoneTasks;
            statusBarNotifyIcon.ShowBalloonTip(500);
        }

        private void listsSimpleButton_Click(object sender, EventArgs e)
        {
            Perform_ShowListOperation();
        }

        private void delAllSimpleButton_Click(object sender, EventArgs e)
        {
            Perform_DeleteAllOperation();
        }

        private void jumpListsToolStripSplitButton_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                int selectedListId = Convert.ToInt32(e.ClickedItem.Tag);
                ListId = selectedListId;
                GetExistingTasks();
            }

            catch
            {
                Perform_ShowListOperation();
            }
        }

        private void listsTextBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void moveToOtherListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int CurrentSelectedTaskId = GetSelectedTaskId();
            int CurrentSelectedListId = GetSelectedListId();

            MoveToForm mtf = new MoveToForm();
            mtf.TaskIdToMove = CurrentSelectedTaskId;
            mtf.TaskCurrentListId = CurrentSelectedListId;
            mtf.SqlConnection = Csql;
            mtf.ShowDialog();

            GetExistingTasks();
        }

        private void summarizeCurrentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Perform_summarizeTasks("CURRENT");
        }

        private void summarizeAllListsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Perform_summarizeTasks("ALL");
        }
    }
}