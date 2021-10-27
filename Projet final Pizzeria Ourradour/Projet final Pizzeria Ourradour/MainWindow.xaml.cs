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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projet_final_Pizzeria_Tetard_Ourradour
{
    /// <summary> Windo
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Client client;
        Commande Commande;
        Pizzeria pizzeria;
        public MainWindow(Client client, Commande commande,Pizzeria pizzeria)  // Nous avons mis les objets client Commande  Pizzaria dans TOUS les conctructeurs de window pour stocker ces informations et les modifier tout le long de la navigation de l'utilisateur
        {
            this.pizzeria = pizzeria;
            this.client = client;
            this.Commande = commande;
            InitializeComponent();
        }

     
        private void BouttoncliqueCommander(object sender, RoutedEventArgs e) // ouvre la page commander si il appuit sur le bouton Commander
        {
            WindowCommander c = new WindowCommander(client, Commande,pizzeria);
            c.Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e) //ouvre la page Adresse si il appuit sur le bouton Adresse
        {
            WindowAdresse a = new WindowAdresse(client, Commande,pizzeria);
            a.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // ouvre la page Contact si il appuit sur le bouton Contact
        {
            WindowContact c = new WindowContact(client, Commande,pizzeria);
            c.Show();
            Close();
        }
    }

}
