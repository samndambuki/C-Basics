﻿using System;
 namespace Defining{
  class Program{
   static void Main(string[] args){
    //New object instances using new operator
    // Book b1 = new Book("War and Peace", "Leo Tolstoy",825);
    // Book b2 = new Book("The grapes of Wrath", "John Steinback",464);
    //Call a method on an object
    // b1._name = "Cat in the hat";
    // Console.WriteLine(b1.GetDescription());
    //Console.WriteLine(b2.GetDescription());

    //try to set one of the properties
    //result in an error 
    //b1._name = "Aldoux Housley";

    //more variables can be accessed via methods
    //set data using functions instead of accessing them directly
    // b1.SetName("Grapes of wrath");
    // b1.SetAuthor("John Steinbeck");
    // b1.SetPagecount(264);
    // Console.WriteLine(b1.GetDescription());

    //set ISBN and Price Properties
    // b1.ISBN = "100140447928";
    // b1.Price = 24.95m;
    // Console.WriteLine(b1.ISBN);
    // Console.WriteLine(b1.Price);

    //change the name and page count
    // b1.Name = "Crime and Punishment";
    // b1.PageCount = 652;
    // Console.WriteLine(b1.Description);
    // Console.WriteLine(b1.Name);
    // Console.WriteLine(b1.PageCount);
   }
  }
 }