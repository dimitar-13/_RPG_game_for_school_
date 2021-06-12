using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Weapon
    {
        public int Weapondmg { get; set; }

        public string WeaponType { get; set; }


        public Weapon(int Wepd, string Weapt)
        {
            this.Weapondmg = Wepd;
            this.WeaponType = Weapt;

        }



        public override string ToString()
        {
            return base.ToString();
        }


    }
}
