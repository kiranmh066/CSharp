using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_training
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int[] arr = new int[4];
            
            int[] arr2 = { 3, 2, 4, 5 };

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(" " + arr2[i]);
            }


            /*Employee employeeObj = new Employee();
            employeeObj.CreateEmployee();*/

            /*Nokia nokiaObj = new Nokia();
            nokiaObj.Year = 2002;
            nokiaObj.Model = "123";
            nokiaObj.NokiaConfig();

            Samsung samsungObj = new Samsung();
            samsungObj.Year = 2003;
            samsungObj.Model = "342";
*/
            //Mobile mobileObj = new Mobile(); 

            /* Employee employeeObj = new Employee();
             employeeObj.Firstname = "Kiran";
             employeeObj.CreateEmployee();
             employeeObj.UpdateEmployee();
             employeeObj.GetEmployeeDetails();
             employeeObj.SearchEmployee(11);
             employeeObj.SearchEmployee("Raj");*/

            /*int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a+ b;
            Console.Write("output:"+ c);
            Console.Write("Completed");*/


            /*            for(int i = 0; i < 4; i++)
                          {}*/
            Console.Read();
        }
    }
}
