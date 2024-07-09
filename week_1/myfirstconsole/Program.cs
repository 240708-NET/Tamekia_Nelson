public class Program
{

	static void Main( string[] args ) // ENTRYPOINT - Main Method - The place that the application starts running
	{
		// <- c# commenting can be done using double forward slash
		/*
			Blocks of text for longer comments on multi lines
		*/
		// - Method - a block of code with a labled functiobality
		// - Methods make code readable and reusable 

        	Console.WriteLine("Hello, World!"); // Console is an object, write line is a behavior
	
		// object oriented program - bundles data/values and behavior to create an object.thing
		//	the functionality of an application is based on the relatiionship between objects

		/* 
		Variables - Data Types
			C# is a strongly typed language - we need to delclare to the compiler what type of data is going to be in each variable 
			'Type-Safe' / 'Type-Safety'
		Compliling - Taking the code we have written in C# and transforming it to machine readable 
		Interpreted - 'reads' the code line by line as it runs and executes the application as it goes - there is no build/compiling (i.e python)
			A compiled application will be faster than a interpreted application 

		*/
		Console.WriteLine("Please enter your name: ");
		// string type hold Test
		// declaring a variable
		// <variable type> <name>

		// instantiate a variable
		// <variable> = <value>

		string userName = "Tamekia";  // declaration and instantiation
		userName = "T"; // assignment (re-assignment not declaring)

		userName = Console.ReadLine();	// Console is the object, Readline is the behavior
		
		// Console.WriteLine("Welcome to week one: ");
		// Console.WriteLine( userName ); // Seperate write line

		// Console.WriteLine( "Welcome to week one: " +  userName );  // String concat
		
		// Console.WriteLine( "Welcome to week one: {0}", userName ); // String interpolation	
		
		Console.WriteLine( $"Welcome to week one: {userName}" );  // String formatting 
		
		/*
		Built-In Data Types
				
			1 0 - binary
			decimal - 5 ==> binary - 0101 
			
			int32 - 32 bit value (32 1's and 0's)
	
			NUMERIC DATA TYPES	
			double, float, long, short, decimal
			Intigers - whole numbers

			Boolean (true or false) - 1 or 0
		
			char -> character (single character)
			string -> strings of text

			byte and bit (not as common, but still used)

		/*
		/*
		Conditional statements and control flow
			if, else if, else
			switch, case
			try, catch, finally - exception handling 

		Looping 
			for (specifies number of loops)
			do-while (executes before checking the condition)
			while (checks for the condition before executing)
			foreach (iterate through a collection)
		*/


		bool? runChoice = null;
		
		if( runChoice == true )
		{
			Console.WriteLine( "runChoice is true");
		}
	
		else if( runChoice == false ) 
		{
			Console.WriteLine( "runChoice is false" );
		}

		else
		{
			Console.WriteLine( "runChoice is undefined/null" );
		}

		// comparison operators ==, >, <, >=, <=, != ( the != operator is very versatile)

		if ( 5 > 4 )
		{
			Console.WriteLine( "five is greater than four");
		}

		if ( 4 < 5 ) 
			Console.WriteLine( "four is less than five" );

	}
}
