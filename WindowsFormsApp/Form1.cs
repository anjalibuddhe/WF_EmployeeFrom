using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if(textUser.Text=="Admin" && textPassword.Text == "Admin123")
            {
                MessageBox.Show("Logine Success");
            }
            else
            {
                MessageBox.Show("Login failed");
            }
            

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            textUser.Clear();
            textPassword.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
