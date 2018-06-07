using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MovieModel
    
{
    class MovieProgram
    {
        static void Main(string[] args)
        {

            List<Movie> allMovies = fillMovies(); // list of movies filled by fillMovies() function
            allMovies = allMovies.OrderByDescending(x => x.rating).ToList(); // sort by descending rating, top rated movies first
            List<Movie> top10 = allMovies.GetRange(0, 10); // shows on screen the top 10 movies, based on the reviews they have received

            foreach (var mov in top10)
            {
                Console.WriteLine(mov.title);
                Console.WriteLine(mov.rating);
                Console.ReadLine();
            }
        }

        // This function initializes the list of reviews

        static List<Review> fillReviews(string T)
        {
            List<Review> reviews = new List<Review>();

            // Input of reviews
            if (T == "The Shawshank Redemption")
            {
                reviews.Add(new Review { rate = 10, comment = "mpompa" });
                reviews.Add(new Review { rate = 5, comment = "metria" });                
            }

            else if (T == "The Godfather")
            {
                reviews.Add(new Review { rate = 7, comment = "kali" });
                reviews.Add(new Review { rate = 8, comment = "poli kali" });                
            }

            else if (T == "The Godfather: Part II")
            {
                reviews.Add(new Review { rate = 2, comment = "xalia" });
                reviews.Add(new Review { rate = 3, comment = "min tin deite" });                
            }

            else if (T == "The Dark Knight")
            {
                reviews.Add(new Review { rate = 10, comment = "the best" });
                reviews.Add(new Review { rate = 9, comment = "foberi" });                
            }

            else if (T == "12 Angry Men")
            {
                reviews.Add(new Review { rate = 7, comment = "nice" });
                reviews.Add(new Review { rate = 6, comment = "ok" });                
            }

            else if (T == " Schindler's List")
            {
                reviews.Add(new Review { rate = 5, comment = "etsi ki etsi" });
                reviews.Add(new Review { rate = 6, comment = "mmm" });                
            }

            else if (T == "The Lord of the Rings: The Return of the King")
            {
                reviews.Add(new Review { rate = 10, comment = "the best" });
                reviews.Add(new Review { rate = 8, comment = "foberi" });                
            }

            else if (T == "Pulp Fiction")
            {
                reviews.Add(new Review { rate = 7, comment = "etsi ki etsi" });
                reviews.Add(new Review { rate = 5, comment = "mmm" });                
            }

            else if (T == "The Good, the Bad and the Ugly")
            {
                reviews.Add(new Review { rate = 7, comment = "nice" });
                reviews.Add(new Review { rate = 5, comment = "ok" });                
            }

            else if (T == "Fight Club")
            {
                reviews.Add(new Review { rate = 7, comment = "kali" });
                reviews.Add(new Review { rate = 8, comment = "poli kali" });                
            }

            else if (T == "The Lord of the Rings: The Fellowship of the Ring")
            {
                reviews.Add(new Review { rate = 10, comment = "the best" });
                reviews.Add(new Review { rate = 10, comment = "foberi" });               
            }

            else // (T == "Forrest Gump")
            {
                reviews.Add(new Review { rate = 8, comment = "kali" });
                reviews.Add(new Review { rate = 8, comment = "poli kali" });                
            }

            return reviews;

        }

        // This function initializes the list of movies
        static List<Movie> fillMovies()
        {
            List<Movie> movies = new List<Movie>();

            // Input of 12 movies with their features
            movies.Add(new Movie { title = "The Shawshank Redemption", boxOffice = 59, actors = "Tim Robbins, Morgan Freeman, Bob Gunton", reviews = fillReviews("The Shawshank Redemption") });
            movies.Add(new Movie { title = "The Godfather", boxOffice = 260, actors = "Marlon Brando, Al Pacino, James Caan", reviews = fillReviews("The Godfather") });
            movies.Add(new Movie { title = "The Godfather: Part II", boxOffice = 50, actors = "Al Pacino, Robert Duvall, Diane Keaton", reviews = fillReviews("The Godfather: Part II") });
            movies.Add(new Movie { title = "The Dark Knight", boxOffice = 1000, actors = "Christian Bale, Heath Ledger, Aaron Eckhart", reviews = fillReviews("The Dark Knight") });
            movies.Add(new Movie { title = "12 Angry Men", boxOffice = 2000, actors = "Martin Balsam, John Fiedler, Lee J. Cobb", reviews = fillReviews("12 Angry Men") });
            movies.Add(new Movie { title = " Schindler's List", boxOffice = 321, actors = "Liam Neeson, Ben Kingsley, Ralph Fiennes", reviews = fillReviews(" Schindler's List") });
            movies.Add(new Movie { title = "The Lord of the Rings: The Return of the King", boxOffice = 1120, actors = "Noel Appleby, Ali Astin, Sean Astin", reviews = fillReviews("The Lord of the Rings: The Return of the King") });
            movies.Add(new Movie { title = "Pulp Fiction", boxOffice = 214, actors = "Tim Roth, Amanda Plummer, Laura Lovelace", reviews = fillReviews("Pulp Fiction") });
            movies.Add(new Movie { title = "The Good, the Bad and the Ugly", boxOffice = 25, actors = "Eli Wallach, Clint Eastwood, Lee Van Cleef", reviews = fillReviews("The Good, the Bad and the Ugly") });
            movies.Add(new Movie { title = "Fight Club", boxOffice = 100, actors = "Edward Norton, Brad Pitt, Meat Loaf", reviews = fillReviews("Fight Club") });
            movies.Add(new Movie { title = "The Lord of the Rings: The Fellowship of the Ring", boxOffice = 871, actors = "Alan Howard, Noel Appleby, Sean Astin", reviews = fillReviews("The Lord of the Rings: The Fellowship of the Ring") });
            movies.Add(new Movie { title = "Forrest Gump", boxOffice = 678, actors = "Tom Hanks, Rebecca Williams, Sally Field", reviews = fillReviews("Forrest Gump") });

            return movies;
        }       

    }

}