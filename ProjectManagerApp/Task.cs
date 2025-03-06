using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagerApp
{
    public class Task
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"Задача {Id}: {Description}";
        }
    }
}
