using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount();
            BankAccount myAccount2 = new BankAccount(100);


            Console.WriteLine(myAccount);
            Console.WriteLine();
            Console.WriteLine(myAccount2);
            Console.ReadKey();
        }
    }
}
