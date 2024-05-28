using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemos
{
    public class MovieList_Events : Hashtable
    {
        public event ConfirmHandler MovieAdded;
        public event ConfirmHandler MovieDeleted;

        public MovieList_Events()
        {
        }
        public void AddMovie(Movie movie)
        {
            base.Add(movie.Title, movie);
            if (MovieAdded != null)
            {
                MovieAdded(this, new ConfirmEventArgs { Message = $"Movie with title {movie.Title} is added successfully" });
            }
        }
    }
}
