#ifndef CPOINT3D
#define CPOINT3D

#include <iostream>
#include "CPoint2D.h"

class CPoint3D: public CPoint2D
{
protected:
    int m_z;

    void afficher(std::ostream& out) const;
    friend std::ostream& operator<<(std::ostream& out, CPoint3D const& self);
    void saisir(std::istream& in);
    friend std::istream& operator>>(std::istream& in, CPoint3D & self);
    
public:
    CPoint3D();
    CPoint3D(int const& x, int const& y, int const& z);
    ~CPoint3D();

    CPoint3D operator+(CVecteur const& t); 
};

#endif