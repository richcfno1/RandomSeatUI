using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RandomSeat
{
    class SeatList
    {
        private int size
        {
            get; set;
        }
        public int row
        {
            get; set;
        }
        public List<int> col
        {
            get; set;
        }
        public Seat head
        {
            get; set;
        }

        public SeatList(int newRow, int[] newCol)
        {
            col = new List<int>();
            if (newRow != newCol.Length)
                throw new Exception("Length Error");
            row = newRow;
            for (int i = 0; i < row; i++)
            {
                col.Add(newCol[i]);
            }
            
            head = null;
            Seat prev = null;
            for (int i = 0; i < updateSize(); i++)
            {
                Seat temp = new Seat(prev);
                if (i == 0)
                    head = temp;
                if (prev != null)
                    prev.next = temp;
                prev = temp;
            }
        }

        public SeatList(int newRow, int[] newCol, Seat newHead)
        {
            col = new List<int>();
            if (newRow != newCol.Length)
                throw new Exception("Length Error");
            row = newRow;
            for (int i = 0; i < row; i++)
            {
                col.Add(newCol[i]);
            }
            head = newHead;
            updateSize();
        }

        public int getLargestCol()
        {
            int max = 0;
            foreach (int i in col)
                max = Math.Max(max, i);
            return max;
        }

        public int updateSize()
        {
            size = 0;
            foreach(int i in col)
            {
                size += i;
            }
            return size;
        }

        public Seat getTail()
        {
            Seat temp = head;
            while (temp.next != null)
                temp = temp.next;
            return temp;
        }

        public Seat getRowHead(int targetRow)
        {
            Seat temp = head;
            int sum = 0;
            for (int i = 0; i < targetRow - 1; i++)
                sum += col[i];
            for (int i = 0; i < sum; i++)
                temp = temp.next;
            return temp;
        }

        public Seat getRowTail(int targetRow)
        {
            Seat temp = head;
            int sum = 0;
            for (int i = 0; i < targetRow; i++)
                sum += col[i];
            for (int i = 0; i < sum - 1; i++)
                temp = temp.next;
            return temp;
        }

        public StudentList getStudentListFromSeatList()
        {
            List<Student> temp = new List<Student>();
            if (head == null)
                throw new Exception("Uninnitialize");
            temp.Add(head.stu);
            Seat i = head;
            while (i.next != null)
            {
                i = i.next;
                temp.Add(i.stu);
            }
            return new StudentList(temp);
        }

        public void nonrandomSortAllStudents(StudentList usedStudentList)
        {
            updateSize();
            if (usedStudentList.students.Count != size)
                throw new Exception("Size miss matched");
            usedStudentList.resetAllUnused();
            Seat i = head;
            int k = 0;
            foreach (int r in col)
            {
                for (int j = 0; j < r; j++)
                {
                    i.stu = usedStudentList.students[k];
                    i = i.next;
                    k++;
                }
            }
        }

        public void randomSortAllStudents(StudentList usedStudentList = null)
        {
            if(usedStudentList == null)
                usedStudentList = getStudentListFromSeatList();
            updateSize();
            if (usedStudentList.students.Count != size)
                throw new Exception("Size miss matched");
            usedStudentList.resetAllUnused();
            Seat i = head;
            foreach(int r in col)
            {
                for(int j = 0; j < r; j++)
                {
                    i.stu = usedStudentList.retrieveOneRandomUnused();
                    i = i.next;
                }
            }
        }

        public void randomSortAllStudentsWithExchange()
        {
            StudentList temp = getStudentListFromSeatList();
            updateSize();
            if (temp.students.Count != size)
                throw new Exception("Size miss matched");
            temp.resetAllUnused();

            StudentList front = StudentList.getHalf(temp, false);
            StudentList back = StudentList.getHalf(temp, true);

            Seat i = head;
            int frontIndex = 0;
            int backIndex = 0;
            foreach (int r in col)
            {
                for (int j = 0; j < r; j++)
                {
                    if (frontIndex < front.students.Count)
                    {
                        i.stu = front.retrieveOneRandomUnused();
                        i = i.next;
                        frontIndex++;
                    }
                    else
                    {
                        i.stu = back.retrieveOneRandomUnused();
                        i = i.next;
                        backIndex++;
                    }
                    
                }
            }
        }

        public override string ToString()
        {
            string result = "FRONT:\n";
            Seat i = head;
            foreach (int r in col)
            {
                for (int j = 0; j < r; j++)
                {
                    result += i.stu.name + ",";
                    i = i.next;
                }
                result += "\n";
            }
            return result;
        }
    }
}
