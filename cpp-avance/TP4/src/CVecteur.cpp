#include "CVecteur.h"
using namespace std;


//constructeur par défaut
CVecteur::CVecteur() {
    //créer un vecteur unitaire avec 1 composante par défaut
    m_composantes.push_back(1);
}

//constructeur paramètre
CVecteur::CVecteur(int const& nb_composante) {
    //créer nb_composante vecteur(s) unitaire(s)
    for(int i = 0; i < nb_composante; i++) {
        m_composantes.push_back(1);
    }
}

//constructeur copie
CVecteur::CVecteur(CVecteur const& nouveauVecteur) {
    m_composantes = nouveauVecteur.m_composantes;
}

//destructeur
CVecteur::~CVecteur() {

}

void CVecteur::afficher(ostream& out) const {
    //affiche de la manière suivante: (x,x,...,x)
    
    out << "(";
    for(int i = 0; i < m_composantes.size(); i++) {
        if(i != m_composantes.size() -1) {
            out << m_composantes[i] << ",";
        }
        else {
            out << m_composantes[i];
        }
    }
    out << ")";
}

ostream& operator<<(ostream& out, CVecteur const& self) {
    self.afficher(out);
    return out;
}

void CVecteur::saisir(istream& in) {
    //demande chaque composante à l'utilisateur

    for(int i = 0; i < m_composantes.size(); i++) {
        cout << "composante[" << i << "]? > ";
        in >> m_composantes[i];
    }
}

istream& operator>>(istream& in, CVecteur & self) {
    self.saisir(in);
    return in;
}


int CVecteur::getComposante(int const& indice) const {
    if(indice >= 0 && indice < m_composantes.size()) {
        return m_composantes[indice];
    }
    else {
        cout << "L'indice n'est pas valable. ";
        return 0;
    }
}

int CVecteur::size() const {
    return m_composantes.size();
}