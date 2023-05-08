using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ADO.NET_FORMS
{
    public partial class Form1 : Form
    {
        private Form2 secondForm; // declare Form2 instance at class level
        public Form1()
        {
            InitializeComponent();

            // create new instance of Form2 and assign to class-level variable
            secondForm = new Form2();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Build the connection string from the input values
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = serverTextBox.Text;
            builder.InitialCatalog = dbTextBox.Text;
            builder.IntegratedSecurity = true;
            builder.Pooling = true;

            //putting connection string into the config files
            var setting = new ConnectionStringSettings
            {
                Name = "ConnectionString1",
                ConnectionString = builder.ConnectionString
            };

            //add connection string to configuration file
            Configuration config;
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings.Add(setting);
            config.Save();

            //encrypting data about connection string
            ConnectionStringsSection section = config.GetSection("connectionStrings") as ConnectionStringsSection;

            if (!section.SectionInformation.IsProtected)
            {
                section.SectionInformation.ProtectSection(
                    "DataProtectionConfigurationProvider");
            }

            // Connect to the database
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString1"].ConnectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Connection successful!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message);
                }
            }


            // Show the second form
            secondForm.Show();
            this.Hide();
        }
    }
}
