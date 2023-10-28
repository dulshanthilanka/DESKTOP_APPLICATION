using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Form1 : Form
    {
        public static Form1 Instance;
        public Form1()
        {
            Instance = this;
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
             this.Close();
        }

        private void addbook_Click(object sender, EventArgs e)
        {
            
        }

        private void check_book_availability_Click(object sender, EventArgs e)
        {
            availability availabilityinfo = new availability();
            availabilityinfo.Show();
        }

        private void addbook_Click_1(object sender, EventArgs e)
        {
            addbook addbookinfo = new addbook();
            addbookinfo.Show();
        }

        private void register_member_Click(object sender, EventArgs e)
        {
            register_member register_Memberinfo = new register_member();
            register_Memberinfo.Show();
        }

        private void borrow_book_Click(object sender, EventArgs e)
        {
            borrowbook borrowbookinfo = new borrowbook();
            borrowbookinfo.Show();
        }

        private void return_book_Click(object sender, EventArgs e)
        {
            @return returninfo = new @return();
            returninfo.Show();
        }

        private void reserve_book_Click(object sender, EventArgs e)
        {
            reserve reserveinfo = new reserve();
            reserveinfo.Show();
        }
    }
}
