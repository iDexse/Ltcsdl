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

namespace Lab7_Advanced_Command
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void LoadAccount()
        {
            string connectionString = "Data Source=DESKTOP-LFQOEKC;Initial Catalog=Restaurant_Management;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "select * from Account";
            sqlConnection.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dataReader);

            dgvAccount.DataSource = dt;
            sqlConnection.Close();
            sqlConnection.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring = "data source=desktop-lfqoekc;initial catalog=restaurant_management;integrated security=true";
            SqlConnection connection = new SqlConnection(connectionstring);

            SqlCommand command = connection.CreateCommand();
            command.CommandText = "EXECUTE InsertAccount @AccountName, @Password, @Fullname, @Email, @Tell, @DateCreated";

            command.Parameters.Add("@AccountName", SqlDbType.NVarChar,100);
            command.Parameters.Add("@Password", SqlDbType.NVarChar, 200);
            command.Parameters.Add("@Fullname", SqlDbType.NVarChar, 1000);
            command.Parameters.Add("@Email", SqlDbType.NVarChar, 1000);
            command.Parameters.Add("@Tell", SqlDbType.NVarChar, 200);
            command.Parameters.Add("@DateCreated", SqlDbType.SmallDateTime);

            command.Parameters["@AccountName"].Value = txtAccName.Text;
            command.Parameters["@Password"].Value = txtPass.Text;
            command.Parameters["@FullName"].Value = txtFullName.Text;
            command.Parameters["@Email"].Value = txtEmail.Text;
            command.Parameters["@Tell"].Value = mtxtTell.Text;
            command.Parameters["@DateCreated"].Value = dtpDateCreate.Value;
            connection.Open();

            int numrowaffected = command.ExecuteNonQuery();

            if (numrowaffected > 0)
            {
                MessageBox.Show("thêm thành công");
                this.LoadAccount();
            }
           else
            {
                MessageBox.Show("lỗi!");
            }

            connection.Close();
            connection.Dispose();
        }
    }
}
