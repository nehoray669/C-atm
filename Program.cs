using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{  
    class Program
    {
       
        static void Main(string[] args)
        {
            while (true) {
                Console.Clear();
            string User_id = StartUp();
            MainMenu(User_id);




            // wait before close
            Console.ReadKey();
            }
        }

         static public string StartUp() 
        {

            Console.WriteLine("Welcome to our bank. \nPlease login in to your account for further actions.\nPlease press Enter");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Username/id:");
            string User_id = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Password:");
            string password = null;
            while (true)
            {
                var key = System.Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                    break;
                password += key.KeyChar;
            }
            //string User_Password = Console.ReadLine();

            return User_id;

        }

        static public void MainMenu(string User_id)
        {
            ConsoleKeyInfo keyInfo;
            Random rnd = new Random();
            var User_balance = rnd.Next(1, 20000);
            Atm atm = new Atm();
            Console.Clear();

            Console.WriteLine(" Welcome Back! " + User_id);

            Console.WriteLine(" Your balance " + User_balance);
            Console.WriteLine("                                            Please select one of the actions.");
            Console.WriteLine("                                            1.Disposit Cash");
            Console.WriteLine("                                            2.Withdraw Cash");
            keyInfo  = Console.ReadKey();
            if(keyInfo.Key == ConsoleKey.D1) 
            {
                Console.Clear();
                Console.WriteLine("                                            Please insert the amount you want to deposit.");
                int Disposit_amount = Convert.ToInt32(Console.ReadLine());
                User_balance = atm.Deposit(User_balance,Disposit_amount);
                Console.Clear();
                Console.WriteLine("Your new balance is " + User_balance);
            }
            else if ( keyInfo.Key == ConsoleKey.D2)
            {
                Console.Clear();
                Console.WriteLine("                                            Please insert the amount you want to Withdraw.");
                int Withdraw_amount = Convert.ToInt32(Console.ReadLine());
                User_balance = atm.Withdraw(User_balance, Withdraw_amount);
                Console.Clear();
                Console.WriteLine("Your new balance is " + User_balance);
            }
       
            
            
        }
        
    }
}
