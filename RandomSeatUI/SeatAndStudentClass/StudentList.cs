using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RandomSeat
{
    class StudentList
    {
        public List<Student> students
        {
            get; set;
        }

        public static StudentList getHalf(StudentList input, bool first = true)
        {
            List<Student> temp = new List<Student>();
            if (first)
                for (int i = 0; i < input.students.Count / 2; i++)
                    temp.Add(input.students[i]);
            else
                for (int i = input.students.Count / 2; i < input.students.Count; i++)
                    temp.Add(input.students[i]);
            return new StudentList(temp);
        }

        public static StudentList combineTwo(StudentList input1, StudentList input2)
        {
            List<Student> temp = new List<Student>();
            foreach (Student i in input1.students)
                temp.Add(i);
            foreach (Student i in input2.students)
                temp.Add(i);
            return new StudentList(temp);
        }

        public StudentList(List<Student> newStudents)
        {
            students = newStudents;
        }

        public StudentList(string[] newStudents)
        {
            students = new List<Student>();
            for (int i = 0; i < newStudents.Length; i++)
            {
                students.Add(new Student(newStudents[i]));
            }
        }

        public Student findStudent(string name)
        {
            foreach (Student i in students)
                if (name.Equals(i.name))
                    return i;
            return null;
        }

        public bool isUsed(string name)
        {
            foreach(Student i in students)
                if (name.Equals(i.name))
                    return i.used;
            throw new Exception("Invalid Name");
        }

        public void resetAllUnused()
        {
            foreach (Student i in students)
                i.used = false;
        }

        public List<Student> retrieveAllUnused()
        {
            List<Student> temp = new List<Student>();
            foreach (Student i in students)
                if (!i.used)
                    temp.Add(i);
            return temp;
        }

        public Student retrieveOneRandomUnused()
        {
            List<Student> temp = retrieveAllUnused();
            if (temp.Count == 0)
                return null;
            int i = new Random().Next(0, temp.Count);
            temp[i].used = true;
            return temp[i];
        }
    }
}
