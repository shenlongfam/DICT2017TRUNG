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

namespace Order
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
            if (chkShipping.IsChecked == false)
            {
                Orders O1 = new Order.Orders();
                O1.setCusName(txtCusName.Text);
                O1.setCusNum(txtNum.Text);
                O1.setUnitPrice(Convert.ToDouble(txtUnitPrice.Text));
                O1.setNumber(Convert.ToInt32(txtQuantity.Text));
                O1.ComputePrice();
                lstDisplay.Items.Add(O1.displayOrder());
            }
            else
            {
                ShippedOrder O1 = new ShippedOrder();
                O1.setCusName(txtCusName.Text);
                O1.setCusNum(txtNum.Text);
                O1.setUnitPrice(Convert.ToDouble(txtUnitPrice.Text));
              O1.setNumber(Convert.ToInt32(txtQuantity.Text));
                O1.ComputePrice();
                lstDisplay.Items.Add(O1.displayOrder());
            }

             
                
                
            }
        }
    }

