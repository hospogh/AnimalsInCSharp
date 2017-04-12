using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows;
using Windows;
using System.IO;

namespace Animals
{
    abstract class Animal
    {
        public string Name { get; set; }
        public abstract int Legs { get; }

        public Animal(string name)
        {
            this.Name = name;
        }
        public abstract void Speak();
    }


    class Cat : Animal
    {
        public Cat(String name) : base(name) { }

        public override int Legs
        {
            get
            {
                return 4;
            }
        }

        public override void Speak()
        {
            Console.WriteLine("Meoow!!");
        }
    }

    class Dog : Animal
    {
        public Dog(String name) : base(name) { }

        public override int Legs
        {
            get
            {
                return 4;
            }
        }

        public override void Speak()
        {
            Console.WriteLine("HafHaf!!");
        }
    }

    class Bird : Animal
    {
        public Bird(String name) : base(name) { }
        
        public override int Legs
        {
            get
            {
                return 4;
            }
        }

        public override void Speak()
        {
            Console.WriteLine("TsivTsiv!!");
        }
    }

    class Lion : Animal
    {
        public Lion(String name) : base(name) { }

        public override int Legs
        {
            get
            {
                return 4;
            }
        }

        public override void Speak()
        {
            Console.WriteLine("RaRaRa!!");
        }
    }
}