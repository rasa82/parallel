using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing3_2
{
    class Listing3_2
    {
        static void Main(string[] args)
        {
            //Create a bank account with the default balance
            ImmutableBankAccount bankAccount1 = new ImmutableBankAccount();
            Console.WriteLine("Account Number: {0}, Account Balance: {1}", ImmutableBankAccount.AccountNumber, bankAccount1.Balance);

            // create a bank account with a starting balance
            ImmutableBankAccount bankAccount2 = new ImmutableBankAccount(200);
            Console.WriteLine("Account Number: {0}, Account Balance: {1}", ImmutableBankAccount.AccountNumber, bankAccount2.Balance);

            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
