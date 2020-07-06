using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TelepnoneDirectory.Models
{
    public class DbTelephoneInitializer : DropCreateDatabaseAlways<TelephoneContext>
    {
        protected override void Seed(TelephoneContext db)
        {
            db.Telephones.Add(new Telephone {PhoneNumber = 777, Name = "Ilya Burakov", Address = "Kaluga" });
            db.Telephones.Add(new Telephone {PhoneNumber = 111, Name = "John Paul", Address = "Ostin" });

            base.Seed(db);
        }
    }
}