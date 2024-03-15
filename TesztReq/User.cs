using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesztReq
{
    public class User
    {
        public int Id { get; private set; }
        public string Email { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Avatar { get; set; }

        public User(int id, string email, string firstName, string lastName, string avatar)
        {
            Id = id;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            Avatar = avatar;
        }
    }
}
