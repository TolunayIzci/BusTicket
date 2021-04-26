using BusTicket.Core.Models;
using BusTicket.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusTicket.Data.Repositories
{
    public class TicketRepository : Repository<Ticket>, ITicketRepository
    {
        private readonly DbSet<Ticket> _dbSet;
        public TicketRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbSet = dbContext.Set<Ticket>();
        }
        public async Task<Ticket> GetSeatCountAsync(int TicketRouteId)
        {


        }

        public Task<IEnumerable<Ticket>> PriceGetAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}