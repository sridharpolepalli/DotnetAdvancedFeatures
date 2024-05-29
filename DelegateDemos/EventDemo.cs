using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemos
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace DelegateDemos
    {
        public class MovieList_Events_1 : Hashtable
        {
            public event ConfirmHandler MovieAdded;
            public event ConfirmHandler MovieDeleted;

            public MovieList_Events_1()
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

    public class MovieList_Events_2 : Hashtable
    {
        private ConfirmHandler _movieAdded;
        public event ConfirmHandler MovieAdded
        {
            add
            {
                // Custom logic for adding an event handler
                Console.WriteLine("Adding an event handler");
                _movieAdded += value;
            }
            remove
            {
                // Custom logic for removing an event handler
                Console.WriteLine("Removing an event handler");
                _movieAdded -= value;
            }
        }
        public event ConfirmHandler MovieDeleted;

        public MovieList_Events_2()
        {
        }
        public void AddMovie(Movie movie)
        {
            base.Add(movie.Title, movie);
            //if (MovieAdded != null)
            //{
            //    MovieAdded.Invoke(this, new ConfirmEventArgs { Message = $"Movie with title {movie.Title} is added successfully" });
            //}
            _movieAdded?.Invoke(this, new ConfirmEventArgs { Message = $"Movie with title {movie.Title} is added successfully" });
        }
    }
}
