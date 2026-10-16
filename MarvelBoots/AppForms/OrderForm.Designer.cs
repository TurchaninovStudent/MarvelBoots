namespace MarvelBoots.AppForms
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonConfirmAccent = new System.Windows.Forms.Button();
            this.buttonNewProductAccent = new System.Windows.Forms.Button();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonActionAccent
            // 
            this.buttonActionAccent.Text = "Выйти";
            this.buttonActionAccent.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // title
            // 
            this.title.Size = new System.Drawing.Size(135, 23);
            this.title.Text = "Список товаров";
            // 
            // splitContainer
            // 
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.dateTimePickerDate);
            this.splitContainer.Panel1.Controls.Add(this.buttonNewProductAccent);
            this.splitContainer.Panel1.Controls.Add(this.buttonConfirmAccent);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            // 
            // buttonCartAccent
            // 
            this.buttonCartAccent.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(744, 337);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // buttonConfirmAccent
            // 
            this.buttonConfirmAccent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonConfirmAccent.BackgroundImage")));
            this.buttonConfirmAccent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonConfirmAccent.Location = new System.Drawing.Point(676, 51);
            this.buttonConfirmAccent.Name = "buttonConfirmAccent";
            this.buttonConfirmAccent.Size = new System.Drawing.Size(44, 44);
            this.buttonConfirmAccent.TabIndex = 8;
            this.buttonConfirmAccent.UseVisualStyleBackColor = true;
            this.buttonConfirmAccent.Click += new System.EventHandler(this.buttonConfirmAccent_Click);
            // 
            // buttonNewProductAccent
            // 
            this.buttonNewProductAccent.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNewProductAccent.Location = new System.Drawing.Point(235, 63);
            this.buttonNewProductAccent.Name = "buttonNewProductAccent";
            this.buttonNewProductAccent.Size = new System.Drawing.Size(119, 23);
            this.buttonNewProductAccent.TabIndex = 9;
            this.buttonNewProductAccent.Text = "Добавить заказ";
            this.buttonNewProductAccent.UseVisualStyleBackColor = true;
            this.buttonNewProductAccent.Click += new System.EventHandler(this.buttonNewProductAccent_Click);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(236, 37);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(118, 20);
            this.dateTimePickerDate.TabIndex = 10;
            this.dateTimePickerDate.ValueChanged += new System.EventHandler(this.dateTimePickerDate_ValueChanged);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Name = "OrderForm";
            this.Text = "LoginForm";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonConfirmAccent;
        private System.Windows.Forms.Button buttonNewProductAccent;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
    }
}