// functionality for user to input new task to do list
// if user selects to input task, it cannot be empty 
// add input task to console application

namespace TodoListConsoleApp
{
    public class AddTasks
    {
        public static void Run()
        {
            TodoList todo = TodoList.GetInstance();
            Console.WriteLine("Enter a new task to track: ");
            string? newTask = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(newTask))
            {
                Console.WriteLine("Please enter a valid task. Task cannot be empty!!");
            }
            else
            {
                todo.AddTasks(newTask);
            }
        }
    }
}


