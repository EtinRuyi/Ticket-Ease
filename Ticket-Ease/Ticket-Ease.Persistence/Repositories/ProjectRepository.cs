﻿

using System.Linq.Expressions;
using Ticket_Ease.Persistence.Context;
using Ticket_Ease.Persistence.Repositories;
using TicketEase.Application.Interfaces.Repositories;
using TicketEase.Domain.Entities;
using TicketEase.Persistence.Context;

namespace TicketEase.Persistence.Repositories
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
