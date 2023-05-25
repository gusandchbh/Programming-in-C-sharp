using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Invoice
{
    public class Item
    {
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TaxPercent { get; set; }

        public Item(string description, int quantity, decimal unitPrice, decimal taxPercent)
        {
            Description = description;
            Quantity = quantity;
            UnitPrice = unitPrice;
            TaxPercent = taxPercent;
        }

        public decimal GetTotalPrice()
        {
            decimal totalPrice = Quantity * UnitPrice;
            decimal taxAmount = GetTotalTax();
            return Math.Round(totalPrice + taxAmount, 2);
        }

        public decimal GetTotalTax()
        {
            decimal totalPrice = Quantity * UnitPrice;
            return Math.Round(totalPrice * (TaxPercent / 100), 2);
        }

        public decimal TotalTax
        {
            get { return GetTotalTax(); }
        }

        public decimal Total
        {
            get { return GetTotalPrice(); }
        }
    }
}
