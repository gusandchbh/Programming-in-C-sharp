using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class AirplaneEventArgs : EventArgs
    {
        public string Flight { get; set; }
        public string Message { get; set; }

        public AirplaneEventArgs(string flight, string message)
        {
            this.Flight = flight;
            this.Message = message;
        }
    }
}
