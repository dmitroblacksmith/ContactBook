using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace ContactBook.Domain.Entities
{
    public class AppUser : IdentityUser
    {
        public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();
        public virtual ICollection<Group> Groups { get; set; } = new List<Group>();
    }
}
