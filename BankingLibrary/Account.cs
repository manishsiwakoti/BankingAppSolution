using System;

namespace BankingLibrary
    {


    public class Account
        {
        public decimal Balance { get; set; }
        public string AcctNbr { get; set; }
        public string Description { get; set; }


        public void Depoist(decimal amount)
            {
            Balance += amount; }

        public void Withdraw(decimal amount)
            {
            Balance -= amount; }

                public void Transfer(decimal amount, Account toaccount, Account fromaccount)
            {
            fromaccount.Withdraw(amount);
            toaccount.Depoist(amount);
            }
        public Account()
            {

            }
            }
        }       
    
