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
    /// Logique d'interaction pour WindowContact.xaml
    /// </summary>
    public partial class WindowContact : Window
    {
        Client client;
        Commande commande;
        Pizzeria pizzeria;
        public WindowContact(Client client,Commande commande, Pizzeria pizzeria)
        {
            this.pizzeria = pizzeria;
            this.client = client;
            this.commande = commande;
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //ouvre la page commander si il appuit sur le bouton Commander
        {
            WindowCommander c = new WindowCommander(client, commande,pizzeria);
            c.Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)// Signifie au client qu'il est déjà sur la page souhaité
        {
            MessageBox.Show(" Vous êtes déjà sur la page pour Contact.", "", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.Cancel, MessageBoxOptions.ServiceNotification);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) // Rassure le client  
        {
            messageClient.Text = $" Nous vous remercions pour votre message nous allons vous répondre sur votre mail({client.Mail}).";

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)  //ouvre la page Adresse si il appuit sur le bouton Adresse 
        {
            WindowAdresse a = new WindowAdresse(client, commande,pizzeria);
            a.Show();
            Close();
        }
    }
}
