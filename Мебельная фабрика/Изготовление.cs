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
using static System.Net.Mime.MediaTypeNames;

namespace Мебельная_фабрика
{
    public partial class Изготовление : Form
    {
        public Изготовление()
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
            System.Windows.Forms.Application.Exit();
        }

        private void Изготовление_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "мебельная_фабрикаDataSet6.IzgotovlenieMebeli". При необходимости она может быть перемещена или удалена.
            this.izgotovlenieMebeliTableAdapter.Fill(this.мебельная_фабрикаDataSet6.IzgotovlenieMebeli);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && comboBox1.Text != "")
            {
                string KodZakaza = textBox1.Text.Trim();
                string DataNach = textBox2.Text.Trim();
                string Status = comboBox1.Text.Trim();

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IEHI6E7\SQLEXPRESS;Integrated Security=True;Initial Catalog=Мебельная фабрика");
                con.Open();
                string insertquery = "INSERT INTO IzgotovlenieMebeli (KodZakaza, Data_nachala_proizvodstva, Status_izgotovlenia) VALUES ('" + KodZakaza + "','" + DataNach + "','" + Status + "')";
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
