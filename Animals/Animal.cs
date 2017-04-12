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
        virtual public string Name { get; set; }
        abstract public int Legs { get; }//abstract public/*private ?*/ int Legs { get; /*private ?*/set;}


        public void Speak()
        {
            SoundPlayer player = new SoundPlayer(Path);
            player.PlaySync();
        }
        protected string Path { get; set; }
    }

    abstract class Mammal : Animal
    {
        public override int Legs
        {
            get
            {
                return 4;
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }

    class Cat : Animal
    {
        public Cat(String name)
        {
            Legs = 4;
            Name = name;
            Path = @"C:\Users\hovse_000\Documents\Visual Studio 2015\Projects\Animals\Animals\sounds\cat\cat.wav";
        }
        public override int Legs { get; }
        public override string Name { get; set; }
    }

    class Dog : Animal
    {
        public Dog(String name)
        {
            Name = name;
            Legs = 4;
            Path = @"C:\Users\hovse_000\Documents\Visual Studio 2015\Projects\Animals\Animals\sounds\dog\Dog Growling And Barking-SoundBible.com-883632423.wav";
        }
        public override int Legs { get; }
        public override string Name { get; set; }
    }

    class Bird : Animal
    {
        public Bird(String name)
        {
            Legs = 2;
            Name = name;
            Path = @"C:\Users\hovse_000\Documents\Visual Studio 2015\Projects\Animals\Animals\sounds\bird\killdeer_song-Mike_Koenig-1144525481.wav";
        }
        public override int Legs { get; }
        public override string Name { get; set; }
    }

    class Lion : Animal
    {
        public Lion(String name)
        {
            Name = name;
            Legs = 4;
            Path = @"C:\Users\hovse_000\Documents\Visual Studio 2015\Projects\Animals\Animals\sounds\lion\Lion Roar-SoundBible.com-718441804.wav";
        }
        public override int Legs { get; }
        public override string Name { get; set; }

    }
}
//sounds from http://soundbible.com/
