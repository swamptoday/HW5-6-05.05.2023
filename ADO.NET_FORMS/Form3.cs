using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Linq;



namespace ADO.NET_FORMS
{
    public partial class Form3 : Form
    {
        private static bool isId = true;
        public Form3()
        {
            InitializeComponent();

        }

        private void RefreshOrders()
        {
            // Build the SQL query
            string query_select = "SELECT ord_id AS id, ord_datetime AS date, an_name AS analysis_type FROM Orders INNER JOIN Analysis ON Orders.ord_an = Analysis.an_id";

            // Create a new SqlConnection object
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString1"].ConnectionString))
            {
                connection.Open();

                // Create a new SqlCommand object and set its CommandText and Connection properties
                SqlCommand command = new SqlCommand(query_select, connection);

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

        private void GetOrder(int id)
        {
            // Build the SQL query
            string query_select = "SELECT ord_id AS id, ord_datetime AS date, an_name AS analysis_type FROM Orders INNER JOIN Analysis ON Orders.ord_an = Analysis.an_id WHERE ord_id = @id";

            // Create a new SqlConnection object
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString1"].ConnectionString))
            {
                connection.Open();

                // Create a new SqlCommand object and set its CommandText and Connection properties
                SqlCommand command = new SqlCommand(query_select, connection);
                command.Parameters.AddWithValue("@id", id);

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

        private void GetOrdersByAn(int an)
        {
            // Build the SQL query
            string query = "SELECT ord_id AS id, ord_datetime AS date, an_name AS analysis_type FROM Orders INNER JOIN Analysis ON Orders.ord_an = Analysis.an_id WHERE ord_an = @an";

            // Create a new SqlConnection object
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString1"].ConnectionString))
            {
                // Create a new SqlCommand object and set its CommandText and Connection properties
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@an", an);

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

        private void Form3_Load(object sender, EventArgs e)
        {
            RefreshOrders();
            // create a SELECT statement to retrieve the analysis names and their IDs from the Analysis table
            string query_analysis = "SELECT an_id, an_name FROM Analysis";

            // Create a new SqlConnection object
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString1"].ConnectionString))
            {
                connection.Open();

                SqlCommand command_analysis = new SqlCommand(query_analysis, connection);

                SqlDataReader reader = command_analysis.ExecuteReader();

                // add each analysis name to the ComboBox
                while (reader.Read())
                {
                    comboBox1.Items.Add(new Item((int)reader["an_id"], (string)reader["an_name"]));
                }

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a valid row is clicked
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].DataBoundItem != null)
            {
                // Get the DataGridViewRow object
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                // Extract the data from the selected row and populate the textboxes
                idTextBox.Text = row.Cells["id"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["date"].Value);
                string analysisName = row.Cells["analysis_type"].Value.ToString();
                int analysisId;
                // Query the database for the matching row in the Analysis table
                string query = "SELECT an_id FROM Analysis WHERE an_name = @analysisName";
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString1"].ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@analysisName", analysisName);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        analysisId = (int)result;
                    }
                }

                Item selectedItem = comboBox1.Items.OfType<Item>().FirstOrDefault(item => item.Id == analysisId);
                comboBox1.SelectedItem = selectedItem;
            }
            else
            {
                MessageBox.Show("There is no data in this row!\nIf you want to add new data - write it in the object part and click on the insert button.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Get the ord_id value of the selected row from the DataGridView
            int ord_id = int.Parse(dataGridView1.CurrentRow.Cells["id"].Value.ToString());

            // Build the SQL query
            string query = "DELETE FROM Orders WHERE ord_id = @ord_id";

            // Create a new SqlConnection object
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString1"].ConnectionString))
            {
                // Create a new SqlCommand object and set its parameters
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ord_id", ord_id);

                // Open the connection and execute the command
                connection.Open();
                command.ExecuteNonQuery();
            }

            // Refresh the DataGridView to reflect the changes
            dataGridView1.DataSource = null;
            RefreshOrders();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            // Get the ord_id value of the selected row from the DataGridView
            DateTime date = dateTimePicker1.Value;
            string analysisName = comboBox1.Text;
            int analysisId;
            // Query the database for the matching row in the Analysis table
            string query_analysis = "SELECT an_id FROM Analysis WHERE an_name = @analysisName";
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString1"].ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query_analysis, connection))
                {
                    command.Parameters.AddWithValue("@analysisName", analysisName);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    analysisId = (int)result;
                }
            }

            // Build the SQL query
            string query = "INSERT INTO Orders (ord_datetime, ord_an) VALUES (@date, @ord_an); ";

            // Create a new SqlConnection object
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString1"].ConnectionString))
            {
                // Create a new SqlCommand object and set its parameters
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@ord_an", analysisId);

                // Open the connection and execute the command
                connection.Open();
                command.ExecuteNonQuery();
            }

            // Refresh the DataGridView to reflect the changes
            dataGridView1.DataSource = null;
            RefreshOrders();
        
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // Get the ord_id value of the selected row from the DataGridView
            int id = int.Parse(idTextBox.Text);
            DateTime date = dateTimePicker1.Value;
            string analysisName = comboBox1.Text;
            int analysisId;
            // Query the database for the matching row in the Analysis table
            string query_analysis = "SELECT an_id FROM Analysis WHERE an_name = @analysisName";
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString1"].ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query_analysis, connection))
                {
                    command.Parameters.AddWithValue("@analysisName", analysisName);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    analysisId = (int)result;
                }
            }

            // Build the SQL query
            string query = "UPDATE Orders SET ord_datetime = @date, ord_an = @ord_an WHERE ord_id = @id;";

            // Create a new SqlConnection object
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString1"].ConnectionString))
            {
                // Create a new SqlCommand object and set its parameters
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@ord_an", analysisId);

                // Open the connection and execute the command
                connection.Open();
                command.ExecuteNonQuery();
            }

            // Refresh the DataGridView to reflect the changes
            dataGridView1.DataSource = null;
            RefreshOrders();
        }

        private void DeleteButton_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(DeleteButton, "Delete selected object");
        }

        private void InsertButton_MouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(InsertButton, "Insert object");
        }

        private void UpdateButton_MouseHover(object sender, EventArgs e)
        {
            toolTip3.SetToolTip(UpdateButton, "Updated selected object");
        }

        private void ByIdRButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ByIdRButton.Checked)
            {
                isId = true;
                ByAnRButton.Checked = false;
            }
            else
            {
                isId = false;
                ByAnRButton.Checked = true;
            }
        }

        private void ByAnRButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ByAnRButton.Checked)
            {
                isId = false;
                ByIdRButton.Checked = false;
            }
            else
            {
                isId = true;
                ByIdRButton.Checked = true;
            }
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            if (isId)
            {
                //checking whether value is realy an integer
                string input = FilterBox.Text;
                int number;
                bool isNotInt = !int.TryParse(input, out number);
                if (isNotInt)
                {
                    MessageBox.Show("You need int value for id-find!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    GetOrder(int.Parse(FilterBox.Text));
                }
                
            }
            else
            {
                string input = FilterBox.Text;
                int number;
                bool isNotInt = !int.TryParse(input, out number);
                if (isNotInt)
                {
                    string analysisName = FilterBox.Text;
                    int analysisId;
                    // Query the database for the matching row in the Analysis table
                    string query_analysis = "SELECT an_id FROM Analysis WHERE an_name = @analysisName";
                    using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString1"].ConnectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query_analysis, connection))
                        {
                            command.Parameters.AddWithValue("@analysisName", analysisName);
                            connection.Open();
                            object result = command.ExecuteScalar();
                            analysisId = (int)result;
                        }
                    }

                    GetOrdersByAn(analysisId);
                }
                else
                {
                    MessageBox.Show("You need string value for id-find!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
