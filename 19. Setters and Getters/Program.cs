using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Setters_and_Getters
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie("john wick", "dwyat","PG-13");
            Console.WriteLine(movie.title);

            Movie movie1 = new Movie("superman","peterson", "NH");
            Console.WriteLine(movie1.rating);

            Console.ReadLine();
        }
    }
}
