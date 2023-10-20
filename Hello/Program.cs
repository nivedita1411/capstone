// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using Entity;
using BzLayer;


MovieBz bz = new MovieBz();
List<Movie> movies = bz.GetMovies();

if( movies != null)
{
    foreach(var m in movies)
    {
        Console.WriteLine($"{m.Id} {m.Name} {m.Ryear} {m.Ratings}");
    }
}

else
{
    Console.WriteLine("No movies Found");
}
