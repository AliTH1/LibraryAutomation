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
            Hide();
            MessageBox.Show("Вы вышли из аккаунта", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form1 login_page = new Form1();
            login_page.Show();
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

        private void btn_search_Click(object sender, EventArgs e)
        {
            Books target_book = null;

            int selected_book_id = Convert.ToInt32(txtBox_search.Text);

            foreach(Books book in books)
            {
                if(book.getBookId() == selected_book_id)
                {
                    target_book = book;
                    break;
                }
            }

            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(target_book.getBookId(), target_book.getBookName(), target_book.getBookAuthor(),
                target_book.getBookLanguage(), target_book.getBookPublishingHouse(), target_book.getBookType(),
                target_book.getBookPiece(), target_book.getBookPages(), target_book.getBookYearOfRelease());
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            foreach(Books book in books)
            {
                dataGridView1.Rows.Add(book.getBookId(), book.getBookName(), book.getBookAuthor(), book.getBookLanguage(),
                    book.getBookPublishingHouse(), book.getBookType(), book.getBookPiece(), book.getBookPages(),
                    book.getBookYearOfRelease());
            }
        }
    }
}
