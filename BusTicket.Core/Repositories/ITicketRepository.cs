using BusTicket.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusTicket.Core.Repositories
{
    public interface ITicketRepository : IRepository<Ticket>
    {
        //GetPriceAsync old name
           Task<Ticket> GetSeatCountAsync(int TicketRouteId);

        Task<IEnumerable<Ticket>> PriceGetAsync();
    }
}
