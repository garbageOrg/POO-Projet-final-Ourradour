using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Projet_final_Pizzeria_Tetard_Ourradour
{
    /// <summary>
    /// Logique d'interaction pour WindowPanier.xaml
    /// </summary>
    public partial class WindowPanier : Window
    {
        Client client;
        Commande commande;
        List<Button> listbutton;
        Pizzeria pizzeria;
        public WindowPanier(Client c,Commande commande, Pizzeria pizzeria)
        {
            this.pizzeria = pizzeria;
            this.client = c;
            this.commande = commande;
            listbutton = new List<Button> { BouttonSup1 , BouttonSup2, BouttonSup3, BouttonSup4, BouttonSup5, BouttonSup6 };

            

            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowCommander c = new WindowCommander(client, commande,pizzeria);
            c.Show();
            Close();
             
        }
        public void AfficheCommande()
        {
            string retour = commande.ListPizza[0].NomPizza;

            for (int i = 1; i < commande.ListPizza.Count;  i++)
            {
                retour += "\n"+commande.ListPizza[i].NomPizza;
            }
            
            MonTextBox.Text= retour;
           
        }

        private void BouttonSup1Clique(object sender, RoutedEventArgs e)
        {
            if (commande.ListPizza.Count == 6)
            {
                BouttonSup6.Opacity = 0;
            }
            if (commande.ListPizza.Count == 5)
            {
                BouttonSup5.Opacity = 0;
            }
            if (commande.ListPizza.Count == 4)
            {
                BouttonSup4.Opacity = 0;
            }
            if (commande.ListPizza.Count == 3)
            {
                BouttonSup3.Opacity = 0;
            }
            if (commande.ListPizza.Count == 2)
            {
                BouttonSup2.Opacity = 0;
            }
            if (commande.ListPizza.Count == 1)
            {
                BouttonSup1.Opacity = 0;
            }
            commande.ListPizza.RemoveAt(0);
            commande.Facture = commande.PrixCommande();
            MonTextBox.Text = commande.stringAfficheCommande(commande);
            //listbutton[commande.ListPizza.Count].Opacity = 0;
       



        }

        private void BouttonSup2clique(object sender, RoutedEventArgs e)
        {

            if (commande.ListPizza.Count == 6)
            {
                BouttonSup6.Opacity = 0;
            }
            if (commande.ListPizza.Count == 5)
            {
                BouttonSup5.Opacity = 0;
            }
            if (commande.ListPizza.Count == 4)
            {
                BouttonSup4.Opacity = 0;
            }
            if (commande.ListPizza.Count == 3)
            {
                BouttonSup3.Opacity = 0;
            }
            if (commande.ListPizza.Count == 2)
            {
                BouttonSup2.Opacity = 0;
            }
            commande.ListPizza.RemoveAt(1);
            commande.Facture = commande.PrixCommande();
            MonTextBox.Text = commande.stringAfficheCommande(commande);
            //listbutton[commande.ListPizza.Count - 1].Opacity = 0;
            

        }

        private void BouttonSup3clique(object sender, RoutedEventArgs e)
        {
            if (commande.ListPizza.Count == 6)
            {
                BouttonSup6.Opacity = 0;
            }
            if (commande.ListPizza.Count == 5)
            {
                BouttonSup5.Opacity = 0;
            }
            if (commande.ListPizza.Count == 4)
            {
                BouttonSup4.Opacity = 0;
            }
            if (commande.ListPizza.Count == 3)
            {
                BouttonSup3.Opacity = 0;
            }
            commande.ListPizza.RemoveAt(2);
            commande.Facture = commande.PrixCommande();
            MonTextBox.Text = commande.stringAfficheCommande(commande);
            //listbutton[commande.ListPizza.Count-1].Opacity = 0;
            
            
        }

        private void BouttonSup4clique(object sender, RoutedEventArgs e)
        {

            if (commande.ListPizza.Count == 6)
            {
                BouttonSup6.Opacity = 0;
            }
            if (commande.ListPizza.Count == 5)
            {
                BouttonSup5.Opacity = 0;
            }
            if (commande.ListPizza.Count == 4)
            {
                BouttonSup4.Opacity = 0;
            }
            commande.ListPizza.RemoveAt(3);
            commande.Facture = commande.PrixCommande();
            MonTextBox.Text = commande.stringAfficheCommande(commande);
            //listbutton[commande.ListPizza.Count-1].Opacity = 0;
            

        }

        private void BouttonSup5clique(object sender, RoutedEventArgs e)
        {

            if (commande.ListPizza.Count == 6)
            {
                BouttonSup6.Opacity = 0;
            }
            if (commande.ListPizza.Count == 5)
            {
                BouttonSup5.Opacity = 0;
            }
            commande.ListPizza.RemoveAt(4);
            commande.Facture = commande.PrixCommande();
            MonTextBox.Text = commande.stringAfficheCommande(commande);
            //listbutton[commande.ListPizza.Count].Opacity = 0;
           
        }

        private void BouttonSup6clique(object sender, RoutedEventArgs e)
        {
            commande.ListPizza.RemoveAt(5);
            commande.Facture = commande.PrixCommande();
            MonTextBox.Text = commande.stringAfficheCommande(commande);
            //listbutton[commande.ListPizza.Count].Opacity = 0;
            BouttonSup6.Opacity = 0;
        }

        private void ButtonCLiqueTerminer(object sender, RoutedEventArgs e)
        {
            var butYesNo = MessageBox.Show("Etes vous sûr de terminer votre commande?", "Finaliser la commande", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (butYesNo == MessageBoxResult.Yes)
            {
                MessageBox.Show($"Nous vous remercions Monsieur.{client.Nom} d'avoir passer votre commande chez Buddy's Pizza. Votre commande vous sera livré au {client.Adresse} incessamment  sous peu","A la prochain!",MessageBoxButton.OK);
                
                pizzeria.EntreCommande();
                pizzeria.ListCommande.Add(commande);
                pizzeria.EnregistrementCommande();
                Close();

            }
        }

        
    }
}
