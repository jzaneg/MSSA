using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumPractice_movieStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set new instance of the movie struct assigning it the movie name 'Troy'
            movie Troy = new movie();
            Troy.movieTitle = "Troy";

            //Sets a new instance of the release date struct assigning it the name 'date'
            releaseDate date = new releaseDate();
            //assigns values to the year, month, and day
            date.year = "2004";
            date.month = "May";
            date.day = "14";
            //sets new variable and assigns it the concatenated release date
            string rDate =(date.year + " " + date.month + " " + date.day);

            //Sets the rating of the movie = 'R';
            Troy.rating = rating.R;
            //Sets the genre of the movie = "Action";
            Troy.genre = genre.Action;
            //Movie Description
            Console.WriteLine($"The title is: {Troy.movieTitle}\nThe release date is: {rDate}\nThe rating is: {Troy.rating}\nThe genre is: {Troy.genre}");
            Console.ReadKey();
        }
        struct movie
        {
            public string movieTitle;
            //public releaseDate date;
            public rating rating;
            public genre genre;
        }
        struct releaseDate
        {
            public string year;
            public string month;
            public string day;
        }
        enum rating
        {
            R, PG13, PG, G
        }
        enum genre
        {
            Action, SciFi, Horror, Comedy
        }
    }
}
