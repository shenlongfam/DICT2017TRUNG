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

namespace PhoneBook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Class level variables to use in all methods.
        String[] names = new String[10];
        String[] phone = new String[10];
        int count = 0;
        public MainWindow()
        {
            InitializeComponent();
            txtName.Focus();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text != String.Empty)
            {
                if (txtName.Text.ToLower() != "zzz" )
                {
                    names[count] = txtName.Text;
                    phone[count] = txtPhone.Text;
                    txtName.Clear();
                    txtPhone.Clear();
                    txtName.Focus();
                    count++;
                }
            }
            if (count == 10 || txtName.Text.ToLower() == "zzz" )
            {
                txtPhone.IsEnabled = false;
                txtName.IsEnabled = false;
                lstNames.Items.Add("The names in the list are: ");
                for (int i = 0; i < count; i++)
                    lstNames.Items.Add(names[i]);
                txtNameFind.Focus();                
            }
            

        }

        private void btnFind_Click(object sender, RoutedEventArgs e)
        {
            String nameFind = txtNameFind.Text;
            Boolean found = false;
            for (int i = 0; i < count; i++)
            {
                if (nameFind == names[i])
                {
                    lblResult.Content = "Phone number is:" + phone[i];
                    found = true;
                }
            }
            if (found == false)
                lblResult.Content = "Name not found";
        }
    }
}
