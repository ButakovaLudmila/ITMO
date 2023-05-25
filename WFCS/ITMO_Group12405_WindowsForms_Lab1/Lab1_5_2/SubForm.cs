using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO_Group12405_WindowsForms_Lab1.Lab1_5_2
{
    public partial class SubForm : Form
    {
        public SubForm()
        {
            InitializeComponent();
        }

        private void SubForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void New_Click(object sender, EventArgs e)
        {
            MainForm newMain = new MainForm();
            newMain.MdiParent = this;
            newMain.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
