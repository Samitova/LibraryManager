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
            this.groupBoxSearchAuthor = new System.Windows.Forms.GroupBox();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.lbSecondName = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.textBoxSearchSecondName = new System.Windows.Forms.TextBox();
            this.textBoxSearchFirstName = new System.Windows.Forms.TextBox();
            this.textBoxSearchBirth = new System.Windows.Forms.TextBox();
            this.btnAuthorSearchCancel = new System.Windows.Forms.Button();
            this.btnAuthorSearch = new System.Windows.Forms.Button();
            this.groupBoxSearchAuthor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSearchAuthor
            // 
            this.groupBoxSearchAuthor.Controls.Add(this.labelBirthDate);
            this.groupBoxSearchAuthor.Controls.Add(this.lbSecondName);
            this.groupBoxSearchAuthor.Controls.Add(this.lbFirstName);
            this.groupBoxSearchAuthor.Controls.Add(this.textBoxSearchSecondName);
            this.groupBoxSearchAuthor.Controls.Add(this.textBoxSearchFirstName);
            this.groupBoxSearchAuthor.Controls.Add(this.textBoxSearchBirth);
            this.groupBoxSearchAuthor.Controls.Add(this.btnAuthorSearchCancel);
            this.groupBoxSearchAuthor.Controls.Add(this.btnAuthorSearch);
            this.groupBoxSearchAuthor.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSearchAuthor.Name = "groupBoxSearchAuthor";
            this.groupBoxSearchAuthor.Size = new System.Drawing.Size(348, 207);
            this.groupBoxSearchAuthor.TabIndex = 1;
            this.groupBoxSearchAuthor.TabStop = false;
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
            // textBoxSearchSecondName
            // 
            this.textBoxSearchSecondName.Location = new System.Drawing.Point(149, 72);
            this.textBoxSearchSecondName.Name = "textBoxSearchSecondName";
            this.textBoxSearchSecondName.Size = new System.Drawing.Size(172, 20);
            this.textBoxSearchSecondName.TabIndex = 16;
            // 
            // textBoxSearchFirstName
            // 
            this.textBoxSearchFirstName.Location = new System.Drawing.Point(149, 35);
            this.textBoxSearchFirstName.Name = "textBoxSearchFirstName";
            this.textBoxSearchFirstName.Size = new System.Drawing.Size(172, 20);
            this.textBoxSearchFirstName.TabIndex = 15;
            // 
            // textBoxSearchBirth
            // 
            this.textBoxSearchBirth.Location = new System.Drawing.Point(149, 113);
            this.textBoxSearchBirth.Name = "textBoxSearchBirth";
            this.textBoxSearchBirth.Size = new System.Drawing.Size(172, 20);
            this.textBoxSearchBirth.TabIndex = 12;
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
            this.ClientSize = new System.Drawing.Size(380, 234);
            this.Controls.Add(this.groupBoxSearchAuthor);
            this.Name = "AuthorSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthorSearchForm";
            this.groupBoxSearchAuthor.ResumeLayout(false);
            this.groupBoxSearchAuthor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSearchAuthor;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label lbSecondName;
        private System.Windows.Forms.Label lbFirstName;
        protected internal System.Windows.Forms.TextBox textBoxSearchSecondName;
        protected internal System.Windows.Forms.TextBox textBoxSearchFirstName;
        protected internal System.Windows.Forms.TextBox textBoxSearchBirth;
        protected internal System.Windows.Forms.Button btnAuthorSearchCancel;
        protected internal System.Windows.Forms.Button btnAuthorSearch;
    }
}