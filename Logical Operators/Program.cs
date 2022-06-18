using System;
namespace LogicalOperators{
 class Program{
  static void Main(string[] args){
   //logical Operators
   Console.WriteLine("-----Logical Operators-----");
   var x = 10;
   var y = 2;
   //Console.WriteLine(x>y && y>=5);
   //Console.WriteLine(x>y || y>=5);
   string str = "hello";
   //?? value on left if not null value on right if null
   //Console.WriteLine(str?? "Unknown String");
   str ??= "New String";
   Console.WriteLine(str);
  }
 }
}