using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TelepnoneDirectory.Models
{
    public class TelephoneContext : DbContext
    {
        public DbSet<Telephone> Telephones { get; set; }
    }
}