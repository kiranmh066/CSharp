using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace LinqAssignment1
{
    public class PersonDAL
    {
        //write linq statement for people with last name that starts with the letter D

        //1
        public List<Person> LastNameDAL(List<Person> people)
        {
            //Linq query- select * from movie where latname like 'D%'
            var result = from obj in people
                         where obj.LastName.StartsWith('D') || obj.LastName.StartsWith('d')
                         select  obj;
            List<Person> personResult = new List<Person>();
            foreach (var item in result) // Linq Query execution
            {
                personResult.Add(item);

            }
            return personResult;
        }
        //2
        public int LastNameCountDAL(List<Person> people)
        {
            int count = (from obj in people
                         where obj.LastName.StartsWith('D') || obj.LastName.StartsWith('d')
                         select obj).Count();

            //int count = (from n in items select n).Count();
            return count;
        }
        //3
        public List<Person> OldPersonDAL(List<Person> people2)
        {
            var result = from obj in people2
                         where obj.Age>40
                         select obj;

            List<Person> personResult = new List<Person>();
            foreach (var item in result) // Linq Query execution
            {
                personResult.Add(item);

            }
            return personResult;
        }
        //4
        public List<String> ConcatePersonDAL(List<Person> people3)
        {
            var result = from obj in people3
                         select obj.FirstName+""+obj.LastName;

            List<String> personResult = new List<String>();
            foreach (var item in result) // Linq Query execution
            {
                personResult.Add(item);

            }
            return personResult;
        }
        //5
        public void MostCharDAL(string enter5)
        {
            var result = (from c in enter5.ToCharArray()
                       group c by c into g
                       where g.Count() > 1
                       select g.Key);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            //return 'c';
        }
        //6
        public List<string> UniqueStringsDAL(List<string> words)
        {
            var result = (from obj1 in words
                          group obj1 by obj1 into grp
                          select new 
                          {
                              cnt = grp.Count(),
                              key = grp.Key 
                          });
            List<string> personResult = new List<string>();
            foreach (var item in result)//linq query execution
            {
                if (item.cnt == 1)
                    personResult.Add(item.key);
            }
            return personResult;
        }
        //7
        public List<int> TopNumbersDAL(List<int> numbers)
        {
            var result = (from obj1 in numbers
                          orderby obj1 descending
                          select obj1).Take(5);

            List<int> personResult = new List<int>();
            foreach (var item in result)
            {
                personResult.Add(item);
            }
            return personResult;
        }
        //8
        public List<string> StartsWithLDAL(List<string> fruits)
        {
            var result = from obj1 in fruits
                         where obj1.StartsWith('L')
                         select obj1;

            List<string> personResult = new List<string>();
            foreach (var item in result)
            {
                personResult.Add(item);
            }
            return personResult;
        }
        //9
        public List<int> MultipleDAL(List<int> mixNumbers)
        {
            var result = from obj1 in mixNumbers
                         where obj1%4==0 || obj1%6==0
                         select obj1;

            List<int> personResult = new List<int>();
            foreach (var item in result)
            {
                personResult.Add(item);
            }
            return personResult;
        }
        //10

        //11

        //12

        //13
        public List<Customer> MillionDAL(List<Customer> customersList)
        {
            var result = from obj1 in customersList
                         where obj1.Balance>=1000000
                         select obj1;

            List<Customer> custResult = new List<Customer>();
            foreach (var item in result)
            {
                custResult.Add(item);
            }
            return custResult;
        }

        //14
        public List<Customer> TopCustomersBank(List<Customer> customersList)
        {
            var result = from data2 in customersList
                         group data2.Balance by data2.Bank into grp
                         select new { max = grp.Max(), key = grp.Key };

            List<Customer> custResult = new List<Customer>();
            foreach (var item in result)
            {
                Console.WriteLine(item.max + "  " + item.key);
            }
            return custResult;
        }

    }
}
