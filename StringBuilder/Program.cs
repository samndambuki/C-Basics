using System.Text;

int jumpcount = 10;
string[] animals = {"goats","cats","pigs"};
//string builder
 StringBuilder sb = new StringBuilder("Initial String.",200);
 //basic stats about stringbuilder
 Console.WriteLine($"Capacity:{sb.Capacity};Length:{sb.Length}");
 //add strings to the builder using append
sb.Append("The quick brown fox");
sb.Append("Jumped over the lazy dog");
//AppendLine can append a line ending
sb.AppendLine();
//Appendformat can be used to append formatted strings
sb.AppendFormat("He did this {0} times.",jumpcount);
sb.AppendLine();
//AppendJoin can iterate over a sequence of values
sb.Append("He also jumps over");
sb.AppendJoin(',',animals);
//Modify content using replace 
sb.Replace("fox","cat");
//insert content at any index
sb.Insert(0,"This is the");
 Console.WriteLine($"Capacity:{sb.Capacity};Length:{sb.Length}");
 Console.WriteLine(sb.ToString());
 







