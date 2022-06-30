using System;
namespace Inheritance{
 //magazine as subclass of publication
 class Magazine:Publication{
  private string _publisher;
  // private int _pagecount;
  // private decimal _price;

  //use base keyword to initialise base class 
  public Magazine(string name,string publisher,int pagecount,decimal price):base(name,pagecount,price){
   _publisher = publisher;
  }
  public string Publisher{
   get => _publisher;
   set => _publisher = value;
  }
 }
}
