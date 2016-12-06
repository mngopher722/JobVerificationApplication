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

namespace Job_Verification_Application
{
    public partial class AddClient : Form
    {
        //string conString = @"Data Source=LENOVO-PC\SQLEXPRESS;Initial Catalog=JobVerification; User ID=Ryan; Integrated Security = True";
        string conString = @"Data Source=MHDC2\SQLEXPRESS2014;Initial Catalog=JobVerification;User ID=Ticketmaster";
        public bool duplicateClient { get; private set; }

        public AddClient()
        {
            InitializeComponent();
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jobVerificationDataSet.CLIENT' table. You can move, or remove it, as needed.
            //this.cLIENTTableAdapter.Fill(this.jobVerificationDataSet.CLIENT);

        }

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{ }

        public void cWAddClientTextBox_Leave(object sender, EventArgs e)
        {
            duplicateClient = true;
            string cmdcheck = "select count (*) FROM CLIENT where ClientName = @ClientName";
            using (SqlConnection conn = new SqlConnection(conString))
            using (SqlCommand datacheck = new SqlCommand(cmdcheck, conn))
            {
                conn.Open();
                SqlParameter client = new SqlParameter("@ClientName", SqlDbType.NVarChar, 50);
                client.Value = cWAddClientTextBox.Text;

                datacheck.Parameters.Add(client);
                int result = (int)datacheck.ExecuteScalar();

                if (result > 0)
                {
                    MessageBox.Show("Client Already Exists in Database");
                }
                else
                {
                    duplicateClient = false;
                }
            }
        }
        
        
        private void cWCancelButton_Click(object sender, EventArgs e)
        {
            cWAddClientTextBox.Clear();
            this.Close();
        }

        private void cWSubmitButton_Click(object sender, EventArgs e)
        {
            if (cWAddClientTextBox.TextLength == 0)
            {
                MessageBox.Show("Please Enter Client Name");
                cWAddClientTextBox.Focus();
            }
            else if (duplicateClient)
            {
                MessageBox.Show("Client Already Exists in Database");
                cWAddClientTextBox.Focus();
            }
            else
            {
                try { 
                    string cmdcheck = "INSERT into CLIENT(ClientName) VALUES (@ClientName)";
                        using (SqlConnection conn = new SqlConnection(conString))
                        using (SqlCommand datacheck = new SqlCommand(cmdcheck, conn))
                        {
                            conn.Open();
                            SqlParameter client = new SqlParameter("@ClientName", SqlDbType.NVarChar, 50);
                            client.Value = cWAddClientTextBox.Text;

                            datacheck.Parameters.Add(client);
                            datacheck.ExecuteNonQuery();
                        this.Close();
                        }
                    }
                catch (Exception)
                {
                    MessageBox.Show("Failed to Add Client to Database");
                }
            }
        }
    }
}
