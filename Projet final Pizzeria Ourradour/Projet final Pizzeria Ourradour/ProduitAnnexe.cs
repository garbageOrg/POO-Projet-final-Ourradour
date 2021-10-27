using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_final_Pizzeria_Tetard_Ourradour
{
   public class ProduitAnnexe
    {
        double prixProduitAnnexe;
        string nomProduitAnnexe;

        public ProduitAnnexe(double prixProduitAnnexe,string nomProduitAnnexe)
        {
            this.prixProduitAnnexe = prixProduitAnnexe;
            this.nomProduitAnnexe = nomProduitAnnexe;
        }
        
        public double PrixProduitAnnexe
        {
            get { return prixProduitAnnexe; }
           
        }

        public string NomProduitAnnexe
        {
            get { return nomProduitAnnexe; }
        }

    }

}
