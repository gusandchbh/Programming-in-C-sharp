using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private ControlTower controlTower;

        public MainWindow()
        {
            InitializeComponent();
            controlTower = new ControlTower(MessagesListBox);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(FlightTimeTextBox.Text, out double flightTime))
            {
                Airplane airplane = new Airplane
                {
                    Name = NameTextBox.Text,
                    FlightID = FlightIdTextBox.Text,
                    Destination = DescriptionTextBox.Text,
                    FlightTime = flightTime,
                    CanLand = true
                };
                PlanesListBox.Items.Add(airplane);
                MessagesListBox.Items.Add(airplane + " sent to runway!");
                controlTower.AddPlane(airplane);
            }
            else
            {
                MessageBox.Show("Invalid input for flight time. Please enter a valid number.");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int selectedIndex = PlanesListBox.SelectedIndex;

      

            // Check if a plane is selected.
            if (selectedIndex >= 0)
            {
                Airplane airplane = PlanesListBox.SelectedItem as Airplane;
                if (!airplane.CanLand)
                {
                    MessageBox.Show("This airplane is still in the air!");
                    return;
                }
                // Order the selected plane to take off.
                controlTower.OrderTakeOff(selectedIndex);
            }
            else
            {
                // If no plane is selected, show an error message.
                MessageBox.Show("Please select a plane to take off.");
            }
        }

    }
}
