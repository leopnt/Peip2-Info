#ifndef CCERCLE
#define CCERCLE

#include "CObjGraph.h"

class CCercle: public CObjGraph {
protected:
    int m_rayon;

    void afficher(std::ostream& out) const;
    friend std::ostream& operator<<(std::ostream& out, CCercle const& self);
    void saisir(std::istream& in);
    friend std::istream& operator>>(std::istream& in, CCercle & self);

public:
    CCercle();
    CCercle(int const& x, int const& y, int const& couleur, int const& epaisseur,
    int const& rayon);
    ~CCercle();

    const char* get_type() const;
};




#endif