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

        public int EnemyBounty { get; set; }

        public Enemy(int E, int D,int B)
        {
            this.Enemyhp = E;
            this.Enemydmg = D;
            this.EnemyBounty = B;
        }


        public void EnemyBeingHit(int EnemyAttackPower)
        {
            Enemyhp -= EnemyAttackPower;

        }

        public override string ToString()
        {
            return ("enemy that has  " + Enemyhp + " hp and deals " + Enemydmg + "dmg!When the enemy dies you will recive "+EnemyBounty+" coins.");
        }

    }
}
