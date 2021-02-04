#ifndef CCOULEUR
#define CCOULEUR

#include <iostream>
#include <vector>

class CCouleur
{
protected:
    std::vector<int> m_color;

    void afficher(std::ostream& out) const;
    friend std::ostream& operator<<(std::ostream& out, CCouleur const& self);
    /*
    void saisir(std::istream& in);
    friend std::istream& operator>>(std::istream& in, CCouleur & self);
    */
    
public:
    CCouleur();
    CCouleur(int const& R, int const& G, int const& B);
    ~CCouleur();
    void operator=(CCouleur const& couleur);
};

#endif