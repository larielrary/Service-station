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
    public partial class AddSpares : Form
    {
        public AddSpares()
        {
            InitializeComponent();
            LoadData();
        }

        private void CheckSpares_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serviceStationDataSet.Spares". При необходимости она может быть перемещена или удалена.
            this.sparesTableAdapter.Fill(this.serviceStationDataSet.Spares);

        }
        private void LoadData()
        {
            string connectString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\ServiceStation.mdf;Integrated Security=True";

            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            string query = "SELECT Spares.SpareName, Spares.Existence, Spares.Price, ServicedShops.ShopName, SpareManufacturer.ManufacturerName  FROM  Spares INNER JOIN ServicedShops ON Spares.PK_Shop = ServicedShops.ServicedShopsId INNER JOIN SpareManufacturer ON  SpareManufacturer.PK_Shop = ServicedShops.ServicedShopsId WHERE Spares.Existence = 'False'";

            SqlCommand command = new SqlCommand(query, myConnection);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[5]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][3] = reader[4].ToString();
            }

            reader.Close();

            myConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
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

        private void заказатьBtn_Click(object sender, EventArgs e)
        {
            int ind = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1[1, ind].Value = true;
            //dataGridView1.Rows.RemoveAt(ind);

            dataGridView1.Refresh();
        }
    }
}
