using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP9
{
    public partial class Form1 : Form
    {
        private Form2 formRecherche;
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void rechercherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formRecherche = new Form2();
            formRecherche.Owner = this;

            formRecherche.TxtToSearch = richTextBox1.Text;
            formRecherche.Show();
        }

        public void surligne(int debut, int longueur)
        {
            richTextBox1.Select(debut, longueur);
        }
    }
}
