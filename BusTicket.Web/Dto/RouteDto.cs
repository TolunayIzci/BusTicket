using System;

namespace BusTicket.Web.Dto
{
    public class RouteDto
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
        public int? OriginLocationId { get; set; }
        public int? DestinationLocationId { get; set; }

    }
}
