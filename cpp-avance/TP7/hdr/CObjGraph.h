#ifndef COBJGRAPH
#define COBJGRAPH

#include <iostream>

class CObjGraph
{
protected:
    int m_x, m_y;
    int m_couleur;
    int m_epaisseur;

    void afficher(std::ostream& out) const;
    friend std::ostream& operator<<(std::ostream& out, CObjGraph const& self);
    void saisir(std::istream& in);
    friend std::istream& operator>>(std::istream& in, CObjGraph & self);

public:
    CObjGraph();
    CObjGraph(int const& x, int const& y, int const& couleur, int const& epaisseur);
    ~CObjGraph();

    int get_x() const;
    int get_y() const;
    int get_couleur() const;
    int get_epaisseur() const;
    char* get_type() const;

    void translate(int const& dx, int const& dy);
};




#endif