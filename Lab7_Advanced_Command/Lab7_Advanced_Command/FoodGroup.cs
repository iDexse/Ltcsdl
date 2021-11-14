using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_Advanced_Command
{
    public partial class FoodGroup : Form
    {
        public FoodGroup()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-LFQOEKC;Initial Catalog=Restaurant_Management;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = connection.CreateCommand();
            command.CommandText = "EXECUTE InsertCategory @id OUTPUT, @name, @type";

            command.Parameters.Add("@id", SqlDbType.Int);
            command.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
            command.Parameters.Add("@type", SqlDbType.Int);
            
            command.Parameters["@id"].Direction = ParameterDirection.Output;
            command.Parameters["@name"].Value = txtName.Text;
            command.Parameters["@type"].Value = txtType.Text;
            
            connection.Open();

            int numRowAffected = command.ExecuteNonQuery();

            if (numRowAffected > 0)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Lỗi!");
            }
            connection.Close();
            connection.Dispose();
            //SqlCommand command = connection.CreateCommand();
            //command.CommandText = @"Insert into Category Values(@Name, @Type)";

            //connection.Open();

            //command.Parameters.AddWithValue("@Name", txtName.Text.Trim());
            //command.Parameters.AddWithValue("@Type", int.Parse(txtType.Text));

            //int numOfRow = command.ExecuteNonQuery();
            //if (numOfRow > 0)
            //{
            //    MessageBox.Show("Thêm thành công");
            //}
            //else
            //{
            //    MessageBox.Show("Lỗi!");
            //}
            //connection.Close();
            //connection.Dispose();

        }

        private void FoodGroup_Load(object sender, EventArgs e)
        {

        }
    }
}
