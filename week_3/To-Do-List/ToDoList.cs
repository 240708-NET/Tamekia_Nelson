// singleton of the todo list application. 

namespace TodoListConsoleApp
{
    public class TodoList
    {
        private static TodoList instance = null!; // Private field to hold the single instance of the TodoList
        private List<string>tasks; // Private list to store task  
        private TodoList() // private constructor to prevent instantiation from outside of class
        {
            tasks = new List<string>();
        }
        public static TodoList GetInstance() // Public method to allow access to singelton 
        {    
            if (instance == null)
                {
                    instance = new TodoList();
                }
                return instance;
            }
        public void AddTask(string task) // Public method to add tasks
        {
            tasks.Add(task);
            Console.WriteLine("The to-do application is now tracking your new task!");
        }
        public void ViewTaskList() // Public method to view tasks
        {
            if(tasks.Count == 0)
            {
                Console.WriteLine("The list is currently empty. Please select appropriate selection to add a new task or exit application. ");
            }
            else 
            {
                Console.WriteLine("Current list of tasks: ");
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i +1}.{tasks[i]}");
                }
            }
        }
    }
}