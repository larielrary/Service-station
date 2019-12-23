namespace CourseProject
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.просмотретьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеЗаказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверитьНаличиеДеталейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьВсеУслугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьВыполненныеЗаказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьРемонтируемуюМодельToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказчикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.NewOrderBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(116, 48);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 303);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотретьToolStripMenuItem,
            this.добавитьЗаписьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(524, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // просмотретьToolStripMenuItem
            // 
            this.просмотретьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.всеЗаказыToolStripMenuItem,
            this.проверитьНаличиеДеталейToolStripMenuItem,
            this.просмотретьВсеУслугиToolStripMenuItem,
            this.просмотретьВыполненныеЗаказыToolStripMenuItem});
            this.просмотретьToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.просмотретьToolStripMenuItem.Name = "просмотретьToolStripMenuItem";
            this.просмотретьToolStripMenuItem.Size = new System.Drawing.Size(93, 27);
            this.просмотретьToolStripMenuItem.Text = "Просмотр";
            // 
            // всеЗаказыToolStripMenuItem
            // 
            this.всеЗаказыToolStripMenuItem.Name = "всеЗаказыToolStripMenuItem";
            this.всеЗаказыToolStripMenuItem.Size = new System.Drawing.Size(322, 28);
            this.всеЗаказыToolStripMenuItem.Text = "Просмотреть все заказы";
            this.всеЗаказыToolStripMenuItem.Click += new System.EventHandler(this.всеЗаказыToolStripMenuItem_Click);
            // 
            // проверитьНаличиеДеталейToolStripMenuItem
            // 
            this.проверитьНаличиеДеталейToolStripMenuItem.Name = "проверитьНаличиеДеталейToolStripMenuItem";
            this.проверитьНаличиеДеталейToolStripMenuItem.Size = new System.Drawing.Size(322, 28);
            this.проверитьНаличиеДеталейToolStripMenuItem.Text = "Проверить наличие запчастей";
            this.проверитьНаличиеДеталейToolStripMenuItem.Click += new System.EventHandler(this.проверитьНаличиеДеталейToolStripMenuItem_Click);
            // 
            // просмотретьВсеУслугиToolStripMenuItem
            // 
            this.просмотретьВсеУслугиToolStripMenuItem.Name = "просмотретьВсеУслугиToolStripMenuItem";
            this.просмотретьВсеУслугиToolStripMenuItem.Size = new System.Drawing.Size(322, 28);
            this.просмотретьВсеУслугиToolStripMenuItem.Text = "Просмотреть все услуги";
            this.просмотретьВсеУслугиToolStripMenuItem.Click += new System.EventHandler(this.просмотретьВсеУслугиToolStripMenuItem_Click);
            // 
            // просмотретьВыполненныеЗаказыToolStripMenuItem
            // 
            this.просмотретьВыполненныеЗаказыToolStripMenuItem.Name = "просмотретьВыполненныеЗаказыToolStripMenuItem";
            this.просмотретьВыполненныеЗаказыToolStripMenuItem.Size = new System.Drawing.Size(322, 28);
            this.просмотретьВыполненныеЗаказыToolStripMenuItem.Text = "Просмотреть выполненные заказы";
            this.просмотретьВыполненныеЗаказыToolStripMenuItem.Click += new System.EventHandler(this.просмотретьВыполненныеЗаказыToolStripMenuItem_Click);
            // 
            // добавитьЗаписьToolStripMenuItem
            // 
            this.добавитьЗаписьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьРемонтируемуюМодельToolStripMenuItem,
            this.заказчикToolStripMenuItem,
            this.работникToolStripMenuItem});
            this.добавитьЗаписьToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 9.75F);
            this.добавитьЗаписьToolStripMenuItem.Name = "добавитьЗаписьToolStripMenuItem";
            this.добавитьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(127, 27);
            this.добавитьЗаписьToolStripMenuItem.Text = "Работа с базой";
            // 
            // добавитьРемонтируемуюМодельToolStripMenuItem
            // 
            this.добавитьРемонтируемуюМодельToolStripMenuItem.Name = "добавитьРемонтируемуюМодельToolStripMenuItem";
            this.добавитьРемонтируемуюМодельToolStripMenuItem.Size = new System.Drawing.Size(244, 28);
            this.добавитьРемонтируемуюМодельToolStripMenuItem.Text = "Ремонтируемая модель";
            this.добавитьРемонтируемуюМодельToolStripMenuItem.Click += new System.EventHandler(this.МодельToolStripMenuItem_Click);
            // 
            // заказчикToolStripMenuItem
            // 
            this.заказчикToolStripMenuItem.Name = "заказчикToolStripMenuItem";
            this.заказчикToolStripMenuItem.Size = new System.Drawing.Size(244, 28);
            this.заказчикToolStripMenuItem.Text = "Заказчик ";
            this.заказчикToolStripMenuItem.Click += new System.EventHandler(this.заказчикToolStripMenuItem_Click);
            // 
            // работникToolStripMenuItem
            // 
            this.работникToolStripMenuItem.Name = "работникToolStripMenuItem";
            this.работникToolStripMenuItem.Size = new System.Drawing.Size(244, 28);
            this.работникToolStripMenuItem.Text = "Сотрудник";
            this.работникToolStripMenuItem.Click += new System.EventHandler(this.работникToolStripMenuItem_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.CloseBtn.Location = new System.Drawing.Point(298, 373);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(190, 37);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "Выйти из программы";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // NewOrderBtn
            // 
            this.NewOrderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewOrderBtn.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewOrderBtn.Location = new System.Drawing.Point(38, 372);
            this.NewOrderBtn.Name = "NewOrderBtn";
            this.NewOrderBtn.Size = new System.Drawing.Size(190, 37);
            this.NewOrderBtn.TabIndex = 3;
            this.NewOrderBtn.Text = "Оформить заказ";
            this.NewOrderBtn.UseVisualStyleBackColor = true;
            this.NewOrderBtn.Click += new System.EventHandler(this.NewOrderBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(524, 442);
            this.ControlBox = false;
            this.Controls.Add(this.NewOrderBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem просмотретьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеЗаказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверитьНаличиеДеталейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотретьВсеУслугиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьРемонтируемуюМодельToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказчикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работникToolStripMenuItem;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button NewOrderBtn;
        private System.Windows.Forms.ToolStripMenuItem просмотретьВыполненныеЗаказыToolStripMenuItem;
    }
}

