using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Invoice
{
    public class Sender : Company
    {
        public string PhoneNumber { get; set; }
        public string HomePageURL { get; set; }

        public Sender(string name, Address address, string phoneNumber, string homePageURL)
            : base(name, address)
        {
            PhoneNumber = phoneNumber;
            HomePageURL = homePageURL;
        }
    }
}
