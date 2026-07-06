using gun7;

TaskManager manager = new TaskManager();

while (true)
{
    Console.WriteLine("==== TASK MANAGER ====");

    Console.WriteLine("1. Add Task"+
        "\n2. Remove Task" +
        "\n3. Complete Task" +
        "\n4. Find Task" +
        "\n5. Show All Tasks" +
        "\n6. Show Pending Tasks" +
        "\n7. Show Completed Tasks" +
        "\n8. Exit");

    Console.WriteLine("Please select an option (1-8):");
    string input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Console.WriteLine("Enter task title:");
            string title = Console.ReadLine();
            Console.WriteLine("Enter task description:");
            string description = Console.ReadLine();
            manager.AddTask(title, description, false, DateTime.Now);
            break;
        case "2":
            Console.WriteLine("Enter task title to remove:");
            string removeTitle = Console.ReadLine();
            manager.RemoveTask(removeTitle);
            break;
        case "3":
            Console.WriteLine("Enter task title to complete:");
            string completeTitle = Console.ReadLine();
            manager.CompleteTask(completeTitle);
            break;
        case "4":
            Console.WriteLine("Enter task title to find:");
            string findTitle = Console.ReadLine();
            TaskItem? task = manager.FindTask(findTitle);
            if (task != null)
            {
                Console.WriteLine(task);
            }
            else
            {
                Console.WriteLine("Bulunamadı");
            }
            break;
        case "5":
            manager.ShowTasks();
            break;
        case "6":
            manager.PendingTasks();
            break;
        case "7":
            manager.CompletedTasks();
            break;
        case "8":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid option. Please select a number between 1 and 8.");
            break;
    }
}