namespace MarvelBoots.AppForms
{
    partial class ProductForm
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
            this.components = new System.ComponentModel.Container();
            this.splitContainerFilter = new System.Windows.Forms.SplitContainer();
            this.radioButtonExpensiveFirst = new System.Windows.Forms.RadioButton();
            this.radioButtonLessFirst = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.turchaninovaemarvelbootsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.turchaninov_ae_marvelbootsDataSet = new MarvelBoots.turchaninov_ae_marvelbootsDataSet();
            this.searchTerm = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.manufacturerTableAdapter = new MarvelBoots.turchaninov_ae_marvelbootsDataSetTableAdapters.ManufacturerTableAdapter();
            this.buttonOrdersAccent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFilter)).BeginInit();
            this.splitContainerFilter.Panel1.SuspendLayout();
            this.splitContainerFilter.Panel2.SuspendLayout();
            this.splitContainerFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turchaninovaemarvelbootsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turchaninov_ae_marvelbootsDataSet)).BeginInit();
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
            this.splitContainer.Panel1.Controls.Add(this.buttonOrdersAccent);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.splitContainerFilter);
            this.splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            // 
            // splitContainerFilter
            // 
            this.splitContainerFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerFilter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerFilter.IsSplitterFixed = true;
            this.splitContainerFilter.Location = new System.Drawing.Point(20, 0);
            this.splitContainerFilter.Name = "splitContainerFilter";
            this.splitContainerFilter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerFilter.Panel1
            // 
            this.splitContainerFilter.Panel1.Controls.Add(this.radioButtonExpensiveFirst);
            this.splitContainerFilter.Panel1.Controls.Add(this.radioButtonLessFirst);
            this.splitContainerFilter.Panel1.Controls.Add(this.label3);
            this.splitContainerFilter.Panel1.Controls.Add(this.label2);
            this.splitContainerFilter.Panel1.Controls.Add(this.label1);
            this.splitContainerFilter.Panel1.Controls.Add(this.comboBoxCategory);
            this.splitContainerFilter.Panel1.Controls.Add(this.searchTerm);
            // 
            // splitContainerFilter.Panel2
            // 
            this.splitContainerFilter.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainerFilter.Size = new System.Drawing.Size(744, 337);
            this.splitContainerFilter.SplitterDistance = 35;
            this.splitContainerFilter.TabIndex = 1;
            // 
            // radioButtonExpensiveFirst
            // 
            this.radioButtonExpensiveFirst.AutoSize = true;
            this.radioButtonExpensiveFirst.Location = new System.Drawing.Point(482, 9);
            this.radioButtonExpensiveFirst.Name = "radioButtonExpensiveFirst";
            this.radioButtonExpensiveFirst.Size = new System.Drawing.Size(64, 17);
            this.radioButtonExpensiveFirst.TabIndex = 6;
            this.radioButtonExpensiveFirst.TabStop = true;
            this.radioButtonExpensiveFirst.Text = "Больше";
            this.radioButtonExpensiveFirst.UseVisualStyleBackColor = true;
            this.radioButtonExpensiveFirst.CheckedChanged += new System.EventHandler(this.radioButtonFirst_CheckedChanged);
            // 
            // radioButtonLessFirst
            // 
            this.radioButtonLessFirst.AutoSize = true;
            this.radioButtonLessFirst.Location = new System.Drawing.Point(410, 9);
            this.radioButtonLessFirst.Name = "radioButtonLessFirst";
            this.radioButtonLessFirst.Size = new System.Drawing.Size(66, 17);
            this.radioButtonLessFirst.TabIndex = 5;
            this.radioButtonLessFirst.TabStop = true;
            this.radioButtonLessFirst.Text = "Меньше";
            this.radioButtonLessFirst.UseVisualStyleBackColor = true;
            this.radioButtonLessFirst.CheckedChanged += new System.EventHandler(this.radioButtonFirst_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(368, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Цена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(146, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Категория";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.manufacturerBindingSource, "Name", true));
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(241, 7);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategory.TabIndex = 1;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxManufacturer_SelectedIndexChanged);
            // 
            // manufacturerBindingSource
            // 
            this.manufacturerBindingSource.DataMember = "Manufacturer";
            this.manufacturerBindingSource.DataSource = this.turchaninovaemarvelbootsDataSetBindingSource;
            // 
            // turchaninovaemarvelbootsDataSetBindingSource
            // 
            this.turchaninovaemarvelbootsDataSetBindingSource.DataSource = this.turchaninov_ae_marvelbootsDataSet;
            this.turchaninovaemarvelbootsDataSetBindingSource.Position = 0;
            // 
            // turchaninov_ae_marvelbootsDataSet
            // 
            this.turchaninov_ae_marvelbootsDataSet.DataSetName = "turchaninov_ae_marvelbootsDataSet";
            this.turchaninov_ae_marvelbootsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchTerm
            // 
            this.searchTerm.Location = new System.Drawing.Point(40, 7);
            this.searchTerm.Name = "searchTerm";
            this.searchTerm.Size = new System.Drawing.Size(100, 20);
            this.searchTerm.TabIndex = 0;
            this.searchTerm.TextChanged += new System.EventHandler(this.searchTerm_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(744, 298);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // manufacturerTableAdapter
            // 
            this.manufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // buttonOrdersAccent
            // 
            this.buttonOrdersAccent.Location = new System.Drawing.Point(223, 64);
            this.buttonOrdersAccent.Name = "buttonOrdersAccent";
            this.buttonOrdersAccent.Size = new System.Drawing.Size(119, 23);
            this.buttonOrdersAccent.TabIndex = 8;
            this.buttonOrdersAccent.Text = "Заказы";
            this.buttonOrdersAccent.UseVisualStyleBackColor = true;
            this.buttonOrdersAccent.Click += new System.EventHandler(this.buttonOrdersAccent_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Name = "ProductForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.splitContainerFilter.Panel1.ResumeLayout(false);
            this.splitContainerFilter.Panel1.PerformLayout();
            this.splitContainerFilter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFilter)).EndInit();
            this.splitContainerFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turchaninovaemarvelbootsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turchaninov_ae_marvelbootsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainerFilter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox searchTerm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.BindingSource turchaninovaemarvelbootsDataSetBindingSource;
        private turchaninov_ae_marvelbootsDataSet turchaninov_ae_marvelbootsDataSet;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
        private turchaninov_ae_marvelbootsDataSetTableAdapters.ManufacturerTableAdapter manufacturerTableAdapter;
        private System.Windows.Forms.Button buttonOrdersAccent;
        private System.Windows.Forms.RadioButton radioButtonExpensiveFirst;
        private System.Windows.Forms.RadioButton radioButtonLessFirst;
        private System.Windows.Forms.Label label3;
    }
}