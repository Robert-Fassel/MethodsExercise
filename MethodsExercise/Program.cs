using Microsoft.VisualBasic.FileIO;
using System.Runtime.CompilerServices;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Madlibs knockoff\nPlease enter the folowing information for a fun story!");
            Console.WriteLine("First Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Favorite Animal:");
            string animal = Console.ReadLine();
            Console.WriteLine("Favorite Color:");
            string color = Console.ReadLine();
            Console.WriteLine("Favorite Band:");
            string band = Console.ReadLine();
            Console.WriteLine($"This is the story of how {name} saved the day.");
            Console.WriteLine($"{name} set off to see {band} perform.");
            Console.WriteLine($"Unknown to {name} a vicious {animal} escaped from the zoo.");
            Console.WriteLine($"{name} wore a {color} shirt which we all know makes an angry {animal} even angrier.");
            Console.WriteLine($"Fortunately {name} had a half eaten chili dog");
            Console.WriteLine($"Everyone knows that there is nothing that a hungry {animal} loves more than chili dogs.");
            Console.WriteLine($"Thinking quickly, {name} threw the tasty morsel into a conveniently placed cage.");

        }
        //TODO: I would like to have a way to get male or female from the user and from that be able to 
        // plug the gender specific variable pronouns (he,him,his,she,her)
        // respective to the gender input, into the story to and more context.
    }
}
