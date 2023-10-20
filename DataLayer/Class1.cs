using Entity;
namespace DataLayer; // namespace and classname should never be the same and classname should not be same as inbuild classes
public class DataAccess
{
    public static List<Movie> movies =  new List<Movie> ()
    {
        new Movie {Id = 1, Name = "Abcdefg", Ratings=1,Ryear = 2001},
        new Movie {Id = 2, Name = "Bcdefgh", Ratings=2,Ryear = 2003},
        new Movie {Id = 3, Name ="Cdefghi", Ratings=3,Ryear = 2005},
        new Movie {Id = 4, Name = "Dedghij", Ratings=5,Ryear = 2002},
        new Movie {Id = 5, Name = "Efghijk", Ratings=2,Ryear = 2004}
    };

    public List <Movie> GetMovies()
    {
        return movies;
    }
}
