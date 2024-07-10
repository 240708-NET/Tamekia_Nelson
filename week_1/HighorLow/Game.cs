class Game
{
    
    Random rand = new Random();
    int targetNumber;
    private int guessNumber = -1;
    private int roundCount = 0;
    public string guessString {get; set; } = " "; // auto-property


    // private string guessString;
    // public string get_guessString()
    // {
    //     return this.guessString;
    // }

    // public void set_guessString(string guessString)
    // {
    //     this.guessString = guessString;
    // }

    // Methods
    // getters and setters - short methods that allow you to "get/set" a value to a field
    
    /*
    public int get_guessNumber()
    {
        return this.guessNumber;
    }

    public void set_guessNumber(int _guessNumber)
    {
        if (_guessNumber > 0)
        this.guessNumber = _guessNumber;
    }
    */

    // Methods - behaviors
    // Method Signature structure
    // [Access module][Modifier][return type], [method name] ([method parameters])
    // Class : Object :: (Idea of object to actual object ie.... Blueprint to Built Home)
    
    // Access Modifiers: 
        // public (anything can access this method/object)
        // priviate (default in c#; only accessed within the same object)
        // protected (only accessed fromt the class/obj or its child/sub/inherited class) 
        // internal (can only be accessed form within the same compiled assemly)

    // (Non-Access) Modifier: will limit or restrict how a taget can be utilized
        // readonly: field can only be modified in the constructor of the class
        // static: method or field belongs to the Class, not to the object (it is shared among all instances of the Class )
        
    // Constructor - the method that instantiates an instance of an object (whatever we want to run in a new instance of the method)
    public Game ()
    {
        targetNumber = rand.Next(11);
    }
    
    public int PlayGame()
    {
        roundCount = 0;
        do 
        {
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
        return roundCount;
    }
}
