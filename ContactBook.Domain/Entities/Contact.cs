using System;
using System.Collections.Generic;
using System.Text;

namespace ContactBook.Domain.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? IsImportant { get; set; }
        public string IconPath { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        public int AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public virtual ICollection<Group> Groups { get; set; } = new List<Group>();
    }
}
