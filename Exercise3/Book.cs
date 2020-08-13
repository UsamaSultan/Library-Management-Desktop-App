using System.Collections.Generic;

namespace Exercise3
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public int PublicationYear { get; set; }
        public List<string> Author { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Book()
        {
            Author = new List<string>();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="isbn"></param>
        /// <param name="title"></param>
        /// <param name="publisher"></param>
        /// <param name="publication_year"></param>
        /// <param name="authors"></param>
        public Book(string isbn, string title, string publisher, int publication_year, List<string> authors)
        {
            ISBN = isbn;
            Title = title;
            Publisher = publisher;
            PublicationYear = publication_year;
            Author = authors;
        }
    }
}
