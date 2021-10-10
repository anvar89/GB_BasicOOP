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
            private set
            {
                type = value;
            }
        }

        public long Balance
        {
            get => balance;
            private set
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

        public BankAccount() : this(BankAccountTypes.Deposit, 0)
        {
        }

        public BankAccount(BankAccountTypes type) : this(type, 0)
        {
        }

        public BankAccount(long balance) : this(BankAccountTypes.Deposit, balance)
        {
        }

        public BankAccount(BankAccountTypes type, long balance)
        {
            Type = type;
            Balance = balance;
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
