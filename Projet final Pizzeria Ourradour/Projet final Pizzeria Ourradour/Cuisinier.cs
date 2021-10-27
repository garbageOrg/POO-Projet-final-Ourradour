using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_final_Pizzeria_Tetard_Ourradour
{
    class Cuisinier : Employe
    {
        string niveau;

        public Cuisinier(string nom, string prenom, string adresse, int identifiant, string etat, string niveau) : base(nom, prenom, adresse, identifiant, etat)
        {
            this.niveau = niveau;
        }
    }
}
