#ifndef CVECTEUR
#define CVECTEUR

#include <iostream>
#include <vector>

class CVecteur
{
protected:
    std::vector<int> m_composantes;

    void afficher(std::ostream& out) const;
    friend std::ostream& operator<<(std::ostream& out, CVecteur const& self);
    void saisir(std::istream& in);
    friend std::istream& operator>>(std::istream& in, CVecteur & self);

public:
    CVecteur();
    CVecteur(int const& nb_composante);
    CVecteur(CVecteur const& nouveauVecteur);
    ~CVecteur();

    int getComposante(int const& indice) const;
    int size() const;
};

#endif