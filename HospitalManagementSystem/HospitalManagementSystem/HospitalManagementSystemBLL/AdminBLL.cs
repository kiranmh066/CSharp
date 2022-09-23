using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementSystemData;
using HospitalManagementSystemEntity;

namespace HospitalManagementSystemBLL
{
    public class AdminBLL
    {
        public bool AdminLoginBLL(string adminEmail, string adminPassword)
        {
            AdminDAL adminDAL = new AdminDAL();
            List<Admin> admins = adminDAL.GetAllAdminsDAL();

            bool flag = false;

            foreach (var item in admins)
            {
                if (item.AdminEmail == adminEmail && item.AdminPassword == adminPassword)
                {
                    flag = true;
                }
            }
            return flag;
        }
    }
}
