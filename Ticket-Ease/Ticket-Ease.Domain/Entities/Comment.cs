using System.ComponentModel.DataAnnotations.Schema;

namespace TicketEase.Domain.Entities
{
    public class Comment : BaseEntity
    {
        [ForeignKey("TicketId")]
        public string TicketId { get; set; }
        public string Comments { get; set; }
    }
}
