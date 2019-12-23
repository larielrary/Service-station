namespace CourseProject
{
    partial class Workers
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
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceStationDataSet = new CourseProject.ServiceStationDataSet();
            this.workerTableAdapter = new CourseProject.ServiceStationDataSetTableAdapters.WorkerTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceStationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // добавитб
            // 
            this.добавитб.Cursor = System.Windows.Forms.Cursors.Hand;
            this.добавитб.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.добавитб.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.добавитб.Location = new System.Drawing.Point(502, 40);
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
            this.выход.Location = new System.Drawing.Point(502, 430);
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
            this.удалить.Location = new System.Drawing.Point(502, 190);
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
            this.редактировать.Location = new System.Drawing.Point(502, 110);
            this.редактировать.Name = "редактировать";
            this.редактировать.Size = new System.Drawing.Size(190, 37);
            this.редактировать.TabIndex = 11;
            this.редактировать.Text = "Редактировать";
            this.редактировать.UseVisualStyleBackColor = true;
            this.редактировать.Click += new System.EventHandler(this.редактировать_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 455);
            this.dataGridView1.TabIndex = 10;
            // 
            // workerBindingSource
            // 
            this.workerBindingSource.DataMember = "Worker";
            this.workerBindingSource.DataSource = this.serviceStationDataSet;
            // 
            // serviceStationDataSet
            // 
            this.serviceStationDataSet.DataSetName = "ServiceStationDataSet";
            this.serviceStationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workerTableAdapter
            // 
            this.workerTableAdapter.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ФИО";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Возраст";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Адрес";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Номер телефона";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Паспортные данные";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Должность";
            this.Column6.Name = "Column6";
            // 
            // Workers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(707, 482);
            this.ControlBox = false;
            this.Controls.Add(this.добавитб);
            this.Controls.Add(this.выход);
            this.Controls.Add(this.удалить);
            this.Controls.Add(this.редактировать);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Workers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AllWorkers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceStationDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button добавитб;
        private System.Windows.Forms.Button выход;
        private System.Windows.Forms.Button удалить;
        private System.Windows.Forms.Button редактировать;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ServiceStationDataSet serviceStationDataSet;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private ServiceStationDataSetTableAdapters.WorkerTableAdapter workerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}