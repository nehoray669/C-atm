using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Atm
    {
        int User_balance; // user balance
        
        public int Deposit(int User_balance, int Disposit_amount) 
        {
            Console.WriteLine("Deposit");
            User_balance += Disposit_amount;
            return User_balance;
        }
        public int Withdraw(int User_balance, int Withdraw_amount)
        {
            Console.WriteLine("Withdraw");
            User_balance -= Withdraw_amount;
            return User_balance;
        }
    }
}
