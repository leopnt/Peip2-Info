#include <iostream>
using namespace std;

#include "CObjGraph.h"
#include "CSegment.h"
#include "CCercle.h"

#include <vector>

int main() {

    CObjGraph* m_pForme(NULL);
    m_pForme = new CObjGraph;

    cout << m_pForme->get_type() << endl;;
    //affiche "Classe de base" OK..

    delete m_pForme;
    m_pForme = NULL;

    //pointage vers un CSegment
    m_pForme = new CSegment;

    cout << m_pForme->get_type() << endl;
    //affiche "Classe de base" si la méthode get_type de CObjGraph n'est pas virtual...
    //si on utilise: virtual char* get_type() const; ,on appel bien
    //la version get_type() de la classe CSegment.

    delete m_pForme;
    m_pForme = NULL;

    //pointage vers un CCercle
    m_pForme = new CCercle;

    cout << m_pForme->get_type() << endl;

    delete m_pForme;
    m_pForme = NULL;


    /* méthode avec tableau dynamique de pointeurs: */
    CObjGraph* tabp[5];

    tabp[0] = new CSegment;
    tabp[1] = new CCercle;
    tabp[2] = new CCercle;
    tabp[3] = new CSegment;
    tabp[4] = new CCercle;

    for(int i = 0; i < 5; i++) {
        cout << "tabp[" << i << "]: " << tabp[i]->get_type() << endl;
    }

    //désallocation de chaque pointeurs
    for(int i = 0; i < 5; i++) {
        delete tabp[i];
        tabp[i] = NULL;
    }

    cout << endl << "Methode vector: " << endl;

    //méthode avec vector
    vector<CObjGraph*> tabv;
    tabv.push_back(new CSegment);
    tabv.push_back(new CCercle);
    tabv.push_back(new CCercle);
    tabv.push_back(new CSegment);
    tabv.push_back(new CCercle);

    for(int i = 0; i < tabv.size(); i++) {
        cout << "tabv[" << i << "]: " << tabv[i]->get_type() << endl;
    }

    for(int i = 0; i < tabv.size(); i++) {
        delete tabv[i];
        tabv[i] = NULL;
    }

    return 0;
}