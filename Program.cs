using system;
using system.collections.generic;

namespace TodoApp
{
    class Program
    {
        static List<string> tasks = new List<string>();
        static List<string> completedTasks = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Todo App!");
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. View Tasks");
                Console.WriteLine("3. Complete Task");
                Console.WriteLine("4. View Completed Tasks");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        ListTasks();
                        break;
                    case "3":
                        CompleteTask();
                        break;
                    case "4":
                        RemoveTasks();
                        break;
                    case "5":
                        Console.WriteLine("Exiting the Todo App. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }
        static void AddTask()
        {
            Console.Write("Enter the task: ");
            string task = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(task))
            {
                tasks.Add(task);
                Console.WriteLine("Task added successfully.");
            }
            else
            {
                Console.WriteLine("Task cannot be empty.");
            }
        }
        static void AddTask()
        {
            Console.Write("Enter the task: ");
            string newtask = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(task))
            {
                tasks.Add(task);
                Console.WriteLine("Task added successfully.");
            }
            else
            {
                Console.WriteLine("Task cannot be empty.");
            }
        }
        static void AddTask()
        {
            Console.Write("Enter the task: ");
            string newtask = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newtask))
            {
                Console.WriteLine("task description cannot be empty.");
                return;
            }
            tasks.Add(newtask);
            completed.Add(false);
            Console.WriteLine($"Task added successfully: \"{newtask}\"");    
        }
        static void ListTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("List is empty. Please add a task.");
                return;
            }
            else
            {
                Console.WriteLine("Tasks List:");
                for (int i = 0; i < tasks.Count; i++)
                {
                    string status = completedTasks[i] ? "[x]" : "[]";
                    Console.WriteLine($"{i + 1}. {status} {tasks[i]}");
                }
            }
        }
        static void CompleteTask()
        {
            Console.WriteLine("In progress...");
        }        static void RemoveTasks()
        {
            Console.WriteLine("In progress...");
        }
    }
}