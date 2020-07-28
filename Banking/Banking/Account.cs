using System;

namespace Banking
{
    class Account
    {
        private string _accountID;
        private string _ownerID;
        private decimal _balance;
        private string _accountType;

        public Account()
        {
            Balance = 0.00M;
            AccountID = "";
            OwnerID = "";
            AccountType = "";
        }

        

        public String AccountID
        {
            get { return _accountID; }
            set { _accountID = value; }
        }

        public String OwnerID
        {
            get { return _ownerID; }
            set { _ownerID = value; }
        }

        public String AccountType
        {
            get { return _accountType; }
            set { _accountType = value; }
        }

        


        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

       



        public void Deposit(decimal amount )
        {
            if (amount > 0)
                // Add DB Statement
                Balance += amount;
            else
                throw new Exception("Broken");
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0)
                // Add DB Statement
                Balance = Balance - amount;
            else
                throw new Exception("Broken");
        }

        public virtual void Transfer(decimal amount, decimal fee)
        {
            if (amount > 100)
                Balance = Balance - amount-fee;
            else
                Balance = Balance - amount;
        }


        

    }
}
