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
    public partial class Вход : Form
    {
        public Вход()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';

        }

       
        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-IEHI6E7\SQLEXPRESS;Integrated Security=True;Initial Catalog=Мебельная фабрика");
            string query = "SELECT * FROM Users WHERE Login='" + textBox1.Text + "' and Password='" + textBox2.Text + "'";
            con1.Open();

            SqlCommand cmd = new SqlCommand(query, con1);
            SqlDataReader reader = cmd.ExecuteReader();
            if (textBox1.Text != "" && textBox2.Text != "")

            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        object KodUsera = reader.GetValue(0);
                        object Login = reader.GetValue(1);
                        object Password = reader.GetValue(2);
                        string User_Login = Login.ToString();
                        object Role = reader.GetValue(3);
                        string KodUser = KodUsera.ToString();
                        string password_Login = Password.ToString();
                        string role_Login = Role.ToString();

                        if (role_Login == "True")
                        {
                            Админ admin = new Админ();
                            admin.Show();
                            this.Hide();
                            Settings.Default["Login"] = textBox1.Text;
                            Settings.Default.Save();
                        }
                        else if (role_Login == "False")
                        {
                            Покупатель buyer = new Покупатель();
                            buyer.Show();
                            this.Hide();
                            Settings.Default["Login"] = textBox1.Text;
                            Settings.Default.Save();


                        }

                    }

                }

                else
                { MessageBox.Show("Некорректный логин или пароль. Ввведите корректные данные!", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Регистрация reg = new Регистрация();
            reg.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
