    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projet_final_Pizzeria_Tetard_Ourradour
{
    public class Pizzeria
    {
        string nom;
        List<Client> listClient;
        List<Commande> listCommande;
        List<Employe> listEmploye;
       

        public Pizzeria()
        {
            nom = "Buddy's Pizza";
            this.listClient = new List<Client>() { };
            listCommande = new List<Commande>() { };
            listEmploye = new List<Employe>() { };
        }

        public List<Client> ListClient
        {
            get { return listClient; }
            set { listClient = value; }
        }

        public List<Commande> ListCommande
        {
            get { return listCommande; }
            set { listCommande = value; }
        }
        public List<Employe> ListEmploye
        {
            get { return listEmploye; }
            set { listEmploye = value; }
        }

        public void EntreClient () // Crée tous les clients qui sont dans notre fichier excel et les rentre dans la liste de clients
        {
            StreamReader lire = new StreamReader("fichierclient.csv");
           
            while ( lire.Peek()>0)
            {
                string[] client = lire.ReadLine().Split(';');
                Client c = new Client(client[0], client[1], client[2], client[3], Convert.ToInt32(client[4]), Convert.ToInt32(client[5]));
                listClient.Add(c);
            }
            lire.Close();
        }

        public void EnregistrementClient () // Rentre tous les clients de notre liste client dans notre fichier excel liste Clients
        {
            StreamWriter ecrire = new StreamWriter("fichierclient.csv", false);
            foreach (Client c in listClient)
            {
                ecrire.WriteLine(($"{c.Nom};{c.Prenom};{c.Adresse};{c.Mail};{c.Numerotel};{c.PremiereCommande}"));
            }
            ecrire.Close();
             
        }

        public void EntreCommande () // Crée toutes les commandes qui sont dans notre fichier excel et les rentre dans la liste de commande
        {
            StreamReader lire = new StreamReader("fichiercommande.csv");
            int i = 0;          
            while (lire.Peek() > 0)
            {
                string[] commande = lire.ReadLine().Split(';');
                listCommande.Add(new Commande(listClient[i], i));
                i++;
            }
            lire.Close();


        }
        public void EnregistrementCommande()// Rentre toutes les commandes de notre liste commande dans notre fichier excel liste commande
        {
            StreamWriter ecrire = new StreamWriter("fichiercommande.csv", false);
            foreach (Commande c in listCommande)
            {
                ecrire.WriteLine(($"{c.Client};{c.Numcommande}"));
            }
            ecrire.Close();

        }

        public double  prixMoyenCommande()
        {
            double somme = 0;
            for (int i = 0; i < listCommande.Count ; i++)
            {
                somme += listCommande[i].PrixCommande();
            }
            somme = somme / (double) listCommande.Count;

           return somme;
        }


    }
}
