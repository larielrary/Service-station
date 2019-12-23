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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
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

        private void enterBtn_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            string connectString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\ServiceStation.mdf;Integrated Security=True";

            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            string query = "SELECT Auth.AuthLogin, Auth.AuthPass FROM Auth";

            SqlCommand command = new SqlCommand(query, myConnection);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[8]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
            }

            reader.Close();

            myConnection.Close();

            foreach (string[] s in data)
            {
                if (login == s[0] && password == s[1])
                {
                    //Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();

                }
                else
                {
                    DialogResult result = MessageBox.Show(
                        "Повторить вход",
                        "Неверные данные",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Error);
                    if (result == DialogResult.Yes)
                        Refresh();
                    //  this.TopMost = false;
                    break;

                }
            }
        }
    }
}
