using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1A
{
    internal class TicketSeller
    {
        private string name;
        private double price = 100;
        private int numOfAdults;
        private int numOfChildren;
        private double amountToPay;

        public void Start()
        {
            Greeting();
            ReadAndSaveData();
            CalculateAmountToPay();
            DisplayInfo();
        }

        public void ReadAndSaveData()
        {
            ReadName();
            ReadNumberOfAdults();
            ReadNumberOfChildren();
        }

        public void ReadNumberOfAdults()
        {
            Console.WriteLine("Number of adults:");
            string adultsNumber = Console.ReadLine();
            numOfAdults = int.Parse(adultsNumber);
        }

        public void ReadNumberOfChildren()
        {
            Console.WriteLine("Number of children:");
            string childrensNumber = Console.ReadLine();
            numOfChildren = int.Parse(childrensNumber);
        }

        public void CalculateAmountToPay()
        {
            double total = 0.25 * (numOfChildren * price) + (numOfAdults * price);
            amountToPay = total;
        }
        

        public void DisplayInfo()
        {
            Console.WriteLine(" +++ Your receipt +++");
            Console.WriteLine(" +++ Amount to pay = " + amountToPay.ToString("F"));
            Console.WriteLine();
            Console.WriteLine(" +++ Thank you " + name + " and please come back! +++");
        }

        public void ReadName()
        {
            Console.WriteLine("Your name please: ");
            name = Console.ReadLine();
        }

        public void Greeting()
        {
            Console.WriteLine("Welcome to KIDS' FAIR!");
            Console.WriteLine("Children get always a 75% discount!");
        }


    }
}
