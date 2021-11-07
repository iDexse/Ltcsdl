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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void LoadFood(int CategoryID)
        {
            string connectionString = "Data Source=DESKTOP-LFQOEKC;Initial Catalog=Restaurant_Management;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "select Name from Category where ID = "+ CategoryID;

            sqlConnection.Open();

            string catName = sqlCommand.ExecuteScalar().ToString();
            this.Text = "Danh sách các món ăn thuộc nhóm: " + catName;

            sqlCommand.CommandText = "select * from Food where FoodCategoryID = " + CategoryID;

            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

            DataTable dt = new DataTable("Food");
            da.Fill(dt);

            dgvFood.DataSource = dt;

            dgvFood.Columns["ID"].HeaderText = "mã món ăn";
            dgvFood.Columns["Name"].HeaderText = "tên món ăn";
            dgvFood.Columns["Unit"].HeaderText = "đơn vị tính";
            dgvFood.Columns["FoodCategoryID"].HeaderText = "mã nhóm món ăn";
            dgvFood.Columns["Price"].HeaderText = "đơn giá";
            dgvFood.Columns["Notes"].HeaderText = "ghi chú";

            sqlConnection.Close();
            sqlConnection.Dispose();
            da.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvFood.SelectedRows.Count == 0) return;
            string connectionString = "Data Source=DESKTOP-LFQOEKC;Initial Catalog=Restaurant_Management;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            sqlConnection.Open();

            var selectedRow = dgvFood.SelectedRows[0];
            string ID = selectedRow.Cells[0].Value.ToString();
            sqlCommand.CommandText = "DELETE FROM Food WHERE ID = " + ID;
            int numOfRowEffected = sqlCommand.ExecuteNonQuery();
           
            
            if (numOfRowEffected == 1)
            {
                dgvFood.Rows.Remove(selectedRow);
                MessageBox.Show("Xóa món ăn thành công");
            }
            else
            {
                MessageBox.Show("Lỗi, vui lòng thử lại");
            }
            sqlConnection.Close();

        }
    }
}
