﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPArv
{
    internal class Chihuahua : Dog
    {
        public string Size { get; set; }
        public Chihuahua(string name, int numberoflegs, string sound, string food, string habitat, string size) : base(name, numberoflegs, sound, food, habitat)
        {
            Size = size;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Sound}");
        }
        public void Playing() 
        {
            Console.WriteLine($"{Name} is playing with the mice");
        }
    }
}