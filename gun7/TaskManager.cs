namespace gun7
{
    class TaskManager
    {
        List<TaskItem> tasks = new List<TaskItem>();

        public void AddTask(string title, string description, bool isCompleted, DateTime createdDate)
        {
            TaskItem task = new TaskItem(title, description, isCompleted, createdDate);
            tasks.Add(task);
        }

        public void RemoveTask(string title)
        {
            var task = tasks.FirstOrDefault(t => t.Title == title);
            if (task!=null)
            {
                tasks.Remove(task);
                Console.WriteLine("Görev silindi.");
            }
            else
            {
                Console.WriteLine("Görev bulunamadı.");
            }
        }

        public void CompleteTask(string title)
        {
            var task = tasks.FirstOrDefault(t => t.Title == title);
            if (task != null)
            {
                task.IsCompleted = true;
            }
        }

        public TaskItem? FindTask(string title)
        {
            var task = tasks.FirstOrDefault(t => t.Title == title);
            if (task != null)
            {
                Console.WriteLine($"Found task: {task}");
            }
            else
            {
                Console.WriteLine("Task not found.");
            }
            return task;
        }
        public void ShowTasks()
        {
            foreach (var task in tasks)
            {
                Console.WriteLine(task);
            }
            if (tasks.Count==0)
            {
                Console.WriteLine("Hiç görev yok.");
                return;
            }
        }
        public void PendingTasks()
        {
            var pendingTasks = tasks.Where(t => !t.IsCompleted);
            foreach (var task in pendingTasks)
            {
                Console.WriteLine(task);
            }
            if (tasks.Count==0)
            {
                Console.WriteLine("Hiç görev yok.");
                return;
            }
        }

        public void CompletedTasks()
        {
            var completedTasks = tasks.Where(t => t.IsCompleted);
            foreach (var task in completedTasks)
            {
                Console.WriteLine(task);
            }
        }
    }
}