using System.Globalization;

string numStr1 = "1";
string numStr2 = "2.00";
string numStr3 = "3,000";
string numStr4 = "3,000.00";

int targetNum = 0;
try{
 //use Parse to try a simple integer
 targetNum = int.Parse(numStr1);
 Console.WriteLine(targetNum);

 //Parse a floating Point Number
 targetNum = int.Parse(numStr2,NumberStyles.Float);
  Console.WriteLine(targetNum);

  //Use Parse to try a number with a thousands marker
   targetNum = int.Parse(numStr3,NumberStyles.AllowThousands);
  Console.WriteLine(targetNum);
    //Use Parse to try a number with a thousands marker and decimal
    targetNum = int.Parse(numStr4,NumberStyles.Float | NumberStyles.AllowThousands);
    Console.WriteLine(targetNum);
    //Works with othe rtypes eg.Boolean
    Console.WriteLine($"{bool.Parse("True")}");
    //Floating Point Numbers
    Console.WriteLine($"{float.Parse("1.235"):F2}");
}
catch{
 Console.Write("Conversion Failed");
}
//try parse function is similar but it handles conversions for us
bool succeeded = false;
succeeded = Int32.TryParse(numStr1,out targetNum);
if(succeeded){
 Console.WriteLine($"{targetNum}");
}
