using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Character
    {
        public int hp { get; set; }
        public int dmg { get; set; }
        public string clas { get; set; }
        public int healing { get; set; }

        public int currency { get; set; }

        public Character(int h, int d, string c, int he,int cu)
        {
            this.hp = h;
            this.dmg = d;
            this.clas = c;
            this.healing = he;
            this.currency = cu;
        }

        public void beingHit(int AttackPower)
        {
            hp -= AttackPower;
        }

        public void Heal()
        {
            hp +=healing;
        }
       
        public void Addwepdmg(int wepdmg)
        {
            dmg += wepdmg;

        }

        public void AddCurency(int a)
        {
            currency += a; 


        }

        public override string ToString()
        {
            return ("You have picked the class " + clas + " he has " + hp + " hp and he deals " + dmg + " damage and he can heal up to " + healing + " hp/health! You always start with " + currency+"coins!");
        }
    }
}
