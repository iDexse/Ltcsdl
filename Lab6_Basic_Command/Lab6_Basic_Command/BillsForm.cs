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

namespace Lab6_Basic_Command
{
    public partial class BillsForm : Form
    {
        public BillsForm()
        {
            InitializeComponent();
			LoadBills();

		}

        private void BillsForm_Load(object sender, EventArgs e)
        {

        }
		public void LoadBills()
		{
			string connectionString = "Data Source=DESKTOP-LFQOEKC;Initial Catalog=Restaurant_Management;Integrated Security=True";

			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			sqlCommand.CommandText = "SELECT * FROM Bills";

			sqlConnection.Open();

			string categoryName = sqlCommand.ExecuteScalar().ToString();
			this.Text = "Danh sách toàn bộ hóa đơn";

			SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

			DataTable table = new DataTable("Food");
			adapter.Fill(table);

			dgvHoaDon.DataSource = table;

			
			dgvHoaDon.Columns[0].ReadOnly = true;

			sqlConnection.Close();
		}
	}
}
