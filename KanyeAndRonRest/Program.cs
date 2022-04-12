using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace KanyeAndRonRest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Kanye West and Ron Swanson walk into a bar.");
            Console.WriteLine();
            Console.WriteLine($"They order drinks and share thoughts.");
            Console.WriteLine();
            Console.WriteLine($"This is a record of their interaction.");
            Console.WriteLine();

            for ( int i = 0; i < 5; i++)
            {
                QuoteGenerator.KanyeQuote();

                Console.WriteLine();

                Console.WriteLine($"Ron orders a double scotch, pets his mustache, and then gulps down his scotch.");

                Console.WriteLine();

                QuoteGenerator.RonQuote();
            }


            
        }
    }
}
