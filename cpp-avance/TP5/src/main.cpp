#include <iostream>
using namespace std;

#include "CVecteur.h"
#include "CPoint2D.h"
#include "CPoint3D.h"
#include "CCouleur.h"

int main() {

    CCouleur bleu(0, 0, 255);
    cout << bleu << endl;

    CPoint3D p;
    cin >> p;
    cout << "p: " << p << endl;

    CVecteur v(2);

    cout << "saisir les composantes du vecteur de translation 2D v:" << endl;
    cin >> v;

    p = p + v; //translation par le vecteur v

    cout << "p apres translation par v: " << p << endl;

    cout << "Creation d'un point p1..." << endl;
    CPoint3D p1(0, 0, 0);
    cout << "p1: " << p1 << endl;

    p1 = p1 + v;

    cout << "p1 apres translation par v: " << p1 << endl;

    CCouleur C1(0, 0, 255);
    CCouleur C2(255, 0, 0);
    cout << "Couleur1: " << C1 << endl;
    cout << "Couleur2: " << C2 << endl;

    cout << "Couleur1 = Couleur2" << endl;
    C1 = C2;
    cout << "Couleur1: " << C1 << endl;

    return 0;
}