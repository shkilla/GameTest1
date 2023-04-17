using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Inventory
    {
            public List<GameObject> Items { get; set; }

            public Inventory()
            {
                Items = new List<GameObject>();
            }

            public void AddItem(GameObject item)
            {
                Items.Add(item);
                Console.WriteLine("Вы добавили " + item.Name + " в инвентарь.");
            }

            public void UseItem(GameObject item)
            {
                Console.WriteLine("Вы использовали " + item.Name + ".");
                // логика баффа/дебаффа от предмета
            }
    }
}
