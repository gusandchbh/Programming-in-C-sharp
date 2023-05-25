using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Invoice
{
    public abstract class Company
    {
        public string Name { get; set; }
        public Address Address { get; set; }

        public Company(string name, Address address)
        {
            Name = name;
            Address = address;
        }
    }
}
