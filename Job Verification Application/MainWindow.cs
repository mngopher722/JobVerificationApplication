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

        DataRow dr;
        public object jobid { get; private set; }
        public SqlCommand querybin { get; private set; }
        public int Jobid { get; private set; }
        public object binid { get; private set; }
        public int userOneID { get; private set; }
        public int userTwoID { get; private set; }
        public int userCount { get; private set; }
        public int userID { get; private set; }
        public int[] users { get; private set; }

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

            try
            {
                con.OpenConnection();
                SqlCommand cmdUser = new SqlCommand("select CONCAT(UserLName, ', ', UserFName)as UserLastFirst, UserID, UserFName, UserLName from dbo.[USER] order by UserLastFirst", conn);
                SqlCommand cmdJob = new SqlCommand("select CONCAT(JobID,' - ',ClientName) as JobClient, JobID from dbo.[JOB], CLIENT Where ClientID = FK_ClientID order by JobID", conn);

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
        protected void FillBinComboBox(int jobnumber)
        {
            Connection_Query con = Connection_Query.INSTANCE;
            SqlConnection conn = con.con;
            DataSet binnum = new DataSet();
            try
            {
                con.OpenConnection();
                SqlCommand bins = new SqlCommand("select [dbo].[BIN].[Index] as BinNumber, BinID, FK_JobID from BIN WHERE FK_JobID = @Jobid And Completed = 'False'", conn);
                bins.Parameters.AddWithValue("Jobid", jobnumber);
                SqlDataAdapter binnumbers = new SqlDataAdapter(bins);
                DataTable dt = new DataTable();
                binnumbers.Fill(dt);
                con.CloseConnection();
                dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, 0 };
                dt.Rows.InsertAt(dr, 0);
                mWBinComboBox.DataSource = dt;
                mWBinComboBox.DisplayMember = "BinNumber";
                mWBinComboBox.ValueMember = "BinID";
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
                if (userCount > 0)
                {
                    try
                    {
                        //List jobs = new List();
                        string binTableUpdate = "UPDATE BIN SET XpectedQuantity = @XQty WHERE BinID = @BinID";
                        using (SqlConnection conn = new SqlConnection(conString))
                        using (SqlCommand updateBinTable = new SqlCommand(binTableUpdate, conn))
                        {
                            conn.Open();
                            SqlParameter xqty = new SqlParameter("@XQty", SqlDbType.SmallInt);
                            SqlParameter binId = new SqlParameter("@BinID", SqlDbType.Int);
                            xqty.Value = xqtyTextBox.Text;
                            binId.Value = binid;
                            updateBinTable.Parameters.Add(xqty);
                            updateBinTable.Parameters.Add(binId);
                            updateBinTable.CommandType = CommandType.Text;
                            updateBinTable.ExecuteNonQuery();

                            
                            //TODO - Finish Createing 2 different record for same job by 2 different users
                            string processTableUpdate = "INSERT into USER_X_BIN(FK_UserID, FK_BinID) VALUES(@UserID, @binid)";
                            using (SqlCommand updateProcessTable = new SqlCommand(processTableUpdate, conn))
                            {
                                //foreach (var user in userCount)
                                {
                                    SqlParameter userid = new SqlParameter("@UserID", SqlDbType.TinyInt);
                                    SqlParameter binid = new SqlParameter("@binid", SqlDbType.Int);
                                    userid.Value = xqtyTextBox.Text;
                                    binId.Value = binid;
                                    updateBinTable.Parameters.Add(xqty);
                                    updateBinTable.Parameters.Add(binId);
                                    updateBinTable.CommandType = CommandType.Text;
                                    updateBinTable.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    catch (Exception)
                    {
                        MessageBox.Show("Failed to Start Processing");
                    }
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Entries Failed Validation");
            }

        }

        public void mWJobComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            jobid = mWJobComboBox.SelectedValue;
            int jobnumber = Convert.ToInt32(jobid);
            FillBinComboBox(jobnumber);
        }

        private void mWBinComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            binid = mWBinComboBox.SelectedValue;
        }

        private void mWUser1ComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            userOneID = mWUser1ComboBox.SelectedIndex;
        }

        private void mWUser2ComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            userTwoID = mWUser2ComboBox.SelectedIndex;
        }

        public void CountUsers()
        {
            userCount = 0;
            if (userOneID != 0 && userTwoID != 0)
            {
                userCount = 2;
            }
            else if (userOneID != 0 && userTwoID == 0)
            {
                userID = mWUser1ComboBox.SelectedIndex;
                userCount = 1;
            }
            else
            {
                userID = mWUser2ComboBox.SelectedIndex;
                userCount = 1;
            }

            //TODO: Set up array to get the number of users to cycle through insert statement.
            //int[] users = new int[userCount] users; 
        }

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

