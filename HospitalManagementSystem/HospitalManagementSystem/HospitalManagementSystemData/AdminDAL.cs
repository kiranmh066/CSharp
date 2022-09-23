using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementSystemEntity;

namespace HospitalManagementSystemData
{
    public class AdminDAL
    {
        public List<Admin> admins = new List<Admin>();

        Admin adminObj1 = new Admin("kiran", 123, "kiran", "123");

        Admin adminObj2 = new Admin("chandan", 789, "chandan", "123");

        //adminObj.AdminEmail="k@g.com";
        //Admin.Add(adminObj);



        public List<Admin> GetAllAdminsDAL()
        {
            admins.Add(adminObj1);
            admins.Add(adminObj2);
            return admins;
        }
    }
}
