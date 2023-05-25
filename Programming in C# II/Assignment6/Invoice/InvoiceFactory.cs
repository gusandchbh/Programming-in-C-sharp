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
            List<string> lines = FileReader.ReadTextFile(filePath).ToList();

            Invoice invoice = new Invoice();

            string invoiceNum = lines[0];
            var invoiceDate = DateTime.Parse(lines[1]);
            var dueDate = DateTime.Parse(lines[2]);
            invoice.InvoiceInfo = Tuple.Create(invoiceNum, invoiceDate, dueDate);

            Address recipient_adress = new Address(lines[5], lines[6], lines[7], lines[8]);
            Recipient recipient = new Recipient(lines[3], recipient_adress, lines[4]);

            invoice.Recipient = recipient;

            int numberOfItems = int.Parse(lines[9]);
            List<Item> items = new List<Item>();
            for (int i = 0; i < numberOfItems; i++)
            {
                int lineIndex = 10 + i * 4;
                items.Add(new Item(lines[lineIndex], int.Parse(lines[lineIndex + 1]), decimal.Parse(lines[lineIndex + 2]), decimal.Parse(lines[lineIndex + 3])));         
            }
            invoice.Items = items;

            int senderStartLine = 10 + numberOfItems * 4;
            Address address = new Address(lines[senderStartLine + 1], lines[senderStartLine + 2], lines[senderStartLine + 3], lines[senderStartLine + 4]);
            Sender sender = new Sender(lines[senderStartLine], address, lines[senderStartLine + 5], lines[senderStartLine + 6]);

            invoice.Sender = sender;

            return invoice;
        }

    }
    }
