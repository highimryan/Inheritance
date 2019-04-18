using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Domain.Entities
{
    public class Slime : Entity
    {
        public Slime()
        {
            x = 22;
            y = 7;
            texture = "Slime";
        }
    }
}
