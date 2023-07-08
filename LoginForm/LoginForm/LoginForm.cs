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

namespace LoginForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=MANDEL\SQLEXPRESS;Initial Catalog=MandelDb;Integrated Security=True");

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }

            else
            {
                this.Show();
            }
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username, user_password;

            username = txtUserName.Text;
            user_password = txtPassword.Text;

            try
            {
                String Querry = "SELECT * FROM  login  WHERE UserName = '"+txtUserName.Text+"' and Password = '"+txtPassword.Text+"' ";
                SqlDataAdapter sda = new SqlDataAdapter(Querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = txtUserName.Text;
                    user_password = txtPassword.Text;

                    //page that needed to be load next
                    Main form1 = new Main();
                    form1.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Invalid Login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Clear();
                    txtPassword.Clear();

                    // To focus username
                    txtUserName.Focus();

                }
            }

            catch 
            {

                MessageBox.Show("Invalid Username or Password");
            }

            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Are you sure?", "Create Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                SignUp form1 = new SignUp();
                form1.Show();
                this.Hide();
            }

            else
            {
                this.Show();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult clr;
            clr = MessageBox.Show("Are you sure", "Clear", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (clr == DialogResult.Yes)
            {

                txtUserName.Clear();
                txtPassword.Clear();

                txtUserName.Focus();
            }

            else if (clr != DialogResult.Yes)
            {
                
            }

            txtUserName.Clear();
            txtPassword.Clear();

            txtUserName.Focus();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

      
    }
}
