using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace ContactApp.Models
{
    public class Contact
    {
        public int ID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Phone { get; set; }
        public String Email { get; set; }
    }

    public class ContactDBContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
    }
}