using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal an1 = new Cat("Mrrrrrrro");
            Console.WriteLine(an1.Name);
            an1.Speak();

            Animal an2 = new Dog("Chalo");
            Console.WriteLine(an2.Name);
            an2.Speak();

            Animal an3 = new Bird("Kiwi");
            Console.WriteLine(an3.Name);
            an3.Speak();

            Animal an4 = new Lion("Catrin");
            Console.WriteLine(an4.Name);
            an4.Speak();
        }
    }

}
