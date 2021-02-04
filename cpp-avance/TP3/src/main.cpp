#include <iostream>
using namespace std;

#include "CIndividu.h"
#include "CSalarie.h"
#include "CEntreprise.h"


int main() {

    CEntreprise mon_entreprise;

    cin >> mon_entreprise;
    cout << mon_entreprise << endl;    

    cout << "Masse Salariale: " << mon_entreprise.calc_masse_salariale() << endl;

    return 0;
}