using System.Collections.Generic;

namespace BusTicket.Core.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int UserTypeId { get; set; }
        public UserType UserType { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}