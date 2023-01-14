using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomation.Model
{
    public class Users
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public DateTime created_data { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string authority { get; set; }

        public Users()
        {

        }

        public Users(int id, string name, string surname, DateTime created_data, string username
            , string password, string authority)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.created_data = created_data;
            this.username = username;
            this.password = password;
            this.authority = authority;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return id;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public void setSurname(string surname)
        {
            this.surname = surname;
        }

        public string getSurname()
        {
            return surname;
        }

        public void setCreatedData(DateTime created_data)
        {
            this.created_data = created_data;
        }

        public DateTime getCreatedData()
        {
            return created_data;
        }

        public void setUsername(string username)
        {
            this.username = username;
        }

        public string getUsername()
        {
            return username;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public string getPassword()
        {
            return password;
        }

        public void setAuthority(string authority)
        {
            this.authority = authority;
        }

        public string getAuthority()
        {
            return authority;
        }


        public override string ToString()
        {
            return "Name - Surname: " + name + " " + surname;
        }
    }
}
