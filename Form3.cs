using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CompTech
{
    public partial class Form3 : Form
    {
        private int? _id;

        public Form3(int? id)
        {
            InitializeComponent();
            _id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con =
                new SqlConnection(Database.ConnectionString))
            {
                con.Open();

                string sql =
                @"INSERT INTO Product
                  (Name, Price, AmountInStock,
                   Description, Discount)
                  VALUES
                  (@n,@p,@s,@d,@disc)";

                SqlCommand cmd =
                    new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@n",
                    textBox1.Text);

                cmd.Parameters.AddWithValue("@p",
                    Convert.ToDecimal(textBox2.Text));

                cmd.Parameters.AddWithValue("@s",
                    Convert.ToDecimal(textBox3.Text));

                cmd.Parameters.AddWithValue("@d",
                    textBox4.Text);

                cmd.Parameters.AddWithValue("@disc",
                    Convert.ToDecimal(textBox5.Text));

                cmd.ExecuteNonQuery();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}