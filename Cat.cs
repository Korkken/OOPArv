using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPArv
{
    internal class Cat : Animal
    {
        public string Dangerous { get; set; }
        public Cat(string name, int numberoflegs, string sound, string food, string habitat) : base(name, numberoflegs, sound, food, habitat)
        {
            string Dangerous = "Yes";
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Sound}");
        }
        public override void Eat()
        {
            Console.WriteLine($"The bear is eating {Food}.");
        }
        public override void Hunt()
        {
            base.Hunt();
        }
        public void Climb()
        {
            Console.WriteLine("The cat is climbing a cat tree.");
        }
    }
}
