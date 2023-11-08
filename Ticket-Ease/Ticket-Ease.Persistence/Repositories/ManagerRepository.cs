using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Ease.Persistence.Repositories
{
    public class ManagerRepository : GenericRepository<Manager>, IManagerRepository
    {
        public ManagerRepository(TicketEaseDbContext ticketEaseDbContext) : base(ticketEaseDbContext) { }

        public void AddManager(Manager manager) => Add(manager);

        public void DeleteManager(Manager manager) => Delete(manager);

        public List<Manager> FindManager(Expression<Func<Manager, bool>> condition)
        {
            return Find(condition);
        }

        public Manager GetManagerById(string id)
        {
            return GetById(id);
        }

        public List<Manager> GetManagers()
        {
            return GetAll();
        }

        public void UpdateManager(Manager manager) => Update(manager);

    }
}
