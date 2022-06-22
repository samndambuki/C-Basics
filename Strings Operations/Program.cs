//Declare Strings
string outstr;
string str1 = "The quick brown fox jumps over the lazy dog";
string str2  = "This is a string";
string str3 = "THIS is a STRING";
string[] strs = {"One","Two","Three","Four"};

//length of a string
Console.WriteLine(str1.Length);
//Access individual characters
Console.WriteLine(str1[14]);
//iterate over a string
foreach(char ch in str1){
 Console.Write(ch);
 if(ch == 'b'){
  Console.WriteLine();
  break;
 }
}
//string concatenation
outstr = String.Concat(strs);
Console.WriteLine(outstr);
//joining strings together with join
outstr = string.Join('.',strs);
Console.WriteLine(outstr);

outstr = string.Join("---",strs);
Console.WriteLine(outstr);
//string comparison 
//0
//<0
//>0
int result = string.Compare(str2,"This is a string");
Console.WriteLine(result);
//equals returns a reular boolean
bool isEqual = str2.Equals(str3);
Console.WriteLine(isEqual);
//String Searching
Console.WriteLine(str1.IndexOf('e'));
Console.WriteLine(str1.IndexOf("fox"));

Console.WriteLine(str1.LastIndexOf('e'));
Console.WriteLine(str1.LastIndexOf("the"));

outstr = str1.Replace("fox","cat");
Console.WriteLine(outstr);
Console.WriteLine(outstr.IndexOf("fox"));
