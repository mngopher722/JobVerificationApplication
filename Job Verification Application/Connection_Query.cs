using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Verification_Application
{
    public class Connection_Query
    {
        //private static string CONNECTION_STRING_DEVELOPMENT = @"Data Source=LENOVO-PC\SQLEXPRESS;Initial Catalog=JobVerification; User ID=Ryan; Integrated Security = True";
        private static string CONNECTION_STRING_PRODUCTION = @"Data Source=MHDC2\SQLEXPRESS2014;Initial Catalog=JobVerification;User ID=Ticketmaster";
        public static Connection_Query INSTANCE { get; } = new Connection_Query();
        private string ConnectionString = CONNECTION_STRING_PRODUCTION;
        public SqlConnection con { get; set; }

        public Connection_Query()
        {
            con = new SqlConnection(ConnectionString);
        }

        public void OpenConnection()
        {
            con.Open();
        }
        public void CloseConnection()
        {
            con.Close();
            con = new SqlConnection(ConnectionString);
        }
        public void ExecuteQueries(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            cmd.ExecuteNonQuery();
        }
        public SqlDataReader DataReader(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public object ShowDataInGridView(string Query_)
        {
            SqlDataAdapter dr = new SqlDataAdapter(Query_, ConnectionString);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }
    }
}
