using ReservationHotelFournisseur.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReservationHotelFournisseur
{
    [Serializable]
    public class Response<T>
    {
        public String Message { get; set; }
        public String Code { get; set; }
        public T[] Responses { get; set; }
        public Adresse[] adresses { get; set; }

    }
}