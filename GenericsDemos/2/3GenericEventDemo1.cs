using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemos._2.Event
{
    public delegate void ConfirmHandler<T1, T2>(T1 sender, T2 eventArgs) where T2 : MyEventArgs;

    public class MyEventArgs
    {
        public bool Success { get; set; } = true;
        public string ErrorMessage { get; set; }
    }
    public class ConfirmEventArgs : MyEventArgs
    {
        public string Message { get; set; }
    }
    internal class EntityCollection<T>
    {
        public string Category { get; }
        public event ConfirmHandler<EntityCollection<T>, ConfirmEventArgs> BookAdded;
        private List<T> Items = new List<T>();
        public EntityCollection(string category)
        {
            this.Category = category;
        }
        public void AddItem(T b)
        {
            try
            {
                Items.Add(b);
                BookAdded.Invoke(this, new ConfirmEventArgs { Message = $"Book Added to {Category} category" });
            }
            catch (Exception ex)
            {
                BookAdded.Invoke(this, new ConfirmEventArgs
                {
                    Success = false,
                    ErrorMessage = ex.Message + ":" + ex.StackTrace,
                    Message = string.Empty
                });
            }
        }
    }
    public class Book
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
    public class GenericDelegateDemo3
    {
        static void Main()
        {
            EntityCollection<Book> bookCollection = new EntityCollection<Book>("Technology");
            bookCollection.BookAdded += new ConfirmHandler<EntityCollection<Book>, ConfirmEventArgs>(BookAdded_Notification);
            bookCollection.AddItem(new Book { Title = "Book1", Description = "Book1" });
        }

        private static void BookAdded_Notification(EntityCollection<Book> sender, ConfirmEventArgs confirmEventArgs)
        {
            if (confirmEventArgs.Success)
            {
                Console.WriteLine(sender.Category);
                Console.WriteLine(confirmEventArgs.Message);
            }
            else
            {
                Console.WriteLine(confirmEventArgs.ErrorMessage);
            }
        }
    }
}
