namespace TodoListConsoleApp
{
    public class DeleteTask
    {
        public static void Run()
        {
            TodoList todo = TodoList.GetInstance();
            
            // Display the list of tasks with their indices
            if (todo.Tasks.Count == 0)
            {
                Console.WriteLine("No tasks available to delete.");
                return;
            }

            Console.WriteLine("Current list of tasks:");
            for (int i = 0; i < todo.Tasks.Count; i++)
            {
                Console.WriteLine($"{i}. {todo.Tasks[i]}");
            }

            Console.WriteLine("Enter the task ID you want to delete: ");
            if (!int.TryParse(Console.ReadLine(), out int index) || index < 0 || index >= todo.Tasks.Count)
            {
                Console.WriteLine("Invalid. Please enter a valid ID.");
                return;
            }

            todo.DeleteTask(index);
        }
    }
}
