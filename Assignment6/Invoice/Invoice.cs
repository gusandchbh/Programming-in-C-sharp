using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class Invoice
    {
        public Tuple<int, DateTime, DateTime> InvoiceInfo { get; set; }
        public Company Recipient { get; set; }
        public List<Item> Items { get; set; }
        public Company Sender { get; set; }
    }
}
