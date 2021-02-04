#ifndef CPOINT3D_COULEUR
#define CPOINT3D_COULEUR

#include <iostream>
#include <cstring>
#include "CPoint3D.h"
#include "CCouleur.h"

class CPoint3D_couleur: public CPoint3D, public CCouleur
{
protected:
    char* m_pnom; //nom du point

    void afficher(std::ostream& out) const;
    friend std::ostream& operator<<(std::ostream& out, CPoint3D_couleur const& self);

    void saisir(std::istream& in);
    friend std::istream& operator>>(std::istream& in, CPoint3D_couleur & self);

public:
    CPoint3D_couleur();
    CPoint3D_couleur(int const& x, int const& y, int const& z, int const& R,
    int const& G, int const& B, char* const& pnom);
    ~CPoint3D_couleur();

    //void operator=(CPoint3D_couleur const& nouvP3D_couleur);
};




#endif