using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagerApp
{
    class UpdateTaskCommand : ICommand
    {
        private Task _task;
        private string _oldDescription;
        private string _newDescription;

        public UpdateTaskCommand(Task task, string newDescription)
        {
            _task = task;
            _oldDescription = task.Description;
            _newDescription = newDescription;
        }

        public void Execute()
        {
            _task.Description = _newDescription;
            Console.WriteLine($"Задача с ID {_task.Id} обновлена");
        }

        public void Undo()
        {
            _task.Description = _oldDescription;
            Console.WriteLine($"Обновление задачи с ID {_task.Id} отменено");
        }
    }
}
