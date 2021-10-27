using System;
using System.IO;
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
    /// Logique d'interaction pour Identification.xaml
    /// </summary>
    public partial class Identification : Window
    {
        public Identification()
        {
            InitializeComponent();
        }

       

        

        public void BouttonCliqueContinuer(object sender, RoutedEventArgs e)
        {
            
            
            bool textBoxTel = Int32.TryParse(TelephoneTextBox.Text,out int num);
            if (textBoxTel)
            {
               var verif = MessageBox.Show($" Vous validez les informations suivantes?\nNom: {NomTextBox.Text}\nPrénom: {PrenomTextBox.Text}\nAdressse: {AdresseTextBox.Text}\nMail: {MailTextBox.Text}\nTéléphone: 0{num}","Vérification",MessageBoxButton.YesNo,MessageBoxImage.Question);
               if(verif == MessageBoxResult.Yes) // Si le client clique sur Yes et est donc satisfait de son profil client
                {
                   Client utilisateur = new Client(NomTextBox.Text, PrenomTextBox.Text, AdresseTextBox.Text, MailTextBox.Text, num, DateTime.Now.Year);
                    Commande CommandeClient = new Commande(utilisateur ,0);
                    Pizzeria buddy = new Pizzeria();
                    buddy.EntreClient();
                    buddy.ListClient.Add(utilisateur);
                    buddy.EnregistrementClient();
                    CommandeClient.Numcommande = buddy.ListClient.Count;




                    MainWindow w = new MainWindow(utilisateur,CommandeClient,buddy); 
                    w.Show(); // ouvre la page d'acceuil
                    Close(); // ferme cette page
                }
               
            }
            else// bloque si le numéro n'est pas composé que de chiffres pour éviter des bugs
            {
                MessageBox.Show("Votre numéro de téléphone n'est pas exploitable."); 
                TelephoneTextBox.Text = null;
            }

        }
    }
}
