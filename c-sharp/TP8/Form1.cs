using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP8
{
    public partial class Form1 : Form
    {
        private List<POI> POIs;
        public Form1()
        {
            InitializeComponent();
            POIs = new List<POI>();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fenetreAjout = new Form2();
            fenetreAjout.Show();
            fenetreAjout.setFormTracker(this);
        }

        public void UpdateGUI()
        {
            listViewPOIs.Items.Clear();
            foreach(POI poi in POIs)
            {
                string[] poiItem = new string[2];
                poiItem[0] = poi.getLat();
                poiItem[1] = poi.getLong();
                ListViewItem it = new ListViewItem(poiItem);

                listViewPOIs.Items.Add(it);
            }
        }
        /*
        public void addItemToList(POI poi)
        {
            string[] poiItem = new string[2];
            poiItem[0] = poi.getLat();
            poiItem[1] = poi.getLong();
            ListViewItem it = new ListViewItem(poiItem);
            //TODO : listViewPOIs.Clear()
            //TODO : for loop
            listViewPOIs.Items.Add(it);
        }
        */
        public void addToPOIs(POI poi) { POIs.Add(poi); }

        public List<POI> GetPOIs() { return POIs; }
        public void setPOIs(List<POI> listePOI)
        {
            POIs = listePOI;

        }

        private void listViewPOIs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nombreDePOIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int nbPOI = POIs.Count();
            MessageBox.Show(Convert.ToString(nbPOI), "Nombre de POI");
        }
    }
}
