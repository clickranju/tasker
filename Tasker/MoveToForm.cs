using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CommonTools;

namespace Tasker
{
    public partial class MoveToForm : DevExpress.XtraEditors.XtraForm, ISql
    {
        Sql Csql;
        Basic B;
        SortedList ListIdName;
        string Query;
        int TaskToMove;
        int CurrentListId;

        public MoveToForm()
        {
            ListIdName = new SortedList();
            InitializeComponent();
            B = new Basic();
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

        public int TaskIdToMove
        {
            set { TaskToMove = value; }
        }

        public int TaskCurrentListId
        {
            set { CurrentListId = value; }
        }

        private void MoveToForm_Shown(object sender, EventArgs e)
        {
            Perform_LoadSuggestions();
        }

        private void Perform_LoadSuggestions()
        {
            DataTable Lists = new DataTable();
            Query = "select id,name from lists";
            Lists = Csql.ExecuteQuery(Query);

            AutoCompleteStringCollection acsc = new AutoCompleteStringCollection();

            foreach (DataRow dr in Lists.Rows)
            {
                acsc.Add(dr["name"].ToString());
                ListIdName.Add(dr["name"].ToString().ToUpper(), dr["id"].ToString());
            }

            listsTextBox.AutoCompleteCustomSource = acsc;
        }

        private void listsTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Perform_CheckIfMoveable();
            }
        }

        private void Perform_CheckIfMoveable()
        {
            int DestinationListId = -1;

            DestinationListId = Convert.ToInt32(ListIdName[listsTextBox.Text.ToUpper()]);

            if (DestinationListId == 0)
            {
                listsTextBox.Clear();
                listsTextBox.Focus();
            }

            else
            {
                Perform_MoveTask(DestinationListId);
            }
        }

        private void Perform_MoveTask(int DestinationListId)
        {
            Query = "update tasks set listid = " + DestinationListId + " where id = " + TaskToMove;
            Csql.ExecuteNonQuery(Query);
            this.Close();
        }

        private void MoveToForm_Load(object sender, EventArgs e)
        {
            this.Location = Control.MousePosition;
        }

        private void moveLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Perform_CheckIfMoveable();
        }
    }
}