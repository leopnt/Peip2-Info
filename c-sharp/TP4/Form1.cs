using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void produitScalaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vecteur v1 = new Vecteur(Convert.ToInt32(textBoxX1.Text),
                                     Convert.ToInt32(textBoxY1.Text),
                                     Convert.ToInt32(textBoxZ1.Text));

            Vecteur v2 = new Vecteur(Convert.ToInt32(textBoxX2.Text),
                                     Convert.ToInt32(textBoxY2.Text),
                                     Convert.ToInt32(textBoxZ2.Text));

            labelX3.Visible = false;
            labelY3.Visible = false;
            labelZ3.Visible = false;

            textBoxX3.Visible = false;
            textBoxZ3.Visible = false;


            textBoxY3.Text = Convert.ToString(v1.Produit_scalaire(v2));
        }

        private void produitVectorielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vecteur v1 = new Vecteur(Convert.ToInt32(textBoxX1.Text),
                                     Convert.ToInt32(textBoxY1.Text),
                                     Convert.ToInt32(textBoxZ1.Text));

            Vecteur v2 = new Vecteur(Convert.ToInt32(textBoxX2.Text),
                                     Convert.ToInt32(textBoxY2.Text),
                                     Convert.ToInt32(textBoxZ2.Text));

            Vecteur v3 = v1.Produit_Vectoriel(v2);

            //on réinitialise la visibilité au cas où le produit scalaire s'est fait avant
            labelX3.Visible = true;
            labelY3.Visible = true;
            labelZ3.Visible = true;

            textBoxX3.Visible = true;
            textBoxZ3.Visible = true;

            textBoxX3.Text = Convert.ToString(v3.Get_X());
            textBoxY3.Text = Convert.ToString(v3.Get_Y());
            textBoxZ3.Text = Convert.ToString(v3.Get_Z());
        }
    }
}
