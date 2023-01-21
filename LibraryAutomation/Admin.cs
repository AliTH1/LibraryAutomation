using LibraryAutomation.Model;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Admin : Form
    {
        List<Users> users;
        List<Books> books;
        public Admin(List<Users> users, List<Books> books)
        {
            InitializeComponent();
            this.users = users;
            this.books = books;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            foreach(Users user in users)
            {
                dataGridView_members.Rows.Add(user.id, user.name, user.surname, user.created_data,
                    user.username, user.password, user.authority);
            }

            foreach (Books book in books)
            {
                dataGridView_Books.Rows.Add(book.getBookId(), book.getBookName(), book.getBookAuthor(), book.getBookLanguage(),
                    book.getBookPublishingHouse(), book.getBookType(), book.getBookPiece(), book.getBookPages(),
                    book.getBookYearOfRelease());
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            dataGridView_members.Rows.Add(Convert.ToInt32(txtBox_id.Text), txtBox_name.Text, txtBox_surname.Text,
                maskTxtBox_created_data.Text, txtBox_username.Text, txtBox_password.Text, txtBox_authority.Text);
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            dataGridView_members.Rows.Remove(dataGridView_members.CurrentRow);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            dataGridView_members.Rows.Remove(dataGridView_members.CurrentRow);
            dataGridView_members.Rows.Add(Convert.ToInt32(txtBox_id.Text), txtBox_name.Text, txtBox_surname.Text,
                maskTxtBox_created_data.Text, txtBox_username.Text, txtBox_password.Text, txtBox_authority.Text);
        }

        private void dataGridView_members_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBox_id.Text = dataGridView_members.CurrentRow.Cells[0].Value.ToString();
            txtBox_name.Text = dataGridView_members.CurrentRow.Cells[1].Value.ToString();
            txtBox_surname.Text = dataGridView_members.CurrentRow.Cells[2].Value.ToString();
            maskTxtBox_created_data.Text = dataGridView_members.CurrentRow.Cells[3].Value.ToString();
            txtBox_username.Text = dataGridView_members.CurrentRow.Cells[4].Value.ToString();
            txtBox_password.Text = dataGridView_members.CurrentRow.Cells[5].Value.ToString();
            txtBox_authority.Text = dataGridView_members.CurrentRow.Cells[6].Value.ToString();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox_member_transactions.Controls.Count; i++)
            {
                if (groupBox_member_transactions.Controls[i] is TextBox 
                    || groupBox_member_transactions.Controls[i] is MaskedTextBox)
                {
                    groupBox_member_transactions.Controls[i].Text = string.Empty;
                }
            }
        }

        private void btn_BookAdd_Click(object sender, EventArgs e)
        {
            dataGridView_Books.Rows.Add(Convert.ToInt32(txtBox_BookId.Text), txtBox_BookName.Text, txtBox_BookAuthor.Text, txtBox_BookLanguage.Text,
                txtBox_BookPublishingHouse.Text, txtBox_BookType.Text, Convert.ToInt32(txtBox_BookPieces.Text), Convert.ToInt32(txtBox_BookPages.Text),
                Convert.ToInt32(txtBox_BookYearOfRelease.Text));
        }

        private void btn_BookRemove_Click(object sender, EventArgs e)
        {
            dataGridView_Books.Rows.Remove(dataGridView_members.CurrentRow);
        }

        private void btn_BookUpdate_Click(object sender, EventArgs e)
        {
            dataGridView_Books.Rows.Remove(dataGridView_Books.CurrentRow);
            dataGridView_Books.Rows.Add(Convert.ToInt32(txtBox_BookId.Text), txtBox_BookName.Text, txtBox_BookAuthor.Text, txtBox_BookLanguage.Text,
                txtBox_BookPublishingHouse.Text, txtBox_BookType.Text, Convert.ToInt32(txtBox_BookPieces.Text), Convert.ToInt32(txtBox_BookPages.Text),
                Convert.ToInt32(txtBox_BookYearOfRelease.Text));
        }

        private void btn_BookClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox_BookTransactions.Controls.Count; i++)
            {
                if (groupBox_member_transactions.Controls[i] is TextBox)
                {
                    groupBox_member_transactions.Controls[i].Text = string.Empty;
                }
            }
        }

        private void dataGridView_Books_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBox_BookId.Text = dataGridView_Books.CurrentRow.Cells[0].Value.ToString();
            txtBox_BookName.Text = dataGridView_Books.CurrentRow.Cells[1].Value.ToString();
            txtBox_BookAuthor.Text = dataGridView_Books.CurrentRow.Cells[2].Value.ToString();
            txtBox_BookLanguage.Text = dataGridView_Books.CurrentRow.Cells[3].Value.ToString();
            txtBox_BookPublishingHouse.Text = dataGridView_Books.CurrentRow.Cells[4].Value.ToString();
            txtBox_BookType.Text = dataGridView_Books.CurrentRow.Cells[5].Value.ToString();
            txtBox_BookPieces.Text = dataGridView_Books.CurrentRow.Cells[6].Value.ToString();
            txtBox_BookPages.Text = dataGridView_Books.CurrentRow.Cells[7].Value.ToString();
            txtBox_BookYearOfRelease.Text = dataGridView_Books.CurrentRow.Cells[8].Value.ToString();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Users target_user = null;

            int selected_user_id = Convert.ToInt32(txtBox_search_members.Text);

            foreach(Users user in users)
            {
                if(user.getId() == selected_user_id)
                {
                    target_user = user;
                    break;
                }
            }

            dataGridView_members.Rows.Clear();
            dataGridView_members.Rows.Add(target_user.getId(), target_user.getName(), target_user.getSurname(),
                target_user.getCreatedData(), target_user.getUsername(), target_user.getPassword(), target_user.getAuthority());
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dataGridView_members.Rows.Clear();

            foreach (Users user in users)
            {
                dataGridView_members.Rows.Add(user.id, user.name, user.surname, user.created_data,
                    user.username, user.password, user.authority);
            }

        }

        private void btn_search_books_Click(object sender, EventArgs e)
        {
            Books target_book = null;

            int selected_book_id = Convert.ToInt32(txtBox_search_books.Text);

            foreach(Books book in books)
            {
                if(book.getBookId() == selected_book_id)
                {
                    target_book = book;
                    break;
                }
            }

            dataGridView_Books.Rows.Clear();
            dataGridView_Books.Rows.Add(target_book.getBookId(), target_book.getBookName(), target_book.getBookAuthor(),
                target_book.getBookLanguage(), target_book.getBookPublishingHouse(), target_book.getBookType(),
                target_book.getBookPiece(), target_book.getBookPages(), target_book.getBookYearOfRelease());
        }

        private void btn_refresh_books_Click(object sender, EventArgs e)
        {
            dataGridView_Books.Rows.Clear();

            foreach (Books book in books)
            {
                dataGridView_Books.Rows.Add(book.getBookId(), book.getBookName(), book.getBookAuthor(), book.getBookLanguage(),
                book.getBookPublishingHouse(), book.getBookType(), book.getBookPiece(), book.getBookPages(),
                book.getBookYearOfRelease());
            }
        }
    }
}