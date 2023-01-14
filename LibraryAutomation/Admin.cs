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
        public Admin(List<Users> users)
        {
            InitializeComponent();
            this.users = users;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            foreach(Users user in users)
            {
                dataGridView_members.Rows.Add(user.id, user.name, user.surname, user.created_data,
                    user.username, user.password, user.authority);
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
    }
}
