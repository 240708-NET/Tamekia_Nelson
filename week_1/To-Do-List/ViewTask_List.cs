// functionality for user to view task after input
// if user adds a new task they can select 2 in console to view all task added during the current console section

namespace TodoListConsoleApp
{
    public class ViewTaskList
    {
        public static void Run()
        {
            TodoList todo = TodoList.GetInstance();
            todo.ViewTaskList();
        }
    }
}