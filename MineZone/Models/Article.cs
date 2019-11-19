using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineZone.Models
{
    public class Article
    {
        private int Id;
        private string NomArticle;
        public decimal Prix;

        public Article(int id, string nomArticle, double prix)
        {
            Id = id;
            NomArticle = nomArticle;
            Prix = prix;
        }

    }
}
