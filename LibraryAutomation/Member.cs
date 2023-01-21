using LibraryAutomation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAutomation
{
    public partial class Member : Form
    {
        List<Books> books;
        public Member(List<Books> books)
        {
            InitializeComponent();
            this.books = books;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();

            Hide();
        }

        private void Member_Load(object sender, EventArgs e)
        {
            foreach(Books book in books)
            {
                dataGridView1.Rows.Add(book.getBookId(), book.getBookName(), book.getBookAuthor(), book.getBookLanguage(),
                    book.getBookPublishingHouse(), book.getBookType(), book.getBookPiece(), book.getBookPages(),
                    book.getBookYearOfRelease());
            }
        }
    }
}
