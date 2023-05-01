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
using Мебельная_фабрика.Properties;

namespace Мебельная_фабрика
{
    public partial class Покупатель : Form
    {
        public Покупатель()
        {
            InitializeComponent();
        }

        private void Покупатель_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "мебельная_фабрикаDataSet2.Mebeli". При необходимости она может быть перемещена или удалена.
            this.mebeliTableAdapter2.Fill(this.мебельная_фабрикаDataSet2.Mebeli);

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Вход vhod = new Вход();
            vhod.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.CurrentCell = null;
                dataGridView1.Rows[i].Visible = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                    {
                        dataGridView1.Rows[i].Visible = true;
                        break;
                    }
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows == null) return;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (row.Cells["nalichieDataGridViewCheckBoxColumn"].Value != null && (bool)row.Cells["nalichieDataGridViewCheckBoxColumn"].Value)
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }



        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.CurrentCell = null;
                dataGridView1.Rows[i].Visible = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "")
            {
                // Подключение к базе данных
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IEHI6E7\SQLEXPRESS;Integrated Security=True;Initial Catalog=Мебельная фабрика"))
                {
                    // Запрос на получение значения поля Наличие из таблицы Мебели для заданного кода мебели
                    string KodMebelya = textBox2.Text.Trim();
                    string query = "SELECT Nalichie FROM Mebeli WHERE KodMebelya=@KodMebelya";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@KodMebelya", KodMebelya);
                        con.Open();
                        bool furnitureAvailable = (bool)command.ExecuteScalar();
                        con.Close();

                        // Если мебели нет в базе данных, выводим сообщение об ошибке
                        if (!furnitureAvailable)
                        {
                            MessageBox.Show("Данная мебель убрана из продаж. Выберите другую мебель.");
                            return;
                        }
                    }

                    // Получение кода клиента по логину пользователя
                    string Login = Settings.Default["Login"].ToString();
                    int KodUsera = GetUserCode(Login);
                    int KodZakachika = GetCustomerCode(KodUsera);

                    // Если код клиента не найден, выводим сообщение об ошибке
                    if (KodZakachika == 0)
                    {
                        MessageBox.Show("Не удалось получить код клиента.");
                        return;
                    }

                    // Запрос на добавление заказа в таблицу Заказы
                    string Kolichestvo = textBox3.Text.Trim();
                    query = "INSERT INTO Zakazi (KodMebelya,KodZakazchika, Kolichestvo, DataZakaza, StatusZakaza) VALUES (@KodMebelya, @KodZakazchika, @Kolichestvo, @DataZakaza, @StatusZakaza)";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        // Добавляем параметры для запроса
                        command.Parameters.AddWithValue("@KodMebelya", KodMebelya);
                        command.Parameters.AddWithValue("@KodZakazchika", KodZakachika);
                        command.Parameters.AddWithValue("@Kolichestvo", Kolichestvo);
                        command.Parameters.AddWithValue("@DataZakaza", DateTime.Today);
                        command.Parameters.AddWithValue("@StatusZakaza", "Ожидание");
                        con.Open();
                        // Выполняем запрос на добавление
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Заказ успешно добавлен!");
                        }
                        else
                        {
                            MessageBox.Show("Заказ не удалось добавить. Повторите попытку ещё раз.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!");
            }
        }
        private int GetCustomerCode(int KodUsera)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-IEHI6E7\SQLEXPRESS;Integrated Security=True;Initial Catalog=Мебельная фабрика"))
            {
                connection.Open();
                string query = "SELECT KodZakazchika FROM Pokupateli WHERE KodUsera = @KodUsera";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@KodUsera", KodUsera);
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        throw new Exception("Код клиента не найдена!");
                    }
                }
            }
        }

        private int GetUserCode(string Login)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-IEHI6E7\SQLEXPRESS;Integrated Security=True;Initial Catalog=Мебельная фабрика"))
            {
                connection.Open();
                string query = "SELECT KodUsera FROM Users WHERE Login = @Login";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Login", Login);
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        throw new Exception("Код пользователя не найден!");
                    }
                }
            }
        }
    }
  
}
