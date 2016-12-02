using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    public partial class ConfigJob : Form
    {
        public bool validjob { get; private set; }
        public bool validbin { get; private set; }
        public int jobID { get; set; }
        public int binID { get; set; }
        public bool validSelection { get; private set; }

        public ConfigJob()
        {
            InitializeComponent();
        }

        private void ConfigJob_Load(object sender, EventArgs e)
        {
            FillComboBox();
        }

        protected void FillComboBox()
        {
            string conString = @"Data Source=MHDC2\SQLEXPRESS2014;Initial Catalog=JobVerification;User ID=Ticketmaster";
            SqlConnection conn = new SqlConnection(conString);
            DataSet jobnum = new DataSet();
            DataSet binnum = new DataSet();
            try
            {
                conn.Open();
                SqlCommand cmdJob = new SqlCommand("select JobID from dbo.[JOB]", conn);
                SqlCommand cmdBin = new SqlCommand("select BinID from BIN", conn);
                SqlDataAdapter job = new SqlDataAdapter();
                SqlDataAdapter bin = new SqlDataAdapter();
                job.SelectCommand = cmdJob;
                bin.SelectCommand = cmdBin;
                job.Fill(jobnum);
                bin.Fill(binnum);
                cfgWJobNumComboBox.DisplayMember = "JobID";
                cfgWJobNumComboBox.ValueMember = "JobID";
                cfgWJobNumComboBox.DataSource = jobnum.Tables[0];
                cfgWBinNumComboBox.DisplayMember = "BinID";
                cfgWBinNumComboBox.ValueMember = "BinID";
                cfgWBinNumComboBox.DataSource = binnum.Tables[0];

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

        private void cfgWCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool Validate(int jobID, int binID)
        {
            //int jobID;
            //int binID;
            validSelection = false;
            if(jobID != 0 && binID != 0)
            {
                validSelection = true;
            }
            else
            {
                validSelection = false;
            }
            return validSelection;
        }

        private void cfgWSubmitButton_Click(object sender, EventArgs e)
        {
            StringCollection sc = new StringCollection();
            int insertingbin;
            Validate(cfgWJobNumComboBox.SelectedIndex, cfgWBinNumComboBox.SelectedIndex);            
            if (validSelection)
            {
                for (insertingbin = 1; insertingbin <= binID; insertingbin++ )
                {    
                    try
                    {
                        string cmdAdd = "INSERT into JOB_X_BIN (FK_JobID, FK_BinID) VALUES (@FK_JobID, @FK_BinID)";
                        using (SqlConnection conn = new SqlConnection(@"Data Source=MHDC2\SQLEXPRESS2014;Initial Catalog=JobVerification;User ID=Ticketmaster"))
                        using (SqlCommand dataAdd = new SqlCommand(cmdAdd, conn))
                        {
                            conn.Open();
                            SqlParameter jobid = new SqlParameter("@FK_JobID", SqlDbType.Int);
                            SqlParameter binid = new SqlParameter("@FK_BinID", SqlDbType.TinyInt);
                            jobid.Value = jobID;
                            binid.Value = insertingbin;

                            dataAdd.Parameters.Add(jobid);
                            dataAdd.Parameters.Add(binid);
                            dataAdd.CommandType = CommandType.Text;

                            dataAdd.ExecuteNonQuery();
                            this.Close();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Failed to Add User to Database");
                    }
                }
            }
            else
            {
                MessageBox.Show("User Input Failed Validation");
            }
        }

        private void cfgWJobNumComboBox_Leave(object sender, EventArgs e)
        {
            jobID = cfgWJobNumComboBox.SelectedIndex;
        }

        private void cfgWBinNumComboBox_Leave(object sender, EventArgs e)
        {
            binID = cfgWBinNumComboBox.SelectedIndex;
        }
    }
}
