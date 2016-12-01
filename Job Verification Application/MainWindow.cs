using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Verification_Application
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jobVerificationDataSet.JOB_X_BIN' table. You can move, or remove it, as needed.
            this.jOB_X_BINTableAdapter.Fill(this.jobVerificationDataSet.JOB_X_BIN);
            // TODO: This line of code loads data into the 'jobVerificationDataSet.USER' table. You can move, or remove it, as needed.
            this.uSERTableAdapter.Fill(this.jobVerificationDataSet.USER);
            // TODO: This line of code loads data into the 'jobVerificationDataSet.JOB' table. You can move, or remove it, as needed.
            this.jOBTableAdapter.Fill(this.jobVerificationDataSet.JOB);
            // TODO: This line of code loads data into the 'jobVerificationDataSet.BIN' table. You can move, or remove it, as needed.
            this.bINTableAdapter.Fill(this.jobVerificationDataSet.BIN);

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
    }
}
