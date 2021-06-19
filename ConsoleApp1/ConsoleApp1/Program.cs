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
            Character wizzard = new Character(65, 30, "wizzard", 30);
            Character knight = new Character(80, 20, "knight", 20);
            Character elf = new Character(60, 30, "Elf", 25);

            List<Character> Hero = new List<Character>();
            List<Enemy> Enemylist = new List<Enemy>();

            Enemy FirstEnemy = new Enemy(40, 5);
            Enemy SecondEnemy = new Enemy(50, 10);
            Enemy ThirdEnemy = new Enemy(60, 15);
            Enemy Boss = new Enemy(70, 15);

            Enemylist.Add(FirstEnemy);
            Enemylist.Add(SecondEnemy);
            Enemylist.Add(ThirdEnemy);
            Enemylist.Add(Boss);

            Weapon Sword = new Weapon(5, "Mele");
            Weapon Bow = new Weapon(10, "Range");
            Weapon Galangal = new Weapon(15, "Range");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Welcome to the best RPG game ever made!");
            Console.ReadKey();
            Console.WriteLine("1.Play game:");
            Console.WriteLine("2.Get a list of playable characters:");
            string c = Console.ReadLine();
            if (c == "2")
            {
                Console.WriteLine("Wizzard:The wizzard has " + wizzard.hp + "hp and he can deal " + wizzard.dmg + "dmg without his weapon,he can also heal with a spell for " + wizzard.healing + "hp!");
                Console.WriteLine("Knight:The knight has " + knight.hp + "hp and he can deal " + knight.dmg + "dmg without his weapon,he can also heal with a potion for " + knight.healing + "hp!");
                Console.WriteLine("Elf:The elf has " + elf.hp + "hp and he can deal " + elf.dmg + "dmg without his weapon,he can also heal with a spell for " + elf.healing + "hp!");
                Console.ReadLine();
            }
            knight.Addwepdmg(Sword.Weapondmg);
            elf.Addwepdmg(Bow.Weapondmg);
            wizzard.Addwepdmg(Galangal.Weapondmg);

            Console.WriteLine("Chose a character:");
            Console.WriteLine("1.Wizzard");
            Console.WriteLine("2.Knight");
            Console.WriteLine("3.Elf");

            string a = Console.ReadLine();
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
            Console.ReadKey();

            foreach (var Enemy in Enemylist)
            {

                Console.WriteLine(Enemy);

                while (Enemy.Enemyhp > 0)
                {
                    if (Hero.ElementAt(0).hp <= 0)
                    {
                        Console.WriteLine("You died!");
                        break;
                    }
                    Console.WriteLine("Chose between heal and attack!");
                    string b = Console.ReadLine();

                    if (b == "Heal" || b == "heal" || b == "h")
                    {
                        Hero.ElementAt(0).Heal();
                        Console.WriteLine("You healed for about: " + Hero.ElementAt(0).hp + "hp");
                        Console.ReadKey();
                    }

                    else if (b == "Attack" || b == "attack" || b == "a")
                    {
                        Console.WriteLine("You delt " + Hero.ElementAt(0).dmg + "dmg to the enemy");
                        Enemy.EnemyBeingHit(Hero.ElementAt(0).dmg);
                        Console.WriteLine("The enemy has left:" + Enemy.Enemyhp + "hp!");
                        Console.ReadKey();
                    }

                    if (Enemy.Enemyhp <= 0)
                    {
                        Console.WriteLine("Enemy is dead!");
                        break;
                    }
                    Console.WriteLine("Its the Enemy turn now!");
                    Hero.ElementAt(0).beingHit(Enemy.Enemydmg);
                    Console.WriteLine("The enemy delt " + Enemy.Enemydmg + "dmg to you.You have " + Hero.ElementAt(0).hp + "hp left");
                }

            }
            if (Hero.ElementAt(0).hp > 0)
            {
                Console.ReadLine();
                Console.WriteLine("You have taken down the final boss!");
                Console.ReadKey();
                Console.WriteLine("You have beeten the dungeon!");
            }
            Console.ReadLine();
            Console.Read();
        }
    }
}
