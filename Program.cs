using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME
{
    class Program
    {        
        static public void Main(string[] args)
        {
            Hero hero = new Hero();
            Enemy enemy = new Enemy();
            Random rnd = new Random();

            hero.HP = 100;
            enemy.HP = 100;
            
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine($"Раунд {i}");

                Console.WriteLine("Выберете атаку: 1 - слабая атака, 2 - сильная атака");
                int atk = Convert.ToInt32(Console.ReadLine());

                if (atk == 1)
                    hero.Damage = 10;
                else if (atk == 2)
                    hero.Damage = 40;
                else
                    Console.WriteLine("Выберете 1 или 2");

                enemy.Attack = rnd.Next(0, 50);

                hero.HP = hero.HP - enemy.Attack;
                enemy.HP = enemy.HP - hero.Damage;

                Console.WriteLine($"Результат раунда {i}:");
                Console.WriteLine($"HP героя = {hero.HP}");
                Console.WriteLine($"HP врага = {enemy.HP}");
            }

            Console.WriteLine("Результат боя: ");
            if (hero.HP > enemy.HP)
                Console.WriteLine("ГЕРОЙ ОДЕРЖАЛ ПОБЕДУ!!!");
            else if (hero.HP < enemy.HP)
                Console.WriteLine("ГЕРОЙ ПОТЕРПЕЛ ПОРАЖЕНИЕ :(");

            Console.ReadKey();

        }



    }
}
