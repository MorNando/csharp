using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLearning
{
    class Person
    {
        public DateTime DateOfBirth { get; private set; }

        public Person(DateTime dateOfBirth)
        {
            DateOfBirth = dateOfBirth;
        }

        public int Age
        {
            get
            {
                TimeSpan diff = DateTime.Now - DateOfBirth;
                int age = diff.Days / 365;
                return age;
            }
        }
    }
}
