using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Battle
    {
        public void StartBattle(GameObject player, GameObject enemy)
        {
            while (player.Health > 0 && enemy.Health > 0)
            {
                // реализация битвы
            }

            if (player.Health > 0)
            {
                Console.WriteLine("Вы победили " + enemy.Name + "!");
                // реализация награды за победу
            }
            else
            {
                Console.WriteLine("Вы проиграли битву.");
                // реализация поражения
            }
        }
    }
}
