using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Ease.Persistence.Repositories
{
    public class UserRepository : GenericRepository<AppUser>, IUserRepository
    {
        public UserRepository(TicketEaseDbContext ticketEaseDbContext) : base(ticketEaseDbContext) { }

        public void AddUser(AppUser appUser) => Add(appUser);

        public void DeleteUser(AppUser appUser) => Delete(appUser);

        public List<AppUser> FindUser(Expression<Func<AppUser, bool>> condition)
        {
            return Find(condition);
        }

        public List<AppUser> GetUser()
        {
            return GetAll();
        }

        public AppUser GetUserById(string id)
        {
            return GetById(id);
        }

        public void UpdateUser(AppUser appUser) => Update(appUser);
    }
}
