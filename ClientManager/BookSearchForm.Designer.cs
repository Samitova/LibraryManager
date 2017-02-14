namespace ClientManager
{
    partial class BookSearchForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkedListBoxSearchGenre = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbGenre = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.textBoxSearchAuthor = new System.Windows.Forms.TextBox();
            this.textBoxSearchTitle = new System.Windows.Forms.TextBox();
            this.textBoxSearchPublishing = new System.Windows.Forms.TextBox();
            this.btnBookSearchCancel = new System.Windows.Forms.Button();
            this.btnBookSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedListBoxSearchGenre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbGenre);
            this.groupBox1.Controls.Add(this.lbAuthor);
            this.groupBox1.Controls.Add(this.lbTitle);
            this.groupBox1.Controls.Add(this.textBoxSearchAuthor);
            this.groupBox1.Controls.Add(this.textBoxSearchTitle);
            this.groupBox1.Controls.Add(this.textBoxSearchPublishing);
            this.groupBox1.Controls.Add(this.btnBookSearchCancel);
            this.groupBox1.Controls.Add(this.btnBookSearch);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 311);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // checkedListBoxSearchGenre
            // 
            this.checkedListBoxSearchGenre.FormattingEnabled = true;
            this.checkedListBoxSearchGenre.Location = new System.Drawing.Point(149, 112);
            this.checkedListBoxSearchGenre.Name = "checkedListBoxSearchGenre";
            this.checkedListBoxSearchGenre.Size = new System.Drawing.Size(172, 94);
            this.checkedListBoxSearchGenre.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Publishing date";
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Location = new System.Drawing.Point(30, 112);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(36, 13);
            this.lbGenre.TabIndex = 19;
            this.lbGenre.Text = "Genre";
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Location = new System.Drawing.Point(30, 75);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(38, 13);
            this.lbAuthor.TabIndex = 18;
            this.lbAuthor.Text = "Author";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(30, 41);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(27, 13);
            this.lbTitle.TabIndex = 17;
            this.lbTitle.Text = "Title";
            // 
            // textBoxSearchAuthor
            // 
            this.textBoxSearchAuthor.Location = new System.Drawing.Point(149, 72);
            this.textBoxSearchAuthor.Name = "textBoxSearchAuthor";
            this.textBoxSearchAuthor.Size = new System.Drawing.Size(172, 20);
            this.textBoxSearchAuthor.TabIndex = 16;
            // 
            // textBoxSearchTitle
            // 
            this.textBoxSearchTitle.Location = new System.Drawing.Point(149, 35);
            this.textBoxSearchTitle.Name = "textBoxSearchTitle";
            this.textBoxSearchTitle.Size = new System.Drawing.Size(172, 20);
            this.textBoxSearchTitle.TabIndex = 15;
            // 
            // textBoxSearchPublishing
            // 
            this.textBoxSearchPublishing.Location = new System.Drawing.Point(149, 225);
            this.textBoxSearchPublishing.Name = "textBoxSearchPublishing";
            this.textBoxSearchPublishing.Size = new System.Drawing.Size(172, 20);
            this.textBoxSearchPublishing.TabIndex = 12;
            // 
            // btnBookSearchCancel
            // 
            this.btnBookSearchCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBookSearchCancel.Location = new System.Drawing.Point(246, 268);
            this.btnBookSearchCancel.Name = "btnBookSearchCancel";
            this.btnBookSearchCancel.Size = new System.Drawing.Size(75, 23);
            this.btnBookSearchCancel.TabIndex = 5;
            this.btnBookSearchCancel.Text = "Cancel";
            this.btnBookSearchCancel.UseVisualStyleBackColor = true;
            // 
            // btnBookSearch
            // 
            this.btnBookSearch.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBookSearch.Location = new System.Drawing.Point(149, 268);
            this.btnBookSearch.Name = "btnBookSearch";
            this.btnBookSearch.Size = new System.Drawing.Size(75, 23);
            this.btnBookSearch.TabIndex = 4;
            this.btnBookSearch.Text = "Search";
            this.btnBookSearch.UseVisualStyleBackColor = true;
            // 
            // BookSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 345);
            this.Controls.Add(this.groupBox1);
            this.Name = "BookSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Search";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        protected internal System.Windows.Forms.CheckedListBox checkedListBoxSearchGenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Label lbTitle;
        protected internal System.Windows.Forms.TextBox textBoxSearchAuthor;
        protected internal System.Windows.Forms.TextBox textBoxSearchTitle;
        protected internal System.Windows.Forms.TextBox textBoxSearchPublishing;
        protected internal System.Windows.Forms.Button btnBookSearchCancel;
        protected internal System.Windows.Forms.Button btnBookSearch;
    }
}