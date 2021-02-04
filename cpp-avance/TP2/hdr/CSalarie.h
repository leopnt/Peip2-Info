#ifndef CSALARIE
#define CSALARIE

#include <iostream>
#include "CIndividu.h"

class CSalarie: public CIndividu {
protected:
    int m_annee_embauche;
    float m_salaire;
    char* m_fonction_entreprise;

    void afficher(std::ostream& out) const;
    friend std::ostream& operator<<(std::ostream& out, CSalarie const& self);
    void saisir(std::istream& in);
    friend std::istream& operator>>(std::istream& in, CSalarie & self);

public:
    CSalarie();
    CSalarie(char* const& nom, char* const& prenom, int const& annee_naissance,
    int const& annee_embauche, float const& salaire, char* fonction_entreprise);
    CSalarie(CSalarie const& salarie);
    ~CSalarie();
};


#endif