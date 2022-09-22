using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementEntity
{
    public class User
    {
        public string UserEmail { get; set; }

        public int UserId { get; set; }

        public string UserName { get; set; }

        public string UserPassword { get; set; }


        public User()
        {

        }

       /* public User(string userEmail,int userId,string userName,string userPassword)
        {
            this.UserEmail = userEmail;
            this.UserId = userId;
            this.UserName = userName;
            this.UserPassword = userPassword;
        }*/
    }
}
