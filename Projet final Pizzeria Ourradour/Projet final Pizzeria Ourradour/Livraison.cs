using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_final_Pizzeria_Tetard_Ourradour
{
    public class Livraison
    {
        Client client;
        double facture;
        Commande commande;

        public Livraison(double facture,Commande commande, Client client)
        {
            this.client = client;
            this.commande = commande;
            this.facture = facture;
        }

        public Client Client
        {
            get { return client; }
            set { client = value; }
        }
    }
}
