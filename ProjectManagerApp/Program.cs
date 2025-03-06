using System.Threading.Tasks;

namespace ProjectManagerApp
{
    class Program
    {
        static void Main()
        {
            List<Task> tasks = new List<Task>();
            CommandStack commandStack = new CommandStack();

            while (true)
            {
                Console.WriteLine("-------------Приложение для управления задачами------------");
                Console.WriteLine("Комманды: 1 - Создать задачу  2 - Обновить задачу  3 - Удалить задачу 4 - Посмотреть созданные задачи 5 - Отменить последнюю команду");
                string num = Console.ReadLine();

                switch (num)
                {
                    case "1":
                        Console.Write("Описание: ");
                        string desc = Console.ReadLine();
                        Task newTask = new Task { Id = tasks.Count + 1, Description = desc };
                        commandStack.ExecuteCommand(new CreateTaskCommand(tasks, newTask));
                        break;

                    case "2":
                        Console.Write("ID задачи: ");
                        int updateId = int.Parse(Console.ReadLine());
                        Task taskToUpdate = tasks.Find(t => t.Id == updateId);

                        Console.Write("Новое описание: ");
                        string newDesc = Console.ReadLine();
                        commandStack.ExecuteCommand(new UpdateTaskCommand(taskToUpdate, newDesc));
                        break;

                    case "3":
                        Console.Write("ID задачи: ");
                        int deleteId = int.Parse(Console.ReadLine());
                        Task taskToDelete = tasks.Find(t => t.Id == deleteId);
                        commandStack.ExecuteCommand(new DeleteTaskCommand(tasks, taskToDelete));
                        break;

                    case "4":
                        foreach (var task in tasks)
                        {
                            Console.WriteLine($"ID: {task.Id}, Описание: {task.Description}");
                        }
                        break;

                    case "5":
                        commandStack.Undo();
                        break;

                    default:
                        Console.WriteLine("Повторите комманду");
                        break;
                }
            }
        }
    }
}