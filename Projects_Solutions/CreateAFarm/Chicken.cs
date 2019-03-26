using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAFarm
{
    class Chicken
    {
        public void speak(string animalName, string animal, string sound)
        {
            Console.WriteLine("I am a {0} and my name is {1}. I make a {2} sound.", animal, animalName, sound);
        }
        public void eat(string eat)
        {
            Console.WriteLine("I like to eat {0}.", eat);
        }
        public void product(string product)
        {
            Console.WriteLine("I can turn into {0}.", product);
        }
        public void talent(string talent)
        {
            Console.WriteLine("{0}", talent);
        }
    }
}
