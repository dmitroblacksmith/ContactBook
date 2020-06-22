using System;
using System.Collections.Generic;
using System.Text;

namespace ContactBook.Domain.Entities
{
    public class GroupContact
    {
        public int ContactId { get; set; }
        public virtual Contact Contact { get; set; }
        public int GroupId { get; set; }
        public virtual Group Group { get; set; }
    }
}
