using System;
namespace WhileLoops{
 class Program{
  static void Main(string[]args){
    string inputstr = "";
   // Console.WriteLine("Basic while Loop:");
   // while(inputstr != "exit"){
   //  inputstr  = Console.ReadLine();
   //  Console.WriteLine("You entered {0}",inputstr);
   // }
   Console.WriteLine("do while Loop");
   do{
    inputstr  = Console.ReadLine();
    Console.WriteLine("You entered {0}",inputstr);
   }while(inputstr != "exit");
  }
 }
}
