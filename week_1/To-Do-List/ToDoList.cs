// singleton of the todo list application. 

namespace TodoListConsoleApp
{
    public class TodoList
    {
        private static TodoList instance = null!;
        private List<string>tasks;
        private TodoList()
        {
            tasks = new List<string>();
        }
        public static TodoList GetInstance()
        {    
            if (instance == null)
                {
                    instance = new TodoList();
                }
                return instance;
            }
        public void AddTasks(string task)
        {
            tasks.Add(task);
            Console.WriteLine("The to-do application is now tracking your new task!");
        }
        public void VIEWTASK_LIST()
        {
            if(tasks.Count == 0)
            {
                Console.WriteLine("The tist is currently empty. Please select appropriate selection to add a new task or exit application. ");
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