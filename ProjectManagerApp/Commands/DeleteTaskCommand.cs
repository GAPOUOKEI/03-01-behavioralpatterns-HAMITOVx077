using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagerApp
{
    class DeleteTaskCommand : ICommand
    {
        private Task _task;
        private List<Task> _tasks;

        public DeleteTaskCommand(List<Task> tasks, Task task)
        {
            _tasks = tasks;
            _task = task;
        }

        public void Execute()
        {
            _tasks.Remove(_task);
            Console.WriteLine($"Задача с ID {_task.Id} удалена");
        }

        public void Undo()
        {
            _tasks.Add(_task);
            Console.WriteLine($"Удаление задачи с ID {_task.Id} отменено");
        }
    }
}
