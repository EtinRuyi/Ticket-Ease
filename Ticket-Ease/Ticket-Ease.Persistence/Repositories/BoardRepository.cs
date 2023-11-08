using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Ease.Persistence.Repositories
{
    public class BoardRepository : GenericRepository<Board>, IBoardRepository
    {
        private readonly TicketEaseDbContext _ticketEaseDbContext;
        public BoardRepository(TicketEaseDbContext ticketEaseDbContext) : base(ticketEaseDbContext)
        {
            _ticketEaseDbContext = ticketEaseDbContext;
        }

        public List<Board> GetBoards()
        {
            return GetAll();
        }
        public void AddBoard(Board board) => Add(board);

        public void DeleteBoard(Board board) => Delete(board);
        public List<Board> FindBoard(Expression<Func<Board, bool>> condition)
        {
            return Find(condition);
        }
        public Board GetBoardById(string id)
        {
            return GetById(id);
        }
        public void UpdateBoard(Board board) => Update(board);
    }
}
