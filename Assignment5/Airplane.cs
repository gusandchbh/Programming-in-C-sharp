using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Assignment5
{
    internal class Airplane
    {
        private DispatcherTimer dispatcherTimer;

        public bool CanLand { get; set; }
        public string Destination { get; set; }
        public string FlightID { get; set; }
        public double FlightTime { get; set; }
        public TimeOnly LocalTime { get; set; }
        public string Name { get; set; }


        public void OnLanding()
        {
        }

        public void OnTakeOff()
        {
        }

        public void SetupTimer()
        {
            dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick 
        }

        public void StopTimer()
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
