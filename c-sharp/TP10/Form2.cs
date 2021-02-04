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

    public partial class Form2 : Form
    {
        private string txtToSearch;
        public string TxtToSearch
        {
            get { return txtToSearch; }
            set { txtToSearch = value; }
        }
        private int startPos;
        public int StartPos
        {
            get { return startPos; }
            set { startPos = value; }
        }

        private Form1 parentF;
        public Form1 ParentF
        {
            set { parentF = value; }
        }

        public Form2()
        {
            InitializeComponent();
            txtToSearch = "";
            startPos = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtToSearch.Contains(textBox1.Text))
            {
                int startPos = txtToSearch.IndexOf(textBox1.Text);
                ((Form1) Owner).surligne(startPos, textBox1.Text.Length); //deux parenthèses: d'abord cast le Owner puis appel sur l'ensemble
                ((Form1) Owner).Focus();
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("La recherche n'a rien donné", "Résultat de la recherche", MessageBoxButtons.OK);
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((Form1) Owner).surligne(0, 0); //deux parenthèses: d'abord cast le Owner puis appel sur l'ensemble
        }
    }
}
