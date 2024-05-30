using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherFeatures
{
    class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }

        public Book ShallowCopy()
        {
            return (Book)this.MemberwiseClone();
        }
    }
}
