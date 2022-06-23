//choose a random number between 0 and 20
int theNumber = new Random().Next(20);
bool keepGoing = true;

//print the game greeting and instructions
Console.WriteLine("Let's play 'Guess The Number!' ");
Console.WriteLine("I am thinking of a number between 0 and 20.");
Console.WriteLine("Enter your guess, or -1 to give up");

//keep track of the number of guesses and the current user  guess
int guessNum = 0;
int guessCount = 0;

//so while lopp - execute at least once 
do{
 //ask user for their current guess
 Console.WriteLine("What's your guess?");
 string theGuess = Console.ReadLine();

 //use tryparse method to parse the input to a number
 bool result = Int32.TryParse(theGuess,out guessNum);
 
 //if the user entered something else other than a number ask them again
 if(!result){
  Console.WriteLine("That does not look like a number.Try again");
 }
 else{
  //if they enter a -1 they want to exit the game
  if(guessNum == -1){
   Console.WriteLine($"I was thinking of {theNumber}");
   keepGoing = false;
  }
  else{
   //increase guessCount
   guessCount ++;
  }
  //if they got it right tell them the guesscount and exit
  if(guessNum == theNumber){
   Console.WriteLine($"You got it in {guessCount} guesses!!");
   keepGoing = false;
  }
  else{
   //tell them mto guess lower or higher than the previous guess
   Console.WriteLine("Nope,{0} than that." ,guessNum<theNumber?"higher":"lower");
  }
 }
}while(keepGoing);


