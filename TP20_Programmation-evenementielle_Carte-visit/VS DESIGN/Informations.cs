using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correction_TP20_EDI
{
    public class Informations
    {

        public String txtBx_Societe;
        public String txtBx_Titre;
        public String txtBx_Description;
        public String txtBx_Telephone;
        public String txtBx_Adresse;
        public String txtBx_Website;
        public Informations()
        {

        }

        public Informations(string txtBx_Societe, string txtBx_Titre, string txtBx_Description, string txtBx_Telephone, string txtBx_Adresse, string txtBx_Website)
        {
            this.txtBx_Societe = txtBx_Societe;
            this.txtBx_Titre = txtBx_Titre;
            this.txtBx_Description = txtBx_Description;
            this.txtBx_Telephone = txtBx_Telephone;
            this.txtBx_Adresse = txtBx_Adresse;
            this.txtBx_Website = txtBx_Website;
        }

        public Informations(string txtBx_Societe, String txtBx_Titre, String txtBx_Description, String txtBx_Telephone, String txtBx_Adresse, String txtBx_Website, string societe)
        {
            txtBx_Societe = txtBx_Societe;
            txtBx_Titre = txtBx_Titre;
            txtBx_Description = txtBx_Description;
            txtBx_Telephone = txtBx_Telephone;
            txtBx_Adresse = txtBx_Adresse;
            txtBx_Website = txtBx_Website;
        }
    }
}
