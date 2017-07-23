using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing3_2
{
    class ImmutableBankAccount
    {
        public const int AccountNumber = 123456;
        public readonly int Balance;

        public ImmutableBankAccount(int InitalBalance)
        {
            Balance = InitalBalance;
        }
        public ImmutableBankAccount()
        {
            Balance = 0;
        }
    }
}
