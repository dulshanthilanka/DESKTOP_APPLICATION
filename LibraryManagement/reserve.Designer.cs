namespace LibraryManagement
{
    partial class reserve
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
            this.re_panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.re_groupBox1 = new System.Windows.Forms.GroupBox();
            this.reserve_book_cancel_btn = new System.Windows.Forms.Button();
            this.reserve_book_reserve_btn = new System.Windows.Forms.Button();
            this.reserve_book_id_of_the_member_textfield = new System.Windows.Forms.TextBox();
            this.reserve_id_of_the_book_textfield = new System.Windows.Forms.TextBox();
            this.reserve_book_id_of_the_member = new System.Windows.Forms.Label();
            this.reserve_id_of_the_book = new System.Windows.Forms.Label();
            this.re_panel1.SuspendLayout();
            this.re_groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // re_panel1
            // 
            this.re_panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.re_panel1.Controls.Add(this.label1);
            this.re_panel1.Location = new System.Drawing.Point(-1, 1);
            this.re_panel1.Name = "re_panel1";
            this.re_panel1.Size = new System.Drawing.Size(1319, 121);
            this.re_panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(531, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "RESERVE BOOK";
            // 
            // re_groupBox1
            // 
            this.re_groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.re_groupBox1.Controls.Add(this.reserve_book_cancel_btn);
            this.re_groupBox1.Controls.Add(this.reserve_book_reserve_btn);
            this.re_groupBox1.Controls.Add(this.reserve_book_id_of_the_member_textfield);
            this.re_groupBox1.Controls.Add(this.reserve_id_of_the_book_textfield);
            this.re_groupBox1.Controls.Add(this.reserve_book_id_of_the_member);
            this.re_groupBox1.Controls.Add(this.reserve_id_of_the_book);
            this.re_groupBox1.Location = new System.Drawing.Point(363, 167);
            this.re_groupBox1.Name = "re_groupBox1";
            this.re_groupBox1.Size = new System.Drawing.Size(590, 476);
            this.re_groupBox1.TabIndex = 5;
            this.re_groupBox1.TabStop = false;
            // 
            // reserve_book_cancel_btn
            // 
            this.reserve_book_cancel_btn.Location = new System.Drawing.Point(438, 371);
            this.reserve_book_cancel_btn.Name = "reserve_book_cancel_btn";
            this.reserve_book_cancel_btn.Size = new System.Drawing.Size(78, 45);
            this.reserve_book_cancel_btn.TabIndex = 7;
            this.reserve_book_cancel_btn.Text = "CANCEL";
            this.reserve_book_cancel_btn.UseVisualStyleBackColor = true;
            // 
            // reserve_book_reserve_btn
            // 
            this.reserve_book_reserve_btn.Location = new System.Drawing.Point(71, 371);
            this.reserve_book_reserve_btn.Name = "reserve_book_reserve_btn";
            this.reserve_book_reserve_btn.Size = new System.Drawing.Size(81, 45);
            this.reserve_book_reserve_btn.TabIndex = 6;
            this.reserve_book_reserve_btn.Text = "RESERVE";
            this.reserve_book_reserve_btn.UseVisualStyleBackColor = true;
            // 
            // reserve_book_id_of_the_member_textfield
            // 
            this.reserve_book_id_of_the_member_textfield.Location = new System.Drawing.Point(234, 240);
            this.reserve_book_id_of_the_member_textfield.Name = "reserve_book_id_of_the_member_textfield";
            this.reserve_book_id_of_the_member_textfield.Size = new System.Drawing.Size(329, 22);
            this.reserve_book_id_of_the_member_textfield.TabIndex = 4;
            // 
            // reserve_id_of_the_book_textfield
            // 
            this.reserve_id_of_the_book_textfield.Location = new System.Drawing.Point(234, 112);
            this.reserve_id_of_the_book_textfield.Name = "reserve_id_of_the_book_textfield";
            this.reserve_id_of_the_book_textfield.Size = new System.Drawing.Size(329, 22);
            this.reserve_id_of_the_book_textfield.TabIndex = 3;
            // 
            // reserve_book_id_of_the_member
            // 
            this.reserve_book_id_of_the_member.AutoSize = true;
            this.reserve_book_id_of_the_member.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserve_book_id_of_the_member.Location = new System.Drawing.Point(26, 246);
            this.reserve_book_id_of_the_member.Name = "reserve_book_id_of_the_member";
            this.reserve_book_id_of_the_member.Size = new System.Drawing.Size(150, 16);
            this.reserve_book_id_of_the_member.TabIndex = 1;
            this.reserve_book_id_of_the_member.Text = "ID OF THE MEMBER";
            // 
            // reserve_id_of_the_book
            // 
            this.reserve_id_of_the_book.AutoSize = true;
            this.reserve_id_of_the_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserve_id_of_the_book.Location = new System.Drawing.Point(26, 118);
            this.reserve_id_of_the_book.Name = "reserve_id_of_the_book";
            this.reserve_id_of_the_book.Size = new System.Drawing.Size(126, 16);
            this.reserve_id_of_the_book.TabIndex = 0;
            this.reserve_id_of_the_book.Text = "ID OF THE BOOK";
            // 
            // reserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1316, 734);
            this.Controls.Add(this.re_groupBox1);
            this.Controls.Add(this.re_panel1);
            this.Name = "reserve";
            this.Text = "reserve";
            this.re_panel1.ResumeLayout(false);
            this.re_panel1.PerformLayout();
            this.re_groupBox1.ResumeLayout(false);
            this.re_groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel re_panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox re_groupBox1;
        private System.Windows.Forms.Button reserve_book_cancel_btn;
        private System.Windows.Forms.Button reserve_book_reserve_btn;
        private System.Windows.Forms.TextBox reserve_book_id_of_the_member_textfield;
        private System.Windows.Forms.TextBox reserve_id_of_the_book_textfield;
        private System.Windows.Forms.Label reserve_book_id_of_the_member;
        private System.Windows.Forms.Label reserve_id_of_the_book;
    }
}