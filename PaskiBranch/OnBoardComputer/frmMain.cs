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

        List<Planet> planets;
        List<HyperSpaceRoute> routes;
        List<AccessMongoDB.Schemas.Region> regions;
        List<Filiation> filiations;


        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            HideAllTabsOnTabControl(tabMain);
            LoadCollections();
        }

        private void HideAllTabsOnTabControl(TabControl theTabControl) // método para hacer las pastañas de tabcontrol invisibles en tiempo de ejecución.
        {
            theTabControl.Appearance = TabAppearance.FlatButtons;
            theTabControl.ItemSize = new Size(0, 1);
            theTabControl.SizeMode = TabSizeMode.Fixed;
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
            treeViewData.Nodes.Clear();

            if (cmbCollections.SelectedItem != null)
            {
                if (cmbCollections.Text.Equals("PLANETS"))
                {
                    LoadPlanets();
                }
                else if (cmbCollections.Text.Equals("REGIONS"))
                {
                    LoadRegions();
                }
                else if (cmbCollections.Text.Equals("FILIATIONS"))
                {
                    LoadFiliations();
                }
                else if (cmbCollections.Text.Equals("HYPERSPACEROUTES"))
                {
                    LoadHyperSpaceRoutes();
                }
            }
            else
            {
                MessageBox.Show("Select an item");
            }

        }


        private void LoadPlanets()
        {

            planets = PlanetsCollection.SelectAll();

            foreach (Planet item in planets)
            {
                treeViewData.Nodes.Add(item.Nombre);
            }
        }

        private void LoadPlanet(Planet planet)
        {
            lblPlanet.Text = planet.Nombre;
            lblSpecie.Text = planet.Natives;
            lblFiliation.Text = planet.Filiation;

            lblLong.Text = planet.Situation.Long;
            lblLat.Text = planet.Situation.Lat;
            lblParsecs.Text = planet.Situation.Parsecs;
            lblSector.Text = planet.Sector;

            pbPlanet.ImageLocation = @"Planetes\" + planet.Nombre + ".jpg";

            listBoxRoutes.Items.Clear();
            foreach (string item in planet.HyperSpaceRoute.Route)
            {
                listBoxRoutes.Items.Add(item);
            }
        }

        private void LoadRegions()
        {
            regions = RegionsCollection.SelectAll();

            foreach (AccessMongoDB.Schemas.Region item in regions)
            {
                treeViewData.Nodes.Add(item.NameRegion);
            }
        }

        private void LoadRegion(AccessMongoDB.Schemas.Region region)
        {
            lblRegionName.Text = region.NameRegion;
            lblRegionDesc.Text = region.DescriptionRegion;

            pbRegion.ImageLocation = @"Planetes\" + region.MapRegion + ".jpg";
        }

        private void LoadFiliations()
        {
            filiations = FiliationsCollection.SelectAll();

            foreach (Filiation item in filiations)
            {
                treeViewData.Nodes.Add(item.Description);
            }
        }

        private void LoadFiliation(Filiation filiation)
        {
            lblFiliationDesc.Text = filiation.Description;
        }

        private void LoadHyperSpaceRoutes()
        {
            routes = HyperSpaceRoutesCollection.SelectAll();

            foreach (HyperSpaceRoute item in routes)
            {
                treeViewData.Nodes.Add(item.NameRoute);
            }
        }

        private void LoadHyperSpaceRoute(HyperSpaceRoute hyperSpaceRoute)
        {
            lblRouteType.Text = hyperSpaceRoute.Type;
            lblRouteName.Text = hyperSpaceRoute.NameRoute;
            lblStart.Text = hyperSpaceRoute.Start;
            lblEnd.Text = hyperSpaceRoute.End;
        }

        private void treeViewData_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)

        {
            if (cmbCollections.Text.Equals("PLANETS"))
            {
                if (treeViewData.Nodes != null)
                {

                    pbPlanet.Visible = true;

                    foreach (var item in planets)
                    {
                        if (item.Nombre.Equals(e.Node.Text))
                        {
                            tabMain.SelectedTab = tabPlanets;
                            LoadPlanet(item);
                            break;
                        }
                    }
                }


            }
            else if (cmbCollections.Text.Equals("REGIONS"))
            {
                if (treeViewData.Nodes != null)
                {

                    pbRegion.Visible = true;

                    foreach (var item in regions)
                    {
                        if (item.NameRegion.Equals(e.Node.Text))
                        {
                            tabMain.SelectedTab = tabRegions;
                            LoadRegion(item);
                            break;
                        }
                    }
                }
            }
            else if (cmbCollections.Text.Equals("FILIATIONS"))
            {
                if (treeViewData.Nodes != null)
                {
                    panel16.Visible = true;
                    label11.Visible = true;

                    pbFiliation.Visible = true;

                    foreach (var item in filiations)
                    {
                        if (item.Description.Equals(e.Node.Text))
                        {
                            tabMain.SelectedTab = tabFiliations;
                            LoadFiliation(item);
                            break;
                        }
                    }
                }
            }
            else if (cmbCollections.Text.Equals("HYPERSPACEROUTES"))
            {
                if (treeViewData.Nodes != null)
                {

                    pbHyperSpace.Visible = true;

                    foreach (var item in routes)
                    {
                        if (item.NameRoute.Equals(e.Node.Text))
                        {
                            tabMain.SelectedTab = tabHyperspaceRoutes;
                            LoadHyperSpaceRoute(item);
                            break;
                        }
                    }
                }
            }
        }

        private void cmbCollections_SelectedIndexChanged(object sender, EventArgs e)
        {
            treeViewData.Nodes.Clear();
        }
    }
}