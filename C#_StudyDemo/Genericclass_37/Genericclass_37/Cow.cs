﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Genericclass_37
{
    public class Cow : Animal
    {
        public void Milk() => WriteLine($"{name} has been milked.");
        public Cow(string newName) : base(newName) { }

        public override void MakeANoise()
        {
            WriteLine($"{name} says 'moo!';");
            //throw new NotImplementedException();
        }
    }
}
