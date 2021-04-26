using System.Collections.Generic;

namespace BusTicket.Core.Models
{
    public class UserType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public ICollection<User> Users { get; set; }
    }
}