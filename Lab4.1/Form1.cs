using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4._1
{
    public partial class Form1 : Form
    {
        private List<string> cities = new List<string>();

        public Form1()
        {
            InitializeComponent();

            for (int i = 1; i <= 12; i++)
            {
                monthComboBox.Items.Add(i);
            }

            for (int i = 1; i <= 31; i++)
            {
                dayComboBox.Items.Add(i);
            }


            for (int i = 1950; i <= 2024; i++)
            {
                yearComboBox.Items.Add(i);
            }
        }
        private void addButton_Click_1(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            int day = Convert.ToInt32(dayComboBox.SelectedItem);
            int month = Convert.ToInt32(monthComboBox.SelectedItem);
            int year = Convert.ToInt32(yearComboBox.SelectedItem);
            string city = cityComboBox.Text;

            string result = $"Прізвище: {lastName}, Ім'я: {firstName}, Дата народження: {day}.{month}.{year}, Місто народження: {city}";

            resultRichTextBox.AppendText(result + Environment.NewLine);

            if (!cities.Contains(city))
            {
                cities.Add(city);
                cityComboBox.Items.Add(city);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
