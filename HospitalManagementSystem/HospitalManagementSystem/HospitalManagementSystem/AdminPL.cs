using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementSystemBLL;

namespace HospitalManagementSystem
{
    public class AdminPL
    {
        public void AdminMenu()
        {
            Console.WriteLine("Welcome to Hospital Management System :) \n"+
                "Press 1 to login as Admin \n"+
                "Press 2 to login as Doctor \n" +
                "Press 3 to login as Patient \n"+
                "Prees 4 to Exit "
                );
            int enter = Convert.ToInt32(Console.ReadLine());

            AdminPL adminPLObj = new AdminPL();


            switch (enter)
            {
                case 1:adminPLObj.AdminLoginPL();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default: Console.WriteLine("Better luck next time");
                    break;
            }



        }
        public void AdminLoginPL()
        {
            AdminPL adminPLObj = new AdminPL();

            Console.WriteLine("Welcome to Admin Page :) \n" +
                "Enter Email: ");
            string email=Console.ReadLine();

            Console.WriteLine("Enter Password:  ");
            string password=Console.ReadLine();

            AdminBLL adminBLLObj = new AdminBLL();

            bool status = false;
            status=adminBLLObj.AdminLoginBLL(email, password);

            if(status)
            {
                Console.WriteLine("Login success");
                adminPLObj.AdminSectionPL();
            }
            else
            {
                Console.WriteLine("Invalid Credentials");
            }

            //adminBLLObj();



           
        }
        public void AdminSectionPL()
        {
            Console.WriteLine("This is Admin Section: \n"+
                "Press 1 for Admin-Doctor Section \n"+
                "Press 2 for Admin-Patient Section \n"+
                "Press 3 to Exit :) ");

            int enter = Convert.ToInt32(Console.ReadLine());

            DoctorPL doctorPLObj =new DoctorPL();
            
            switch(enter)
            {
                case 1:doctorPLObj.AdminDoctorSectionPL();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:Console.WriteLine("Better Luck Next Time :) ");
                    break;
            }
        }
    }
}
