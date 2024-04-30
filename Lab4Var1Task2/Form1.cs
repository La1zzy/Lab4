using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4Var1Task2
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> jobSalaries = new Dictionary<string, int>()
        {
            { "Системний адміністратор", 25000 },
            { "Веб-програміст", 32500 },
            { "Веб-дизайнер", 16000 },
            { "Модератор сайтів", 15000 }
        };

        public Form1()
        {
            InitializeComponent();

            foreach (string job in jobSalaries.Keys)
            {
                listBox1.Items.Add(job);
            }

            listBox1.Sorted = true;

            foreach (int salary in jobSalaries.Values)
            {
                comboBox1.Items.Add(salary);
            }

            comboBox1.SelectedIndex = 0;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string selectedJob = listBox1.SelectedItem.ToString();
            int selectedSalary = Convert.ToInt32(comboBox1.SelectedItem);
            int yearsOfWork = (int)numericUpDown1.Value;

            string result = $"Тип роботи: {selectedJob}\n" +
                            $"Зарплата: {selectedSalary}\n" +
                            $"Стаж роботи: {yearsOfWork} років\n";

            richTextBox1.Text = result;
        }
    }
}