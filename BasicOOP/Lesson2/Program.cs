using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount();

            Console.WriteLine(myAccount);
            Console.WriteLine("Снятие со счёта:");
            Console.WriteLine(myAccount.Withdraw(100)? "Операция удалась" : "Недостаточно средств" );
            Console.WriteLine(myAccount);
            Console.WriteLine("Пополнение счёта:");

            myAccount.Deposit(1000);

            Console.WriteLine(myAccount);
            Console.WriteLine("Снятие со счёта:");
            Console.WriteLine(myAccount.Withdraw(100) ? "Операция удалась" : "Недостаточно средств");
            Console.WriteLine(myAccount);

            Console.ReadKey();
        }
    }
}
