namespace TodoListConsoleApp
{
    public class EditTask
    {
        public static void Run()
        {
            TodoList todo = TodoList.GetInstance();
            
            if (todo.Tasks.Count == 0)
            {
                Console.WriteLine("No tasks available to edit.");
                return;
            }

            Console.WriteLine("Current list of tasks by ID:");
            for (int i = 0; i < todo.Tasks.Count; i++)
            {
                Console.WriteLine($"{i}. {todo.Tasks[i]}");
            }

            Console.WriteLine("Enter the task ID you want to edit: ");
            if (!int.TryParse(Console.ReadLine(), out int index) || index < 0 || index >= todo.Tasks.Count)
            {
                Console.WriteLine("Invalid. Please enter a valid ID.");
                return;
            }

            Console.WriteLine($"Current task: {todo.Tasks[index]}");
            Console.WriteLine("Enter the new task description: ");
            string newTask = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(newTask))
            {
                Console.WriteLine("Please enter a valid task. Task cannot be empty!!");
                return;
            }

            todo.EditTask(index, newTask);
            Console.WriteLine("Task edited successfully!");
        }
    }
}
