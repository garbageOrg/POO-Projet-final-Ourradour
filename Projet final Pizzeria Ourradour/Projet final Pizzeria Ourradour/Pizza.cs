using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_final_Pizzeria_Tetard_Ourradour
{
    public class Pizza
    {
        string nomPizza;
        double prixPizza;
        string taille;
        
        DateTime tempsPreparation;
        DateTime cuisson;
            
        public Pizza(string nomPizza,double prixPrizza,string taille)
        {
            this.nomPizza = nomPizza;
            this.prixPizza = prixPrizza;
            this.taille = taille;

        }

        public string NomPizza
        {
            get { return nomPizza; }
            set { nomPizza = value; }
        }

        public double PrixPizza
        {
            get { return prixPizza; }
            set { prixPizza = value; }
        }

        public string Taille
        {
            get { return taille; }
            set { taille = value; }
        }
       
       
        public DateTime TempsPreparation
        {
            get { return tempsPreparation; }
            set { tempsPreparation = value; }
        }
        public DateTime Cuisson
        {
            get { return cuisson; }
            set { cuisson = value; }
        }
    }
}
