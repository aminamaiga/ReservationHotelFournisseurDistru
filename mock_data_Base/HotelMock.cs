using ReservationHotelFournisseur.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace ReservationHotelFournisseur.mock_data_Base
{
    public class HotelMock
    {
        static List<Hotel> ListeHotel { get; set; }

       public static List<Hotel> GetHotels()
        {
            ListeHotel = new List<Hotel>();
            Hotel h = new Hotel(1, "Hotel Panama", 100, 90, "Panama", 1);
            ListeHotel.Add(h);
            ListeHotel.Add(new Hotel(2, "Hotel Lamantin", 200, 200, "Lamantin", 1));
            ListeHotel.Add(new Hotel(3, "Hotel Teroubi", 300, 290, "Teroubi", 1));
            ListeHotel.Add(new Hotel(4, "Hotel Wakola", 400, 390, "Wakola", 2));
            ListeHotel.Add(new Hotel(5, "Hotel Plaza", 500, 490, "Plaza", 3));
            ListeHotel.Add(new Hotel(6, "Hotel Golden", 600, 590, "Golden", 4));
            ListeHotel.Add(new Hotel(7, "Hotel Pullman", 700, 690, "Pullman", 5));
            ListeHotel.Add(new Hotel(8, "Hotel Mercure", 800, 790, "Mercure", 6));
            return ListeHotel;
        }
    }
}