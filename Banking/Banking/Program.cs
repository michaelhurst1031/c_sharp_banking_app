using System;

namespace Banking
{
    class Program
    {

        static void Main(string[] args)
        {

            decimal startingBalance = 200.00M;
            string AccountType = "Basic";

            //Savings Account Check
            Savings_Account acct = new Savings_Account(startingBalance, AccountType);

            // For Checking Account
            //Checking_Account acct = new Checking_Account(startingBalance);

            Decimal accountFee = 10.00M;
            Decimal movingMoneyamount = 101.00M;
            Decimal remaingingBalance = 0.00M;
            acct.OwnerID = "29789834793247893248";
            acct.AccountType = "Basic";
            acct.AccountID = "353453534543";
            acct.Balance = startingBalance;


            acct.Transfer(movingMoneyamount, accountFee);

            remaingingBalance = acct.Balance;

            movingMoneyamount = 1.00M;

            acct.Withdraw(movingMoneyamount);

            remaingingBalance = acct.Balance;

            acct.Deposit(movingMoneyamount);

            remaingingBalance = acct.Balance;
        }
    }
}
