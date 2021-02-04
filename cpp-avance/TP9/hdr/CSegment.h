#ifndef CSEGMENT
#define CSEGMENT

#include "CObjGraph.h"

class CSegment: public CObjGraph {
protected:
    int m_longueur;
    double m_angle;

    void afficher(std::ostream& out) const;
    friend std::ostream& operator<<(std::ostream& out, CSegment const& self);
    void saisir(std::istream& in);
    friend std::istream& operator>>(std::istream& in, CSegment & self);

public:
    CSegment();
    CSegment(int const& x, int const& y, int const& couleur, int const& epaisseur,
    int const& longueur, double const& angle);
    ~CSegment();

    virtual char* get_type() const;
};




#endif