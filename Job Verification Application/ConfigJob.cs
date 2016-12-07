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
        //string conString = @"Data Source=LENOVO-PC\SQLEXPRESS;Initial Catalog=JobVerification; User ID=Ryan; Integrated Security = True";
        string conString = @"Data Source=MHDC2\SQLEXPRESS2014;Initial Catalog=JobVerification;User ID=Ticketmaster";
        public bool validjob { get; private set; }
        public bool validbin { get; private set; }
        public int jobID { get; set; }
        public int binID { get; set; }
        public int jobnumber { get; private set; }



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
            SqlConnection conn = new SqlConnection(conString);
            DataSet jobnum = new DataSet();
            //DataSet binnum = new DataSet();
            GetBinNumbers();
            try
            {
                conn.Open();
                SqlCommand cmdJob = new SqlCommand("select JobID from dbo.[JOB]", conn);
                //SqlCommand cmdBin = new SqlCommand("select BinID from BIN", conn);
                SqlDataAdapter job = new SqlDataAdapter();
                //SqlDataAdapter bin = new SqlDataAdapter();
                job.SelectCommand = cmdJob;
                //bin.SelectCommand = cmdBin;
                job.Fill(jobnum);
                //bin.Fill(binnum);
                cfgWJobNumComboBox.DisplayMember = "JobID";
                cfgWJobNumComboBox.ValueMember = "JobID";
                cfgWJobNumComboBox.DataSource = jobnum.Tables[0];
                //cfgWBinNumComboBox.DisplayMember = "BinID";
                //cfgWBinNumComboBox.ValueMember = "BinID";
                //cfgWBinNumComboBox.DataSource = binnum.Tables[0];

            }
            catch (Exception ex)
            {
                //Exception Message
                MessageBox.Show("Connection to the database has quit. Please reload Database" + ex.Message +ex.StackTrace);
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

            //if (jobID)
            if(jobID != 0 && binID != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void cfgWSubmitButton_Click(object sender, EventArgs e)
        {
            StringCollection sc = new StringCollection();
            int insertingbin;
            if (Validate(jobnumber , cfgWBinNumComboBox.SelectedIndex))
            {
                for (insertingbin = 1; insertingbin <= binID + 1; insertingbin++ )
                {    
                    try
                    {
                        string cmdAdd = "INSERT into BIN (FK_JobID, [dbo].[BIN].[Index], Completed) VALUES (@FK_JobID, @BinIndex, @BinCompleted)";
                        using (SqlConnection conn = new SqlConnection(conString))
                        using (SqlCommand dataAdd = new SqlCommand(cmdAdd, conn))
                        {
                            conn.Open();
                            SqlParameter jobid = new SqlParameter("@FK_JobID", SqlDbType.Int);
                            SqlParameter binid = new SqlParameter("@BinIndex", SqlDbType.TinyInt);
                            SqlParameter comp = new SqlParameter("@BinCompleted", SqlDbType.Bit);
                            jobid.Value = jobnumber;
                            binid.Value = insertingbin;
                            comp.Value = false;

                            dataAdd.Parameters.Add(jobid);
                            dataAdd.Parameters.Add(binid);
                            dataAdd.Parameters.Add(comp);
                            dataAdd.CommandType = CommandType.Text;

                            dataAdd.ExecuteNonQuery();
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to Add Configuration to Database" +ex.StackTrace +ex.Message);
                        
                        return;
                        this.Close();
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
            jobID = cfgWJobNumComboBox.SelectedIndex + 1;
            jobnumber = Convert.ToInt32(cfgWJobNumComboBox.SelectedValue);
        }

        private void cfgWBinNumComboBox_Leave(object sender, EventArgs e)
        {
            binID = cfgWBinNumComboBox.SelectedIndex;
        }

        public void GetBinNumbers()
        {
            var bins = new Dictionary<int,int>();
            int b;
            for (b = 1; b < 26; b++)
            {
                bins[b] = b;
            }
            cfgWBinNumComboBox.DataSource = new BindingSource(bins, null);
            cfgWBinNumComboBox.DisplayMember = "Value";
            cfgWBinNumComboBox.ValueMember = "Key";
        }
    }
}
