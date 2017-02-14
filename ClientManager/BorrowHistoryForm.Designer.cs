namespace ClientManager
{
    partial class BorrowHistoryForm
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
            this.dataGridViewBorrow = new System.Windows.Forms.DataGridView();
            this.btnOk = new System.Windows.Forms.Button();
            this.AutorFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.borrowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBorrow
            // 
            this.dataGridViewBorrow.AllowUserToAddRows = false;
            this.dataGridViewBorrow.AllowUserToDeleteRows = false;
            this.dataGridViewBorrow.AutoGenerateColumns = false;
            this.dataGridViewBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBorrow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.bookIdDataGridViewTextBoxColumn,
            this.bookDataGridViewTextBoxColumn,
            this.AutorFullName,
            this.borrowedDataGridViewTextBoxColumn,
            this.returnedDataGridViewTextBoxColumn});
            this.dataGridViewBorrow.DataSource = this.borrowBindingSource1;
            this.dataGridViewBorrow.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewBorrow.Name = "dataGridViewBorrow";
            this.dataGridViewBorrow.ReadOnly = true;
            this.dataGridViewBorrow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBorrow.Size = new System.Drawing.Size(672, 373);
            this.dataGridViewBorrow.TabIndex = 13;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(332, 391);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // AutorFullName
            // 
            this.AutorFullName.DataPropertyName = "AutorFullName";
            this.AutorFullName.HeaderText = "Autor";
            this.AutorFullName.Name = "AutorFullName";
            this.AutorFullName.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Borrow Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookIdDataGridViewTextBoxColumn
            // 
            this.bookIdDataGridViewTextBoxColumn.DataPropertyName = "BookId";
            this.bookIdDataGridViewTextBoxColumn.HeaderText = "BookId";
            this.bookIdDataGridViewTextBoxColumn.Name = "bookIdDataGridViewTextBoxColumn";
            this.bookIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookDataGridViewTextBoxColumn
            // 
            this.bookDataGridViewTextBoxColumn.DataPropertyName = "Book";
            this.bookDataGridViewTextBoxColumn.HeaderText = "Title";
            this.bookDataGridViewTextBoxColumn.Name = "bookDataGridViewTextBoxColumn";
            this.bookDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // borrowedDataGridViewTextBoxColumn
            // 
            this.borrowedDataGridViewTextBoxColumn.DataPropertyName = "Borrowed";
            this.borrowedDataGridViewTextBoxColumn.HeaderText = "Borrowed";
            this.borrowedDataGridViewTextBoxColumn.Name = "borrowedDataGridViewTextBoxColumn";
            this.borrowedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // returnedDataGridViewTextBoxColumn
            // 
            this.returnedDataGridViewTextBoxColumn.DataPropertyName = "Returned";
            this.returnedDataGridViewTextBoxColumn.HeaderText = "Returned";
            this.returnedDataGridViewTextBoxColumn.Name = "returnedDataGridViewTextBoxColumn";
            this.returnedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // borrowBindingSource1
            // 
            this.borrowBindingSource1.DataSource = typeof(LibraryManager.Borrow);
            // 
            // borrowBindingSource
            // 
            this.borrowBindingSource.DataSource = typeof(LibraryManager.Borrow);
            // 
            // BorrowHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 432);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dataGridViewBorrow);
            this.Name = "BorrowHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrow History";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.DataGridView dataGridViewBorrow;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.BindingSource borrowBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutorFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnedDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource borrowBindingSource1;
    }
}