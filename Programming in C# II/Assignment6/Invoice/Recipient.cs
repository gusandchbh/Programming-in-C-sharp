using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Invoice
{
    public class Recipient : Company
    {
        public string PersonName { get; set; }

        public Recipient(string name, Address address, string personName)
            : base(name, address)
        {
            PersonName = personName;
        }
    }

}
