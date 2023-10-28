namespace LibraryManagement
{
    partial class availability
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
            this.a_panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.a_groupBox1 = new System.Windows.Forms.GroupBox();
            this.availability_check_btn = new System.Windows.Forms.Button();
            this.id_of_the_book_textfield = new System.Windows.Forms.TextBox();
            this.id_of_the_book = new System.Windows.Forms.Label();
            this.availability_grid_area = new System.Windows.Forms.DataGridView();
            this.a_panel1.SuspendLayout();
            this.a_groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availability_grid_area)).BeginInit();
            this.SuspendLayout();
            // 
            // a_panel1
            // 
            this.a_panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.a_panel1.Controls.Add(this.label1);
            this.a_panel1.Location = new System.Drawing.Point(1, 1);
            this.a_panel1.Name = "a_panel1";
            this.a_panel1.Size = new System.Drawing.Size(1315, 131);
            this.a_panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(568, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "AVAILABILITY";
            // 
            // a_groupBox1
            // 
            this.a_groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.a_groupBox1.Controls.Add(this.availability_check_btn);
            this.a_groupBox1.Controls.Add(this.id_of_the_book_textfield);
            this.a_groupBox1.Controls.Add(this.id_of_the_book);
            this.a_groupBox1.Location = new System.Drawing.Point(12, 158);
            this.a_groupBox1.Name = "a_groupBox1";
            this.a_groupBox1.Size = new System.Drawing.Size(590, 565);
            this.a_groupBox1.TabIndex = 2;
            this.a_groupBox1.TabStop = false;
            // 
            // availability_check_btn
            // 
            this.availability_check_btn.Location = new System.Drawing.Point(223, 340);
            this.availability_check_btn.Name = "availability_check_btn";
            this.availability_check_btn.Size = new System.Drawing.Size(81, 45);
            this.availability_check_btn.TabIndex = 6;
            this.availability_check_btn.Text = "CHECK";
            this.availability_check_btn.UseVisualStyleBackColor = true;
            // 
            // id_of_the_book_textfield
            // 
            this.id_of_the_book_textfield.Location = new System.Drawing.Point(223, 175);
            this.id_of_the_book_textfield.Name = "id_of_the_book_textfield";
            this.id_of_the_book_textfield.Size = new System.Drawing.Size(329, 22);
            this.id_of_the_book_textfield.TabIndex = 4;
            // 
            // id_of_the_book
            // 
            this.id_of_the_book.AutoSize = true;
            this.id_of_the_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_of_the_book.Location = new System.Drawing.Point(26, 181);
            this.id_of_the_book.Name = "id_of_the_book";
            this.id_of_the_book.Size = new System.Drawing.Size(126, 16);
            this.id_of_the_book.TabIndex = 1;
            this.id_of_the_book.Text = "ID OF THE BOOK";
            // 
            // availability_grid_area
            // 
            this.availability_grid_area.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availability_grid_area.Location = new System.Drawing.Point(693, 227);
            this.availability_grid_area.Name = "availability_grid_area";
            this.availability_grid_area.RowHeadersWidth = 51;
            this.availability_grid_area.RowTemplate.Height = 24;
            this.availability_grid_area.Size = new System.Drawing.Size(561, 253);
            this.availability_grid_area.TabIndex = 3;
            // 
            // availability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1318, 735);
            this.Controls.Add(this.availability_grid_area);
            this.Controls.Add(this.a_groupBox1);
            this.Controls.Add(this.a_panel1);
            this.Name = "availability";
            this.Text = "availability";
            this.a_panel1.ResumeLayout(false);
            this.a_panel1.PerformLayout();
            this.a_groupBox1.ResumeLayout(false);
            this.a_groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availability_grid_area)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel a_panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox a_groupBox1;
        private System.Windows.Forms.Button availability_check_btn;
        private System.Windows.Forms.TextBox id_of_the_book_textfield;
        private System.Windows.Forms.Label id_of_the_book;
        private System.Windows.Forms.DataGridView availability_grid_area;
    }
}