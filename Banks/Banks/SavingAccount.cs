using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banks
{
    class SavingAccount:BankAccount
    {
        int interestrate = 20;
        public new void getNewBalance()
        {
            
            double NewBalance_V3 = getBalance()+interestrate ;
            setTotalBalance(NewBalance_V3);
        }
    }
}
