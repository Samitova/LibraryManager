namespace LibraryManager
{
    partial class AuthorSearchForm
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
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.lbSecondName = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.textBoxSearchAuthor = new System.Windows.Forms.TextBox();
            this.textBoxSearchTitle = new System.Windows.Forms.TextBox();
            this.textBoxSearchPublishing = new System.Windows.Forms.TextBox();
            this.btnAuthorSearchCancel = new System.Windows.Forms.Button();
            this.btnAuthorSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelBirthDate);
            this.groupBox1.Controls.Add(this.lbSecondName);
            this.groupBox1.Controls.Add(this.lbFirstName);
            this.groupBox1.Controls.Add(this.textBoxSearchAuthor);
            this.groupBox1.Controls.Add(this.textBoxSearchTitle);
            this.groupBox1.Controls.Add(this.textBoxSearchPublishing);
            this.groupBox1.Controls.Add(this.btnAuthorSearchCancel);
            this.groupBox1.Controls.Add(this.btnAuthorSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 207);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(32, 116);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(52, 13);
            this.labelBirthDate.TabIndex = 20;
            this.labelBirthDate.Text = "Birth date";
            // 
            // lbSecondName
            // 
            this.lbSecondName.AutoSize = true;
            this.lbSecondName.Location = new System.Drawing.Point(30, 75);
            this.lbSecondName.Name = "lbSecondName";
            this.lbSecondName.Size = new System.Drawing.Size(73, 13);
            this.lbSecondName.TabIndex = 18;
            this.lbSecondName.Text = "Second name";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(30, 41);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(55, 13);
            this.lbFirstName.TabIndex = 17;
            this.lbFirstName.Text = "First name";
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
            this.textBoxSearchPublishing.Location = new System.Drawing.Point(149, 113);
            this.textBoxSearchPublishing.Name = "textBoxSearchPublishing";
            this.textBoxSearchPublishing.Size = new System.Drawing.Size(172, 20);
            this.textBoxSearchPublishing.TabIndex = 12;
            // 
            // btnAuthorSearchCancel
            // 
            this.btnAuthorSearchCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAuthorSearchCancel.Location = new System.Drawing.Point(246, 156);
            this.btnAuthorSearchCancel.Name = "btnAuthorSearchCancel";
            this.btnAuthorSearchCancel.Size = new System.Drawing.Size(75, 23);
            this.btnAuthorSearchCancel.TabIndex = 5;
            this.btnAuthorSearchCancel.Text = "Cancel";
            this.btnAuthorSearchCancel.UseVisualStyleBackColor = true;
            // 
            // btnAuthorSearch
            // 
            this.btnAuthorSearch.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAuthorSearch.Location = new System.Drawing.Point(149, 156);
            this.btnAuthorSearch.Name = "btnAuthorSearch";
            this.btnAuthorSearch.Size = new System.Drawing.Size(75, 23);
            this.btnAuthorSearch.TabIndex = 4;
            this.btnAuthorSearch.Text = "Search";
            this.btnAuthorSearch.UseVisualStyleBackColor = true;
            // 
            // AuthorSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 248);
            this.Controls.Add(this.groupBox1);
            this.Name = "AuthorSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthorSearchForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label lbSecondName;
        private System.Windows.Forms.Label lbFirstName;
        protected internal System.Windows.Forms.TextBox textBoxSearchAuthor;
        protected internal System.Windows.Forms.TextBox textBoxSearchTitle;
        protected internal System.Windows.Forms.TextBox textBoxSearchPublishing;
        protected internal System.Windows.Forms.Button btnAuthorSearchCancel;
        protected internal System.Windows.Forms.Button btnAuthorSearch;
    }
}