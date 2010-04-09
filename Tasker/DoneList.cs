using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CommonTools;

namespace Tasker
{
    public partial class DoneList : DevExpress.XtraEditors.XtraForm,ISql
    {
        Sql Csql;
        string Query;
        BindingSource DoneTasksBs;
        Point MainFormLocation;
        Size MainFormSize;

        public DoneList(Point mainFormLocation, Size mainFormSize)
        {
            InitializeComponent();
            
            DoneTasksBs = new BindingSource();
            MainFormLocation = mainFormLocation;
            MainFormSize = mainFormSize;
        }

        #region ISql Members

        public Sql SqlConnection
        {
            set { Csql = value; }
        }

        #endregion

        private void DoneList_Shown(object sender, EventArgs e)
        {
            GetDoneTasks();
            doneTasksGridControl.Focus();
        }

        private void GetDoneTasks()
        {
            DataTable dt = new DataTable();
            DataColumn doneInt = new DataColumn("doneint",Type.GetType("System.Int32"));
            dt.Columns.Add(doneInt);
            
            Query = "select id,name,done as doneint from tasks where done = 1";
            dt = Csql.ExecuteQuery(Query);

            DataColumn doneBool = new DataColumn("done", Type.GetType("System.Boolean"));
            dt.Columns.Add(doneBool);

            foreach (DataRow dr in dt.Rows)
            {
                dr["done"] = Convert.ToBoolean(dr["doneint"]); 
            }
            
            DoneTasksBs.DataSource = dt;
            doneTasksGridControl.DataSource = DoneTasksBs;
        }

        private void closeDoneTasksSimpleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DoneList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift == true)
            {
                if (e.KeyCode == Keys.Delete)
                    Perform_DeleteAllDoneTasksOperation();
            } 
            
            else if (e.KeyCode == Keys.Escape)
                this.Close();

            else if (e.KeyCode == Keys.Delete)
                Perform_DelOperation();
        }

        private void Perform_DeleteAllDoneTasksOperation()
        {
            DialogResult result = MessageBox.Show("Remove all done tasks?", "Tasker v2.0", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Query = "delete from tasks where done = 1";
                Csql.ExecuteNonQuery(Query);
                GetDoneTasks();
            }

            else if (result == DialogResult.No)
            {
                return;
            }
        }

        private void taskDoneRepositoryItemCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            int UnCheckedTaskId;
            UnCheckedTaskId = GetUnCheckedTaskId();
            TransferToList(UnCheckedTaskId);
        }

        private void TransferToList(int UnCheckedTaskId)
        {
            Query = "update tasks set done = 0 where id = " + UnCheckedTaskId + "";
            Csql.ExecuteNonQuery(Query);
            GetDoneTasks();
        }

        private int GetUnCheckedTaskId()
        {
            int[] SelectedIndex = doneTasksGridView.GetSelectedRows();
            DataRowView selected = (DataRowView)DoneTasksBs[SelectedIndex[0]];
            return Convert.ToInt32(selected["id"]);
        }

        private void removeAllDoneTasksSimpleButton_Click(object sender, EventArgs e)
        {
            Perform_DeleteAllDoneTasksOperation();
        }

        private void DoneList_Load(object sender, EventArgs e)
        {
            Point NewLocation = this.Location;
            NewLocation.X = MainFormLocation.X + 20;
            NewLocation.Y = MainFormLocation.Y + 65;
            this.Location = NewLocation;

            Size NewSize = this.Size;
            NewSize.Width = MainFormSize.Width - 37;
            NewSize.Height = MainFormSize.Height - 105;
            this.Size = NewSize;
        }

        private void Perform_DelOperation()
        {
            if (doneTasksGridView.RowCount == 0)
                return;

            int TaskToDelete = GetSelectedTaskId();
            Query = "delete from tasks where id = " + TaskToDelete + "";
            Csql.ExecuteNonQuery(Query);

            Query = "delete from labels where taskid = " + TaskToDelete + "";
            Csql.ExecuteNonQuery(Query);

            Query = "delete from priorities where taskid = " + TaskToDelete + "";
            Csql.ExecuteNonQuery(Query);

            Query = "delete from rawtask where taskid = " + TaskToDelete + "";
            Csql.ExecuteNonQuery(Query);

            GetDoneTasks();
        }

        private int GetSelectedTaskId()
        {
            int[] SelectedIndex = doneTasksGridView.GetSelectedRows();
            DataRowView selected = (DataRowView)DoneTasksBs[SelectedIndex[0]];
            return Convert.ToInt32(selected["id"]);
        }

        private void delDoneTaskSimpleButton_Click(object sender, EventArgs e)
        {
            Perform_DelOperation();
        }
    }
}