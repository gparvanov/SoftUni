using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    class Cat
    {
        public string Name
        { 
            get; 
            set; 
        }
        public string breed { get; set; }
        public int age { get; set; }

        public double Fat { get; set; }

        public void Eat()
        {
            Fat += 200;
        }
    }
}
