using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementSystemData;
using HospitalManagementSystemEntity;
using HospitalManagementSystemBLL;

namespace HospitalManagementSystem
{
    public class DoctorPL
    {
        public void AdminDoctorSectionPL()
        {
            Console.WriteLine("This is Admin-Doctor Section: \n" +
                "Press 1 to Add Doctor \n" +
                "Press 2 to Update Doctor \n" +
                "Press 3 to Delete Doctor \n" +
                "Press 4 to Show all Doctor \n" +
                "Press 5 to Exit :)");

            int enter =Convert.ToInt32(Console.ReadLine());
            DoctorPL doctorPLObj = new DoctorPL();

            switch(enter)
            {
                case 1:doctorPLObj.AddDoctorPL(); //Adding Doctor;
                    break;
                case 2: doctorPLObj.UpdateDoctorPL();  //Upadting Doctor;
                    break;
                case 3: doctorPLObj.DeleteDoctorPL();  //Deleting Doctor;
                    break;
                case 4: doctorPLObj.ShowAllDoctorPL();  //Showing all doctor;
                    break;
                default: Console.WriteLine("Better luck Next Time");
                    break;
            }
        }

        public void AddDoctorPL()
        {
            DoctorDAL doctorDALObj = new DoctorDAL();

            Console.WriteLine("Adding the Doctor: :)");
            Console.WriteLine("Enter DoctorId: ");
            int doctorId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter DoctorName: ");
            string doctorName = Console.ReadLine();

            Console.WriteLine("Enter DoctorEmail: ");
            string doctorEmail = Console.ReadLine();

            Console.WriteLine("Enter DoctorPassword: ");
            string doctorPassword = Console.ReadLine();

            Doctor doctorObj = new Doctor(doctorId,doctorName,doctorEmail, doctorPassword);

            DoctorBLL doctorBLLObj = new DoctorBLL();

            //doctorDALObj.AddDoctorDAL(doctorObj);

            bool flag = doctorBLLObj.AddDoctorBLL(doctorObj);
            if(flag)
            {
                Console.WriteLine("Doctor Added Suucessfully... :)");
            }
            else
            {
                Console.WriteLine("Can't Insert");
            }

        }
        public void UpdateDoctorPL()
        {
            DoctorDAL doctorDALObj = new DoctorDAL();

            Console.WriteLine("Enter Doctor Details to Update :)");
            Console.WriteLine("Enter DoctorId: ");
            int doctorId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter DoctorName: ");
            string doctorName = Console.ReadLine();

            Console.WriteLine("Enter DoctorEmail: ");
            string doctorEmail = Console.ReadLine();

            Console.WriteLine("Enter DoctorPassword: ");
            string doctorPassword = Console.ReadLine();

            Doctor doctorObj = new Doctor(doctorId, doctorName, doctorEmail, doctorPassword);
            //string msg = doctorDALObj.UpadateDoctorDAl(doctorObj);

            DoctorBLL doctorBLLObj =new DoctorBLL();

            string flag = doctorBLLObj.UpdateDoctorBLL(doctorObj);
            if (flag== "Updated")
            {
                Console.WriteLine("Update Successfully...");
            }
            else
            {
                Console.WriteLine("Can't Update");
            }

        }

        public void DeleteDoctorPL()
        {
            Console.WriteLine("Deleting Doctor Details");
            Console.WriteLine("Enter DoctorId: ");
            int doctorId = Convert.ToInt32(Console.ReadLine());

            //DoctorDAL doctorDALObj = new DoctorDAL();
            

            DoctorBLL doctorBLLObj = new DoctorBLL();
            string msg = doctorBLLObj.DeleteDoctorBLL(doctorId);

            if (msg =="Deleted" )
            {
                Console.WriteLine("User Deleted Succesfully");
            }
            else
            {
                Console.WriteLine("Can't Delete");
            }
            
        }

        public void ShowAllDoctorPL()
        {
            DoctorBLL doctorBLLLObj = new DoctorBLL();
            //doctorDALObj.ShowAllDoctorDAL();

            List<Doctor> doctorPLList;
            doctorPLList=doctorBLLLObj.ShowAllDoctorBLL();

            foreach (var items in doctorPLList)
            {
                Console.WriteLine(items.DoctorId + " " + items.DoctorName + " " + items.DoctorEmail + " " + items.DoctorPassword);

            }
            Console.Read();
        }
    }
}
