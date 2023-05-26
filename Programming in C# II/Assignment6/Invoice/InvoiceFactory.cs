using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Assignment6.Utility;

namespace Assignment6.Invoice
{
    public class InvoiceFactory
    {
        public static Invoice CreateInvoice(string filePath)
        {
            List<string> rows = FileReader.ReadTextFile(filePath).ToList();

            Invoice invoice = new Invoice();

            string invoiceNum = rows[0];
            DateTime invoiceDate = DateTime.Parse(rows[1]);
            DateTime dueDate = DateTime.Parse(rows[2]);
            invoice.InvoiceInfo = Tuple.Create(invoiceNum, invoiceDate, dueDate);

            Address recipientAdress = new Address(rows[5], rows[6], rows[7], rows[8]);
            Recipient recipient = new Recipient(rows[3], recipientAdress, rows[4]);

            invoice.Recipient = recipient;

            int numberOfItems = int.Parse(rows[9]);
            List<Item> items = new List<Item>();
            for (int i = 0; i < numberOfItems; i++)
            {
                int rowIndex = 10 + i * 4;

                items.Add(new Item(rows[rowIndex], int.Parse(rows[rowIndex + 1]), ParseDecimal(rows[rowIndex + 2]), ParseDecimal(rows[rowIndex + 3])));
            }
            invoice.Items = items;

            int afterItems = 10 + numberOfItems * 4;
            Address address = new Address(rows[afterItems + 1], rows[afterItems + 2], rows[afterItems + 3], rows[afterItems + 4]);
            Sender sender = new Sender(rows[afterItems], address, rows[afterItems + 5], rows[afterItems + 6]);

            invoice.Sender = sender;

            return invoice;
        }

        private static decimal ParseDecimal(string str)
        {
            if (str.Contains(","))
            {
                str = str.Replace(',', '.');
            }
            if (!decimal.TryParse(str, out decimal result))
            {
                throw new FormatException($"Cannot parse {str} to decimal");
            }
            return result;
        }


    }
}
