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
using System.Text.RegularExpressions;
using System.IO;

namespace LoginForm
{
    public partial class SignUp : Form
    {
      

        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
          
           
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate if all the fields are filled
            if (string.IsNullOrWhiteSpace(txtFirstName.Text)|| 
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtMiddleName.Text)||
                string.IsNullOrWhiteSpace(txtPassword.Text)||
                string.IsNullOrWhiteSpace(txtUserName.Text)||
                string.IsNullOrWhiteSpace(cmbSex.Text)||
                string.IsNullOrWhiteSpace(dtpDob.Text))

            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            //validate profile picture

            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please select a profile picture");
                return;
            }


            // Collect Data form form fields
            string FirstName = txtFirstName.Text;
            string LastName = txtLastName.Text;
            string MiddleName = txtMiddleName.Text;
            string Username = txtUserName.Text;
            string Password = txtPassword.Text;
            string Sex = cmbSex.Text;
            string dateOfBirth = dtpDob.Text;
            char[] DateOfBirth = dateOfBirth.ToCharArray();

            // save profile picture to sql
            byte[] imageBytes = null;

            if (pictureBox1.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imageBytes = ms.ToArray();
                }
            }
           

            // Create SQL connection and command
            using (SqlConnection conn = new SqlConnection(@"Data Source=MANDEL\SQLEXPRESS;Initial Catalog=MandelDb;Integrated Security=True"))
            {
                string querry = "INSERT INTO login (UserName, Password, Sex, Date_of_Birth, FirstName, Lastname, MiddleName, ProfilePicture) VALUES (@UserName, @Password, @Sex, @Date_of_Birth, @FirstName, @Lastname, @MiddleName, @ProfilePicture)";
               
                SqlCommand cmd = new SqlCommand(querry, conn);
                cmd.Parameters.AddWithValue("@UserName", Username);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@Sex", Sex);
                cmd.Parameters.AddWithValue("@Date_of_Birth", DateOfBirth);
                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@LastName", LastName);
                cmd.Parameters.AddWithValue("@MiddleName", MiddleName);
                cmd.Parameters.AddWithValue("@ProfilePicture", imageBytes);
               

                // Open the connection and execute the command

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registration Successful!");
                        LoginForm form1 = new LoginForm();
                        form1.Show();
                        this.Hide();
                    }
                    else 
                    {
                        MessageBox.Show("Registration Failed!");
                    }
                   
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error:" + ex.Message);
                }

               

            }
           
        }


        private void ClearForm()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtMiddleName.Text = "";
            txtPassword.Text = "";
            txtUserName.Text = "";
            cmbSex.Text = "";
            dtpDob.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to Login", "Login", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                LoginForm form1 = new LoginForm();
                form1.Show();
                this.Hide();
            }

            else
            {
                this.Show();
            }

        }

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

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            // Open file dialog to select image
            OpenFileDialog openFile = new OpenFileDialog ();
            openFile.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.bmp) |*.jpg;*.jpeg;*.png;*.bmp";
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFile.FileName);

              
               
            }

        }
    }
}
