using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount accountPetrov = new BankAccount(150);
            BankAccount accountIvanov = new BankAccount();

            Console.WriteLine("Счёт Петрова:");
            Console.WriteLine(accountPetrov);
            Console.WriteLine();

            Console.WriteLine("Счёт Иванова:");
            Console.WriteLine(accountIvanov);
            Console.WriteLine();

            Console.WriteLine("Попытка перевода Иванову от Петрова 100 денег:");
            Console.WriteLine(accountIvanov.TransferFrom(accountPetrov, 100) ? "Перевод прошёл успешно" : "Перевод не удался");

            Console.WriteLine("Счёт Петрова:");
            Console.WriteLine(accountPetrov);
            Console.WriteLine();

            Console.WriteLine("Счёт Иванова:");
            Console.WriteLine(accountIvanov);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
