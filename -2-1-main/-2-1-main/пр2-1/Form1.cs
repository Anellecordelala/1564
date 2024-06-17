using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace пр2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<Student> students = new List<Student>();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] input = textBox1.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (input.Length >= 2)
            {
                students.Add(new Student(input[0], input[1]));
                listBox2.Items.Add($"{input[0]} {input[1]}");
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Введите фамилию и имя через пробел.");
            }
        }
            private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
            {

            }
        
        private void button2_Click(object sender, EventArgs e)
        {
            dynamic groupedStudents = students.GroupBy(s => new { s.LastName, s.FirstName });
            listBox1.Items.Clear();
            foreach (IGrouping<dynamic, Student> group in groupedStudents)
            {
                if (group.Count() > 1)
                {
                    listBox1.Items.Add($"Студенты с одинаковыми фамилиями и именами:");
                    foreach (Student student in group)
                    {
                        listBox1.Items.Add($"Фамилия: {student.LastName}, Имя: {student.FirstName}");
                    }
                    listBox1.Items.Add("");
                }
            }
        }
                private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
                {

                }

                private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    Form2 newF = new Form2();
                    newF.Show();
                }

                private void выходToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    Close();
                }

                private void button3_Click(object sender, EventArgs e)
                {
                    Close();
                }
            }
        }

    

