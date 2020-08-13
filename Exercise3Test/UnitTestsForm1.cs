using Exercise3;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;

namespace Exercise3Test
{
    [TestClass]
    public class UnitTestsForm1
    {
        [TestMethod]
        public void TestAddNewRoom()
        {
            var library = new Library();
            library.AddNewRoom(1);

            var expectedRoomCount = 1;
            var actualRoomCount = library.rooms.Count;

            expectedRoomCount.Should().Equals(actualRoomCount);
        }

        [TestMethod]
        public void TestAddNewRow()
        {
            var library = new Library();
            library.AddNewRoom(1);
            library.AddNewRow(1, 1);
            library.AddNewRow(2, 1);

            var expectedRowCount = 2;
            var actualRowCount = library.rooms[0].rows.Count;

            expectedRowCount.Should().Equals(actualRowCount);
        }

        [TestMethod]
        public void TestAddNewBookshelf()
        {
            var library = new Library();
            library.AddNewRoom(1);
            library.AddNewRow(1, 1);
            library.AddNewBookshelf(1, 1);
            library.AddNewBookshelf(2, 1);
            library.AddNewBookshelf(3, 1);

            var expectedBookshelfCount = 3;
            var actualBookshelfCount = library.rooms[0].rows[0].bookshelves.Count;

            expectedBookshelfCount.Should().Equals(actualBookshelfCount);
        }

        [TestMethod]
        public void TestAddNewBook()
        {
            var library = new Library();
            library.AddNewRoom(1);
            library.AddNewRow(1, 1);
            library.AddNewBookshelf(1, 1);
            string[] authors = { "Peter Smith" };
            library.AddNewBook("0123456789", "My Title Book", "ABC group", 2020, authors, 1);
            library.AddNewBook("9876543210", "My Title Book2", "ABC group2", 2019, authors, 1);

            var expectedBookCount = 2;
            var actualBookCount = library.rooms[0].rows[0].bookshelves[0].books.Count;

            expectedBookCount.Should().Equals(actualBookCount);
        }

        [TestMethod]
        public void TestRoomConstructor()
        {
            var room = new Room(1);

            var expectedID = 1;
            var actualID = room.ID;

            expectedID.Should().Equals(actualID);
        }

        [TestMethod]
        public void TestRowConstructor()
        {
            var row = new Row(1);

            var expectedBookshelvesCount = 0;
            var actualBookshelvesCount = row.bookshelves.Count;

            expectedBookshelvesCount.Should().Equals(actualBookshelvesCount);
        }

        [TestMethod]
        public void TestBookshelfConstructor()
        {
            var bookshelf = new Bookshelf(1);

            var expectedID = 1;
            var actualID = bookshelf.ID;

            expectedID.Should().Equals(actualID);
        }

        [TestMethod]
        public void TestBookConstructor()
        {
            string[] a = { "Peter Smith", "Jannet Jackson" };
            var authors = new List<string>(a);
            var book = new Book("0123456789", "My Title Book", "ABC group", 2020, authors);

            var expectedISBN = "0123456789";
            var actualISBN = book.ISBN;
            
            Assert.AreEqual(expectedISBN, actualISBN);
            Assert.AreEqual("My Title Book", book.Title);
            Assert.AreEqual("ABC group", book.Publisher);
            Assert.AreEqual(2020, book.PublicationYear);
            Assert.AreEqual("Jannet Jackson", book.Author[1]);
        }

        [TestMethod]
        public void TestLoadCurrentInventory()
        {
            var library = new Library();
            var current = Directory.GetCurrentDirectory().ToString();
            var path = Directory.GetParent(current).Parent.FullName;
            path = Directory.GetParent(path).FullName;
            library.LoadInventory(path + "\\Exercise3\\bin\\Debug\\library.txt");

            var expectedISBN = "0451464419";
            var actualISBN = library.rooms[0].rows[0].bookshelves[0].books[0].ISBN;

            expectedISBN.Should().Equals(actualISBN);
        }
    }
}
