using System;

namespace Inheritance{
 class Publication{
  private string _name;

  public Publication(string name,int pagecount,decimal price)
  {
   _name = name;
   PageCount = pagecount;
   Price = price;
  }
  public int PageCount{
   get;set;
  }
  public decimal Price{
   get;set;
  }
  public string Name{
   //return name
   get{return _name;}
   //use setter to validate new property value
   set{
    if(value == ""){
     throw new ArgumentException("Name cannot be blank");
    }
    _name = value;
   }
  }
  //virtual keyword to indicate that a method can be overriden by subclasses to customize behaviour
  public virtual string GetDescription(){
   return $"{Name},{PageCount} pages";

  }
 }
}