#ifndef CPOINT2D
#define CPOINT2D

#include <iostream>
#include "CVecteur.h"

class CPoint2D
{
protected:
    int m_x, m_y; //abscisse, ordonnée

    void afficher(std::ostream& out) const;
    friend std::ostream& operator<<(std::ostream& out, CPoint2D const& self);
    void saisir(std::istream& in);
    friend std::istream& operator>>(std::istream& in, CPoint2D & self);
    
public:
    CPoint2D();
    CPoint2D(int const& x, int const& y);
    ~CPoint2D();

    CPoint2D operator+(CVecteur const& t); 
};

#endif