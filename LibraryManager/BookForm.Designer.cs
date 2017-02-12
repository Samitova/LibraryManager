namespace LibraryManager
{
    partial class BookForm
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
            this.groupBoxBook = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelTeam = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.comboBoxAuthor = new System.Windows.Forms.ComboBox();
            this.textBoxPublishing = new System.Windows.Forms.TextBox();
            this.groupBoxBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBook
            // 
            this.groupBoxBook.Controls.Add(this.textBoxPublishing);
            this.groupBoxBook.Controls.Add(this.btnCancel);
            this.groupBoxBook.Controls.Add(this.labelTeam);
            this.groupBoxBook.Controls.Add(this.lbTitle);
            this.groupBoxBook.Controls.Add(this.lbAuthor);
            this.groupBoxBook.Controls.Add(this.btnOK);
            this.groupBoxBook.Controls.Add(this.textBoxTitle);
            this.groupBoxBook.Controls.Add(this.comboBoxAuthor);
            this.groupBoxBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBoxBook.Location = new System.Drawing.Point(12, 12);
            this.groupBoxBook.Name = "groupBoxBook";
            this.groupBoxBook.Size = new System.Drawing.Size(331, 238);
            this.groupBoxBook.TabIndex = 11;
            this.groupBoxBook.TabStop = false;
            this.groupBoxBook.Text = "Book";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(236, 193);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // labelTeam
            // 
            this.labelTeam.AutoSize = true;
            this.labelTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelTeam.Location = new System.Drawing.Point(16, 140);
            this.labelTeam.Name = "labelTeam";
            this.labelTeam.Size = new System.Drawing.Size(110, 18);
            this.labelTeam.TabIndex = 8;
            this.labelTeam.Text = "Publishing Date";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbTitle.Location = new System.Drawing.Point(16, 42);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(35, 18);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Title";
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbAuthor.Location = new System.Drawing.Point(16, 89);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(51, 18);
            this.lbAuthor.TabIndex = 1;
            this.lbAuthor.Text = "Author";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(139, 193);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(139, 36);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(172, 24);
            this.textBoxTitle.TabIndex = 3;
            // 
            // comboBoxAuthor
            // 
            this.comboBoxAuthor.FormattingEnabled = true;
            this.comboBoxAuthor.Location = new System.Drawing.Point(139, 81);
            this.comboBoxAuthor.Name = "comboBoxAuthor";
            this.comboBoxAuthor.Size = new System.Drawing.Size(172, 26);
            this.comboBoxAuthor.TabIndex = 4;
            // 
            // textBoxPublishing
            // 
            this.textBoxPublishing.Location = new System.Drawing.Point(139, 134);
            this.textBoxPublishing.Name = "textBoxPublishing";
            this.textBoxPublishing.Size = new System.Drawing.Size(172, 24);
            this.textBoxPublishing.TabIndex = 9;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 264);
            this.Controls.Add(this.groupBoxBook);
            this.Name = "BookForm";
            this.Text = "BookForm";
            this.groupBoxBook.ResumeLayout(false);
            this.groupBoxBook.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBook;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelTeam;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Button btnOK;
        protected internal System.Windows.Forms.TextBox textBoxTitle;
        protected internal System.Windows.Forms.ComboBox comboBoxAuthor;
        protected internal System.Windows.Forms.TextBox textBoxPublishing;
    }
}