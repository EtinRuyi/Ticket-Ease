﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Ease.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TicketEaseDbContext _ticketEaseDbContext;
        public UnitOfWork(TicketEaseDbContext ticketEaseDbContext)
        {
            _ticketEaseDbContext = ticketEaseDbContext;
            BoardRepository = new BoardRepository(_ticketEaseDbContext);
            CommentRepository = new CommentRepository(_ticketEaseDbContext);
            ManagerRepository = new ManagerRepository(_ticketEaseDbContext);
            PaymentRepository = new PaymentRepository(_ticketEaseDbContext);
            ProjectRepository = new ProjectRepository(_ticketEaseDbContext);
            TicketRepository = new TicketRepository(_ticketEaseDbContext);
            UserRepository = new UserRepository(_ticketEaseDbContext);
        }
        public IBoardRepository BoardRepository { get; private set; }

        public ICommentRepository CommentRepository { get; private set; }

        public IManagerRepository ManagerRepository { get; private set; }

        public IPaymentRepository PaymentRepository { get; private set; }

        public IProjectRepository ProjectRepository { get; private set; }

        public ITicketRepository TicketRepository { get; private set; }

        public IUserRepository UserRepository { get; private set; }

        public int SaveChanges()
        {
            return _ticketEaseDbContext.SaveChanges();
        }

        public void Dispose()
        {
            _ticketEaseDbContext.Dispose();
        }
    }
}
