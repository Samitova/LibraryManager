namespace ClientManager
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageAllBooks = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBookBorrow = new System.Windows.Forms.Button();
            this.btnBookSearch = new System.Windows.Forms.Button();
            this.btnAllBooks = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.dataGridViewAllBooks = new System.Windows.Forms.DataGridView();
            this.tabPageClientBooks = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dataGridViewClientBooks = new System.Windows.Forms.DataGridView();
            this.bindingSourceBookSearch = new System.Windows.Forms.BindingSource(this.components);
            this.btnHistory = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishingDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControlMain.SuspendLayout();
            this.tabPageAllBooks.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllBooks)).BeginInit();
            this.tabPageClientBooks.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBookSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookAllBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookClientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageAllBooks);
            this.tabControlMain.Controls.Add(this.tabPageClientBooks);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(739, 432);
            this.tabControlMain.TabIndex = 8;
            // 
            // tabPageAllBooks
            // 
            this.tabPageAllBooks.Controls.Add(this.groupBox2);
            this.tabPageAllBooks.Controls.Add(this.groupBox1);
            this.tabPageAllBooks.Controls.Add(this.dataGridViewAllBooks);
            this.tabPageAllBooks.Location = new System.Drawing.Point(4, 22);
            this.tabPageAllBooks.Name = "tabPageAllBooks";
            this.tabPageAllBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAllBooks.Size = new System.Drawing.Size(731, 406);
            this.tabPageAllBooks.TabIndex = 0;
            this.tabPageAllBooks.Text = "All books";
            this.tabPageAllBooks.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBookBorrow);
            this.groupBox2.Controls.Add(this.btnBookSearch);
            this.groupBox2.Controls.Add(this.btnAllBooks);
            this.groupBox2.Location = new System.Drawing.Point(597, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 160);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // btnBookBorrow
            // 
            this.btnBookBorrow.Enabled = false;
            this.btnBookBorrow.Location = new System.Drawing.Point(22, 68);
            this.btnBookBorrow.Name = "btnBookBorrow";
            this.btnBookBorrow.Size = new System.Drawing.Size(75, 23);
            this.btnBookBorrow.TabIndex = 7;
            this.btnBookBorrow.Text = "Borrow";
            this.btnBookBorrow.UseVisualStyleBackColor = true;
            this.btnBookBorrow.Click += new System.EventHandler(this.btnBookBorrow_Click);
            // 
            // btnBookSearch
            // 
            this.btnBookSearch.Enabled = false;
            this.btnBookSearch.Location = new System.Drawing.Point(22, 109);
            this.btnBookSearch.Name = "btnBookSearch";
            this.btnBookSearch.Size = new System.Drawing.Size(75, 23);
            this.btnBookSearch.TabIndex = 10;
            this.btnBookSearch.Text = "Search";
            this.btnBookSearch.UseVisualStyleBackColor = true;
            this.btnBookSearch.Click += new System.EventHandler(this.btnBookSearch_Click);
            // 
            // btnAllBooks
            // 
            this.btnAllBooks.Enabled = false;
            this.btnAllBooks.Location = new System.Drawing.Point(22, 28);
            this.btnAllBooks.Name = "btnAllBooks";
            this.btnAllBooks.Size = new System.Drawing.Size(75, 23);
            this.btnAllBooks.TabIndex = 11;
            this.btnAllBooks.Text = "All Books";
            this.btnAllBooks.UseVisualStyleBackColor = true;
            this.btnAllBooks.Click += new System.EventHandler(this.btnAllBooks_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.btnRegister);
            this.groupBox1.Location = new System.Drawing.Point(597, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(24, 19);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(24, 58);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 13;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // dataGridViewAllBooks
            // 
            this.dataGridViewAllBooks.AllowUserToAddRows = false;
            this.dataGridViewAllBooks.AllowUserToDeleteRows = false;
            this.dataGridViewAllBooks.AutoGenerateColumns = false;
            this.dataGridViewAllBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.publishingDateDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn});
            this.dataGridViewAllBooks.DataSource = this.bookAllBindingSource;
            this.dataGridViewAllBooks.Location = new System.Drawing.Point(10, 11);
            this.dataGridViewAllBooks.Name = "dataGridViewAllBooks";
            this.dataGridViewAllBooks.ReadOnly = true;
            this.dataGridViewAllBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAllBooks.Size = new System.Drawing.Size(570, 357);
            this.dataGridViewAllBooks.TabIndex = 6;
            // 
            // tabPageClientBooks
            // 
            this.tabPageClientBooks.Controls.Add(this.groupBox3);
            this.tabPageClientBooks.Controls.Add(this.dataGridViewClientBooks);
            this.tabPageClientBooks.Location = new System.Drawing.Point(4, 22);
            this.tabPageClientBooks.Name = "tabPageClientBooks";
            this.tabPageClientBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClientBooks.Size = new System.Drawing.Size(731, 406);
            this.tabPageClientBooks.TabIndex = 1;
            this.tabPageClientBooks.Text = "My books";
            this.tabPageClientBooks.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnHistory);
            this.groupBox3.Controls.Add(this.btnReturn);
            this.groupBox3.Location = new System.Drawing.Point(601, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(110, 106);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // btnReturn
            // 
            this.btnReturn.Enabled = false;
            this.btnReturn.Location = new System.Drawing.Point(18, 19);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 13;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dataGridViewClientBooks
            // 
            this.dataGridViewClientBooks.AllowUserToAddRows = false;
            this.dataGridViewClientBooks.AllowUserToDeleteRows = false;
            this.dataGridViewClientBooks.AutoGenerateColumns = false;
            this.dataGridViewClientBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.titleDataGridViewTextBoxColumn1,
            this.genreDataGridViewTextBoxColumn1,
            this.publishingDateDataGridViewTextBoxColumn1,
            this.authorDataGridViewTextBoxColumn1});
            this.dataGridViewClientBooks.DataSource = this.bookClientBindingSource;
            this.dataGridViewClientBooks.Location = new System.Drawing.Point(10, 11);
            this.dataGridViewClientBooks.Name = "dataGridViewClientBooks";
            this.dataGridViewClientBooks.ReadOnly = true;
            this.dataGridViewClientBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClientBooks.Size = new System.Drawing.Size(570, 357);
            this.dataGridViewClientBooks.TabIndex = 12;
            // 
            // btnHistory
            // 
            this.btnHistory.Enabled = false;
            this.btnHistory.Location = new System.Drawing.Point(18, 64);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(75, 23);
            this.btnHistory.TabIndex = 14;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // publishingDateDataGridViewTextBoxColumn
            // 
            this.publishingDateDataGridViewTextBoxColumn.DataPropertyName = "PublishingDate";
            this.publishingDateDataGridViewTextBoxColumn.HeaderText = "PublishingDate";
            this.publishingDateDataGridViewTextBoxColumn.Name = "publishingDateDataGridViewTextBoxColumn";
            this.publishingDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookAllBindingSource
            // 
            this.bookAllBindingSource.DataSource = typeof(LibraryManager.Book);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn1
            // 
            this.titleDataGridViewTextBoxColumn1.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn1.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn1.Name = "titleDataGridViewTextBoxColumn1";
            this.titleDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // genreDataGridViewTextBoxColumn1
            // 
            this.genreDataGridViewTextBoxColumn1.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn1.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn1.Name = "genreDataGridViewTextBoxColumn1";
            this.genreDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // publishingDateDataGridViewTextBoxColumn1
            // 
            this.publishingDateDataGridViewTextBoxColumn1.DataPropertyName = "PublishingDate";
            this.publishingDateDataGridViewTextBoxColumn1.HeaderText = "PublishingDate";
            this.publishingDateDataGridViewTextBoxColumn1.Name = "publishingDateDataGridViewTextBoxColumn1";
            this.publishingDateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // authorDataGridViewTextBoxColumn1
            // 
            this.authorDataGridViewTextBoxColumn1.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn1.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn1.Name = "authorDataGridViewTextBoxColumn1";
            this.authorDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bookClientBindingSource
            // 
            this.bookClientBindingSource.DataSource = typeof(LibraryManager.Book);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 457);
            this.Controls.Add(this.tabControlMain);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Manager";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageAllBooks.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllBooks)).EndInit();
            this.tabPageClientBooks.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBookSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookAllBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookClientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageAllBooks;
        protected internal System.Windows.Forms.DataGridView dataGridViewAllBooks;
        private System.Windows.Forms.TabPage tabPageClientBooks;
        protected internal System.Windows.Forms.DataGridView dataGridViewClientBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bookAllBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishingDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource bookClientBindingSource;
        protected internal System.Windows.Forms.Button btnAllBooks;
        protected internal System.Windows.Forms.Button btnBookSearch;
        protected internal System.Windows.Forms.Button btnBookBorrow;
        protected internal System.Windows.Forms.Button btnLogin;
        protected internal System.Windows.Forms.Button btnRegister;
        protected internal System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource bindingSourceBookSearch;
        protected internal System.Windows.Forms.Button btnHistory;
    }
}

