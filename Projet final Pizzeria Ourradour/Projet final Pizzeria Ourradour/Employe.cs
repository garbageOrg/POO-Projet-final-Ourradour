using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_final_Pizzeria_Tetard_Ourradour
{
    abstract public class Employe
    {

        protected string nom;
        protected string prenom;
        protected string adresse;
        protected int identifiant;
        protected string etat;
    
        public Employe(string nom, string prenom, string adresse, int identifiant, string etat)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.identifiant = identifiant;
            this.etat = etat;
        }





    }
}

