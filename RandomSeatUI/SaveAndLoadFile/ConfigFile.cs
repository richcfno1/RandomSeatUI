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
    class ConfigFile
    {
        public int row
        {
            get; set;
        }
        public List<int> col
        {
            get; set;
        }
        public List<string> students
        {
            get; set;
        }

        public ConfigFile()
        {
            row = 0;
            col = new List<int>();
            students = new List<string>();

        }
        public ConfigFile(SeatList inputSeatList, StudentList inputStudentList)
        {
            row = inputSeatList.row;
            col = inputSeatList.col;
            students = new List<string>();
            foreach (Student i in inputStudentList.students)
                students.Add(i.name);
        }

        public void SaveToFile(string path)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(this));
        }

        public void LoadFromFile(string path)
        {
            ConfigFile temp = JsonConvert.DeserializeObject<ConfigFile>(File.ReadAllText(path));
            row = temp.row;
            col = temp.col;
            students = temp.students;
        }
    }
}
