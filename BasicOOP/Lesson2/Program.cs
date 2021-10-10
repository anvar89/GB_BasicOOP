using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount()
            {
                Type = BankAccountTypes.Deposit,
                Balance = 1000000
            };

            Console.WriteLine(myAccount);
            Console.ReadKey();
        }
    }
}
