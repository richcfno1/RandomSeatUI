using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using RandomSeat;
using Newtonsoft.Json;


namespace RandomSeatUI.SaveAndLoadFile
{
    class TableResultFile
    {
        public List<string> students
        {
            get; set;
        }

        public TableResultFile()
        {
            students = new List<string>();
        }

        public TableResultFile(SeatList inputSeatList)
        {
            students = new List<string>();
            Seat temp = inputSeatList.head;
            while(temp != null)
            {
                if(temp.stu == null)
                {
                    return;
                }
                students.Add(temp.stu.name);
                temp = temp.next;
            }
        }

        public void SaveToFile(string path)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(this));
        }

        public void LoadFromFile(string path)
        {
            TableResultFile temp = JsonConvert.DeserializeObject<TableResultFile>(File.ReadAllText(path));
            students = temp.students;
        }
    }
}
