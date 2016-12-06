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
    public partial class ScanningWindow : Form
    {
        //string conString = @"Data Source=LENOVO-PC\SQLEXPRESS;Initial Catalog=JobVerification";
        string conString = @"Data Source=MHDC2\SQLEXPRESS2014;Initial Catalog=JobVerification;User ID=Ticketmaster";
        public ScanningWindow()
        {
            InitializeComponent();
        }

        private void ScanningWindow_Load(object sender, EventArgs e)
        {
            
        }
        protected void FillDataGrid()
        {
            
            SqlConnection conn = new SqlConnection(conString);
            DataTable jxb = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmdjxb = new SqlCommand("select FK_JobID_X_BinID as Bin_Number, FK_SequenceID as Sequence_Number, ScanDateTime " +
                    "from SEQUENCE_X_BIN, JOB_X_BIN WHERE FK_JobID_X_BinID  = JobID_X_BinID", conn);
                SqlDataAdapter job = new SqlDataAdapter();
                job.SelectCommand = cmdjxb;
                job.Fill(jxb);

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
