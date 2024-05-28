using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemos
{
    public delegate void ConfirmHandler(object o, ConfirmEventArgs args);

    public class ConfirmEventArgs
    {
        public string Message { get; set; }
    }

    public class MovieList : Hashtable
    {
        public ConfirmHandler MovieAdded;
        public ConfirmHandler MovieDeleted;

        public MovieList()
        {
        }
        public void AddMovie(Movie movie)
        {
            base.Add(movie.Title, movie);
            if (MovieAdded != null)
            {
                MovieAdded.Invoke(this, new ConfirmEventArgs { Message = $"Movie with title {movie.Title} is added successfully" });
            }
        }
    }
}
