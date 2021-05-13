using FarmSystem.Test2;
using System;

namespace FarmSystem.Test1
{
    public class Cow : Animal, IMilkableAnimal
    {
        protected override string Noise => "Moo";

        public void Walk()
        {
            Console.WriteLine("Cow is walking");
        }

        public void ProduceMilk()
        {
            Console.WriteLine("Cow produced milk");
        }
    }
}