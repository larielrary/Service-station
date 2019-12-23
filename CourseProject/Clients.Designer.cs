namespace CourseProject
{
    partial class Clients
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
            this.добавитб = new System.Windows.Forms.Button();
            this.выход = new System.Windows.Forms.Button();
            this.удалить = new System.Windows.Forms.Button();
            this.редактировать = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serviceStationDataSet = new CourseProject.ServiceStationDataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new CourseProject.ServiceStationDataSetTableAdapters.ClientTableAdapter();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceStationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // добавитб
            // 
            this.добавитб.Cursor = System.Windows.Forms.Cursors.Hand;
            this.добавитб.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.добавитб.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.добавитб.Location = new System.Drawing.Point(422, 40);
            this.добавитб.Name = "добавитб";
            this.добавитб.Size = new System.Drawing.Size(190, 37);
            this.добавитб.TabIndex = 14;
            this.добавитб.Text = "Добавить";
            this.добавитб.UseVisualStyleBackColor = true;
            this.добавитб.Click += new System.EventHandler(this.добавитб_Click);
            // 
            // выход
            // 
            this.выход.Cursor = System.Windows.Forms.Cursors.Hand;
            this.выход.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.выход.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.выход.Location = new System.Drawing.Point(422, 420);
            this.выход.Name = "выход";
            this.выход.Size = new System.Drawing.Size(190, 37);
            this.выход.TabIndex = 13;
            this.выход.Text = "Выход";
            this.выход.UseVisualStyleBackColor = true;
            this.выход.Click += new System.EventHandler(this.выход_Click);
            // 
            // удалить
            // 
            this.удалить.Cursor = System.Windows.Forms.Cursors.Hand;
            this.удалить.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.удалить.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.удалить.Location = new System.Drawing.Point(422, 193);
            this.удалить.Name = "удалить";
            this.удалить.Size = new System.Drawing.Size(190, 37);
            this.удалить.TabIndex = 12;
            this.удалить.Text = "Удалить";
            this.удалить.UseVisualStyleBackColor = true;
            this.удалить.Click += new System.EventHandler(this.удалить_Click);
            // 
            // редактировать
            // 
            this.редактировать.Cursor = System.Windows.Forms.Cursors.Hand;
            this.редактировать.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.редактировать.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.редактировать.Location = new System.Drawing.Point(422, 114);
            this.редактировать.Name = "редактировать";
            this.редактировать.Size = new System.Drawing.Size(190, 37);
            this.редактировать.TabIndex = 11;
            this.редактировать.Text = "Редактировать";
            this.редактировать.UseVisualStyleBackColor = true;
            this.редактировать.Click += new System.EventHandler(this.редактировать_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIDDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.phoneNumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridView1.Location = new System.Drawing.Point(12, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(391, 436);
            this.dataGridView1.TabIndex = 10;
            // 
            // serviceStationDataSet
            // 
            this.serviceStationDataSet.DataSetName = "ServiceStationDataSet";
            this.serviceStationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.serviceStationDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "ФИО клиента";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            // 
            // phoneNumDataGridViewTextBoxColumn
            // 
            this.phoneNumDataGridViewTextBoxColumn.DataPropertyName = "PhoneNum";
            this.phoneNumDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
            this.phoneNumDataGridViewTextBoxColumn.Name = "phoneNumDataGridViewTextBoxColumn";
            // 
            // AllClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(629, 476);
            this.ControlBox = false;
            this.Controls.Add(this.добавитб);
            this.Controls.Add(this.выход);
            this.Controls.Add(this.удалить);
            this.Controls.Add(this.редактировать);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AllClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AllClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceStationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button добавитб;
        private System.Windows.Forms.Button выход;
        private System.Windows.Forms.Button удалить;
        private System.Windows.Forms.Button редактировать;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ServiceStationDataSet serviceStationDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private ServiceStationDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumDataGridViewTextBoxColumn;
    }
}