using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelepnoneDirectory.Models
{
    public class Telephone
    {
        public int Id { get; set; }
        public int PhoneNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}