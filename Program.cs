using System;
using System.Threading;

namespace Madlib2
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter a number: 1, 2, or 3 (and hit Enter)");
            string w = SentChoice.SentChoice1(); //pauses to store value
            Console.WriteLine("Enter a thing (and hit Enter)");
            string thing1 = Console.ReadLine(); 
            Console.WriteLine(w + thing1); //prints first sentence

            Console.WriteLine(); //creates a visual break
            Thread.Sleep(2000); //pauses for 2 seconds

            Console.WriteLine("Enter another number: 1, 2, or 3");
            string x = SentChoice.SentChoice2();
            Console.WriteLine("Name a celebrity");
            string celeb1 = Console.ReadLine();
            Console.WriteLine("Name an animal");
            string anml1 = Console.ReadLine();
            Console.WriteLine(celeb1 + x + anml1);

            Console.WriteLine();
            Thread.Sleep(2000);

            Console.WriteLine("Enter a number: 1, 2, or 3");
            string y = SentChoice.SentChoice3pt1();
            Console.WriteLine("Enter another number: 1, 2, or 3");
            string z = SentChoice.SentChoice3pt2();
            Console.WriteLine("Enter a verb");
            string verb1 = Console.ReadLine();
            Console.WriteLine("Enter a plural thing");
            string plthing = Console.ReadLine();
            Console.WriteLine(y + verb1 + z + plthing);

            Console.WriteLine();
            Thread.Sleep(2000);

            Console.WriteLine("That's all, folks!");
            Thread.Sleep(1000);
            Console.WriteLine("Play again");
        }
    }
}
