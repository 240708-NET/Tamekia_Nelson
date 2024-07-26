using System;
using System.Collections.Generic;
using System.Text.Json;
using TodoData.Models;

namespace TodoListConsoleApp
{
    public class TodoList
    {
        private static TodoList instance = null!; 
        private List<Todo> tasks; 

        private TodoList() 
        {
            tasks = new List<Todo>();
        }

        public static TodoList GetInstance() 
        {    
            if (instance == null)
            {
                instance = new TodoList();
            }
            return instance;
        }

        public void AddTask(string task)
        {
            int newId = tasks.Count > 0 ? tasks[^1].ID + 1 : 1; 
            int newTaskNumber = tasks.Count + 1; 
            tasks.Add(new Todo { ID = newId, TodoTask = task, TaskNumber = newTaskNumber, IsComplete = false });
            Console.WriteLine("The to-do application is now tracking your new task!");
        }

        public IReadOnlyList<Todo> Tasks => tasks; 

        public void EditTask(int id, string newTask) 
        {
            Todo? task = tasks.Find(t => t.ID == id); 
            if (task != null)
            {
                task.TodoTask = newTask;
            }
        }

        public void DeleteTask(int id) 
        {
            Todo? task = tasks.Find(t => t.ID == id); 
            if (task != null)
            {
                tasks.Remove(task);
                Console.WriteLine("Task deleted successfully!");
            }
            else
            {
                Console.WriteLine("Invalid entry. Please enter a valid ID");
            }
        }

        public string SerializeTasks() 
        {
            return JsonSerializer.Serialize(tasks); 
        }

        public void DisplayJsonData() 
        {
            string json = SerializeTasks(); 
            Console.WriteLine("Current task list data:");
            Console.WriteLine(json);
        }

        public void ViewTaskList() 
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("The list is currently empty. Please select appropriate selection to add a new task or exit application.");
            }
            else
            {
                Console.WriteLine("Current list of tasks:");
                foreach (var task in tasks)
                {
                    Console.WriteLine($"{task.ID}. {task.TodoTask}");
                }
            }
        }
    }
}
