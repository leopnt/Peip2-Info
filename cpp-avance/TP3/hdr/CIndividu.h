#ifndef CINDIVIDU
#define CINDIVIDU

#include <iostream>

class CIndividu
{
protected:
    std::string m_nom;
    std::string m_prenom;
    int m_annee_naissance;

    void affiche(std::ostream& out) const;
    void saisir(std::istream &in);

    friend std::ostream& operator<<(std::ostream &out, CIndividu const& self);
    friend std::istream& operator>>(std::istream &in, CIndividu & self);

public:
    CIndividu();
    CIndividu(CIndividu const& individu);
    CIndividu(std::string const& nom, std::string const& prenom, int const& annee_naissance);
    ~CIndividu();
};


#endif