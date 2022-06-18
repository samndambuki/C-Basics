using System;

namespace Conditionals{
 class program{
  static void Main(string[] args){
   int theVal = 51;
   //if(theVal == 50){
    //Console.WriteLine("The val is small");
   //}
   //else if(theVal >=51 && theVal <= 60 ){
    //Console.WriteLine("The val is between 51 and 60");
   //}
   //else{
    //Console.WriteLine("The val is large");
   //}
   //Ternary Operator
   Console.WriteLine(theVal < 50 ? "the val is small" : "theVal is large");
  }
 }
}
