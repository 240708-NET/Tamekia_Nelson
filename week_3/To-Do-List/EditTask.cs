using System;
using TodoData.Models;

namespace TodoListConsoleApp
{
    public class EditTask
    {
        public static void Run()
        {
            TodoList todo = TodoList.GetInstance();
            Console.WriteLine("Enter the ID of the task you want to edit: "); 
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid ID. Please enter a valid ID.");
                return;
            }

            Todo? task = todo.Tasks.FirstOrDefault(t => t.ID == id); 
            if (task == null)
            {
                Console.WriteLine("Task not found. Please enter a valid ID.");
                return;
            }

            Console.WriteLine($"Current task: {task.TodoTask}");
            Console.WriteLine("Enter the new task description: ");
            string newDescription = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(newDescription))
            {
                Console.WriteLine("Please enter a valid task. Task cannot be empty!!");
                return;
            }

            todo.EditTask(id, newDescription); 
            Console.WriteLine("Task edited successfully!");
        }
    }
}
