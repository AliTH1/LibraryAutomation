using System.Collections;
using LibraryAutomation.Model;
using Microsoft.VisualBasic.ApplicationServices;


namespace LibraryAutomation
{
    public partial class Form1 : Form
    {
        List<Users> users = new List<Users>();
        List<Books> books = new List<Books>();

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
                    Admin admin = new Admin(users, books);
                    admin.Show();
                    Hide();
                    control = true;
                    break;
                }
                else if (username.ToLower() == user.getUsername() && password.ToLower() == user.getPassword()
                    && user.getAuthority() == "member")
                {
                    Member member = new Member(books);
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


            books.Add(new Books(1, "Kimyayı-Saadet", "İmam Qazali", "Türkçe", "Çınar Evi", "Din", 50, 650, 2021));
            books.Add(new Books(2, "İblisin Bəşəriyyət üçün planı", "Abid Qafarov", "Azərbaycanca", "BBT", "Din", 100, 25, 2020));
            books.Add(new Books(3, "Riyazus-Salihin", "İmam Nəvəvi", "Türkçe", "Yayın Evi", "Din", 20, 1200, 2022));
            books.Add(new Books(4, "Adap Risalesi", "Öncü Nesil", "Türkçe", "Pınar Evi", "Din", 10, 100, 2019));
            books.Add(new Books(5, "Peygamberliğin ispatı", "Cem Meriç", "Türkçe", "İnsan", "Din", 10, 650, 2022));
            //books.Add(new Books(6, "İlmihal", "Ömer Nasuhi", "Türkçe", "Çınar Evi", "Din", 150, 360, 2018));
        }
    }
}