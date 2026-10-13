namespace MarvelBoots.AppForms
{
    partial class DetailsForm
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
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.buttonAddCartAccent = new System.Windows.Forms.Button();
            this.labelResources = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelSizes = new System.Windows.Forms.Label();
            this.listBoxAvaibleSizes = new System.Windows.Forms.ListBox();
            this.labelManufacturer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
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
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.numericUpDownAmount);
            this.splitContainer.Panel2.Controls.Add(this.label2);
            this.splitContainer.Panel2.Controls.Add(this.labelManufacturer);
            this.splitContainer.Panel2.Controls.Add(this.listBoxAvaibleSizes);
            this.splitContainer.Panel2.Controls.Add(this.labelSizes);
            this.splitContainer.Panel2.Controls.Add(this.labelDescription);
            this.splitContainer.Panel2.Controls.Add(this.label1);
            this.splitContainer.Panel2.Controls.Add(this.labelResources);
            this.splitContainer.Panel2.Controls.Add(this.labelAmount);
            this.splitContainer.Panel2.Controls.Add(this.labelCategory);
            this.splitContainer.Panel2.Controls.Add(this.labelPrice);
            this.splitContainer.Panel2.Controls.Add(this.labelName);
            this.splitContainer.Panel2.Controls.Add(this.buttonAddCartAccent);
            this.splitContainer.Panel2.Controls.Add(this.pictureBoxImage);
            this.splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(23, 21);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 16;
            this.pictureBoxImage.TabStop = false;
            // 
            // buttonAddCartAccent
            // 
            this.buttonAddCartAccent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddCartAccent.Enabled = false;
            this.buttonAddCartAccent.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddCartAccent.Location = new System.Drawing.Point(623, 306);
            this.buttonAddCartAccent.Name = "buttonAddCartAccent";
            this.buttonAddCartAccent.Size = new System.Drawing.Size(149, 39);
            this.buttonAddCartAccent.TabIndex = 17;
            this.buttonAddCartAccent.Text = "Добавить в корзину";
            this.buttonAddCartAccent.UseVisualStyleBackColor = true;
            this.buttonAddCartAccent.Click += new System.EventHandler(this.buttonAddCartAccent_Click);
            // 
            // labelResources
            // 
            this.labelResources.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResources.Location = new System.Drawing.Point(232, 193);
            this.labelResources.Name = "labelResources";
            this.labelResources.Size = new System.Drawing.Size(381, 53);
            this.labelResources.TabIndex = 22;
            this.labelResources.Text = "Description";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAmount.Location = new System.Drawing.Point(239, 121);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(47, 19);
            this.labelAmount.TabIndex = 21;
            this.labelAmount.Text = "Name";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCategory.Location = new System.Drawing.Point(239, 91);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(55, 23);
            this.labelCategory.TabIndex = 20;
            this.labelCategory.Text = "Name";
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(609, 26);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(163, 49);
            this.labelPrice.TabIndex = 19;
            this.labelPrice.Text = "Name";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(239, 21);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(63, 26);
            this.labelName.TabIndex = 18;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Доступные размеры:";
            // 
            // labelDescription
            // 
            this.labelDescription.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescription.Location = new System.Drawing.Point(232, 140);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(415, 53);
            this.labelDescription.TabIndex = 25;
            this.labelDescription.Text = "Description";
            // 
            // labelSizes
            // 
            this.labelSizes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSizes.AutoSize = true;
            this.labelSizes.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSizes.Location = new System.Drawing.Point(12, 234);
            this.labelSizes.Name = "labelSizes";
            this.labelSizes.Size = new System.Drawing.Size(111, 18);
            this.labelSizes.TabIndex = 26;
            this.labelSizes.Text = "Размерный ряд:";
            // 
            // listBoxAvaibleSizes
            // 
            this.listBoxAvaibleSizes.FormattingEnabled = true;
            this.listBoxAvaibleSizes.Location = new System.Drawing.Point(197, 263);
            this.listBoxAvaibleSizes.Name = "listBoxAvaibleSizes";
            this.listBoxAvaibleSizes.Size = new System.Drawing.Size(51, 82);
            this.listBoxAvaibleSizes.TabIndex = 27;
            this.listBoxAvaibleSizes.SelectedIndexChanged += new System.EventHandler(this.listBoxAvaibleSizes_SelectedIndexChanged);
            // 
            // labelManufacturer
            // 
            this.labelManufacturer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelManufacturer.AutoSize = true;
            this.labelManufacturer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelManufacturer.Location = new System.Drawing.Point(239, 58);
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Size = new System.Drawing.Size(55, 23);
            this.labelManufacturer.TabIndex = 28;
            this.labelManufacturer.Text = "Name";
            this.labelManufacturer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(623, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Кол-во:";
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Location = new System.Drawing.Point(678, 284);
            this.numericUpDownAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(94, 20);
            this.numericUpDownAmount.TabIndex = 30;
            this.numericUpDownAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Name = "DetailsForm";
            this.Text = "LoginForm";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAddCartAccent;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelResources;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelSizes;
        private System.Windows.Forms.ListBox listBoxAvaibleSizes;
        private System.Windows.Forms.Label labelManufacturer;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.Label label2;
    }
}