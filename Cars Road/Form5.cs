using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars_Road
{
    public partial class Form5 : Form
    {
        Cars_RoadEntities db;
        public Form5()
        {
            db = new Cars_RoadEntities();
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cars_RoadDataSet2.СервисныеПункты". При необходимости она может быть перемещена или удалена.
            this.сервисныеПунктыTableAdapter.Fill(this.cars_RoadDataSet2.СервисныеПункты);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            СервисныеПункты sp = new СервисныеПункты();
            sp.Название = textBox1.Text;
            sp.Тип = textBox2.Text;
            sp.Дорога = int.Parse(textBox3.Text);
            db.СервисныеПункты.Add(sp);
            db.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }
    }
}
