namespace TodoListConsoleApp
{
    public class DeleteTask
    {
        public static void Run()
        {
            TodoList todo = TodoList.GetInstance();

            if (todo.Tasks.Count == 0)
            {
                Console.WriteLine("No tasks available to delete.");
                return;
            }

            Console.WriteLine("Current list of tasks:");
            foreach (var task in todo.Tasks)
            {
                Console.WriteLine($"{task.ID}. {task.TodoTask}");
            }

            Console.WriteLine("Enter the task ID you want to delete: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid. Please enter a valid ID.");
                return;
            }

            todo.DeleteTask(id);
        }
    }
}
