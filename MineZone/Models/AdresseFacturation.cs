using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineZone.Models
{
    public class AdresseFacturation : Adresse
    {
        private string NomFacturation { get; set; }
        private string PrenomFacturation { get; set; }

        public AdresseFacturation(int numero, string nomAdresse, int codePostal, string pays, string nomFacturation, string prenomFacturation) 
            : base(numero, nomAdresse, codePostal, pays)
        {
            NomFacturation = nomFacturation;
            PrenomFacturation = prenomFacturation;
        }
    }


}
