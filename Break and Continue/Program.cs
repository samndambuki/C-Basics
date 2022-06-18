using System;
namespace BreakContinue{
 class Program{
  static void Main(string[] args){
   int[] values = {15,7,12,23,41,28,9,17,36};
   Console.WriteLine("Using Break and Continue");
   foreach(int val in values){
    //continues statement skips rest of loop entirely and jumps to nest iteration
    if(val >=20 && val<=29)
    continue;
    //print value
    Console.WriteLine($"val is currently{val}");
    //Break statement stops the loop and exits
    // if(val>=40){
    //  break;
    // }
   }
  }
 }
}