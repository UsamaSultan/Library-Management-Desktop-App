using System.Collections.Generic;

namespace Exercise3
{
    public class Room
    {
        public int ID { get; set; }
        public List<Row> rows;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Room()
        {
            rows = new List<Row>();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id"></param>
        public Room(int id)
        {
            this.ID = id;
            rows = new List<Row>();
        }
    }
}
