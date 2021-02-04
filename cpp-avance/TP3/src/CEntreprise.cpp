#include "CEntreprise.h"
using namespace std;

//constructeur par défaut
CEntreprise::CEntreprise(): m_nom("Nom entreprise"), m_nb_salarie(1) {
    
    //création des salariés par défaut dans le tableau:
    m_ptab_salarie = new CSalarie[m_nb_salarie];
}

//constructeur copie
CEntreprise::CEntreprise(CEntreprise const& entreprise):
m_nb_salarie(entreprise.m_nb_salarie) {
    delete[] m_ptab_salarie; //supprime l'ancienne entreprise
    
    //allocation mémoire: (La nouvelle taille est donnée dans la liste d'initialisation)
    m_ptab_salarie = new CSalarie[m_nb_salarie];

    //dépose des nouvelles valeurs:
    for(int i = 0; i < m_nb_salarie; i++) {
        m_ptab_salarie[i] = entreprise.m_ptab_salarie[i];
    }
}

//constructeur paramètre
CEntreprise::CEntreprise(string const& nom, int const& nb_salarie): m_nom(nom),
m_nb_salarie(nb_salarie) {
    
    //création des salariés par défaut dans le tableau:
    m_ptab_salarie = new CSalarie[m_nb_salarie];
}

//destructeur
CEntreprise::~CEntreprise() {
    delete[] m_ptab_salarie;
}

ostream& operator<<(std::ostream &out, CEntreprise const& self) {
    out << "Entreprise: " << self.m_nom << " | ";
    out << "(Nombre de salaries: " << self.m_nb_salarie << ")" << endl << endl;
    
    //affiche tous les salariés
    for(int i = 0; i < self.m_nb_salarie; i++) {
        out << "------------" << endl;
        out << "ID(" << i << "): " << endl << self.m_ptab_salarie[i] << endl;
    }

    return out;
}

istream& operator>>(std::istream &in, CEntreprise & self) {
    cout << "Nom de l'entreprise? > ";
    in >> self.m_nom;
    cout << "Nombre de salaries? > ";
    in >> self.m_nb_salarie;
    cout << "Veuillez saisir les informations des salaries..." << endl;
    
    delete[] self.m_ptab_salarie; //supprime l'ancienne entreprise
    
    //allocation mémoire: (La nouvelle taille est donnée précédemment)
    self.m_ptab_salarie = new CSalarie[self.m_nb_salarie];    

    for(int i = 0; i < self.m_nb_salarie; i++) {
        cout << "Salarie ID(" << i << "): " << endl;
        in >> self.m_ptab_salarie[i];
        cout << endl;
    }

    return in;
}

float CEntreprise::calc_masse_salariale() const {
    //retourne la masse salariale (somme des salaires) de l'entreprise

    float somme(0);
    for(int i = 0; i < m_nb_salarie; i++) {
        somme += m_ptab_salarie[i].getSalaire();
    }

    return somme;
}