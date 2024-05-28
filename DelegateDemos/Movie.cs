using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemos
{
    public class Movie
    {
        // Properties
        public string Title { get; set; }
        public string Director { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }  

        // Constructor
        public Movie(string title, string director, int releaseYear, string genre, double rating)
        {
            Title = title;
            Director = director;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Director: {Director}");
            Console.WriteLine($"Release Year: {ReleaseYear}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Rating: {Rating}/10");
        }
    }

    public enum MovieFilterAttribute
    {
        Title=0,
        Director=1,
        Genre=2,
        Rating=3,
        ReleaseYear=4,
    }
}
