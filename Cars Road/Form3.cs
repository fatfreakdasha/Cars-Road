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
    public partial class Form3 : Form
    {
        Cars_RoadEntities db;
        public Form3()
        {
            db = new Cars_RoadEntities();
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cars_RoadDataSet.Дороги". При необходимости она может быть перемещена или удалена.
            this.дорогиTableAdapter.Fill(this.cars_RoadDataSet.Дороги);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Дороги dr = new Дороги();
            dr.Протяженность = decimal.Parse(textBox1.Text);
            dr.ЕдиницаИзмерения = textBox2.Text;
            dr.Категория = textBox3.Text;
            dr.ВидПокрытия = textBox4.Text;
            dr.ОграничениеСкорости = int.Parse(textBox5.Text);
            dr.СоединенныйГородИдентификатор = int.Parse(textBox6.Text);
            dr.НаличиеАвторемонтныхПунктов = textBox7.Text;
            dr.НаличиеАвтозаправочныхСтанций = textBox8.Text;
            db.Дороги.Add(dr);
            db.SaveChanges();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }
    }
}
