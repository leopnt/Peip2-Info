#include "CSalarie.h"
using namespace std;

//constructeur défaut
CSalarie::CSalarie(): CIndividu(), m_annee_embauche(0),
m_salaire(0), m_fonction_entreprise(NULL) {
    
    m_fonction_entreprise = new char;
}

//constructeur paramètre
CSalarie::CSalarie(char* const& nom, char* const& prenom, int const& annee_naissance,
int const& annee_embauche, float const& salaire, char* fonction_entreprise):
CIndividu(nom, prenom, annee_naissance), m_annee_embauche(annee_embauche),
m_salaire(salaire), m_fonction_entreprise(NULL) {
    
    cout << "debug" << endl;

    m_fonction_entreprise = new char;
    strcpy(m_fonction_entreprise, fonction_entreprise);
}

//constructeur copie
CSalarie::CSalarie(CSalarie const& salarie): CIndividu(salarie),
m_annee_embauche(salarie.m_annee_embauche), m_salaire(salarie.m_salaire),
m_fonction_entreprise(salarie.m_fonction_entreprise) {
    delete[] m_fonction_entreprise;
    m_fonction_entreprise = NULL;

    m_fonction_entreprise = new char;
    strcpy(m_fonction_entreprise, salarie.m_fonction_entreprise);
}

CSalarie::~CSalarie() {
    //on appel le destructeur de CIndividu
    CIndividu::~CIndividu();

    delete[] m_fonction_entreprise;
    m_fonction_entreprise = NULL;
}

void CSalarie::afficher(ostream& out) const {
    //on appel l'affichage de CIndividu
    CIndividu::afficher(out);

    out << endl;

    out << "Date d'embauche: " << m_annee_embauche << endl;
    out << "Fonction: " << m_fonction_entreprise << endl;
    out << "Salaire: " << m_salaire;
}

ostream& operator<<(ostream& out, CSalarie const& self) {
    self.afficher(out);
    return out;
}

void CSalarie::saisir(istream& in) {
    //on appel la saisie de CIndividu
    CIndividu::saisir(in);

    cout << "Date d'embauche XXXX? > ";
    in >> m_annee_embauche;
    cout << "Fonction dans l'entreprise? > ";
    in >> m_fonction_entreprise;
    cout << "Salaire? > ";
    in >> m_salaire;
}

istream& operator>>(istream& in, CSalarie & self) {
    self.saisir(in);
    return in;
}