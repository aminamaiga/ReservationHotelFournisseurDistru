using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReservationHotelFournisseur.model
{
    [Serializable]
    public class Reservation
    {
        public int IdReservation { get; set; }
        public int IdClient { get; set; }
        public int PrixReservation { get; set; }
        public int IdChambre { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }

        public Reservation() { }

        public Reservation(int idReservation, int idClient, int prixReservation, int idChambre, DateTime dateDebut, DateTime dateFin)
        {
            IdReservation = idReservation;
            IdClient = idClient;
            PrixReservation = prixReservation;
            IdChambre = idChambre;
            DateDebut = dateDebut;
            DateFin = dateFin;
        }
    }
}