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
    public partial class Workers : Form
    {
        string connectString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\ServiceStation.mdf;Integrated Security=True";
        public Workers()
        {
            InitializeComponent();
        }

        private void AllWorkers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serviceStationDataSet.Worker". При необходимости она может быть перемещена или удалена.
            //this.workerTableAdapter.Fill(this.serviceStationDataSet.Worker);
            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            string query = "SELECT Worker.FIO, Worker.Age, Worker.Adress, Worker.PhoneNum, Worker.Passport, Position.PositionName FROM Worker INNER JOIN Position ON Worker.PK_Position = Position.PositionID";

            SqlCommand command = new SqlCommand(query, myConnection);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[6]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
            }

            reader.Close();

            myConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void добавитб_Click(object sender, EventArgs e)
        {
            string SqlText;
            NewWorker newWorker = new NewWorker();
            if (newWorker.ShowDialog() == DialogResult.OK)
            {
                // сформировать SQL-строку
                SqlText = "INSERT INTO [Worker] ([FIO], [Age],[Adress],[PhoneNum],[Passport],[PK_Position]) VALUES (";
                SqlText = SqlText + "\'" + newWorker.textBox1.Text + "\', ";
                SqlText = SqlText + "\'" + newWorker.textBox2.Text + "\', ";
                SqlText = SqlText + "\'" + newWorker.textBox3.Text + "\', ";
                SqlText = SqlText + "\'" + newWorker.textBox4.Text + "\', ";
                SqlText = SqlText + "\'" + newWorker.textBox5.Text + "\', ";
                SqlText = SqlText + "\'" + Convert.ToInt32(newWorker.comboBox1.ValueMember) + "\')";

                // выполнить SQL-команду
                MyExecuteNonQuery(SqlText);
            }
            dataGridView1.Refresh();
        }

        private void редактировать_Click(object sender, EventArgs e)
        {
            int index, n;
            string SqlText = "UPDATE [Worker] SET ";
            string ID_Source, name, address;

            // проверка, есть ли вообще записи в таблице Source
            n = dataGridView1.Rows.Count;
            if (n == 1) return;

            UpdWorker f = new UpdWorker();

            // заполнить форму данными перед открытием
            index = dataGridView1.CurrentRow.Index;
            ID_Source = dataGridView1[0, index].Value.ToString();
            name = dataGridView1[1, index].Value.ToString();
            address = dataGridView1[2, index].Value.ToString();

        }

        private void удалить_Click(object sender, EventArgs e)
        {
            int index, n;
            string ID_Client;
            string SqlText = "DELETE FROM [Client] WHERE [Client].ClientID = ";

            // проверка, есть ли вообще записи в таблице Source
            n = dataGridView1.Rows.Count;
            if (n == 1) return;


            index = dataGridView1.CurrentRow.Index;
            ID_Client = Convert.ToString(dataGridView1[0, index].Value);

            // сформировать SQL-команду
            SqlText = SqlText + ID_Client;

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
