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
                Balance = 1000000,
                Id = 123123123123
            };

            Console.WriteLine($"Номер счёта: {myAccount.Id} \nТип счёта: {Enum.GetName(typeof(BankAccountTypes),myAccount.Type)}\nБаланс: {myAccount.Balance}");
            Console.ReadKey();
        }
    }
}
