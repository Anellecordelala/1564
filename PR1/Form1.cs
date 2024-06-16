using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Вычислить_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(textBox2.Text) & !String.IsNullOrEmpty(textBox3.Text) & !String.IsNullOrEmpty(textBox4.Text))
                {
                    ChristmasDecorations decoration = new ChristmasDecorations
                    {
                        type = textBox4.Text,
                        color = textBox3.Text,
                        quantity = UInt32.Parse(textBox2.Text)
                    };
                     MessageBox.Show($"Количество украшений на елке: {decoration.CalculateOnTree()}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                { 
                    MessageBox.Show("Проверьте не пустые ли у вас строчки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Проверьте введенные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Выход_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void программаНовогодниеУкрашенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(textBox2.Text) & !String.IsNullOrEmpty(textBox3.Text) & !String.IsNullOrEmpty(textBox4.Text))
                {
                    ChristmasDecorations decoration = new ChristmasDecorations
                    {
                        type = textBox4.Text,
                        color = textBox3.Text,
                        quantity = UInt32.Parse(textBox2.Text)
                    };
                    MessageBox.Show($"Количество украшений на елке: {decoration.CalculateOnTree()}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Проверьте не пустые ли у вас строчки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Проверьте введенные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newF = new Form2();
            newF.Show();
        }
    }
}
