#include <iostream>
using namespace std;

#include "CVecteur.h"
#include "CPoint2D.h"
#include "CPoint3D.h"
#include "CCouleur.h"
#include "CPoint3D_couleur.h"

int main() {

    CPoint3D_couleur p;

    cin >> p;
    cout << "point3D Couleur: " << p << endl;
    p.CPoint3D::getNomClass();
    p.CCouleur::getNomClass();

    return 0;
}