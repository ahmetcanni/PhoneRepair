using System;
using Les3WPF.Model;
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

namespace Les3WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Customer> customers = new List<Customer>
            {
                new Customer
                {
                    FirstName = "Bob",
                    LastName = "Stuurman",
                    Gender = Gender.Male,
                    CustomerID = 101,
                    HeightCentimeter = 180,
                    Email = "Beste.stuurlui.staan.aan.wal@gmail.com"
                }
            };

            List<Bike> bikes = new List<Bike>
            {
                new Bike()
                {
                    Type = "Beachcruiser",
                    BikeGender = BikeGender.Male,
                    Size = 160,
                    HourRate = 10.00,
                    DayRate = 25.00
                },
                new Bike()
                {
                    Type = "Mountainbike",
                    BikeGender = BikeGender.Female,
                    Size = 150,
                    HourRate = 7.50,
                    DayRate = 50.00

                }
            };

            CustomerList.ItemsSource = customers;

            BikeList.ItemsSource = bikes;
        }

        private void TexBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
