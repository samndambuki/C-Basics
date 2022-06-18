using System;
namespace Switch{
 class Program{
  static void Main(string[] args){
   int theVal = 560;
   switch(theVal){
    case 50:
    Console.WriteLine("The val is 50");
    break;
    case 51:
    Console.WriteLine("The val is 51");
    break;
    case 52:
    case 53:
    case 54:
    Console.WriteLine("The val is between 52 and 54");
    break;
    default:
    Console.WriteLine("The val is something else");
    break;
   }
  }
 }
}