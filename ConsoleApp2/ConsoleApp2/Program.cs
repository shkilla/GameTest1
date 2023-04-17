using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя персонажа: ");
            string nameChar = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Выберите персонажа: ");
            Console.WriteLine("1: Викинг, 2: Воин, 3: Рыцарь, 4: Стрелок");
            int personChoose = int.Parse(Console.ReadLine());
            Console.Clear();

            int healthChar = 100;
            int maxHpChar = 100;
            int damageChar = 10;
            int coinChar = 0;
            double chanceMissChar = 1.05;

            while (personChoose < 1 || personChoose > 4)
            {
                Console.WriteLine("Такого персонажа нет! Выберите из существующих:(от 1 до  4) 1: Викинг, 2: Воин, 3: Рыцарь, 4: Стрелок.");
                personChoose = int.Parse(Console.ReadLine());
                Console.Clear();
            }

            switch (personChoose)
            {
                case 1:
                    healthChar = 150;
                    maxHpChar = 150;
                    damageChar = 10;
                    chanceMissChar = 1.05;
                    Console.WriteLine(GetInfoChar("Викинг"));
                    break;
                case 2:
                    healthChar = 100;
                    maxHpChar = 100;
                    damageChar = 18;
                    chanceMissChar = 1.1;
                    Console.WriteLine(GetInfoChar("Воин"));
                    break;
                case 3:
                    healthChar = 170;
                    maxHpChar = 170;
                    damageChar = 7;
                    chanceMissChar = 1.15;
                    Console.WriteLine(GetInfoChar("Рыцарь"));
                    break;
                case 4:
                    healthChar = 80;
                    maxHpChar = 80;
                    damageChar = 25;
                    chanceMissChar = 1.02;
                    Console.WriteLine(GetInfoChar("Стрелок"));
                    break;
                default:
                    break;
            }

            string GetInfoChar(string person)
            {
                return $"Имя: {nameChar}, Персонаж: {person}, Здоровье: {healthChar}, урон: {damageChar}";
            }

            void ChangeHpChar(int count)
            {
                if(count + healthChar >= maxHpChar)
                {
                    healthChar = maxHpChar;
                }
                else
                {
                    healthChar = healthChar + count;
                }

            }

            Console.WriteLine("Нажмите 1 чтобы продолжить или 2 чтобы вернуться: ");
            int continueGame = int.Parse(Console.ReadLine());
            if(continueGame == 1)
            {
                Console.Clear();
            }

            else if(continueGame == 2)
            {
                Console.Clear();
                Console.WriteLine("Введите имя персонажа: ");
                nameChar = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Выберите персонажа: ");
                Console.WriteLine("1: Викинг, 2: Воин, 3: Рыцарь, 4: Стрелок");
                personChoose = int.Parse(Console.ReadLine());
                Console.Clear();

                while (personChoose < 1 || personChoose > 4)
                {
                    Console.WriteLine("Такого персонажа нет! Выберите из существующих:(от 1 до  4) 1: Викинг, 2: Воин, 3: Рыцарь, 4: Стрелок.");
                    personChoose = int.Parse(Console.ReadLine());
                    Console.Clear();
                }

                switch (personChoose)
                {
                    case 1:
                        healthChar = 150;
                        maxHpChar = 150;
                        damageChar = 10;
                        chanceMissChar = 1.05;
                        Console.WriteLine(GetInfoChar("Викинг"));
                        break;
                    case 2:
                        healthChar = 100;
                        maxHpChar = 100;
                        damageChar = 18;
                        chanceMissChar = 1.1;
                        Console.WriteLine(GetInfoChar("Воин"));
                        break;
                    case 3:
                        healthChar = 170;
                        maxHpChar = 170;
                        damageChar = 7;
                        chanceMissChar = 1.15;
                        Console.WriteLine(GetInfoChar("Рыцарь"));
                        break;
                    case 4:
                        healthChar = 80;
                        maxHpChar = 80;
                        damageChar = 25;
                        chanceMissChar = 1.02;
                        Console.WriteLine(GetInfoChar("Стрелок"));
                        break;
                    default:
                        break;
                }
            }

            Console.Clear();
            Console.WriteLine($"ДОБРО ПОЖАЛОВАТЬ В ПРИКЛЮЧЕНИЕ {nameChar}!");
            Console.WriteLine("Нажмите любую клавишу чтобы продолжить...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Вы появились в маленькой деревушке с населением 1200 человек");
            Console.WriteLine("Нажмите любую клавишу чтобы продолжить...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("В последнее время на деревню стали часто нападать охотники");
            Console.WriteLine("Нажмите любую клавишу чтобы продолжить...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Ваша цель защитить деревню от следующего нападения!");
            Console.WriteLine("Нажмите любую клавишу чтобы продолжить...");
            Console.ReadKey();
            Console.Clear();

            int hpHunter1 = 100;

            Console.WriteLine("На деревню напал Охотник 1 уровня!");
            Console.WriteLine($"Здоровье охотника: {hpHunter1}");
            Console.WriteLine("Вам нужно быстро кликать на любую клавишу, чтобы преодолеть охотника!");
            Console.ReadKey();
            Console.Clear();
            while(hpHunter1 > 0)
            {
                Console.WriteLine($"Здоровье охотника: {hpHunter1}");
                Console.WriteLine("Вам нужно быстро кликать на любую клавишу, чтобы преодолеть охотника!");
                Console.ReadKey();
                hpHunter1 = hpHunter1 - damageChar;
                Console.Clear();
            }
            Console.WriteLine("Поздравляю с победой над первым соперником!");
            Console.WriteLine("Нажмите любую клавишу чтобы продолжить...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Не стоит радоваться, ведь он даже не наносил вам урона!");
            Console.WriteLine("Нажмите любую клавишу чтобы продолжить...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Ваш следующий соперник гораздо сильнее, будьте осторожней в бою!");
            Console.WriteLine("Нажмите любую клавишу чтобы продолжить...");
            Console.ReadKey();
            Console.Clear();

            hpHunter1 = 100;
            int damageHunter1 = 5;
            Console.WriteLine($"Здоровье противника: {hpHunter1}");
            Console.WriteLine($"Ваше здоровье: {healthChar}");
            Console.WriteLine("Вам нужно быстро кликать на любую клавишу, чтобы преодолеть противника!");
            Console.ReadKey();
            Console.Clear();
            while (hpHunter1 > 0)
            {
                Console.WriteLine($"Здоровье охотника: {hpHunter1}");
                Console.WriteLine($"Ваше здоровье: {healthChar}");
                Console.WriteLine("Вам нужно быстро кликать на любую клавишу, чтобы преодолеть противника!");
                Console.ReadKey();
                ChangeHpChar(-damageHunter1);
                hpHunter1 = hpHunter1 - damageChar;
                Console.Clear();
            }
            coinChar = coinChar + 20;
            Console.WriteLine("Победа!");
            Console.WriteLine("Нажмите любую клавишу чтобы продолжить...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Вы получили 20 монет за победу над противником!");
            Console.WriteLine("Нажмите любую клавишу чтобы продолжить...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("После этой нелёгкой схватки вам необходимо подлечиться!");
            Console.WriteLine($"Ваше здоровье: {healthChar}");
            Console.WriteLine($"Монеты: {coinChar}");
            Console.WriteLine("Нажмите 1 чтобы восстановить здоровье за 10 монет или 2 чтобы продолжить без восстановления: ");
            continueGame = int.Parse(Console.ReadLine());
            Console.Clear();
            if (continueGame == 1)
            {
                ChangeHpChar(100);
                Console.WriteLine("Отлично! Теперь вы готовы к следующему бою!");
                Console.WriteLine($"Ваше здоровье: {healthChar}");
                Console.WriteLine("Нажмите любую клавишу чтобы продолжить...");
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine("Continue");
            Console.WriteLine("Нажмите любую клавишу чтобы продолжить...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
