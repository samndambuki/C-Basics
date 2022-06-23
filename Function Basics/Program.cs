//group re-usable code together
//have return type,name and optional parameters
float MilesToKm(float miles){
 float result = miles*1.6f;
 return result;
}

//function with no return value 
void PrintWithPrefix(string theStr){
 Console.WriteLine($"::>{theStr}");
}

//call first function
Console.WriteLine($"The result is {MilesToKm(8.0f)}");
Console.WriteLine($"The result is {MilesToKm(52.0f)}");

//call the second function
PrintWithPrefix("Test String");
PrintWithPrefix("Another Test String");



