using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineZone.Models
{
    public abstract class Adresse
    {
        private int Numero { get; set; }
        private string NomAdresse { get; set; }
        private int CodePostal { get; set; }
        private string Pays { get; set; }

        public Adresse(int numero, string nomAdresse, int codePostal, string pays)
        {
            Numero = numero;
            NomAdresse = nomAdresse;
            CodePostal = codePostal;
            Pays = pays;
        }
    }
}
