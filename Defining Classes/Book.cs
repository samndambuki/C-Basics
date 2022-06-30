using System;

// namespace Defining{
namespace Inheritance{
 //classes have a name unnique within the namespace
 //public - any other code in our proogram can use it 
  // public class Book{
   class Book:Publication{
  //member variables or "fields" to hold data
  //string _name;
  // public string _name;
  // string _author;
  // protected string  _author;
  private string _author;
  //   private int _pagecount;
  // private decimal _price;
  // int _pagecount;
  // private int _pagecount;

  //one or more constructors - object of the classes type
  // public Book(string name, string author, int pages){
  //  //initialise internal fields to each of the parameters
  //  _name = name;
  //  _author = author;
  //  _pagecount = pages;
  // }
  //Declare Methods - operate on classes and data

  //properties to implement access to our internal data
  //property with a backing field
  // public string Name{
  //  //use getters and setters
  //  get{
  //   return _name;
  //  }
  //  set{
  //   //value - automaticall passed to property when you set value
  //   _name = value;
  //  }
  // }

  //shorthand - expression bodied properties

  //use base keyword to initialise base class
  public Book(string name,string author,int pagecount,decimal price):base(name,pagecount,price)
  {
   _author = author;
  }
  public string Author{
   get => _author;
   set => _author = value;
  }
  //override keyword to override a baseclass method
  public override string GetDescription(){
    return $"{Name} by {Author}, {PageCount} pages";
  }



  // public string Author{
  //  // => means return
  //  get => _author;
  //  set => _author = value;
  // }

  // public int PageCount{
  //  get => _pagecount;
  //  //make it reaonly by removing setter
  //  set => _pagecount = value;
  // }

  //computing properties - get their values from other properties and expressions
  // public string Description{
  //  //return interpolated string
  //  get => $"{Name} by {Author},{PageCount} pages";
  // }
  //auto generated properties - dont have backing fields
  //not only control data properties but also add data properties
  // public string ISBN{
  //  get;set;
  // }
  // public decimal Price{
  //  get;set;
  // }
  // public string GetDescription(){
  //  //return interpolated string 
  //  return $"{_name} by {_author},{_pagecount}pages";
  // }
  //member variables can be accessed via methods
   // public string GetName()
   // {
   //  return _name;
   //  }
   //  public void SetName(string s){
   //   _name = s;
   //  }
   //  public void SetAuthor(string s){
   //   _author = s;
   //  }
   //  public void SetPagecount(int c){
   //   _pagecount = c;
   //  }
 // }
}
}
