﻿using System;
using Course.Entities;
using Ex_Account.Entities;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "ALex", 500);
            Account acc2 = new SavingsAccount(1002, "Alex", 500, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);


        }
    }
}