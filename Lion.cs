using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject
{
    public class Lion : Animal
    {
        public Lion(string name) : base(name)
        {
        }

        public override void Voice() 
        {
            Console.WriteLine("Рычу очень с кайфом");
        }
        public override void Eat()
        {
            if (Energy < 100) 
            {
                Console.WriteLine($"{Name} бахнув пельменiв");
                Energy += 50;
                Voice();
            }
            else
            {
                Console.WriteLine("Наелся люто, аж пузико раздуло");
            }
        }
    }
}
