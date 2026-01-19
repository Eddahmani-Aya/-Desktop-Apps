using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Correction_TP19_EDI
{
    public class Class1
    {
        public string Nom;
        public string Prenom;
        public string Telephone;
        public string Adresse;
        public string Poste;
        public DateTime Naissance;
        public string Diplomes;
        public string Skills;
        public string Genre;
        public string Langue;


        public Class1(string Nom, string Prenom, string Telephone, string Adresse, string Poste, DateTime Naissance, string Diplomes, string Skills, string Genre, string Langue)
        {
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Telephone = Telephone;
            this.Adresse = Adresse;
            this.Poste = Poste;
            this.Naissance = Naissance;
            this.Diplomes = Diplomes;
            this.Skills = Skills;
            this.Genre = Genre;
            this.Langue = Langue;
        }
        
        
    }
}
            