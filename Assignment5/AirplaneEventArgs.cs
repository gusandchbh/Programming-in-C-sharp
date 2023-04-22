using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class AirplaneEventArgs : EventArgs
    {
        private string Message;
        private string Name;

        public string Flight { get; set; }
        public string Message { get; set; }
    }
}
