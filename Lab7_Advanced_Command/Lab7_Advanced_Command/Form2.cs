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
           // string connectionstring = "data source=desktop-lfqoekc;initial catalog=restaurant_management;integrated security=true";
           // sqlconnection connection = new sqlconnection(connectionstring);

           // sqlcommand command = connection.createcommand();
           // command.commandtext = "execute insertaccount @accountname, @password, @fullname, @email, @tell, @datecreated";

           // command.parameters.add("@accountname", sqldbtype.nvarchar,100);
           // command.parameters.add("@password", sqldbtype.nvarchar, 200);
           // command.parameters.add("@fullname", sqldbtype.nvarchar, 1000);
           // command.parameters.add("@email", sqldbtype.nvarchar, 1000);
           // command.parameters.add("@tell", sqldbtype.nvarchar,200);
           // command.parameters.add("@datecreated", sqldbtype.smalldatetime);

           // command.parameters["@accountname"].value = txtaccname.text;
           // command.parameters["@password"].value = txtpass.text;
           // command.parameters["@fullname"].value = txtfullname.text;
           // command.parameters["@email"].value = txtemail.text;
           // command.parameters["@tell"].value = mtxttell.text;
           // command.parameters["@datecreated"].value=datetime;
           // connection.open();

           // int numrowaffected = command.executenonquery();

           // if (numrowaffected > 0)
           // {
           //     messagebox.show("thêm thành công");
           // }
           //else
           // {
           //     messagebox.show("lỗi!");
           // }

           // connection.close();
           // connection.dispose();
        }
    }
}
