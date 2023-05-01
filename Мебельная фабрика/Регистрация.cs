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
    public partial class Регистрация : Form
    {
        public Регистрация()
        {
            InitializeComponent();
        }

        private void Регистрация_Load(object sender, EventArgs e)
        {
            textBox4.PasswordChar = '*';
            textBox5.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != ""&&textBox5.Text!="")
            {
                if (textBox5.Text == textBox4.Text)
                {
                    if (textBox4.Text.Length >= 6 && textBox5.Text.Length >= 6)
                    {
                        string FIO = textBox1.Text.Trim();
                        string City = textBox2.Text.Trim();
                        string login = textBox3.Text.Trim();
                        string password = textBox4.Text.Trim();
                        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IEHI6E7\SQLEXPRESS;Integrated Security=True;Initial Catalog=Мебельная фабрика");
                        string query = "SELECT * FROM users WHERE login='" + textBox3.Text + "' and password='" + textBox4.Text + "'";
                        string pok = "SELECT * FROM Pokupateli WHERE FIO='" + textBox1.Text + "' and City='" + textBox2.Text + "'";

                        con.Open();
                        SqlCommand cmd1 = new SqlCommand(query, con);
                        SqlDataReader reader1 = cmd1.ExecuteReader();

                        if (reader1.HasRows)
                        {
                            MessageBox.Show("Данный пользователь уже существует");
                            reader1.Close();
                        }
                        else
                        {
                            reader1.Close();
                            // Создание SqlCommand для запроса inserquery
                            string inserquery = "INSERT INTO Users (Login, Password, Role) VALUES ('" + login + "','" + password + "', 0)";
                            SqlCommand cmd2 = new SqlCommand(inserquery, con);
                            cmd2.ExecuteNonQuery();

                            // Создание SqlCommand для запроса inserpok
                            string inserpok = "INSERT INTO Pokupateli (FIO, City) VALUES ('" + FIO + "','" + City + "')";
                            SqlCommand cmd3 = new SqlCommand(inserpok, con);
                            cmd3.ExecuteNonQuery();

                            MessageBox.Show("Вы успешно зарегистрированы");
                            //Регистрация.ActiveForm.Close();
                        }
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Пароль должен иметь длину больше или равно 6 символов", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Пароли должны совпадать", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Вход vhod = new Вход();
            vhod.Show();
        }
    }
}
