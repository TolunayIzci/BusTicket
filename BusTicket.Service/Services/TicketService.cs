using BusTicket.Core.Models;
using BusTicket.Core.Repositories;
using BusTicket.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.Service.Services
{
    public class TicketService : Service<Ticket>, ITicketService
    {
        public TicketService(IRepository<Ticket> repository) : base(repository)
        {
        }
    }
}
