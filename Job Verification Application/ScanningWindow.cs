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
        private object binid;

        public DataTable Sequence { get; private set; }

        public ScanningWindow()
        {
            InitializeComponent();
        }

        public ScanningWindow(object binid)
        {
            this.binid = binid;
        }

        private void ScanningWindow_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }
        public DataTable LoadDataGrid()
        {
            Connection_Query con = Connection_Query.INSTANCE;
            SqlConnection conn = con.con;
            try
            {
                conn.Open();
                SqlCommand cmdload = new SqlCommand("select FK_JobID as JobNumber, Index as SequenceNumber, ScanDateTime " +
                    "from SEQUENCE, BIN WHERE BinID = FK_BinID AND BinID = @BinID", conn);
                SqlParameter BinId = new SqlParameter("@BinID", SqlDbType.Int);
                BinId.Value = binid;
                DataTable Sequence = new DataTable();
                Sequence.Load(cmdload.ExecuteReader());    
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
            return Sequence;
        }
    }
}
