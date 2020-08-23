using System;
using System.Collections.Generic;
using System.Text;

namespace RandomSeat
{
    class Seat
    {
        public Seat next
        {
            get; set;
        }
        public Student stu
        {
            get; set;
        }

        public Seat(Seat prev)
        {
            if (prev != null)
            {
                prev.next = this;
            }
            next = null;
            stu = null;
        }
    }
}
