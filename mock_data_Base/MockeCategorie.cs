using ReservationHotelFournisseur.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReservationHotelFournisseur.mock_data_Base
{
    public class MockeCategorie
    {
       static List<Categorie> ListeCategories { get; set; }

      public static List<Categorie> GetListCategories()
        {
            ListeCategories = new List<Categorie>();
            ListeCategories.Add(new Categorie(1, 1, "1 étoiles"));
            ListeCategories.Add(new Categorie(2, 2, "2 étoiles"));
            ListeCategories.Add(new Categorie(3, 3, "3 étoiles"));
            ListeCategories.Add(new Categorie(4, 4, "4 étoiles"));
            ListeCategories.Add(new Categorie(5, 5, "5 étoiles"));

            return ListeCategories;
        }

    }
}