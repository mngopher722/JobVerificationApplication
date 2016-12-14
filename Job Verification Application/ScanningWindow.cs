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
            LoadDataGrid();
        }

        public ScanningWindow(object binid)
        {
            this.binid = binid;
            InitializeComponent();
            LoadDataGrid();
        }

        private void ScanningWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jobVerificationDataSet.SEQUENCE' table. You can move, or remove it, as needed.
            //this.sEQUENCETableAdapter.Fill(this.jobVerificationDataSet.SEQUENCE);        

        }
        [STAThread]
        private void LoadDataGrid()
        { 
            Connection_Query con = Connection_Query.INSTANCE;
            con.OpenConnection();
            SqlConnection conn = con.con;
            try
            {
                SqlCommand cmdload = new SqlCommand("select FK_JobID as JobNumber, [dbo].[SEQUENCE].[Index] as SequenceNumber, ScanDateTime " +
                    "from SEQUENCE, BIN WHERE BinID = FK_BinID AND BinID = @BinID", conn);
                SqlParameter BinId = new SqlParameter("@BinID", SqlDbType.Int);
                BinId.Value = binid;
                cmdload.Parameters.Add(BinId);
                SqlDataAdapter datagridview = new SqlDataAdapter(cmdload);
                DataTable Sequence = new DataTable();
                using (SqlDataReader sqldr = cmdload.ExecuteReader())
                {
                    Sequence.Load(sqldr);
                    sqldr.Close();
                }
                DataGridView dataGridView1 = new DataGridView();
                dataGridView1.DataSource = datagridview.FillSchema(Sequence, SchemaType.Source);
                BindingSource bs = new BindingSource();
                datagridview.Fill(Sequence);
                sWJobDataGrid.DataSource = Sequence;
                //sWJobDataGrid.DataMember = Sequence.Table[0];
                //Sequence.Load(cmdload.ExecuteReader());    
            }
            catch (Exception ex)
            {
                //Exception Message
                MessageBox.Show("Connection to the database has quit. Please reload Database" + ex.Message + " " + ex.StackTrace);
            }
            finally
            {
                con.CloseConnection();
                conn.Dispose();
            }
        }

        private void sWSubmitButton_Click(object sender, EventArgs e)
        {
            int bin = Convert.ToInt32(binid);
            Connection_Query con = Connection_Query.INSTANCE;
            con.OpenConnection();
            SqlConnection conn = con.con;
            try
            {
                string processTableUpdate = "INSERT into SEQUENCE(FK_BinID, [dbo].[SEQUENCE].[INDEX], ScanDateTime) VALUES(@binid, @[Index], @ScanDT)";
                using(SqlCommand updateProcessTable = new SqlCommand(processTableUpdate, conn))
                {
                    SqlParameter BinId = new SqlParameter("@binid", SqlDbType.Int);
                    SqlParameter indx = new SqlParameter("@[Index]", SqlDbType.Int);
                    SqlParameter scan = new SqlParameter("@ScanDT", SqlDbType.DateTime);
                    BinId.Value = bin;
                    indx.Value = sequenceMaskedTextBox.Text;
                    scan.Value = DateTime.Now.ToLocalTime();
                    updateProcessTable.Parameters.Add(BinId);
                    updateProcessTable.Parameters.Add(indx);
                    updateProcessTable.Parameters.Add(scan);
                    updateProcessTable.CommandType = CommandType.Text;
                    updateProcessTable.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                //Exception Message
                MessageBox.Show("Connection to the database has quit. Please reload Database" + ex.Message + " " + ex.StackTrace);
            }
            finally
            {
                con.CloseConnection();
                conn.Dispose();
            }
        }
    }
}
