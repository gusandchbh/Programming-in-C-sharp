using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Assignment5
{
    public class ControlTower
    {

        private ListManager<Airplane> flights;

        private ListBox listBox;

        public ControlTower(ListBox listBox)
        {
            this.listBox = listBox;
            this.flights = new ListManager<Airplane>();
        }

        public void AddPlane(Airplane plane)
        {
            flights.Add(plane);

            // Subscribe to the plane's events
            plane.Landed += OnDisplayInfo;
            plane.TakeOff += OnDisplayInfo;
        }

        public void OnDisplayInfo(object sender, AirplaneEventArgs e)
        {
            listBox.Items.Add(e.Message);
        }

        public void OrderLanding(int index)
        {
            Airplane plane = flights.Get(index);
            plane.OnLanding();
        }

        public void OrderTakeOff(int index)
        {
            Airplane plane = flights.Get(index);
            plane.OnTakeOff();
        }


    }
}
