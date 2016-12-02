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
    public partial class AddJob : Form
    {
        public bool notDuplicateJob { get; private set; }
        public bool jwClientValidated { get; private set; }
        public bool jWJobDescValidated { get; private set; }
        public int result { get; private set; }

        public AddJob()
        {
            InitializeComponent();
        }

        private void AddJob_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jobVerificationDataSet.CLIENT' table. You can move, or remove it, as needed.
            this.cLIENTTableAdapter.Fill(this.jobVerificationDataSet.CLIENT);
            // TODO: This line of code loads data into the 'jobVerificationDataSet.BIN' table. You can move, or remove it, as needed.
            //this.bINTableAdapter.Fill(this.jobVerificationDataSet.BIN);
            FillComboBox();

        }

        private void jWJobNumMaskedTB_Leave(object sender, EventArgs e)
        {
            notDuplicateJob = false;
            string cmdcheck = "select count (*) FROM JOB where JobID = @JobID";
            using (SqlConnection conn = new SqlConnection(@"Data Source=MHDC2\SQLEXPRESS2014;Initial Catalog=JobVerification;User ID=Ticketmaster"))
            using (SqlCommand datacheck = new SqlCommand(cmdcheck, conn))
            {
                conn.Open();
                SqlParameter jobid = new SqlParameter("@JobID", SqlDbType.Int);
                jobid.Value = jWJobNumMaskedTB.Text;

                datacheck.Parameters.Add(jobid);
                result = (int)datacheck.ExecuteScalar();

                if (result > 0)
                {
                    MessageBox.Show("Job Already Exists in Database");
                    jWJobNumMaskedTB.Focus();
                }
                else
                {
                    notDuplicateJob = true;
                }
            }
        }

        private void jWCancelButton_Click(object sender, EventArgs e)
        {
            jWJobNumMaskedTB.Clear();
            jWJobDescTextBox.Clear();
            this.Close();
        }

        private void jWJobDescTextBox_Leave(object sender, EventArgs e)
        {
            jWJobDescValidated = false;
            if (jWJobDescTextBox.TextLength == 0)
            {
                MessageBox.Show("Please Enter Description of Job");
                jWJobDescTextBox.Focus();
            }
            else if (jWJobDescTextBox.TextLength > 50)
            {
                MessageBox.Show("Please Limit Description to Under 50 Characters");
                jWJobDescTextBox.Focus();
            }
            else
            {
                jWJobDescValidated = true;
            }

        }

        private void jWClientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            jwClientValidated = false;
            if (jWClientComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Client Associated with Job");
                jWClientComboBox.Focus();
            }
            else
            {
                jwClientValidated = true;
            }
        }

        private bool Validate()
        {
            notDuplicateJob = false;
            jWJobDescValidated = false;
            jwClientValidated = false;

            if (jWJobDescTextBox.TextLength == 0)
            {
                MessageBox.Show("Please Enter Description of Job");
                jWJobDescTextBox.Focus();
            }
            else if (jWJobDescTextBox.TextLength > 50)
            {
                MessageBox.Show("Please Limit Description to Under 50 Characters");
                jWJobDescTextBox.Focus();
            }
            else
            {
                jWJobDescValidated = true;
            }

            if (jWClientComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Client Associated with Job");
                jWClientComboBox.Focus();
            }
            else
            {
                jwClientValidated = true;
            }
            return false;
        }
        private void jWSubmitButton_Click(object sender, EventArgs e)
        {
            if (Validate()) 
            {
                try
                {
                    string cmdadd = "INSERT into Job(JobID, JobDesc, FK_ClientID) VALUES (@JobID, @JobDesc, @ClientID)";
                    using (SqlConnection conn = new SqlConnection(@"Data Source=MHDC2\SQLEXPRESS2014;Initial Catalog=JobVerification;User ID=Ticketmaster"))
                    using (SqlCommand dataAdd = new SqlCommand(cmdadd, conn))
                    {
                        conn.Open();
                        SqlParameter jobid = new SqlParameter("@JobID", SqlDbType.Int);
                        SqlParameter jobdesc = new SqlParameter("@JobDesc", SqlDbType.NVarChar, 50);
                        SqlParameter client = new SqlParameter("@ClientID", SqlDbType.Int);
                        jobid.Value = jWJobNumMaskedTB.Text;
                        jobdesc.Value = jWJobDescTextBox.Text;
                        client.Value = jWClientComboBox.SelectedIndex;
                        dataAdd.Parameters.Add(jobid);
                        dataAdd.Parameters.Add(jobdesc);
                        dataAdd.Parameters.Add(client);
                        dataAdd.CommandType = CommandType.Text;
                        dataAdd.ExecuteNonQuery();
                        
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to Add Job to Database");
                }
                    this.Close();
            }
            else
            {
                MessageBox.Show("Entries Failed Validation");
            }
            
        }
        protected void FillComboBox()
        {
            string conString = @"Data Source=MHDC2\SQLEXPRESS2014;Initial Catalog=JobVerification;User ID=Ticketmaster";
            SqlConnection conn = new SqlConnection(conString);
            DataSet client = new DataSet();
            try
            {
                conn.Open();
                SqlCommand cmdclient = new SqlCommand("select ClientID, ClientName from Client order by ClientID", conn);
                SqlDataAdapter da = new SqlDataAdapter();
                SqlDataAdapter db = new SqlDataAdapter();
                SqlDataAdapter dc = new SqlDataAdapter();
                dc.SelectCommand = cmdclient;
                dc.Fill(client);
                jWClientComboBox.DisplayMember = "ClientName";
                jWClientComboBox.ValueMember = "ClientID";
                jWClientComboBox.DataSource = client.Tables[0];

            }
            catch (Exception)
            {
                //Exception Message
                MessageBox.Show("Connection to the database has quit. Please reload Database");
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
    }
}
