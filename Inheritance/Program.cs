using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance.Domain;
using Inheritance.Domain.Entities;

namespace Inheritance
{
    static class Util
    {
        public static int Add(this int i, int addend)
        {
            return i + addend;
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine(i.Add(3));
            Console.WriteLine(Util.Add(i,3));

            PC hero = new PC();
            hero.Draw();
            hero.Move(0,1);
            hero.Draw();
            hero.GainExperience(5);
            Console.WriteLine(hero.GetExperience());
            Console.WriteLine();

            List<Entity> gameEntities = new List<Entity>
            {
                new PC(), new Slime(), new Tree()
            };

            foreach (var entity in gameEntities)
            {
                entity.Draw();
                entity.Move(0, 0);
                entity.Draw();
                Console.WriteLine();

            }
        }
    }
}
