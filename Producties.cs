using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompTech
{
    public partial class Producties : UserControl
    {
        public Producties()
        {
            InitializeComponent();
        }

        public void FillData(
        string category,
        string description,
        string producer,
        string provider,
        decimal price,
        decimal discount,
        string unit,
        decimal stock,
        string photo)
        {
            lblCategory.Text = category;
            lblDescription.Text = description;
            lblProducer.Text = "Производитель: " + producer;
            lblProvider.Text = "Поставщик: " + provider;
            lblUnit.Text = "Ед. измерения: " + unit;
            lblStock.Text = "На складе: " + stock;

            decimal newPrice = price - (price * discount / 100);

            lblOldPrice.Text = price.ToString("N2");
            lblNewPrice.Text = newPrice.ToString("N2");

            if (discount > 0)
                lblDiscount.Text = discount + "%";
            else
                lblDiscount.Text = "";

            if (!string.IsNullOrEmpty(photo) && System.IO.File.Exists(photo))
                pictureBox1.Image = Image.FromFile(photo);
        }

        private void Producties_Load(object sender, EventArgs e)
        {

        }
    }
}
