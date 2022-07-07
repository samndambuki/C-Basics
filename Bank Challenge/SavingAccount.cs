using System;
namespace ProgChallenge{
 public class SavingAccount : BankAccount{
  private int _withdrawcount = 0;
  private const decimal WITHDRAW_CHARGE = 2.0m;
  private const int WITHDRAW_LIMIT = 3;

  public SavingAccount(string fname,string lname,decimal interest,decimal initial) : base(fname,lname,initial)
  {
   InterestRate = interest;
  }
  public decimal InterestRate{
   get;set;
  }
  public void ApplyInterest(){
   //add new amount to existing balance
   Balance += (Balance * InterestRate);
  }

  public override void Withdraw(decimal amount)
  {
   //Dont alllow overdraw - print a denial message
   if(amount > Balance){
    Console.WriteLine("Attempt to Overdraw savings - denied");
   }
   else{
    base.Withdraw(amount);
   }
   //charge for more than 3 withdrawals
   _withdrawcount++;
   if(_withdrawcount > WITHDRAW_LIMIT){
    Console.WriteLine("More than three withdrawals - extra charge");
   }
   base.Withdraw(WITHDRAW_CHARGE);
  }
 }
}