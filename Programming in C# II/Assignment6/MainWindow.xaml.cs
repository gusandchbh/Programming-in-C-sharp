using Assignment6.Utility;
using Microsoft.Win32;
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
using Assignment6.Invoice;

namespace Assignment6
{
    public partial class MainWindow : Window
    {
        private Invoice.Invoice invoice;
        public MainWindow()
        {
            InitializeComponent();
            InvoiceGrid.Visibility = Visibility.Hidden;
        }
        private void OpenInvoice_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            if (openFileDialog.ShowDialog() == true)
            {
                string fileName = openFileDialog.FileName;
                if (!fileName.EndsWith(".txt"))
                {
                    MessageBox.Show("Wrong file format!");
                } else
                {
                    try
                    {
                        invoice = InvoiceFactory.CreateInvoice(fileName);
                        InitializeGUI();
                        InvoiceGrid.Visibility = Visibility.Visible;
                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void InitializeGUI()
        {
            LabelInvoiceNumberValue.Content = invoice.InvoiceInfo.Item1;
            DateInvoiceDate.SelectedDate = invoice.InvoiceInfo.Item2;
            DateDueDate.SelectedDate = invoice.InvoiceInfo.Item3;

            LabelCompanyName.Content = invoice.Sender.Name;

            LabelRecipientName.Content = invoice.Recipient.Name;
            LabelRecipientPersonalName.Content = invoice.Recipient.PersonName;
            LabelRecipientStreet.Content = invoice.Recipient.Address.Street;
            LabelRecipientZipCode.Content = invoice.Recipient.Address.Zipcode;
            LabelRecipientCity.Content = invoice.Recipient.Address.City;
            LabelRecipientCountry.Content = invoice.Recipient.Address.Country;

            LabelSenderStreet.Content = invoice.Sender.Address.Street;
            LabelSenderZipCode.Content = invoice.Sender.Address.Zipcode;
            LabelSenderCity.Content = invoice.Sender.Address.City;
            LabelSenderCountry.Content = invoice.Sender.Address.Country;

            LabelTelephone.Content = invoice.Sender.PhoneNumber;
            LabelURL.Content = invoice.Sender.HomePageURL;

            LabelTotalNumber.Content = invoice.CalculateTotal();

            InvoiceDataGrid.ItemsSource = invoice.Items;

            TextBoxDiscount.Text = "0.0";
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}
