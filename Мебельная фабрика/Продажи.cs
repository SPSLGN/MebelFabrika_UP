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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Мебельная_фабрика
{
    public partial class Продажи : Form
    {
        public Продажи()
        {
            InitializeComponent();
        }

        private void Продажи_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "мебельная_фабрикаDataSet8.Prodazhi". При необходимости она может быть перемещена или удалена.
            this.prodazhiTableAdapter1.Fill(this.мебельная_фабрикаDataSet8.Prodazhi);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Админ adm = new Админ();
            adm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string KodZakaza = textBox1.Text.Trim();
                DateTime saleDate = DateTime.Today;
                string date = saleDate.ToString("yyyy-MM-dd");
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IEHI6E7\SQLEXPRESS;Integrated Security=True;Initial Catalog=Мебельная фабрика");
                con.Open();
                string insertquery = "INSERT INTO Prodazhi (KodZakaza, DataProdazhi) VALUES ('" + KodZakaza + "','" + saleDate + "')";
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
