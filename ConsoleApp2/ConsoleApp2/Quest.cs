using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Quest
    {
            public string Name { get; set; }
            public string Description { get; set; }
            public bool Completed { get; set; }

            public Quest(string name, string description)
            {
                Name = name;
                Description = description;
                Completed = false;
            }

            public void Complete()
            {
                Completed = true;
                Console.WriteLine("Вы завершили задание " + Name + "!");
                // реализация награды за задание
            }
    }
}
