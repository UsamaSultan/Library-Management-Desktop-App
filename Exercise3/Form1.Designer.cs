namespace Exercise3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddNewBook = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbPublisher = new System.Windows.Forms.TextBox();
            this.nudPublicationYear = new System.Windows.Forms.NumericUpDown();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudBookshelfID = new System.Windows.Forms.NumericUpDown();
            this.tbISBNSearch = new System.Windows.Forms.TextBox();
            this.lblBookNotFound = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblISBNs = new System.Windows.Forms.Label();
            this.lblTitleS = new System.Windows.Forms.Label();
            this.lblPublisherS = new System.Windows.Forms.Label();
            this.lblPulicationYearS = new System.Windows.Forms.Label();
            this.lblAuthorS = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblRoomIDs = new System.Windows.Forms.Label();
            this.lblRowIDs = new System.Windows.Forms.Label();
            this.lblBookshelfIDs = new System.Windows.Forms.Label();
            this.btnGenerateList = new System.Windows.Forms.Button();
            this.cbInventoryList = new System.Windows.Forms.ComboBox();
            this.nudInventoryList = new System.Windows.Forms.NumericUpDown();
            this.lblDataNotFound = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPublicationYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBookshelfID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInventoryList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.Location = new System.Drawing.Point(399, 146);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.Size = new System.Drawing.Size(137, 23);
            this.btnAddNewBook.TabIndex = 0;
            this.btnAddNewBook.Text = "Add New Book";
            this.btnAddNewBook.UseVisualStyleBackColor = true;
            this.btnAddNewBook.Click += new System.EventHandler(this.btnAddNewBook_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(520, 344);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(22, 56);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(137, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search Books by ISBN";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(594, 337);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.nudBookshelfID);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.tbAuthor);
            this.tabPage1.Controls.Add(this.nudPublicationYear);
            this.tabPage1.Controls.Add(this.tbPublisher);
            this.tabPage1.Controls.Add(this.tbTitle);
            this.tabPage1.Controls.Add(this.tbISBN);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnAddNewBook);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(586, 311);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add New Book";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblBookshelfIDs);
            this.tabPage2.Controls.Add(this.lblRowIDs);
            this.tabPage2.Controls.Add(this.lblRoomIDs);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.lblAuthorS);
            this.tabPage2.Controls.Add(this.lblPulicationYearS);
            this.tabPage2.Controls.Add(this.lblPublisherS);
            this.tabPage2.Controls.Add(this.lblTitleS);
            this.tabPage2.Controls.Add(this.lblISBNs);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.lblBookNotFound);
            this.tabPage2.Controls.Add(this.tbISBNSearch);
            this.tabPage2.Controls.Add(this.btnSearch);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(586, 311);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search Books by ISBN";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblDataNotFound);
            this.tabPage3.Controls.Add(this.nudInventoryList);
            this.tabPage3.Controls.Add(this.cbInventoryList);
            this.tabPage3.Controls.Add(this.btnGenerateList);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(586, 311);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Generate Inventory List";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ISBN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Publisher:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Publication Year:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Author:";
            // 
            // tbISBN
            // 
            this.tbISBN.Location = new System.Drawing.Point(131, 26);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(181, 20);
            this.tbISBN.TabIndex = 6;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(131, 61);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(181, 20);
            this.tbTitle.TabIndex = 7;
            // 
            // tbPublisher
            // 
            this.tbPublisher.Location = new System.Drawing.Point(131, 96);
            this.tbPublisher.Name = "tbPublisher";
            this.tbPublisher.Size = new System.Drawing.Size(181, 20);
            this.tbPublisher.TabIndex = 8;
            // 
            // nudPublicationYear
            // 
            this.nudPublicationYear.Location = new System.Drawing.Point(131, 132);
            this.nudPublicationYear.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.nudPublicationYear.Name = "nudPublicationYear";
            this.nudPublicationYear.Size = new System.Drawing.Size(180, 20);
            this.nudPublicationYear.TabIndex = 9;
            this.nudPublicationYear.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(131, 166);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(181, 20);
            this.tbAuthor.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Separate by comma if many ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Bookshelf:";
            // 
            // nudBookshelfID
            // 
            this.nudBookshelfID.Location = new System.Drawing.Point(131, 227);
            this.nudBookshelfID.Name = "nudBookshelfID";
            this.nudBookshelfID.Size = new System.Drawing.Size(180, 20);
            this.nudBookshelfID.TabIndex = 13;
            this.nudBookshelfID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbISBNSearch
            // 
            this.tbISBNSearch.Location = new System.Drawing.Point(22, 18);
            this.tbISBNSearch.Name = "tbISBNSearch";
            this.tbISBNSearch.Size = new System.Drawing.Size(137, 20);
            this.tbISBNSearch.TabIndex = 3;
            // 
            // lblBookNotFound
            // 
            this.lblBookNotFound.AutoSize = true;
            this.lblBookNotFound.ForeColor = System.Drawing.Color.Red;
            this.lblBookNotFound.Location = new System.Drawing.Point(248, 14);
            this.lblBookNotFound.Name = "lblBookNotFound";
            this.lblBookNotFound.Size = new System.Drawing.Size(83, 13);
            this.lblBookNotFound.TabIndex = 4;
            this.lblBookNotFound.Text = "Book not found!";
            this.lblBookNotFound.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(296, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "ISBN:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(301, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Title:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(278, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Publisher:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(244, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Publication Year:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(290, 251);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Author:";
            // 
            // lblISBNs
            // 
            this.lblISBNs.AutoSize = true;
            this.lblISBNs.Location = new System.Drawing.Point(346, 50);
            this.lblISBNs.Name = "lblISBNs";
            this.lblISBNs.Size = new System.Drawing.Size(0, 13);
            this.lblISBNs.TabIndex = 10;
            // 
            // lblTitleS
            // 
            this.lblTitleS.AutoSize = true;
            this.lblTitleS.Location = new System.Drawing.Point(346, 79);
            this.lblTitleS.Name = "lblTitleS";
            this.lblTitleS.Size = new System.Drawing.Size(0, 13);
            this.lblTitleS.TabIndex = 11;
            // 
            // lblPublisherS
            // 
            this.lblPublisherS.AutoSize = true;
            this.lblPublisherS.Location = new System.Drawing.Point(346, 108);
            this.lblPublisherS.Name = "lblPublisherS";
            this.lblPublisherS.Size = new System.Drawing.Size(0, 13);
            this.lblPublisherS.TabIndex = 12;
            // 
            // lblPulicationYearS
            // 
            this.lblPulicationYearS.AutoSize = true;
            this.lblPulicationYearS.Location = new System.Drawing.Point(346, 137);
            this.lblPulicationYearS.Name = "lblPulicationYearS";
            this.lblPulicationYearS.Size = new System.Drawing.Size(0, 13);
            this.lblPulicationYearS.TabIndex = 13;
            // 
            // lblAuthorS
            // 
            this.lblAuthorS.AutoSize = true;
            this.lblAuthorS.Location = new System.Drawing.Point(346, 251);
            this.lblAuthorS.Name = "lblAuthorS";
            this.lblAuthorS.Size = new System.Drawing.Size(0, 13);
            this.lblAuthorS.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(293, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Room:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(299, 194);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Row:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(274, 223);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Bookshelf:";
            // 
            // lblRoomIDs
            // 
            this.lblRoomIDs.AutoSize = true;
            this.lblRoomIDs.Location = new System.Drawing.Point(344, 165);
            this.lblRoomIDs.Name = "lblRoomIDs";
            this.lblRoomIDs.Size = new System.Drawing.Size(0, 13);
            this.lblRoomIDs.TabIndex = 18;
            // 
            // lblRowIDs
            // 
            this.lblRowIDs.AutoSize = true;
            this.lblRowIDs.Location = new System.Drawing.Point(344, 194);
            this.lblRowIDs.Name = "lblRowIDs";
            this.lblRowIDs.Size = new System.Drawing.Size(0, 13);
            this.lblRowIDs.TabIndex = 19;
            // 
            // lblBookshelfIDs
            // 
            this.lblBookshelfIDs.AutoSize = true;
            this.lblBookshelfIDs.Location = new System.Drawing.Point(344, 223);
            this.lblBookshelfIDs.Name = "lblBookshelfIDs";
            this.lblBookshelfIDs.Size = new System.Drawing.Size(0, 13);
            this.lblBookshelfIDs.TabIndex = 20;
            // 
            // btnGenerateList
            // 
            this.btnGenerateList.Location = new System.Drawing.Point(176, 128);
            this.btnGenerateList.Name = "btnGenerateList";
            this.btnGenerateList.Size = new System.Drawing.Size(129, 23);
            this.btnGenerateList.TabIndex = 0;
            this.btnGenerateList.Text = "Generate Inventory List";
            this.btnGenerateList.UseVisualStyleBackColor = true;
            this.btnGenerateList.Click += new System.EventHandler(this.btnGenerateList_Click);
            // 
            // cbInventoryList
            // 
            this.cbInventoryList.FormattingEnabled = true;
            this.cbInventoryList.Items.AddRange(new object[] {
            "By Room",
            "By Row",
            "By Bookshelf"});
            this.cbInventoryList.Location = new System.Drawing.Point(19, 59);
            this.cbInventoryList.Name = "cbInventoryList";
            this.cbInventoryList.Size = new System.Drawing.Size(129, 21);
            this.cbInventoryList.TabIndex = 1;
            // 
            // nudInventoryList
            // 
            this.nudInventoryList.Location = new System.Drawing.Point(176, 59);
            this.nudInventoryList.Name = "nudInventoryList";
            this.nudInventoryList.Size = new System.Drawing.Size(129, 20);
            this.nudInventoryList.TabIndex = 2;
            this.nudInventoryList.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDataNotFound
            // 
            this.lblDataNotFound.AutoSize = true;
            this.lblDataNotFound.ForeColor = System.Drawing.Color.Red;
            this.lblDataNotFound.Location = new System.Drawing.Point(377, 65);
            this.lblDataNotFound.Name = "lblDataNotFound";
            this.lblDataNotFound.Size = new System.Drawing.Size(84, 13);
            this.lblDataNotFound.TabIndex = 3;
            this.lblDataNotFound.Text = "Data not Found!";
            this.lblDataNotFound.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 372);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Library System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPublicationYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBookshelfID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInventoryList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewBook;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.NumericUpDown nudPublicationYear;
        private System.Windows.Forms.TextBox tbPublisher;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbISBN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudBookshelfID;
        private System.Windows.Forms.TextBox tbISBNSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblBookNotFound;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblAuthorS;
        private System.Windows.Forms.Label lblPulicationYearS;
        private System.Windows.Forms.Label lblPublisherS;
        private System.Windows.Forms.Label lblTitleS;
        private System.Windows.Forms.Label lblISBNs;
        private System.Windows.Forms.Label lblBookshelfIDs;
        private System.Windows.Forms.Label lblRowIDs;
        private System.Windows.Forms.Label lblRoomIDs;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnGenerateList;
        private System.Windows.Forms.ComboBox cbInventoryList;
        private System.Windows.Forms.NumericUpDown nudInventoryList;
        private System.Windows.Forms.Label lblDataNotFound;
    }
}

