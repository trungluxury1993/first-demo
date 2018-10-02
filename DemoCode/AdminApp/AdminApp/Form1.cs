using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminApp
{
    public partial class Form1 : Form
    {
        public Staff user = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            lg.ShowDialog();
            user = lg.currentUser;
            this.Text = "Welcome to : "+user.UserName;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add new sucesss");
        }

        private void rtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtD_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtC_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtContent_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdD_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
