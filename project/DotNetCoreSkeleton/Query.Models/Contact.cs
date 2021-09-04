using System;

namespace Query.Models
{
    public class Contact
    {
        public Guid ContactId { get; set; }
        public Dapper.CommandDefinition Definition { get; set; }
    }
}
