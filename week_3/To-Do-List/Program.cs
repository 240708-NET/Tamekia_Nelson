using System;
using TodoData.Models;

namespace TodoListConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TodoList todoList = TodoList.GetInstance();
            while (true)
            {
                Console.WriteLine("Press #1 and press 'Enter' to add a new task: ");
                Console.WriteLine("Press #2 and press 'Enter' to view task list");
                Console.WriteLine("Press #3 and press 'Enter' to edit task");
                Console.WriteLine("Press #4 and press 'Enter' to delete task"); 
                Console.WriteLine("Press #5 and press 'Enter' to view tasks in JSON format"); 
                Console.WriteLine("Press #6 and press 'Enter' to exit to-do application");

                if (!int.TryParse(Console.ReadLine(), out int selection))
                {
                    Console.WriteLine("Invalid selection. Please choose a valid number.");
                    continue;
                }

                switch (selection)
                {
                    case 1:
                        AddTask.Run();
                        break;
                    case 2:
                        ViewTaskList.Run();
                        break;
                    case 3:
                        EditTask.Run();
                        break;
                    case 4:
                        DeleteTask.Run();
                        break;
                    case 5:
                        todoList.DisplayJsonData();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please choose a valid number.");
                        break;
                }
            }
        }
    }
}
