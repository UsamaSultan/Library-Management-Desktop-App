using System.Collections.Generic;

namespace Exercise3
{
    public class Row
    {
        public int ID { get; set; }
        public List<Bookshelf> bookshelves;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Row()
        {
            bookshelves = new List<Bookshelf>();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id"></param>
        public Row(int id)
        {
            this.ID = id;
            bookshelves = new List<Bookshelf>();
        }
    }
}
