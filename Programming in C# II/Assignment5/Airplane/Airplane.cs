using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace Assignment5
{
    public class Airplane
    {
        private DispatcherTimer dispatcherTimer;

        public bool CanLand { get; set; }
        public string Destination { get; set; }
        public string FlightID { get; set; }
        public double FlightTime { get; set; }
        public TimeOnly LocalTime { get; set; }
        public string Name { get; set; }

        public Airplane()
        {

        }



        /// <summary>
        /// Prepare an info string with airplane name, destination, current time(Now)
        /// Create an AirplaneEventArgs object
        /// Fire the LAnded event
        /// Set the destination to "Home"
        /// </summary>
        public void OnLanding()
        {
            LocalTime = TimeOnly.FromDateTime(DateTime.Now);
            string info = $"{Name} has landed in {Destination}, {LocalTime.ToString("HH:mm:ss")}";
            AirplaneEventArgs args = new AirplaneEventArgs(FlightID, info);

            Landed?.Invoke(this, args);

            Destination = "Home";
        }

        public void OnTakeOff()
        {
            CanLand = false;
           
            LocalTime = TimeOnly.FromDateTime(DateTime.Now);

            string info = $"The aircraft {Name} is taking off, destination {Destination}, {LocalTime.ToString("HH:mm:ss")}";
            AirplaneEventArgs args = new AirplaneEventArgs(FlightID, info);

            TakeOff?.Invoke(this, args);
            SetupTimer();
        }


        public void SetupTimer()
        {
            dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(DispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        private void DispatcherTimer_Tick(object? sender, EventArgs e)
        {
            FlightTime -= 1;
            if (FlightTime < 0)
            {
                CanLand = true;
                this.StopTimer();
                OnLanding();
            }
        }

        public void StopTimer()
        {
            dispatcherTimer.Stop();
        }

        public event EventHandler<AirplaneEventArgs> Landed;
        public event EventHandler<AirplaneEventArgs> TakeOff;



        public override string ToString()
        {
            return $"{Name},{FlightID}, heading for {Destination}";
        }
    }
}
