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
    public partial class Models : Form
    {
        string connectString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\ServiceStation.mdf;Integrated Security=True";
        public Models()
        {
            InitializeComponent();
        }

        private void AllModels_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serviceStationDataSet.Model". При необходимости она может быть перемещена или удалена.
            this.modelTableAdapter.Fill(this.serviceStationDataSet.Model);

        }

        private void редактировать_Click(object sender, EventArgs e)
        {
            int index, n;
            string SqlText = "UPDATE [Model] SET ";
            string ID_Source, name, address;

            // проверка, есть ли вообще записи в таблице Source
            n = dataGridView1.Rows.Count;
            if (n == 1) return;

            UpdModel f = new UpdModel();

            // заполнить форму данными перед открытием
            index = dataGridView1.CurrentRow.Index;
            ID_Source = dataGridView1[0, index].Value.ToString();
            name = dataGridView1[1, index].Value.ToString();
            address = dataGridView1[2, index].Value.ToString();

            /*f.textBox1.Text = name;
            f.textBox2.Text = address;

            if (f.ShowDialog() == DialogResult.OK)
            {
                name = f.textBox1.Text;
                address = f.textBox2.Text;
                SqlText += "Name = \'" + name + "\', Address = '" + address + "\' ";
                SqlText += "WHERE [Source].ID_Source = " + ID_Source;
                MyExecuteNonQuery(SqlText);
                FillSource();
            }*/
        }

        private void выход_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы уверены?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
            this.TopMost = true;
        }

        private void удалить_Click(object sender, EventArgs e)
        {
            int index, n;
            string ID_Model;
            string SqlText = "DELETE FROM [Model] WHERE [Model].ModelID = ";

            // проверка, есть ли вообще записи в таблице Source
            n = dataGridView1.Rows.Count;
            if (n == 1) return;


            index = dataGridView1.CurrentRow.Index;
            ID_Model = Convert.ToString(dataGridView1[0, index].Value);

            // сформировать SQL-команду
            SqlText = SqlText + ID_Model;

            DialogResult result = MessageBox.Show(
                "Вы уверены?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // выполнить SQL-команду
                MyExecuteNonQuery(SqlText);
                dataGridView1.Refresh();
            }
            this.TopMost = true;
        }

        private void добавитб_Click(object sender, EventArgs e)
        {
            string SqlText;
            NewModel newmodel = new NewModel();
            if (newmodel.ShowDialog() == DialogResult.OK)
            {
                // сформировать SQL-строку
                SqlText = "INSERT INTO [Model] ([ModelName], [Manufacturer],[YearManufacture], [InspectionDate]) VALUES (";
                SqlText = SqlText + "\'" + newmodel.textBox1.Text + "\', ";
                SqlText = SqlText + "\'" + newmodel.textBox2.Text + "\', ";
                SqlText = SqlText + "\'" + newmodel.textBox3.Text + "\', ";
                SqlText = SqlText + "\'" + newmodel.dateTimePicker1.Value + "\')";
                // выполнить SQL-команду
                MyExecuteNonQuery(SqlText);
            }
            dataGridView1.Refresh();
        }
        public void MyExecuteNonQuery(string SqlText)
        {
            SqlConnection cn; // экземпляр класса типа SqlConnection
            SqlCommand cmd;

            // выделение памяти с инициализацией строки соединения с базой данных
            cn = new SqlConnection(connectString);
            cn.Open(); // открыть источник данных
            cmd = cn.CreateCommand(); // задать SQL-команду
            cmd.CommandText = SqlText; // задать командную строку
            cmd.ExecuteNonQuery(); // выполнить SQL-команду
            cn.Close(); // закрыть источник данных
        }
    }
}
