namespace MarvelBoots.AppForms
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.buttonCartAccent = new System.Windows.Forms.Button();
            this.labelFullName = new System.Windows.Forms.Label();
            this.buttonActionAccent = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer.Panel1.Controls.Add(this.buttonCartAccent);
            this.splitContainer.Panel1.Controls.Add(this.labelFullName);
            this.splitContainer.Panel1.Controls.Add(this.buttonActionAccent);
            this.splitContainer.Panel1.Controls.Add(this.title);
            this.splitContainer.Panel1.Controls.Add(this.logo);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer.Size = new System.Drawing.Size(784, 461);
            this.splitContainer.SplitterDistance = 100;
            this.splitContainer.TabIndex = 0;
            // 
            // buttonCartAccent
            // 
            this.buttonCartAccent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCartAccent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCartAccent.BackgroundImage")));
            this.buttonCartAccent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCartAccent.Location = new System.Drawing.Point(727, 51);
            this.buttonCartAccent.Name = "buttonCartAccent";
            this.buttonCartAccent.Size = new System.Drawing.Size(45, 45);
            this.buttonCartAccent.TabIndex = 7;
            this.buttonCartAccent.UseVisualStyleBackColor = true;
            this.buttonCartAccent.Click += new System.EventHandler(this.buttonCartAccent_Click);
            // 
            // labelFullName
            // 
            this.labelFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFullName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFullName.Location = new System.Drawing.Point(550, 8);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(219, 34);
            this.labelFullName.TabIndex = 6;
            this.labelFullName.Text = "FullName";
            this.labelFullName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonActionAccent
            // 
            this.buttonActionAccent.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonActionAccent.Location = new System.Drawing.Point(98, 63);
            this.buttonActionAccent.Name = "buttonActionAccent";
            this.buttonActionAccent.Size = new System.Drawing.Size(119, 23);
            this.buttonActionAccent.TabIndex = 2;
            this.buttonActionAccent.Text = "Действие";
            this.buttonActionAccent.UseVisualStyleBackColor = true;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(94, 13);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(40, 23);
            this.title.TabIndex = 1;
            this.title.Text = "title";
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(75, 75);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.splitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseForm";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox logo;
        protected System.Windows.Forms.Button buttonActionAccent;
        protected System.Windows.Forms.Label title;
        protected System.Windows.Forms.SplitContainer splitContainer;
        protected System.Windows.Forms.Button buttonCartAccent;
        protected System.Windows.Forms.Label labelFullName;
    }
}