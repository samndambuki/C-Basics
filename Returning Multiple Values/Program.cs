//paranthesis - group tuple values
(int a,int b) tup1 = (5,10);
var tup2 = ("Some text",10.5f);

//tuple - lightweight data structure 
//lets you group multiple values in one place

tup1.b = 20;
tup2.Item1 = "New String";
Console.WriteLine($"{tup1.a},{tup1.b}");
Console.WriteLine($"{tup2.Item1},{tup2.Item2}");

//tuples - clean way of returning multiple values from a function

//get tuple back with two integers
(int,int) result = PlusTimes(6,12);
Console.WriteLine($"Sum:{result.Item1},Product:{result.Item2}");

//function return two ints
//two int arguments
//return a tuple
static(int,int) PlusTimes(int a, int b){
 return (a+b,a*b);
}
