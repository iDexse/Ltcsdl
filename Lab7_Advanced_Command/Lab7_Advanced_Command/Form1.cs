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
    public partial class btnHoaDon : Form
    {
        private DataTable foodTable;
        public btnHoaDon()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            this.LoadCategory();
         
        }
        public void LoadCategory()
        {
            string connectionString = "Data Source=DESKTOP-LFQOEKC;Initial Catalog=Restaurant_Management;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "select ID, Name From Category " ;

            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            
            sqlConnection.Open();
            da.Fill(dt);
           
            sqlConnection.Close();
            sqlConnection.Dispose();
             cbbCategory.DataSource = dt;
            cbbCategory.DisplayMember = "Name";

            cbbCategory.ValueMember = "ID";
           
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCategory.SelectedIndex == -1) return;
            string connectionString = "Data Source=DESKTOP-LFQOEKC;Initial Catalog=Restaurant_Management;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "select * from Food Where FoodCategoryID = @categoryId ";
            
            sqlCommand.Parameters.Add("@categoryId", SqlDbType.Int);

            if(cbbCategory.SelectedValue is DataRowView)
            {
                DataRowView rowView = cbbCategory.SelectedValue as DataRowView;
                sqlCommand.Parameters["@categoryId"].Value = rowView["ID"];
            }
            else
            {
                sqlCommand.Parameters["@categoryId"].Value = cbbCategory.SelectedValue;
            }
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            foodTable = new DataTable();
            sqlConnection.Open();
           
            adapter.Fill(foodTable);
            
            sqlConnection.Close();
            sqlConnection.Dispose();

            dgvFoodList.DataSource = foodTable;

            dgvFoodList.Columns["ID"].HeaderText = "mã món ăn";
            dgvFoodList.Columns["Name"].HeaderText = "tên món ăn";
            dgvFoodList.Columns["Unit"].HeaderText = "đơn vị tính";
            dgvFoodList.Columns["FoodCategoryID"].HeaderText = "mã nhóm món ăn";
            dgvFoodList.Columns["Price"].HeaderText = "đơn giá";
            dgvFoodList.Columns["Notes"].HeaderText = "ghi chú";

            lblQuantity.Text = foodTable.Rows.Count.ToString();
            lblCatName.Text = cbbCategory.Text;
        }

        private void tsmCalculateQuantity_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-LFQOEKC;Initial Catalog=Restaurant_Management;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "select @numSalefood = sum(Quantity) from BillDetails Where FoodID = @foodId ";
            
            if (dgvFoodList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];

                DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

                sqlCommand.Parameters.Add("@foodId", SqlDbType.Int);
                sqlCommand.Parameters["@foodId"].Value = rowView["ID"];

                sqlCommand.Parameters.Add("@numSaleFood", SqlDbType.Int);
                sqlCommand.Parameters["@numSaleFood"].Direction = ParameterDirection.Output;

                sqlConnection.Open();

                sqlCommand.ExecuteNonQuery();

                string result = sqlCommand.Parameters["@numSaleFood"].Value.ToString();
                string message = $"Tổng số lượng món {rowView["Name"]} đã bán là {result} {rowView["Unit"]}";

                if (string.IsNullOrWhiteSpace(result))
                    message = $"Món {rowView["Name"]} chưa bán được {rowView["Unit"]} nào!";

                MessageBox.Show(message);

                sqlConnection.Close();
            }

            sqlCommand.Dispose();
            sqlConnection.Dispose();
        }
        private void FormFood_FormClosed(object sender, FormClosedEventArgs e)
        {
            int index = cbbCategory.SelectedIndex;
            cbbCategory.SelectedIndex = -1;
            cbbCategory.SelectedIndex = index;
        }
        private void tsmAddFood_Click(object sender, EventArgs e)
        {
            FoodInfoForm formFood = new FoodInfoForm();
            formFood.FormClosed += FormFood_FormClosed;

            formFood.Show(this);
        }

        private void tsmUpdateFood_Click(object sender, EventArgs e)
        {
            if (dgvFoodList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
                DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

                FoodInfoForm foodForm = new FoodInfoForm();
                foodForm.FormClosed += new FormClosedEventHandler(FormFood_FormClosed);

                foodForm.Show(this);
                foodForm.DisplayFoodInfo(rowView);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (foodTable == null) return;

            string filterExpression = $"Name LIKE '%{txtSearch.Text}%'";
            string sortExpression = "Price DESC";

            DataViewRowState rowStateFilter = DataViewRowState.OriginalRows;

            DataView foodView = new DataView(foodTable, filterExpression, sortExpression, rowStateFilter);

            dgvFoodList.DataSource = foodView;
        }

        

       

        private void btnAccount_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrdersForm frm = new OrdersForm();
            frm.ShowDialog();
        }
    }
}
