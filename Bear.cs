using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OOPArv;

namespace OOPArv
{
    internal class Bear : Animal
    {
        public string Dangerous { get; set; }
        public Bear(string name, int numberoflegs, string sound, string food, string habitat) : base(name, numberoflegs, sound, food, habitat)
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
            Console.WriteLine("The bear is climbing a tree.");
        }
    }
}
