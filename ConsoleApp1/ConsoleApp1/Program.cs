using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {

        static void Main(string[] args)
        {
            Character wizzard = new Character(65, 25, "wizzard", 20);
            Character knight = new Character(80,20,"knight",10);
            Character elf = new Character(60, 25, "Elf", 15);

            List<Character> Hero = new List<Character>();
            List<Enemy> Enemylist = new List<Enemy>();

            Enemy FirstEnemy = new Enemy(40, 5);
            Enemy SecondEnemy = new Enemy(50, 10);
            Enemy ThirdEnemy = new Enemy(60, 15);
            Enemy Boss = new Enemy(70, 20);

            Enemylist.Add(FirstEnemy);
            Enemylist.Add(SecondEnemy);
            Enemylist.Add(ThirdEnemy);
            Enemylist.Add(Boss);

            Weapon Sword = new Weapon(5,"Mele");
            Weapon Bow = new Weapon(10,"Range");
            Weapon Galangal = new Weapon(15,"Range"); 

            knight.Addwepdmg(Sword.Weapondmg);
            elf.Addwepdmg(Bow.Weapondmg);
            wizzard.Addwepdmg(Galangal.Weapondmg);
        
            Console.WriteLine("Chose a character:");
            Console.WriteLine("1.Wizzard");
            Console.WriteLine("2.Knight");
            Console.WriteLine("3.Elf");

            string a=Console.ReadLine();

            if (a == "wizzard" || a == "Wizzard" || a == "1")
            {
                Console.WriteLine("You have chosen the Wizzard.");
                Hero.Add(wizzard);
            }

            if (a == "knight" || a == "Knight" || a == "2")
            {
                Console.WriteLine("You have chosen the Knight.");
                Hero.Add(knight);
            }

            if (a == "Elf" || a == "elf" || a == "3")
            {
                Console.WriteLine("You have chosen the Elf.");
                Hero.Add(elf);
            }

            Console.WriteLine("You run into an enemy!");


            foreach (var Enemy in Enemylist)
            {

                Console.WriteLine(Enemy);

                while (Enemy.Enemyhp > 0)
                {

                    Console.WriteLine("Chose between heal and attack!");

                    string b = Console.ReadLine();

                    if (b == "Heal" || b == "heal")
                    {
                        Hero.ElementAt(0).Heal();
                        Console.WriteLine("You healed for about: " + Hero.ElementAt(0).hp + "hp");


                    }

                    else if (b == "Attack" || b == "attack")
                    {
                        Enemy.EnemyBeingHit(Hero.ElementAt(0).dmg);
                        Console.WriteLine("The enemy has left:" + Enemy.Enemyhp + "hp!");
                    }

                    if (Enemy.Enemyhp <= 0)
                    {
                        Console.WriteLine("Enemy is dead!");
                    }


                    if (Enemy.Enemyhp <= 0)
                    {
                        break;
                    }

                    Console.WriteLine("Its the Enemy turn now!");
                    Hero.ElementAt(0).beingHit(Enemy.Enemydmg);
                    Console.WriteLine("The enemy delt " + Enemy.Enemydmg + "dmg to you.You have " + Hero.ElementAt(0).hp + "hp left");
                }

            }
            Console.ReadLine();
            Console.WriteLine("You have taken down the final boss!");
            Console.ReadLine();
            Console.WriteLine("You have beeten the dungeon!");

            Console.ReadLine();
            Console.Read();
        }
    }
}
