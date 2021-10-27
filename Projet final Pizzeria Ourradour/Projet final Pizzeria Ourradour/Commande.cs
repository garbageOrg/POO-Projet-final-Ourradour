using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_final_Pizzeria_Tetard_Ourradour
{
    public class Commande
    {
        string nomRestaurant;
        List<ProduitAnnexe> accompagnements;
        List<Pizza> listPizza;
        Livraison livraison;
        double facture;
        int numCommande;
        DateTime priseCommande;
        Client client;
        Commis commis;


        public Commande(Client client   ,int numCommande)
        {
            this.nomRestaurant = "Buddy's Pizza";
            this.client = client;
            accompagnements = new List<ProduitAnnexe>() { };
            listPizza = new List<Pizza> { };
            this.numCommande = numCommande;
            this.facture = PrixCommande();
           
        }

        public string NomRestaurant
        {
            get { return nomRestaurant; }
            set { nomRestaurant = value; }
        }
        public List<ProduitAnnexe> Accompagnements
        {
            get { return accompagnements; }
            set { accompagnements = value;  }
        }
        public List<Pizza> ListPizza
        {
            get { return listPizza; }
            set { listPizza = value; }
        }

        public Livraison Livraison
        {
            get { return livraison; }
            set { livraison = value; }
        }

        public double Facture
        {
            get { return facture; }
            set { facture = value; }
        }

        public int Numcommande
        {
            get { return numCommande; }
            set { numCommande = value; }
        }

        public DateTime PriseCommande
        {
            get { return priseCommande; }
            set { priseCommande = value; }
        }

        public Client Client
        {
            get { return client; }
            set { client = value; }
        }

        public Commis Commis
        {
            get { return commis; }
            set { commis = value; }
        }
        public void TriListPizza() // Tri une liste de pizza par rapport à leur nom de pizza
        {
            
            listPizza.Sort((x, y) => x.NomPizza.CompareTo(y.NomPizza));
        }
        public void TriListAccompagnement() // Tri une liste de produit annexe par rapport à leur attribut nom 
        {
            accompagnements.Sort((x, y) => x.NomProduitAnnexe.CompareTo(y.NomProduitAnnexe));
        }

        public void AjouterPizza(Pizza z) // Ajoute une pizza dans la commande
        {
            listPizza.Add(z);
            facture += z.PrixPizza;
            TriListPizza();
        }

        public void AjouterProduitAnnexe(ProduitAnnexe p) // Ajoute un produit annexe dans la commande
        {
            accompagnements.Add(p);
            facture += p.PrixProduitAnnexe;
            TriListAccompagnement();
        }

        public string RemiseMenu() // Effectue une remise sur la facture de 3 euros pour chaque lot de pizza produit annexe dans la commande et renvoie un string contenant le nombre de menu
        {
            int nbmenu = Math.Min(accompagnements.Count, listPizza.Count);
            facture -= 3 * nbmenu;
            return $"Vous avez bénéficié {nbmenu} fois de l'offre de Menu.";
        }
        public double PrixCommande() // Renvoie et Calcul le prix de la commande
        {
            double total = 0;

            for (int i = 0; i < listPizza.Count; i++)
            {
                total += ListPizza[i].PrixPizza;
            }
            for (int i = 0; i < accompagnements.Count; i++)
            {
                total += accompagnements[i].PrixProduitAnnexe;
            }
            facture = total;
            return total;

        }
        public string stringAfficheCommande(Commande commande) // Renvoie le détail de la commande sous forme d'un string
        {
            string retour = $"Commande numéro :{commande.Numcommande}\n     PIZZA                   PRIX ";

            for (int i = 0; i < commande.ListPizza.Count; i++)
            {
                string espace = "";
                if (commande.ListPizza[i].Taille == "Grande" || commande.ListPizza[i].Taille == "Petite")
                {
                    espace += " ";
                }
                retour += $"\n{commande.ListPizza[i].Taille[0]}" + espace + ": " + commande.ListPizza[i].NomPizza;
                if (commande.ListPizza[i].NomPizza == "Margarita")
                {

                    retour += $"             {commande.ListPizza[i].PrixPizza} €";
                }
                else if (commande.ListPizza[i].NomPizza == "Reine")
                {
                    retour += $"                   {commande.ListPizza[i].PrixPizza} €";
                }
                else if (commande.ListPizza[i].NomPizza == "Sauvage")
                {
                    retour += $"               {commande.ListPizza[i].PrixPizza} €";
                }
            }

            retour += $"\n\nFrais de livraison       2.90 € \n -----------------------------\nTOTAL:                       {commande.Facture + 2.9} €";
            return retour;
        }
    }
}
