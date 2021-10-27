using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_final_Pizzeria_Tetard_Ourradour
{
    class Livreur :Employe
    {
        string vehicule;

        public Livreur(string nom, string prenom, string adresse, int identifiant, string etat, string vehicule) : base(nom, prenom, adresse, identifiant, etat)
        {
            this.vehicule = vehicule;
        }
    }
}
