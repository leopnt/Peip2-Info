using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP9
{
    public partial class Form1 : Form
    {
        private Form2 formRecherche;
        private OpenFileDialog formOuvrirFichier;
        private SaveFileDialog formEnregistrerFichier;
        private string m_file_path;
        private StreamReader sr;
        private StreamWriter sw;

        private bool m_is_modified; 
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

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formOuvrirFichier = new OpenFileDialog();
            formOuvrirFichier.InitialDirectory = Application.ExecutablePath;
            formOuvrirFichier.Filter = "Fichier texte(*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            formOuvrirFichier.FilterIndex = 0;
            if(formOuvrirFichier.ShowDialog() == DialogResult.OK)
            {
                m_file_path = formOuvrirFichier.FileName;
            }
            
            var sr = new StreamReader(m_file_path);
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();

            enregistrerToolStripMenuItem.Enabled = true;
            enregistrerSousToolStripMenuItem.Enabled = true;
        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enregistrer();
        }

        private void enregistrer()
        {
            formOuvrirFichier = new OpenFileDialog();
            formOuvrirFichier.InitialDirectory = Application.ExecutablePath;
            formOuvrirFichier.Filter = "Fichier texte(*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            formOuvrirFichier.FilterIndex = 0;
            
            var sw = new StreamWriter(m_file_path);
            sw.Write(richTextBox1.Text);
            sw.Close();

            m_is_modified = false;

        }

        private void enregistrerSousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enregistrer_sous();
        }

        private void enregistrer_sous()
        {
            formEnregistrerFichier = new SaveFileDialog();
            formEnregistrerFichier.InitialDirectory = Application.ExecutablePath;
            formEnregistrerFichier.Filter = "Fichier texte(*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            formEnregistrerFichier.FilterIndex = 0;
            if(formEnregistrerFichier.ShowDialog() == DialogResult.OK)
            {
                m_file_path = formEnregistrerFichier.FileName;
            }
            
            var sw = new StreamWriter(m_file_path);
            sw.Write(richTextBox1.Text);
            sw.Close();

            m_is_modified = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            m_is_modified = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(m_is_modified)
            {
                var result = MessageBox.Show("Enregistrer avant de quitter ?", "Avertissement", MessageBoxButtons.YesNoCancel);
                if(result == DialogResult.Yes)
                {
                    if(m_file_path == "")
                    {
                        enregistrer_sous();
                    }
                    else
                    {
                        enregistrer();
                    }
                }

                else if(result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
