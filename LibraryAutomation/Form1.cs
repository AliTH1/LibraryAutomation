using System.Collections;
using LibraryAutomation.Model;
using Microsoft.VisualBasic.ApplicationServices;


namespace LibraryAutomation
{
    public partial class Form1 : Form
    {
        List<Users> users = new List<Users>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username, password = "";

            username = txt_username.Text;
            password = txt_password.Text;

            bool control = false;

            foreach (Users user in users)
            {
                if(username.ToLower() == user.getUsername() && password.ToLower() == user.getPassword()
                    && user.getAuthority() == "admin")
                {
                    Admin admin = new Admin(users);
                    admin.Show();
                    Hide();
                    control = true;
                    break;
                }
                else if (username.ToLower() == user.getUsername() && password.ToLower() == user.getPassword()
                    && user.getAuthority() == "member")
                {
                    Member member = new Member();
                    member.Show();
                    Hide();
                    control = true;
                    break;
                }
            }

            if (!control)
            {
                MessageBox.Show("Произошла ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            users.Add(new Users(1, "Ali", "Taghizada", DateTime.Now, "ali", "ali123", "admin"));
            users.Add(new Users(2, "Enes", "Bayram", DateTime.Now, "enes", "enes123", "member"));
            users.Add(new Users(3, "Akbar", "Taghizada", DateTime.Now, "akbar", "akbar123", "member"));
            users.Add(new Users(4, "Taqit", "Taghiyev", DateTime.Now, "taqit", "taqit123", "member"));
        }
    }
}