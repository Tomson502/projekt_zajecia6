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
         
    }
}