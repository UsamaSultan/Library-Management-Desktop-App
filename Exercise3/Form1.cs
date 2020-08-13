using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Exercise3
{
    public partial class Form1 : Form
    {
        private string filename = Application.StartupPath + "\\library.txt";
        private string filenameInventory = Application.StartupPath + "\\inventoryList.txt";
        Library library;

        public Form1() => InitializeComponent();

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbISBN.Text))
            {
                library.AddNewBook(tbISBN.Text, tbTitle.Text, tbPublisher.Text, (int)nudPublicationYear.Value, tbAuthor.Text.Split(','), (int)nudBookshelfID.Value);
                File.AppendAllText(filename, Environment.NewLine + "book," + (int)nudBookshelfID.Value + "," + tbISBN.Text + "," + tbTitle.Text + ","
                    + tbPublisher.Text + "," + (int)nudPublicationYear.Value + "," + tbAuthor.Text);
                MessageBox.Show("New Book Added and saved to file", "New Book Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { MessageBox.Show("Please fill in details first", "No Book Added", MessageBoxButtons.OK, MessageBoxIcon.Error); }


        }

        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();

        private void Form1_Load(object sender, EventArgs e)
        {
            library = new Library(1);
            LoadCurrentInventory(filename);
        }

        public void LoadCurrentInventory(string filePath) => library.LoadInventory(filePath);

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Book theBook = null;
            Room theRoom = null;
            Row theRow = null;
            Bookshelf theBookshelf = null;
            foreach (var room in library.rooms)
            {
                foreach (var row in room.rows)
                {
                    foreach (var bookshelf in row.bookshelves)
                    {
                        foreach (var book in bookshelf.books)
                        {
                            if (book.ISBN == tbISBNSearch.Text)
                            {
                                theBook = book;
                                theRoom = room;
                                theRow = row;
                                theBookshelf = bookshelf;
                                break;
                            }
                        }
                    }

                }
            }
            if (theBook != null)
            {
                lblISBNs.Text = theBook.ISBN;
                lblTitleS.Text = theBook.Title;
                lblPublisherS.Text = theBook.Publisher;
                lblPulicationYearS.Text = theBook.PublicationYear.ToString();
                lblAuthorS.Text = "";
                foreach (string author in theBook.Author)
                {
                    lblAuthorS.Text += author + Environment.NewLine;
                }
                lblRoomIDs.Text = theRoom.ID.ToString();
                lblRowIDs.Text = theRow.ID.ToString();
                lblBookshelfIDs.Text = theBookshelf.ID.ToString();
                lblBookNotFound.Visible = false;
            }
            else
            {
                lblISBNs.Text = "";
                lblTitleS.Text = "";
                lblPublisherS.Text = "";
                lblPulicationYearS.Text = "";
                lblRoomIDs.Text = "";
                lblRowIDs.Text = "";
                lblBookshelfIDs.Text = "";
                lblAuthorS.Text = "";
                lblBookNotFound.Visible = true;
            }
        }

        private void btnGenerateList_Click(object sender, EventArgs e)
        {
            lblDataNotFound.Visible = false;
            var books = new List<Book>();
            bool found = false;
            if (cbInventoryList.SelectedItem.ToString() == "By Room")
            {
                Room theRoom = null;
                foreach (var room in library.rooms)
                {
                    if (room.ID == (int)nudInventoryList.Value)
                    {
                        theRoom = room;
                        found = true;
                    }
                }
                if (!found)
                {
                    lblDataNotFound.Visible = true;
                    return;
                }
                foreach (var row in theRoom.rows)
                {
                    foreach (var bookshelf in row.bookshelves)
                    {
                        books.AddRange(bookshelf.books);
                    }
                }
            }
            else if (cbInventoryList.SelectedItem.ToString() == "By Row")
            {
                Row theRow = null;

                foreach (var room in library.rooms)
                {
                    foreach (var row in room.rows)
                    {
                        if (row.ID == (int)nudInventoryList.Value)
                        {
                            theRow = row;
                            found = true;
                            break;
                        }
                    }
                }

                if (!found)
                {
                    lblDataNotFound.Visible = true;
                    return;
                }
                foreach (var bookshelf in theRow.bookshelves)
                {
                    books.AddRange(bookshelf.books);
                }
            }
            else if (cbInventoryList.SelectedItem.ToString() == "By Bookshelf")
            {
                Bookshelf theBookshelf = null;

                foreach (var room in library.rooms)
                {
                    foreach (var row in room.rows)
                    {
                        foreach (var bookshelf in row.bookshelves)
                        {
                            if (bookshelf.ID == (int)nudInventoryList.Value)
                            {
                                theBookshelf = bookshelf;
                                found = true;
                                break;
                            }
                        }
                    }
                }

                if (!found)
                {
                    lblDataNotFound.Visible = true;
                    return;
                }

                books = theBookshelf.books;
            }
            //write to file
            using (var sw = new StreamWriter(filenameInventory))
            {
                sw.WriteLine($"List of all Books sorted {cbInventoryList.SelectedItem} {(int)nudInventoryList.Value} ");
                foreach (var book in books)
                {
                    sw.WriteLine(book.ISBN + "," + book.Title);
                }
            }

            MessageBox.Show("Inventory list saved", "Inventory list saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
