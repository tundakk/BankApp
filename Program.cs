using System;

namespace challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //VARIABLE
            char choice;


            CheckingAccount ca1 = new CheckingAccount("Jane Fonda", 123, 12345.32);
            SavingsAccount sa1 = new SavingsAccount("Jane Fonda", 123, 242.00);
            BankAccounts b1 = new BankAccounts("testAccount", 666);

            do
            {
                System.Console.WriteLine(sa1.ShowOptions());  
                choice = Convert.ToChar(Console.ReadLine().ToLower());       


                switch (choice)
                {
                    case '1':
                        System.Console.WriteLine(sa1.GetInfo());
                        System.Console.WriteLine(ca1.GetInfo());
                        break;
                    case '2':
                        System.Console.WriteLine(ca1.ShowBallance());
                        break;
                    case '3':
                        System.Console.WriteLine("Write how much you want to deposit?");
                        double depositAmount = Convert.ToDouble(Console.ReadLine());
                        ca1.Deposit(depositAmount);
                        System.Console.WriteLine($"You've deposited ${depositAmount} to your Checking account");
                        break;
                    case '4':
                    if (sa1 is BankAccounts) //true
                    {
                        
                    }
                        break;
                    case '5':
                        // b1.setRegion("Aarhus");
                        // break;
                    case '6':

                    case 'x':
                        System.Console.WriteLine("exiting the program");
                        break;

                }
                Console.ReadKey();
                Console.Clear();
            } while (choice != 'x');
        }
    }
}
