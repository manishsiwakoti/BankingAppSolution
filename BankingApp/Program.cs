using BankingLibrary;
using System;

namespace BankingApp
    {
    class Program
        {
        static void Main(string[] args)
            {
            var chk = new Account();
            chk.Depoist(100);
            chk.Withdraw(75);

             

            }
        }
    }
