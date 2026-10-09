namespace MarvelBoots.CustomControls
{
    partial class ProductCard
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
            this.labelManufacturerAndName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelResources = new System.Windows.Forms.Label();
            this.buttonAddToCartAccent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelManufacturerAndName
            // 
            this.labelManufacturerAndName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelManufacturerAndName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelManufacturerAndName.Location = new System.Drawing.Point(163, 13);
            this.labelManufacturerAndName.Name = "labelManufacturerAndName";
            this.labelManufacturerAndName.Size = new System.Drawing.Size(544, 25);
            this.labelManufacturerAndName.TabIndex = 0;
            this.labelManufacturerAndName.Text = "Name";
            this.labelManufacturerAndName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(544, 51);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(163, 49);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Name";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCategory.Location = new System.Drawing.Point(159, 34);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(55, 23);
            this.labelCategory.TabIndex = 3;
            this.labelCategory.Text = "Name";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAmount.Location = new System.Drawing.Point(159, 64);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(47, 19);
            this.labelAmount.TabIndex = 4;
            this.labelAmount.Text = "Name";
            // 
            // labelResources
            // 
            this.labelResources.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResources.Location = new System.Drawing.Point(159, 87);
            this.labelResources.Name = "labelResources";
            this.labelResources.Size = new System.Drawing.Size(415, 53);
            this.labelResources.TabIndex = 5;
            this.labelResources.Text = "Description";
            // 
            // buttonAddToCartAccent
            // 
            this.buttonAddToCartAccent.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddToCartAccent.Location = new System.Drawing.Point(580, 103);
            this.buttonAddToCartAccent.Name = "buttonAddToCartAccent";
            this.buttonAddToCartAccent.Size = new System.Drawing.Size(127, 34);
            this.buttonAddToCartAccent.TabIndex = 6;
            this.buttonAddToCartAccent.Text = "Добавить в корзину";
            this.buttonAddToCartAccent.UseVisualStyleBackColor = true;
            this.buttonAddToCartAccent.Click += new System.EventHandler(this.buttonAddToCartAccent_Click);
            // 
            // ProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAddToCartAccent);
            this.Controls.Add(this.labelResources);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelManufacturerAndName);
            this.Name = "ProductCard";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(720, 150);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ProductCard_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelManufacturerAndName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelResources;
        private System.Windows.Forms.Button buttonAddToCartAccent;
    }
}
