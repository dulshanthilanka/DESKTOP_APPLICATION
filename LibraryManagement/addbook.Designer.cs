namespace LibraryManagement
{
    partial class addbook
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
            this.a_b_panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.a_b_groupBox1 = new System.Windows.Forms.GroupBox();
            this.add_book_cancel_btn = new System.Windows.Forms.Button();
            this.add_book_save_btn = new System.Windows.Forms.Button();
            this.id_of_the_book_textfield = new System.Windows.Forms.TextBox();
            this.author_of_the_book_textfield = new System.Windows.Forms.TextBox();
            this.name_of_the_bookfield = new System.Windows.Forms.TextBox();
            this.id_of_the_book = new System.Windows.Forms.Label();
            this.author_of_the_book = new System.Windows.Forms.Label();
            this.name_of_the_book = new System.Windows.Forms.Label();
            this.publication_year = new System.Windows.Forms.Label();
            this.publicationYearTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.Label();
            this.a_b_panel1.SuspendLayout();
            this.a_b_groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // a_b_panel1
            // 
            this.a_b_panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.a_b_panel1.Controls.Add(this.label1);
            this.a_b_panel1.Location = new System.Drawing.Point(1, 0);
            this.a_b_panel1.Name = "a_b_panel1";
            this.a_b_panel1.Size = new System.Drawing.Size(1273, 131);
            this.a_b_panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(531, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD BOOK";
            // 
            // a_b_groupBox1
            // 
            this.a_b_groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.a_b_groupBox1.Controls.Add(this.quantity);
            this.a_b_groupBox1.Controls.Add(this.quantityTextBox);
            this.a_b_groupBox1.Controls.Add(this.publicationYearTextBox);
            this.a_b_groupBox1.Controls.Add(this.publication_year);
            this.a_b_groupBox1.Controls.Add(this.add_book_cancel_btn);
            this.a_b_groupBox1.Controls.Add(this.add_book_save_btn);
            this.a_b_groupBox1.Controls.Add(this.id_of_the_book_textfield);
            this.a_b_groupBox1.Controls.Add(this.author_of_the_book_textfield);
            this.a_b_groupBox1.Controls.Add(this.name_of_the_bookfield);
            this.a_b_groupBox1.Controls.Add(this.id_of_the_book);
            this.a_b_groupBox1.Controls.Add(this.author_of_the_book);
            this.a_b_groupBox1.Controls.Add(this.name_of_the_book);
            this.a_b_groupBox1.Location = new System.Drawing.Point(331, 161);
            this.a_b_groupBox1.Name = "a_b_groupBox1";
            this.a_b_groupBox1.Size = new System.Drawing.Size(590, 505);
            this.a_b_groupBox1.TabIndex = 1;
            this.a_b_groupBox1.TabStop = false;
            this.a_b_groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // add_book_cancel_btn
            // 
            this.add_book_cancel_btn.Location = new System.Drawing.Point(429, 423);
            this.add_book_cancel_btn.Name = "add_book_cancel_btn";
            this.add_book_cancel_btn.Size = new System.Drawing.Size(78, 45);
            this.add_book_cancel_btn.TabIndex = 7;
            this.add_book_cancel_btn.Text = "CANCEL";
            this.add_book_cancel_btn.UseVisualStyleBackColor = true;
            this.add_book_cancel_btn.Click += new System.EventHandler(this.add_book_cancel_btn_Click);
            // 
            // add_book_save_btn
            // 
            this.add_book_save_btn.Location = new System.Drawing.Point(71, 423);
            this.add_book_save_btn.Name = "add_book_save_btn";
            this.add_book_save_btn.Size = new System.Drawing.Size(81, 45);
            this.add_book_save_btn.TabIndex = 6;
            this.add_book_save_btn.Text = "SAVE";
            this.add_book_save_btn.UseVisualStyleBackColor = true;
            this.add_book_save_btn.Click += new System.EventHandler(this.add_book_save_btn_Click);
            // 
            // id_of_the_book_textfield
            // 
            this.id_of_the_book_textfield.Location = new System.Drawing.Point(234, 221);
            this.id_of_the_book_textfield.Name = "id_of_the_book_textfield";
            this.id_of_the_book_textfield.Size = new System.Drawing.Size(329, 22);
            this.id_of_the_book_textfield.TabIndex = 5;
            this.id_of_the_book_textfield.TextChanged += new System.EventHandler(this.id_of_the_book_textfield_TextChanged);
            // 
            // author_of_the_book_textfield
            // 
            this.author_of_the_book_textfield.Location = new System.Drawing.Point(234, 139);
            this.author_of_the_book_textfield.Name = "author_of_the_book_textfield";
            this.author_of_the_book_textfield.Size = new System.Drawing.Size(329, 22);
            this.author_of_the_book_textfield.TabIndex = 4;
            this.author_of_the_book_textfield.TextChanged += new System.EventHandler(this.author_of_the_book_textfield_TextChanged);
            // 
            // name_of_the_bookfield
            // 
            this.name_of_the_bookfield.Location = new System.Drawing.Point(234, 68);
            this.name_of_the_bookfield.Name = "name_of_the_bookfield";
            this.name_of_the_bookfield.Size = new System.Drawing.Size(329, 22);
            this.name_of_the_bookfield.TabIndex = 3;
            this.name_of_the_bookfield.TextChanged += new System.EventHandler(this.name_of_the_bookfield_TextChanged);
            // 
            // id_of_the_book
            // 
            this.id_of_the_book.AutoSize = true;
            this.id_of_the_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_of_the_book.Location = new System.Drawing.Point(26, 221);
            this.id_of_the_book.Name = "id_of_the_book";
            this.id_of_the_book.Size = new System.Drawing.Size(126, 16);
            this.id_of_the_book.TabIndex = 2;
            this.id_of_the_book.Text = "ID OF THE BOOK";
            // 
            // author_of_the_book
            // 
            this.author_of_the_book.AutoSize = true;
            this.author_of_the_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author_of_the_book.Location = new System.Drawing.Point(26, 139);
            this.author_of_the_book.Name = "author_of_the_book";
            this.author_of_the_book.Size = new System.Drawing.Size(175, 16);
            this.author_of_the_book.TabIndex = 1;
            this.author_of_the_book.Text = "AUTHOR OF THE BOOK";
            // 
            // name_of_the_book
            // 
            this.name_of_the_book.AutoSize = true;
            this.name_of_the_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_of_the_book.Location = new System.Drawing.Point(26, 68);
            this.name_of_the_book.Name = "name_of_the_book";
            this.name_of_the_book.Size = new System.Drawing.Size(154, 16);
            this.name_of_the_book.TabIndex = 0;
            this.name_of_the_book.Text = "NAME OF THE BOOK";
            // 
            // publication_year
            // 
            this.publication_year.AutoSize = true;
            this.publication_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publication_year.Location = new System.Drawing.Point(26, 303);
            this.publication_year.Name = "publication_year";
            this.publication_year.Size = new System.Drawing.Size(151, 16);
            this.publication_year.TabIndex = 8;
            this.publication_year.Text = "PUBLICATION YEAR";
            // 
            // publicationYearTextBox
            // 
            this.publicationYearTextBox.Location = new System.Drawing.Point(234, 297);
            this.publicationYearTextBox.Name = "publicationYearTextBox";
            this.publicationYearTextBox.Size = new System.Drawing.Size(329, 22);
            this.publicationYearTextBox.TabIndex = 9;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(234, 378);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(329, 22);
            this.quantityTextBox.TabIndex = 10;
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(26, 378);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(84, 16);
            this.quantity.TabIndex = 11;
            this.quantity.Text = "QUANTITY";
            // 
            // addbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1274, 699);
            this.Controls.Add(this.a_b_groupBox1);
            this.Controls.Add(this.a_b_panel1);
            this.Name = "addbook";
            this.Text = "addbook";
            this.a_b_panel1.ResumeLayout(false);
            this.a_b_panel1.PerformLayout();
            this.a_b_groupBox1.ResumeLayout(false);
            this.a_b_groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel a_b_panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox a_b_groupBox1;
        private System.Windows.Forms.Label author_of_the_book;
        private System.Windows.Forms.Label name_of_the_book;
        private System.Windows.Forms.Label id_of_the_book;
        private System.Windows.Forms.Button add_book_cancel_btn;
        private System.Windows.Forms.Button add_book_save_btn;
        private System.Windows.Forms.TextBox id_of_the_book_textfield;
        private System.Windows.Forms.TextBox author_of_the_book_textfield;
        private System.Windows.Forms.TextBox name_of_the_bookfield;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox publicationYearTextBox;
        private System.Windows.Forms.Label publication_year;
    }
}