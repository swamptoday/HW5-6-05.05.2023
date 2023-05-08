using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace ADO.NET_FORMS
{
    public partial class Form2 : Form
    {
        private Form3 thirdForm; // declare Form3 instance at class level
        public Form2()
        {
            InitializeComponent();
            // create new instance of Form3 and assign to class-level variable
            thirdForm = new Form3();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            // Get the year entered by the user
            int year = int.Parse(yearTextBox.Text);

            // Build the SQL query
            string query = "SELECT ord_id AS id, ord_datetime AS date, an_name AS analysis_type FROM Orders INNER JOIN Analysis ON Orders.ord_an = Analysis.an_id WHERE YEAR(ord_datetime) = @year";

            // Create a new SqlConnection object
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString1"].ConnectionString))
            {
                // Create a new SqlCommand object and set its Connection and CommandText
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@year", year);

                // Create a new SqlDataReader object to hold the results of the query
                SqlDataReader reader;

                // Open the connection and execute the query
                connection.Open();
                reader = command.ExecuteReader();

                // Create a new DataTable object to hold the data
                DataTable table = new DataTable();

                // Load the SqlDataReader into the DataTable
                table.Load(reader);

                // Close the SqlDataReader and the SqlConnection
                reader.Close();
                connection.Close();

                // Bind the DataTable to the DataGridView control
                dataGridView1.DataSource = table;
            }
        }

        private void FindAdapterButton_Click(object sender, EventArgs e)
        {
            // Get the year entered by the user
            int year = int.Parse(yearTextBox.Text);

            // Build the SQL query
            string query = "SELECT ord_id AS id, ord_datetime AS date, an_name AS analysis_type FROM Orders INNER JOIN Analysis ON Orders.ord_an = Analysis.an_id WHERE YEAR(ord_datetime) = @year";

            // Create a new SqlConnection object
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString1"].ConnectionString))
            {
                // Create a new SqlCommand object and set its CommandText and Connection properties
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@year", year);

                // Create a new SqlDataAdapter object and set its SelectCommand
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // Create a new DataSet object to hold the data
                DataSet dataset = new DataSet();

                // Fill the DataSet with the results of the query
                adapter.Fill(dataset, "Orders");

                // Bind the DataSet to the DataGridView control
                dataGridView1.DataSource = dataset.Tables["Orders"];
            }
        }

        private void ToModifyButton_Click(object sender, EventArgs e)
        {
            // Show the third form
            thirdForm.Show();
            this.Hide();
        }
    }
}
