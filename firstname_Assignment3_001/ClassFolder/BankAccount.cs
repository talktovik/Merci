using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace firstname_Assignment3_001.ClassFolder
{
    class BankAccount
    {
        public BankAccount()
        {
        // I don't think We need Constructor for this, Since this app is having very Limited Options to do.
        }
        public string Name { get; set; }
        public int Amount{ get; set; }
        public int Balance_Remaining { get; set; }
        public int Withdraw(int Balance, int WithdrawlAmount)
        {
            if (Balance >= WithdrawlAmount)
            {
                int avialable = Balance - WithdrawlAmount;
                return avialable;
            }
            else
            {
                return -1;
            }
        }
        public int Deposit(int Depositmoney, int Balance)
        {
            int avialable = Depositmoney + Balance;
            return avialable;
        }
    }
}
