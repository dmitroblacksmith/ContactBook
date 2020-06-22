using System;
using System.Collections.Generic;
using System.Text;

namespace ContactBook.Domain.Entities
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? IsImportant { get; set; }
        public string IconPath { get; set; }
        public int AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();
    }
}
