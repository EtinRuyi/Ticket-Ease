using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Ease.Persistence.Repositories
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(TicketEaseDbContext ticketEaseDbContext) : base(ticketEaseDbContext) { }

        public void AddProject(Project project) => Add(project);

        public void DeleteProject(Project project) => Delete(project);

        public List<Project> FindProject(Expression<Func<Project, bool>> condition)
        {
            return Find(condition);
        }

        public Project GetProjectById(string id)
        {
            return GetById(id);
        }

        public List<Project> GetProjects()
        {
            return GetAll();
        }

        public void UpdateProject(Project project) => Update(project);
    }
}
