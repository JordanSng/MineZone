using System;
using System.Collections.Generic;
using System.Linq;
using DataA
using System.Runtime.CompilerServices;

namespace MineZone.Models
{
    public class Commande
    {
        [Required]
        private int Id { get; set; }

        public decimal SommeHT { get; set; }
        public decimal SommeTTC { get; set; }

        private DateTime Date
        {
            get
            {
               return Date;
            }
            set
            {
                var dateTime = DateTime.Now.Date;
            }
        }

        private DateTime DateLivraison
        {
            get => DateLivraison;
            set => Date.AddDays(7);
        }

        public List<Article> Articles { get; set; }
        public virtual Adresse AdresseLivraison { get; set; }
        public virtual Adresse AdresseFacturation { get; set; }

        public Commande(int id, decimal sommeHT, decimal sommeTTC, DateTime date, DateTime dateLivraison,
            List<Article> articles, Adresse adresseLivraison, Adresse adresseFacturation)
        {
            this.Id = id;
            this.SommeHT = Math.Abs(sommeHT);
            this.SommeTTC = Math.Abs(SommeTTC);
            Date = date;
            DateLivraison = dateLivraison;
            if (Articles.Any())
            {
                this.Articles = articles;
            }
            else
            {
                Console.WriteLine("Impossible de créer une commande à 0 article");
            }
            
            this.AdresseLivraison = adresseLivraison;
            this.AdresseFacturation = adresseFacturation;
        }

        public decimal prixMoyenArticle()
        {
            if
           return Articles.Average(a => a.Prix);
        }
    }
}
