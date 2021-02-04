using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3
{
    public partial class Devise : Form
    {
        public Devise()
        {
            InitializeComponent();
            this.Text = "Devise";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label_taux_Click(object sender, EventArgs e)
        {

        }

        private void button_convertir_Click(object sender, EventArgs e)
        {
            if(textBox_taux.Text.Length > 0 && textBox_devise1.Text.Length > 0)
            {
                double tauxDeConversion = Convert.ToDouble(textBox_taux.Text);
                double devise1 = Convert.ToDouble(textBox_devise1.Text);

                label_resultat_devise2.Text = Convert.ToString(devise1 * tauxDeConversion);
            }
            else
            {
                label_resultat_devise2.Text = "Champs incorrects";
            }
        }

        private void radioButtonEuros_Dollars_CheckedChanged(object sender, EventArgs e)
        {
            label_devise_1.Text = "Euros";
            label_devise_2.Text = "Dollars";
            textBox_taux.Text = "";
            textBox_devise1.Text = "";
            label_resultat_devise2.Text = "label1";
        }

        private void radioButtonDollars_Euros_CheckedChanged(object sender, EventArgs e)
        {
            label_devise_1.Text = "Dollars";
            label_devise_2.Text = "Euros";
            textBox_taux.Text = "";
            textBox_devise1.Text = "";
            label_resultat_devise2.Text = "label1";
        }

    }
}
