using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_final_Pizzeria_Tetard_Ourradour
{
    public class Client
    {
        string nom;
        string prenom;
        string adresse;
        string ville;
        string mail;
        int numerotel;
        int premierecommande;
        

        public Client(string nom, string prenom, string adresse, string mail ,int numerotel, int premierecommande)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.numerotel = numerotel;
            this.mail = mail;
            this.ville = ObtenirVille();
            this.premierecommande = premierecommande;

        }

        public string Nom
        {
            get { return nom; }
        }
        public string Prenom
        {
            get { return prenom; }
        }
        public string Adresse
        {
            get { return adresse; }
        }

        public int Numerotel
        {
            get { return numerotel; }
        }

        public string Ville
        {
            get { return ville; }
        }
        public string Mail
        {
            get { return mail; }
        }

        public string ObtenirVille() // Permet de renvoyer la ville du client ex: nous renvoie Bordeaux pour adresse = 24 rue dubourdieu 33800 Bordeaux 
        {
            string[] elementsAdresse = Adresse.Split(' ');
            string ville = elementsAdresse[elementsAdresse.Length - 1];
            return ville;
        }
        public int PremiereCommande
        {
            get { return premierecommande; }
        }

        public int FideliteAnnee() // Renvoie le nombre d'années qui séparent la première commande d'aujourd'hui
        {
           return DateTime.Now.Year-premierecommande;
        }

        public static void TriClientNom(List<Client> c) // Tri une liste de client par rapport à leur attribut nom
        {
            c.Sort((x, y) => x.nom.CompareTo(y.nom));
        }
        public static void TriclientVille(List<Client> c)// Tri une liste de client par rapport à leur attribut ville
        {
            
            c.Sort((x, y) => x.ville.CompareTo(y.ville));
        }
        public override string ToString() // Renvoie l'attribut nom du client pour l'objet client
        {
            return nom;
        }

        public  static void AjouterClientFihier(Client c) // Ajoute un client à notre fichier excel contenant les clients
        {
            StreamWriter fichierClient = new StreamWriter("test.csv", false);
            fichierClient.WriteLine();
            fichierClient.Close();
        }
    }
}
