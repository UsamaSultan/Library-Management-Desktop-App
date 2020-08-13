using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exercise3
{
    public class Library
    {
        public int ID { get; set; }
        public List<Room> rooms;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Library()
        {
            rooms = new List<Room>();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id"></param>
        public Library(int id)
        {
            this.ID = id;
            rooms = new List<Room>();
        }

        /// <summary>
        /// Add new room 
        /// </summary>
        /// <param name="roomID"></param>
        public void AddNewRoom(int roomID)
        {
            var room = new Room(roomID);
            rooms.Add(room);
        }

        public void AddNewRow(int rowID, int roomID)
        {
            var room = rooms.ElementAt(roomID - 1);
            var row = new Row(rowID);
            room.rows.Add(row);
        }

        public void AddNewBookshelf(int bookshelfID, int rowID)
        {
            Row theRow = null;
            var bookshelf = new Bookshelf(bookshelfID);

            foreach(var room in rooms)
            {
                foreach(var row in room.rows)
                {
                    if(row.ID == rowID)
                    {
                        theRow = row;
                        break;
                    }
                }
            }

            theRow.bookshelves.Add(bookshelf);
        }

        public void AddNewBook (string ISBN, string title, string publisher, int publication_year, string[] authors, int bookshelfID)
        {
            var book = new Book(ISBN, title, publisher, publication_year, authors.ToList());
            Bookshelf theBookshelf = null;
            foreach (var room in rooms)
            {
                foreach (var row in room.rows)
                {
                    foreach(var bookshelf in row.bookshelves)
                    {
                        if (bookshelf.ID == bookshelfID)
                        {
                            theBookshelf = bookshelf;
                            break;
                        }
                    }                    
                }
            }
            theBookshelf.books.Add(book);
        }

        public void LoadInventory(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                if (line == "" || line.Substring(0, 2) == "//")
                {
                    continue;
                }

                var data = line.Split(',');
                if (data[0] == "room")
                {
                    AddNewRoom(int.Parse(data[1]));
                }
                else if (data[0] == "row")
                {
                    AddNewRow(int.Parse(data[1]), int.Parse(data[2]));
                }
                else if (data[0] == "bookshelf")
                {
                    AddNewBookshelf(int.Parse(data[1]), int.Parse(data[2]));
                }
                else if (data[0] == "book")
                {
                    var authors = new string[10];
                    Array.Copy(data, 6, authors, 0, data.Count() - 6);
                    Array.Resize<string>(ref authors, data.Count() - 6);
                    AddNewBook(data[2], data[3], data[4], int.Parse(data[5]), authors, int.Parse(data[1]));
                }
            }
        }
    }
}
