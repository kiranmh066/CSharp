using System;
using System.Collections.Generic;
using System.Text;

namespace LinqAssignment1
{
    public class Person
    {
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        //override ToString to return the person's FirstName LastName Age
    }
}
