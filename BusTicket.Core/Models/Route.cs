using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusTicket.Core.Models
{
    public class Route
    {
        public int Id { get; set; }

        public int SeatCount { get; set; }
        public int SeatCapacity { get; set; }
        public decimal Price { get; set; }
        public decimal AdditionRate { get; set; }
        public decimal ActivePrice { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
        public int? OriginLocationId { get; set; }
        public Location OriginLocation { get; set; }
        public int? DestinationLocationId { get; set; }
        public Location DestinationLocation { get; set; }
    }
}