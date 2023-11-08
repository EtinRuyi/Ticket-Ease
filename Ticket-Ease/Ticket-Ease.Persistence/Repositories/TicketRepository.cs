using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Ease.Persistence.Repositories
{
    public class TicketRepository : GenericRepository<Ticket>, ITicketRepository
    {
        public TicketRepository(TicketEaseDbContext ticketEaseDbContext) : base(ticketEaseDbContext) { }
        public void AddTicket(Ticket ticket) => Add(ticket);

        public void DeleteTicket(Ticket ticket) => Delete(ticket);

        public List<Ticket> FindTicket(Expression<Func<Ticket, bool>> condition)
        {
            return Find(condition);
        }

        public Ticket GetTicketById(string id)
        {
            return GetById(id);
        }

        public List<Ticket> GetTickets()
        {
            return GetAll();
        }

        public void UpdateTicket(Ticket ticket) => Update(ticket);
    }
}
