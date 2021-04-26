using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusTicket.Core.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Place { get; set; }
        public ICollection<Route> OriginRoutes { get; set; }
        public ICollection<Route> DestinationRoutes { get; set; }
    }
}