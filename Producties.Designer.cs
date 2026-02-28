namespace CompTech
{
    partial class Producties
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblProducer = new System.Windows.Forms.Label();
            this.lblProvider = new System.Windows.Forms.Label();
            this.lblOldPrice = new System.Windows.Forms.Label();
            this.lblNewPrice = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.lblCategory.Location = new System.Drawing.Point(287, 24);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(235, 15);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Категория товара | Наименование товара";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.lblDescription.Location = new System.Drawing.Point(287, 65);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(65, 15);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Описание:";
            // 
            // lblProducer
            // 
            this.lblProducer.AutoSize = true;
            this.lblProducer.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.lblProducer.Location = new System.Drawing.Point(288, 86);
            this.lblProducer.Name = "lblProducer";
            this.lblProducer.Size = new System.Drawing.Size(94, 15);
            this.lblProducer.TabIndex = 3;
            this.lblProducer.Text = "Производитель:";
            // 
            // lblProvider
            // 
            this.lblProvider.AutoSize = true;
            this.lblProvider.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.lblProvider.Location = new System.Drawing.Point(288, 108);
            this.lblProvider.Name = "lblProvider";
            this.lblProvider.Size = new System.Drawing.Size(72, 15);
            this.lblProvider.TabIndex = 4;
            this.lblProvider.Text = "Поставщик:";
            // 
            // lblOldPrice
            // 
            this.lblOldPrice.AutoSize = true;
            this.lblOldPrice.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.lblOldPrice.Location = new System.Drawing.Point(288, 129);
            this.lblOldPrice.Name = "lblOldPrice";
            this.lblOldPrice.Size = new System.Drawing.Size(35, 15);
            this.lblOldPrice.TabIndex = 5;
            this.lblOldPrice.Text = "Цена";
            // 
            // lblNewPrice
            // 
            this.lblNewPrice.AutoSize = true;
            this.lblNewPrice.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.lblNewPrice.Location = new System.Drawing.Point(459, 129);
            this.lblNewPrice.Name = "lblNewPrice";
            this.lblNewPrice.Size = new System.Drawing.Size(35, 15);
            this.lblNewPrice.TabIndex = 6;
            this.lblNewPrice.Text = "Цена";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.lblUnit.Location = new System.Drawing.Point(287, 150);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(86, 15);
            this.lblUnit.TabIndex = 7;
            this.lblUnit.Text = "Ед. измерения";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.lblStock.Location = new System.Drawing.Point(288, 172);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(99, 15);
            this.lblStock.TabIndex = 8;
            this.lblStock.Text = "Кол-во на складе";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.lblDiscount.Location = new System.Drawing.Point(449, 65);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(125, 15);
            this.lblDiscount.TabIndex = 9;
            this.lblDiscount.Text = "Действующая скидка";
            // 
            // Producties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblNewPrice);
            this.Controls.Add(this.lblOldPrice);
            this.Controls.Add(this.lblProvider);
            this.Controls.Add(this.lblProducer);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Producties";
            this.Size = new System.Drawing.Size(617, 339);
            this.Load += new System.EventHandler(this.Producties_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblProducer;
        private System.Windows.Forms.Label lblProvider;
        private System.Windows.Forms.Label lblOldPrice;
        private System.Windows.Forms.Label lblNewPrice;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblDiscount;
    }
}
