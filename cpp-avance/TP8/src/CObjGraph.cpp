#include "CObjGraph.h"
using namespace std;

CObjGraph::CObjGraph(): m_x(0), m_y(0), m_couleur(0), m_epaisseur(0) {

}

CObjGraph::CObjGraph(int const& x, int const& y, int const& couleur, int const& epaisseur):
m_x(x), m_y(y), m_couleur(couleur), m_epaisseur(epaisseur) {

}

CObjGraph::~CObjGraph() {

}

int CObjGraph::get_x() const {
    return m_x;
}

int CObjGraph::get_y() const {
    return m_y;
}

int CObjGraph::get_couleur() const {
    return m_couleur;
}

int CObjGraph::get_epaisseur() const {
    return m_epaisseur;
}

const char* CObjGraph::get_type() const {
    return (const char*) "Objet de base";
}

void CObjGraph::translate(int const& dx, int const& dy) {
    m_x += dx;
    m_y += dy;
}

void CObjGraph::afficher(ostream& out) const {
    out << "(" << m_x << "," << m_y << ") couleur:" << m_couleur <<
    " epaisseur:" << m_epaisseur;
}

ostream& operator<<(ostream& out, CObjGraph const& self) {
    self.afficher(out);
    return out;
}

void CObjGraph::saisir(istream& in) {
    cout << "x? > ";
    in >> m_x;
    cout << "y? > ";
    in >> m_y;
    cout << "couleur? > ";
    in >> m_couleur;
    cout << "epaisseur? > ";
    in >> m_epaisseur;
}

istream& operator>>(istream& in, CObjGraph & self) {
    self.saisir(in);
    return in;
}
