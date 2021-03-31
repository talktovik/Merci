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
using firstname_Assignment3_001.ClassFolder;


namespace firstname_Assignment3_001
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int mainbalance = 0;
        public MainWindow()
        {
            InitializeComponent();
            BalanceClass balanceClass = new BalanceClass();
            gameChanger();
        }

        public void gameChanger()
        {
            // This would Create all the buttons off only button on would be the create button.
            btnDeposit.IsEnabled = false;
            btnWithdrw.IsEnabled = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Int32.Parse(txtAmount.Text) > 0)
            {
                mainbalance = mainbalance + Int32.Parse(txtAmount.Text);
                lblBalance.Content = "$ " + mainbalance.ToString();
                txtAmount.Text = " ";
                btnWithdrw.IsEnabled = true;
                
            }
            else 
            {
                MessageBox.Show("Not a Valid Deposite");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (mainbalance <= 0)
            {
                MessageBox.Show("You Have nothing to take from the bank so Don't worry");
            }
            else 
            {
                int avai = 0;
                BankAccount bank = new BankAccount();
                avai = bank.Withdraw(mainbalance, Int32.Parse(txtAmount.Text));
                
                if (avai > 0)
                {
                    mainbalance = avai;
                    lblBalance.Content = avai.ToString();
                }
                else 
                {
                    MessageBox.Show("Something Went wrong");
                }
            }
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            btnDeposit.IsEnabled = true;
            
        }


    }
}
