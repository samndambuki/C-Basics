using System;

namespace StringRep{
 class Book{
  public string Name {get;set;}
  public string Author {get;set;}
  public int PageCount {get;set;}

  //string method generates string representation of the object
  //override - ovverride default behaviour in base object class 
  public override string ToString(){
   return $"Book: {Name},by {Author}";
  }
 public Book(string name,string author,int pages){
  Name = name;
  Author = author;
  PageCount = pages;
 }
 public string ToString(char format){
  if(format == 'B'){
   return $"Book:{Name}:{Author}";
  }
  if(format == 'F'){
      return $"Book:{Name} by {Author} is {PageCount} pages";
  }
  return ToString();
 }
 }
}