using System;
using System.Collections.Generic;
using System.Linq;
using ReservationHotelFournisseur.model;
using System.Web;

namespace ReservationHotelFournisseur.mock_data_Base
{
    public class ClientMock
    {
       public static List<Client> ListClients { get; set; }

        public static List<Client> GetClientsLists()
        {
            ListClients = new List<Client>();
            ListClients.Add(new Client(1, "Dupont", "Paul", "MasterCard"));
            ListClients.Add(new Client(2, "Durant", "Jean", "LCL paid"));
            ListClients.Add(new Client(3, "Lauret", "Nicolas", "Paypal"));
            ListClients.Add(new Client(4, "Macron", "Sebille", "CB"));
            ListClients.Add(new Client(5, "Roux", "Veronique", "MasterCard"));
            return ListClients;
        }

    }
}