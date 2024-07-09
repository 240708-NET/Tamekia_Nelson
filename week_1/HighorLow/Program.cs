class Program
{
	static void Main( string[] args )
	{
		Console.WriteLine( "High/Low Running" );

	// in SDLC a user story is a way to track a feature


	// computer should choose a randon number 
	// user should be able to make guesses
	// if the guess is too high... computer should respond so 
	// if the guess is too low... computer should say
	// user wins if they guess the target number
	// user can guess until they guess the correct number 
	
		// Variables
		int targetNumber;
		int guessNumber;
		int roundCount = 0;
		string guessString;

		// creating a random number
		Random rand = new Random();
		targetNumber = rand.Next(11);
		
		// for loop may not know when to stop
		// foreach is right out, nothing to iterate
		// while loop would work..... 
		// do while will execute at lease once, will work better


		do {
			// roundCount = roundCount + 1;
			// roundCount += 1;
			roundCount++;		
	
			Console.Write( "Enter a guess between 0 - 10: " );
			guessString = Console.ReadLine();

			guessNumber = Int32.Parse( guessString );
		
			if(guessNumber == targetNumber) 
			{
				Console.WriteLine( " Greate Job!!! " );
			}
			else if(guessNumber > targetNumber)
			{
				Console.WriteLine( " Your number is too high!!! ");
			}
			else
			{
				Console.WriteLine( "Oops, too low!!!" );
			}
		} while ( guessNumber != targetNumber );
		Console.WriteLine( "Thank you for playing!!" );
		Console.WriteLine( $"Rounds to guess, {roundCount}" );
	}
}
