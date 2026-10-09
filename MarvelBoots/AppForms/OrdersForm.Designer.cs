namespace MarvelBoots.AppForms
{
    partial class OrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersForm));
            this.labelFullName = new System.Windows.Forms.Label();
            this.buttonCartAccent = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonActionAccent
            // 
            this.buttonActionAccent.Text = "Выйти";
            this.buttonActionAccent.Click += new System.EventHandler(this.buttonUnauthorize_Click);
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
            this.splitContainer.Panel1.Controls.Add(this.buttonCartAccent);
            this.splitContainer.Panel1.Controls.Add(this.labelFullName);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            // 
            // labelFullName
            // 
            this.labelFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFullName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFullName.Location = new System.Drawing.Point(540, 9);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(219, 34);
            this.labelFullName.TabIndex = 4;
            this.labelFullName.Text = "FullName";
            this.labelFullName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonCartAccent
            // 
            this.buttonCartAccent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCartAccent.BackgroundImage")));
            this.buttonCartAccent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCartAccent.Location = new System.Drawing.Point(719, 41);
            this.buttonCartAccent.Name = "buttonCartAccent";
            this.buttonCartAccent.Size = new System.Drawing.Size(45, 45);
            this.buttonCartAccent.TabIndex = 5;
            this.buttonCartAccent.UseVisualStyleBackColor = true;
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
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Name = "OrdersForm";
            this.Text = "LoginForm";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Button buttonCartAccent;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}