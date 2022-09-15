using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_training
{
    public class Employee
    {
        public int Id { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Email { get; set; }

        public double Mobile { get; set; }

        public void CreateEmployee()
        {
            int[] arr = new int[3];
            string[] arrs= new string[3];

            int[] arr2 = { 3, 2, 4, 5};


            for (int i = 0; i < arrs.Length; i++)
            {
                Console.Write("Enter Id:");
                arr[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter name:");
                arrs[i] = Console.ReadLine();

            }




           /* Console.Write("Enter ID:");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Firstname:");
            Firstname = Console.ReadLine();

            Console.Write("Enter Lastname:");
            Lastname = Console.ReadLine();

            Console.Write("Enter Email:");
            Email = Console.ReadLine();

            Console.Write("Enter Mobile:");
            Mobile = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**************");
            Console.WriteLine("Created....");
            Console.WriteLine("Employee Details: " + Id + "," + Firstname + ","
                + Lastname + "," + Email + "," + Mobile);*/

        }

        /*public void UpdateEmployee()
        {
            Id = 11;
            Firstname = "Raj";
            Lastname = "Kumar";
            Email = "raj@kar.com";
            Mobile = 9066370947;
            Console.WriteLine("**************");
            Console.WriteLine("Updated....");
        }
        public void GetEmployeeDetails()
        {

            Console.WriteLine("**************");
            Console.WriteLine("Reading....");
            Console.WriteLine("Employee Details: " + Id + "," + Firstname + ","
               + Lastname + "," + Email + "," + Mobile);
        }

        public void SearchEmployee(int id)
        {
            if (Id == 11)
            {
                Console.WriteLine("**************");
                Console.WriteLine("Employee Details: " + Id + "," + Firstname + ","
                   + Lastname + "," + Email + "," + Mobile);
            }
        }
        public void SearchEmployee(string name)
        {
            if (name == "Raj")
            {
                Console.WriteLine("**************");
                Console.WriteLine("Reading....");
                Console.WriteLine("Employee Details: " + Id + "," + Firstname + ","
                   + Lastname + "," + Email + "," + Mobile);
            }
        }*/
    }
}
