#ifndef CSALARIE
#define CSALARIE

#include <iostream>
#include "CIndividu.h"

class CSalarie: public CIndividu {
protected:
    int m_annee_embauche;
    float m_salaire;
    std::string m_fonction_entreprise;

    friend std::ostream& operator<<(std::ostream& out, CSalarie const& self);
    friend std::istream& operator>>(std::istream& in, CSalarie & self);

public:
    CSalarie();
    CSalarie(std::string const& nom, std::string const& prenom, int const& annee_naissance, int const& annee_embauche, float const& salaire,
    std::string fonction_entreprise);
    CSalarie(CSalarie const& salarie);
    ~CSalarie();

    float getSalaire() const;
};


#endif