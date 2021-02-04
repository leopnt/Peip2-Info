using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4
{
    class Vecteur
    {
        private List<int> m_tab = new List<int>();

        public Vecteur()
        {
            m_tab.Add(0);
            m_tab.Add(0);
            m_tab.Add(0);
        }

        public Vecteur(int x, int y, int z)
        {
            m_tab.Add(x);
            m_tab.Add(y);
            m_tab.Add(z);
        }

        public int Produit_scalaire(Vecteur V)
        {
            return Get_X() * V.Get_X() + Get_Y() * V.Get_Y() + Get_Z() * V.Get_Z();
        }

        public Vecteur Produit_Vectoriel(Vecteur V)
        {
            return new Vecteur(Get_Y() * V.Get_Z() - Get_Z() * V.Get_Y(),
                               Get_Z() * V.Get_X() - Get_X() * V.Get_Z(),
                               Get_X() * V.Get_Y() - Get_Y() * V.Get_X());
        }

        public int Get_X() { return m_tab[0]; }
        public int Get_Y() { return m_tab[1]; }
        public int Get_Z() { return m_tab[2]; }
    }
}
