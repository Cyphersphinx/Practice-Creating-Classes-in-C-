using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Class_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var album = new Album("Dangerous", "Michael Jackson");
            var book = new Book("Ender's Game", "Orson Scott Card");
            var movie = new Movie("Transformers", "Michael Bay");


            Console.WriteLine("The album " + album.Title + " was created by " + album.Artist);
            Console.WriteLine("The book " + book.Title + " was written by " + book.Author);
            Console.WriteLine("The movie " + movie.Title + " was directed by " + movie.Director);
            Console.WriteLine("Press any key to continue: ");
            Console.ReadKey();
        }
    }
}
