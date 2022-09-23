using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystemEntity
{
    public class Admin
    {
        public string AdminEmail { get; set; }

        public int AdminId { get; set; }

        public string AdminName { get; set; }

        public string AdminPassword { get; set; }

        public Admin(string adminEmail, int adminId, string adminName, string adminPassword)
        {
            AdminEmail = adminEmail;
            AdminId = adminId;
            AdminName = adminName;
            AdminPassword = adminPassword;
        }
    }
}
