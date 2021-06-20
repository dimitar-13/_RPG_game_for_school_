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
            Character wizzard = new Character(65, 30, "wizzard", 30, 0);
            Character knight = new Character(80, 20, "knight", 20, 0);
            Character elf = new Character(60, 30, "Elf", 25, 0);

            List<Character> Hero = new List<Character>();
            List<Enemy> Enemylist = new List<Enemy>();


            Enemy FirstEnemy = new Enemy(40, 5, 20);
            Enemy SecondEnemy = new Enemy(50, 10, 25);
            Enemy ThirdEnemy = new Enemy(60, 15, 40);
            Enemy Boss = new Enemy(70, 15, 60);

            Enemylist.Add(FirstEnemy);
            Enemylist.Add(SecondEnemy);
            Enemylist.Add(ThirdEnemy);
            Enemylist.Add(Boss);

            Weapon Sword = new Weapon(5, "Mele");
            Weapon Bow = new Weapon(10, "Range");
            Weapon Galangal = new Weapon(20, "Range");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Welcome to the best RPG game ever made!");
            Console.ReadKey();
            Console.WriteLine("1.Play game:");
            Console.WriteLine("2.Get a list of playable characters:");
            string c = Console.ReadLine();
            if (c == "2")
            {
                Console.WriteLine("Wizzard: The wizzard has " + wizzard.hp + " hp and he can deal " + wizzard.dmg + " dmg without his weapon, he can also heal with a spell for " + wizzard.healing + " hp!");
                Console.WriteLine("Knight: The knight has " + knight.hp + " hp and he can deal " + knight.dmg + " dmg without his weapon, he can also heal with a potion for " + knight.healing + " hp!");
                Console.WriteLine("Elf: The elf has " + elf.hp + " hp and he can deal " + elf.dmg + " dmg without his weapon, he can also heal with a spell for " + elf.healing + " hp!");
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
            Console.Clear();

            foreach (var Enemy in Enemylist)
            {

                Console.WriteLine("This is your " + Enemylist.IndexOf(Enemy) + "th/st" + " " + Enemy);

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
                        Console.WriteLine("You healed: " + Hero.ElementAt(0).hp + " hp");
                        Console.ReadKey();
                    }

                    else if (b == "Attack" || b == "attack" || b == "a")
                    {
                        Console.WriteLine("You delt " + Hero.ElementAt(0).dmg + " dmg to the enemy");
                        Enemy.EnemyBeingHit(Hero.ElementAt(0).dmg);
                        Console.WriteLine("The enemy has left: " + Enemy.Enemyhp + " hp!");
                        Console.ReadKey();
                    }

                    Console.WriteLine("Its the Enemy turn now!");
                    Hero.ElementAt(0).beingHit(Enemy.Enemydmg);
                    Console.WriteLine("The enemy delt " + Enemy.Enemydmg + " dmg to you.You have " + Hero.ElementAt(0).hp + " hp left");

                    if (Enemy.Enemyhp <= 0)
                    {
                        Console.WriteLine("Enemy is dead!");
                        Hero.ElementAt(0).AddCurency(Enemy.EnemyBounty);
                        Console.WriteLine("You recive " + Enemy.EnemyBounty + " coins for killing the enemy!");
                        if (Enemylist.Count <= 0)
                        {
                            break;
                        }
                        Console.ReadKey();
                        Console.WriteLine("Do you want to enter the shop?y/n");
                        string answer2 = Console.ReadLine();
                        if (answer2 == "y" || answer2 == "yes" || answer2 == "Yes")
                        {
                            Console.WriteLine("You've entered the shop!");
                            Console.WriteLine("What are you looking for?");
                            Console.ReadKey();
                            Console.WriteLine("1.Weapon Upgrade: Adds 5 dmg to your weapon.");
                            Console.WriteLine("Cost 15 coins:You have " + Hero.ElementAt(0).currency);
                            Console.ReadKey();
                            Console.WriteLine("2.Healing boost: Make that so you heal with 10 hp more.");
                            Console.WriteLine("Cost 20 coins:You have " + Hero.ElementAt(0).currency);
                            Console.ReadKey();
                            Console.WriteLine("3.Ultimate heal: You will heal with 130 hp points.");
                            Console.WriteLine("Cost 40 coins: You have " + Hero.ElementAt(0).currency);
                            Console.ReadKey();
                            Console.WriteLine("Chose something or contuinue!");
                            while (Hero.ElementAt(0).currency >= 20)
                            {
                                string answer = Console.ReadLine();
                                if (answer == "2" || answer == "Healing boost" || answer == "healing boost" && Hero.ElementAt(0).currency >= 20)
                                {
                                    Console.WriteLine("You have chosen the healing boost.");
                                    Console.WriteLine("You heal with 10 hp points more now! ");
                                    int sumhealing;
                                    Hero.ElementAt(0).healing = sumhealing = Hero.ElementAt(0).healing + 10;

                                    int curencycost;
                                    Hero.ElementAt(0).currency = curencycost = Hero.ElementAt(0).currency - 20;
                                    Console.ReadKey();
                                }
                                if (answer == "1" || answer == "Weapon Upgrade" || answer == "weapon upgrade" && Hero.ElementAt(0).currency >= 15)
                                {
                                    Console.WriteLine("You have chosen the weapon dmg boost.");
                                    Console.WriteLine("Your weapon deals 5 more dmg now! ");
                                    int sumdmg;
                                    Hero.ElementAt(0).dmg = sumdmg = Hero.ElementAt(0).dmg + 5;

                                    int curencycost2;
                                    Hero.ElementAt(0).currency = curencycost2 = Hero.ElementAt(0).currency - 15;
                                    Console.ReadKey();
                                }

                                if (answer == "3" || answer == "Ultimate heal" || answer == "ultimate heal" && Hero.ElementAt(0).currency >= 40)
                                {
                                    Console.WriteLine("You have chosen the ultimate heal. You will heal with 130hp points! ");

                                    int healplayer;
                                    Hero.ElementAt(0).hp = healplayer = Hero.ElementAt(0).hp + 130;
                                    int curencycost3;
                                    Hero.ElementAt(0).currency = curencycost3 = Hero.ElementAt(0).currency - 40;
                                    Console.ReadKey();
                                }
                                Console.WriteLine("You have " + Hero.ElementAt(0).currency + " coins left you can stil buy things if you want, or you can continue.");
                                if (answer == "Countinue" || answer == "countinue" || answer == "c")
                                {
                                    break;
                                }
                            }
                        }
                        if (answer2 == "n" || answer2 == "No" || answer2 == "no")
                        {
                            break;
                        }

                    }
                }
                Console.Clear();
            }

            if (Hero.ElementAt(0).hp > 0)
            {
                Console.WriteLine("You have beaten the shit out of the final boss!");
                Console.ReadKey();
                Console.WriteLine("You successfully completed the dungeon!");
            }
            Console.ReadLine();
            Console.Read();
        }
    }
}