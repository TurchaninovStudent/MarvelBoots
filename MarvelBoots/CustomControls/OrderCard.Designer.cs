namespace MarvelBoots.CustomControls
{
    partial class OrderCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderCard));
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.buttonRemoveAccent = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(544, 88);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(163, 49);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Name";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelPrice.Click += new System.EventHandler(this.OrderCard_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUser.Location = new System.Drawing.Point(13, 13);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(55, 23);
            this.labelUser.TabIndex = 3;
            this.labelUser.Text = "Name";
            this.labelUser.Click += new System.EventHandler(this.OrderCard_Click);
            // 
            // buttonRemoveAccent
            // 
            this.buttonRemoveAccent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRemoveAccent.BackgroundImage")));
            this.buttonRemoveAccent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRemoveAccent.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemoveAccent.Location = new System.Drawing.Point(657, 13);
            this.buttonRemoveAccent.Name = "buttonRemoveAccent";
            this.buttonRemoveAccent.Size = new System.Drawing.Size(50, 50);
            this.buttonRemoveAccent.TabIndex = 6;
            this.buttonRemoveAccent.UseVisualStyleBackColor = true;
            this.buttonRemoveAccent.Click += new System.EventHandler(this.buttonAddToCartAccent_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(14, 51);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(37, 18);
            this.labelDate.TabIndex = 8;
            this.labelDate.Text = "Date";
            this.labelDate.Click += new System.EventHandler(this.OrderCard_Click);
            // 
            // OrderCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.buttonRemoveAccent);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelPrice);
            this.Name = "OrderCard";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(720, 150);
            this.Click += new System.EventHandler(this.OrderCard_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ProductCard_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button buttonRemoveAccent;
        private System.Windows.Forms.Label labelDate;
    }
}
