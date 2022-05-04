using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AccessMongoDB;

namespace OnBoardComputer
{
    public partial class frmMain : Form
    {
        AllCollections allCollections = new AllCollections();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            loadCollections();
        }

        private void loadCollections()
        {
            List<string> collectionsCombo;

            collectionsCombo = allCollections.GetCollections();

            foreach (string item in collectionsCombo)
            {
                cmbCollections.Items.Add(item);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure?", "NoName Developers", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lnkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.lnkGithub.LinkVisited = true;

            System.Diagnostics.Process.Start("https://github.com/DevPaski/OnBoardComputer");
        }
    }
}
