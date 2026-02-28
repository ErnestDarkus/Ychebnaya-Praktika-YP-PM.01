using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CompTech
{
    public partial class Form2 : Form
    {
        private int _role;

        public Form2(int role, string fio)
        {
            InitializeComponent();
            _role = role;
            label1.Text = fio;
           
            if (_role != 1)
            {
                button1.Visible = false; // удалить
                button2.Visible = false; // добавить
                button3.Visible = false; // редактировать
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[]
            {
                "По возрастанию цены",
                "По убыванию цены"
            });

            comboBox1.SelectedIndex = 0;

            LoadCategories();
            LoadProducts();
        }

        private void LoadCategories()
        {
            comboBox2.Items.Clear();
            comboBox2.Items.Add("Все категории");

            using (SqlConnection con = new SqlConnection(Database.ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Name FROM Category", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                    comboBox2.Items.Add(reader["Name"].ToString());
            }

            comboBox2.SelectedIndex = 0;
        }

        private void LoadProducts()
        {
            flowLayoutPanel1.Controls.Clear();

            using (SqlConnection con = new SqlConnection(Database.ConnectionString))
            {
                con.Open();

                string sql = @"SELECT p.*, c.Name as CategoryName,
                       pr.Name as ProducerName,
                       pv.Name as ProviderName,
                       u.Name as UnitName
                       FROM Product p
                       LEFT JOIN Category c ON p.CategoryID=c.ID
                       LEFT JOIN Producer pr ON p.ProducerID=pr.ID
                       LEFT JOIN Provider pv ON p.ProviderID=pv.ID
                       LEFT JOIN Unit u ON p.UnitID=u.ID
                       WHERE p.Name LIKE @search";

                if (comboBox2.SelectedIndex > 0)
                    sql += " AND c.Name=@cat";

                if (comboBox1.SelectedIndex == 0)
                    sql += " ORDER BY Price ASC";
                else
                    sql += " ORDER BY Price DESC";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@search", "%" + textBox1.Text + "%");

                if (comboBox2.SelectedIndex > 0)
                    cmd.Parameters.AddWithValue("@cat", comboBox2.SelectedItem.ToString());

                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    Producties card = new Producties();

                    card.FillData(
                        r["CategoryName"].ToString(),
                        r["Description"].ToString(),
                        r["ProducerName"].ToString(),
                        r["ProviderName"].ToString(),
                        Convert.ToDecimal(r["Price"]),
                        Convert.ToDecimal(r["Discount"]),
                        r["UnitName"].ToString(),
                        Convert.ToDecimal(r["AmountInStock"]),
                        r["Photo"].ToString()
                    );

                    flowLayoutPanel1.Controls.Add(card);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }
    }
}
