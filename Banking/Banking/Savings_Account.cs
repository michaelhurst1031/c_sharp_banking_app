using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    class Savings_Account: Account
    {

        private string _accountType;


        public Savings_Account(decimal balance, string accountType) 
        {
            AccountType = accountType;
        }

        public string AccountType
        {
            get { return _accountType; }
            set { _accountType = value; }
        }


        public override void Transfer(decimal amount, decimal fee)
        {
            if (AccountType == "Advanced")
            {
                base.Transfer(amount, 0.00M);
            }
            else
            {
                base.Transfer(amount, fee);
            }
        }
    }
}
