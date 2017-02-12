namespace LibraryManager
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBooks = new System.Windows.Forms.TabPage();
            this.tabPageAuthors = new System.Windows.Forms.TabPage();
            this.btnBookSearch = new System.Windows.Forms.Button();
            this.btnBookDelete = new System.Windows.Forms.Button();
            this.btnBookChange = new System.Windows.Forms.Button();
            this.btnBookAdd = new System.Windows.Forms.Button();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.btnAuthorSearch = new System.Windows.Forms.Button();
            this.btnAuthorDelete = new System.Windows.Forms.Button();
            this.btnAuthorChange = new System.Windows.Forms.Button();
            this.btnAuthorAdd = new System.Windows.Forms.Button();
            this.dataGridViewAuthors = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPageBooks.SuspendLayout();
            this.tabPageAuthors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageBooks);
            this.tabControl1.Controls.Add(this.tabPageAuthors);
            this.tabControl1.Location = new System.Drawing.Point(45, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(700, 432);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPageBooks
            // 
            this.tabPageBooks.Controls.Add(this.btnBookSearch);
            this.tabPageBooks.Controls.Add(this.btnBookDelete);
            this.tabPageBooks.Controls.Add(this.btnBookChange);
            this.tabPageBooks.Controls.Add(this.btnBookAdd);
            this.tabPageBooks.Controls.Add(this.dataGridViewBooks);
            this.tabPageBooks.Location = new System.Drawing.Point(4, 22);
            this.tabPageBooks.Name = "tabPageBooks";
            this.tabPageBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBooks.Size = new System.Drawing.Size(692, 406);
            this.tabPageBooks.TabIndex = 0;
            this.tabPageBooks.Text = "Books";
            this.tabPageBooks.UseVisualStyleBackColor = true;
            // 
            // tabPageAuthors
            // 
            this.tabPageAuthors.Controls.Add(this.btnAuthorSearch);
            this.tabPageAuthors.Controls.Add(this.btnAuthorDelete);
            this.tabPageAuthors.Controls.Add(this.btnAuthorChange);
            this.tabPageAuthors.Controls.Add(this.btnAuthorAdd);
            this.tabPageAuthors.Controls.Add(this.dataGridViewAuthors);
            this.tabPageAuthors.Location = new System.Drawing.Point(4, 22);
            this.tabPageAuthors.Name = "tabPageAuthors";
            this.tabPageAuthors.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAuthors.Size = new System.Drawing.Size(622, 406);
            this.tabPageAuthors.TabIndex = 1;
            this.tabPageAuthors.Text = "Authors";
            this.tabPageAuthors.UseVisualStyleBackColor = true;
            // 
            // btnBookSearch
            // 
            this.btnBookSearch.Location = new System.Drawing.Point(587, 144);
            this.btnBookSearch.Name = "btnBookSearch";
            this.btnBookSearch.Size = new System.Drawing.Size(75, 23);
            this.btnBookSearch.TabIndex = 10;
            this.btnBookSearch.Text = "Search";
            this.btnBookSearch.UseVisualStyleBackColor = true;
            // 
            // btnBookDelete
            // 
            this.btnBookDelete.Location = new System.Drawing.Point(587, 100);
            this.btnBookDelete.Name = "btnBookDelete";
            this.btnBookDelete.Size = new System.Drawing.Size(75, 23);
            this.btnBookDelete.TabIndex = 9;
            this.btnBookDelete.Text = "Delete";
            this.btnBookDelete.UseVisualStyleBackColor = true;
            this.btnBookDelete.Click += new System.EventHandler(this.btnBookDelete_Click);
            // 
            // btnBookChange
            // 
            this.btnBookChange.Location = new System.Drawing.Point(587, 57);
            this.btnBookChange.Name = "btnBookChange";
            this.btnBookChange.Size = new System.Drawing.Size(75, 23);
            this.btnBookChange.TabIndex = 8;
            this.btnBookChange.Text = "Change";
            this.btnBookChange.UseVisualStyleBackColor = true;
            this.btnBookChange.Click += new System.EventHandler(this.btnBookChange_Click);
            // 
            // btnBookAdd
            // 
            this.btnBookAdd.Location = new System.Drawing.Point(587, 15);
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.Size = new System.Drawing.Size(75, 23);
            this.btnBookAdd.TabIndex = 7;
            this.btnBookAdd.Text = "Add ";
            this.btnBookAdd.UseVisualStyleBackColor = true;
            this.btnBookAdd.Click += new System.EventHandler(this.btnBookAdd_Click);
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AllowUserToAddRows = false;
            this.dataGridViewBooks.AllowUserToDeleteRows = false;
            this.dataGridViewBooks.AutoGenerateColumns = false;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.Genre,
            this.publishingDateDataGridViewTextBoxColumn});
            this.dataGridViewBooks.DataSource = this.bookBindingSource;
            this.dataGridViewBooks.Location = new System.Drawing.Point(10, 11);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBooks.Size = new System.Drawing.Size(546, 357);
            this.dataGridViewBooks.TabIndex = 6;
            // 
            // btnAuthorSearch
            // 
            this.btnAuthorSearch.Location = new System.Drawing.Point(500, 139);
            this.btnAuthorSearch.Name = "btnAuthorSearch";
            this.btnAuthorSearch.Size = new System.Drawing.Size(75, 23);
            this.btnAuthorSearch.TabIndex = 15;
            this.btnAuthorSearch.Text = "Search";
            this.btnAuthorSearch.UseVisualStyleBackColor = true;
            // 
            // btnAuthorDelete
            // 
            this.btnAuthorDelete.Location = new System.Drawing.Point(500, 95);
            this.btnAuthorDelete.Name = "btnAuthorDelete";
            this.btnAuthorDelete.Size = new System.Drawing.Size(75, 23);
            this.btnAuthorDelete.TabIndex = 14;
            this.btnAuthorDelete.Text = "Delete";
            this.btnAuthorDelete.UseVisualStyleBackColor = true;
            this.btnAuthorDelete.Click += new System.EventHandler(this.btnAuthorDelete_Click);
            // 
            // btnAuthorChange
            // 
            this.btnAuthorChange.Location = new System.Drawing.Point(500, 52);
            this.btnAuthorChange.Name = "btnAuthorChange";
            this.btnAuthorChange.Size = new System.Drawing.Size(75, 23);
            this.btnAuthorChange.TabIndex = 13;
            this.btnAuthorChange.Text = "Change";
            this.btnAuthorChange.UseVisualStyleBackColor = true;
            this.btnAuthorChange.Click += new System.EventHandler(this.btnAuthorChange_Click);
            // 
            // btnAuthorAdd
            // 
            this.btnAuthorAdd.Location = new System.Drawing.Point(500, 10);
            this.btnAuthorAdd.Name = "btnAuthorAdd";
            this.btnAuthorAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAuthorAdd.TabIndex = 12;
            this.btnAuthorAdd.Text = "Add ";
            this.btnAuthorAdd.UseVisualStyleBackColor = true;
            this.btnAuthorAdd.Click += new System.EventHandler(this.btnAuthorAdd_Click);
            // 
            // dataGridViewAuthors
            // 
            this.dataGridViewAuthors.AllowUserToAddRows = false;
            this.dataGridViewAuthors.AllowUserToDeleteRows = false;
            this.dataGridViewAuthors.AutoGenerateColumns = false;
            this.dataGridViewAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAuthors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.FirstName,
            this.SecondName,
            this.BirthDate});
            this.dataGridViewAuthors.DataSource = this.authorBindingSource;
            this.dataGridViewAuthors.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewAuthors.Name = "dataGridViewAuthors";
            this.dataGridViewAuthors.RowHeadersWidth = 20;
            this.dataGridViewAuthors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAuthors.Size = new System.Drawing.Size(445, 357);
            this.dataGridViewAuthors.TabIndex = 11;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            // 
            // SecondName
            // 
            this.SecondName.DataPropertyName = "SecondName";
            this.SecondName.HeaderText = "SecondName";
            this.SecondName.Name = "SecondName";
            // 
            // BirthDate
            // 
            this.BirthDate.DataPropertyName = "BirthDate";
            this.BirthDate.HeaderText = "BirthDate";
            this.BirthDate.Name = "BirthDate";
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(LibraryManager.Book);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // authorBindingSource
            // 
            this.authorBindingSource.DataSource = typeof(LibraryManager.Author);
            // 
            // bookBindingSource1
            // 
            this.bookBindingSource1.DataSource = typeof(LibraryManager.Book);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            // 
            // Genre
            // 
            this.Genre.DataPropertyName = "Genre";
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            // 
            // publishingDateDataGridViewTextBoxColumn
            // 
            this.publishingDateDataGridViewTextBoxColumn.DataPropertyName = "PublishingDate";
            this.publishingDateDataGridViewTextBoxColumn.HeaderText = "PublishingDate";
            this.publishingDateDataGridViewTextBoxColumn.Name = "publishingDateDataGridViewTextBoxColumn";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 483);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Library manager";
            this.tabControl1.ResumeLayout(false);
            this.tabPageBooks.ResumeLayout(false);
            this.tabPageAuthors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bookBindingSource1;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageBooks;
        private System.Windows.Forms.Button btnBookSearch;
        private System.Windows.Forms.Button btnBookDelete;
        private System.Windows.Forms.Button btnBookChange;
        private System.Windows.Forms.Button btnBookAdd;
        protected internal System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.TabPage tabPageAuthors;
        private System.Windows.Forms.Button btnAuthorSearch;
        private System.Windows.Forms.Button btnAuthorDelete;
        private System.Windows.Forms.Button btnAuthorChange;
        private System.Windows.Forms.Button btnAuthorAdd;
        protected internal System.Windows.Forms.DataGridView dataGridViewAuthors;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.BindingSource authorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishingDateDataGridViewTextBoxColumn;
    }
}

