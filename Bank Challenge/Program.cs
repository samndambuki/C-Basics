using System;

namespace ProgChallenge{
 class Program{
  static void Main(string [] args){
   // create the checking Account with initial balance
   CheckingAcct checking = new CheckingAcct("John","Doe",2500.00m);
   //Create the savings Account with interest and initial balance
   SavingAccount saving = new SavingAccount("Jane","Doe",0.025m,1000.0m);

   //Check the balances
   Console.WriteLine($"Checking Balance is {checking.Balance:C2}");
   Console.WriteLine($"Savings Balance is {saving.Balance:C2}");

   //Account owner info
   Console.WriteLine($"Checking Owner : {checking.AccountOwner}");
   Console.WriteLine($"Savings Owner : {saving.AccountOwner}");

   //Deposit
   checking.Deposit(200.0m);
   saving.Deposit(150.0m);

   //Check Balances - 2700 and 1150
   Console.WriteLine($"Checking Balance is {checking.Balance:C2}");
   Console.WriteLine($"Savings Balance is {saving.Balance:C2}");

   //Withdrawals 
   checking.Withdraw(50.0m);
   saving.Withdraw(125.0m);

   //Balances - 2650 1025
   Console.WriteLine($"Checking Balance is {checking.Balance:C2}");
   Console.WriteLine($"Savings Balance is {saving.Balance:C2}");

   //Apply savings interest 
   saving.ApplyInterest();
   //Savings - 1050.63
    Console.WriteLine($"Savings balance is {saving.Balance:C2}");

    //More than 3 savings withdwawals - 2.00 charge
    saving.Withdraw(10.0m);
    saving.Withdraw(20.0m);
    saving.Withdraw(30.0m);

    //Saving Balance - 988.63
    Console.WriteLine($"Savings balance is {saving.Balance:C2}");

    //try overdraw savings - denied
    saving.Withdraw(2000.0m);

    //overdraw - extra charge
    saving.Withdraw(3000.0m);

    //Output = -385 and 988.63

   Console.WriteLine($"Checking Balance is {checking.Balance:C2}");
   Console.WriteLine($"Savings Balance is {saving.Balance:C2}");
 }
}
}