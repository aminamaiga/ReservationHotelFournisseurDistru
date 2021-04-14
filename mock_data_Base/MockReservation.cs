using System;
using System.Collections.Generic;
using ReservationHotelFournisseur.model;
using System.Linq;
using System.Web;

namespace ReservationHotelFournisseur.mock_data_Base
{
    public class MockReservation
    {
        public static List<Reservation> ListeReservations { get; set; }

        public static List<Reservation> GetListeReservations()
        {
            ListeReservations = new List<Reservation>();
            ListeReservations.Add(new Reservation(1, 1, 70, 1, new DateTime(), new DateTime()));
            ListeReservations.Add(new Reservation(1, 1, 70, 1, new DateTime(), new DateTime()));
            return ListeReservations;
        }

    }
}