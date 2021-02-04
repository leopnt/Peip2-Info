#include <iostream>
using namespace std;
#include "CIndividu.h"

int main() {
    CIndividu test( (char*) "BG", (char*) "Leo", 2048);
    cout << test << endl;

    CIndividu yo;
    
    cin >> yo;

    cout << yo << endl;

    return 0;
}