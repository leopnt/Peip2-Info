#ifndef CENTREPRISE
#define CENTREPRISE

#include <iostream>
#include "CSalarie.h"

class CEntreprise
{
protected:
    std::string m_nom;
    CSalarie* m_ptab_salarie;
    int m_nb_salarie;

public:
    CEntreprise();
    CEntreprise(CEntreprise const& entreprise);
    CEntreprise(std::string const& nom, int const& nb_salarie);
    ~CEntreprise();

    friend std::ostream& operator<<(std::ostream &out, CEntreprise const& self);
    friend std::istream& operator>>(std::istream &in, CEntreprise & self);

    float calc_masse_salariale() const;
};


#endif