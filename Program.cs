using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME
{
    class Program
    {
        static public Hero GetHero()
        {
            Hero hero = new Hero();

            hero.HP = 100;
            hero.StrongAttack = 40;
            hero.LowAttack = 10;
            return hero;
        }

        static public Enemy GetEnemy()
        {
            Enemy enemy = new Enemy();
            Random rnd = new Random();

            enemy.HP = 100;
            enemy.Attack = rnd.Next(0, 50);
            return enemy;
        }

        static public void Main(string[] args)
        {
            //1
            Console.WriteLine("Первый раунд");

            Hero hero = new Hero();
            Enemy enemy = new Enemy();
            Random rnd = new Random();
            Console.WriteLine("Выберете атаку: 1 - слабая атака, 2 - сильная атака");
            int atk1 = Convert.ToInt32(Console.ReadLine());

            if (atk1 == 1)
                hero.Damage = 10;
            else if (atk1 == 2)
                hero.Damage = 40;
            else
                Console.WriteLine("Выберете 1 или 2");

            enemy.Attack = rnd.Next(0, 50);

            hero.HP = 100 - enemy.Attack;
            enemy.HP = 100 - hero.Damage;

            Console.WriteLine("Результат первого раунда:");
            Console.WriteLine($"HP героя = {hero.HP}");
            Console.WriteLine($"HP врага = {enemy.HP}");

            //2
            Console.WriteLine("Второй раунд");

            Console.WriteLine("Выберете атаку: 1 - слабая атака, 2 - сильная атака");
            int atk2 = Convert.ToInt32(Console.ReadLine());

            if (atk2 == 1)
                hero.Damage = 10;
            else if (atk2 == 2)
                hero.Damage = 40;
            else
                Console.WriteLine("Выберете 1 или 2");

            enemy.Attack = rnd.Next(0, 50);

            hero.HP = hero.HP - enemy.Attack;
            enemy.HP = enemy.HP - hero.Damage;

            Console.WriteLine("Результат второго раунда:");
            Console.WriteLine($"HP героя = {hero.HP}");
            Console.WriteLine($"HP врага = {enemy.HP}");

            //3
            Console.WriteLine("Третий раунд");

            Console.WriteLine("Выберете атаку: 1 - слабая атака, 2 - сильная атака");
            int atk3 = Convert.ToInt32(Console.ReadLine());

            if (atk3 == 1)
                hero.Damage = 10;
            else if (atk3 == 2)
                hero.Damage = 40;
            else
                Console.WriteLine("Выберете 1 или 2");

            enemy.Attack = rnd.Next(0, 50);

            hero.HP = hero.HP - enemy.Attack;
            enemy.HP = enemy.HP - hero.Damage;

            Console.WriteLine("Результат третьего раунда:");
            Console.WriteLine($"HP героя = {hero.HP}");
            Console.WriteLine($"HP врага = {enemy.HP}");

            Console.WriteLine("Результат боя: ");
            if (hero.HP > enemy.HP)
                Console.WriteLine("ГЕРОЙ ОДЕРЖАЛ ПОБЕДУ!!!");
            else if (hero.HP < enemy.HP)
                Console.WriteLine("ГЕРОЙ ПОТЕРПЕЛ ПОРАЖЕНИЕ :(");

            Console.ReadKey();

        }



    }
}
