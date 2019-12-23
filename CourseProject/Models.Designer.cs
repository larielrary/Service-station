namespace CourseProject
{
    partial class Models
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
            this.modelIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearOfManufactureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceStationDataSet = new CourseProject.ServiceStationDataSet();
            this.modelTableAdapter = new CourseProject.ServiceStationDataSetTableAdapters.ModelTableAdapter();
            this.редактировать = new System.Windows.Forms.Button();
            this.удалить = new System.Windows.Forms.Button();
            this.выход = new System.Windows.Forms.Button();
            this.добавитб = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceStationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modelIdDataGridViewTextBoxColumn,
            this.modelNameDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.yearOfManufactureDataGridViewTextBoxColumn,
            this.inspectionDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.modelBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 455);
            this.dataGridView1.TabIndex = 0;
            // 
            // modelIdDataGridViewTextBoxColumn
            // 
            this.modelIdDataGridViewTextBoxColumn.DataPropertyName = "ModelId";
            this.modelIdDataGridViewTextBoxColumn.HeaderText = "ModelId";
            this.modelIdDataGridViewTextBoxColumn.Name = "modelIdDataGridViewTextBoxColumn";
            this.modelIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // modelNameDataGridViewTextBoxColumn
            // 
            this.modelNameDataGridViewTextBoxColumn.DataPropertyName = "ModelName";
            this.modelNameDataGridViewTextBoxColumn.HeaderText = "Марка и модель";
            this.modelNameDataGridViewTextBoxColumn.Name = "modelNameDataGridViewTextBoxColumn";
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Производитель";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            // 
            // yearOfManufactureDataGridViewTextBoxColumn
            // 
            this.yearOfManufactureDataGridViewTextBoxColumn.DataPropertyName = "YearOfManufacture";
            this.yearOfManufactureDataGridViewTextBoxColumn.HeaderText = "Год производства";
            this.yearOfManufactureDataGridViewTextBoxColumn.Name = "yearOfManufactureDataGridViewTextBoxColumn";
            // 
            // inspectionDateDataGridViewTextBoxColumn
            // 
            this.inspectionDateDataGridViewTextBoxColumn.DataPropertyName = "InspectionDate";
            this.inspectionDateDataGridViewTextBoxColumn.HeaderText = "Дата технического осмотра";
            this.inspectionDateDataGridViewTextBoxColumn.Name = "inspectionDateDataGridViewTextBoxColumn";
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataMember = "Model";
            this.modelBindingSource.DataSource = this.serviceStationDataSet;
            // 
            // serviceStationDataSet
            // 
            this.serviceStationDataSet.DataSetName = "ServiceStationDataSet";
            this.serviceStationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modelTableAdapter
            // 
            this.modelTableAdapter.ClearBeforeFill = true;
            // 
            // редактировать
            // 
            this.редактировать.Cursor = System.Windows.Forms.Cursors.Hand;
            this.редактировать.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.редактировать.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.редактировать.Location = new System.Drawing.Point(502, 110);
            this.редактировать.Name = "редактировать";
            this.редактировать.Size = new System.Drawing.Size(190, 37);
            this.редактировать.TabIndex = 5;
            this.редактировать.Text = "Редактировать";
            this.редактировать.UseVisualStyleBackColor = true;
            this.редактировать.Click += new System.EventHandler(this.редактировать_Click);
            // 
            // удалить
            // 
            this.удалить.Cursor = System.Windows.Forms.Cursors.Hand;
            this.удалить.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.удалить.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.удалить.Location = new System.Drawing.Point(502, 190);
            this.удалить.Name = "удалить";
            this.удалить.Size = new System.Drawing.Size(190, 37);
            this.удалить.TabIndex = 6;
            this.удалить.Text = "Удалить";
            this.удалить.UseVisualStyleBackColor = true;
            this.удалить.Click += new System.EventHandler(this.удалить_Click);
            // 
            // выход
            // 
            this.выход.Cursor = System.Windows.Forms.Cursors.Hand;
            this.выход.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.выход.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.выход.Location = new System.Drawing.Point(502, 430);
            this.выход.Name = "выход";
            this.выход.Size = new System.Drawing.Size(190, 37);
            this.выход.TabIndex = 7;
            this.выход.Text = "Выход";
            this.выход.UseVisualStyleBackColor = true;
            this.выход.Click += new System.EventHandler(this.выход_Click);
            // 
            // добавитб
            // 
            this.добавитб.Cursor = System.Windows.Forms.Cursors.Hand;
            this.добавитб.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.добавитб.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.добавитб.Location = new System.Drawing.Point(502, 40);
            this.добавитб.Name = "добавитб";
            this.добавитб.Size = new System.Drawing.Size(190, 37);
            this.добавитб.TabIndex = 9;
            this.добавитб.Text = "Добавить";
            this.добавитб.UseVisualStyleBackColor = true;
            this.добавитб.Click += new System.EventHandler(this.добавитб_Click);
            // 
            // AllModels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(712, 482);
            this.ControlBox = false;
            this.Controls.Add(this.добавитб);
            this.Controls.Add(this.выход);
            this.Controls.Add(this.удалить);
            this.Controls.Add(this.редактировать);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AllModels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AllModels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceStationDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ServiceStationDataSet serviceStationDataSet;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private ServiceStationDataSetTableAdapters.ModelTableAdapter modelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearOfManufactureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspectionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button редактировать;
        private System.Windows.Forms.Button удалить;
        private System.Windows.Forms.Button выход;
        private System.Windows.Forms.Button добавитб;
    }
}