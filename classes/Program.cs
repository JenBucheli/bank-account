using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Jenifer Bucheli", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with  €{account.Balance} initial balance.");

            account.MakeWithdrawal(150, DateTime.Now, "Telenet");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(2300, DateTime.Now, "Salary");
            Console.WriteLine(account.Balance);

            try
            {
                var invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
            }

           
            try
            {
                account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }



        }
    }
}
