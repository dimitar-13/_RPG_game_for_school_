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
            Character wizzard = new Character(100, 50, "Wizzard", 20);

            //attacking void of the hero to the enemy

            Enemy FirstEnemy = new Enemy(55, 10);


            wizzard.beingHit(FirstEnemy.Enemydmg);

            FirstEnemy.EnemyBeingHit(wizzard.dmg);



            Console.WriteLine(wizzard);
           
            Story.FightingScene();Console.WriteLine(FirstEnemy);


            Console.ReadLine();
            
            Story.TheEnd();

            Console.WriteLine("Game Over!");
            Console.Read();
        }
    }

}
