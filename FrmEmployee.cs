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
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }

        string connectionString = "Server= localhost; port=5432; Database = CustomerDb; user Id = postgres; Password=2609";


        void EmployeeList()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From Employees";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        void DepartmentList()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From Departments";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            cmbEmployeeDepartment.DisplayMember = "DepartmentName";
            cmbEmployeeDepartment.ValueMember = "DepartmentId";
            cmbEmployeeDepartment.DataSource = dataTable;
            connection.Close();

        }
        private void btnList_Click(object sender, EventArgs e)
        {
            EmployeeList();


        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            EmployeeList();
            DepartmentList();

        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            string employeeName = txtEmployeeName.Text;
            string employeeSurname = txtEmployeeSurname.Text;
            int DepartmentId = (int)cmbEmployeeDepartment.SelectedValue;
            decimal employeeSalary = decimal.Parse(txtEmployeeSalary.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "insert into Employees (EmployeeName, EmployeeSurname, DepartmentId, EmployeeSalary) values (@employeeName, @employeeSurname, @DepartmentId, @employeeSalary)";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@employeeName", employeeName);
            command.Parameters.AddWithValue("@employeeSurname", employeeSurname);
            command.Parameters.AddWithValue("@DepartmentId", DepartmentId);
            command.Parameters.AddWithValue("@employeeSalary", employeeSalary);
            command.ExecuteNonQuery();
            MessageBox.Show("Employee added successfully");
            connection.Close();
            EmployeeList();


        }
    }
}
