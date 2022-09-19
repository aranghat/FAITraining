using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloMvc.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }

    public static class UserService
    {
        static List<User> users = new List<User>();

        static UserService()
        {
            users.Add(new User { UserName = "sree", Password = "12345" , Role = "Member" });
            users.Add(new User { UserName = "bill", Password = "12345" , Role = "Member" });
            users.Add(new User { UserName = "steve", Password = "12345", Role = "Admin" });
        }

        public static User Authenticate(string userName,string password)
        {
            return users.FirstOrDefault(d => d.UserName == userName && d.Password == password);
        }

        public static User FindById(string userName)
        {
            return users.FirstOrDefault(d => d.UserName == userName);
        }
    }
}