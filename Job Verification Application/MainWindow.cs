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
        string conString = @"Data Source=MHDC2\SQLEXPRESS2014;Initial Catalog=JobVerification;User ID=Ticketmaster; Integrated Security = True";
        //string conString = @"Data Source=LENOVO-PC\SQLEXPRESS;Initial Catalog=JobVerification; User ID=Ryan; Integrated Security = True";
        public object jobid { get; private set; }
        public SqlCommand querybin { get; private set; }

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
            Connection_Query con = Connection_Query.INSTANCE;
            SqlConnection conn = con.con;
            DataSet user1 = new DataSet();
            DataSet user2 = new DataSet();
            DataSet jobnum = new DataSet();
            //DataSet binnum = new DataSet();
            try
            {
                con.OpenConnection();
                SqlCommand cmdUser = new SqlCommand("select CONCAT(UserLName, ', ', UserFName)as UserLastFirst, UserID, UserFName, UserLName from dbo.[USER] order by UserLastFirst", conn);
                SqlCommand cmdJob = new SqlCommand("select CONCAT(JobID,' - ',ClientName) as JobClient, JobID from dbo.[JOB], CLIENT Where ClientID = FK_ClientID order by JobID", conn);
                //SqlCommand cmdBin = new SqlCommand("select JobID_X_BinID, FK_BinID, FK_JobID from JOB_X_BIN WHERE FK_JobID = @jobid", conn);
                SqlDataAdapter ucb1 = new SqlDataAdapter();
                SqlDataAdapter ucb2 = new SqlDataAdapter();
                SqlDataAdapter job = new SqlDataAdapter();
                //SqlDataAdapter bin = new SqlDataAdapter();
                ucb1.SelectCommand = cmdUser;
                ucb2.SelectCommand = cmdUser;
                job.SelectCommand = cmdJob;
                //bin.SelectCommand = cmdBin;
                ucb1.Fill(user1);
                ucb2.Fill(user2);
                job.Fill(jobnum);
                //bin.Fill(binnum);
                mWUser1ComboBox.DisplayMember = "UserLastFirst";
                mWUser1ComboBox.ValueMember = "UserID";
                mWUser1ComboBox.DataSource = user1.Tables[0];
                mWUser2ComboBox.DisplayMember = "UserLastFirst";
                mWUser2ComboBox.ValueMember = "UserID";
                mWUser2ComboBox.DataSource = user2.Tables[0];
                mWJobComboBox.DisplayMember = "JobClient";
                mWJobComboBox.ValueMember = "JobID";
                mWJobComboBox.DataSource = jobnum.Tables[0];
                //mWBinComboBox.DisplayMember = "FK_BinID";
                //mWBinComboBox.ValueMember = "JobID_X_BinID";
                //mWBinComboBox.DataSource = binnum.Tables[0];

            }
            catch (Exception ex)
            {
                //Exception Message
                MessageBox.Show("Connection to the database has quit. Please reload Database" + ex.StackTrace + ex.Message);
               
            }
            finally
            {
                con.CloseConnection();
                conn.Dispose();
            }
        }
        protected void FillBinComboBox( int jobnumber)
        {
            //string querybins = "select JobID_X_BinID, FK_BinID, FK_JobID from JOB_X_BIN WHERE FK_JobID = @jobid";
            Connection_Query con = Connection_Query.INSTANCE;
            SqlConnection conn = con.con;
            con.OpenConnection();
            SqlDataAdapter binadapter = new SqlDataAdapter("select [dbo].[BIN].[Index] as BinNumber, BinID, FK_JobID from BIN WHERE FK_JobID = @jobid", conn);
            using (SqlConnection conn = new SqlConnection(conString))
            using (SqlCommand dataAdd = new SqlCommand(cmdAdd, conn))
            {
                jobid.Value = jobnumber;
                binid.Value = insertingbin;


                dataAdd.Parameters.Add(jobid);
                dataAdd.Parameters.Add(binid);

                dataAdd.CommandType = CommandType.Text;

                dataAdd.ExecuteNonQuery();
                this.Close();
            }


            //binadapter.SelectCommand.Parameters.AddWithValue("jobid", mWJobComboBox.SelectedIndex);
            //DataSet dsBins = new DataSet("Bins");
            //binadapter.FillSchema(dsBins, SchemaType.Source, "Bins");
            //binadapter.Fill(dsBins, "Bins");
            //binadapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            con.CloseConnection();
        }

        private void configJobButton_Click(object sender, EventArgs e)
        {
            ConfigJob configJob = new ConfigJob();
            configJob.Show();
        }

        private void startProcessButton_Click(object sender, EventArgs e)
        {
            ScanningWindow scanWindow = new ScanningWindow();
            if (Validate())
            {
                try
                {
                    //List jobs = new List();
                    string cmdquery = "SELECT JobID_X_BinID as 'Process Number', FK_JobID, FK_BinID FROM JOB_X_BIN WHERE FK_JobID = @JobID AND FK_BinID = @BinID";
                    using (SqlConnection conn = new SqlConnection(conString))
                    using (SqlCommand dataquery = new SqlCommand(cmdquery, conn))

                    {
                        conn.Open();
                        //using (SqlDataReader reader = cmdquery.ExecuteReader())
                        //{
                        //    if (reader.HasRows)
                        //    {
                        //        while(reader.Read())
                        //        {
                        SqlParameter jobbinid = new SqlParameter("@jobbinid", SqlDbType.Int);
                        SqlParameter jobid = new SqlParameter("@JobID", SqlDbType.Int);
                        SqlParameter binid = new SqlParameter("@JobDesc", SqlDbType.TinyInt);
                        jobid.Value = mWJobComboBox.SelectedText;
                        binid.Value = mWBinComboBox.SelectedText;
                        dataquery.Parameters.Add(jobid);
                        dataquery.Parameters.Add(binid);
                        dataquery.CommandType = CommandType.Text;
                        dataquery.ExecuteScalar();

                        //        }
                        //    }
                        //}
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to Start Processing");
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Entries Failed Validation");
            }

        }

        private void mWJobComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            jobid = mWJobComboBox.SelectedValue;
            int jobnumber = Convert.ToInt32(jobid);
            FillBinComboBox(jobnumber);
        }
        //    static public int GetJobxBinID();
        //        {
        //            int JobBinID = 0;
        //    string sql = "INSERT INTO Production.ProductCategory (Name) VALUES (@Name);
        //            using (SqlConnection conn = new SqlConnection(@"Data Source=MHDC2\SQLEXPRESS2014;Initial Catalog=JobVerification;User ID=Ticketmaster"));
        //            {
        //                SqlCommand cmd = new SqlCommand(sql, conn);
        //cmd.Parameters.Add("@Name", SqlDbType.VarChar);
        //                cmd.Parameters["@name"].Value = newName;
        //                try
        //                {
        //                    conn.Open();
        //                    newProdID = (Int32)cmd.ExecuteScalar();
        //                }
        //                catch (Exception ex)
        //                {
        //                    Console.WriteLine(ex.Message);
        //                }
        //            }
        //            return (int)newProdID;
        //        }
        //    }
        //public void scanWindow_Pass(int jxbID, int xqty)
        //{
        //    int xpectedQty;
        //    int jobxbin_id;
        //    int.TryParse(xqtyTextBox.Text, out xpectedQty);
        //    int.TryParse(mW);
        //    xqty = xpectedQty;
        //}
    }
}

