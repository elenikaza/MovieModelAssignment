using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieModel
{
    class Movie
    {
        public string title { get; set; } // Movie's title
        public float rating // Movie's rating
        {
            get
            {
                return CountMovieRating();
            }
        }

        public int boxOffice { get; set; } // Movie's box office
        public string actors { get; set; } // Movie's actors       
        public List<Review> reviews { get; set; } // Movie's list of reviews

        private float CountMovieRating()
        {
            float rating = 0;

            foreach (var element in reviews)
            {
                rating = rating + element.rate;
            }
            rating = rating / reviews.Count();

            return rating;
        }
    }
}
