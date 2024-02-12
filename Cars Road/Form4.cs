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
    public partial class Form4 : Form
    {
        Cars_RoadEntities db;
        public Form4()
        {
            db = new Cars_RoadEntities();
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cars_RoadDataSet1.Города". При необходимости она может быть перемещена или удалена.
            this.городаTableAdapter.Fill(this.cars_RoadDataSet1.Города);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Города gr = new Города();
            gr.Название = textBox1.Text;
            gr.ЧисленностьНаселения = int.Parse(textBox2.Text);
            db.Города.Add(gr);
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
