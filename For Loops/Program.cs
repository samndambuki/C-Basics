using System;

namespace forloops{
 class Program {
  static void Main(string[] args){

   int[] nums = new int[] {3,14,15,92,6};
   // int myVal = 15;
   // Console.WriteLine("The absic for loop:");
   // for(int i=0;i<myVal;i++)
   // {
   //  Console.WriteLine("i is currently {0}",i);
   // }
   // foreach(int i in nums){
   //  Console.WriteLine("i is currently{0} ",i);
   // }
   string str = "The quick brown fox jumps over the lazy dog";
   var count = 0;
   foreach (char c in str){
    if(c=='o'){
     count ++;
    }
   }
   Console.WriteLine("Counted {0} o characters",count);
  }
 }
}