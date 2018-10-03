using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banks
{
    class BankAccount
    {
        public String AccountNumber;
        public double TotalBalance;
        public double Deposit;
        public double Withdraw;
        public double newBalance;
        public void setAvccountNumber(String AC)
        {
           AccountNumber = AC;
        }
        public String getAccountNumber()
        {
            return AccountNumber;
        }
        public void setTotalBalance(double TB)
        {
            TotalBalance = TB;
        }
        public double getTotalBalance()
        {
            return TotalBalance;
        }
       
           public double getDeposit()
            {
                return Deposit;
            }
            public void setDeposit(double DS)
        {
            TotalBalance += DS;
        }
           public double  getWithdraw()
            {
              return Withdraw;
            }
        public void setWithdraw(double WT)
        {
           TotalBalance -= WT;
        }
       public double getBalance()
        {
            return newBalance;
        }
        public void setBalance(double BL)
        {
            BL = newBalance;
        }
    }
}
