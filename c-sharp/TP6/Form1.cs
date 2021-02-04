using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP5
{
    public partial class Form1 : Form
    {
        private List<Personne> tab;
        public Form1()
        {
            InitializeComponent();
            tab = new List<Personne>();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tab.Add(new Personne(textBoxNom.Text, textBoxPrenom.Text, Convert.ToChar(comboBoxSexe.Text), dateTimePicker1.Value, textBoxLieuNaissance.Text));
            textBoxNom.Text = "";
            textBoxPrenom.Text = "";
            comboBoxSexe.Text = "";
            dateTimePicker1.ResetText();
            textBoxLieuNaissance.Text = "";

            //on ajoute l'item (qui vient d'être ajouté dans le tableau) au ListView
            string[] strTab = {Convert.ToString(tab[tab.Count - 1].GetNom()),
                               Convert.ToString(tab[tab.Count - 1].GetPrenom()),
                               Convert.ToString(tab[tab.Count - 1].GetSexe()),
                               Convert.ToString(tab[tab.Count - 1].GetDateNaissance()),
                               Convert.ToString(tab[tab.Count - 1].GetLieuNaissance())};
            
            listViewPersonne.Items.Add(new ListViewItem(strTab));
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem I in listViewPersonne.SelectedItems)
            {
                tab.RemoveAt(I.Index); //retire le trou du tableau
                listViewPersonne.Items.RemoveAt(I.Index); //retire l'item du tableau graphique
            }
        }
    }
}
