#ifndef CINDIVIDU
#define CINDIVIDU

#include <iostream>
#include <cstring>

class CIndividu
{
private:
    char* m_nom;
    char* m_prenom;
    int m_annee_naissance;

public:
    CIndividu();
    CIndividu(CIndividu const& individu);
    CIndividu(char* const& nom, char* const& prenom, int const& annee_naissance);
    ~CIndividu();

    friend std::ostream& operator<<(std::ostream &out, CIndividu const& self);
    friend std::istream& operator>>(std::istream &in, CIndividu & self);
};


#endif