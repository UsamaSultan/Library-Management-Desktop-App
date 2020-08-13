using System.Collections.Generic;

namespace Exercise3
{
    public class Bookshelf
    {
        public int ID { get; set; }
        public List<Book> books;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Bookshelf()
        {
            books = new List<Book>();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id"></param>
        public Bookshelf(int id)
        {
            this.ID = id;
            books = new List<Book>();
        }

    }
}
