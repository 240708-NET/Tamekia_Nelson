namespace TodoData.Models
{
    public class Todo
    {
        public int ID { get; set; }
        public string TodoTask { get; set; } = string.Empty;
        public int TaskNumber { get; set; }
        public bool IsComplete { get; set; }

        public Todo (string Task, int TaskTracker)
        {
            this.TodoTask = Task;
            this.TaskNumber = TaskTracker;
        }

        public Todo() {}

        public void Track()
        {
            Console.WriteLine("Tracking task {0}", this.TodoTask);
        }

        public override string ToString()
        {
            return $"{ID} {TodoTask}";
        }
    }
}
