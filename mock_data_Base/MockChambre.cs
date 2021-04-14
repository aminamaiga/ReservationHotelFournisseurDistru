using System;
using System.Collections.Generic;
using System.Linq;
using ReservationHotelFournisseur.model;
using System.Web;

namespace ReservationHotelFournisseur.mock_data_Base
{
    public class MockChambre
    {
        public static List<Chambre> ListChambres {get; set;}

        public static List<Chambre> GetListChambre()
        {
            ListChambres = new List<Chambre>();
            ListChambres.Add(new Chambre(1, 70, 1, true, 5));
            ListChambres.Add(new Chambre(1, 100, 1, true, 4));
            ListChambres.Add(new Chambre(1, 170, 2, true, 4));
            ListChambres.Add(new Chambre(1, 270, 1, true, 3));
            ListChambres.Add(new Chambre(1, 400, 1, true, 2));
            ListChambres.Add(new Chambre(1, 500, 1, true, 1));
            ListChambres.Add(new Chambre(1, 1000, 2, true, 1));
            return ListChambres;
        }

    }
}