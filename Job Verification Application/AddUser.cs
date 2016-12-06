using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Job_Verification_Application
{
    public partial class AddUser : Form
    {
        string conString = @"Data Source=LENOVO-PC\SQLEXPRESS;Initial Catalog=JobVerification; User ID=Ryan; Integrated Security = True";
        public AddUser()
        {
            InitializeComponent();
        }

        public string firstname { get; private set; }
        public bool validtextbox { get; private set; }
        public string lastname { get; private set; }
        public bool notempty { get; private set; }
        public bool validentry { get; private set; }
        public bool duplicateUser { get; private set; }
        public string properFName { get; private set; }
        public string properLName { get; private set; }

        public static string ConvertTo_ProperCase(string text)
        {
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            return myTI.ToTitleCase(text.ToLower());
        }
        public bool IsAlpha(string input)
        {
            validtextbox = false;
            if (!Regex.IsMatch(input, "^[a-zA-Z]+$"))
            {
                MessageBox.Show("Textbox only accepts characters A-Z");
                validtextbox = false;
            }
            else
            {
                validtextbox = true;
            }
            return Regex.IsMatch(input, "^[a-zA-Z]+$");
        }
        public bool NotEmpty(string input)
        {
            notempty = false;
            if (input.Length == 0)
            {
                MessageBox.Show("Please Enter User's Name");
            }
            else
            {
                notempty = true;
            }

            return notempty;
        }
        public bool ValidateEntry(string input)
        {
            NotEmpty(input);
            IsAlpha(input);
            validentry = false;
            if (notempty && validtextbox)
            {
                validentry = true;
            }
            else
            {
                MessageBox.Show("This is not a valid entry");
            }
            return validentry;
        }
        public bool DuplicateUser()
        {
            properFName = Validation.ConvertTo_ProperCase(uWFirstNameTextBox.Text);
            properLName = Validation.ConvertTo_ProperCase(uWLastNameTextBox.Text);
            duplicateUser = true;
            string cmdcheck = "select count (*) FROM dbo.[USER] where UserFName = @FirstName and UserLName = @LastName";
            //using (SqlConnection conn = new SqlConnection(@"Data Source=MHDC2\SQLEXPRESS2014;Initial Catalog=JobVerification;User ID=Ticketmaster"))
            using (SqlConnection conn = new SqlConnection(conString))
            using (SqlCommand datacheck = new SqlCommand(cmdcheck, conn))
            {
                conn.Open();
                SqlParameter fname = new SqlParameter("@FirstName", SqlDbType.NVarChar, 25);
                SqlParameter lname = new SqlParameter("@LastName", SqlDbType.NVarChar, 25);
                fname.Value = properFName;
                lname.Value = properLName;

                datacheck.Parameters.Add(fname);
                datacheck.Parameters.Add(lname);
                int result = (int)datacheck.ExecuteScalar();

                if (result > 0)
                {
                }
                else
                {
                    duplicateUser = false;
                }
                return duplicateUser;
            }
        }

        private void uWFirstNameTextBox_Leave(object sender, EventArgs e)
        {
            ValidateEntry(uWFirstNameTextBox.Text);
            if(!validentry)
            {
                uWFirstNameTextBox.Clear();
            }
            else
            {
                firstname = uWFirstNameTextBox.Text;
            }
            
        }

        private void uWCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uWLastNameTextBox_Leave(object sender, EventArgs e)
        {
            ValidateEntry(uWLastNameTextBox.Text);
            if (!validentry)
            {
                uWLastNameTextBox.Clear();
            }
            else
            {
                lastname = uWLastNameTextBox.Text;
            }
        }

        private void uWSubmitButton_Click(object sender, EventArgs e)
        {
            DuplicateUser();
            if(validentry && !duplicateUser)
            {
                try
                {
                    string cmdAdd = "INSERT into dbo.[USER](UserFName, UserLName) VALUES (@FirstName, @LastName)";
                    using (SqlConnection conn = new SqlConnection(conString))
                    using (SqlCommand dataAdd = new SqlCommand(cmdAdd, conn))
                    {
                        conn.Open();
                        SqlParameter fname = new SqlParameter("@FirstName", SqlDbType.NVarChar, 25);
                        SqlParameter lname = new SqlParameter("@LastName", SqlDbType.NVarChar, 25);
                        fname.Value = properFName;
                        lname.Value = properLName;

                        dataAdd.Parameters.Add(fname);
                        dataAdd.Parameters.Add(lname);
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
            else if(validentry && duplicateUser)
            {
                MessageBox.Show("User Already Exists in Database");
            }
            else
            {
                MessageBox.Show("User Input Failed Validation");
            }
        }      
    }
}
