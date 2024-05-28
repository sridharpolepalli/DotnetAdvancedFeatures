using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemos
{
    public class MovieCollection
    {
        List<Movie> movies = new List<Movie>();
        public MovieCollection()
        {
            movies.Add(new Movie("Inception", "Christopher Nolan", 2010, "Science Fiction", 8.8));
            movies.Add(new Movie("The Matrix", "The Wachowskis", 1999, "Action", 8.7));
            movies.Add(new Movie("The Dark Knight", "Christopher Nolan", 2008, "Action", 9.0));
        }
        public void FilterMovies(MovieFilterAttribute movieFilterAttribute, string filterValue)
        {
            List<Movie> result = new List<Movie>();
            if (movieFilterAttribute == MovieFilterAttribute.Director)
            {
                for (int i = 0; i < movies.Count; i++)
                {
                    if (movies[i].Director.Equals(filterValue, StringComparison.OrdinalIgnoreCase))
                    {
                        result.Add(movies[i]);
                    }
                }
            }
            else if (movieFilterAttribute == MovieFilterAttribute.Genre)
            {
                for (int i = 0; i < movies.Count; i++)
                {
                    if (movies[i].Genre.Equals(filterValue, StringComparison.OrdinalIgnoreCase))
                    {
                        result.Add(movies[i]);
                    }
                }
            }
            else if (movieFilterAttribute == MovieFilterAttribute.Title)
            {
                for (int i = 0; i < movies.Count; i++)
                {
                    if (movies[i].Title.Equals(filterValue, StringComparison.OrdinalIgnoreCase))
                    {
                        result.Add(movies[i]);
                    }
                }
            }
            foreach (Movie m in result) m.DisplayInfo();
        }
    }

    //----------------------using Delegate param --------------------------




    public class MovieCollection_1
    {
        private readonly List<Movie> movies = new List<Movie>();

        public MovieCollection_1()
        {
            movies.Add(new Movie("Inception", "Christopher Nolan", 2010, "Science Fiction", 8.8));
            movies.Add(new Movie("The Matrix", "The Wachowskis", 1999, "Action", 8.7));
            movies.Add(new Movie("The Dark Knight", "Christopher Nolan", 2008, "Action", 9.0));
        }

        public delegate bool MovieFilter(Movie movie, string filterValue);

        public void FilterMovies(MovieFilterAttribute movieFilterAttribute, string filterValue)
        {
            MovieFilter filter = GetFilterDelegate(movieFilterAttribute);
            List<Movie> result = new List<Movie>();

            for (int i = 0; i < movies.Count; i++)
            {
                if (filter(movies[i], filterValue))
                {
                    result.Add(movies[i]);
                }
            }

            foreach (Movie m in result) m.DisplayInfo();
        }

        private MovieFilter GetFilterDelegate(MovieFilterAttribute movieFilterAttribute)
        {
            switch (movieFilterAttribute)
            {
                case MovieFilterAttribute.Director:
                    return (movie, filterValue) => movie.Director.Equals(filterValue, StringComparison.OrdinalIgnoreCase);
                case MovieFilterAttribute.Genre:
                    return (movie, filterValue) => movie.Genre.Equals(filterValue, StringComparison.OrdinalIgnoreCase);
                case MovieFilterAttribute.Title:
                    return (movie, filterValue) => movie.Title.Equals(filterValue, StringComparison.OrdinalIgnoreCase);
                default:
                    throw new ArgumentException("Invalid filter attribute");
            }
        }
    }
}
