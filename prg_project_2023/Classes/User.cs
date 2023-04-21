using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace prg_project_2023.Classes
{
    public class User
    {
        public int Id { get; }
        public string Username { get; }
        public string Password { get; }
        public string Role { get; set; }

        public User(int id, string username, string password, string role)
        {
            Id = id;
            Username = username;
            Password = password;
            Role = role;
        }

        public ListViewItem ToListViewItem()
        {
            return new ListViewItem(new string[] { Id.ToString(), Username, Role });
        }
    }
}
