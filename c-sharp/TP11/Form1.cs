using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP11
{
    public partial class Form1 : Form
    {
        private Brush m_brosse_bleu;
        private Brush m_brosse_rectangle;
        private Brush m_brosse_police;
        private Font m_police;
        private bool m_deplace;
        private Rectangle m_rect;
        private Point m_pos_souris;
        public Form1()
        {
            InitializeComponent();
            m_police = new Font("Arial", 14);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_brosse_rectangle = new Brush();
        }
    }
}
