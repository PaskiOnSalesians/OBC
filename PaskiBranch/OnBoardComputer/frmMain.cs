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
using AccessMongoDB.Schemas;
using MongoDB.Bson;

namespace OnBoardComputer
{
    public partial class frmMain : Form
    {
        AllCollections allCollections = new AllCollections();

        //List<Planets> planetas;
        //List<HyperSpaceRoutes> rutas;
        //List<Regions> regions;
        //List<Filiations> filiations;


        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadCollections();
        }

        private void LoadCollections()
        {
            List<string> collectionsCombo;

            collectionsCombo = allCollections.GetCollections();

            foreach (string item in collectionsCombo)
            {
                cmbCollections.Items.Add(item.ToUpper());
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadAllData(cmbCollections.SelectedIndex.ToString());
        }

        private void LoadDataById(ObjectId id)
        {
            
        }

        // Intentar hacerlo con una lista con GetType
        private void LoadAllData(string collectionName)
        {
            Type listType;

            switch (collectionName)
            {
                case "PLANETS":
                    listType = PlanetsCollection.SelectAll().GetType();
                    //planetas = PlanetsCollection.SelectAll();
                    break;
                case "HYPERSPACEROUTES":
                    listType = HyperSpaceRoutesCollection.SelectAll().GetType();
                    //rutas = HyperSpaceRoutesCollection.SelectAll();
                    break;
                case "REGIONS":
                    listType = RegionsCollection.SelectAll().GetType();
                    //regions = RegionsCollection.SelectAll();
                    break;
                case "FILIATIONS":
                    listType = FiliationsCollection.SelectAll().GetType();
                    //filiations = FiliationsCollection.SelectAll();
                    break;
                default:
                    break;
            }
        }

        private void treeViewData_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }
    }
}
