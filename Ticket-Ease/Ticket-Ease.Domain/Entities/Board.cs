﻿namespace TicketEase.Domain.Entities
{
    public class Board : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
}
