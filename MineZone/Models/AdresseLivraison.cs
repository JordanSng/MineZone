using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineZone.Models
{
    public class AdresseLivraison : Adresse
    {
        private string NomLivraison { get; set; }
        private string PrenomLivraison { get; set; }

        public AdresseLivraison(int numero, string nomAdresse, int codePostal, string pays, string nomLivraison, string prenomLivraison) 
            : base(numero, nomAdresse, codePostal, pays)
        {

        }
    }


}
