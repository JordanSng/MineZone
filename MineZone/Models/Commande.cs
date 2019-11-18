using System;
using System.Collections.Generic;

namespace MineZone.Models
{
    public class Commande
    {

        private int Id { get; set; }
        private decimal SommeHT { get; set; }
        private decimal SommeTTC { get; set; }
        private DateTime Date { get; set; }

        private DateTime DateLivraison
        {
            get => DateLivraison;
            set => Date.AddDays(7);
        }
        private List<Article> Articles { get; set; }
        public virtual Adresse AdresseLivraison { get; set; }
        public virtual Adresse AdresseFacturation { get; set; }

        public Commande(int id, decimal sommeHT, decimal sommeTTC, DateTime date, DateTime dateLivraison, List<Article> articles, Adresse adresseLivraison, Adresse adresseFacturation)
        {
            this.Id = id;
            this.SommeHT = Math.Abs(sommeHT);
            this.SommeTTC = Math.Abs(SommeTTC);
            Date = date;
            DateLivraison = dateLivraison;
            this.Articles = articles;
            this.AdresseLivraison = adresseLivraison;
            this.AdresseFacturation = adresseFacturation;
        }
    }
}
