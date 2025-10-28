using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_an_cuoi_ki_dau_tto
{
    internal class User
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public User() { }
        public User(string iD, string name, string email, string password)
        {
            ID = iD;
            Name = name;
            Email = email;
            Password = password;
        }
        public bool CheckPassWord(string password)
        {
            return password == Password;
        }
        public void Role(string password)
        {
            if(CheckPassWord(password))
            {

            }
        }
        public void AddUser(User user)
        {
            UserStorage userStorage = new UserStorage();
            List<User> users = new List<User>();
            users.Add(user);
            UserStorage.SaveToFile(users, "file.dat");
        }
    }
}
