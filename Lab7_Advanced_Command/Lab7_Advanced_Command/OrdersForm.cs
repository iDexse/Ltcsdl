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
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
			LoadBills();

		}
		public void LoadBills()
		{
			string connectionString = "Data Source=DESKTOP-LFQOEKC;Initial Catalog=Restaurant_Management;Integrated Security=True";

			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			sqlCommand.CommandText = "SELECT * FROM Bills";

			sqlConnection.Open();

			string Bill = sqlCommand.ExecuteScalar().ToString();

			SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

			DataTable table = new DataTable("Food");
			adapter.Fill(table);

			dgvOrders.DataSource = table;

			sqlConnection.Close();
		}
	}
}
