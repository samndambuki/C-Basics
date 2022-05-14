//Program Using Code in the .Net System Namespace
using System;
//Helps organize Programs - Nmaes in Code Names in third part y libraries
namespace HelloWorld{
 
 //C# is an OOP all code organized into classes
 //Program - Put Main Function
 class Program
 {
  //Program has an entry point called Main
  //Void - No return value 
  //Arrray of strings
  static void Main(string[] args){
   //Console - Object Represents a terminal in System namespace
   //Method/Function in Console object -Prints a string to console 
   Console.WriteLine("Hello World");
   Console.WriteLine("What is your name?");
   //Allows user type a line of text
   string str = Console.ReadLine();
   Console.WriteLine("Why, hello there " + str );
  }
 }
}
