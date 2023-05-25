using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Invoice
{
    public class Invoice
    {
        public Tuple<string, DateTime, DateTime> InvoiceInfo { get; set; }
        public Recipient Recipient { get; set; }
        public List<Item> Items { get; set; }
        public Sender Sender { get; set; }

        public decimal CalculateTotal()
        {
            decimal totalAmount = 0;

            foreach (var item in Items)
            {
                totalAmount += item.GetTotalPrice();
            }

            return Math.Round(totalAmount, 2);
        }
    }

}
