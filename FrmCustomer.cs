using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace CSharpEgitimKampi601
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }

        string connectionString = "Server= localhost; port=5432; Database = CustomerDb; user Id = postgres; Password=2609"; 

        void GetAllCustomers()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From Customers";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void btnCustomerList_Click(object sender, EventArgs e)
        {
            GetAllCustomers();
        }

        private void btnCustomerCreate_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text;
            string customerCity = txtCustomerCity.Text;
            string customerSurname = txtCustomerSurname.Text;
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "insert into Customers (CustomerName, CustomerCity, CustomerSurname) values (@customerName, @customerCity, @customerSurname)";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@customerName", customerName);
            command.Parameters.AddWithValue("@customerSurname", customerSurname);
            command.Parameters.AddWithValue("@customerCity", customerCity);
            command.ExecuteNonQuery();
            MessageBox.Show("Customer added successfully");
            connection.Close();
            GetAllCustomers();

        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCustomerId.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "delete from Customers where CustomerId = @customerId";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@customerId", id);
            command.ExecuteNonQuery();
            MessageBox.Show("Customer deleted successfully");
            connection.Close();
            GetAllCustomers();

        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text;
            string customerCity = txtCustomerCity.Text;
            string customerSurname = txtCustomerSurname.Text;
            int id = int.Parse(txtCustomerId.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "update Customers set CustomerName = @customerName, CustomerCity = @customerCity, CustomerSurname = @customerSurname where CustomerId = @customerId";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@customerName", customerName);
            command.Parameters.AddWithValue("@customerSurname", customerSurname);
            command.Parameters.AddWithValue("@customerCity", customerCity);
            command.Parameters.AddWithValue("@customerId", id);
            command.ExecuteNonQuery();
            MessageBox.Show("Customer updated successfully");
            connection.Close();
            GetAllCustomers();



        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCustomerId.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From Customers where CustomerId = @customerId";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@customerId", id);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }
    }
}
