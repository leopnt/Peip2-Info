#ifndef CINDIVIDU
#define CINDIVIDU

#include <iostream>
#include <cstring>

class CIndividu
{
protected:
    char* m_nom;
    char* m_prenom;
    int m_annee_naissance;

    void afficher(std::ostream& out) const;
    friend std::ostream& operator<<(std::ostream &out, CIndividu const& self);
    void saisir(std::istream& in);
    friend std::istream& operator>>(std::istream &in, CIndividu & self);

public:
    CIndividu();
    CIndividu(CIndividu const& individu);
    CIndividu(char* const& nom, char* const& prenom, int const& annee_naissance);
    ~CIndividu();
};


#endif