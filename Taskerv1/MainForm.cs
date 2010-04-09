using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Collections;
using System.IO;

namespace Taskerv1
{
    public partial class MainForm : Form
    {
        TreeNode NewTask;
        TreeNode ParentNode;
        TreeNode PrevReadNode;
        XmlWriter writer;
        XmlReader Reader;

        int P = 0;
        int NodeCount=0;
        bool FormVisible = true;

        public MainForm()
        {
            InitializeComponent();
            PrevReadNode = null;
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            AddNewTaskOperation();
            tasksTreeView.Focus();
            tasksTreeView.SelectedNode = NewTask;
        }

        private void AddNewTaskOperation()
        {
            AddModifyTask AddNewTask = new AddModifyTask(this.Location);
            AddNewTask.ShowDialog();
            if (AddNewTask.newTask != null)
            {
                NewTask = AddNewTask.newTask;
                P = AddNewTask.p;

                SetPriority(NewTask,P);

                if (ParentNode == null)
                {
                    NewTask.Tag = 0;
                    tasksTreeView.Nodes.Add(NewTask);
                    ParentNode = NewTask;
                }
                else
                {
                    NewTask.Tag = Convert.ToInt32(ParentNode.Tag) + 1;
                    ParentNode.Nodes.Add(NewTask);
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("tasks.xml") == true)
            {
                ReadTasksFromXml();
                tasksTreeView.ExpandAll();
                Reader.Close();
            }
            ParentNode = null;
            plusButton.Focus();
        }

        private void tasksTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ModifyOperation(tasksTreeView.SelectedNode);
                }
            }

            else if (e.KeyCode == Keys.Escape)
            {
                if (ParentNode != null)
                {
                    ParentNode = null;
                    plusButton.Focus();
                }

                else if (plusButton.Focused == true || xButton.Focused == true)
                {
                    tasksTreeView.Focus();
                    ParentNode = tasksTreeView.SelectedNode;
                }

                else if (tasksTreeView.Focused == true)
                    plusButton.Focus();
            }

            else if (e.KeyCode == Keys.Space)
            {
                AfterCheckTaskOperation(tasksTreeView.SelectedNode);
            }

            else if (e.KeyCode == Keys.Enter)
            {
                AddNewTaskOperation();
                tasksTreeView.Focus();
                tasksTreeView.SelectedNode = NewTask;
            }

            else if (e.KeyCode == Keys.Delete)
            {
                if (tasksTreeView.GetNodeCount(true) != 0)
                {
                    tasksTreeView.Nodes.RemoveAt(tasksTreeView.SelectedNode.Index);
                    if (tasksTreeView.GetNodeCount(true) == 0)
                    {
                        ParentNode = null;
                    }
                }
            }
        }

        private void tasksTreeView_AfterCheck(object sender, TreeViewEventArgs e)
        {
            AfterCheckTaskOperation(e.Node);
        }

        private void tasksTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            ModifyOperation(e.Node);
        }

        private void ModifyOperation(TreeNode treeNode)
        {
            AddModifyTask amt = new AddModifyTask(this.Location);
            amt.newTask = treeNode;
            amt.p = GetPriority(treeNode);
            
            amt.ShowDialog();
            treeNode.Text = amt.newTask.Text;
            NewTask = amt.newTask;
            P = amt.p;

            SetPriority(treeNode,P);
        }

        private int GetPriority(TreeNode treeNode)
        {
            switch (treeNode.ForeColor.ToString().ToUpper())
            {
                case "COLOR [RED]":
                    return 4;
                case "COLOR [DARKORANGE]":
                    return 3;
                case "COLOR [GREEN]":
                    return 2;
                case "COLOR [GRAY]":
                    return 1;
                default:
                    return -1;
            }
        }

        private void SetPriority(TreeNode treeNode,int PriorityToSet)
        {
            switch (PriorityToSet)
            {
                case 4:
                    treeNode.ForeColor = Color.Red;
                    break;
                case 3:
                    treeNode.ForeColor = Color.DarkOrange;
                    break;
                case 2:
                    treeNode.ForeColor = Color.Green;
                    break;
                case 1:
                    treeNode.ForeColor = Color.Gray;
                    break;
            }
        }

        private void xButton_Click(object sender, EventArgs e)
        {
            if (tasksTreeView.Nodes.Count != 0)
                tasksTreeView.Nodes.Remove(tasksTreeView.SelectedNode);
        }

        private void tasksTreeView_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void AfterCheckTaskOperation(TreeNode e)
        {
            Font Tahoma = new Font(tasksTreeView.Font, FontStyle.Regular);
            Font StrikedOutFont = new Font(Tahoma, FontStyle.Strikeout);
            Font NonStrikedOutFont = new Font(Tahoma, FontStyle.Regular);

            if (e.Checked == true)
            {
                if (e.Nodes.Count != 0)
                {
                    foreach (TreeNode node in e.Nodes)
                    {
                        node.NodeFont = StrikedOutFont;
                        if (node.Checked == false)
                        {
                            node.Checked = true;
                        }
                    }

                    e.NodeFont = StrikedOutFont;
                }

                else
                {
                    e.NodeFont = StrikedOutFont;
                }
            }

            else if (e.Checked == false)
            {
                if (e.Nodes.Count != 0)
                {
                    foreach (TreeNode node in e.Nodes)
                    {
                        node.NodeFont = NonStrikedOutFont;
                        if (node.Checked == true)
                        {
                            node.Checked = false;
                        }
                    }

                    e.NodeFont = NonStrikedOutFont;
                }

                else
                {
                    e.NodeFont = NonStrikedOutFont;
                }

                UncheckParentNodes(e, NonStrikedOutFont);
            }

        }

        private void UncheckParentNodes(TreeNode e, Font NonStrikedOutFont)
        {
            while (true)
            {
                e.NodeFont = NonStrikedOutFont;
                e = e.Parent;
                if (e == null)
                    break;
            }
        }
    
        private void tasksTreeView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            //tasksTreeView.DoDragDrop(e.Item, DragDropEffects.Move);            
        }

        private void tasksTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ParentNode = e.Node;
        }

        private void tasksTreeView_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Cancel = true;
            return;
        }

        private void ReadTasksFromXml()
        {
            SortedList Task = new SortedList();

            string mx, my, mtasks;
            int x, y, tasks;
            
            Reader = XmlReader.Create("tasks.xml");
            Reader.ReadStartElement("tasker");
            Reader.ReadStartElement("location");
            Reader.ReadStartElement("x");
            mx = Reader.ReadString();
            Reader.ReadEndElement();
            Reader.ReadStartElement("y");
            my = Reader.ReadString();
            Reader.ReadEndElement();
            Reader.ReadEndElement();
            Reader.ReadStartElement("tasks");
            mtasks = Reader.ReadString();
            Reader.ReadEndElement();

            x = Convert.ToInt32(mx);
            y = Convert.ToInt32(my);
            tasks = Convert.ToInt32(mtasks);

            RestoreOldPosition(x, y);

            for (int i = 0; i < tasks; i++)
            {
                Task = ReadATask();

                //if (Task == null)
                //{
                //    break;
                //}

                CreateNode(Task);
            }
        }

        private void CreateNode(SortedList Task)
        {
            Font Tahoma = new Font(tasksTreeView.Font, FontStyle.Regular);
            Font StrikedOutFont = new Font(Tahoma, FontStyle.Strikeout);
            Font NonStrikedOutFont = new Font(Tahoma, FontStyle.Regular);

            TreeNode NewNode= new TreeNode();

            if (Convert.ToInt32(Task["level"]) == 0)
            {
                NewNode.Text = Task["name"].ToString();
                NewNode.Tag = Task["level"];
                NewNode.Checked = Convert.ToBoolean(Task["done"]);
                if (NewNode.Checked == true)
                {
                    NewNode.NodeFont = StrikedOutFont;
                }

                else
                {
                    NewNode.NodeFont = NonStrikedOutFont;
                }
                SetPriority(NewNode,Convert.ToInt32(Task["priority"]));
                PrevReadNode = NewNode;
                tasksTreeView.Nodes.Add(NewNode);
            }

            else
            {
                NewNode = new TreeNode();
                NewNode.Text = Task["name"].ToString();
                NewNode.Tag = Task["level"];
                NewNode.Checked = Convert.ToBoolean(Task["done"]);
                if (NewNode.Checked == true)
                {
                    NewNode.NodeFont = StrikedOutFont;
                }

                else
                {
                    NewNode.NodeFont = NonStrikedOutFont;
                }
                SetPriority(NewNode, Convert.ToInt32(Task["priority"]));

                if (Convert.ToInt32(Task["level"]) <= Convert.ToInt32(PrevReadNode.Tag))
                {
                    while (Convert.ToInt32(PrevReadNode.Tag) >= Convert.ToInt32(NewNode.Tag))
                    {
                        PrevReadNode = PrevReadNode.Parent;
                    }
                }

                if (Convert.ToInt32(Task["level"]) > Convert.ToInt32(PrevReadNode.Tag))
                {
                    PrevReadNode.Nodes.Add(NewNode);
                    PrevReadNode = NewNode;
                }
            }
        }

        private SortedList ReadATask()
        {
            SortedList temp= new SortedList();
            string name, mlevel, mdone,mpriority;
            bool done;
            int level,priority;

            try
            {
                Reader.ReadStartElement("task");
            }
            catch
            {
                return null;
            }
            Reader.ReadStartElement("name");
            name = Reader.ReadString();
            Reader.ReadEndElement();
            Reader.ReadStartElement("level");
            mlevel = Reader.ReadString();
            Reader.ReadEndElement();
            Reader.ReadStartElement("done");
            mdone = Reader.ReadString();
            Reader.ReadEndElement();
            Reader.ReadStartElement("priority");
            mpriority = Reader.ReadString();
            Reader.ReadEndElement();
            Reader.ReadEndElement();

            level = Convert.ToInt32(mlevel);
            priority = Convert.ToInt32(mpriority);
            done = Convert.ToBoolean(mdone);

            temp.Add("name", name);
            temp.Add("level", level);
            temp.Add("done", done);
            temp.Add("priority", priority);

            return temp;
        }

        private void RestoreOldPosition(int x, int y)
        {
            Point OldPosition = new Point(x, y);
            this.Location = OldPosition;
        }

        private void SaveTasksToXml()
        {
            string name, level, done;
            int priority;

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");
            writer = XmlWriter.Create("tasks.xml", settings);
            writer.WriteStartElement("tasker");
            writer.WriteStartElement("location");
            writer.WriteElementString("x", this.Location.X.ToString());
            writer.WriteElementString("y", this.Location.Y.ToString());
            writer.WriteEndElement();
            writer.WriteElementString("tasks", NodeCount.ToString());

            foreach (TreeNode n in tasksTreeView.Nodes)
            {
                name = n.Text;
                level = n.Tag.ToString();

                if (n.NodeFont == null)
                    done = "False";

                else if (n.NodeFont.Strikeout == true)
                    done = "True";
                else
                    done = "False";

                priority = GetPriority(n);

                WriteATask(name, level, done,priority);

                WriteChildTasks(n);
            }

            writer.WriteEndElement();
            writer.Close();
        }

        private void WriteChildTasks(TreeNode n)
        {
            string name, level, done;
            int priority;

            foreach (TreeNode nn in n.Nodes)
            {
                name = nn.Text;
                level = nn.Tag.ToString();

                if (nn.NodeFont == null)
                    done = "False";

                else if (nn.NodeFont.Strikeout == true)
                    done = "True";
                else
                    done = "False";

                priority = GetPriority(nn);

                WriteATask(name,level,done,priority);

                if (nn.Nodes.Count != 0)
                    WriteChildTasks(nn);
            }
        }

        private void WriteATask(string name, string level, string done,int priority)
        {
            writer.WriteStartElement("task");
            writer.WriteElementString("name", name);
            writer.WriteElementString("level", level);
            writer.WriteElementString("done", done);
            writer.WriteElementString("priority", priority.ToString());
            writer.WriteEndElement();
        }

        private int GetNoOfTasks(TreeNode NodeToIterate,int count)
        {
            foreach (TreeNode n in NodeToIterate.Nodes)
            {
                count++;
                if (n.Nodes.Count != 0)
                    count += GetNoOfTasks(n, 0);
            }

            return count;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            NodeCount = 0;
            foreach (TreeNode Node in tasksTreeView.Nodes)
            {
                NodeCount++;
                NodeCount += GetNoOfTasks(Node,0);
            }

            SaveTasksToXml();
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            this.TopMost = true;
            this.TopMost = false;
        }

        private void plusButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {

            }
        }

        private void tasksTreeView_DragEnter(object sender, DragEventArgs e)
        {
            //e.Effect = DragDropEffects.Move;
        }

        private void tasksTreeView_DragDrop(object sender, DragEventArgs e)
        {
            //Point loc = ((TreeView)sender).PointToClient(new Point(e.X, e.Y));
            //TreeNode srcnode = (TreeNode)e.Data.GetData(typeof(TreeNode));
            //TreeNode destNode = ((TreeView)sender).GetNodeAt(loc);

            //if (srcnode.Parent == null)
            //    srcnode.TreeView.Nodes.Remove(srcnode);
            //else
            //    srcnode.Parent.Nodes.Remove(srcnode);

            //if (destNode == null)
            //    tasksTreeView.Nodes.Add(srcnode);

            //else if (destNode.Parent == null)
            //    destNode.TreeView.Nodes.Insert(destNode.Index + 1, srcnode);
            //else
            //    destNode.Parent.Nodes.Insert(destNode.Index + 1, srcnode);
        }

        private void tasksTreeView_MouseDown(object sender, MouseEventArgs e)
        {
            //tasksTreeView.SelectedNode = tasksTreeView.GetNodeAt(e.X, e.Y);
        }

        private void aboutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            About a = new About();
            a.ShowDialog();
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
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

        private void removeAllDoneTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TreeNode tn in tasksTreeView.Nodes)
            {
                if (tn.NodeFont != null)
                    if (tn.NodeFont.Strikeout == true)
                        tn.Remove();
                RemoveDoneChildTasks(tn);
            }

            if (tasksTreeView.GetNodeCount(true) == 0)
                ParentNode = null;
        }

        private void RemoveDoneChildTasks(TreeNode t)
        {
            foreach (TreeNode tn in t.Nodes)
            {
                if (tn.NodeFont != null)
                    if (tn.NodeFont.Strikeout == true)
                        tn.Remove();
                if (tn.Nodes.Count != 0)
                    RemoveDoneChildTasks(tn);
            }
        }
    }
}