using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Ease.Persistence.Repositories
{
    public PaymentRepository(TicketEaseDbContext ticketEaseDbContext) : base(ticketEaseDbContext) { }

    public void AddPayment(Payment payment) => Add(payment);

    public void DeletePayment(Payment payment) => Delete(payment);

    public List<Payment> FindPayment(Expression<Func<Payment, bool>> condition)
    {
        return Find(condition);
    }

    public Payment GetPaymentById(string id)
    {
        return GetById(id);
    }

    public List<Payment> GetPayments()
    {
        return GetAll();
    }

    public void UpdatePayment(Payment payment) => Update(payment);
}
}
