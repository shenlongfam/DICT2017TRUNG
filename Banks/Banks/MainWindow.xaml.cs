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

namespace Banks
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
            if (radCheckingAccount.IsChecked == true)
            {
                //BankAccount BA = new Banks.BankAccount();
                CheckingAccount CA = new Banks.CheckingAccount();
                CA.setAvccountNumber(txtAccNum.Text);
                CA.setTotalBalance(Convert.ToDouble(txtBalance.Text));
                string stg = "The Account Number is " + CA.getAccountNumber();
                stg += "\nThe Total Balance is $" + CA.getTotalBalance(); 
                if (radWithdraw.IsChecked == true)
                {
                    CA.setWithdraw(Convert.ToDouble(txtTransaction.Text));
                    stg += "\nThe new balance is $" +CA.getTotalBalance();
                   
                }
                else if(radDeposit.IsChecked == true)
                {
                    CA.setDeposit(Convert.ToDouble(txtTransaction.Text));
                    stg += "\nThe new balance is $"+CA.getTotalBalance();
                }
                lstDisplay.Items.Add( stg);
                
            }
            else if (radSavingAccount.IsChecked == true)
            {
                
                SavingAccount SA = new Banks.SavingAccount();
                SA.setAvccountNumber(txtAccNum.Text);
                SA.setTotalBalance(Convert.ToDouble(txtBalance.Text));
                string stg = "The Account Number is " + SA.getAccountNumber();
                stg += "\nThe Total Balance is $" + SA.getTotalBalance();
                if (radWithdraw.IsChecked == true)
                {
                    SA.setWithdraw(Convert.ToDouble(txtTransaction.Text));
                    stg += "\nThe new balance is $"+SA.getTotalBalance();
                }
                else if (radDeposit.IsChecked == true)
                {
                    SA.setDeposit(Convert.ToDouble(txtTransaction.Text));
                    stg += "\nThe new balance is $"+SA.getTotalBalance();
                }
                lstDisplay.Items.Add(stg);
            }
            
        }
    }
}
