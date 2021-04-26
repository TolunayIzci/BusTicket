using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusTicket.Web.Dto
{
    public class TicketDto
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


    }
}
