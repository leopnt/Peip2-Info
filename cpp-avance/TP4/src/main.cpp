#include <iostream>
using namespace std;

#include "CVecteur.h"
#include "CPoint2D.h"

int main() {

    CPoint2D p;
    cin >> p;
    cout << "p: " << p << endl;

    CVecteur v(2);
    cin >> v;

    p = p + v; //translation par le vecteur v

    cout << "p apres translation: " << p << endl;

    return 0;
}