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
    public partial class Clients : Form
    {
        string connectString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\ServiceStation.mdf;Integrated Security=True";
        public Clients()
        {
            InitializeComponent();
        }

        private void AllClients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serviceStationDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.serviceStationDataSet.Client);

        }

        private void добавитб_Click(object sender, EventArgs e)
        {
            string SqlText;
            NewClient newClient = new NewClient();
            if(newClient.ShowDialog() == DialogResult.OK)
            {
                // сформировать SQL-строку
                SqlText = "INSERT INTO [Client] ([FIO], [Adress],[PhoneNum]) VALUES (";
                SqlText = SqlText + "\'" + newClient.textBox1.Text + "\', ";
                SqlText = SqlText + "\'" + newClient.textBox3.Text + "\', ";
                SqlText = SqlText + "\'" + newClient.textBox4.Text + "\')";

                // выполнить SQL-команду
                MyExecuteNonQuery(SqlText);
            }
            dataGridView1.Refresh();

        }

        private void редактировать_Click(object sender, EventArgs e)
        {
            int index, n;
            string SqlText = "UPDATE [Client] SET ";
            string ID_Source, name, address;

            // проверка, есть ли вообще записи в таблице Source
            n = dataGridView1.Rows.Count;
            if (n == 1) return;

            UpdClient f = new UpdClient();

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
            /*if (f.ShowDialog() == DialogResult.OK) // вывести форму
            {
                
                // отобразить таблицу Source
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
