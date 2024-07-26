// Main method and program entry/exit 
// Sets the program up with expections to enter corresponding selection based on what that user would like to do
// Handles selections to navigate through application
// Once the application has ended the list resets

namespace TodoListConsoleApp
{
    public class Program{
        public static void Main(string[] args)
        {
            TodoList todoList = TodoList.GetInstance();
            while(true)
            {
                Console.WriteLine("Press #1 and press 'Enter' to add a new task: ");
                Console.WriteLine("Press #2 and press 'Enter' to view task list");
                Console.WriteLine("Press #3 and press 'Enter' to exit to-do application");
                
                int selection;
                bool isValid = int.TryParse(Console.ReadLine(), out selection);
                if (!isValid)
                {
                    Console.WriteLine("Invalid selection. Please choose a valid number.");
                    continue;
                }
                switch(selection)
                {
                    case 1:
                        AddTask.Run();
                        break;
                    case 2:
                        ViewTaskList.Run();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}



