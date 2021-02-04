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
    public partial class Form2 : Form
    {
        private Form1 formTracker;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public List<string> getLatLong()
        {
            List<string> latLong = new List<string>();

            string lat = "";
            lat += textBoxLatDeg.Text;
            lat += textBoxLatMin.Text;
            lat += textBoxLatSec.Text;

            latLong.Add(lat);

            string Long = "";
            Long += textBoxLongDeg.Text;
            Long += textBoxLongMin.Text;
            Long += textBoxLongSec.Text;

            latLong.Add(Long);

            return latLong;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            POI tempPOI = new POI();
            tempPOI.setLat(getLatLong()[0]);
            tempPOI.setLong(getLatLong()[1]);
            formTracker.addToPOIs(tempPOI);

            formTracker.UpdateGUI();

            this.Close();
        }

        public void setFormTracker(Form1 f)
        {
            formTracker = f;
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
