//int - No decimal points
int i = 10;
//floating -  decimal point with f at the end
float f = 2.0f;
//decimal -  decimal point with m at the end
decimal d = 10.0m;
//Boolean - True or false
bool b = true;
//Character - Single character inside single quotes
char c = 'c';
//Strings - Collection of characters inside double quotes
string str = "a string";
//var keyword to declare variables C# compiler figre out what it is
var x = 10;
var z = "Hello";
// arrays - list of values
// array of 5 integers
int[]  vals = new int[5];
// array of strings
string[] strs = {"One","Two","Three"};
//Print out values using formatting string
//Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}",i,f,d,b,c,str,x,z);
//null - variable has no value
Object obj = null;
Console.WriteLine(obj);
//Conversions - Implicit Conversion 
long bignum;
bignum = i;
//Explicit Conversions
float i_to_f = (float)i;
Console.WriteLine("{0}",i_to_f);

int f_to_i = (int)f;
Console.WriteLine("{0}",f_to_i);
























