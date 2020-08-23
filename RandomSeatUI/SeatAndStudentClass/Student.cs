using System;
using System.Collections.Generic;
using System.Text;

namespace RandomSeat
{
    class Student
    {
        public string name
        {
            get; set;
        }
        public bool used
        {
            get; set;
        }

        public Student(string newName)
        {
            name = newName;
            used = false;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
