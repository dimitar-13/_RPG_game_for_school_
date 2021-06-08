using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Enemy 
    {
        public int Enemyhp { get; set; }

        public int Enemydmg { get; set; }


        public Enemy(int E, int D)
        {
            this.Enemyhp = E;
            this.Enemydmg = D;
        }


        public void EnemyBeingHit(int EnemyAttackPower)
        {
            Enemyhp -= EnemyAttackPower;

        }

        public override string ToString()
        {
            return ("You are facing an enemy with " + Enemyhp + " hp and it deals " + Enemydmg + " dmg!");
        }

    }
}
