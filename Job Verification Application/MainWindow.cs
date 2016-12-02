using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Verification_Application
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jobVerificationDataSet.JOB_X_BIN' table. You can move, or remove it, as needed.
            //this.jOB_X_BINTableAdapter.Fill(this.jobVerificationDataSet.JOB_X_BIN);
            // TODO: This line of code loads data into the 'jobVerificationDataSet.USER' table. You can move, or remove it, as needed.
            //this.uSERTableAdapter.Fill(this.jobVerificationDataSet.USER);
            // TODO: This line of code loads data into the 'jobVerificationDataSet.JOB' table. You can move, or remove it, as needed.
            //this.jOBTableAdapter.Fill(this.jobVerificationDataSet.JOB);
            // TODO: This line of code loads data into the 'jobVerificationDataSet.BIN' table. You can move, or remove it, as needed.
            //this.bINTableAdapter.Fill(this.jobVerificationDataSet.BIN);
            FillComboBox();
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            //exit application when form is closed
            Application.Exit();
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            AddClient addClient = new AddClient();
            addClient.Show();
        }

        private void addJobButton_Click(object sender, EventArgs e)
        {
            AddJob addJob = new AddJob();
            addJob.Show();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
        }

        protected void FillComboBox()
        {
            string conString = @"Data Source=MHDC2\SQLEXPRESS2014;Initial Catalog=JobVerification;User ID=Ticketmaster";
            SqlConnection conn = new SqlConnection(conString);
            DataSet user1 = new DataSet();
            DataSet user2 = new DataSet();
            DataSet jobnum = new DataSet();
            try
            {
                conn.Open();
                SqlCommand cmdUser = new SqlCommand("select CONCAT(UserLName, ', ', UserFName)as UserLastFirst, UserID UserFName, UserLName from dbo.[USER] order by UserLastFirst", conn);
                SqlCommand cmdJob = new SqlCommand("select CONCAT(JobID,' - ',ClientName) as JobClient, JobID from dbo.[JOB], CLIENT Where ClientID = FK_ClientID order by JobID", conn);
                SqlCommand cmdBin = new SqlCommand("select BinID from ");
                SqlDataAdapter ucb1 = new SqlDataAdapter();
                SqlDataAdapter ucb2 = new SqlDataAdapter();
                SqlDataAdapter job = new SqlDataAdapter();
                ucb1.SelectCommand = cmdUser;
                ucb2.SelectCommand = cmdUser;
                job.SelectCommand = cmdJob;
                ucb1.Fill(user1);
                ucb2.Fill(user2);
                job.Fill(jobnum);
                mWUser1ComboBox.DisplayMember = "UserLastFirst";
                mWUser1ComboBox.ValueMember = "UserID";
                mWUser1ComboBox.DataSource = user1.Tables[0];
                mWUser2ComboBox.DisplayMember = "UserLastFirst";
                mWUser2ComboBox.ValueMember = "UserID";
                mWUser2ComboBox.DataSource = user2.Tables[0];
                mWJobComboBox.DisplayMember = "JobClient";
                mWJobComboBox.ValueMember = "JobID";
                mWJobComboBox.DataSource = jobnum.Tables[0];

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

        private void configJobButton_Click(object sender, EventArgs e)
        {
            ConfigJob configJob = new ConfigJob();
            configJob.Show();
        }
    }
}
