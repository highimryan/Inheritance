using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Domain.Entities
{
    public class Tree : Entity
    {
        public Tree()
        {
            x = 3;
            y = 19;
            texture = "Tree";
        }


        public override void Move(int x, int y)
        {
            Console.WriteLine("Trees can't move...");
        }
    }
}
