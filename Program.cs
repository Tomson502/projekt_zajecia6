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
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available to complete.");
                return;
            }
            Console.Write("Enter the task number to complete: ");
            for (int i = 0; i < tasks.Count; i++)
            {
                string status = completedTasks[i] ? "[x]" : "[]";
                Console.WriteLine($"{i + 1}. {status} {tasks[i]}");
            }
            Console.Write("Number of the task to complete: ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int taskNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid task number.");
                return;
            }

            int index = taskNumber - 1;
            if (index < 0 || index >= tasks.Count)
            {
                Console.WriteLine("Task number out of range. Please try again.");
                return;
            }

            if (completedTasks[index])
            {
                Console.WriteLine($"This \"{task[index]}\" is already completed.");
            }
            else
            {
                completed[index] = true;
                Console.WriteLine($"Task \"{tasks[index]}\" marked as completed.");
            }
        }
        static void RemoveTasks()
        {
            if (task.Count == 0)
            {
                Console.WriteLine("No tasks available to remove ");
                return;
            }
            Console.WriteLine("Witch task want to remove? picka a number of task:");
            for (int i = 0; i < tasks.Count; i++)
            {
                string status = completedTasks[i] ? "[x]" : "[]";
                Console.WriteLine($"{i + 1}. {status} {tasks[i]}");
            }

            Console.Write("Number of task:");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int taskNumber))
            {
                Console.WriteLine("Invalid input please put the right number.");
                return;
            }
            int index = taskNumber - 1;
            if (index < 0 || index >= tasks.Count)
            {
                Console.WriteLine("This tasks dosent exist.");
                return;
            }
            string removedTask = tasks[index];
            tasks.RemoveAt(index);
            completed.RemoveAt(index);
            Console.WriteLine($"Task Delete: \"{removedTask}\"");
        }    
    }
}