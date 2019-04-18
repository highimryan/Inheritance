using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Domain
{
    using Texture = System.String;

    public class Entity
    {
        protected int x;
        protected int y;

        protected Texture texture;

        public void Draw()
        {
            // Take the texture and the coordinates and draw the texture at the coordinates in the grid system
            Console.WriteLine($"Drawing {texture} at {x}, {y}");
        }

        public virtual void Move(int x, int y)
        {
            Console.WriteLine("Generic move");

            this.x = x;
            this.y = y;
        }

        public int GetXPosition() => x;
        public int GetYPosition() => y;
    }
}
