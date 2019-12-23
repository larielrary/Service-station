namespace CourseProject
{
    partial class AddSpares
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sparesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceStationDataSet = new CourseProject.ServiceStationDataSet();
            this.sparesTableAdapter = new CourseProject.ServiceStationDataSetTableAdapters.SparesTableAdapter();
            this.NewOrderBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SpareName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceStationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SpareName,
            this.Exist,
            this.Price,
            this.Shop,
            this.Manufacturer});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.Location = new System.Drawing.Point(13, 14);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(447, 438);
            this.dataGridView1.TabIndex = 0;
            // 
            // sparesBindingSource
            // 
            this.sparesBindingSource.DataMember = "Spares";
            this.sparesBindingSource.DataSource = this.serviceStationDataSet;
            // 
            // serviceStationDataSet
            // 
            this.serviceStationDataSet.DataSetName = "ServiceStationDataSet";
            this.serviceStationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sparesTableAdapter
            // 
            this.sparesTableAdapter.ClearBeforeFill = true;
            // 
            // NewOrderBtn
            // 
            this.NewOrderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewOrderBtn.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewOrderBtn.Location = new System.Drawing.Point(13, 471);
            this.NewOrderBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewOrderBtn.Name = "NewOrderBtn";
            this.NewOrderBtn.Size = new System.Drawing.Size(133, 32);
            this.NewOrderBtn.TabIndex = 4;
            this.NewOrderBtn.Text = "Заказать";
            this.NewOrderBtn.UseVisualStyleBackColor = true;
            this.NewOrderBtn.Click += new System.EventHandler(this.заказатьBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.CloseBtn.Location = new System.Drawing.Point(327, 473);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(133, 31);
            this.CloseBtn.TabIndex = 5;
            this.CloseBtn.Text = "Выход";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // SpareName
            // 
            this.SpareName.DataPropertyName = "Shop";
            this.SpareName.HeaderText = "Наименование";
            this.SpareName.Name = "SpareName";
            // 
            // Exist
            // 
            this.Exist.HeaderText = "Наличие";
            this.Exist.Name = "Exist";
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            // 
            // Shop
            // 
            this.Shop.HeaderText = "Поставщик";
            this.Shop.Name = "Shop";
            // 
            // Manufacturer
            // 
            this.Manufacturer.HeaderText = "Производитель";
            this.Manufacturer.Name = "Manufacturer";
            // 
            // AddSpares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(473, 515);
            this.ControlBox = false;
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.NewOrderBtn);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddSpares";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CheckSpares_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceStationDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ServiceStationDataSet serviceStationDataSet;
        private System.Windows.Forms.BindingSource sparesBindingSource;
        private ServiceStationDataSetTableAdapters.SparesTableAdapter sparesTableAdapter;
        private System.Windows.Forms.Button NewOrderBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpareName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufacturer;
    }
}