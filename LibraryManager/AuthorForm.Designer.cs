namespace LibraryManager
{
    partial class AuthorForm
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
            this.groupBoxAuthor = new System.Windows.Forms.GroupBox();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.textBoxBirthDate = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbBirthDate = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbSecondName = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.groupBoxAuthor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAuthor
            // 
            this.groupBoxAuthor.Controls.Add(this.textBoxSecondName);
            this.groupBoxAuthor.Controls.Add(this.textBoxBirthDate);
            this.groupBoxAuthor.Controls.Add(this.btnCancel);
            this.groupBoxAuthor.Controls.Add(this.lbBirthDate);
            this.groupBoxAuthor.Controls.Add(this.lbFirstName);
            this.groupBoxAuthor.Controls.Add(this.lbSecondName);
            this.groupBoxAuthor.Controls.Add(this.btnOK);
            this.groupBoxAuthor.Controls.Add(this.textBoxFirstName);
            this.groupBoxAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBoxAuthor.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAuthor.Name = "groupBoxAuthor";
            this.groupBoxAuthor.Size = new System.Drawing.Size(331, 238);
            this.groupBoxAuthor.TabIndex = 12;
            this.groupBoxAuthor.TabStop = false;
            this.groupBoxAuthor.Text = "Author";
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Location = new System.Drawing.Point(139, 89);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(172, 24);
            this.textBoxSecondName.TabIndex = 10;
            // 
            // textBoxBirthDate
            // 
            this.textBoxBirthDate.Location = new System.Drawing.Point(139, 134);
            this.textBoxBirthDate.Name = "textBoxBirthDate";
            this.textBoxBirthDate.Size = new System.Drawing.Size(172, 24);
            this.textBoxBirthDate.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(236, 193);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbBirthDate
            // 
            this.lbBirthDate.AutoSize = true;
            this.lbBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbBirthDate.Location = new System.Drawing.Point(16, 140);
            this.lbBirthDate.Name = "lbBirthDate";
            this.lbBirthDate.Size = new System.Drawing.Size(73, 18);
            this.lbBirthDate.TabIndex = 8;
            this.lbBirthDate.Text = "Birth Date";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbFirstName.Location = new System.Drawing.Point(16, 42);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(78, 18);
            this.lbFirstName.TabIndex = 0;
            this.lbFirstName.Text = "First name";
            // 
            // lbSecondName
            // 
            this.lbSecondName.AutoSize = true;
            this.lbSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbSecondName.Location = new System.Drawing.Point(16, 89);
            this.lbSecondName.Name = "lbSecondName";
            this.lbSecondName.Size = new System.Drawing.Size(100, 18);
            this.lbSecondName.TabIndex = 1;
            this.lbSecondName.Text = "Second name";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(139, 193);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(139, 36);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(172, 24);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // AuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 276);
            this.Controls.Add(this.groupBoxAuthor);
            this.Name = "AuthorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Author";
            this.groupBoxAuthor.ResumeLayout(false);
            this.groupBoxAuthor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAuthor;
        protected internal System.Windows.Forms.TextBox textBoxSecondName;
        protected internal System.Windows.Forms.TextBox textBoxBirthDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbBirthDate;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbSecondName;
        private System.Windows.Forms.Button btnOK;
        protected internal System.Windows.Forms.TextBox textBoxFirstName;
    }
}