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
    /// Logique d'interaction pour WindowAdresse.xaml
    /// </summary>
    public partial class WindowAdresse : Window
    {
        Client client;
        Commande commande;
        Pizzeria pizzeria;
        public WindowAdresse(Client client, Commande commande, Pizzeria pizzeria)
        {
            this.pizzeria = pizzeria;
            this.client = client;
            this.commande = commande;
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)//ouvre la page commander si il appuit sur le bouton Commander
        {
            WindowCommander c = new WindowCommander(client, commande,pizzeria);
            c.Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)// ouvre la page Contact si il appuit sur le bouton Contact
        {

            WindowContact c = new WindowContact(client, commande,pizzeria);
            c.Show();
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) // Signifie au client qu'il est déjà sur la page souhaité
        {
            MessageBox.Show(" Vous êtes déjà sur la page pour Adresse.", "", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.Cancel, MessageBoxOptions.ServiceNotification);
        }
    }
}
