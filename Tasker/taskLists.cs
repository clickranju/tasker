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
    public partial class taskLists : DevExpress.XtraEditors.XtraForm,ISql
    {
        Sql Csql;
        string Query = "";
        int ListId;
        int CurrentListId;
        BindingSource ListBs;
        DataRowView CurrentSelectedRow;
        Basic B;
        CloseLaunchers HowClose;
        OperationModes CurrentOpMode;
        Point mainFormLocation;

        public taskLists(Point MainFormCurrentLocation)
        {
            InitializeComponent();
            ListBs = new BindingSource();
            ListBs.PositionChanged += new EventHandler(ListBs_PositionChanged);

            B = new Basic();

            mainFormLocation = MainFormCurrentLocation;
        }

        private enum CloseLaunchers
        {
            Voluntary,xButton,xButtonAfterDel
        }

        private enum OperationModes
        {
            Add, Modify
        }

        void ListBs_PositionChanged(object sender, EventArgs e)
        {
            CurrentSelectedRow = (DataRowView)ListBs.Current;
        }

        private void taskLists_Load(object sender, EventArgs e)
        {
            SetPosition();
            CurrentOpMode = OperationModes.Add;
            CurrentListId = ListId;
            HowClose = CloseLaunchers.xButton;
            AddModifyListGroupControl.Visible = false;
            GetLists();
        }

        private void SetPosition()
        {
            Point NewLocation = new Point(mainFormLocation.X + 20, mainFormLocation.Y + 50);
            this.Location = NewLocation;
        }

        private void GetLists()
        {
            Query = "select * from lists";
            DataTable dt = Csql.ExecuteQuery(Query);
            ListBs.DataSource = dt;
            listsGridControl.DataSource = ListBs;
            CurrentSelectedRow = (DataRowView)ListBs.Current;
            ListId = GetSelectedListId();
        }

        #region ISql Members

        public Sql SqlConnection
        {
            set 
            { 
                Csql = value; 
                B.SqlConnection = value;
            }
        }

        #endregion


        public int selectedListId
        {
            get { return ListId; }
            set { ListId = value; }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentOpMode = OperationModes.Add;
            AddModifyListGroupControl.Visible = true;
            AddModifyListGroupControl.Text = "Add a List";
            addListSimpleButton.Text = "+";
            listNameTextEdit.Focus();
        }

        private void addListSimpleButton_Click(object sender, EventArgs e)
        {
            Perform_CheckForAddModify();
        }

        private void Perform_CheckForAddModify()
        {
            if (CurrentOpMode == OperationModes.Add)
            {
                Perform_addList();
                GetLists();
                listsGridControl.Focus();
            }

            else if (CurrentOpMode == OperationModes.Modify)
            {
                Perform_ModifyList();
                GetLists();
                listsGridControl.Focus();
            }
        }

        private void Perform_addList()
        {
            int NextListId;
            NextListId = B.GetMaxId("id", "lists") + 1;

            Query = "insert into lists values (" + NextListId + ",'" + listNameTextEdit.Text + "')";
            Csql.ExecuteNonQuery(Query);
            listNameTextEdit.Text = "";
            AddModifyListGroupControl.Visible = false;
        }

        private void Perform_delList()
        {
            ListId = Convert.ToInt32(CurrentSelectedRow["id"]);

            if (ListId == 1)
            {
                MessageBox.Show("Cannot delete Root list", "Tasker v2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Query = "delete from labels where taskid in (select id from tasks where listid = " + ListId + ")";
            Csql.ExecuteNonQuery(Query);

            Query = "delete from priorities where taskid in (select id from tasks where listid = " + ListId + ")";
            Csql.ExecuteNonQuery(Query);

            Query = "delete from rawtask where taskid in (select id from tasks where listid = " + ListId + ")";
            Csql.ExecuteNonQuery(Query);

            Query = "delete from tasks where listid = " + ListId;
            Csql.ExecuteNonQuery(Query);

            Query = "delete from lists where id = " + ListId;
            Csql.ExecuteNonQuery(Query);
        }

        private void removeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Perform_delList();
            GetLists();
            HowClose = CloseLaunchers.xButtonAfterDel;
        }

        private void taskLists_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    if (AddModifyListGroupControl.Visible == true)
                        AddModifyListGroupControl.Visible = false;
                    else
                        this.Close();
                    break;
                case Keys.Enter:
                    Perform_selectList();
                    break;
            }
        }

        private void listsGridControl_DoubleClick(object sender, EventArgs e)
        {
            Perform_selectList();
        }

        private void Perform_selectList()
        {
            ListId = GetSelectedListId();
            HowClose = CloseLaunchers.Voluntary;
            this.Close();
        }

        private int GetSelectedListId()
        {
            if (CurrentSelectedRow == null)
                return -1;
            return Convert.ToInt32(CurrentSelectedRow["id"]);
        }

        private string GetSelectedListName()
        {
            if (CurrentSelectedRow == null)
                return "";
            return CurrentSelectedRow["name"].ToString();
        }

        private void modifyListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentOpMode = OperationModes.Modify;
            AddModifyListGroupControl.Visible = true;
            AddModifyListGroupControl.Text = "Modify a List";
            ListId = GetSelectedListId();
            string ListToModify = GetSelectedListName();
            listNameTextEdit.Text = ListToModify;
            addListSimpleButton.Text = "◊";
            listNameTextEdit.Focus();
        }

        private void Perform_ModifyList()
        {
            Query = "update lists set name = '"+listNameTextEdit.Text+"' where id = " + ListId;
            Csql.ExecuteNonQuery(Query);
            listNameTextEdit.Text = "";
            AddModifyListGroupControl.Visible = false;
        }

        private void taskLists_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (HowClose)
            {
                case CloseLaunchers.Voluntary:
                    break;

                case CloseLaunchers.xButton:
                    ListId = CurrentListId;
                    break;

                case CloseLaunchers.xButtonAfterDel:
                    break;
            }
        }

        private void listNameTextEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Perform_CheckForAddModify();
        }
    }
}