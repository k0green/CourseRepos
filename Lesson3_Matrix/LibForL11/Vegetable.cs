﻿using System;

namespace Lesson8
{
    public class Vegetable
    {

        public string Name
        {
            get//add verification
            {
                if (Name != null)
                {
                    return Name;
                }
                else { return "Error"; }
            }
            set
            {
                Name = value;
            }
        }
        public double Coast { get; set; }
        static int Id = 0;
        public Vegetable(string name, double coast)
        {
            Name = name ?? "Udefined";
            Coast = coast;
        }

        public Vegetable()
        {
        }

        public string GetName()
        {
            return Name;
        }

        internal bool Print()
        {
            Id++;
            if (Name != null)
            {
                Console.WriteLine($"Vegetable: {Name} coast: {Coast} id:{Id}");
            }
            else { Console.WriteLine($"Vegetable: Undefined coast: {Coast} id:{Id}"); }
            return true;
        }
    }
}