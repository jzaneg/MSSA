using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables  
            string animal = "";
            string noise = "";
            string animalName = "";
            string eat = "";
            string product = "";
            string talent = "";

            Console.WriteLine("Welcome to the Farm. Here are some of the animals and a few fun facts.\n");

            //Instantiating 'Horse' class
            Horse horse = new Horse();
            horse.speak(animalName = "Mr.Ed", animal = "horse", noise = "neigh");
            horse.eat(eat = "hay");
            horse.product(product = "glue");
            horse.talent(talent = "I like to race.\n");

            //Instantiating 'Cow' class
            Cow cow = new Cow();
            cow.speak(animalName = "Ribeye", animal = "cow", noise = "Mooooo");
            cow.eat(eat = "grass");
            cow.product(product = "steaks");
            cow.talent(talent = "I own a fast food restaraunt.\n");

            //Instantiating 'Chicken' class
            Chicken chicken = new Chicken();
            chicken.speak(animalName = "Nugget", animal = "chicken", noise = "bawwwwwk");
            chicken.eat(eat = "corn");
            chicken.product(product = "chicken nuggets");
            chicken.talent(talent = "Everything tastes like me.\n");

            //Instantiating 'Goat' class
            Goat goat = new Goat();
            goat.speak(animalName = "Billy", animal = "goat", noise = "baaaahhh");
            goat.eat(eat = "grass");
            goat.product(product = "milk");
            goat.talent(talent = "I'll eat your clothes if you get close to me.");


            Console.ReadKey();
        }
    }
}
