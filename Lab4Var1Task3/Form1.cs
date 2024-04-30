using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4Var1Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeDisciplines(); 
        }

        private void InitializeDisciplines()
        {
            checkedListBoxDisciplines.Items.Add("Математика");
            checkedListBoxDisciplines.Items.Add("Фізика");
            checkedListBoxDisciplines.Items.Add("Історія");
            checkedListBoxDisciplines.Items.Add("Література");
            checkedListBoxDisciplines.Items.Add("Програмування");
            checkedListBoxDisciplines.Items.Add("Хімія");
            checkedListBoxDisciplines.Items.Add("Біологія");
            checkedListBoxDisciplines.Items.Add("Фізкультура");
            checkedListBoxDisciplines.Items.Add("Українська мова");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (object item in checkedListBoxDisciplines.CheckedItems)
            {
                listBox1.Items.Add(item.ToString());
            }
        }
    }
}

