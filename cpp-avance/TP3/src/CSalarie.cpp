#include "CSalarie.h"
using namespace std;

//constructeur défaut
CSalarie::CSalarie(): CIndividu(), m_annee_embauche(1990),
m_salaire(1200), m_fonction_entreprise("Fonction dans l'entreprise") {
    
}

//constructeur paramètre
CSalarie::CSalarie(string const& nom, string const& prenom, int const& annee_naissance,
int const& annee_embauche, float const& salaire, std::string fonction_entreprise):
CIndividu(nom, prenom, annee_naissance), m_annee_embauche(annee_embauche),
m_salaire(salaire), m_fonction_entreprise(fonction_entreprise) {

}

//constructeur copie
CSalarie::CSalarie(CSalarie const& salarie): CIndividu(salarie),
m_annee_embauche(salarie.m_annee_embauche), m_salaire(salarie.m_salaire),
m_fonction_entreprise(salarie.m_fonction_entreprise) {

}

CSalarie::~CSalarie() {

}

ostream& operator<<(ostream& out, CSalarie const& self) {
    self.CIndividu::affiche(out); //appel de la saisie de CIndividu. On économise du code
    out << endl;

    out << "Date d'embauche: " << self.m_annee_embauche << endl;
    out << "Fonction: " << self.m_fonction_entreprise << endl;
    out << "Salaire: " << self.m_salaire;

    return out;
}

istream& operator>>(istream& in, CSalarie & self) {
    self.CIndividu::saisir(in); //appel de la saisie de CIndividu. On économise du code

    cout << "Date d'embauche XXXX? > ";
    in >> self.m_annee_embauche;

    cout << "Fonction dans l'entreprise? > ";
    in.ignore(); //résout les bugs d'espace dans le buffer
    getline(in, self.m_fonction_entreprise);
    
    cout << "Salaire? > ";
    in >> self.m_salaire;
    
    return in;
}

float CSalarie::getSalaire() const {
    return m_salaire;
}