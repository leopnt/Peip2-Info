#include "CCercle.h"
using namespace std;

CCercle::CCercle(): CObjGraph(), m_rayon(0) {

}

CCercle::CCercle(int const& x, int const& y, int const& couleur, int const& epaisseur,
int const& rayon):
CObjGraph(x, y, couleur, epaisseur), m_rayon(rayon) {

}

CCercle::~CCercle() {

}

char* CCercle::get_type() const {
    return (char*) "Type: Cercle";
}

void CCercle::afficher(ostream& out) const {
    CObjGraph::afficher(out);
    
    out << " rayon:" << m_rayon;
}

ostream& operator<<(ostream& out, CCercle const& self) {
    self.afficher(out);
    return out;
}

void CCercle::saisir(istream& in) {
    CObjGraph::saisir(in);
    cout << "rayon? > ";
    in >> m_rayon;
}

istream& operator>>(istream& in, CCercle & self) {
    self.saisir(in);
    return in;
}