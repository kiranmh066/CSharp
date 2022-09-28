using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqAssignment1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>()
            {
            new Person("Bill", "Smith", 41),
            new Person("Sarah", "Jones", 22),
            new Person("Stacy","Baker", 21),
            new Person("Vivianne","Dexter", 19 ),
            new Person("Bob","Smith", 49 ),
            new Person("Brett","Baker", 51 ),
            new Person("Mark","Parker", 19),
            new Person("Alice","Thompson", 18),
            new Person("Evelyn","Thompson", 58 ),
            new Person("Mort","Martin", 58),
            new Person("Eugene","deLauter", 84 ),
            new Person("Gail","Dawson", 19 ),
            };
            //1
            #region write linq statement for people with last name that starts with the letter D
            PersonDAL personDALObj = new PersonDAL();
            List<Person> personList = personDALObj.LastNameDAL(people);
            Console.WriteLine("FirstName:           LastName: ");
            foreach (var item in personList)
            {
                Console.WriteLine(item.FirstName    +"          "+item.LastName);
            }
            #endregion

            //2
            #region write a linq statement for people with last names that starts with the letter D and displays the count.	
            Console.WriteLine("write a linq statement for people with last names that starts with the letter D and displays the count");
            int count = personDALObj.LastNameCountDAL(people);
            Console.WriteLine("Final Count is: "+count);
            #endregion


            //3
            #region Write linq statement for first Person Older Than 40 In Descending Alphabetical Order By First Name
            Console.WriteLine("\n Write linq statement for first Person Older Than 40 In Descending Alphabetical Order By First Name: ");
            List<Person> personList3=new List<Person>();
            personList3 = personDALObj.OldPersonDAL(people);
            Console.WriteLine("FirstName:           LastName:           Age:");
            foreach (var item in personList)
            {
                Console.WriteLine(item.FirstName + "          " + item.LastName+"           "+item.Age);
            }
            #endregion

            //4
            #region Write linq statement for people’s full name(concat firstname and last name)
            Console.WriteLine("\n write linq statement for people’s full name(concat firstname and last name)");
            List<String> personList4 = new List<String>();
            personList4 = personDALObj.ConcatePersonDAL(people);
            Console.WriteLine("FirstName:           LastName:");
            foreach (var item in personList)
            {
                Console.WriteLine(item.FirstName +""+ item.LastName);
            }

            #endregion  

            //5
            #region 1.Most frequent character
            Console.WriteLine("1/9.Most frequent character \n Enter:");
            string enter5=Console.ReadLine();
            
            personDALObj.MostCharDAL(enter5);
            #endregion

            //6
            #region 2.Find out Unique values

            Console.WriteLine("2/9.Find out Unique values");
            List<string> words=new List<string>() { "abc", "xyz", "klm", "xyz", "abc", "abc", "rst" };

            List<string> uniquewords = personDALObj.UniqueStringsDAL(words);
            foreach (var item in uniquewords)
            {
                Console.WriteLine(item);
            }
            #endregion

            //7
            #region 3.Top 5 numbers
            Console.WriteLine("3/9. Top 5 numbers");
            List<int> numbers = new List<int>() {78,-9,0,23,54,21,7,86};

            List<int> topNumber = personDALObj.TopNumbersDAL(numbers);
            foreach (var item in topNumber)
            {
                Console.WriteLine(item);
            }
            #endregion

            //8
            #region 4. Find the words in the collection that start with the letter 'L'
            Console.WriteLine("4/9. Find the words in the collection that start with the letter 'L'");
            
            List<string> fruits = new List<string>() {"Lemon","Apple","Orange","Lime","Watermelon","Loganberry"};

            List<string> startsL=personDALObj.StartsWithLDAL(fruits);
            foreach (var item in startsL)
            {
                Console.WriteLine(item);
            }

            #endregion

            //9
            #region 5. Which of the following numbers are multiples of 4 or 6
            Console.WriteLine("5/9. Which of the following numbers are multiples of 4 or 6");
            
            List<int> mixedNumbers = new List<int>() {15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96};

            List<int> MultiplesOf46 = personDALObj.MultipleDAL(mixedNumbers);
            foreach (var item in MultiplesOf46)
            {
                Console.WriteLine(item);
            }
            #endregion

            //10
            #region 6.Output how many numbers are in this list
            Console.WriteLine("6/9. Output how many numbers are in this list ");
            List<int> numbersList = new List<int>(){15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96};

            int total=numbersList.Count();
            Console.WriteLine("Count of Numbers:  "+total);
            #endregion

            //11
            #region 7. How much money have we made?
            Console.WriteLine("7/9. How much money have we made?");
            List<double> purchases = new List<double>(){2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65};

            double sum=purchases.Sum();
            Console.WriteLine("Sum is: "+sum);
            #endregion

            //12
            #region 8. What is our most expensive product?
            Console.WriteLine("8/9 What is our most expensive product?");
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };

            double high=prices.Max();
            Console.WriteLine("Maximum : " + high);
            #endregion

            //13
            #region 9.Given the same customer set, display how many millionaires per bank
            Console.WriteLine("9/10. Given the same customer set, display how many millionaires per bank");

            List<Customer> customersList = new List<Customer>() {
                new Customer( "Bob Lesman", 80345.66, "FTB"),
                new Customer("Joe Landy", 9284756.21, "WF"),
                new Customer( "Meg Ford", 487233.01, "BOA"),
                new Customer("Peg Vale", 7001449.92, "BOA"),
                new Customer("Mike Johnson", 790872.12, "WF"),
                new Customer("Les Paul", 8374892.54, "WF"),
                new Customer( "Sid Crosby", 957436.39, "FTB"),
                new Customer("Sarah Ng", 56562389.85, "FTB"),
                new Customer( "Tina Fey", 1000000.00, "CITI"),
                new Customer("Sid Brown", 49582.68, "CITI")
            };

            List<Customer> customersList2 = personDALObj.MillionDAL(customersList);
            foreach (var item in customersList2)
            {
                Console.WriteLine(item.Name+"--"+item.Balance+"--"+item.Bank);
            }
            #endregion

            //14
            #region 10.	Display Top 3 customers per bank.
            Console.WriteLine("10/10. Display Top 3 customers per bank.");

            List<Customer> customersList3 = personDALObj.MillionDAL(customersList);
            foreach (var item in customersList3)
            {
                Console.WriteLine(item.Name + "--" + item.Balance + "--" + item.Bank);
            }
            #endregion


        }



    }
}