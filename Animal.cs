using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPArv
{
    internal class Animal
    {
        public string Name { get; set; }
        public int NumberOfLegs { get; set; }
        public string Sound { get; set; }
        public string Food { get; set; }
        public string Habitat { get; set; }
        public Animal(string name, int numberOfLegs, string sound, string food, string habitat)
        {
            Name = name;
            NumberOfLegs = numberOfLegs;
            Sound = sound;
            Food = food;
            Habitat = habitat;
        }
      


        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound}");
        }
        public virtual void Eat()
        {
            Console.WriteLine($"{Name} eats {Food}");
        }
        public virtual void Hunt()
        { 
            Console.WriteLine();
        }
    }
}
