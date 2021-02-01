﻿
namespace challenge_exceptions.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account ()
        {
        }

        public Account ( int number, string holder, double balance, double withDrawLimit )
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Desposit (double amount)
        {
            Balance += amount;
        }

        public void WithDraw (double amount)
        {
            Balance -= +amount;
        }
    }
}
