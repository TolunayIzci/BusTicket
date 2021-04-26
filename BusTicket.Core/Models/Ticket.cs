using System;

namespace BusTicket.Core.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int RouteId { get; set; }
        public string PassangerName { get; set; }
        public string PassangerSurname { get; set; }
        public int SeatNumber { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }

        public Route Route { get; set; }
        public User User { get; set; }
    }
}