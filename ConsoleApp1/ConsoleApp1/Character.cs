﻿using System;
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


        public Character(int h, int d, string c, int he)
        {
            this.hp = h;
            this.dmg = d;
            this.clas = c;
            this.healing = he;
        }



        public void beingHit(int AttackPower)
        {
            hp -= AttackPower;

        }

        public void Heal()
        {
            hp += healing;


        }

        public override string ToString()
        {
            return ("You have picked the hero *" + clas + "* and he has " + hp + " hp, he deals " + dmg + " damage with his weapon and he can heal up to " + healing + " hp/health! ");
        }
    }
}
