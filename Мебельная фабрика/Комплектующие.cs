using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Мебельная_фабрика
{
    public partial class Комплектующие : Form
    {
        public Комплектующие()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Админ adm = new Админ();
            adm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Комплектующие_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "мебельная_фабрикаDataSet10.Sklad". При необходимости она может быть перемещена или удалена.
            this.skladTableAdapter.Fill(this.мебельная_фабрикаDataSet10.Sklad);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                string KodKompl = textBox1.Text.Trim();
                string KolvoKompl = textBox2.Text.Trim();
                DateTime DateKompl = DateTime.Today;
                string date = DateKompl.ToString("yyyy-MM-dd");
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IEHI6E7\SQLEXPRESS;Integrated Security=True;Initial Catalog=Мебельная фабрика");
                con.Open();
                string insertquery = "INSERT INTO Prodazhi (KodZakaza, DataProdazhi) VALUES ('" + KodKompl + "','" + KolvoKompl + "','" + DateKompl + "')";
                SqlCommand cmd2 = new SqlCommand(insertquery, con);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Информация добавлена!");
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!");
            }
        }
    }
}
