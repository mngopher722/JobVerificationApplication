using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Verification_Application
{
    public class Validation
    {
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
            //properFName = ConvertTo_ProperCase(uWFirstNameTextBox.Text);
            //properLName = ConvertTo_ProperCase(uWLastNameTextBox.Text);
            duplicateUser = true;
            string cmdcheck = "select count (*) FROM dbo.[USER] where UserFName = @FirstName and UserLName = @LastName";
            using (SqlConnection conn = new SqlConnection(@"Data Source=MHDC2\SQLEXPRESS2014;Initial Catalog=JobVerification;User ID=Ticketmaster"))
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
    }
}
