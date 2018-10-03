using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banks
{
    class CheckingAccount:BankAccount
    {
        int fee = 30;
        public new void deductFee()
        {

            double newBalance_V2 = getBalance() - fee;
            setTotalBalance(newBalance_V2);
            
            
        }
    }
}
