using ReservationHotelFournisseur.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReservationHotelFournisseur.mock_data_Base
{
    public class MockAdresse
    {
        static List<Adresse> ListeAdresses { get; set; }

        public static List<Adresse> GetListAdresse()
        {
            ListeAdresses = new List<Adresse>();
            ListeAdresses.Add(new Adresse(1, 02, "France", 34000, "Montpellier", 1, 34) );
            ListeAdresses.Add(new Adresse(2, 06, "France", 51100, "Reims", 1, 51));
            ListeAdresses.Add(new Adresse(3, 07, "France", 21231, "Dijon", 1, 21));
            ListeAdresses.Add(new Adresse(4, 09, "France", 76100, "Rouen", 1, 76));
            ListeAdresses.Add(new Adresse(5, 01, "France", 68200, "Mulhouse", 1, 68));
            return ListeAdresses;
        }
    }
}