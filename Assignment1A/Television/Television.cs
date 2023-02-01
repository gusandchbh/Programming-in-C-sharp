using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Television
{
    internal class Television
    {
        double sizeInInches;
        double price;
        DateTime dateTime;
        string[] channels;


        public void configureChannels(int channelNumber)
        {
            channels = new string[channelNumber];
            for (int i = 0; i < channelNumber; i++)
            {
                channels[i] = "Channel " + i;
            }
        }

        public void SetCorrectTime()
        {
            dateTime = DateTime.Now;
        }

        public void startTv()
        {
            Console.WriteLine("Welcome! You first need to configure the tv. I will require some information from you!");
            Console.WriteLine("What was the price of this TV?");
            price = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the size of this TV in inches?");
            sizeInInches = double.Parse(Console.ReadLine());
            Console.WriteLine("How many channels would you like?");
            int numOfChannels = int.Parse(Console.ReadLine());
            configureChannels(numOfChannels);
            SetCorrectTime();
            Console.WriteLine("TV has now been succesfully configured. Thank you!");
            Console.WriteLine();
            Console.WriteLine("We have registered the following information: ");
            Information();
            watchTv();
            Crash();
        }
        public void Information()
        {
            string x = "\n" + "Price: " + price.ToString("F") + " SEK" +  "\n" + "TV size: " + sizeInInches + " inches. " + "\n" + "Number of channels: " + channels.Length + "\n" +
                "Current date and time: " + dateTime.ToString() + "\n";
            Console.WriteLine(x);
        }

        public void Crash()
        {
            Console.WriteLine("Ooooops. Something has gone horribly wrong. You should have spent more than " + price.ToString("F") + " SEK" + " on this TV! SHUTTING DOWN.");
        }

        public void watchTv()
        {
            Console.WriteLine("What channel would you like to watch? ");
            int channel = int.Parse(Console.ReadLine());
            while (channel < 0 || channel > channels.Length)
            {
                Console.WriteLine("Channel does not exist! Choose another channel!");
                channel = int.Parse(Console.ReadLine());
            }
               
            Console.WriteLine("You are now watching channel " + channel + "!");
            Console.WriteLine();
           

            }
       
        }
    }

