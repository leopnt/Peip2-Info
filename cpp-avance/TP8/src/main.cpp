#include <iostream>
using namespace std;

#include "CObjGraph.h"
#include "CSegment.h"
#include "CCercle.h"

int main() {

    CCercle c;

    cout << "Entrez les informations pour le cercle:" << endl;
    cin >> c;

    cout << c << endl;

    int dx(0), dy(0);
    cout << "translater de: " << endl << "dx? > ";
    cin >> dx;
    cout << "dy? > ";
    cin >> dy;

    c.translate(dx, dy);

    cout << "Le cercle apres translation: " << endl << c << endl;

    return 0;
}