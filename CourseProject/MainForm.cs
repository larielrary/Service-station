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
    public partial class MainForm : Form
    {
        string connectString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\ServiceStation.mdf;Integrated Security=True";
        public MainForm()
        {
            InitializeComponent();
        }

        private void всеЗаказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllOrders allOrders = new AllOrders();
            allOrders.ShowDialog();
        }

        private void найтиЗаказПоФамилииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void проверитьНаличиеДеталейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSpares checkSpares = new AddSpares();
            checkSpares.ShowDialog();
        }

        
        private void просмотретьВсеУслугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllServices allServices = new AllServices();
            allServices.ShowDialog();
        }

        private void запчастьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        
        private void CloseBtn_Click(object sender, EventArgs e)
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

        private void NewOrderBtn_Click(object sender, EventArgs e)
        {
            NewOrder newOrder = new NewOrder();
            //Hide();
            string SqlText;
            if (newOrder.ShowDialog() == DialogResult.OK)
            {
                // сформировать SQL-строку
                SqlText = "INSERT INTO [Orders] ([PK_Service], [PK_Client],[PK_Worker],[EtecutionMark],[Price],[OrderDate],[ReturnDate],[PK_Model]) VALUES (";
                SqlText = SqlText + "\'" + newOrder.comboBox1.ValueMember + "\', ";
                SqlText = SqlText + "\'" + newOrder.comboBox2.ValueMember + "\', ";
                SqlText = SqlText + "\'" + newOrder.comboBox3.ValueMember + "\', ";
                SqlText = SqlText + "\'" + newOrder.checkBox1.Text + "\', ";
                SqlText = SqlText + "\'" + newOrder.textBox1.Text + "\', ";
                SqlText = SqlText + "\'" + newOrder.dateTimePicker1.Value + "\', ";
                SqlText = SqlText + "\'" + newOrder.dateTimePicker2.Value + "\', ";
                SqlText = SqlText + "\'" + newOrder.comboBox4.ValueMember + "\')";

                // выполнить SQL-команду
                MyExecuteNonQuery(SqlText);
            }

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
        private void МодельToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Models models = new Models();
            models.ShowDialog();
        }

        private void заказчикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            clients.ShowDialog();
        }

        private void работникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Workers workers = new Workers();
            workers.ShowDialog();
        }

        private void просмотретьВыполненныеЗаказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecOrders execOrders = new ExecOrders();
            execOrders.ShowDialog();
        }
    }
}
