using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginForm
{
    public partial class Main : Form
    {
        

        public Main()
        {
            InitializeComponent();
           
           
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Retrieve user details from the database based on the Username
                
               
            }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm form1 = new LoginForm();
                form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUp form1 = new SignUp();
            form1.Show();
            this.Hide();
        }
    }
    }

    
