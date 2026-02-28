using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CompTech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Введите логин и пароль");
                return;
            }

            using (SqlConnection con = new SqlConnection(Database.ConnectionString))
            {
                try
                {
                    con.Open();

                    string query = @"SELECT RoleID, Surname, Name, Patronmic
                                     FROM [User]
                                     WHERE Login=@log AND Password=@pass";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@log", textBox1.Text);
                    cmd.Parameters.AddWithValue("@pass", textBox2.Text);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int role = Convert.ToInt32(reader["RoleID"]);
                        string fio = reader["Surname"] + " " +
                                     reader["Name"] + " " +
                                     reader["Patronmic"];

                        Form2 f = new Form2(role, fio);
                        f.Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Неверный логин или пароль");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(3, "Гость");
            f.Show();
            this.Hide();
        }
    }
}