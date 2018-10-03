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

namespace Hotel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, RoutedEventArgs e)
        {
            if (chkSuite.IsChecked==true)
            {
                HotelSuite HS = new HotelSuite(Convert.ToInt32(txtRoomNumber.Text));
                string stg = "Hotel Suite, room number " + HS.getRoomNumber();
                stg += "\nhas a nightly rate of $" + HS.getNightlyRate();
                lblDisplay.Content = stg;
            }
            else
            {
                HotelRoom HR = new HotelRoom(Convert.ToInt32(txtRoomNumber.Text));
                string stg = "Hotel  room number " + HR.getRoomNumber();
                stg += "\nhas a nightly rate of $" + HR.getNightlyRate();
                lblDisplay.Content = stg;
            }
        }
    }
}
