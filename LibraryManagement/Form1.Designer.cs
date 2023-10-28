namespace LibraryManagement
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
            this.head = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Button();
            this.head_name = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.Panel();
            this.check_book_availability = new System.Windows.Forms.Button();
            this.reserve_book = new System.Windows.Forms.Button();
            this.return_book = new System.Windows.Forms.Button();
            this.register_member = new System.Windows.Forms.Button();
            this.borrow_book = new System.Windows.Forms.Button();
            this.addbook = new System.Windows.Forms.Button();
            this.head.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // head
            // 
            this.head.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.head.Controls.Add(this.head_name);
            this.head.Location = new System.Drawing.Point(0, 0);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(1312, 104);
            this.head.TabIndex = 0;
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.Red;
            this.close.Location = new System.Drawing.Point(76, 535);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(154, 40);
            this.close.TabIndex = 7;
            this.close.Text = "CANCEL";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // head_name
            // 
            this.head_name.AutoSize = true;
            this.head_name.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.head_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.head_name.Location = new System.Drawing.Point(434, 34);
            this.head_name.Name = "head_name";
            this.head_name.Size = new System.Drawing.Size(475, 31);
            this.head_name.TabIndex = 0;
            this.head_name.Text = "LIBRARY MANAGEMENT SYSTEM";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menu.Controls.Add(this.close);
            this.menu.Controls.Add(this.check_book_availability);
            this.menu.Controls.Add(this.reserve_book);
            this.menu.Controls.Add(this.return_book);
            this.menu.Controls.Add(this.register_member);
            this.menu.Controls.Add(this.borrow_book);
            this.menu.Controls.Add(this.addbook);
            this.menu.Location = new System.Drawing.Point(0, 110);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(339, 609);
            this.menu.TabIndex = 1;
            // 
            // check_book_availability
            // 
            this.check_book_availability.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_book_availability.Location = new System.Drawing.Point(12, 107);
            this.check_book_availability.Name = "check_book_availability";
            this.check_book_availability.Size = new System.Drawing.Size(306, 56);
            this.check_book_availability.TabIndex = 6;
            this.check_book_availability.Text = "BOOK AVAILABILITY";
            this.check_book_availability.UseVisualStyleBackColor = true;
            this.check_book_availability.Click += new System.EventHandler(this.check_book_availability_Click);
            // 
            // reserve_book
            // 
            this.reserve_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserve_book.Location = new System.Drawing.Point(12, 438);
            this.reserve_book.Name = "reserve_book";
            this.reserve_book.Size = new System.Drawing.Size(306, 56);
            this.reserve_book.TabIndex = 5;
            this.reserve_book.Text = "RESURVE BOOK";
            this.reserve_book.UseVisualStyleBackColor = true;
            this.reserve_book.Click += new System.EventHandler(this.reserve_book_Click);
            // 
            // return_book
            // 
            this.return_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_book.Location = new System.Drawing.Point(12, 354);
            this.return_book.Name = "return_book";
            this.return_book.Size = new System.Drawing.Size(306, 56);
            this.return_book.TabIndex = 4;
            this.return_book.Text = "RETURN BOOK";
            this.return_book.UseVisualStyleBackColor = true;
            this.return_book.Click += new System.EventHandler(this.return_book_Click);
            // 
            // register_member
            // 
            this.register_member.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_member.Location = new System.Drawing.Point(12, 184);
            this.register_member.Name = "register_member";
            this.register_member.Size = new System.Drawing.Size(306, 56);
            this.register_member.TabIndex = 2;
            this.register_member.Text = "REGISTER MEMBER";
            this.register_member.UseVisualStyleBackColor = true;
            this.register_member.Click += new System.EventHandler(this.register_member_Click);
            // 
            // borrow_book
            // 
            this.borrow_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrow_book.Location = new System.Drawing.Point(12, 270);
            this.borrow_book.Name = "borrow_book";
            this.borrow_book.Size = new System.Drawing.Size(306, 56);
            this.borrow_book.TabIndex = 3;
            this.borrow_book.Text = "BORROW BOOK";
            this.borrow_book.UseVisualStyleBackColor = true;
            this.borrow_book.Click += new System.EventHandler(this.borrow_book_Click);
            // 
            // addbook
            // 
            this.addbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbook.Location = new System.Drawing.Point(12, 17);
            this.addbook.Name = "addbook";
            this.addbook.Size = new System.Drawing.Size(306, 56);
            this.addbook.TabIndex = 0;
            this.addbook.Text = "ADD BOOK";
            this.addbook.UseVisualStyleBackColor = true;
            this.addbook.Click += new System.EventHandler(this.addbook_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1313, 721);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.head);
            this.Name = "Form1";
            this.Text = "Form1";
            this.head.ResumeLayout(false);
            this.head.PerformLayout();
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel head;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Label head_name;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button check_book_availability;
        private System.Windows.Forms.Button reserve_book;
        private System.Windows.Forms.Button return_book;
        private System.Windows.Forms.Button register_member;
        private System.Windows.Forms.Button borrow_book;
        private System.Windows.Forms.Button addbook;
    }
}

