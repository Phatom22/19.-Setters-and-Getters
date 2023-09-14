using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Setters_and_Getters
{
    class Movie
    {
        public string title;
        public string director;
        public string rating;

        //constructor
        public Movie(string aTitle, string aDirector, string aRating) {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }

        public string Rating
        {
            get
            {
                return rating;

            }
            set
            {
                if (value =="G" || value == "PG" || value == "PG-13")
                {
                    rating = value;
                }
                else
                {
                    rating = "NOT RATED";
                }
            }
        }
    }
}
