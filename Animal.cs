using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooProject
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public int Energy { get; set; }
        public abstract void Voice();
        public abstract void Eat();

        public Animal(string name)
        {
            Name = name;
            Energy = 0;
        }
    }
}
