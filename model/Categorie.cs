using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReservationHotelFournisseur.model
{
    [Serializable]
    public class Categorie
    {
       public int IdCategorie { get; set; }
       public int NombreEtoile { get; set; }
        public String NomCategorie { get; set; }

        public Categorie() { }

        public Categorie(int idCategorie, int nombreEtoile, string nomCategorie)
        {
            IdCategorie = idCategorie;
            NombreEtoile = nombreEtoile;
            NomCategorie = nomCategorie;
        }
    }


}