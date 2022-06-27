using System;
using System.Text;

//IsPalindrome returns a tuple of two vlaues
(bool,int) IsPalindrome(string theStr){
 string teststr;

 //convert string to uppercase
 teststr = theStr.ToUpper();
 //stringbuilder to strip out all the punctuation
 var sb = new StringBuilder();
 foreach(char c in teststr){
  //add characters to builder if not punctuation or whitespace
  if(!char.IsPunctuation(c) && ! char.IsWhiteSpace(c)){
   sb.Append(c);
  }
 }
 //convert builder to finished string
 teststr = sb.ToString();

 //compare characters starting at the beginning and at the end of string
 int i=0,j=teststr.Length-1;
 while(i<=j){
  //if characers at each index dont match its not a palindrome
  if(teststr[i] != teststr[j]){
   return(false,0);
  }
  //update counters and try again
  i++;
  j--;
 }
 //if we reach this point we have a palindrome
 return(true,theStr.Length);
}

string inputStr="";
(bool b,int l) result;
Console.WriteLine("Lets begin: ");
while(inputStr != "exit"){
 inputStr = Console.ReadLine();
 if(inputStr != "exit"){
 result = IsPalindrome(inputStr);
 Console.WriteLine($"Palindrome: {result.b},Length:{result.l}");
 }
}


