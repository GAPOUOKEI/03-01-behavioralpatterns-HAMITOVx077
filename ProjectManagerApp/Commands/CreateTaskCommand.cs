using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagerApp
{
    class CreateTaskCommand : ICommand
    {
        private Task _task;
        private List<Task> _tasks;

        public CreateTaskCommand(List<Task> tasks, Task task)
        {
            _tasks = tasks;
            _task = task;
        }

        public void Execute()
        {
            _tasks.Add(_task);
            Console.WriteLine($"Задача с ID {_task.Id} создана");
        }

        public void Undo()
        {
            _tasks.Remove(_task);
            Console.WriteLine($"Создание задачи с ID {_task.Id} отменено");
        }
    }
}
