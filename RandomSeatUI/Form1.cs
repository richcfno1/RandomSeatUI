using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using RandomSeat;
using RandomSeatUI.SaveAndLoadFile;

namespace RandomSeatUI
{
    public partial class Form1 : Form
    {
        private SeatList seats;
        private StudentList students;
        public Form1()
        {
            InitializeComponent();
            CleanTableWithFrontSign();
            int[] temp0 = { };
            seats = new SeatList(0, temp0, null);
            string[] temp1 = { };
            students = new StudentList(temp1);
        }

        public void CleanTableWithFrontSign()
        {
            seatTable.Controls.Clear();
            Label Temp = new Label();
            Temp.Text = "FRONT!!!";
            seatTable.Controls.Add(Temp, 0, 0);
        }

        public void SetInactiveSeat()
        {
            for (int i = 1; i < seatTable.RowCount; i++)
            {
                for(int j = 0; j < seatTable.ColumnCount; j++)
                {
                    if (j < seats.col[i - 1])
                        continue;
                    Label Temp1 = new Label();
                    Temp1.Text = "NOT A SEAT";
                    seatTable.Controls.Add(Temp1, j, i);
                }
            }
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            if (newStudentName.Text != "")
            {
                Student temp = new Student(newStudentName.Text);
                students.students.Add(temp);
                studentListTable.Items.Add(temp);
                newStudentName.Text = "";
            }
            else
                MessageBox.Show("学生名不能为空");
        }

        private void deleteStudent_Click(object sender, EventArgs e)
        {
            if (studentListTable.SelectedItem != null)
            {
                students.students.RemoveAt(studentListTable.SelectedIndex);
                studentListTable.Items.RemoveAt(studentListTable.SelectedIndex);
            }
            else
                MessageBox.Show("请先从列表中选择一个学生");
        }

        private void clearStudents_Click(object sender, EventArgs e)
        {
            studentListTable.Items.Clear();
            students.students.Clear();
        }

        private void AddNewRow(int row, int col)
        {
            seatTable.RowCount++;
            seatTable.ColumnCount = Math.Max(seatTable.ColumnCount, col);

            Seat tempHead = new Seat(null);
            Seat tempPrev = tempHead;
            Seat tempTail = tempHead;
            for (int i = 1; i < col; i++)
            {
                Seat tempCurr = new Seat(tempPrev);
                tempPrev = tempCurr;
                if (col - i == 1)
                    tempTail = tempCurr;
            }

            if (row == 1)
            {
                tempTail.next = seats.head;
                seats.head = tempHead;
            }
            else
            {
                Seat Head = seats.getRowHead(row);
                Seat Tail = seats.getRowTail(row - 1);
                tempTail.next = Head;
                Tail.next = tempHead;
            }

            seats.row++;
            seats.col.Insert(row - 1, col);
            seats.updateSize();

            seatTable.RowStyles.Clear();
            for (int i = 0; i < seatTable.RowCount; i++)
                seatTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1F / seatTable.RowCount));
            seatTable.ColumnStyles.Clear();
            for (int i = 0; i < seatTable.ColumnCount; i++)
                seatTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F / seatTable.ColumnCount));
            CleanTableWithFrontSign();
            SetInactiveSeat();

            rowNumber.Value++;
        }

        private void AddRow_Click(object sender, EventArgs e)
        {
            int row = (int)rowNumber.Value;
            int col = (int)colNumber.Value;
            if(row <= 0)
            {
                MessageBox.Show("不能在第" + row + "行插入一个新的行， 其值必须大于0");
                return;
            }
            if (row > seatTable.RowCount)
            {
                MessageBox.Show("不能在第" + row + "行插入一个新的行， 其值不可以大于现总行数");
                return;
            }
            if (col <= 0)
            {
                MessageBox.Show("不能添加一个空的行， 其值必须大于0");
                return;
            }
            AddNewRow(row, col);
        }

        private void removeRow_Click(object sender, EventArgs e)
        {
            int row = (int)removeRowNumber.Value;
            if (row <= 0)
            {
                MessageBox.Show("不能删除第" + row + "行， 其值必须大于0");
                return;
            }
            if (row > seatTable.RowCount - 1)
            {
                MessageBox.Show("不能删除第" + row + "行， 其值不可以大于现总行数");
                return;
            }

            if(row == 1)
            {
                seats.head = seats.getRowHead(2);
            }
            else
            {
                seats.getRowTail(row - 1).next = seats.getRowHead(row + 1);
            }
            seats.col.RemoveAt(row - 1);
            seats.row--;
            seats.updateSize();

            seatTable.RowCount--;
            seatTable.ColumnCount = Math.Max(seats.getLargestCol(), 1);

            seatTable.RowStyles.Clear();
            for (int i = 0; i < seatTable.RowCount; i++)
                seatTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1F / seatTable.RowCount));
            seatTable.ColumnStyles.Clear();
            for (int i = 0; i < seatTable.ColumnCount; i++)
                seatTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F / seatTable.ColumnCount));
            CleanTableWithFrontSign();
            SetInactiveSeat();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if(seats.updateSize() != students.students.Count)
            {
                MessageBox.Show("学生数量与座位数量不匹配\n座位数" + seats.updateSize() + "\n学生数" + students.students.Count);
                return;
            }
            CleanTableWithFrontSign();
            seats.nonrandomSortAllStudents(students);
            SetInactiveSeat();
            Seat i = seats.head;
            for(int r = 0; r < seats.row; r++)
            {
                for(int c = 0; c < seats.col[r]; c++)
                {
                    Label temp = new Label();
                    temp.Text = i.stu.ToString();
                    seatTable.Controls.Add(temp, c, r + 1);
                    i = i.next;
                }
            }
        }

        private void Random_Click(object sender, EventArgs e)
        {
            if (seats.updateSize() != students.students.Count)
            {
                MessageBox.Show("学生数量与座位数量不匹配\n座位数" + seats.updateSize() + "\n学生数" + students.students.Count);
                return;
            }
            CleanTableWithFrontSign();
            seats.randomSortAllStudents(students);
            SetInactiveSeat();
            Seat i = seats.head;
            for (int r = 0; r < seats.row; r++)
            {
                for (int c = 0; c < seats.col[r]; c++)
                {
                    Label temp = new Label();
                    temp.Text = i.stu.ToString();
                    seatTable.Controls.Add(temp, c, r + 1);
                    i = i.next;
                }
            }
        }

        private void RandomEX_Click(object sender, EventArgs e)
        {
            if (seats.updateSize() != students.students.Count)
            {
                MessageBox.Show("学生数量与座位数量不匹配\n座位数" + seats.updateSize() + "\n学生数" +students.students.Count);
                return;
            }
            if (seats.head == null)
            {
                MessageBox.Show("需要先初始化表格");
                return;
            }
            CleanTableWithFrontSign();
            seats.randomSortAllStudentsWithExchange();
            SetInactiveSeat();
            Seat i = seats.head;
            for (int r = 0; r < seats.row; r++)
            {
                for (int c = 0; c < seats.col[r]; c++)
                {
                    Label temp = new Label();
                    temp.Text = i.stu.ToString();
                    seatTable.Controls.Add(temp, c, r + 1);
                    i = i.next;
                }
            }
        }

        private void inputConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigFile temp = new ConfigFile();
            openFileDialog1.Filter = "Config File(*.cfgdata)|*.cfgdata";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                temp.LoadFromFile(openFileDialog1.FileName);

                List<Student> tempStudents = new List<Student>();
                studentListTable.Items.Clear();
                foreach (string i in temp.students)
                {
                    Student newStudent = new Student(i);
                    tempStudents.Add(newStudent);
                    studentListTable.Items.Add(newStudent);
                }
                students = new StudentList(tempStudents);
                
                seats = new SeatList(0, Array.Empty<int>());
                seatTable.RowCount = 1;
                seatTable.ColumnCount = 1;
                CleanTableWithFrontSign();
                for (int k = 0; k < temp.row; k++)
                    AddNewRow(k + 1, temp.col[k]);
            }
        }

        private void outputConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigFile temp = new ConfigFile(seats, students);
            saveFileDialog1.Filter = "Config File(*.cfgdata)|*.cfgdata";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.FileName = "New Config";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                temp.SaveToFile(saveFileDialog1.FileName);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("这是帮助!\n遇到问题还是直接联系我吧（Richard | 柴赋）\n这里太小写不下\n版本 v1.0 2020/08/23");
        }

        private void inputResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableResultFile temp = new TableResultFile();
            openFileDialog1.Filter = "Table Result File(*.tbdata)|*.tbdata";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                temp.LoadFromFile(openFileDialog1.FileName);

                if(temp.students.Count != seats.updateSize())
                {
                    MessageBox.Show("正在尝试读入的座位表名单长度与当前座位表长度不符\n座位数（现）" + seats.updateSize() + "\n座位数（尝试读入的）" + temp.students.Count);
                    return;
                }

                List<Student> tempStudents = new List<Student>();
                studentListTable.Items.Clear();
                foreach (string k in temp.students)
                {
                    Student newStudent = new Student(k);
                    tempStudents.Add(newStudent);
                    studentListTable.Items.Add(newStudent);
                }
                students = new StudentList(tempStudents);
                seats.nonrandomSortAllStudents(students);
                CleanTableWithFrontSign();
                SetInactiveSeat();
                Seat i = seats.head;
                for (int r = 0; r < seats.row; r++)
                {
                    for (int c = 0; c < seats.col[r]; c++)
                    {
                        Label temp1 = new Label();
                        temp1.Text = i.stu.ToString();
                        seatTable.Controls.Add(temp1, c, r + 1);
                        i = i.next;
                    }
                }
            }
        }

        private void outputResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            return;
        }

        private void tbdatawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seats.head == null)
            {
                MessageBox.Show("需要先初始化表格");
                return;
            }
            TableResultFile temp = new TableResultFile(seats);
            saveFileDialog1.Filter = "Table Result File(*.tbdata)|*.tbdata";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.FileName = "New Table Result";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                temp.SaveToFile(saveFileDialog1.FileName);
        }

        private void csvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seats.head == null)
            {
                MessageBox.Show("需要先初始化表格");
                return;
            }
            saveFileDialog1.Filter = "Comma-Separated Values(*.csv)|*.csv";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.FileName = "New Table Result";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                File.WriteAllText(saveFileDialog1.FileName, seats.ToString());
        }

        private void cleanTable_Click(object sender, EventArgs e)
        {
            seatTable.RowCount = 1;
            seatTable.ColumnCount = 1;
            CleanTableWithFrontSign();
            int[] temp0 = { };
            seats = new SeatList(0, temp0, null);
        }
    }
}