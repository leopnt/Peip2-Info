#include <iostream>
using namespace std;

#include "CObjGraph.h"

int main() {

    CObjGraph o;

    cin >> o;

    cout << o << endl;

    cout << "x: " << o.get_x() << " y: " << o.get_y() <<
    " couleur: " << o.get_couleur() << " epaisseur: " <<
    o.get_epaisseur() << endl;

    return 0;
}