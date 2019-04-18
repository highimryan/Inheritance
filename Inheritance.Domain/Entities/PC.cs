using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Domain.Entities
{
    public class PC : Entity
    {
        private int exp = 0;

        public PC()
        {
            x = 23;
            y = 7;
            texture = "Player Character";
        }

        public void GainExperience(int exp)
        {
            this.exp += exp;
        }

        public int GetExperience() => exp;

        public new void Move(int x, int y)
        {
            Console.WriteLine("Man, I didn't want to get out of bed today...");

            base.Move(x,y);
        }
    }
}
