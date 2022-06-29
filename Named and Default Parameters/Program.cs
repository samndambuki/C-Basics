//functions can provide default values for thei parameters
void PrintWithPrefix(string thestr,string prefix=""){
 Console.WriteLine($"{prefix}{thestr}");
}

//Test Default Parameters
PrintWithPrefix("Hello There");
PrintWithPrefix("Hello There",":> ");

//Call with named Parameters
PrintWithPrefix(prefix:"%",thestr: "Hello There");



