using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;

namespace Tasker
{
    public partial class splash : DevExpress.XtraEditors.XtraForm
    {
        public splash()
        {
            InitializeComponent();
        }

        private void splash_Load(object sender, EventArgs e)
        {
            
        }

        private void splash_Shown(object sender, EventArgs e)
        {
            Thread.Sleep(2000);
            this.Close();
        }
    }
}