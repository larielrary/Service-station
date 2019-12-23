using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class NewOrder : Form
    {
        public NewOrder()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Не сохранять изменения?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
               /* MainForm mainForm = new MainForm();
                mainForm.ShowDialog();*/
            }
                this.TopMost = true;
            
        }

        private void NewOrder_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serviceStationDataSet.Model". При необходимости она может быть перемещена или удалена.
            this.modelTableAdapter.Fill(this.serviceStationDataSet.Model);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serviceStationDataSet.Worker". При необходимости она может быть перемещена или удалена.
            this.workerTableAdapter.Fill(this.serviceStationDataSet.Worker);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serviceStationDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.serviceStationDataSet.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serviceStationDataSet.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.serviceStationDataSet.Service);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}
