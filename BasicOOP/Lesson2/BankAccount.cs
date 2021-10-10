using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    class BankAccount
    {
        private BankAccountTypes type;
        private long balance;
        private long id;

        private static long lastId;

        public BankAccountTypes Type
        {
            get => type;
            set
            {
                type = value;
            }
        }

        public long Balance
        {
            get => balance;
            set
            {
                balance = value;
            }
        }

        public long Id
        {
            get => id;
            private set
            {
                id = value;
            }
        }

        public BankAccount()
        {
            Id = GenerateUniqueId();
        }

        private long GenerateUniqueId() => ++lastId;
            

        public override string ToString()
        {
            return $"Номер счёта: {this.Id} \n" +
                $"Тип счёта: {Enum.GetName(typeof(BankAccountTypes), this.Type)}\n" +
                $"Баланс: {this.Balance}";
        }
    }
}
