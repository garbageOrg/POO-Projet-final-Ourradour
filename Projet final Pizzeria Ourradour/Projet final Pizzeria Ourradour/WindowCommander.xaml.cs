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
    /// Logique d'interaction pour WindowCommander.xaml
    /// </summary>
    public partial class WindowCommander : Window
    {
        Client client;
        Commande commande;
        Pizzeria pizzeria;
        public WindowCommander(Client client , Commande commande, Pizzeria pizzeria)
        {
            this.pizzeria = pizzeria;
            this.client = client;
            this.commande = commande;
            InitializeComponent();
        }

   

        private void Button_Click_1(object sender, RoutedEventArgs e) // Signifie au client qu'il est déjà sur la page souhaité
        {
            MessageBox.Show(" Vous êtes déjà sur la page pour Commander.", "", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.Cancel, MessageBoxOptions.ServiceNotification);
        }

        private void Button_Click(object sender, RoutedEventArgs e)// ouvre la page Contact si il appuit sur le bouton Contact
        {
            WindowContact c = new WindowContact(client, commande,pizzeria);
            c.Show();
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) //ouvre la page Adresse si il appuit sur le bouton Adresse

        {
                WindowAdresse a = new WindowAdresse(client, commande,pizzeria);
                a.Show();
                Close();
            }

        private void CliqueBouttonMargarita(object sender, RoutedEventArgs e) // ajouter une margarité
        {
            ComboBoxItem cbi = (ComboBoxItem)MyComboBox.SelectedItem;

            if (cbi != null) // si le client  a choisi sa taille
            {
                string selectedText = cbi.Content.ToString();


                if (selectedText == "Grande")
                {
                    Pizza margarita = new Pizza("Margarita", 18.50, selectedText);
                    commande.AjouterPizza(margarita);

                }
                else if (selectedText == "Moyenne")
                {
                    Pizza margarita = new Pizza("Margarita", 15.50, selectedText);
                    commande.AjouterPizza(margarita);
                }
                else if (selectedText == "Petite")
                {
                    Pizza margarita = new Pizza("Margarita", 12.50, selectedText);
                    commande.AjouterPizza(margarita);
                }
                LabelNotification.Content = $"Vous avez ajouté une pizza Margarita de taille {selectedText} à votre commande.";
            }
            else
            {
                MessageBox.Show("Sélectionnez une taille.","Erreur",MessageBoxButton.OK,MessageBoxImage.Error);
            }
            MyComboBox.Text = " -- Choississez votre taille --";
        }

        private void CliqueBouttonReine(object sender, RoutedEventArgs e)
        {
            ComboBoxItem cbi = (ComboBoxItem)MyComboBox.SelectedItem;

            if (cbi != null)
            {
                string selectedText = cbi.Content.ToString();


                if (selectedText == "Grande")
                {
                    Pizza reine = new Pizza("Reine", 12.50, selectedText);
                    commande.AjouterPizza(reine);

                }
                else if (selectedText == "Moyenne")
                {
                    Pizza reine = new Pizza("Reine", 17.50, selectedText);
                    commande.AjouterPizza(reine);
                }
                else if (selectedText == "Petite")
                {
                    Pizza reine = new Pizza("Reine", 14.50, selectedText);
                    commande.AjouterPizza(reine);

                }
                LabelNotification.Content = $"Vous avez ajouté une pizza Reine de taille {selectedText} à votre commande.";
            }
            else
            {
                MessageBox.Show("Sélectionnez une taille.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            MyComboBox.Text = " -- Choississez votre taille --";
        }

        private void CliqueBouttonSauvage(object sender, RoutedEventArgs e)
        {
            ComboBoxItem cbi = (ComboBoxItem)MyComboBox.SelectedItem;

            if (cbi != null)
            {
                string selectedText = cbi.Content.ToString();


                if (selectedText == "Grande")
                {
                    Pizza sauvage = new Pizza("Sauvage", 19.50, selectedText);
                    commande.AjouterPizza(sauvage);

                }
                else if (selectedText == "Moyenne")
                {
                    Pizza sauvage = new Pizza("Sauvage", 16.50, selectedText);
                    commande.AjouterPizza(sauvage);
                }
                else if (selectedText == "Petite")
                {
                    Pizza sauvage = new Pizza("Sauvage", 13.50, selectedText);
                    commande.AjouterPizza(sauvage);
                }
                LabelNotification.Content = $"Vous avez ajouté une pizza Sauvage de taille {selectedText} à votre commande";
            }
            else
            {
                MessageBox.Show("Sélectionnez une taille.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            MyComboBox.Text = " -- Choississez votre taille --";
        }

        public void Button_Click_3(object sender, RoutedEventArgs e)
        {
          WindowPanier p = new WindowPanier(client, commande,pizzeria);
          p.MonTextBox.Text = commande.stringAfficheCommande(commande);
          int i = commande.ListPizza.Count;
            if(i<6)
            {
                p.BouttonSup6.Opacity = 0;
            }
            if (i < 5)
            {
                p.BouttonSup5.Opacity = 0;
            }
            if (i < 4)
            {
                p.BouttonSup4.Opacity = 0;
            }
            if (i < 3)
            {
                p.BouttonSup3.Opacity = 0;
            }
            if (i < 2)
            {
                p.BouttonSup2.Opacity = 0;
            }
             if (i < 1)
            {
                p.BouttonSup1.Opacity = 0;
            }


            p.BouttonSup6.Opacity = 0;
          p.Show();
          Close();
        }
    }


}
 