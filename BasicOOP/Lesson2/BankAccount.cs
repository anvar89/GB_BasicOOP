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
            set
            {
                id = value;
            }
        }
    }
}
