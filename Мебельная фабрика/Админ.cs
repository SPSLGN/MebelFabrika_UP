using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Мебельная_фабрика
{
    public partial class Админ : Form
    {
        public Админ()
        {
            InitializeComponent();
        }

        private void Админ_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "мебельная_фабрикаDataSet9.Prodazhi". При необходимости она может быть перемещена или удалена.
            this.prodazhiTableAdapter1.Fill(this.мебельная_фабрикаDataSet9.Prodazhi);
         
            // TODO: данная строка кода позволяет загрузить данные в таблицу "мебельная_фабрикаDataSet4.IzgotovlenieMebeli". При необходимости она может быть перемещена или удалена.
            this.izgotovlenieMebeliTableAdapter.Fill(this.мебельная_фабрикаDataSet4.IzgotovlenieMebeli);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "мебельная_фабрикаDataSet3.Sklad". При необходимости она может быть перемещена или удалена.
            this.skladTableAdapter.Fill(this.мебельная_фабрикаDataSet3.Sklad);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Изготовление izg = new Изготовление();
            izg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Продажи prod = new Продажи();
            prod.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Комплектующие komp = new Комплектующие();
            komp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Вход vhod = new Вход();
            vhod.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
