using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ReservationHotelFournisseur.model;
using ReservationHotelFournisseur.mock_data_Base;
using System.Xml.Serialization;
using System.Linq.Expressions;


namespace ReservationHotelFournisseur
{
    /// <summary>
    /// Description résumée de ServiceWebHotel
    /// </summary>
    [WebService(Namespace = "http://tp.umontpellier.fr/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class ServiceWebHotel : System.Web.Services.WebService
    {
        public List<Hotel> ListeHotel = new List<Hotel>();
        public List<Adresse> ListeAdresse = new List<Adresse>();


        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod(EnableSession = true)]
        [XmlInclude(typeof(Hotel))]
        public Hotel[] GetHotels()
        {
            return HotelMock.GetHotels().ToArray();
        }


        [WebMethod]
        [XmlInclude(typeof(Reservation))]
        public List<Reservation> GetReservations()
        {
            return MockReservation.GetListeReservations();
        }


        [WebMethod]
        [XmlInclude(typeof(Adresse))]
        public List<Adresse> GetAdresses()
        {
            return MockAdresse.GetListAdresse();
        }


        [WebMethod]
        [XmlInclude(typeof(Client))]
        public List<Client> GetClients()
        {
            return ClientMock.GetClientsLists();
        }


        [WebMethod]
        [XmlInclude(typeof(Categorie))]
        public List<Categorie> GetCategories()
        {
            return MockeCategorie.GetListCategories();
        }

        [WebMethod]
        [XmlInclude(typeof(Chambre))]
        public List<Chambre> GetChambres()
        {
            return MockChambre.GetListChambre();
        }

        [WebMethod]
        [XmlInclude(typeof(Response<Hotel>))]
        public Response<Hotel> SearchHotel(String ville, String nomHotel,
            DateTime dateArrivee, DateTime dateDebu,
            int prixMin , int prixMax, int nombreEtoile, int nombrePersonne)
        {
            Response<Hotel> response = new Response<Hotel>();
            List<Hotel> hotelsList = HotelMock.GetHotels();
            List<Adresse> listAdresses = MockAdresse.GetListAdresse();
            var allHotels = from hotel in hotelsList
                            join adress in listAdresses on hotel.IdHotel equals adress.IdHotel
                            select new { hotel, adress };

            if (!ville.Trim().Equals(""))
            {
                allHotels = allHotels.Where(p => p.adress.Ville.ToLower().Equals(ville.ToLower()));
            }
            if (!nomHotel.Trim().Equals(""))
            {
                allHotels = allHotels.Where(p => p.hotel.nomHotel.ToLower().Equals(nomHotel.ToLower()));
            }



            foreach (var q in allHotels)
            {
                ListeHotel.Add(new Hotel(q.hotel.IdHotel, q.hotel.nomHotel, q.hotel.nombreChambre, q.hotel.nombreLit, q.hotel.lieuDit, q.hotel.idCategorie));
                ListeAdresse.Add(new Adresse(q.adress.IdAdresse, q.adress.Rue, q.adress.Pays, q.adress.Numero, q.adress.Ville, q.adress.IdHotel, q.adress.Gps));
            }
            response.Responses = ListeHotel.ToArray();
            response.Message = "Reponse true. Resultat trouvé " + ListeHotel.Count ;
            response.adresses = ListeAdresse.ToArray();
            return response;
        }
    }
}

 class FilterVM
{
    public string Ville { get; set; }
    public DateTime DateArrivee { get; set; }
    public DateTime? DateDebut { get; set; }
    public int? PrixMin { get; set; }
    public int? PrixMax { get; set; }
    public int? NombreEtoile { get; set; }
    public int? NombrePersonne { get; set; }
}
