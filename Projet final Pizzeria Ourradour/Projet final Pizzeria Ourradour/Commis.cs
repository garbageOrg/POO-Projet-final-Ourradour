using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_final_Pizzeria_Tetard_Ourradour
{
    public class Commis : Employe
    {
        DateTime recrutement;


        public Commis(string nom, string prenom, string adresse, int identifiant, string etat, DateTime recrutement) : base(nom, prenom, adresse, identifiant, etat)
        {
            this.recrutement = recrutement;
        }
    }
}
